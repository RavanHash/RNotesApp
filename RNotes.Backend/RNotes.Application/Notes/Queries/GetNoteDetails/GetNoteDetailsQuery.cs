using MediatR;

namespace RNotes.Application.Notes.Queries.GetNoteDetails;

public class GetNoteDetailsQuery : IRequest<NoteDetailsVm>
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}