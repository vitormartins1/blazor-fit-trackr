using FitTrackr.WebUi.Client.Handlers.Interfaces;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using Microsoft.AspNetCore.Components;

namespace FitTrackr.WebUi.Client.Pages.ExerciseNotes;

public partial class ExerciseNotes
{
    [Parameter] public RenderFragment ChildContent { get; set; } = default!;
    [Inject] public IExerciseNoteHandler ExerciseNoteHandler { get; set; } = default!;

    public ExerciseNotesVm? Model { get; set; }

    public bool Initialized { get; private set; }

    protected override async Task OnInitializedAsync()
    {
        Model = await ExerciseNoteHandler.GetExerciseNotesAsync();
        Initialized = true;
    }
}
