
namespace EXER_1a
{
    partial class Form1
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
            this.btnChangeToBlue = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeToBlue
            // 
            this.btnChangeToBlue.Location = new System.Drawing.Point(279, 102);
            this.btnChangeToBlue.Name = "btnChangeToBlue";
            this.btnChangeToBlue.Size = new System.Drawing.Size(98, 53);
            this.btnChangeToBlue.TabIndex = 0;
            this.btnChangeToBlue.Text = "Blue";
            this.btnChangeToBlue.UseVisualStyleBackColor = true;
            this.btnChangeToBlue.Click += new System.EventHandler(this.btnChangeToBlue_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(279, 229);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(98, 44);
            this.btnYellow.TabIndex = 1;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnChangeToBlue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeToBlue;
        private System.Windows.Forms.Button btnYellow;
    }
}

