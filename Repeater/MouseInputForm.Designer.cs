namespace Repeater
{
    partial class MouseInputForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.pos_X = new System.Windows.Forms.TextBox();
            this.pos_Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBox_MOVE = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.CheckBox_LEFTCLICK = new System.Windows.Forms.CheckBox();
            this.CheckBox_RIGHTCLICK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // pos_X
            // 
            this.pos_X.Location = new System.Drawing.Point(81, 68);
            this.pos_X.Name = "pos_X";
            this.pos_X.Size = new System.Drawing.Size(52, 21);
            this.pos_X.TabIndex = 2;
            this.pos_X.TabStop = false;
            // 
            // pos_Y
            // 
            this.pos_Y.Location = new System.Drawing.Point(162, 68);
            this.pos_Y.Name = "pos_Y";
            this.pos_Y.Size = new System.Drawing.Size(58, 21);
            this.pos_Y.TabIndex = 3;
            this.pos_Y.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "q를 누르면 현재 마우스의 위치로 X,Y가 설정됩니다";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "포커스를 TextBox 외의 부분에 두고 사용하십시오";
            // 
            // CheckBox_MOVE
            // 
            this.CheckBox_MOVE.AutoSize = true;
            this.CheckBox_MOVE.Location = new System.Drawing.Point(49, 124);
            this.CheckBox_MOVE.Name = "CheckBox_MOVE";
            this.CheckBox_MOVE.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_MOVE.TabIndex = 7;
            this.CheckBox_MOVE.Text = "이동";
            this.CheckBox_MOVE.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(58, 249);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(145, 249);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 9;
            this.Cancle.Text = "취소";
            this.Cancle.UseVisualStyleBackColor = true;
            // 
            // CheckBox_LEFTCLICK
            // 
            this.CheckBox_LEFTCLICK.AutoSize = true;
            this.CheckBox_LEFTCLICK.Location = new System.Drawing.Point(49, 146);
            this.CheckBox_LEFTCLICK.Name = "CheckBox_LEFTCLICK";
            this.CheckBox_LEFTCLICK.Size = new System.Drawing.Size(76, 16);
            this.CheckBox_LEFTCLICK.TabIndex = 10;
            this.CheckBox_LEFTCLICK.Text = "왼쪽 클릭";
            this.CheckBox_LEFTCLICK.UseVisualStyleBackColor = true;
            // 
            // CheckBox_RIGHTCLICK
            // 
            this.CheckBox_RIGHTCLICK.AutoSize = true;
            this.CheckBox_RIGHTCLICK.Location = new System.Drawing.Point(49, 168);
            this.CheckBox_RIGHTCLICK.Name = "CheckBox_RIGHTCLICK";
            this.CheckBox_RIGHTCLICK.Size = new System.Drawing.Size(88, 16);
            this.CheckBox_RIGHTCLICK.TabIndex = 11;
            this.CheckBox_RIGHTCLICK.Text = "오른쪽 클릭";
            this.CheckBox_RIGHTCLICK.UseVisualStyleBackColor = true;
            // 
            // MouseInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 284);
            this.Controls.Add(this.CheckBox_RIGHTCLICK);
            this.Controls.Add(this.CheckBox_LEFTCLICK);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CheckBox_MOVE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pos_Y);
            this.Controls.Add(this.pos_X);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MouseInputForm";
            this.Text = "MouseInputForm";
            this.Load += new System.EventHandler(this.MouseInputForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MouseInputForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pos_X;
        private System.Windows.Forms.TextBox pos_Y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBox_MOVE;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.CheckBox CheckBox_LEFTCLICK;
        private System.Windows.Forms.CheckBox CheckBox_RIGHTCLICK;
    }
}