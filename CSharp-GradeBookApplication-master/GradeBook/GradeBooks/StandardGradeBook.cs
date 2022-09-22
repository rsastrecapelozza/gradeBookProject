using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public string Name { get; set; }
        public GradeBookType Type { get; private set; }
        //public StandardGradeBook()
        //{

        //}
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Name = name;
            Type = GradeBookType.Standard;
            IsWeighted = isWeighted;
        }


    }
}
