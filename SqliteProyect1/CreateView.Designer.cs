namespace SqliteProyect1
{
    partial class CreateView
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
            this.viewBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewBox
            // 
            this.viewBox.Location = new System.Drawing.Point(148, 170);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(340, 142);
            this.viewBox.TabIndex = 0;
            this.viewBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = " Nombre del view:";
            // 
            // txtViewName
            // 
            this.txtViewName.Location = new System.Drawing.Point(148, 53);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.Size = new System.Drawing.Size(159, 22);
            this.txtViewName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " Sentencia Select:";
            // 
            // CreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtViewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewBox);
            this.Name = "CreateView";
            this.Text = "CreateView";
            this.Load += new System.EventHandler(this.CreateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox viewBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViewName;
        private System.Windows.Forms.Label label2;
    }
}