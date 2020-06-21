using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private bool weighted;

        public StandardGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }

        public StandardGradeBook(string name, bool weighted) : this(name)
        {
            this.weighted = weighted;
        }
    }

}