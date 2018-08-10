using System;
using System.Collections.Generic;

namespace TestTaskGlobalLogic.Models
{
    internal sealed class Folder
    {
        public string Name { get; set; }
        //public DateTime DateCreated { get; set; }
        public string DateCreated { get; set; }

        public List<Folder> Children { get; set; }
        public List<MyFile> Files { get; set; }

        public Folder()
        {

        }

        //public Folder(string name, DateTime dateCreated, List<Folder> children, List<MyFile> files)
        //{
        //    Name = name;
        //    DateCreated = dateCreated;
        //    Children = children;
        //    Files = files;
        //}

        public Folder(string name, string dateCreated, List<Folder> children, List<MyFile> files)
        {
            Name = name;
            DateCreated = dateCreated;
            Children = children;
            Files = files;
        }
    }
}
