using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    internal class TrueOrFalseAnswer:Answer
    {
        public string TrueAnswer { get; set; }
        public string FalseAnswer { get; set; }


        public override void showChoices()
        {
            Console.WriteLine($"{TrueAnswer}\n{FalseAnswer}");
        }
    }
}
