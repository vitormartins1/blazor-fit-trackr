using FitTrackr.WebUi.Client.Components;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FitTrackr.WebUi.Client.Pages.ExerciseNotes;

public partial class AddEditExerciseNoteDialog
{
    [CascadingParameter] MudDialogInstance MudDialog { get; set; } = default!;
    [Parameter] public ExerciseNoteDto ExerciseNote { get; set; } = new();
    [Parameter] public ExerciseNotesVm State { get; set; } = default!;

    private ExerciseNoteDto _exerciseNote = new();
    private CustomValidation _customValidation = default!;
    private MudTextField<string> _nameInput = default!;
    private MudTextField<string> _descriptionInput = default!;

    protected override void OnInitialized()
    {
        if (ExerciseNote != null)
        {
            _exerciseNote = ExerciseNote;
        }
    }

    private void Cancel()
    {
        MudDialog.Cancel();
    }

    private async Task Save()
    {
        if (_exerciseNote.Id == 0)
        {
            var request = new CreateExerciseNoteRequest { Name = _exerciseNote.Name, Description = _exerciseNote.Description };
            // await ExerciseNoteHandler.CreateExerciseNoteAsync(request);
        }
        else
        {
            // Implementar a lógica de atualização aqui
        }

        MudDialog.Close(DialogResult.Ok(true));
    }
}
