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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label5 = new System.Windows.Forms.Label();
            this.Name_display = new System.Windows.Forms.TextBox();
            this.Age_display = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Description_display = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Ranking = new System.Windows.Forms.DataGridView();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年齢 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性別 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.いいね = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_display = new System.Windows.Forms.Label();
            this.Registration_button = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.Thumbup_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "名前";
            // 
            // Name_display
            // 
            this.Name_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_display.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name_display.Location = new System.Drawing.Point(37, 87);
            this.Name_display.Name = "Name_display";
            this.Name_display.Size = new System.Drawing.Size(230, 31);
            this.Name_display.TabIndex = 10;
            // 
            // Age_display
            // 
            this.Age_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age_display.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Age_display.Location = new System.Drawing.Point(317, 87);
            this.Age_display.Name = "Age_display";
            this.Age_display.Size = new System.Drawing.Size(50, 31);
            this.Age_display.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(311, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "年齢";
            // 
            // Description_display
            // 
            this.Description_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description_display.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Description_display.Location = new System.Drawing.Point(37, 165);
            this.Description_display.Name = "Description_display";
            this.Description_display.Size = new System.Drawing.Size(330, 100);
            this.Description_display.TabIndex = 13;
            this.Description_display.Text = "";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "自己紹介";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(657, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "プロフィール登録";
            // 
            // dataGridView_Ranking
            // 
            this.dataGridView_Ranking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Ranking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ranking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ranking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名前,
            this.年齢,
            this.性別,
            this.いいね});
            this.dataGridView_Ranking.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_Ranking.Location = new System.Drawing.Point(435, 192);
            this.dataGridView_Ranking.Name = "dataGridView_Ranking";
            this.dataGridView_Ranking.RowHeadersWidth = 51;
            this.dataGridView_Ranking.RowTemplate.Height = 21;
            this.dataGridView_Ranking.Size = new System.Drawing.Size(456, 276);
            this.dataGridView_Ranking.TabIndex = 17;
            // 
            // 名前
            // 
            this.名前.HeaderText = "UserName";
            this.名前.Name = "名前";
            this.名前.ReadOnly = true;
            // 
            // 年齢
            // 
            this.年齢.HeaderText = "Age";
            this.年齢.Name = "年齢";
            this.年齢.ReadOnly = true;
            // 
            // 性別
            // 
            this.性別.HeaderText = "Sex";
            this.性別.Name = "性別";
            this.性別.ReadOnly = true;
            // 
            // いいね
            // 
            this.いいね.HeaderText = "Liked";
            this.いいね.Name = "いいね";
            this.いいね.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Meiryo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "UserのID";
            // 
            // ID_display
            // 
            this.ID_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_display.AutoSize = true;
            this.ID_display.BackColor = System.Drawing.Color.Transparent;
            this.ID_display.Font = new System.Drawing.Font("Meiryo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_display.ForeColor = System.Drawing.Color.White;
            this.ID_display.Location = new System.Drawing.Point(30, 427);
            this.ID_display.Name = "ID_display";
            this.ID_display.Size = new System.Drawing.Size(99, 41);
            this.ID_display.TabIndex = 20;
            this.ID_display.Text = "読込中";
            // 
            // Registration_button
            // 
            this.Registration_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Registration_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.new_user;
            this.Registration_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registration_button.Location = new System.Drawing.Point(698, 86);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(100, 100);
            this.Registration_button.TabIndex = 15;
            this.Registration_button.UseVisualStyleBackColor = true;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // Update_button
            // 
            this.Update_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.reload1;
            this.Update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Update_button.Location = new System.Drawing.Point(267, 282);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(100, 100);
            this.Update_button.TabIndex = 7;
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Thumbup_button
            // 
            this.Thumbup_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Thumbup_button.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.iine;
            this.Thumbup_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumbup_button.Location = new System.Drawing.Point(37, 282);
            this.Thumbup_button.Name = "Thumbup_button";
            this.Thumbup_button.Size = new System.Drawing.Size(100, 100);
            this.Thumbup_button.TabIndex = 6;
            this.Thumbup_button.UseVisualStyleBackColor = true;
            this.Thumbup_button.Click += new System.EventHandler(this.Thumbup_button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Meiryo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "ランキング";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.tinder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Ranking);
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
            this.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PreTinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ranking)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView_Ranking;
        private System.Windows.Forms.Label ID_display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年齢;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性別;
        private System.Windows.Forms.DataGridViewTextBoxColumn いいね;
    }
}

