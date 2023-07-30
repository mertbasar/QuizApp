using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Domain
{
    public class Question:IEntity
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
