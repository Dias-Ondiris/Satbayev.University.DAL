using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.University.LIB;
using Satbayev.University.DAL;
namespace Satbayev.University.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question question = new Question();
            QuestionTemplate tempquestion = new QuestionTemplate();
            tempquestion.Mark = 4;
            tempquestion.Title = "How many?";
            tempquestion.Author = "Dias";
            tempquestion.ChangeDate = new DateTime(2023, 10, 18);
            tempquestion.Questions = "where? ";
            tempquestion.CreateDate = new DateTime(2023, 10, 18);
            tempquestion.ChangeAuthor = "Dias";
            tempquestion.CorrectedDate = new DateTime(2023, 10, 18);
            tempquestion.Category = new Category()
            {
                CreateDate = new DateTime(2023, 10, 18),
                Id = 1,
                Name = "Populate"
            };
            tempquestion.CategoryId = 1;
            Console.WriteLine(question.AddQuestion(tempquestion));
            //Console.WriteLine(question.AddQuestion(tempquestion));
            List<QuestionTemplate> questions = question.GetAllQuestion();
            try
            {
                if (questions != null)
                {
                    questions.ForEach(ques =>
                    {

                        Console.WriteLine(ques.Title);
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
