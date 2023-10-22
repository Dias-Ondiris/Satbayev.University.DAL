using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.University.DAL;

namespace Satbayev.University.LIB
{
    public class Question
    {
        Repository repository = new Repository("C:/temp/dias.db");
        public string AddQuestion(QuestionTemplate questions)
        {
            
            try
            {
                if(repository.CreateQuestion(questions))return "success";
                return "error";
            }
            catch
            {
                return "error";
            }
        }
        public List<QuestionTemplate> GetAllQuestion()
        {
            return repository.GetAllQuestion();
        }
        
    }
}
