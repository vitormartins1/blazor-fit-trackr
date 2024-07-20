using System.ComponentModel.DataAnnotations.Schema;

namespace FitTrackr.Domain.Entities;

[ComplexType]
public record RepetitionSet(
    string Set,
    string RepetitionMin,
    string RepetitionMax);
