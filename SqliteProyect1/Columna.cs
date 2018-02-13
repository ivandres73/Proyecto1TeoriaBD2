using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteProyect1
{
    class Columna
    {
        string name;
        bool pk;
        string dataType;
        bool nullable;
        string defaultValue;

        public Columna(string n, bool p, string dt, bool nu, string dv)
        {
            name = n;
            pk = p;
            dataType = dt;
            nullable = nu;
            defaultValue = dv;
        }

        public String getColumnLine()
        {
            string columnline;
            columnline = name + " ";
            columnline += dataType + " ";
            columnline += pk ? "primary key " : "";
            columnline += nullable ? "not null " : "";
            columnline += (defaultValue.Equals("")) ? "" : "default " + defaultValue;

            return columnline;
        }
    }
}
