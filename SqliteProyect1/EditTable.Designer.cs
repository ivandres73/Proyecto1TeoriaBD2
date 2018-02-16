namespace SqliteProyect1
{
    partial class EditTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.btnAgregarColumna = new System.Windows.Forms.Button();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.checkNull = new System.Windows.Forms.CheckBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevoNombreTabla = new System.Windows.Forms.TextBox();
            this.btnRenombrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRefreshColumn = new System.Windows.Forms.Button();
            this.cboColumnas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Location = new System.Drawing.Point(232, 26);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(98, 17);
            this.lblNombreTabla.TabIndex = 0;
            this.lblNombreTabla.Text = "Nombre Tabla";
            // 
            // btnAgregarColumna
            // 
            this.btnAgregarColumna.Location = new System.Drawing.Point(620, 200);
            this.btnAgregarColumna.Name = "btnAgregarColumna";
            this.btnAgregarColumna.Size = new System.Drawing.Size(115, 32);
            this.btnAgregarColumna.TabIndex = 24;
            this.btnAgregarColumna.Text = "Add Column";
            this.btnAgregarColumna.UseVisualStyleBackColor = true;
            this.btnAgregarColumna.Click += new System.EventHandler(this.btnAgregarColumna_Click);
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(447, 210);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(100, 22);
            this.txtDefaultValue.TabIndex = 23;
            // 
            // checkNull
            // 
            this.checkNull.AutoSize = true;
            this.checkNull.Location = new System.Drawing.Point(372, 210);
            this.checkNull.Name = "checkNull";
            this.checkNull.Size = new System.Drawing.Size(18, 17);
            this.checkNull.TabIndex = 22;
            this.checkNull.UseVisualStyleBackColor = true;
            // 
            // cboDataType
            // 
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "varchar",
            "int",
            "boolean"});
            this.cboDataType.Location = new System.Drawing.Point(208, 210);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(121, 24);
            this.cboDataType.TabIndex = 21;
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(86, 212);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(100, 22);
            this.txtNombreColumna.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = " Default Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Not Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = " Data Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = " Column Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nuevo Nombre:";
            // 
            // txtNuevoNombreTabla
            // 
            this.txtNuevoNombreTabla.Location = new System.Drawing.Point(184, 292);
            this.txtNuevoNombreTabla.Name = "txtNuevoNombreTabla";
            this.txtNuevoNombreTabla.Size = new System.Drawing.Size(162, 22);
            this.txtNuevoNombreTabla.TabIndex = 26;
            // 
            // btnRenombrar
            // 
            this.btnRenombrar.Location = new System.Drawing.Point(620, 292);
            this.btnRenombrar.Name = "btnRenombrar";
            this.btnRenombrar.Size = new System.Drawing.Size(115, 32);
            this.btnRenombrar.TabIndex = 27;
            this.btnRenombrar.Text = "Rename Table";
            this.btnRenombrar.UseVisualStyleBackColor = true;
            this.btnRenombrar.Click += new System.EventHandler(this.btnRenombrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(768, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(768, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(768, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // btnRefreshColumn
            // 
            this.btnRefreshColumn.Location = new System.Drawing.Point(620, 107);
            this.btnRefreshColumn.Name = "btnRefreshColumn";
            this.btnRefreshColumn.Size = new System.Drawing.Size(125, 34);
            this.btnRefreshColumn.TabIndex = 3;
            this.btnRefreshColumn.Text = "Refresh Columns";
            this.btnRefreshColumn.UseVisualStyleBackColor = true;
            this.btnRefreshColumn.Click += new System.EventHandler(this.btnDropColumn_Click);
            // 
            // cboColumnas
            // 
            this.cboColumnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnas.FormattingEnabled = true;
            this.cboColumnas.Location = new System.Drawing.Point(184, 107);
            this.cboColumnas.Name = "cboColumnas";
            this.cboColumnas.Size = new System.Drawing.Size(162, 24);
            this.cboColumnas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Columns:";
            // 
            // EditTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRenombrar);
            this.Controls.Add(this.txtNuevoNombreTabla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregarColumna);
            this.Controls.Add(this.txtDefaultValue);
            this.Controls.Add(this.checkNull);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.txtNombreColumna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshColumn);
            this.Controls.Add(this.cboColumnas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreTabla);
            this.Name = "EditTable";
            this.Text = "EditTable";
            this.Load += new System.EventHandler(this.EditTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTabla;
        private System.Windows.Forms.Button btnAgregarColumna;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.CheckBox checkNull;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevoNombreTabla;
        private System.Windows.Forms.Button btnRenombrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefreshColumn;
        private System.Windows.Forms.ComboBox cboColumnas;
        private System.Windows.Forms.Label label1;
    }
}