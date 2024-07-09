using FitTrackr.Domain.Entities;
using FitTrackr.WebUi.Shared.TodoLists;
using Riok.Mapperly.Abstractions;

namespace FitTrackr.Application.TodoLists;

[Mapper]
public static partial class Mapping
{
    public static partial IQueryable<TodoListDto> ProjectToDto(this IQueryable<TodoList> s);
}
