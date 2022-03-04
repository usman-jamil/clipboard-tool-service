using System;
using System.Linq;
using ClipBoard.Data;
using ClipBoard.Domain;


namespace ClipBoard
{
    class Program
    {
        private static Context _context = new Context();
        static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
            AddClip("Hello", "This is note");
            AddResource("File", "Filepath");
        }
        private static void AddClip(string Title, string Note)
        {

            var newClip = new Clip { Title = Title, Note = Note };
            _context.Clips.Add(newClip);
            _context.SaveChanges();
            Console.WriteLine("Data base AddResource ");
        }
        //-----------add resource-----------
        private static void AddResource(string Filename, string Filepath)
        {
            var newClip = new Clip { Note = "Note", Title = "Title" };
            var newrsc = new Resource { Filename = Filename, FilePath = Filepath };
            _context.Clips.Add(newClip);
            newClip.Resources.Add(newrsc);
            _context.SaveChanges();
            Console.WriteLine("Data base AddResource ");
        }
    }
}
