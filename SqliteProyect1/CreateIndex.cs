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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexCode += txtNombre.Text + " ON ";
            indexCode += cboTablas.Text + " (" + txtcolumna.Text + ")";

            sqlIndex.Text = indexCode;
        }
    }
}
