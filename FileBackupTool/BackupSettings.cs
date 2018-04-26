using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBackupTool
{
    class BackupSettings
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private string SourceDirectory { get; set; }
        private string DestinationDirectory { get; set; }

        public BackupSettings (string name, string description, string sourceDirectory, string destinationDirectory)
        {
            Name = name;
            Description = description;
            SourceDirectory = sourceDirectory;
            DestinationDirectory = destinationDirectory;
        }
    }
}
