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
    public partial class Form1 : Form
    {
        Database ivan = new Database();
        DataTable dt = new DataTable();

        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        void ColumnStyle()
        {
            int colCount = vista.ColumnCount;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("Verdana", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            for (int i = 0; i < colCount; i++)
            {
                this.vista.Columns[i].HeaderCell.Style = style;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void MostrarTablas()
        {
            if (cboObjects.SelectedIndex == 4)
                vista.DataSource = ivan.selectQuery("PRAGMA index_list(t1)");
            else
                vista.DataSource = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = '" + cboObjects.Text + "'");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarTablas();
            ColumnStyle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cboObjectsCreate.SelectedIndex == 0)
            {
                CrearTable ct = new CrearTable();
                ct.StartPosition = FormStartPosition.CenterScreen;
                ct.Show();
            }
            else if (cboObjectsCreate.SelectedIndex == 1)
            {
                CreateIndex ci = new CreateIndex();
                ci.StartPosition = FormStartPosition.CenterScreen;
                ci.Show();
            }
            else if(cboObjectsCreate.SelectedIndex == 2)
            {
                CreateTrigger ct = new CreateTrigger();
                ct.StartPosition = FormStartPosition.CenterScreen;
                ct.Show();
            }
            else if(cboObjectsCreate.SelectedIndex == 3)
            {
                CreateView cv = new CreateView();
                cv.StartPosition = FormStartPosition.CenterScreen;
                cv.Show();
            }
        }

        private void cboObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = '" + cboObjetos.Text + "'");
            dt.Columns.Add("NAME", typeof(String));
            cboListas.ValueMember = "NAME";
            cboListas.DataSource = dt;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are u sure?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                if (cboObjetos.SelectedIndex == 0)
                {
                    ivan.selectQuery("DROP TABLE " + cboListas.Text);
                }
            }
        }
    }
}
