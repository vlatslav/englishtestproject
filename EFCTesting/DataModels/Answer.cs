using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCTesting.DataModels
{
    public class Answer
    {
        public int AnswerID { get; set; }
        [MaxLength(20)]
        public string Answ { get; set; }
        public string Correct { get; set; }
    }
}
