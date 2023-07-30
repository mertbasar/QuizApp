﻿using QuizApp.Dto.QuestionDtos;

namespace QuizApp.WebApp.Models
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<AnswerViewModel> Answers { get; set; }
    }
}
