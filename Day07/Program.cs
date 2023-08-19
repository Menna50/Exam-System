using Answers;
using Examspace;
using Questions;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SET Questions

            #region CHOOSE ONE
            ChooseOne[] Choose = new ChooseOne[3];

            for (int i = 0; i < Choose.Length; i++)
            {
                switch (i)
                {
                    case 0:

                        Choose[i] = new ChooseOne("1- Which class can have member functions without their implementation",
                        "a) Default class",
                        "b) String class",
                        "c) Template class",
                        "d) Abstract class",
                        "d");
                        Choose[i].grade = 2;
                        break;

                    case 1:

                        Choose[i] = new ChooseOne("2- Which of the following describes a friend class",
                        "a) Friend class can access all the private members of the class, of which it is a friend",
                        "b) Sum of the size of all the variables along with inherited variables in the class",
                        "c) Size of the largest size of variable",
                        "d) Classes doesn’t have any size",
                        "a");
                        Choose[i].grade = 2;
                        break;

                    case 2:

                        Choose[i] = new ChooseOne("3- What is the scope of a class nested inside another class?",
                        "a) Protected scope",
                        "b) Private scope",
                        "c) Global scope",
                        "d) Depends on access specifier and inheritance used",
                        "d");
                        Choose[i].grade = 2;
                        break;

                }
            }
            #endregion


            #region CHOOSE ALL
            ChooseAllCorrect[] ChooseAll = new ChooseAllCorrect[3];

            for (int i = 0; i < ChooseAll.Length; i++)
            {

                switch (i)
                {
                    case 0:
                        ChooseAll[i] = new ChooseAllCorrect("4- Which Access Modifier are allowed in The namespace",
                        "a) Public",
                        "b) Protected",
                        "c) Internal",
                        "d) private",
                        "a/c");
                        ChooseAll[i].grade = 2;

                        break;

                    case 1:
                        ChooseAll[i] = new ChooseAllCorrect("5- What are types of classes",
                         "a) Static",
                         "b) Concret",
                         "c) Virtual",
                         "d) Abstract",
                         "a/b/d");
                        ChooseAll[i].grade = 2;

                        break;

                    case 2:
                        ChooseAll[i] = new ChooseAllCorrect("6- What are the OOP Principles ",
                        "a) Inheritance",
                        "b) Abstraction",
                        "c) Polimorphism",
                        "d) Encapsulation",
                        "a/b/c/d");

                        ChooseAll[i].grade = 2;

                        break;

                }
            }
            #endregion


            #region TRUE OR FALSE
            TrueOrFalse[] TR = new TrueOrFalse[3];

            for (int i = 0; i < TR.Length; i++)
            {

                switch (i)
                {
                    case 0:
                        TR[i] = new TrueOrFalse("7- Super classes are also called Parent classes/Base classes",
                        "a)True",
                        "b)False",
                        "a");
                        TR[i].grade = 2;

                        break;

                    case 1:
                        TR[i] = new TrueOrFalse("8- It is not possible to achieve inheritance of structures in c#",
                            "a)True",
                            "b)False",
                            "a");
                        TR[i].grade = 2;

                        break;

                    case 2:

                        TR[i] = new TrueOrFalse("9- Sub classes may also be called Child classes/Derived classes",
                            "a)True",
                            "b)False",
                            "a");
                        TR[i].grade = 2;

                        break;

                }
            }
            #endregion

            #endregion

            examEnum ExamType;
            do
            {
                Console.WriteLine("Choose which type of exam you want: Practice or Final");
            }
            while (!Enum.TryParse<examEnum>(Console.ReadLine(), out ExamType));





            //show exam and scan answers

           
            #region show questions of choose one question
            string answer;
            Choose[0].Head();
            for (int i = 0; i < Choose.Length; i++)
            {
                Choose[i].ShowQuestion();
                Choose[i].ShowGrade();
                Choose[i].CH.showChoices();
                do {
                    Console.WriteLine("Enter Your Answer a or b or c or d :- ");
                    answer = Console.ReadLine();
                } while (!Enum.TryParse<choiceanswer>(answer, out choiceanswer Enumanswer));
                Choose[i].CH.StudentAnswer = answer;
                Choose[i].CH.correction(Choose[i].grade);
            }
            #endregion

            #region show questions of choose all correct question
            ChooseAll[0].Head();
            int count = 0;
            String[] ArrAnswer;
             for (int i = 0; i < ChooseAll.Length; i++)
             {
                ChooseAll[i].ShowQuestion();
                ChooseAll[i].ShowGrade();
                ChooseAll[i].CH.showChoices();
                
                do
                {
                    count = 0;

                    Console.WriteLine("Enter Your Answer in this formate a/b/c/d:- ");
                    answer = Console.ReadLine();
                    ArrAnswer=answer.Split('/');
                    for(int j=0;j<ArrAnswer.Length; j++)
                    {
                        if (Enum.TryParse<choiceanswer>(ArrAnswer[j], out choiceanswer Enumanswer))
                            count++;
                    }

                    
                } while (count!= ArrAnswer.Length || ArrAnswer.Length>4);
                ChooseAll[i].CH.StudentAnswer = answer;
                ChooseAll[i].CH.correction(ChooseAll[i].grade);

             }
             #endregion

             #region show questions of true or false question
             TR[0].Head();
             for (int i = 0; i < TR.Length; i++)
             {
                TR[i].ShowQuestion();
                TR[i].ShowGrade();
                TR[i].TOR.showChoices();
                do
                {
                    Console.WriteLine("Enter Your Answer a or b:- ");
                    answer = Console.ReadLine();
                } while (!Enum.TryParse<trANSWER>(answer, out trANSWER Enumanswer));
                TR[i].TOR.StudentAnswer = answer; 
                TR[i].TOR.correction(TR[i].grade);


             }
             #endregion
       

            switch (ExamType)
            {

                case examEnum.Practice:
                    PracticExam p = new PracticExam(ChooseAll, Choose, TR);
                    Console.WriteLine($"\n --------------- you are finshed your exam your score is {p.showDegree()} and true answers are : ---------------------\n ");
                    p.Show_Exam();

                    break;

                case examEnum.Final:
                    FinalExam f = new FinalExam(ChooseAll, Choose, TR);
                    Console.WriteLine($"you are finshed your exam and your answers are : ---------------------\n");
                    f.Show_Exam();
                    break;
            }



        }
    }
}