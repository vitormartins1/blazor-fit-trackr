using FitTrackr.Application.ExerciseNotes.Commands;
using FitTrackr.Application.ExerciseNotes.Queries;
using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using MediatR;

namespace FitTrackr.WebUi.Client.Handlers.ServerImplementation;

internal class ExerciseNotesServerHandler : IExerciseNoteHandler
{
    private IMediator _mediator;

    public ExerciseNotesServerHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<ExerciseNotesVm> GetExerciseNotesAsync()
    {
        return _mediator.Send(new GetExerciseNotesQuery());
    }

    public Task<int> PostExerciseNoteAsync(CreateExerciseNoteRequest request)
    {
        return _mediator.Send(new CreateExerciseNoteCommand(request));
    }
}
