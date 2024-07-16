using FitTrackr.Domain.Entities;
using FitTrackr.WebUi.Shared.ExerciseNotes;
using Riok.Mapperly.Abstractions;

namespace FitTrackr.Application.ExerciseNotes;

[Mapper]
public static partial class Mapping
{
    public static partial IQueryable<ExerciseNoteDto> ProjectToDto(this IQueryable<ExerciseNote> s);
}
