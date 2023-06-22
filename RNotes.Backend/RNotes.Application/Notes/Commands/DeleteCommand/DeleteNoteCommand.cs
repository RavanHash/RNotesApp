using MediatR;

namespace RNotes.Application.Notes.Commands.DeleteCommand;

public class DeleteNoteCommand : IRequest
{
    public Guid UserId { get; set; }
    public Guid Id { get; set; }
}