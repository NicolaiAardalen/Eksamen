using System;
using System.Collections.Generic;
using System.Data;
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

        public List<ElevData> GetCountByKlasseNavn1A()
        {
            return dbl.GetCountByKlasseNavn1A();
        }

        public List<ElevData> GetCountByKlasseNavn1B()
        { 
            return dbl.GetCountByKlasseNavn1B();
        }

        public List<ElevData> GetTeacherData()
        {
            return dbl.GetTeacherData();
        }
    }
}
