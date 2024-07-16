using FitTrackr.Application.Common.Services.Data;
using FitTrackr.Domain.Entities;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using FluentValidation;

namespace FitTrackr.Application.ExerciseNotes.Commands;

public sealed record CreateExerciseNoteCommand(CreateExerciseNoteRequest ExerciseNote) : IRequest<int>;

public sealed class CreateExerciseNoteCommandValidator : AbstractValidator<CreateExerciseNoteCommand>
{
    public CreateExerciseNoteCommandValidator()
    {
        RuleFor(p => p.ExerciseNote).SetValidator(new CreateExerciseNoteRequestValidator());
    }
}

public sealed class CreateExerciseNoteCommandHandler : IRequestHandler<CreateExerciseNoteCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateExerciseNoteCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateExerciseNoteCommand request, CancellationToken cancellationToken)
    {
        ExerciseNote entity = new()
        {
            Name = request.ExerciseNote.Name,
            Description = request.ExerciseNote.Description
        };

        _context.ExerciseNotes.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}