using Microsoft.EntityFrameworkCore;
using RNotes.Application.Interfaces;
using RNotes.Domain;
using RNotes.Persistence.EntityTypeConfigurations;

namespace RNotes.Persistence;

public class NotesDbContext : DbContext, INotesDbContext
{
    public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new NoteConfiguration());
        base.OnModelCreating(builder);
    }
}