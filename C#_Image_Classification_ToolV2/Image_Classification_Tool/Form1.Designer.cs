
namespace Image_Classification_Tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uploadbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.compbtn = new System.Windows.Forms.Button();
            this.irrebtn = new System.Windows.Forms.Button();
            this.manualbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hollbtn = new System.Windows.Forms.Button();
            this.rarebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadbtn
            // 
            this.uploadbtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadbtn.Location = new System.Drawing.Point(1036, 12);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(150, 74);
            this.uploadbtn.TabIndex = 2;
            this.uploadbtn.Text = "Upload Photo\r\n";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(243, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 478);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // compbtn
            // 
            this.compbtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.compbtn.Location = new System.Drawing.Point(356, 529);
            this.compbtn.Name = "compbtn";
            this.compbtn.Size = new System.Drawing.Size(148, 85);
            this.compbtn.TabIndex = 4;
            this.compbtn.Text = "Complete network";
            this.compbtn.UseVisualStyleBackColor = true;
            this.compbtn.Click += new System.EventHandler(this.compbtn_Click);
            // 
            // irrebtn
            // 
            this.irrebtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.irrebtn.Location = new System.Drawing.Point(639, 529);
            this.irrebtn.Name = "irrebtn";
            this.irrebtn.Size = new System.Drawing.Size(139, 85);
            this.irrebtn.TabIndex = 5;
            this.irrebtn.Text = "Irregular contour";
            this.irrebtn.UseVisualStyleBackColor = true;
            this.irrebtn.Click += new System.EventHandler(this.irrebtn_Click);
            // 
            // manualbtn
            // 
            this.manualbtn.BackColor = System.Drawing.Color.Transparent;
            this.manualbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("manualbtn.BackgroundImage")));
            this.manualbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manualbtn.FlatAppearance.BorderSize = 0;
            this.manualbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.manualbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.manualbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manualbtn.Location = new System.Drawing.Point(20, 10);
            this.manualbtn.Name = "manualbtn";
            this.manualbtn.Size = new System.Drawing.Size(50, 54);
            this.manualbtn.TabIndex = 6;
            this.manualbtn.UseVisualStyleBackColor = false;
            this.manualbtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manual";
            // 
            // hollbtn
            // 
            this.hollbtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hollbtn.Location = new System.Drawing.Point(639, 651);
            this.hollbtn.Name = "hollbtn";
            this.hollbtn.Size = new System.Drawing.Size(139, 84);
            this.hollbtn.TabIndex = 9;
            this.hollbtn.Text = "Hollow network";
            this.hollbtn.UseVisualStyleBackColor = true;
            this.hollbtn.Click += new System.EventHandler(this.hollbtn_Click);
            // 
            // rarebtn
            // 
            this.rarebtn.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rarebtn.Location = new System.Drawing.Point(356, 651);
            this.rarebtn.Name = "rarebtn";
            this.rarebtn.Size = new System.Drawing.Size(148, 84);
            this.rarebtn.TabIndex = 10;
            this.rarebtn.Text = "Rare junction";
            this.rarebtn.UseVisualStyleBackColor = true;
            this.rarebtn.Click += new System.EventHandler(this.rarebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 755);
            this.Controls.Add(this.rarebtn);
            this.Controls.Add(this.hollbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manualbtn);
            this.Controls.Add(this.irrebtn);
            this.Controls.Add(this.compbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uploadbtn);
            this.Name = "Form1";
            this.Text = "Image classification tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button compbtn;
        private System.Windows.Forms.Button irrebtn;
        private System.Windows.Forms.Button manualbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hollbtn;
        private System.Windows.Forms.Button rarebtn;
    }
}

