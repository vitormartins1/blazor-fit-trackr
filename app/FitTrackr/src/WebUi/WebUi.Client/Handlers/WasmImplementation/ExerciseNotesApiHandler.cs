using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.ExerciseNotes;

namespace FitTrackr.WebUi.Client.Handlers.WasmImplementation;

internal class ExerciseNotesApiHandler : IExerciseNoteHandler
{
    private IExerciseNotesClient _exerciseNotesClient;

    public ExerciseNotesApiHandler(IExerciseNotesClient exerciseNotesClient)
    {
        _exerciseNotesClient = exerciseNotesClient;
    }

    public Task<ExerciseNotesVm> GetExerciseNotesAsync()
    {
        return _exerciseNotesClient.GetExerciseNotesAsync();
    }

    public Task<int> PostExerciseNoteAsync(CreateExerciseNoteRequest request)
    {
        return _exerciseNotesClient.PostExerciseNoteAsync(request);
    }
}
