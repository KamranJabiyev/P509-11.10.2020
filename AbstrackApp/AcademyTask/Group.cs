using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTask
{
    partial class Group
    {
        public string Name { get; set; }
        public int MaxCount { get; set; }

        protected Student[] students=new Student[0];

        public readonly int Id;
        private static int _id = 0;

        public Group()
        {
            _id++;
            Id = _id;
        }

        public Group(string name,int maxCount):this()
        {
            Name = name;
            MaxCount = maxCount;
        }

    }
}
