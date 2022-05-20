using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCTesting.DataModels
{
    public class Question
    {
        public int QuestionID { get; set; }
        [MaxLength(50)]
        public string Quest { get; set; }
        public ICollection<Answer> Answer { get; set; }
    }
}
