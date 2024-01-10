
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace osp.ViewModels
{
    [Keyless]
    public class QuestionModels
    {
        public int QuestionId { get; set; }


        public string QuestionText { get; set; }


        public string OptionA { get; set; }

        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string OptionE { get; set; }
    }
}
