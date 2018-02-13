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
    public partial class CreateTrigger : Form
    {
        DataTable dt = new DataTable();
        Database ivan = new Database();
        public CreateTrigger()
        {
            InitializeComponent();
        }

        private void CreateTrigger_Load(object sender, EventArgs e)
        {
            dt = ivan.selectQuery("SELECT NAME FROM SQLITE_MASTER WHERE TYPE='table';");
            dt.Columns.Add("NAME", typeof(String));
            cboTablas.ValueMember = "NAME";
            cboTablas.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String TriggerSql = "CREATE TRIGGER " + txtTriggerName.Text + " ";
            TriggerSql += (rdbAfter.Checked) ? rdbAfter.Text : rdbBefore.Text;
            TriggerSql += " ";
            if (rdbInsert.Checked)
            {
                TriggerSql += rdbInsert.Text;
            }
            else if (rdbUpdate.Checked)
            {
                TriggerSql += rdbUpdate.Text;
            }
            else
            {
                TriggerSql += rdbDelete.Text;
            }
            TriggerSql += " ON " + cboTablas.Text + " BEGIN ";
            if (txtStatement.Text.Length == 0)
            {
                MessageBox.Show("Statement can't be empy...");
                return;
            }
            TriggerSql += txtStatement.Text + " END;";
            SqlTrigger.Text = TriggerSql;
            tabControl1.SelectedTab = tabCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SqlTrigger.Text.Length == 0)
                MessageBox.Show("Error: Empty");
            else
            {
                if (ivan.selectQuery(SqlTrigger.Text) != null)
                {
                    MessageBox.Show("Trigger creado!");
                    SqlTrigger.Text = "";
                }
            }
        }
    }
}
