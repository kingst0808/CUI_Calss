
namespace CUI_Calss_0220
{
    partial class FormFinalGame
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "遊戲開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(45, 164);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(105, 41);
            this.button_2.TabIndex = 1;
            this.button_2.Text = "猜!";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(45, 113);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 22);
            this.tb_input.TabIndex = 2;
            // 
            // FormFinalGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button1);
            this.Name = "FormFinalGame";
            this.Text = "FormFinalGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.TextBox tb_input;
    }
}