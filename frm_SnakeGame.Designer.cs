namespace Snake_WindowsFomsApp
{
    partial class frm_SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.lbl_Score = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmr_Clock
            // 
            this.tmr_Clock.Enabled = true;
            this.tmr_Clock.Interval = 500;
            this.tmr_Clock.Tick += new System.EventHandler(this.Tmr_Clock_Tick);
            // 
            // lbl_Score
            // 
            this.lbl_Score.BackColor = System.Drawing.Color.White;
            this.lbl_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Score.Location = new System.Drawing.Point(570, 13);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(240, 60);
            this.lbl_Score.TabIndex = 0;
            this.lbl_Score.Text = "Score: 0";
            this.lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Restart
            // 
            this.btn_Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Restart.Location = new System.Drawing.Point(570, 93);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(240, 60);
            this.btn_Restart.TabIndex = 1;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.Btn_Restart_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Pause.Location = new System.Drawing.Point(570, 173);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(240, 60);
            this.btn_Pause.TabIndex = 2;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Left.Location = new System.Drawing.Point(570, 339);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(117, 85);
            this.btn_Left.TabIndex = 3;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.Btn_Left_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Up.Location = new System.Drawing.Point(628, 252);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(117, 85);
            this.btn_Up.TabIndex = 4;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.Btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Down.Location = new System.Drawing.Point(628, 426);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(117, 85);
            this.btn_Down.TabIndex = 5;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.Btn_Down_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_Right.Location = new System.Drawing.Point(693, 339);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(117, 85);
            this.btn_Right.TabIndex = 6;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.Btn_Right_Click);
            // 
            // frm_SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(822, 541);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Score);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(838, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(838, 580);
            this.Name = "frm_SnakeGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.TopMost = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_SnakeGame_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Clock;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Left;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_Right;
    }
}

