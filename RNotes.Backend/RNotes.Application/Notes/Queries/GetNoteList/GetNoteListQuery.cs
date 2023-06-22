﻿using MediatR;

namespace RNotes.Application.Notes.Queries.GetNoteList;

public class GetNoteListQuery : IRequest<NoteListVm>
{
    public Guid UserId { get; set; }
}