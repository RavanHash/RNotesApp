﻿using MediatR;
using RNotes.Application.Common.Exceptions;
using RNotes.Application.Interfaces;
using RNotes.Application.Notes.Commands.DeleteCommand;
using RNotes.Domain;

namespace RNotes.Application.Notes.Commands.UpdateNote;

public class DeleteNoteCommandHandler : IRequestHandler<DeleteNoteCommand>
{
    private readonly INotesDbContext _dbContext;

    public DeleteNoteCommandHandler(INotesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Notes
            .FindAsync(new object[] {request.Id}, cancellationToken);

        if (entity == null || entity.UserId != request.UserId) throw new NotFoundException(nameof(Note), request.Id);

        _dbContext.Notes.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}