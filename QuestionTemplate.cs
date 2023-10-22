using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Satbayev.University.DAL
{
    public class QuestionTemplate
    {
        public int Id { get; set; }
        public DateTime CreateDate { get;set; }
        public string Title { get; set; }
        public DateTime CorrectedDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Author { get; set; }
        public string ChangeAuthor { get; set; }
        public string Questions { get; set; }
        public double Mark { get; set; }
        public string Level { get; set; }

        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public string GetQuestion()
        {
            return "Id:{Id},Title:{Title},Author:{Author}";
        }
    }
}
