
namespace SQLTraceBook.GUI
{
    partial class BookTrace_Form
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
            this.labelBlock = new System.Windows.Forms.Label();
            this.labelStName = new System.Windows.Forms.Label();
            this.textBoxSTname = new System.Windows.Forms.TextBox();
            this.labeltitelbook = new System.Windows.Forms.Label();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
            this.comboBoxTitel = new System.Windows.Forms.ComboBox();
            this.labelidbook = new System.Windows.Forms.Label();
            this.comboBoxIDBOOK = new System.Windows.Forms.ComboBox();
            this.labelDateOut = new System.Windows.Forms.Label();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.labelDateDue = new System.Windows.Forms.Label();
            this.dateTimePickerDateDue = new System.Windows.Forms.DateTimePicker();
            this.buttonInsertindb = new System.Windows.Forms.Button();
            this.buttonDeleteDB = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxtotal = new System.Windows.Forms.TextBox();
            this.buttontotal = new System.Windows.Forms.Button();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonsum = new System.Windows.Forms.Button();
            this.textBoxsun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Location = new System.Drawing.Point(40, 27);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(42, 17);
            this.labelBlock.TabIndex = 0;
            this.labelBlock.Text = "Block";
            // 
            // labelStName
            // 
            this.labelStName.AutoSize = true;
            this.labelStName.Location = new System.Drawing.Point(200, 38);
            this.labelStName.Name = "labelStName";
            this.labelStName.Size = new System.Drawing.Size(66, 17);
            this.labelStName.TabIndex = 2;
            this.labelStName.Text = "St_Name";
            // 
            // textBoxSTname
            // 
            this.textBoxSTname.Location = new System.Drawing.Point(179, 57);
            this.textBoxSTname.Name = "textBoxSTname";
            this.textBoxSTname.Size = new System.Drawing.Size(137, 22);
            this.textBoxSTname.TabIndex = 3;
            // 
            // labeltitelbook
            // 
            this.labeltitelbook.AutoSize = true;
            this.labeltitelbook.Location = new System.Drawing.Point(372, 38);
            this.labeltitelbook.Name = "labeltitelbook";
            this.labeltitelbook.Size = new System.Drawing.Size(87, 17);
            this.labeltitelbook.TabIndex = 4;
            this.labeltitelbook.Text = "Titel of Book";
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxBlock.Location = new System.Drawing.Point(43, 53);
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBlock.TabIndex = 5;
            this.comboBoxBlock.SelectedIndexChanged += new System.EventHandler(this.comboBoxBlock_SelectedIndexChanged);
            // 
            // comboBoxTitel
            // 
            this.comboBoxTitel.FormattingEnabled = true;
            this.comboBoxTitel.Items.AddRange(new object[] {
            "War & peace",
            "Miserable",
            "Ana Karnina",
            "1984",
            "Animal farm"});
            this.comboBoxTitel.Location = new System.Drawing.Point(375, 59);
            this.comboBoxTitel.Name = "comboBoxTitel";
            this.comboBoxTitel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTitel.TabIndex = 6;
            // 
            // labelidbook
            // 
            this.labelidbook.AutoSize = true;
            this.labelidbook.Location = new System.Drawing.Point(554, 38);
            this.labelidbook.Name = "labelidbook";
            this.labelidbook.Size = new System.Drawing.Size(57, 17);
            this.labelidbook.TabIndex = 7;
            this.labelidbook.Text = "ID Book";
            // 
            // comboBoxIDBOOK
            // 
            this.comboBoxIDBOOK.FormattingEnabled = true;
            this.comboBoxIDBOOK.Items.AddRange(new object[] {
            "10123",
            "21536",
            "85362",
            "63444",
            "88997"});
            this.comboBoxIDBOOK.Location = new System.Drawing.Point(539, 57);
            this.comboBoxIDBOOK.Name = "comboBoxIDBOOK";
            this.comboBoxIDBOOK.Size = new System.Drawing.Size(79, 24);
            this.comboBoxIDBOOK.TabIndex = 8;
            // 
            // labelDateOut
            // 
            this.labelDateOut.AutoSize = true;
            this.labelDateOut.Location = new System.Drawing.Point(720, 37);
            this.labelDateOut.Name = "labelDateOut";
            this.labelDateOut.Size = new System.Drawing.Size(72, 17);
            this.labelDateOut.TabIndex = 9;
            this.labelDateOut.Text = "Date OUT";
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(692, 57);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOut.TabIndex = 10;
            // 
            // labelDateDue
            // 
            this.labelDateDue.AutoSize = true;
            this.labelDateDue.Location = new System.Drawing.Point(987, 38);
            this.labelDateDue.Name = "labelDateDue";
            this.labelDateDue.Size = new System.Drawing.Size(68, 17);
            this.labelDateDue.TabIndex = 11;
            this.labelDateDue.Text = "Date Due";
            // 
            // dateTimePickerDateDue
            // 
            this.dateTimePickerDateDue.Location = new System.Drawing.Point(951, 60);
            this.dateTimePickerDateDue.Name = "dateTimePickerDateDue";
            this.dateTimePickerDateDue.Size = new System.Drawing.Size(219, 22);
            this.dateTimePickerDateDue.TabIndex = 12;
            // 
            // buttonInsertindb
            // 
            this.buttonInsertindb.Location = new System.Drawing.Point(1099, 116);
            this.buttonInsertindb.Name = "buttonInsertindb";
            this.buttonInsertindb.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertindb.TabIndex = 13;
            this.buttonInsertindb.Text = "Insert DB";
            this.buttonInsertindb.UseVisualStyleBackColor = true;
            this.buttonInsertindb.Click += new System.EventHandler(this.buttonInsertindb_Click);
            // 
            // buttonDeleteDB
            // 
            this.buttonDeleteDB.Location = new System.Drawing.Point(1095, 167);
            this.buttonDeleteDB.Name = "buttonDeleteDB";
            this.buttonDeleteDB.Size = new System.Drawing.Size(79, 25);
            this.buttonDeleteDB.TabIndex = 14;
            this.buttonDeleteDB.Text = "Delete ";
            this.buttonDeleteDB.UseVisualStyleBackColor = true;
            this.buttonDeleteDB.Click += new System.EventHandler(this.buttonDeleteDB_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1099, 212);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(1099, 260);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 16;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1099, 316);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(106, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(749, 306);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.BackColorChanged += new System.EventHandler(this.buttonClear_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Block";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ST_Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Titel_Book";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Book_ID";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date_OUT";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date_DUE";
            this.columnHeader6.Width = 120;
            // 
            // textBoxtotal
            // 
            this.textBoxtotal.Location = new System.Drawing.Point(962, 167);
            this.textBoxtotal.Name = "textBoxtotal";
            this.textBoxtotal.Size = new System.Drawing.Size(93, 22);
            this.textBoxtotal.TabIndex = 20;
            // 
            // buttontotal
            // 
            this.buttontotal.Location = new System.Drawing.Point(951, 132);
            this.buttontotal.Name = "buttontotal";
            this.buttontotal.Size = new System.Drawing.Size(104, 29);
            this.buttontotal.TabIndex = 21;
            this.buttontotal.Text = "Total Row";
            this.buttontotal.UseVisualStyleBackColor = true;
            this.buttontotal.Click += new System.EventHandler(this.buttontotal_Click);
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(203, 97);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch.TabIndex = 22;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(969, 243);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(75, 23);
            this.buttonupdate.TabIndex = 23;
            this.buttonupdate.Text = "UPDATE";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonsum
            // 
            this.buttonsum.Location = new System.Drawing.Point(980, 301);
            this.buttonsum.Name = "buttonsum";
            this.buttonsum.Size = new System.Drawing.Size(75, 23);
            this.buttonsum.TabIndex = 24;
            this.buttonsum.Text = "SUM";
            this.buttonsum.UseVisualStyleBackColor = true;
            this.buttonsum.Click += new System.EventHandler(this.buttonsum_Click);
            // 
            // textBoxsun
            // 
            this.textBoxsun.Location = new System.Drawing.Point(969, 350);
            this.textBoxsun.Name = "textBoxsun";
            this.textBoxsun.Size = new System.Drawing.Size(100, 22);
            this.textBoxsun.TabIndex = 25;
            // 
            // BookTrace_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1238, 450);
            this.Controls.Add(this.textBoxsun);
            this.Controls.Add(this.buttonsum);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonsearch);
            this.Controls.Add(this.buttontotal);
            this.Controls.Add(this.textBoxtotal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDeleteDB);
            this.Controls.Add(this.buttonInsertindb);
            this.Controls.Add(this.dateTimePickerDateDue);
            this.Controls.Add(this.labelDateDue);
            this.Controls.Add(this.dateTimePickerDateOut);
            this.Controls.Add(this.labelDateOut);
            this.Controls.Add(this.comboBoxIDBOOK);
            this.Controls.Add(this.labelidbook);
            this.Controls.Add(this.comboBoxTitel);
            this.Controls.Add(this.comboBoxBlock);
            this.Controls.Add(this.labeltitelbook);
            this.Controls.Add(this.textBoxSTname);
            this.Controls.Add(this.labelStName);
            this.Controls.Add(this.labelBlock);
            this.Name = "BookTrace_Form";
            this.Text = "BookTrace_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBlock;
        private System.Windows.Forms.Label labelStName;
        private System.Windows.Forms.TextBox textBoxSTname;
        private System.Windows.Forms.Label labeltitelbook;
        private System.Windows.Forms.ComboBox comboBoxBlock;
        private System.Windows.Forms.ComboBox comboBoxTitel;
        private System.Windows.Forms.Label labelidbook;
        private System.Windows.Forms.ComboBox comboBoxIDBOOK;
        private System.Windows.Forms.Label labelDateOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.Label labelDateDue;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDue;
        private System.Windows.Forms.Button buttonInsertindb;
        private System.Windows.Forms.Button buttonDeleteDB;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxtotal;
        private System.Windows.Forms.Button buttontotal;
        private System.Windows.Forms.Button buttonsearch;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonsum;
        private System.Windows.Forms.TextBox textBoxsun;
    }
}