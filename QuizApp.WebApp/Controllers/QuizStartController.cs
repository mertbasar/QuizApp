//using Microsoft.AspNetCore.Mvc;
//using QuizApp.Business.AnswerManager;
//using QuizApp.Business.QuestionManagers;
//using QuizApp.Business.QuizManagers;
//using QuizApp.Domain;
//using QuizApp.Dto.AnswerDtos;
//using QuizApp.Dto.QuestionDtos;
//using QuizApp.Dto.QuizDtos;
//using QuizApp.WebApp.Models;
//using System.Collections.Generic;
//using System.Linq;

//public class QuizStartController : Controller
//{
//    private readonly IQuizService _quizService;
//    private readonly IQuestionService _questionService;
//    private readonly IAnswerService _answerService;

//    public QuizStartController(IQuizService quizService, IQuestionService questionService, IAnswerService answerService)
//    {
//        _quizService = quizService;
//        _questionService = questionService;
//        _answerService = answerService;
//    }
//    public QuizDto GetQuizById(int id)
//    {
//        var quiz = _quizService.GetById(id);
//        if (quiz == null)
//        {
//            // Eğer quiz bulunamazsa null dönebilirsiniz veya hata işlemleri yapabilirsiniz
//            return null;
//        }

//        return new QuizDto
//        {
//            Id = quiz.Id,
//            Name = quiz.Name,
//            Description = quiz.Description,
//            categoryId = quiz.categoryId,
//            QuestionCount = quiz.QuestionCount
//        };
//    }

//    public IEnumerable<QuestionDto> GetQuestionsByQuiz(int quizId)
//    {
//        var questions = GetQuestionsByQuiz(quizId);

//        return questions.Select(q => new QuestionDto
//        {
//            Id = q.Id,
//            Text = q.Text,
//            Answers = q.Answers,
//            Description = q.Description,
//            Title = q.Title,
//            Category = q.Category,
//            QuizId = q.QuizId,
//            CategoryId = q.CategoryId
            
//            // Diğer özellikleri de DTO'ya ekleyebilirsiniz
//        }).ToList();
//    }

//    [HttpGet]
//    public IActionResult StartQuiz(int quizId)
//    {
//        var quiz = GetQuizById(quizId);
//        var questions = GetQuestionsByQuiz(quizId);

//        var viewModel = new QuizViewModel
//        {
//            Quiz = new QuizDto
//            {
//                Id = quiz.Id,
//                Name = quiz.Name,
//                Description = quiz.Description,
//                QuestionCount = quiz.QuestionCount
//            },
//            Questions = new List<QuestionViewModel>()
//        };

//        foreach (var question in questions)
//        {
//            var answers = _answerService.GetAnswersByQuestion(question.Id);
//            var questionViewModel = new QuestionViewModel
//            {
//                 = new QuestionDto
//                {
//                    Id = question.Id,
//                    Text = question.Text,
//                    // Diğer özellikleri de ViewModel'e ekleyebilirsiniz
//                },
//                Answers = answers.Select(a => new AnswerDto
//                {
//                    Id = a.Id,
//                    Text = a.Text,
//                    IsCorrect = a.IsCorrect
//                    // Diğer özellikleri de ViewModel'e ekleyebilirsiniz
//                }).ToList(),
//                UserAnswers = new List<int>() // Kullanıcının cevaplarını tutmak için boş bir liste oluşturuyoruz
//            };

//            viewModel.Questions.Add(questionViewModel);
//        }

//        return View(viewModel);
//    }

//    [HttpPost]
//    public IActionResult StartQuiz(QuizViewModel viewModel)
//    {
//        if (ModelState.IsValid)
//        {
//            // ViewModel'de tutulan cevapları doğru cevaplarla karşılaştırarak skor hesaplaması yapabilirsiniz
//            int totalScore = 0;
//            foreach (var questionViewModel in viewModel.Questions)
//            {
//                var correctAnswers = questionViewModel.Answers.Where(a => a.IsCorrect).Select(a => a.Id).ToList();
//                var userAnswers = questionViewModel.UserAnswers;
//                var isUserAnswersCorrect = correctAnswers.SequenceEqual(userAnswers);

//                if (isUserAnswersCorrect)
//                {
//                    totalScore++;
//                }
//            }

//            // Toplam skoru başka bir sayfada gösterebilirsiniz
//            // Örneğin, Score.cshtml adında yeni bir View oluşturun ve aşağıdaki gibi kullanın
//            return View("Score", totalScore);
//        }

//        // Eğer ModelState geçerli değilse, View'ı tekrar gösteriyoruz
//        return View(viewModel);
//    }
//}
