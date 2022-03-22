namespace Lab_Final_200042151
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.attLabel = new System.Windows.Forms.Label();
            this.quiz1label = new System.Windows.Forms.Label();
            this.quiz3label = new System.Windows.Forms.Label();
            this.quiz2label = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.midLabel = new System.Windows.Forms.Label();
            this.quizTotal = new System.Windows.Forms.Label();
            this.quiz4label = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.vivaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "IUT Result Processing System";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(32, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(541, 468);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name : Object Oriented Concepts";
            // 
            // studentIdBox
            // 
            this.studentIdBox.Location = new System.Drawing.Point(880, 90);
            this.studentIdBox.Name = "studentIdBox";
            this.studentIdBox.Size = new System.Drawing.Size(238, 22);
            this.studentIdBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Id :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(880, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Serach by ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchByID);
            // 
            // attLabel
            // 
            this.attLabel.AutoSize = true;
            this.attLabel.Location = new System.Drawing.Point(738, 232);
            this.attLabel.Name = "attLabel";
            this.attLabel.Size = new System.Drawing.Size(81, 16);
            this.attLabel.TabIndex = 6;
            this.attLabel.Text = "Attendance :";
            // 
            // quiz1label
            // 
            this.quiz1label.AutoSize = true;
            this.quiz1label.Location = new System.Drawing.Point(739, 261);
            this.quiz1label.Name = "quiz1label";
            this.quiz1label.Size = new System.Drawing.Size(49, 16);
            this.quiz1label.TabIndex = 7;
            this.quiz1label.Text = "Quiz 1 :";
            // 
            // quiz3label
            // 
            this.quiz3label.AutoSize = true;
            this.quiz3label.Location = new System.Drawing.Point(739, 319);
            this.quiz3label.Name = "quiz3label";
            this.quiz3label.Size = new System.Drawing.Size(49, 16);
            this.quiz3label.TabIndex = 9;
            this.quiz3label.Text = "Quiz 3 :";
            this.quiz3label.Click += new System.EventHandler(this.label5_Click);
            // 
            // quiz2label
            // 
            this.quiz2label.AutoSize = true;
            this.quiz2label.Location = new System.Drawing.Point(739, 290);
            this.quiz2label.Name = "quiz2label";
            this.quiz2label.Size = new System.Drawing.Size(49, 16);
            this.quiz2label.TabIndex = 8;
            this.quiz2label.Text = "Quiz 2 :";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Location = new System.Drawing.Point(739, 432);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(42, 16);
            this.finalLabel.TabIndex = 13;
            this.finalLabel.Text = "Final :";
            // 
            // midLabel
            // 
            this.midLabel.AutoSize = true;
            this.midLabel.Location = new System.Drawing.Point(739, 403);
            this.midLabel.Name = "midLabel";
            this.midLabel.Size = new System.Drawing.Size(35, 16);
            this.midLabel.TabIndex = 12;
            this.midLabel.Text = "Mid :";
            // 
            // quizTotal
            // 
            this.quizTotal.AutoSize = true;
            this.quizTotal.Location = new System.Drawing.Point(739, 374);
            this.quizTotal.Name = "quizTotal";
            this.quizTotal.Size = new System.Drawing.Size(121, 16);
            this.quizTotal.TabIndex = 11;
            this.quizTotal.Text = "Quiz Total (Best 3) :";
            // 
            // quiz4label
            // 
            this.quiz4label.AutoSize = true;
            this.quiz4label.Location = new System.Drawing.Point(739, 345);
            this.quiz4label.Name = "quiz4label";
            this.quiz4label.Size = new System.Drawing.Size(49, 16);
            this.quiz4label.TabIndex = 10;
            this.quiz4label.Text = "Quiz 4 :";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(739, 546);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(51, 16);
            this.gradeLabel.TabIndex = 17;
            this.gradeLabel.Text = "Grade :";
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(739, 517);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(83, 16);
            this.percentLabel.TabIndex = 16;
            this.percentLabel.Text = "Percentage :";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(739, 488);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(113, 16);
            this.TotalLabel.TabIndex = 15;
            this.TotalLabel.Text = "Total (Out of 300) :";
            // 
            // vivaLabel
            // 
            this.vivaLabel.AutoSize = true;
            this.vivaLabel.Location = new System.Drawing.Point(739, 459);
            this.vivaLabel.Name = "vivaLabel";
            this.vivaLabel.Size = new System.Drawing.Size(40, 16);
            this.vivaLabel.TabIndex = 14;
            this.vivaLabel.Text = "Viva :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(947, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Developed by :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(1048, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "200042151";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 693);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.vivaLabel);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.midLabel);
            this.Controls.Add(this.quizTotal);
            this.Controls.Add(this.quiz4label);
            this.Controls.Add(this.quiz3label);
            this.Controls.Add(this.quiz2label);
            this.Controls.Add(this.quiz1label);
            this.Controls.Add(this.attLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentIdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label attLabel;
        private System.Windows.Forms.Label quiz1label;
        private System.Windows.Forms.Label quiz3label;
        private System.Windows.Forms.Label quiz2label;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label midLabel;
        private System.Windows.Forms.Label quizTotal;
        private System.Windows.Forms.Label quiz4label;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label vivaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

