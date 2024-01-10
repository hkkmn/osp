using Microsoft.AspNetCore.Mvc;
using osp.Models;
using osp.ViewModels;

namespace osp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly Databasecontext _context;
        private object _databasecontext;

        public QuestionController(Databasecontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var questionModel = _context.Question.Select(x => new ViewModels.QuestionModels
            {
                QuestionId = x.QuestionId,
                QuestionText = x.QuestionText,
                OptionA = x.OptionA,
                OptionB = x.OptionB,
                OptionC = x.OptionC,
                OptionD = x.OptionD,
                OptionE = x.OptionE,


            }).ToList();
            return View("Index");
        }
        public IActionResult Detail(int id)
        {
            var questionModel = _databasecontext.Question.Select(x => new QuestionModel()
            {
                QuestionId = x.QuestionId,
                QuestionText = x.QuestionText,
                OptionA = x.OptionA,
                OptionB = x.OptionB,
                OptionC = x.OptionC,
                OptionD = x.OptionD,
                OptionE = x.OptionE,
            }).SingleOrDefault(x => x.QuestionId == id);
            return View(questionModel);

        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(ViewModels.QuestionModels model)
        {
            var question = new Question();
            question.QuestionId = model.QuestionId;
            question.QuestionText = model.QuestionText;
            question.OptionA = model.OptionA;
            question.OptionB = model.OptionB;
            question.OptionC = model.OptionC;
            question.OptionD = model.OptionD;
            question.OptionE = model.OptionE;


            _context.Question.Add(question);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var questionModel = _context.Question.Select(x => new ViewModels.QuestionModels()
            {
                QuestionId = x.QuestionId,
                QuestionText = x.QuestionText,
                OptionA = x.OptionA,
                OptionB = x.OptionB,
                OptionC = x.OptionC,
                OptionD = x.OptionD,
                OptionE = x.OptionE,

            }).SingleOrDefault(x => x.QuestionId == id);
            return View(questionModel);
        }

        [HttpPost]
        public IActionResult Edit(ViewModels.QuestionModels model)
        {
            var question = _context.Question.SingleOrDefault(x => x.QuestionId == model.QuestionId);
            question.QuestionText = question.QuestionText;
            question.OptionA = question.OptionA;
            question.OptionB = question.OptionB;
            question.OptionC = question.OptionC;
            question.OptionD = question.OptionD;
            question.OptionE = question.OptionE;

            _context.Question.Update(question);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var questionModel = _context.Question.Select(x => new ViewModels.QuestionModels()
            {
                QuestionId = x.QuestionId,
                QuestionText = x.QuestionText,
                OptionA = x.OptionA,
                OptionB = x.OptionB,
                OptionC = x.OptionC,
                OptionD = x.OptionD,
                OptionE = x.OptionE,

            }).SingleOrDefault(x => x.QuestionId == id);
            return View(questionModel);
        }

        [HttpPost]
        public IActionResult Delete(ViewModels.QuestionModels model)
        {
            var question = _context.Question.SingleOrDefault(x => x.QuestionId == model.QuestionId);
            _context.Question.Remove(question);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }

    internal class Question : Models.QuestionModel
    {
    }
}