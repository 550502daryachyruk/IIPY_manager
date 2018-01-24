using System;

namespace lb5_deviseman
{
    class SysFile
    {
        public string Path { get; }
        public string Description { get; }

        public SysFile(string path, string description)
        {
            this.Path = path;
            this.Description = description;
        }
    }
}