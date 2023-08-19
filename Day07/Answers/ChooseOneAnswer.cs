using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    internal class ChooseOneAnswer:Answer
    {
        public string CH1 { get; set; }
        public string CH2 { get; set; }
        public string CH3 { get; set; }
        public string CH4 { get; set; }

      
        public override void showChoices()
        {
            Console.WriteLine($"{CH1}\n{CH2}\n{CH3}\n{CH4}");
        }
    }
}
