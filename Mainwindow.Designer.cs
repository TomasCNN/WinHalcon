namespace WinHalcon
{
    partial class Main_Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button4_Algorithm_Initialized = new System.Windows.Forms.Button();
            this.Button3_Result_Initialized = new System.Windows.Forms.Button();
            this.Button2_Original_Initialized = new System.Windows.Forms.Button();
            this.Button1_System_Initialized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(320, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原图显示区";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(9, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 410);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(324, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(320, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果图显示区";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 410);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Button4_Algorithm_Initialized);
            this.groupBox3.Controls.Add(this.Button3_Result_Initialized);
            this.groupBox3.Controls.Add(this.Button2_Original_Initialized);
            this.groupBox3.Controls.Add(this.Button1_System_Initialized);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(643, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(587, 445);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置区";
            // 
            // Button4_Algorithm_Initialized
            // 
            this.Button4_Algorithm_Initialized.Location = new System.Drawing.Point(447, 25);
            this.Button4_Algorithm_Initialized.Name = "Button4_Algorithm_Initialized";
            this.Button4_Algorithm_Initialized.Size = new System.Drawing.Size(107, 23);
            this.Button4_Algorithm_Initialized.TabIndex = 3;
            this.Button4_Algorithm_Initialized.Text = "算法引擎初始化";
            this.Button4_Algorithm_Initialized.UseVisualStyleBackColor = true;
            // 
            // Button3_Result_Initialized
            // 
            this.Button3_Result_Initialized.Location = new System.Drawing.Point(279, 26);
            this.Button3_Result_Initialized.Name = "Button3_Result_Initialized";
            this.Button3_Result_Initialized.Size = new System.Drawing.Size(145, 23);
            this.Button3_Result_Initialized.TabIndex = 2;
            this.Button3_Result_Initialized.Text = "结果图显示初始化";
            this.Button3_Result_Initialized.UseVisualStyleBackColor = true;
            // 
            // Button2_Original_Initialized
            // 
            this.Button2_Original_Initialized.Location = new System.Drawing.Point(135, 26);
            this.Button2_Original_Initialized.Name = "Button2_Original_Initialized";
            this.Button2_Original_Initialized.Size = new System.Drawing.Size(121, 23);
            this.Button2_Original_Initialized.TabIndex = 1;
            this.Button2_Original_Initialized.Text = "原图显示初始化";
            this.Button2_Original_Initialized.UseVisualStyleBackColor = true;
            // 
            // Button1_System_Initialized
            // 
            this.Button1_System_Initialized.Location = new System.Drawing.Point(10, 26);
            this.Button1_System_Initialized.Name = "Button1_System_Initialized";
            this.Button1_System_Initialized.Size = new System.Drawing.Size(102, 23);
            this.Button1_System_Initialized.TabIndex = 0;
            this.Button1_System_Initialized.Text = "系统初始化";
            this.Button1_System_Initialized.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 918);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main_Window";
            this.Text = "WinHalcon";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Button2_Original_Initialized;
        private System.Windows.Forms.Button Button1_System_Initialized;
        private System.Windows.Forms.Button Button3_Result_Initialized;
        private System.Windows.Forms.Button Button4_Algorithm_Initialized;
        private System.Windows.Forms.Label label1;
    }
}

