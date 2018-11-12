using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnumerator
{
    public class Teacher : Person
    {
        private string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public override string SayGoodmorning()
        {
            return "God morgon klassen!";
        }
    }
}
