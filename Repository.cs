using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Satbayev.University.DAL
{
    public class Repository
    {
        private string Path;
        public Repository(string Path)
        {
            this.Path = Path;
        }
        public bool CreateQuestion(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var questions = db.GetCollection<QuestionTemplate>("Question");
                    questions.Insert(question);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateQuestion(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var questions = db.GetCollection<QuestionTemplate>("Question");
                    questions.Update(question);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool DeleteQuestion(int  questionid)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var questions = db.GetCollection<QuestionTemplate>("Question");
                    questions.Delete(questionid);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public List<QuestionTemplate> GetAllQuestion()
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>("Question").FindAll();
                    return col.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<QuestionTemplate> GetQuestionByCotegory(Category category)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>("Question").FindAll().Where(q=>q.Category==category);
                    return col.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<QuestionTemplate> GetQuestionByID(int  id)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>("Question").FindAll().Where(q => q.Id == id);
                    return col.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
