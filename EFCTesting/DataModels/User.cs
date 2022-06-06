using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTesting.DataModels
{
    public class User
    {
        public int UserID { get; set; }
        public string NickName { get; set; }
        public List<TestUser> Tests { get; set; }
    }
}
