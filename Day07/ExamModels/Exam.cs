using Answers;
using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examspace
{
    enum examEnum
    {
        Practice , Final
    }
    internal class Exam
    {

       protected ChooseAllCorrect[] allCorrect ;
       protected ChooseOne[] Choose ;
       protected TrueOrFalse[] TrueOrFalse ;
       public  Exam(ChooseAllCorrect[] CA, ChooseOne[] CO, TrueOrFalse[] TF)
        {
            allCorrect = CA;
            Choose = CO;
            TrueOrFalse = TF;
        }

       public Exam()
        {

        }

        public int Time { get; set; }
        public int showDegree()
        {
            return Answer.degree;
        }

        public virtual void Show_Exam()
        {
            
        }

          
    }

   
}
