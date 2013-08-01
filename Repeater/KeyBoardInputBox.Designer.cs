namespace Repeater
{
    partial class KeyBoardInputForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.InputKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력한 키 : ";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(40, 62);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.TabStop = false;
            this.OK.Text = "확인";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(129, 62);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 3;
            this.Cancle.TabStop = false;
            this.Cancle.Text = "취소";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.Cancle_Click);
            // 
            // InputKey
            // 
            this.InputKey.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.InputKey.Location = new System.Drawing.Point(121, 21);
            this.InputKey.Name = "InputKey";
            this.InputKey.Size = new System.Drawing.Size(100, 21);
            this.InputKey.TabIndex = 4;
            this.InputKey.TabStop = false;
            // 
            // KeyBoardInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 97);
            this.Controls.Add(this.InputKey);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Name = "KeyBoardInputForm";
            this.Text = "KeyBoardInputBox";
            this.Shown += new System.EventHandler(this.KeyBoardInputBox_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyBoardInputBox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.TextBox InputKey;
    }
}