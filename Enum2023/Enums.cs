using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum2023
{
    class Enums
    {

        public enum MyEnumInsideClass
        {
            FirstConstant,
            SecondConstant,
            ThirdConstant,
        }
    }
    enum MyEnumWithInt
    {
        FirstConstant = 1,
        SecondConstant = 2,
        ThirdConstant = 3,
    }

    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    public enum CurrentState
    {
        Sleeping,
        Working,
        Eating,
    }
}
