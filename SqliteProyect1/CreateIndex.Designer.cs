namespace SqliteProyect1
{
    partial class CreateIndex
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboColumnas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.btnApply = new System.Windows.Forms.Button();
            this.sqlIndex = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkComplejo = new System.Windows.Forms.CheckBox();
            this.cboColumnas2 = new System.Windows.Forms.ComboBox();
            this.lblColumna2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabCode);
            this.tabControl1.Location = new System.Drawing.Point(21, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 395);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboColumnas2);
            this.tabPage1.Controls.Add(this.lblColumna2);
            this.tabPage1.Controls.Add(this.checkComplejo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboColumnas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cboTablas);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visual";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboColumnas
            // 
            this.cboColumnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnas.FormattingEnabled = true;
            this.cboColumnas.Location = new System.Drawing.Point(136, 146);
            this.cboColumnas.Name = "cboColumnas";
            this.cboColumnas.Size = new System.Drawing.Size(184, 24);
            this.cboColumnas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Columna:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTablas
            // 
            this.cboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(136, 78);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(184, 24);
            this.cboTablas.TabIndex = 3;
            this.cboTablas.SelectedIndexChanged += new System.EventHandler(this.cboTablas_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Index:";
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.btnApply);
            this.tabCode.Controls.Add(this.sqlIndex);
            this.tabCode.Location = new System.Drawing.Point(4, 25);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(563, 366);
            this.tabCode.TabIndex = 1;
            this.tabCode.Text = "Code";
            this.tabCode.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(464, 323);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 26);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // sqlIndex
            // 
            this.sqlIndex.Location = new System.Drawing.Point(59, 39);
            this.sqlIndex.Name = "sqlIndex";
            this.sqlIndex.Size = new System.Drawing.Size(294, 209);
            this.sqlIndex.TabIndex = 0;
            this.sqlIndex.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Indice Complejo?";
            // 
            // checkComplejo
            // 
            this.checkComplejo.AutoSize = true;
            this.checkComplejo.Location = new System.Drawing.Point(136, 216);
            this.checkComplejo.Name = "checkComplejo";
            this.checkComplejo.Size = new System.Drawing.Size(18, 17);
            this.checkComplejo.TabIndex = 8;
            this.checkComplejo.UseVisualStyleBackColor = true;
            this.checkComplejo.CheckedChanged += new System.EventHandler(this.checkComplejo_CheckedChanged);
            // 
            // cboColumnas2
            // 
            this.cboColumnas2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnas2.FormattingEnabled = true;
            this.cboColumnas2.Location = new System.Drawing.Point(136, 270);
            this.cboColumnas2.Name = "cboColumnas2";
            this.cboColumnas2.Size = new System.Drawing.Size(184, 24);
            this.cboColumnas2.TabIndex = 10;
            // 
            // lblColumna2
            // 
            this.lblColumna2.AutoSize = true;
            this.lblColumna2.Location = new System.Drawing.Point(47, 270);
            this.lblColumna2.Name = "lblColumna2";
            this.lblColumna2.Size = new System.Drawing.Size(67, 17);
            this.lblColumna2.TabIndex = 9;
            this.lblColumna2.Text = "Columna:";
            // 
            // CreateIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 439);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateIndex";
            this.Text = "CreateIndex";
            this.Load += new System.EventHandler(this.CreateIndex_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox sqlIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboColumnas;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox checkComplejo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboColumnas2;
        private System.Windows.Forms.Label lblColumna2;
    }
}