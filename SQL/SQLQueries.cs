using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMUD
{
    public static class SQLQueries
    {
        public readonly static string GET_TEACHERS = "select * from dbo.Teachers";
        public readonly static string GET_CABINETS = "select * from dbo.Cabinets";
        public readonly static string GET_CLERKS = "select * from dbo.Clerks";
    }
}
