namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.Enter_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Completion_button = new System.Windows.Forms.Button();
            this.Enter_age = new System.Windows.Forms.NumericUpDown();
            this.Enter_description = new System.Windows.Forms.TextBox();
            this.Select_male = new System.Windows.Forms.RadioButton();
            this.Select_female = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Enter_age)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // Enter_name
            // 
            this.Enter_name.Location = new System.Drawing.Point(14, 48);
            this.Enter_name.Name = "Enter_name";
            this.Enter_name.Size = new System.Drawing.Size(100, 20);
            this.Enter_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "年齢";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "自己紹介";
            // 
            // Completion_button
            // 
            this.Completion_button.Location = new System.Drawing.Point(197, 267);
            this.Completion_button.Name = "Completion_button";
            this.Completion_button.Size = new System.Drawing.Size(75, 25);
            this.Completion_button.TabIndex = 6;
            this.Completion_button.Text = "登録完了";
            this.Completion_button.UseVisualStyleBackColor = true;
            this.Completion_button.Click += new System.EventHandler(this.Completion_button_Click);
            // 
            // Enter_age
            // 
            this.Enter_age.Location = new System.Drawing.Point(133, 49);
            this.Enter_age.Name = "Enter_age";
            this.Enter_age.Size = new System.Drawing.Size(46, 20);
            this.Enter_age.TabIndex = 7;
            // 
            // Enter_description
            // 
            this.Enter_description.Location = new System.Drawing.Point(15, 88);
            this.Enter_description.Name = "Enter_description";
            this.Enter_description.Size = new System.Drawing.Size(100, 20);
            this.Enter_description.TabIndex = 8;
            // 
            // Select_male
            // 
            this.Select_male.AutoSize = true;
            this.Select_male.Location = new System.Drawing.Point(18, 142);
            this.Select_male.Name = "Select_male";
            this.Select_male.Size = new System.Drawing.Size(49, 17);
            this.Select_male.TabIndex = 12;
            this.Select_male.TabStop = true;
            this.Select_male.Text = "男性";
            this.Select_male.UseVisualStyleBackColor = true;
            // 
            // Select_female
            // 
            this.Select_female.AutoSize = true;
            this.Select_female.Location = new System.Drawing.Point(90, 142);
            this.Select_female.Name = "Select_female";
            this.Select_female.Size = new System.Drawing.Size(49, 17);
            this.Select_female.TabIndex = 13;
            this.Select_female.TabStop = true;
            this.Select_female.Text = "女性";
            this.Select_female.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 307);
            this.Controls.Add(this.Select_female);
            this.Controls.Add(this.Select_male);
            this.Controls.Add(this.Enter_description);
            this.Controls.Add(this.Enter_age);
            this.Controls.Add(this.Completion_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter_name);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Enter_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Enter_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Completion_button;
        private System.Windows.Forms.NumericUpDown Enter_age;
        private System.Windows.Forms.TextBox Enter_description;
        private System.Windows.Forms.RadioButton Select_male;
        private System.Windows.Forms.RadioButton Select_female;
    }
}