namespace SqliteProyect1
{
    partial class CrearTable
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.chechPK = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDefaultValue = new System.Windows.Forms.TextBox();
            this.checkNull = new System.Windows.Forms.CheckBox();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.txtNombreColumna = new System.Windows.Forms.TextBox();
            this.checkPK = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laber47 = new System.Windows.Forms.Label();
            this.txtNombreTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.SqlBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.chechPK.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.chechPK);
            this.tabControl1.Controls.Add(this.tabCode);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // chechPK
            // 
            this.chechPK.Controls.Add(this.button2);
            this.chechPK.Controls.Add(this.button1);
            this.chechPK.Controls.Add(this.txtDefaultValue);
            this.chechPK.Controls.Add(this.checkNull);
            this.chechPK.Controls.Add(this.cboDataType);
            this.chechPK.Controls.Add(this.txtNombreColumna);
            this.chechPK.Controls.Add(this.checkPK);
            this.chechPK.Controls.Add(this.label5);
            this.chechPK.Controls.Add(this.label4);
            this.chechPK.Controls.Add(this.label3);
            this.chechPK.Controls.Add(this.label2);
            this.chechPK.Controls.Add(this.laber47);
            this.chechPK.Controls.Add(this.txtNombreTabla);
            this.chechPK.Controls.Add(this.label1);
            this.chechPK.Location = new System.Drawing.Point(4, 25);
            this.chechPK.Name = "chechPK";
            this.chechPK.Padding = new System.Windows.Forms.Padding(3);
            this.chechPK.Size = new System.Drawing.Size(762, 352);
            this.chechPK.TabIndex = 0;
            this.chechPK.Text = "Visual";
            this.chechPK.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Column";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDefaultValue
            // 
            this.txtDefaultValue.Location = new System.Drawing.Point(440, 144);
            this.txtDefaultValue.Name = "txtDefaultValue";
            this.txtDefaultValue.Size = new System.Drawing.Size(100, 22);
            this.txtDefaultValue.TabIndex = 11;
            // 
            // checkNull
            // 
            this.checkNull.AutoSize = true;
            this.checkNull.Location = new System.Drawing.Point(365, 144);
            this.checkNull.Name = "checkNull";
            this.checkNull.Size = new System.Drawing.Size(18, 17);
            this.checkNull.TabIndex = 10;
            this.checkNull.UseVisualStyleBackColor = true;
            // 
            // cboDataType
            // 
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "varchar",
            "int",
            "boolean"});
            this.cboDataType.Location = new System.Drawing.Point(201, 144);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(121, 24);
            this.cboDataType.TabIndex = 9;
            // 
            // txtNombreColumna
            // 
            this.txtNombreColumna.Location = new System.Drawing.Point(79, 146);
            this.txtNombreColumna.Name = "txtNombreColumna";
            this.txtNombreColumna.Size = new System.Drawing.Size(100, 22);
            this.txtNombreColumna.TabIndex = 8;
            // 
            // checkPK
            // 
            this.checkPK.AutoSize = true;
            this.checkPK.Location = new System.Drawing.Point(26, 146);
            this.checkPK.Name = "checkPK";
            this.checkPK.Size = new System.Drawing.Size(34, 21);
            this.checkPK.TabIndex = 7;
            this.checkPK.Text = " ";
            this.checkPK.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = " Default Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Not Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = " Data Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = " Column Name";
            // 
            // laber47
            // 
            this.laber47.AutoSize = true;
            this.laber47.Location = new System.Drawing.Point(23, 110);
            this.laber47.Name = "laber47";
            this.laber47.Size = new System.Drawing.Size(26, 17);
            this.laber47.TabIndex = 2;
            this.laber47.Text = "PK";
            // 
            // txtNombreTabla
            // 
            this.txtNombreTabla.Location = new System.Drawing.Point(129, 23);
            this.txtNombreTabla.Name = "txtNombreTabla";
            this.txtNombreTabla.Size = new System.Drawing.Size(171, 22);
            this.txtNombreTabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of table:";
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.button3);
            this.tabCode.Controls.Add(this.SqlBox);
            this.tabCode.Location = new System.Drawing.Point(4, 25);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(762, 352);
            this.tabCode.TabIndex = 1;
            this.tabCode.Text = "Code";
            this.tabCode.UseVisualStyleBackColor = true;
            // 
            // SqlBox
            // 
            this.SqlBox.Location = new System.Drawing.Point(37, 83);
            this.SqlBox.Name = "SqlBox";
            this.SqlBox.Size = new System.Drawing.Size(565, 172);
            this.SqlBox.TabIndex = 0;
            this.SqlBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CrearTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 443);
            this.Controls.Add(this.tabControl1);
            this.Name = "CrearTable";
            this.Text = "CrearTable";
            this.tabControl1.ResumeLayout(false);
            this.chechPK.ResumeLayout(false);
            this.chechPK.PerformLayout();
            this.tabCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chechPK;
        private System.Windows.Forms.TextBox txtDefaultValue;
        private System.Windows.Forms.CheckBox checkNull;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.TextBox txtNombreColumna;
        private System.Windows.Forms.CheckBox checkPK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laber47;
        private System.Windows.Forms.TextBox txtNombreTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCode;
        private System.Windows.Forms.RichTextBox SqlBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}