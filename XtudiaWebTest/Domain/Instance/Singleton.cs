using Domain.CrudModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Instance
{
    public class Singleton
    {
        private static UserCrud instance;
        public static UserCrud GetUser()
        {
            if(instance == null)
            {
                return new UserCrud();
            }
            return instance;
        }
    }
}
