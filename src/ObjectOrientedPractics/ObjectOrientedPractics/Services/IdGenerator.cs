using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal static class IdGenerator
    {
        static int _id;

        static int Id
        {
            get
            { 
                return _id; 
            }
            set { 
                _id = value; 
            }
        }

        public static int GetNextId()
        {
            return Id++;
        }
    }
}
