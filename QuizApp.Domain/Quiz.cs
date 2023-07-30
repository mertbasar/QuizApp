using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Domain
{
    public class Quiz:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        // İlişkili sorular için ICollection kullanabilirsiniz
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public ICollection<Question> Questions { get; set; }
    }
}
