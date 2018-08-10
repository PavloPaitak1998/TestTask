using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TestTaskGlobalLogic.Models;

namespace TestTaskGlobalLogic
{
    internal static class FolderHelper
    {
        public static Folder CreateFolder(DirectoryInfo dir)
        {
            var myFiles = new List<MyFile>();
            var files = dir.GetFiles();
            var myDirectories = new List<Folder>();
            var directiries = dir.GetDirectories();


            if (directiries.Count() > 0)
            {
                foreach (var d in directiries)
                {
                    myDirectories.Add(CreateFolder(d));
                }
            }

            if (files.Count() > 0)
            {
                foreach (var file in files)
                {
                    myFiles.Add(new MyFile { Name = file.Name, Size = String.Format(file.Length + " B"), Path = file.FullName });
                }
            }
            //return new Folder(dir.Name, dir.CreationTime.ToLocalTime(), myDirectories, myFiles);
            return new Folder(dir.Name, dir.CreationTime.ToString("dd-MMM-yy h:mm tt",
                  CultureInfo.CreateSpecificCulture("en-US")), myDirectories, myFiles);

        }
    }
}
