﻿namespace CsharpOpenCV_card
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.groupBox_lowerb = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_lowerb = new System.Windows.Forms.Button();
            this.groupBoxupperb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_upperb = new System.Windows.Forms.Button();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.groupBox_lowerb.SuspendLayout();
            this.groupBoxupperb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 49);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
          
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(127, 49);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.TabIndex = 1;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(237, 49);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.TabIndex = 1;
            // 
            // groupBox_lowerb
            // 
            this.groupBox_lowerb.Controls.Add(this.label3);
            this.groupBox_lowerb.Controls.Add(this.label2);
            this.groupBox_lowerb.Controls.Add(this.label1);
            this.groupBox_lowerb.Controls.Add(this.button_lowerb);
            this.groupBox_lowerb.Controls.Add(this.trackBar2);
            this.groupBox_lowerb.Controls.Add(this.trackBar3);
            this.groupBox_lowerb.Controls.Add(this.trackBar1);
            this.groupBox_lowerb.Location = new System.Drawing.Point(59, 185);
            this.groupBox_lowerb.Name = "groupBox_lowerb";
            this.groupBox_lowerb.Size = new System.Drawing.Size(432, 100);
            this.groupBox_lowerb.TabIndex = 2;
            this.groupBox_lowerb.TabStop = false;
            this.groupBox_lowerb.Text = "lowerb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blue";
            // 
            // button_lowerb
            // 
            this.button_lowerb.Location = new System.Drawing.Point(349, 20);
            this.button_lowerb.Name = "button_lowerb";
            this.button_lowerb.Size = new System.Drawing.Size(75, 74);
            this.button_lowerb.TabIndex = 2;
            this.button_lowerb.Text = " ";
            this.button_lowerb.UseVisualStyleBackColor = true;
            // 
            // groupBoxupperb
            // 
            this.groupBoxupperb.Controls.Add(this.label4);
            this.groupBoxupperb.Controls.Add(this.label5);
            this.groupBoxupperb.Controls.Add(this.label6);
            this.groupBoxupperb.Controls.Add(this.button_upperb);
            this.groupBoxupperb.Controls.Add(this.trackBar4);
            this.groupBoxupperb.Controls.Add(this.trackBar5);
            this.groupBoxupperb.Controls.Add(this.trackBar6);
            this.groupBoxupperb.Location = new System.Drawing.Point(59, 303);
            this.groupBoxupperb.Name = "groupBoxupperb";
            this.groupBoxupperb.Size = new System.Drawing.Size(432, 100);
            this.groupBoxupperb.TabIndex = 2;
            this.groupBoxupperb.TabStop = false;
            this.groupBoxupperb.Text = "upperb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Red";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Green";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Blue";
            // 
            // button_upperb
            // 
            this.button_upperb.Location = new System.Drawing.Point(349, 20);
            this.button_upperb.Name = "button_upperb";
            this.button_upperb.Size = new System.Drawing.Size(75, 74);
            this.button_upperb.TabIndex = 2;
            this.button_upperb.Text = " ";
            this.button_upperb.UseVisualStyleBackColor = true;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(127, 49);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.TabIndex = 1;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(237, 49);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 1;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(17, 49);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 45);
            this.trackBar6.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxupperb);
            this.Controls.Add(this.groupBox_lowerb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.groupBox_lowerb.ResumeLayout(false);
            this.groupBox_lowerb.PerformLayout();
            this.groupBoxupperb.ResumeLayout(false);
            this.groupBoxupperb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.GroupBox groupBox_lowerb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_lowerb;
        private System.Windows.Forms.GroupBox groupBoxupperb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_upperb;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
    }
}

