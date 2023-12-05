using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class ChangeWorld
    {

        public ChangeWorld()
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }

        //constructor

        public ChangeWorld(string Name,string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

   

        public string actionNeeded()
        {
            return "Make world a better place";
        }
    }
}
