using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SqliteProyect1
{
    public partial class CreateIndex : Form
    {
        Database ivan = new Database();
        DataTable dt = new DataTable();
        String indexCode = "CREATE INDEX ";

        public CreateIndex()
        {
            InitializeComponent();
        }

        private void CreateIndex_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            dt = ivan.selectQuery("SELECT NAME FROM SQLITE_MASTER WHERE TYPE='table';");
            dt.Columns.Add("NAME", typeof(String));
            cboTablas.ValueMember = "NAME";
            cboTablas.DataSource = dt;
            cboColumnas2.Visible = false;
            lblColumna2.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkComplejo.Checked == false)
            {
                indexCode += txtNombre.Text + " ON ";
                indexCode += cboTablas.Text + " (" + cboColumnas.Text + ")";

                sqlIndex.Text = indexCode;
                tabControl1.SelectedTab = tabCode;
            }
            else
            {
                indexCode += txtNombre.Text + " ON ";
                indexCode += cboTablas.Text + " (" + cboColumnas.Text + "," + cboColumnas2.Text + ")";

                sqlIndex.Text = indexCode;
                tabControl1.SelectedTab = tabCode;
            }
        }

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("PRAGMA table_info(" + cboTablas.Text + ")");
            dt.Columns.Add("NAME", typeof(String));
            cboColumnas.ValueMember = "NAME";
            cboColumnas.DataSource = dt;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (ivan.runCommand(sqlIndex.Text) == true)
            {
                MessageBox.Show("Indice creado en tabla: " + cboTablas.Text);
                sqlIndex.Text = "";
            }
        }

        private void checkComplejo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkComplejo.Checked == true)
            {
                cboColumnas2.Visible = true;
                lblColumna2.Visible = true;

                DataTable dt2 = new DataTable();
                dt2 = ivan.selectQuery("PRAGMA table_info(" + cboTablas.Text + ")");
                dt2.Columns.Add("NAME", typeof(String));
                cboColumnas2.ValueMember = "NAME";
                cboColumnas2.DataSource = dt2;
                //cboColumnas2.Items.RemoveAt(cboColumnas.SelectedIndex);
            }
            else
            {
                cboColumnas2.Visible = false;
                lblColumna2.Visible = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
