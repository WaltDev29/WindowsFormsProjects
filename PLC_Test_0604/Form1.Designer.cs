namespace PLC_Test_0604
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
            this.components = new System.ComponentModel.Container();
            this.btn_connect = new System.Windows.Forms.Button();
            this.pic_cylB = new System.Windows.Forms.PictureBox();
            this.pic_cylC = new System.Windows.Forms.PictureBox();
            this.pic_liftA = new System.Windows.Forms.PictureBox();
            this.pic_liftB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cynB_mvB = new System.Windows.Forms.Button();
            this.btn_cynB_mvF = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btn_cynC_mvF = new System.Windows.Forms.Button();
            this.btn_cynC_mvB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftB)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(65, 33);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(69, 38);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // pic_cylB
            // 
            this.pic_cylB.ImageLocation = "images/cylinder_off.png";
            this.pic_cylB.Location = new System.Drawing.Point(188, 21);
            this.pic_cylB.Name = "pic_cylB";
            this.pic_cylB.Size = new System.Drawing.Size(207, 50);
            this.pic_cylB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylB.TabIndex = 1;
            this.pic_cylB.TabStop = false;
            // 
            // pic_cylC
            // 
            this.pic_cylC.ImageLocation = "images/cylinder_off.png";
            this.pic_cylC.Location = new System.Drawing.Point(188, 119);
            this.pic_cylC.Name = "pic_cylC";
            this.pic_cylC.Size = new System.Drawing.Size(207, 50);
            this.pic_cylC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cylC.TabIndex = 2;
            this.pic_cylC.TabStop = false;
            // 
            // pic_liftA
            // 
            this.pic_liftA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_liftA.Location = new System.Drawing.Point(451, 12);
            this.pic_liftA.Name = "pic_liftA";
            this.pic_liftA.Size = new System.Drawing.Size(119, 70);
            this.pic_liftA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_liftA.TabIndex = 3;
            this.pic_liftA.TabStop = false;
            // 
            // pic_liftB
            // 
            this.pic_liftB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pic_liftB.Location = new System.Drawing.Point(451, 108);
            this.pic_liftB.Name = "pic_liftB";
            this.pic_liftB.Size = new System.Drawing.Size(119, 70);
            this.pic_liftB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_liftB.TabIndex = 4;
            this.pic_liftB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cynB_mvB
            // 
            this.btn_cynB_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cynB_mvB.Location = new System.Drawing.Point(98, 131);
            this.btn_cynB_mvB.Name = "btn_cynB_mvB";
            this.btn_cynB_mvB.Size = new System.Drawing.Size(69, 38);
            this.btn_cynB_mvB.TabIndex = 5;
            this.btn_cynB_mvB.Text = "후진";
            this.btn_cynB_mvB.UseVisualStyleBackColor = true;
            this.btn_cynB_mvB.Click += new System.EventHandler(this.btn_mvB_Click);
            // 
            // btn_cynB_mvF
            // 
            this.btn_cynB_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cynB_mvF.Location = new System.Drawing.Point(12, 131);
            this.btn_cynB_mvF.Name = "btn_cynB_mvF";
            this.btn_cynB_mvF.Size = new System.Drawing.Size(69, 38);
            this.btn_cynB_mvF.TabIndex = 6;
            this.btn_cynB_mvF.Text = "전진";
            this.btn_cynB_mvF.UseVisualStyleBackColor = true;
            this.btn_cynB_mvF.Click += new System.EventHandler(this.btn_mvF_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_cynC_mvF
            // 
            this.btn_cynC_mvF.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cynC_mvF.Location = new System.Drawing.Point(12, 268);
            this.btn_cynC_mvF.Name = "btn_cynC_mvF";
            this.btn_cynC_mvF.Size = new System.Drawing.Size(69, 38);
            this.btn_cynC_mvF.TabIndex = 8;
            this.btn_cynC_mvF.Text = "전진";
            this.btn_cynC_mvF.UseVisualStyleBackColor = true;
            this.btn_cynC_mvF.Click += new System.EventHandler(this.btn_cynC_mvF_Click);
            // 
            // btn_cynC_mvB
            // 
            this.btn_cynC_mvB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cynC_mvB.Location = new System.Drawing.Point(98, 268);
            this.btn_cynC_mvB.Name = "btn_cynC_mvB";
            this.btn_cynC_mvB.Size = new System.Drawing.Size(69, 38);
            this.btn_cynC_mvB.TabIndex = 7;
            this.btn_cynC_mvB.Text = "후진";
            this.btn_cynC_mvB.UseVisualStyleBackColor = true;
            this.btn_cynC_mvB.Click += new System.EventHandler(this.btn_cynC_mvB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cynC_mvF);
            this.Controls.Add(this.btn_cynC_mvB);
            this.Controls.Add(this.btn_cynB_mvF);
            this.Controls.Add(this.btn_cynB_mvB);
            this.Controls.Add(this.pic_liftB);
            this.Controls.Add(this.pic_liftA);
            this.Controls.Add(this.pic_cylC);
            this.Controls.Add(this.pic_cylB);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cylC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_liftB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.PictureBox pic_cylB;
        private System.Windows.Forms.PictureBox pic_cylC;
        private System.Windows.Forms.PictureBox pic_liftA;
        private System.Windows.Forms.PictureBox pic_liftB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_cynB_mvB;
        private System.Windows.Forms.Button btn_cynB_mvF;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_cynC_mvF;
        private System.Windows.Forms.Button btn_cynC_mvB;
    }
}

