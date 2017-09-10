using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWebApplication.data
{
    public class User
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Followers { get; set; }
        public List<Repos> Repos { get; set; }
    }
}
