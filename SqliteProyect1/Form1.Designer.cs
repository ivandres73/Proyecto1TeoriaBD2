namespace SqliteProyect1
{
    partial class Form1
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.systemTab = new System.Windows.Forms.TabPage();
            this.cboObjects = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.vista = new System.Windows.Forms.DataGridView();
            this.createTab = new System.Windows.Forms.TabPage();
            this.cboObjectsCreate = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cboObjetos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboListas = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.systemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.createTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de objeto";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.systemTab);
            this.tab1.Controls.Add(this.createTab);
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Location = new System.Drawing.Point(13, 4);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(979, 485);
            this.tab1.TabIndex = 4;
            // 
            // systemTab
            // 
            this.systemTab.Controls.Add(this.cboObjects);
            this.systemTab.Controls.Add(this.btnListar);
            this.systemTab.Controls.Add(this.vista);
            this.systemTab.Location = new System.Drawing.Point(4, 25);
            this.systemTab.Name = "systemTab";
            this.systemTab.Padding = new System.Windows.Forms.Padding(3);
            this.systemTab.Size = new System.Drawing.Size(971, 456);
            this.systemTab.TabIndex = 0;
            this.systemTab.Text = "System Table";
            this.systemTab.UseVisualStyleBackColor = true;
            // 
            // cboObjects
            // 
            this.cboObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjects.FormattingEnabled = true;
            this.cboObjects.Items.AddRange(new object[] {
            "table",
            "index",
            "trigger",
            "view",
            "constraint"});
            this.cboObjects.Location = new System.Drawing.Point(53, 61);
            this.cboObjects.Name = "cboObjects";
            this.cboObjects.Size = new System.Drawing.Size(121, 24);
            this.cboObjects.TabIndex = 5;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(452, 61);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // vista
            // 
            this.vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vista.Location = new System.Drawing.Point(53, 141);
            this.vista.Name = "vista";
            this.vista.RowTemplate.Height = 24;
            this.vista.Size = new System.Drawing.Size(865, 254);
            this.vista.TabIndex = 3;
            // 
            // createTab
            // 
            this.createTab.Controls.Add(this.cboObjectsCreate);
            this.createTab.Controls.Add(this.button2);
            this.createTab.Location = new System.Drawing.Point(4, 25);
            this.createTab.Name = "createTab";
            this.createTab.Padding = new System.Windows.Forms.Padding(3);
            this.createTab.Size = new System.Drawing.Size(971, 456);
            this.createTab.TabIndex = 1;
            this.createTab.Text = "Create";
            this.createTab.UseVisualStyleBackColor = true;
            // 
            // cboObjectsCreate
            // 
            this.cboObjectsCreate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjectsCreate.FormattingEnabled = true;
            this.cboObjectsCreate.Items.AddRange(new object[] {
            "table",
            "index",
            "trigger",
            "view",
            "constraint"});
            this.cboObjectsCreate.Location = new System.Drawing.Point(59, 42);
            this.cboObjectsCreate.Name = "cboObjectsCreate";
            this.cboObjectsCreate.Size = new System.Drawing.Size(121, 24);
            this.cboObjectsCreate.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBorrar);
            this.tabPage1.Controls.Add(this.cboListas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboObjetos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Objeto:";
            // 
            // cboObjetos
            // 
            this.cboObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjetos.FormattingEnabled = true;
            this.cboObjetos.Items.AddRange(new object[] {
            "table",
            "index",
            "trigger",
            "view",
            "constraint"});
            this.cboObjetos.Location = new System.Drawing.Point(125, 46);
            this.cboObjetos.Name = "cboObjetos";
            this.cboObjetos.Size = new System.Drawing.Size(142, 24);
            this.cboObjetos.TabIndex = 1;
            this.cboObjetos.SelectedIndexChanged += new System.EventHandler(this.cboObjetos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista";
            // 
            // cboListas
            // 
            this.cboListas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListas.FormattingEnabled = true;
            this.cboListas.Location = new System.Drawing.Point(125, 142);
            this.cboListas.Name = "cboListas";
            this.cboListas.Size = new System.Drawing.Size(142, 24);
            this.cboListas.TabIndex = 3;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(306, 145);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(79, 27);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 501);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Toeria 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab1.ResumeLayout(false);
            this.systemTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            this.createTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage systemTab;
        private System.Windows.Forms.ComboBox cboObjects;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView vista;
        private System.Windows.Forms.TabPage createTab;
        private System.Windows.Forms.ComboBox cboObjectsCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboObjetos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboListas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrar;
    }
}

