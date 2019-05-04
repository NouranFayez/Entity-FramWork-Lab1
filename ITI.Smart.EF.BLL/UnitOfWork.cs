using ITI.Smart.EF.BLL.Manager;
using ITI.Smart.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Smart.EF.BLL
{
   public class UnitOfWork
    {
        private static Entities context = new Entities();
        private static UnitOfWork unitofwork;

        private UnitOfWork()
        {
            
        }
        public static UnitOfWork Create()
        {
            if (unitofwork == null)
            {
                unitofwork = new UnitOfWork();
            }
            return unitofwork;
        }
        public CountryManager CountryManager {
            get
            {
                return new CountryManager(context);

            }
        }
       public CityManager CityManager
        {
            get
            {
                return new CityManager(context);
            }
        }

    }
}
