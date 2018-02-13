using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace SqliteProyect1
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=C:\\db01\\example.db");
        }

        public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad = new SQLiteDataAdapter(query, myConnection);//= new SQLiteDataAdapter(query, myConnection)
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd = myConnection.CreateCommand();
                myConnection.Open();  //Initiate connection to the db
                cmd.CommandText = query;  //set the passed query
                //ad = new SQLiteDataAdapter(cmd);//quitarle el comment
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Hubo un error");
            }
            myConnection.Close();
            return dt;
        }

        public DataSet selectQueryDataSet(string query)
        {
            SQLiteDataAdapter ad = new SQLiteDataAdapter(query, myConnection);//= new SQLiteDataAdapter(query, myConnection)
            DataSet ds = new DataSet();

            try
            {
                SQLiteCommand cmd = myConnection.CreateCommand();
                myConnection.Open();  //Initiate connection to the db
                cmd.CommandText = query;  //set the passed query
                //ad = new SQLiteDataAdapter(cmd);//quitarle el comment
                ad.Fill(ds); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Hubo un error");
            }
            myConnection.Close();
            return ds;
        }

    }
}