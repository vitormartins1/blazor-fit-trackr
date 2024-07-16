using FitTrackr.Application.ExerciseNotes.Commands;
using FitTrackr.Application.ExerciseNotes.Queries;
using FitTrackr.WebUi.Shared.Authorization;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using Microsoft.AspNetCore.Mvc;

namespace FitTrackr.WebUi.Controllers;

[Authorize(Permissions.Exercices)]
public class ExerciseNotesController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ExerciseNotesVm>> GetExerciseNotes()
    {
        return await Mediator.Send(new GetExerciseNotesQuery());
    }

    [HttpPost]
    public async Task<ActionResult<int>> PostExerciseNote(CreateExerciseNoteRequest request)
    {
        return await Mediator.Send(new CreateExerciseNoteCommand(request));
    }
}