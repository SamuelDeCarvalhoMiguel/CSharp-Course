using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionOOP
{
    internal class Student
    {

        public string Name;
        public double FirstNote, secondNote, ThirdNote;

        public double FinalNote()
        {
            return FirstNote + secondNote + ThirdNote;
        }

        public string Approved()
        {
            if (FinalNote() >= 60)
                return "Approved";
            else
                return "disapproved";
        }

        public double neededNote()
        {
            return 60 - FinalNote();
        }

    }
}
