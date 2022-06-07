using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.DataModels
{
    public class TestUser
    {
        public int TestId { get; set; }
        public Test Test { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Progress { get; set; }
        public bool Done { get; set; }
    }
}
