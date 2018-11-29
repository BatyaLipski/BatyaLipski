using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {
        public void ToraMen()
        {
            using (var context = new MilgaPluseDBEntities2())
            {
               //  t = new ToraMen;
                var t =  from ToraMen in context.ToraMen
                      where ToraMen.buildingNumber > 1
                      select ToraMen;
            }
           // from movie in db.Movies select movie
        }
    }
}
