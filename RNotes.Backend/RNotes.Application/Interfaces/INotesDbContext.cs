using Microsoft.EntityFrameworkCore;
using RNotes.Domain;

namespace RNotes.Application.Interfaces;

public interface INotesDbContext
{
    DbSet<Note> Notes { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}