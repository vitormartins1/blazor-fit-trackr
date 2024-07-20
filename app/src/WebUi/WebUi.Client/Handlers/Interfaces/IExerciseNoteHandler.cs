using FitTrackr.WebUi.Shared.ExerciseNotes;

namespace FitTrackr.WebUi.Client.Handlers.Interfaces;

public interface IExerciseNoteHandler
{
    Task<ExerciseNotesVm> GetExerciseNotesAsync();
    //Task PutExerciseNoteAsync(int id, UpdateExerciseNoteRequest request);
    Task<int> PostExerciseNoteAsync(CreateExerciseNoteRequest request);
}