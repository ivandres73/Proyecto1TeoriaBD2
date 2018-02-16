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
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboListas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboObjetos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cboListasAlter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboObjetosAlter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboWhereColumna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tablaVistas = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.cboUserTables = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboViews = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.cboSetColumn = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtWhereColumn = new System.Windows.Forms.TextBox();
            this.cboWhereColumn = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tab1.SuspendLayout();
            this.systemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            this.createTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVistas)).BeginInit();
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
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Location = new System.Drawing.Point(13, 4);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(994, 510);
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
            this.systemTab.Size = new System.Drawing.Size(986, 456);
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
            this.createTab.Size = new System.Drawing.Size(986, 456);
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
            "view"});
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
            this.tabPage1.Controls.Add(this.cboTable);
            this.tabPage1.Controls.Add(this.lblTable);
            this.tabPage1.Controls.Add(this.btnBorrar);
            this.tabPage1.Controls.Add(this.cboListas);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cboObjetos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(986, 456);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Location = new System.Drawing.Point(125, 139);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(191, 24);
            this.cboTable.TabIndex = 6;
            this.cboTable.SelectedIndexChanged += new System.EventHandler(this.cboTable_SelectedIndexChanged);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(13, 139);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(79, 17);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "From table:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(348, 231);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(79, 27);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cboListas
            // 
            this.cboListas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListas.FormattingEnabled = true;
            this.cboListas.Location = new System.Drawing.Point(125, 231);
            this.cboListas.Name = "cboListas";
            this.cboListas.Size = new System.Drawing.Size(191, 24);
            this.cboListas.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista";
            // 
            // cboObjetos
            // 
            this.cboObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjetos.FormattingEnabled = true;
            this.cboObjetos.Items.AddRange(new object[] {
            "table",
            "index",
            "trigger",
            "view"});
            this.cboObjetos.Location = new System.Drawing.Point(125, 46);
            this.cboObjetos.Name = "cboObjetos";
            this.cboObjetos.Size = new System.Drawing.Size(191, 24);
            this.cboObjetos.TabIndex = 1;
            this.cboObjetos.SelectedIndexChanged += new System.EventHandler(this.cboObjetos_SelectedIndexChanged);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cboListasAlter);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cboObjetosAlter);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(986, 456);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Alter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboListasAlter
            // 
            this.cboListasAlter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListasAlter.FormattingEnabled = true;
            this.cboListasAlter.Location = new System.Drawing.Point(129, 223);
            this.cboListasAlter.Name = "cboListasAlter";
            this.cboListasAlter.Size = new System.Drawing.Size(182, 24);
            this.cboListasAlter.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista";
            // 
            // cboObjetosAlter
            // 
            this.cboObjetosAlter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObjetosAlter.FormattingEnabled = true;
            this.cboObjetosAlter.Items.AddRange(new object[] {
            "table",
            "index",
            "trigger",
            "view"});
            this.cboObjetosAlter.Location = new System.Drawing.Point(130, 46);
            this.cboObjetosAlter.Name = "cboObjetosAlter";
            this.cboObjetosAlter.Size = new System.Drawing.Size(182, 24);
            this.cboObjetosAlter.TabIndex = 6;
            this.cboObjetosAlter.SelectedValueChanged += new System.EventHandler(this.cboObjetosAlter_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Objeto:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtWhereColumn);
            this.tabPage3.Controls.Add(this.cboWhereColumn);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtNewValue);
            this.tabPage3.Controls.Add(this.cboSetColumn);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.btnView);
            this.tabPage3.Controls.Add(this.cboViews);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtValue);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cboWhereColumna);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnDeleteRow);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.tablaVistas);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.cboUserTables);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(986, 481);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "User Tables";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(889, 369);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(83, 22);
            this.txtValue.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(851, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "is:";
            // 
            // cboWhereColumna
            // 
            this.cboWhereColumna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWhereColumna.FormattingEnabled = true;
            this.cboWhereColumna.Location = new System.Drawing.Point(851, 329);
            this.cboWhereColumna.Name = "cboWhereColumna";
            this.cboWhereColumna.Size = new System.Drawing.Size(121, 24);
            this.cboWhereColumna.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(882, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Where";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteRow.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnDeleteRow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDeleteRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteRow.Location = new System.Drawing.Point(746, 408);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(99, 26);
            this.btnDeleteRow.TabIndex = 5;
            this.btnDeleteRow.Text = "Delete Row";
            this.btnDeleteRow.UseVisualStyleBackColor = false;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add Row";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tablaVistas
            // 
            this.tablaVistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVistas.Location = new System.Drawing.Point(59, 132);
            this.tablaVistas.Name = "tablaVistas";
            this.tablaVistas.RowTemplate.Height = 24;
            this.tablaVistas.Size = new System.Drawing.Size(786, 254);
            this.tablaVistas.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(363, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Refresh List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboUserTables
            // 
            this.cboUserTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserTables.FormattingEnabled = true;
            this.cboUserTables.Location = new System.Drawing.Point(59, 38);
            this.cboUserTables.Name = "cboUserTables";
            this.cboUserTables.Size = new System.Drawing.Size(150, 24);
            this.cboUserTables.TabIndex = 0;
            this.cboUserTables.SelectedIndexChanged += new System.EventHandler(this.cboUserTables_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Views:";
            // 
            // cboViews
            // 
            this.cboViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViews.FormattingEnabled = true;
            this.cboViews.Location = new System.Drawing.Point(719, 35);
            this.cboViews.Name = "cboViews";
            this.cboViews.Size = new System.Drawing.Size(126, 24);
            this.cboViews.TabIndex = 11;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(866, 36);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnView.Size = new System.Drawing.Size(81, 26);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "Execute";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 26);
            this.button3.TabIndex = 13;
            this.button3.Text = "Update Row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtNewValue
            // 
            this.txtNewValue.Location = new System.Drawing.Point(479, 408);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(83, 22);
            this.txtNewValue.TabIndex = 15;
            // 
            // cboSetColumn
            // 
            this.cboSetColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetColumn.FormattingEnabled = true;
            this.cboSetColumn.Location = new System.Drawing.Point(341, 408);
            this.cboSetColumn.Name = "cboSetColumn";
            this.cboSetColumn.Size = new System.Drawing.Size(121, 24);
            this.cboSetColumn.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 449);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Where:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "New Value";
            // 
            // txtWhereColumn
            // 
            this.txtWhereColumn.Location = new System.Drawing.Point(497, 446);
            this.txtWhereColumn.Name = "txtWhereColumn";
            this.txtWhereColumn.Size = new System.Drawing.Size(83, 22);
            this.txtWhereColumn.TabIndex = 19;
            // 
            // cboWhereColumn
            // 
            this.cboWhereColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWhereColumn.FormattingEnabled = true;
            this.cboWhereColumn.Location = new System.Drawing.Point(341, 446);
            this.cboWhereColumn.Name = "cboWhereColumn";
            this.cboWhereColumn.Size = new System.Drawing.Size(121, 24);
            this.cboWhereColumn.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Set";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 526);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVistas)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboListasAlter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboObjetosAlter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboUserTables;
        private System.Windows.Forms.DataGridView tablaVistas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cboWhereColumna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox cboViews;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWhereColumn;
        private System.Windows.Forms.ComboBox cboWhereColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.ComboBox cboSetColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
    }
}

