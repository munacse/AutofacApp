using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacApp.Repository
{
    public interface IBaseRepository
    {
        int GetId();

        string GetName();
    }
}
