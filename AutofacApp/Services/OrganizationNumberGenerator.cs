using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacApp.Services
{
    public interface IOrganizationNumberGenerator
    {
        int Generate();
    }


    public class OrganizationNumberGenerator : IOrganizationNumberGenerator
    {
        public int Generate()
        {
            return 12313123;
        }
    }
}
