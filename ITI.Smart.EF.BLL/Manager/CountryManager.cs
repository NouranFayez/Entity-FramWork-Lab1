using ITI.Smart.EF.Model;
using ITI.Smart.EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.EF.BLL.Manager
{
    public class CountryManager :Repository<Country, Entities>
    {
        public CountryManager(Entities context ):base(context)
        {

        }
    }
}
