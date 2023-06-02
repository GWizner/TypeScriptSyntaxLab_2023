using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_to_CSharp
{
    class fromJson
    {

    }
    //Edit: Paste Special: Paste Json as Classes

   
    public class Dog
    {
        public int id { get; set; }
        public string name { get; set; }
        public string breed { get; set; }
        public string birthday { get; set; }
        public float weight { get; set; }
        public SpecialNeeds specialneeds { get; set; }
        public bool vaccination { get; set; }
    }

    public class SpecialNeeds
    {
        public string diet { get; set; }
        public string exercise { get; set; }
    }

}
