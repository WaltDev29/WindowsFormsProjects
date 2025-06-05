namespace PLC_Test_0604_2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_cylB_mvF = new System.Windows.Forms.Button();
            this.btn_cylB_mvB = new System.Windows.Forms.Button();
            this.btn_cylC_mvB = new System.Windows.Forms.Button();
            this.btn_cylC_mvF = new System.Windows.Forms.Button();
            this.btn_liftB_up = new System.Windows.Forms.Button();
            this.btn_liftB_down = new System.Windows.Forms.Button();
            this.btn_liftA_down = new System.Windows.Forms.Button();
            this.btn_liftA_up = new System.Windows.Forms.Button();
            this.gb_cylB = new System.Windows.Forms.GroupBox();
            this.gb_cylC = new System.Windows.Forms.GroupBox();
            this.gb_liftA = new System.Windows.Forms.GroupBox();
            this.gb_liftB = new System.Windows.Forms.GroupBox();
            this.gb_cylB.SuspendLayout();
            this.gb_cylC.SuspendLayout();
            this.gb_liftA.SuspendLayout();
            this.gb_liftB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(230, 41);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(63, 36);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_cylB_mvF
            // 
            this.btn_cylB_mvF.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvF.Location = new System.Drawing.Point(23, 34);
            this.btn_cylB_mvF.Name = "btn_cylB_mvF";
            this.btn_cylB_mvF.Size = new System.Drawing.Size(63, 36);
            this.btn_cylB_mvF.TabIndex = 1;
            this.btn_cylB_mvF.Text = "전진";
            this.btn_cylB_mvF.UseVisualStyleBackColor = true;
            this.btn_cylB_mvF.Click += new System.EventHandler(this.btn_cylB_mvF_Click);
            // 
            // btn_cylB_mvB
            // 
            this.btn_cylB_mvB.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylB_mvB.Location = new System.Drawing.Point(107, 34);
            this.btn_cylB_mvB.Name = "btn_cylB_mvB";
            this.btn_cylB_mvB.Size = new System.Drawing.Size(63, 36);
            this.btn_cylB_mvB.TabIndex = 2;
            this.btn_cylB_mvB.Text = "후진";
            this.btn_cylB_mvB.UseVisualStyleBackColor = true;
            this.btn_cylB_mvB.Click += new System.EventHandler(this.btn_cylB_mvB_Click);
            // 
            // btn_cylC_mvB
            // 
            this.btn_cylC_mvB.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvB.Location = new System.Drawing.Point(110, 34);
            this.btn_cylC_mvB.Name = "btn_cylC_mvB";
            this.btn_cylC_mvB.Size = new System.Drawing.Size(63, 36);
            this.btn_cylC_mvB.TabIndex = 3;
            this.btn_cylC_mvB.Text = "후진";
            this.btn_cylC_mvB.UseVisualStyleBackColor = true;
            this.btn_cylC_mvB.Click += new System.EventHandler(this.btn_cylC_mvB_Click);
            // 
            // btn_cylC_mvF
            // 
            this.btn_cylC_mvF.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cylC_mvF.Location = new System.Drawing.Point(22, 35);
            this.btn_cylC_mvF.Name = "btn_cylC_mvF";
            this.btn_cylC_mvF.Size = new System.Drawing.Size(63, 36);
            this.btn_cylC_mvF.TabIndex = 4;
            this.btn_cylC_mvF.Text = "전진";
            this.btn_cylC_mvF.UseVisualStyleBackColor = true;
            this.btn_cylC_mvF.Click += new System.EventHandler(this.btn_cylC_mvF_Click);
            // 
            // btn_liftB_up
            // 
            this.btn_liftB_up.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftB_up.Location = new System.Drawing.Point(26, 41);
            this.btn_liftB_up.Name = "btn_liftB_up";
            this.btn_liftB_up.Size = new System.Drawing.Size(63, 36);
            this.btn_liftB_up.TabIndex = 8;
            this.btn_liftB_up.Text = "Up";
            this.btn_liftB_up.UseVisualStyleBackColor = true;
            this.btn_liftB_up.Click += new System.EventHandler(this.btn_liftB_up_Click);
            // 
            // btn_liftB_down
            // 
            this.btn_liftB_down.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftB_down.Location = new System.Drawing.Point(110, 41);
            this.btn_liftB_down.Name = "btn_liftB_down";
            this.btn_liftB_down.Size = new System.Drawing.Size(77, 36);
            this.btn_liftB_down.TabIndex = 7;
            this.btn_liftB_down.Text = "Down";
            this.btn_liftB_down.UseVisualStyleBackColor = true;
            this.btn_liftB_down.Click += new System.EventHandler(this.btn_liftB_down_Click);
            // 
            // btn_liftA_down
            // 
            this.btn_liftA_down.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftA_down.Location = new System.Drawing.Point(107, 41);
            this.btn_liftA_down.Name = "btn_liftA_down";
            this.btn_liftA_down.Size = new System.Drawing.Size(77, 36);
            this.btn_liftA_down.TabIndex = 6;
            this.btn_liftA_down.Text = "Down";
            this.btn_liftA_down.UseVisualStyleBackColor = true;
            this.btn_liftA_down.Click += new System.EventHandler(this.btn_liftA_down_Click);
            // 
            // btn_liftA_up
            // 
            this.btn_liftA_up.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_liftA_up.Location = new System.Drawing.Point(23, 41);
            this.btn_liftA_up.Name = "btn_liftA_up";
            this.btn_liftA_up.Size = new System.Drawing.Size(63, 36);
            this.btn_liftA_up.TabIndex = 5;
            this.btn_liftA_up.Text = "Up";
            this.btn_liftA_up.UseVisualStyleBackColor = true;
            this.btn_liftA_up.Click += new System.EventHandler(this.btn_liftA_up_Click);
            // 
            // gb_cylB
            // 
            this.gb_cylB.Controls.Add(this.btn_cylB_mvF);
            this.gb_cylB.Controls.Add(this.btn_cylB_mvB);
            this.gb_cylB.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_cylB.Location = new System.Drawing.Point(18, 112);
            this.gb_cylB.Name = "gb_cylB";
            this.gb_cylB.Size = new System.Drawing.Size(200, 100);
            this.gb_cylB.TabIndex = 9;
            this.gb_cylB.TabStop = false;
            this.gb_cylB.Text = "CylinderB";
            // 
            // gb_cylC
            // 
            this.gb_cylC.Controls.Add(this.btn_cylC_mvF);
            this.gb_cylC.Controls.Add(this.btn_cylC_mvB);
            this.gb_cylC.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_cylC.Location = new System.Drawing.Point(304, 112);
            this.gb_cylC.Name = "gb_cylC";
            this.gb_cylC.Size = new System.Drawing.Size(200, 100);
            this.gb_cylC.TabIndex = 10;
            this.gb_cylC.TabStop = false;
            this.gb_cylC.Text = "CylinderC";
            // 
            // gb_liftA
            // 
            this.gb_liftA.Controls.Add(this.btn_liftA_up);
            this.gb_liftA.Controls.Add(this.btn_liftA_down);
            this.gb_liftA.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_liftA.Location = new System.Drawing.Point(18, 261);
            this.gb_liftA.Name = "gb_liftA";
            this.gb_liftA.Size = new System.Drawing.Size(200, 100);
            this.gb_liftA.TabIndex = 11;
            this.gb_liftA.TabStop = false;
            this.gb_liftA.Text = "LiftA";
            // 
            // gb_liftB
            // 
            this.gb_liftB.Controls.Add(this.btn_liftB_up);
            this.gb_liftB.Controls.Add(this.btn_liftB_down);
            this.gb_liftB.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gb_liftB.Location = new System.Drawing.Point(304, 261);
            this.gb_liftB.Name = "gb_liftB";
            this.gb_liftB.Size = new System.Drawing.Size(200, 100);
            this.gb_liftB.TabIndex = 12;
            this.gb_liftB.TabStop = false;
            this.gb_liftB.Text = "LiftB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_liftB);
            this.Controls.Add(this.gb_liftA);
            this.Controls.Add(this.gb_cylC);
            this.Controls.Add(this.gb_cylB);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_cylB.ResumeLayout(false);
            this.gb_cylC.ResumeLayout(false);
            this.gb_liftA.ResumeLayout(false);
            this.gb_liftB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_cylB_mvF;
        private System.Windows.Forms.Button btn_cylB_mvB;
        private System.Windows.Forms.Button btn_cylC_mvB;
        private System.Windows.Forms.Button btn_cylC_mvF;
        private System.Windows.Forms.Button btn_liftB_up;
        private System.Windows.Forms.Button btn_liftB_down;
        private System.Windows.Forms.Button btn_liftA_down;
        private System.Windows.Forms.Button btn_liftA_up;
        private System.Windows.Forms.GroupBox gb_cylB;
        private System.Windows.Forms.GroupBox gb_cylC;
        private System.Windows.Forms.GroupBox gb_liftA;
        private System.Windows.Forms.GroupBox gb_liftB;
    }
}

