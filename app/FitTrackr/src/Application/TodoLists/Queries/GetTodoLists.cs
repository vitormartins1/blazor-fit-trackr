using FitTrackr.Application.Common.Services.Data;
using FitTrackr.Domain.Enums;
using FitTrackr.WebUi.Shared.Common;
using FitTrackr.WebUi.Shared.TodoLists;

namespace FitTrackr.Application.TodoLists.Queries;

public sealed record GetTodoListsQuery : IRequest<TodosVm>;

public class GetTodoListQueryHandler : IRequestHandler<GetTodoListsQuery, TodosVm>
{
    private readonly IApplicationDbContext _context;

    public GetTodoListQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TodosVm> Handle(GetTodoListsQuery request, 
        CancellationToken cancellationToken)
    {
        return new TodosVm
        {
            PriorityLevels = PriorityLevelExtensions.GetValues()
                .Select(p => new LookupDto { Id = (int)p, Title = p.ToStringFast() })
                .ToList(),
            Lists = await _context.TodoLists
                .ProjectToDto()
                .ToListAsync(cancellationToken)
        };
    }
}
