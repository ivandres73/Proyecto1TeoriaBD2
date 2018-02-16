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
    public partial class EditTable : Form
    {
        Database ivan = new Database();
        DataTable dt = new DataTable();
        Columna nuevaCol;

        public EditTable()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void actualizarColumnas()
        {
            dt = ivan.selectQuery("PRAGMA table_info(" + lblNombreTabla.Text + ")");
            dt.Columns.Add("NAME", typeof(String));
            cboColumnas.ValueMember = "NAME";
            cboColumnas.DataSource = dt;
        }

        private void EditTable_Load(object sender, EventArgs e)
        {
            lblNombreTabla.Text = EditableTable.currentTable;
            actualizarColumnas();
        }

        private void btnDropColumn_Click(object sender, EventArgs e)
        {
            actualizarColumnas();
        }

        private void btnAgregarColumna_Click(object sender, EventArgs e)
        {
            String addColumna = "ALTER TABLE " + lblNombreTabla.Text + " ADD COLUMN ";
            nuevaCol = new Columna(txtNombreColumna.Text, false, cboDataType.Text, checkNull.Checked, txtDefaultValue.Text, false);
            addColumna += nuevaCol.getColumnLine();
            addColumna += ";";
            MessageBox.Show(addColumna);
            ivan.runCommand(addColumna);
            MessageBox.Show("Columna Agregada");
            txtNombreColumna.Text = "";
            cboDataType.Text = "";
            checkNull.Checked = false;
            txtDefaultValue.Text = "";
        }

        private void btnRenombrar_Click(object sender, EventArgs e)
        {
            if (ivan.selectQuery("ALTER TABLE " + lblNombreTabla.Text + " RENAME TO " + txtNuevoNombreTabla.Text) != null)
            {
                MessageBox.Show("Tabla renombrada");
                lblNombreTabla.Text = txtNuevoNombreTabla.Text;
                txtNuevoNombreTabla.Text = "";
            }
        }
    }
}
