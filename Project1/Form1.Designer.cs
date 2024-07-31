namespace Project1
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
            this.predict = new System.Windows.Forms.Button();
            this.blName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.timeHeader = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime1 = new System.Windows.Forms.TextBox();
            this.txtTime2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTime3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rosterText = new System.Windows.Forms.Label();
            this.nextRosterBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // predict
            // 
            this.predict.Location = new System.Drawing.Point(138, 392);
            this.predict.Name = "predict";
            this.predict.Size = new System.Drawing.Size(150, 40);
            this.predict.TabIndex = 0;
            this.predict.Text = "Predict next winner";
            this.predict.UseVisualStyleBackColor = true;
            this.predict.Click += new System.EventHandler(this.predict_Click);
            // 
            // blName
            // 
            this.blName.AutoSize = true;
            this.blName.Location = new System.Drawing.Point(19, 32);
            this.blName.Name = "blName";
            this.blName.Size = new System.Drawing.Size(35, 13);
            this.blName.TabIndex = 1;
            this.blName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(87, 72);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(60, 20);
            this.txtAge.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(87, 115);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(60, 20);
            this.txtHeight.TabIndex = 6;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(309, 174);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 7;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // timeHeader
            // 
            this.timeHeader.AutoSize = true;
            this.timeHeader.Location = new System.Drawing.Point(19, 220);
            this.timeHeader.Name = "timeHeader";
            this.timeHeader.Size = new System.Drawing.Size(128, 13);
            this.timeHeader.TabIndex = 8;
            this.timeHeader.Text = "Enter the  last three races";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time 1:";
            // 
            // txtTime1
            // 
            this.txtTime1.Location = new System.Drawing.Point(96, 258);
            this.txtTime1.Name = "txtTime1";
            this.txtTime1.Size = new System.Drawing.Size(288, 20);
            this.txtTime1.TabIndex = 10;
            // 
            // txtTime2
            // 
            this.txtTime2.Location = new System.Drawing.Point(96, 294);
            this.txtTime2.Name = "txtTime2";
            this.txtTime2.Size = new System.Drawing.Size(288, 20);
            this.txtTime2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time 2:";
            // 
            // txtTime3
            // 
            this.txtTime3.Location = new System.Drawing.Point(96, 333);
            this.txtTime3.Name = "txtTime3";
            this.txtTime3.Size = new System.Drawing.Size(288, 20);
            this.txtTime3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Time 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "===================================================";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "===================================================";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Roster for next race";
            // 
            // rosterText
            // 
            this.rosterText.AutoSize = true;
            this.rosterText.Location = new System.Drawing.Point(63, 53);
            this.rosterText.Name = "rosterText";
            this.rosterText.Size = new System.Drawing.Size(0, 13);
            this.rosterText.TabIndex = 18;
            // 
            // nextRosterBox
            // 
            this.nextRosterBox.Location = new System.Drawing.Point(29, 80);
            this.nextRosterBox.Multiline = true;
            this.nextRosterBox.Name = "nextRosterBox";
            this.nextRosterBox.Size = new System.Drawing.Size(472, 278);
            this.nextRosterBox.TabIndex = 19;
            this.nextRosterBox.TextChanged += new System.EventHandler(this.nextRosterBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blName);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtTime3);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.timeHeader);
            this.groupBox1.Controls.Add(this.txtTime2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTime1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 371);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horse";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rosterText);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nextRosterBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(452, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 375);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roster";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.predict);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button predict;
        private System.Windows.Forms.Label blName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label timeHeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime1;
        private System.Windows.Forms.TextBox txtTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTime3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label rosterText;
        private System.Windows.Forms.TextBox nextRosterBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

