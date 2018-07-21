using System;
using System.Diagnostics;
using Xunit;

namespace Events
{
    public class Test
    {
        [Fact]
        public void Find_All_PDF_Files()
        {
            int filesFound = 0;
            var lister = new FileSearcher();

            EventHandler<FileFoundArgs> onFileFound = (sender, eventArgs) =>
            {
                Debug.WriteLine(eventArgs.FoundFile);
                filesFound++;
            };

            lister.FileFound += onFileFound;

            lister.Search(@"C:\Logs\", "*.pdf");

            lister.FileFound -= onFileFound;

            Assert.Equal(0, filesFound);
        }
    }
}
