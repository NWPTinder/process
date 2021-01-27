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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // Enter_name
            // 
            this.Enter_name.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Enter_name.Location = new System.Drawing.Point(12, 56);
            this.Enter_name.Name = "Enter_name";
            this.Enter_name.Size = new System.Drawing.Size(100, 25);
            this.Enter_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "年齢";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "自己紹介";
            // 
            // Completion_button
            // 
            this.Completion_button.BackColor = System.Drawing.Color.White;
            this.Completion_button.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Completion_button.ForeColor = System.Drawing.Color.Black;
            this.Completion_button.Location = new System.Drawing.Point(197, 267);
            this.Completion_button.Name = "Completion_button";
            this.Completion_button.Size = new System.Drawing.Size(74, 27);
            this.Completion_button.TabIndex = 6;
            this.Completion_button.Text = "登録完了";
            this.Completion_button.UseVisualStyleBackColor = false;
            this.Completion_button.Click += new System.EventHandler(this.Completion_button_Click);
            // 
            // Enter_age
            // 
            this.Enter_age.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Enter_age.Location = new System.Drawing.Point(131, 56);
            this.Enter_age.Name = "Enter_age";
            this.Enter_age.Size = new System.Drawing.Size(46, 27);
            this.Enter_age.TabIndex = 7;
            // 
            // Enter_description
            // 
            this.Enter_description.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Enter_description.Location = new System.Drawing.Point(12, 129);
            this.Enter_description.Name = "Enter_description";
            this.Enter_description.Size = new System.Drawing.Size(165, 27);
            this.Enter_description.TabIndex = 8;
            // 
            // Select_male
            // 
            this.Select_male.AutoSize = true;
            this.Select_male.BackColor = System.Drawing.Color.Transparent;
            this.Select_male.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Select_male.ForeColor = System.Drawing.Color.White;
            this.Select_male.Location = new System.Drawing.Point(12, 205);
            this.Select_male.Name = "Select_male";
            this.Select_male.Size = new System.Drawing.Size(53, 24);
            this.Select_male.TabIndex = 12;
            this.Select_male.TabStop = true;
            this.Select_male.Text = "男性";
            this.Select_male.UseVisualStyleBackColor = false;
            // 
            // Select_female
            // 
            this.Select_female.AutoSize = true;
            this.Select_female.BackColor = System.Drawing.Color.Transparent;
            this.Select_female.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Select_female.ForeColor = System.Drawing.Color.Transparent;
            this.Select_female.Location = new System.Drawing.Point(115, 205);
            this.Select_female.Name = "Select_female";
            this.Select_female.Size = new System.Drawing.Size(53, 24);
            this.Select_female.TabIndex = 13;
            this.Select_female.TabStop = true;
            this.Select_female.Text = "女性";
            this.Select_female.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tinder;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "プロフィール登録";
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