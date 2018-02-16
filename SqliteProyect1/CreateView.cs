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
    public partial class CreateView : Form
    {
        Database ivan = new Database();
        public CreateView()
        {
            InitializeComponent();
        }

        private void CreateView_Load(object sender, EventArgs e)
        {
            viewBox.Text = "Select...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ivan.selectQuery("CREATE VIEW " + txtViewName.Text + " AS " + viewBox.Text) != null)
            {
                MessageBox.Show("View creado");
                viewBox.Text = "";
                txtViewName.Text = "";
            }
        }
    }
}
