using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqliteProyect1
{
    public partial class CrearTable : Form
    {
        List<Columna> columnnas = new List<Columna>();
        Database ivan = new Database();
        
        public CrearTable()
        {
            InitializeComponent();
        }

        public void clearColumn()
        {
            txtNombreColumna.Text = "";
            checkPK.Checked = false;
            cboDataType.Text = "";
            checkNull.Checked = false;
            txtDefaultValue.Text = "";
            chkIncremental.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "create table ";
            sql += txtNombreTabla.Text;
            if (columnnas.Any())
            {
                sql += "(";
                for (int i = 0; i < columnnas.Count(); i++)
                {
                    sql += columnnas[i].getColumnLine();
                    sql += (i == columnnas.Count() - 1) ? ")" : ",";
                }
            }
            SqlBox.Text = sql;
            tabControl1.SelectedTab = tabCode;
            columnnas.Clear();
            txtNombreTabla.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            columnnas.Add(new Columna(txtNombreColumna.Text, checkPK.Checked, cboDataType.Text, checkNull.Checked, txtDefaultValue.Text,  chkIncremental.Checked));
            clearColumn();
            MessageBox.Show("Lleva " + columnnas.Count + " columna(s) agregadas");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ivan.selectQuery(SqlBox.Text) != null)
            {
                MessageBox.Show("Table Created!");
                SqlBox.Text = "";
            }
        }

        private void CrearTable_Load(object sender, EventArgs e)
        {

        }
    }
}
