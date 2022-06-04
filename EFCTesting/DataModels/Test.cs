using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.DataModels
{
    public class Test
    {
        public int TestID { get; set; }
        public int Progress { get; set; }
        public bool Done { get; set; }
        public ICollection<Question> Questions { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
