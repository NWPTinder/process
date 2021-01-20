namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_display = new System.Windows.Forms.TextBox();
            this.Age_display = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_display = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ranking = new System.Windows.Forms.DataGridView();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Thumbup_button = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "名前";
            // 
            // Name_display
            // 
            this.Name_display.Location = new System.Drawing.Point(36, 77);
            this.Name_display.Name = "Name_display";
            this.Name_display.Size = new System.Drawing.Size(227, 19);
            this.Name_display.TabIndex = 10;
            // 
            // Age_display
            // 
            this.Age_display.Location = new System.Drawing.Point(299, 77);
            this.Age_display.Name = "Age_display";
            this.Age_display.Size = new System.Drawing.Size(27, 19);
            this.Age_display.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "年齢";
            // 
            // Description_display
            // 
            this.Description_display.Location = new System.Drawing.Point(36, 127);
            this.Description_display.Name = "Description_display";
            this.Description_display.Size = new System.Drawing.Size(398, 332);
            this.Description_display.TabIndex = 13;
            this.Description_display.Text = "";
            this.Description_display.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "自己紹介";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "新規登録・プロフィール更新";
            // 
            // Ranking
            // 
            this.Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ranking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Ranking.Location = new System.Drawing.Point(587, 183);
            this.Ranking.Name = "Ranking";
            this.Ranking.RowTemplate.Height = 21;
            this.Ranking.Size = new System.Drawing.Size(344, 276);
            this.Ranking.TabIndex = 17;
            this.Ranking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Registration_button
            // 
            this.Registration_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.touroku1;
            this.Registration_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registration_button.Location = new System.Drawing.Point(660, 62);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(132, 99);
            this.Registration_button.TabIndex = 15;
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // Update_button
            // 
            this.Update_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.reload1;
            this.Update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_button.Location = new System.Drawing.Point(450, 344);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(115, 115);
            this.Update_button.TabIndex = 7;
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Thumbup_button
            // 
            this.Thumbup_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.good2;
            this.Thumbup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumbup_button.Location = new System.Drawing.Point(450, 198);
            this.Thumbup_button.Name = "Thumbup_button";
            this.Thumbup_button.Size = new System.Drawing.Size(115, 113);
            this.Thumbup_button.TabIndex = 6;
            this.Thumbup_button.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ランキング";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(943, 496);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Description_display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Age_display);
            this.Controls.Add(this.Name_display);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.Thumbup_button);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ranking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thumbup_button;
        private System.Windows.Forms.Button Update_button;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Description_display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Age_display;
        private System.Windows.Forms.TextBox Name_display;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

