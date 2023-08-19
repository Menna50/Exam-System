using Examspace;
using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examspace
{


    class FinalExam : Exam
    {
        public FinalExam(ChooseAllCorrect[] CA, ChooseOne[] CO, TrueOrFalse[] TF) : base(CA, CO, TF)
        {

        }
        public override void Show_Exam()
        {

            #region show exam

            #region show questions of choose one question
            Choose[0].Head();
            for (int i = 0; i < Choose.Length; i++)
            {

                Choose[i].ShowQuestion();
                Choose[i].CH.showStudentAnswer();

            }
            #endregion

            #region show questions of choose all correct question
            allCorrect[0].Head();
            Console.WriteLine();
            for (int i = 0; i < allCorrect.Length; i++)
            {

                allCorrect[i].ShowQuestion();
                allCorrect[i].CH.showStudentAnswer();
            }
            #endregion

            #region show questions of true or false question
            TrueOrFalse[0].Head();
            Console.WriteLine();
            for (int i = 0; i < TrueOrFalse.Length; i++)
            {
                TrueOrFalse[i].ShowQuestion();
                TrueOrFalse[i].TOR.showStudentAnswer();

            }
            #endregion

            #endregion
        }
    }
}
