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
                    sql += (i == columnnas.Count() - 1) ? "" : ",";
                }
                sql += (checkForeign.Checked) ? "," : "";
            }
            if (checkForeign.Checked == true)
            {
                sql += "FOREIGN KEY(" + cbo.Text+ ") REFERENCES " + cboTableForeign.Text + "(" + cboColumnForeign.Text + ")";
            }
            sql += ")";
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
            lblColumnForeign.Visible = false;
            lblTableForeign.Visible = false;
            cboColumnForeign.Visible = false;
            cboTableForeign.Visible = false;
            cbo.Visible = false;
            lblcol.Visible = false;
        }

        private void checkForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (checkForeign.Checked == true)
            {
                lblColumnForeign.Visible = true;
                lblTableForeign.Visible = true;
                cboColumnForeign.Visible = true;
                cboTableForeign.Visible = true;
                cbo.Visible = true;
                lblcol.Visible = true;

                cbo.Items.Clear();
                for (int i=0; i < columnnas.Count; i++)
                {
                    cbo.Items.Add(columnnas[i].name);
                }

                DataTable dt1 = new DataTable();
                dt1 = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = 'table'");
                dt1.Columns.Add("NAME", typeof(String));
                cboTableForeign.ValueMember = "NAME";
                cboTableForeign.DataSource = dt1;
            }
            else
            {
                lblColumnForeign.Visible = false;
                lblTableForeign.Visible = false;
                cboColumnForeign.Visible = false;
                cboTableForeign.Visible = false;
                cbo.Visible = false;
                lblcol.Visible = false;
            }
        }

        private void cboTableForeign_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2 = ivan.selectQuery("PRAGMA table_info(" + cboTableForeign.Text + ")");
            dt2.Columns.Add("NAME", typeof(String));
            cboColumnForeign.ValueMember = "NAME";
            cboColumnForeign.DataSource = dt2;
        }
    }
}
