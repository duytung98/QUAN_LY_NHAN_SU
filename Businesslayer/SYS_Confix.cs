using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;

namespace Businesslayer
{
    public class SYS_Confix
    {
        QUAN_LY_NHAN_SUEntities db = new QUAN_LY_NHAN_SUEntities();
        public T_confix getItem(string name)
        {
            return db.T_confix.FirstOrDefault(x => x.Name == name);
        }
    }
}
