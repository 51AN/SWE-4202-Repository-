namespace Lab_task_04
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bIDbox = new System.Windows.Forms.TextBox();
            this.bTitleBox = new System.Windows.Forms.TextBox();
            this.bAuthorBox = new System.Windows.Forms.TextBox();
            this.BPublisherBox = new System.Windows.Forms.TextBox();
            this.BQuantityBox = new System.Windows.Forms.TextBox();
            this.ISBNbox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.ArPubDateBOx = new System.Windows.Forms.TextBox();
            this.DOIbox = new System.Windows.Forms.TextBox();
            this.ArQuantity = new System.Windows.Forms.TextBox();
            this.ArPublisherBOx = new System.Windows.Forms.TextBox();
            this.ArAuthorBox = new System.Windows.Forms.TextBox();
            this.ArTItleBox = new System.Windows.Forms.TextBox();
            this.ArIDBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.JournalBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.StudyBookListBox = new System.Windows.Forms.ListBox();
            this.ResearchArticleListBox = new System.Windows.Forms.ListBox();
            this.ArticleIDshowBox = new System.Windows.Forms.TextBox();
            this.BookIDShowBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Study Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Research  Article";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Publisher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "ISBN No.";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Genre";
            // 
            // bIDbox
            // 
            this.bIDbox.Location = new System.Drawing.Point(117, 44);
            this.bIDbox.Name = "bIDbox";
            this.bIDbox.Size = new System.Drawing.Size(158, 22);
            this.bIDbox.TabIndex = 9;
            // 
            // bTitleBox
            // 
            this.bTitleBox.Location = new System.Drawing.Point(117, 75);
            this.bTitleBox.Name = "bTitleBox";
            this.bTitleBox.Size = new System.Drawing.Size(158, 22);
            this.bTitleBox.TabIndex = 10;
            // 
            // bAuthorBox
            // 
            this.bAuthorBox.Location = new System.Drawing.Point(117, 103);
            this.bAuthorBox.Name = "bAuthorBox";
            this.bAuthorBox.Size = new System.Drawing.Size(158, 22);
            this.bAuthorBox.TabIndex = 11;
            // 
            // BPublisherBox
            // 
            this.BPublisherBox.Location = new System.Drawing.Point(117, 131);
            this.BPublisherBox.Name = "BPublisherBox";
            this.BPublisherBox.Size = new System.Drawing.Size(158, 22);
            this.BPublisherBox.TabIndex = 12;
            // 
            // BQuantityBox
            // 
            this.BQuantityBox.Location = new System.Drawing.Point(117, 159);
            this.BQuantityBox.Name = "BQuantityBox";
            this.BQuantityBox.Size = new System.Drawing.Size(158, 22);
            this.BQuantityBox.TabIndex = 13;
            // 
            // ISBNbox
            // 
            this.ISBNbox.Location = new System.Drawing.Point(117, 187);
            this.ISBNbox.Name = "ISBNbox";
            this.ISBNbox.Size = new System.Drawing.Size(158, 22);
            this.ISBNbox.TabIndex = 14;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(117, 215);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(158, 22);
            this.GenreBox.TabIndex = 15;
            // 
            // ArPubDateBOx
            // 
            this.ArPubDateBOx.Location = new System.Drawing.Point(117, 511);
            this.ArPubDateBOx.Name = "ArPubDateBOx";
            this.ArPubDateBOx.Size = new System.Drawing.Size(158, 22);
            this.ArPubDateBOx.TabIndex = 29;
            // 
            // DOIbox
            // 
            this.DOIbox.Location = new System.Drawing.Point(117, 483);
            this.DOIbox.Name = "DOIbox";
            this.DOIbox.Size = new System.Drawing.Size(158, 22);
            this.DOIbox.TabIndex = 28;
            // 
            // ArQuantity
            // 
            this.ArQuantity.Location = new System.Drawing.Point(117, 455);
            this.ArQuantity.Name = "ArQuantity";
            this.ArQuantity.Size = new System.Drawing.Size(158, 22);
            this.ArQuantity.TabIndex = 27;
            // 
            // ArPublisherBOx
            // 
            this.ArPublisherBOx.Location = new System.Drawing.Point(117, 427);
            this.ArPublisherBOx.Name = "ArPublisherBOx";
            this.ArPublisherBOx.Size = new System.Drawing.Size(158, 22);
            this.ArPublisherBOx.TabIndex = 26;
            // 
            // ArAuthorBox
            // 
            this.ArAuthorBox.Location = new System.Drawing.Point(117, 399);
            this.ArAuthorBox.Name = "ArAuthorBox";
            this.ArAuthorBox.Size = new System.Drawing.Size(158, 22);
            this.ArAuthorBox.TabIndex = 25;
            // 
            // ArTItleBox
            // 
            this.ArTItleBox.Location = new System.Drawing.Point(117, 371);
            this.ArTItleBox.Name = "ArTItleBox";
            this.ArTItleBox.Size = new System.Drawing.Size(158, 22);
            this.ArTItleBox.TabIndex = 24;
            // 
            // ArIDBox
            // 
            this.ArIDBox.Location = new System.Drawing.Point(117, 340);
            this.ArIDBox.Name = "ArIDBox";
            this.ArIDBox.Size = new System.Drawing.Size(158, 22);
            this.ArIDBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Publisher Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "DOI No.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Publisher";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 399);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Author";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Article Title ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Article ID";
            // 
            // JournalBox
            // 
            this.JournalBox.Location = new System.Drawing.Point(117, 545);
            this.JournalBox.Name = "JournalBox";
            this.JournalBox.Size = new System.Drawing.Size(158, 22);
            this.JournalBox.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 539);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 64);
            this.label17.TabIndex = 30;
            this.label17.Text = "Conference/\r\nJournal(C/J)\r\n\r\n\r\n";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(333, -1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 645);
            this.label18.TabIndex = 32;
            this.label18.Text = "Genre";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(627, -4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 645);
            this.label19.TabIndex = 33;
            this.label19.Text = "Genre";
            // 
            // StudyBookListBox
            // 
            this.StudyBookListBox.FormattingEnabled = true;
            this.StudyBookListBox.ItemHeight = 16;
            this.StudyBookListBox.Location = new System.Drawing.Point(683, 78);
            this.StudyBookListBox.Name = "StudyBookListBox";
            this.StudyBookListBox.Size = new System.Drawing.Size(527, 196);
            this.StudyBookListBox.TabIndex = 35;
            // 
            // ResearchArticleListBox
            // 
            this.ResearchArticleListBox.FormattingEnabled = true;
            this.ResearchArticleListBox.ItemHeight = 16;
            this.ResearchArticleListBox.Location = new System.Drawing.Point(683, 394);
            this.ResearchArticleListBox.Name = "ResearchArticleListBox";
            this.ResearchArticleListBox.Size = new System.Drawing.Size(527, 196);
            this.ResearchArticleListBox.TabIndex = 36;
            // 
            // ArticleIDshowBox
            // 
            this.ArticleIDshowBox.Location = new System.Drawing.Point(383, 181);
            this.ArticleIDshowBox.Name = "ArticleIDshowBox";
            this.ArticleIDshowBox.Size = new System.Drawing.Size(202, 22);
            this.ArticleIDshowBox.TabIndex = 38;
            // 
            // BookIDShowBox
            // 
            this.BookIDShowBox.Location = new System.Drawing.Point(383, 78);
            this.BookIDShowBox.Name = "BookIDShowBox";
            this.BookIDShowBox.Size = new System.Drawing.Size(202, 22);
            this.BookIDShowBox.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(447, 43);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 16);
            this.label21.TabIndex = 41;
            this.label21.Text = "Book ID";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(447, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 16);
            this.label22.TabIndex = 42;
            this.label22.Text = "Article ID";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(-13, 295);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1284, 10);
            this.label20.TabIndex = 34;
            this.label20.Text = "Genre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 75);
            this.button1.TabIndex = 43;
            this.button1.Text = "Show Study Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowStudyBookonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 75);
            this.button2.TabIndex = 44;
            this.button2.Text = "Show Research Article";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowReArOnClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 45;
            this.button3.Text = "Add Book";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddStudyBookButton);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Add Article";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddArticleOnClick);
            // 
            // Borrow
            // 
            this.Borrow.Location = new System.Drawing.Point(441, 106);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(75, 23);
            this.Borrow.TabIndex = 47;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = true;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(441, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 48;
            this.button6.Text = "Borrow";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 631);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Borrow);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.ArticleIDshowBox);
            this.Controls.Add(this.BookIDShowBox);
            this.Controls.Add(this.ResearchArticleListBox);
            this.Controls.Add(this.StudyBookListBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.JournalBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ArPubDateBOx);
            this.Controls.Add(this.DOIbox);
            this.Controls.Add(this.ArQuantity);
            this.Controls.Add(this.ArPublisherBOx);
            this.Controls.Add(this.ArAuthorBox);
            this.Controls.Add(this.ArTItleBox);
            this.Controls.Add(this.ArIDBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.ISBNbox);
            this.Controls.Add(this.BQuantityBox);
            this.Controls.Add(this.BPublisherBox);
            this.Controls.Add(this.bAuthorBox);
            this.Controls.Add(this.bTitleBox);
            this.Controls.Add(this.bIDbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bIDbox;
        private System.Windows.Forms.TextBox bTitleBox;
        private System.Windows.Forms.TextBox bAuthorBox;
        private System.Windows.Forms.TextBox BPublisherBox;
        private System.Windows.Forms.TextBox BQuantityBox;
        private System.Windows.Forms.TextBox ISBNbox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox ArPubDateBOx;
        private System.Windows.Forms.TextBox DOIbox;
        private System.Windows.Forms.TextBox ArQuantity;
        private System.Windows.Forms.TextBox ArPublisherBOx;
        private System.Windows.Forms.TextBox ArAuthorBox;
        private System.Windows.Forms.TextBox ArTItleBox;
        private System.Windows.Forms.TextBox ArIDBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox JournalBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListBox StudyBookListBox;
        private System.Windows.Forms.ListBox ResearchArticleListBox;
        private System.Windows.Forms.TextBox ArticleIDshowBox;
        private System.Windows.Forms.TextBox BookIDShowBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button button6;
    }
}

