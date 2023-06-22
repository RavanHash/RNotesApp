using FluentValidation;

namespace RNotes.Application.Notes.Queries.GetNoteList;

public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
{
    public GetNoteListQueryValidator()
    {
        RuleFor(x => x.UserId).NotEqual(Guid.Empty);
    }
}