
namespace Mediaregister_Uppgift_4
{
    partial class FormMediaRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMediaRegister));
            this.listBoxMedia = new System.Windows.Forms.ListBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDownRuntime = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFilm = new System.Windows.Forms.Button();
            this.textBoxFilmTitle = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonBooks = new System.Windows.Forms.RadioButton();
            this.radioButtonFilms = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMedia
            // 
            this.listBoxMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMedia.FormattingEnabled = true;
            this.listBoxMedia.ItemHeight = 15;
            this.listBoxMedia.Location = new System.Drawing.Point(283, 36);
            this.listBoxMedia.Name = "listBoxMedia";
            this.listBoxMedia.Size = new System.Drawing.Size(505, 210);
            this.listBoxMedia.TabIndex = 1;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(83, 22);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(120, 23);
            this.textBoxBookTitle.TabIndex = 2;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(83, 51);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(120, 23);
            this.textBoxAuthor.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(265, 234);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDownPages);
            this.tabPage1.Controls.Add(this.buttonAddBook);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxBookTitle);
            this.tabPage1.Controls.Add(this.textBoxAuthor);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(83, 82);
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPages.TabIndex = 8;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(118, 166);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(85, 23);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Add";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownRuntime);
            this.tabPage2.Controls.Add(this.buttonAddFilm);
            this.tabPage2.Controls.Add(this.textBoxFilmTitle);
            this.tabPage2.Controls.Add(this.textBoxDirector);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add film";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRuntime
            // 
            this.numericUpDownRuntime.Location = new System.Drawing.Point(83, 82);
            this.numericUpDownRuntime.Name = "numericUpDownRuntime";
            this.numericUpDownRuntime.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownRuntime.TabIndex = 8;
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(118, 166);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(85, 23);
            this.buttonAddFilm.TabIndex = 7;
            this.buttonAddFilm.Text = "Add";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // textBoxFilmTitle
            // 
            this.textBoxFilmTitle.Location = new System.Drawing.Point(83, 22);
            this.textBoxFilmTitle.Name = "textBoxFilmTitle";
            this.textBoxFilmTitle.Size = new System.Drawing.Size(120, 23);
            this.textBoxFilmTitle.TabIndex = 5;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(83, 51);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(120, 23);
            this.textBoxDirector.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Runtime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mediaregister_Uppgift_4.Properties.Resources.MediaRegister_Logo1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 101);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 22);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(39, 19);
            this.radioButtonAll.TabIndex = 8;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonBooks
            // 
            this.radioButtonBooks.AutoSize = true;
            this.radioButtonBooks.Location = new System.Drawing.Point(51, 22);
            this.radioButtonBooks.Name = "radioButtonBooks";
            this.radioButtonBooks.Size = new System.Drawing.Size(57, 19);
            this.radioButtonBooks.TabIndex = 9;
            this.radioButtonBooks.Text = "Books";
            this.radioButtonBooks.UseVisualStyleBackColor = true;
            this.radioButtonBooks.CheckedChanged += new System.EventHandler(this.radioButtonBooks_CheckedChanged);
            // 
            // radioButtonFilms
            // 
            this.radioButtonFilms.AutoSize = true;
            this.radioButtonFilms.Location = new System.Drawing.Point(114, 22);
            this.radioButtonFilms.Name = "radioButtonFilms";
            this.radioButtonFilms.Size = new System.Drawing.Size(53, 19);
            this.radioButtonFilms.TabIndex = 10;
            this.radioButtonFilms.Text = "Films";
            this.radioButtonFilms.UseVisualStyleBackColor = true;
            this.radioButtonFilms.CheckedChanged += new System.EventHandler(this.radioButtonFilms_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Controls.Add(this.radioButtonFilms);
            this.groupBox1.Controls.Add(this.radioButtonBooks);
            this.groupBox1.Location = new System.Drawing.Point(283, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 55);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(520, 270);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(85, 23);
            this.buttonClearList.TabIndex = 9;
            this.buttonClearList.Text = "Clear";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(283, 323);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 15);
            this.labelMessage.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 362);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBoxMedia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "   MediaRegister ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRuntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMedia;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilmTitle;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddFilm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.NumericUpDown numericUpDownRuntime;
        private System.Windows.Forms.RadioButton radioButtonBooks;
        private System.Windows.Forms.RadioButton radioButtonFilms;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Label labelMessage;
    }
}

