using System;
using System.IO;

namespace Events
{
    public class FileFoundArgs : EventArgs
    {
        public string FoundFile { get; }
        public bool CancelRequested { get; set; }

        public FileFoundArgs(string fileName)
        {
            FoundFile = fileName;
        }
    }

    public class FileSearcher
    {
        public event EventHandler<FileFoundArgs> FileFound;

        public void Search(string directory, string searchPattern)
        {
            foreach (var file in Directory.EnumerateFiles(directory, searchPattern))
            {
                FileFound?.Invoke(this, new FileFoundArgs(file));
            }
        }
    }
}
