using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DatabaseLayer;

namespace BusinessLayer
{
    public class BLayer
    {
        private DBLayer dbl = new DBLayer();
        public List<ElevData> GetAllElevDataFromElevByJoin()
        {
            return dbl.GetAllElevDataFromElevByJoin();
        }

        public List<ElevData> GetAllElevDataWhereFornavn(string Fornavn)
        {
            return dbl.GetAllElevDataWhereFornavn(Fornavn);
        }

        public List<ElevData> GetAllElevDataWhereKlassenavn(string Klassenavn)
        {
            return dbl.GetAllElevDataWhereKlassenavn(Klassenavn);
        }
        public List<ElevData> GetAllElevDataWhereFagnavn(string Fagnavn)
        {
            return dbl.GetAllElevDataWhereFagnavn(Fagnavn);
        }
    }
}
