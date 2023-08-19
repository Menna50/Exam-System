using Examspace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal abstract class  Question
    {
      
        int Grade;

        public int grade
        {
            get
            {
                return Grade;
            }

            set
            {
                if (value > 0)
                    this.Grade = value;
                else
                    this.Grade = 1;
            }
        }
        public abstract void Head(); // return head of ques
        public string Body { get; set; }

        public  void ShowQuestion()
        {

            Console.Write($"{Body}\t\t\t\t");

        }

        public void ShowGrade()
        {

            Console.WriteLine($"{Grade} Points");

        }



    }
}
