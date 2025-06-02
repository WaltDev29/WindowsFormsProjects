namespace PLC_Test_0521
{
    partial class lbl_autoMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbl_autoMode));
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_move = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_mvForward = new System.Windows.Forms.Button();
            this.btn_mvBackward = new System.Windows.Forms.Button();
            this.picBox_autoMode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_autoMode)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(144, 46);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(111, 58);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_move
            // 
            this.btn_move.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_move.Location = new System.Drawing.Point(51, 232);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(111, 58);
            this.btn_move.TabIndex = 1;
            this.btn_move.Text = "1회 왕복";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_status.Location = new System.Drawing.Point(156, 329);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(89, 19);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "초기상태";
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_mvForward
            // 
            this.btn_mvForward.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mvForward.Location = new System.Drawing.Point(51, 138);
            this.btn_mvForward.Name = "btn_mvForward";
            this.btn_mvForward.Size = new System.Drawing.Size(111, 58);
            this.btn_mvForward.TabIndex = 3;
            this.btn_mvForward.Text = "전진";
            this.btn_mvForward.UseVisualStyleBackColor = true;
            this.btn_mvForward.Click += new System.EventHandler(this.btn_mvForward_Click);
            // 
            // btn_mvBackward
            // 
            this.btn_mvBackward.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_mvBackward.Location = new System.Drawing.Point(210, 138);
            this.btn_mvBackward.Name = "btn_mvBackward";
            this.btn_mvBackward.Size = new System.Drawing.Size(111, 58);
            this.btn_mvBackward.TabIndex = 4;
            this.btn_mvBackward.Text = "후진";
            this.btn_mvBackward.UseVisualStyleBackColor = true;
            this.btn_mvBackward.Click += new System.EventHandler(this.btn_mvBackward_Click);
            // 
            // picBox_autoMode
            // 
            this.picBox_autoMode.Image = ((System.Drawing.Image)(resources.GetObject("picBox_autoMode.Image")));
            this.picBox_autoMode.Location = new System.Drawing.Point(215, 233);
            this.picBox_autoMode.Name = "picBox_autoMode";
            this.picBox_autoMode.Size = new System.Drawing.Size(110, 55);
            this.picBox_autoMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_autoMode.TabIndex = 6;
            this.picBox_autoMode.TabStop = false;
            this.picBox_autoMode.Click += new System.EventHandler(this.picBox_autoMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(222, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "자동모드";
            // 
            // lbl_autoMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox_autoMode);
            this.Controls.Add(this.btn_mvBackward);
            this.Controls.Add(this.btn_mvForward);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.btn_connect);
            this.Name = "lbl_autoMode";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_autoMode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_mvForward;
        private System.Windows.Forms.Button btn_mvBackward;
        private System.Windows.Forms.PictureBox picBox_autoMode;
        private System.Windows.Forms.Label label1;
    }
}

