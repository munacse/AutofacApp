using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacApp.Repository
{
    public class StudentRepository :IBaseRepository
    {
        public int GetId()
        {
            return 1;
        }

        public string GetName()
        {
            return "ABC";
        }
    }
}
