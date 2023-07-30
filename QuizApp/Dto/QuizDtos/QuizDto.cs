using QuizApp.Dto.CategoryDtos;
using QuizApp.Dto.QuestionDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Dto.QuizDtos
{
    public class QuizDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QuestionCount { get; set; }
        public int categoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
