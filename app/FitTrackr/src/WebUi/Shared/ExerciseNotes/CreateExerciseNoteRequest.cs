using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrackr.WebUi.Shared.ExerciseNotes;

public class CreateExerciseNoteRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class CreateExerciseNoteRequestValidator
    : AbstractValidator<CreateExerciseNoteRequest>
{
    public CreateExerciseNoteRequestValidator()
    {
        RuleFor(v => v.Name)
            .MaximumLength(240)
            .NotEmpty();

        RuleFor(v => v.Description)
            .NotEmpty();
    }
}
