using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggerNetEng.Engine
{
    [Serializable]
    public class NobelPhysicsLaureate
    {
        public NobelPhysicsLaureate()
        {
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }

    [Serializable]
    public class NobelPhysicsLaureateList
    {
        public NobelPhysicsLaureateList()
        {
            NPLList = new List<NobelPhysicsLaureate>();
        }
        public List<NobelPhysicsLaureate> NPLList { get; set; }
    }
}
