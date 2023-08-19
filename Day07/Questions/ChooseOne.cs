using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answers;

namespace Questions
{
    internal class ChooseOne : Question
    {
     internal ChooseOneAnswer CH=new ChooseOneAnswer();


        public ChooseOne(string body, string ch1, string ch2, string ch3, string ch4 , string modelAnswer)
        {
            Body = body;
            CH.CH1 = ch1;
            CH.CH2 = ch2;
            CH.CH3 = ch3;
            CH.CH4 = ch4;
            CH.ModelAnswer = modelAnswer;
        }

        public override void Head()
        {
            Console.WriteLine("Choose The Correct Answer From The Folowing :- ") ;

        }


      
    }
}
