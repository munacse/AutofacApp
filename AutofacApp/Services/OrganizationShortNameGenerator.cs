using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacApp.Services
{
    public interface IOrganizationShortNameGenerator
    {
        string Generate(string name);
    }

    public class OrganizationShortNameGenerator : IOrganizationShortNameGenerator
    {
        private readonly IOrganizationNumberGenerator _numberGenerator;

        public OrganizationShortNameGenerator(IOrganizationNumberGenerator numberGenerator)
        {
            this._numberGenerator = numberGenerator;
        }

        public string Generate(string name)
        {
            return "Muna";
        }
    }
}
