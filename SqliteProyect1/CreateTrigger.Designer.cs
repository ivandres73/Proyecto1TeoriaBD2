namespace SqliteProyect1
{
    partial class CreateTrigger
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTablas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbBefore = new System.Windows.Forms.RadioButton();
            this.rdbAfter = new System.Windows.Forms.RadioButton();
            this.txtStatement = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbInsert = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCode = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SqlTrigger = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTriggerName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " Tabla: ";
            // 
            // cboTablas
            // 
            this.cboTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTablas.FormattingEnabled = true;
            this.cboTablas.Location = new System.Drawing.Point(127, 84);
            this.cboTablas.Name = "cboTablas";
            this.cboTablas.Size = new System.Drawing.Size(203, 24);
            this.cboTablas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = " Timing:";
            // 
            // rdbBefore
            // 
            this.rdbBefore.AutoSize = true;
            this.rdbBefore.Location = new System.Drawing.Point(127, 133);
            this.rdbBefore.Name = "rdbBefore";
            this.rdbBefore.Size = new System.Drawing.Size(85, 21);
            this.rdbBefore.TabIndex = 3;
            this.rdbBefore.TabStop = true;
            this.rdbBefore.Text = "BEFORE";
            this.rdbBefore.UseVisualStyleBackColor = true;
            // 
            // rdbAfter
            // 
            this.rdbAfter.AutoSize = true;
            this.rdbAfter.Location = new System.Drawing.Point(262, 135);
            this.rdbAfter.Name = "rdbAfter";
            this.rdbAfter.Size = new System.Drawing.Size(74, 21);
            this.rdbAfter.TabIndex = 4;
            this.rdbAfter.TabStop = true;
            this.rdbAfter.Text = "AFTER";
            this.rdbAfter.UseVisualStyleBackColor = true;
            // 
            // txtStatement
            // 
            this.txtStatement.Location = new System.Drawing.Point(127, 299);
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(263, 163);
            this.txtStatement.TabIndex = 9;
            this.txtStatement.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Statement:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rdbInsert);
            this.groupBox1.Controls.Add(this.rdbUpdate);
            this.groupBox1.Controls.Add(this.rdbDelete);
            this.groupBox1.Location = new System.Drawing.Point(31, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 91);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Event:";
            // 
            // rdbInsert
            // 
            this.rdbInsert.AutoSize = true;
            this.rdbInsert.Location = new System.Drawing.Point(98, 38);
            this.rdbInsert.Name = "rdbInsert";
            this.rdbInsert.Size = new System.Drawing.Size(79, 21);
            this.rdbInsert.TabIndex = 11;
            this.rdbInsert.TabStop = true;
            this.rdbInsert.Text = "INSERT";
            this.rdbInsert.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(218, 38);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(85, 21);
            this.rdbUpdate.TabIndex = 10;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "UPDATE";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(345, 38);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(83, 21);
            this.rdbDelete.TabIndex = 9;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "DELETE";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabCode);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 512);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTriggerName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cboTablas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rdbBefore);
            this.tabPage1.Controls.Add(this.txtStatement);
            this.tabPage1.Controls.Add(this.rdbAfter);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(540, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCode
            // 
            this.tabCode.Controls.Add(this.SqlTrigger);
            this.tabCode.Controls.Add(this.button1);
            this.tabCode.Location = new System.Drawing.Point(4, 25);
            this.tabCode.Name = "tabCode";
            this.tabCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabCode.Size = new System.Drawing.Size(540, 483);
            this.tabCode.TabIndex = 1;
            this.tabCode.Text = " Code";
            this.tabCode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 26);
            this.button2.TabIndex = 13;
            this.button2.Text = "Generate Code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SqlTrigger
            // 
            this.SqlTrigger.Location = new System.Drawing.Point(71, 74);
            this.SqlTrigger.Name = "SqlTrigger";
            this.SqlTrigger.Size = new System.Drawing.Size(357, 284);
            this.SqlTrigger.TabIndex = 14;
            this.SqlTrigger.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre Trigger:";
            // 
            // txtTriggerName
            // 
            this.txtTriggerName.Location = new System.Drawing.Point(129, 33);
            this.txtTriggerName.Name = "txtTriggerName";
            this.txtTriggerName.Size = new System.Drawing.Size(132, 22);
            this.txtTriggerName.TabIndex = 15;
            // 
            // CreateTrigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreateTrigger";
            this.Text = "CreateTrigger";
            this.Load += new System.EventHandler(this.CreateTrigger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTablas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbBefore;
        private System.Windows.Forms.RadioButton rdbAfter;
        private System.Windows.Forms.RichTextBox txtStatement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbInsert;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabCode;
        private System.Windows.Forms.RichTextBox SqlTrigger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTriggerName;
        private System.Windows.Forms.Label label5;
    }
}