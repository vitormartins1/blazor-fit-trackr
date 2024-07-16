using FitTrackr.Application.Common.Services.Data;
using FitTrackr.WebUi.Shared.ExerciseNotes;

namespace FitTrackr.Application.ExerciseNotes.Queries;

public sealed record GetExerciseNotesQuery : IRequest<ExerciseNotesVm>;

public class GetExerciseNotesQueryHandler : IRequestHandler<GetExerciseNotesQuery, ExerciseNotesVm>
{
    private readonly IApplicationDbContext _context;

    public GetExerciseNotesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ExerciseNotesVm> Handle(
        GetExerciseNotesQuery request, 
        CancellationToken cancellationToken)
    {
        return new ExerciseNotesVm
        {
            ExerciceNotes = await _context.ExerciseNotes
                .ProjectToDto()
                .ToListAsync(cancellationToken)
        };
    }
}