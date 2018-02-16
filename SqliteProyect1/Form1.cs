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
            lblTable.Visible = false;
            cboTable.Visible = false;
        }

        public void MostrarTablas(String tipo, DataGridView dgv, String table)
        {
            if (cboObjects.SelectedIndex == 4)
                dgv.DataSource = ivan.selectQuery("PRAGMA index_list(t1)");
            else
                dgv.DataSource = ivan.selectQuery("SELECT * FROM " + table + " WHERE type = '" + tipo + "'");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarTablas(cboObjects.Text, vista, "sqlite_master");
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

            if (cboObjetos.SelectedIndex == 0 || cboObjetos.SelectedIndex == 3)
            {
                lblTable.Visible = false;
                cboTable.Visible = false;

                dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = '" + cboObjetos.Text + "'");
                dt.Columns.Add("NAME", typeof(String));
                cboListas.ValueMember = "NAME";
                cboListas.DataSource = dt;
            }
            else
            {
                lblTable.Visible = true;
                cboTable.Visible = true;

                dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = 'table'");
                dt.Columns.Add("NAME", typeof(String));
                cboTable.ValueMember = "NAME";
                cboTable.DataSource = dt;
            }
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
                else if (cboObjetos.SelectedIndex == 1)
                {
                    ivan.selectQuery("DROP INDEX " + cboListas.Text);
                }
                else if (cboObjetos.SelectedIndex == 2)
                {
                    ivan.selectQuery("DROP TRIGGER " + cboListas.Text);
                }
                else if (cboObjetos.SelectedIndex == 3)
                {
                    ivan.runCommand("DROP VIEW " + cboListas.Text);
                }
            }
        }

        private void cboObjetosAlter_SelectedValueChanged(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = '" + cboObjetosAlter.Text + "'");
            dt.Columns.Add("NAME", typeof(String));
            cboListasAlter.ValueMember = "NAME";
            cboListasAlter.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = 'table'");
            dt.Columns.Add("NAME", typeof(String));
            cboUserTables.ValueMember = "NAME";
            cboUserTables.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tablaVistas.DataSource = ivan.selectQuery("SELECT * FROM " + cboUserTables.Text);

            dt = ivan.selectQuery("PRAGMA table_info(" + cboUserTables.Text + ")");
            dt.Columns.Add("NAME", typeof(String));
            cboWhereColumna.ValueMember = "NAME";
            cboWhereColumna.DataSource = dt;
            //cboWhereColumna.Items.Insert(cboWhereColumna.Items.Count - 1, "All Rows");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = ivan.selectQueryDataSet("PRAGMA table_info(" + cboUserTables.Text + ")");
            string sql = "INSERT INTO " + cboUserTables.Text + " VALUES ("; //sql command base

            //add values to command
            for (int i = 0; i < tablaVistas.ColumnCount; i++)
            {
                sql += "'" + tablaVistas.CurrentRow.Cells[i].Value.ToString() + "'";

                if (i < (tablaVistas.ColumnCount - 1))
                {
                    sql += ", ";
                }
                else
                {
                    sql += ")";
                }
            }
            MessageBox.Show(sql);
            ivan.selectQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboObjetosAlter.SelectedIndex == 0)
            {
                EditTable et = new EditTable();
                EditableTable.currentTable = cboListasAlter.Text;
                et.Show();
            }
            else if (cboObjetosAlter.SelectedIndex == 1)
            {
                MessageBox.Show("Futuras actualisaciones...");
            }
            else if (cboObjetosAlter.SelectedIndex == 2)
            {

            }
            else if (cboObjetosAlter.SelectedIndex == 3)
            {
                MessageBox.Show("Futuras actualisaciones...");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void cboUserTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablaVistas.DataSource = ivan.selectQuery("SELECT * FROM " + cboUserTables.Text);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            dt = ivan.selectQuery("PRAGMA table_info(" + cboUserTables.Text + ")");
            dt2 = ivan.selectQuery("PRAGMA table_info(" + cboUserTables.Text + ")");
            dt3 = ivan.selectQuery("PRAGMA table_info(" + cboUserTables.Text + ")");
            dt.Columns.Add("NAME", typeof(String));
            cboWhereColumna.ValueMember = "NAME";
            cboWhereColumna.DataSource = dt;
            cboSetColumn.ValueMember = "NAME";
            cboSetColumn.DataSource = dt2;
            cboWhereColumn.ValueMember = "NAME";
            cboWhereColumn.DataSource = dt3;

            DataTable dtview = new DataTable();
            dtview = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = 'view'");
            dtview.Columns.Add("NAME", typeof(String));
            cboViews.ValueMember = "NAME";
            cboViews.DataSource = dtview;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            String sqlDelete = "DELETE FROM " + cboUserTables.Text + " WHERE " + cboWhereColumna.Text + " = " + txtValue.Text;
            MessageBox.Show(sqlDelete);
            if (ivan.runCommand(sqlDelete) == true)
            {
                tablaVistas.DataSource = ivan.selectQuery("SELECT * FROM " + cboUserTables.Text);
            }
                
        }

        private void cboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("SELECT * FROM sqlite_master WHERE type = '" + cboObjetos.Text + "' AND tbl_name = '" + cboTable.Text + "'");
            dt.Columns.Add("NAME", typeof(String));
            cboListas.ValueMember = "NAME";
            cboListas.DataSource = dt;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tablaVistas.DataSource = ivan.selectQuery("SELECT * FROM " + cboViews.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            String sqlUpdate = "UPDATE " + cboUserTables.Text + " SET " + cboSetColumn.Text + " = " + txtNewValue.Text + " ";
            sqlUpdate += "WHERE " + cboWhereColumn.Text + " = " + txtWhereColumn.Text;
            MessageBox.Show(sqlUpdate);
            if (ivan.runCommand(sqlUpdate) == true)
            {
                tablaVistas.DataSource = ivan.selectQuery("SELECT * FROM " + cboUserTables.Text);
            }
        }
    }
}
