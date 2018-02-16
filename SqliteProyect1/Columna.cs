using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteProyect1
{
    class Columna
    {
        public string name;
        bool pk;
        string dataType;
        bool nullable;
        string defaultValue;
        bool incremental;

        public Columna(string n, bool p, string dt, bool nu, string dv, bool inc)
        {
            name = n;
            pk = p;
            dataType = dt;
            nullable = nu;
            defaultValue = dv;
            incremental = inc;
        }

        public String getColumnLine()
        {
            string columnline;
            columnline = name + " ";
            columnline += dataType + " ";
            columnline += pk ? "primary key " : "";
            columnline += incremental ? "autoincrement " : "";
            columnline += nullable ? "not null " : "";
            columnline += (defaultValue.Equals("")) ? "" : "default " + defaultValue;

            return columnline;
        }
    }
}
