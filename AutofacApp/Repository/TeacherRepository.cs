using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacApp.Repository
{
    public class TeacherRepository : IBaseRepository
    {
        public int GetId()
        {
            return 980;
        }

        public string GetName()
        {
            return "XYZ";
        }
    }
}
