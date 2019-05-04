using ITI.Smart.EF.BLL;
using ITI.Smart.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.EF.DBF
{
    class Program
    {
        static void Main(string[] args)
        {App_Start.EntityFrameworkProfilerBootstrapper.PreStart();

            UnitOfWork unit = UnitOfWork.Create();
            unit.CountryManager.Add(new Country
            {
                name = "USA"
            });
        }
    }
}

