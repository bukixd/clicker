using System.Windows.Forms;

namespace clicker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.siano = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ButtonLevelTextBox = new System.Windows.Forms.TextBox();
            this.button3_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::clicker.Properties.Resources.papiez;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(632, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 147);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bij";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siano
            // 
            this.siano.AutoSize = true;
            this.siano.Location = new System.Drawing.Point(632, 273);
            this.siano.Name = "siano";
            this.siano.Size = new System.Drawing.Size(78, 15);
            this.siano.TabIndex = 1;
            this.siano.Text = "Kremówki: 0$";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ulepsz: 10$";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonLevelTextBox
            // 
            this.ButtonLevelTextBox.Location = new System.Drawing.Point(551, 355);
            this.ButtonLevelTextBox.Name = "ButtonLevelTextBox";
            this.ButtonLevelTextBox.ReadOnly = true;
            this.ButtonLevelTextBox.Size = new System.Drawing.Size(75, 23);
            this.ButtonLevelTextBox.TabIndex = 3;
            this.ButtonLevelTextBox.Text = "1";
            this.ButtonLevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3_exit
            // 
            this.button3_exit.Location = new System.Drawing.Point(12, 415);
            this.button3_exit.Name = "button3_exit";
            this.button3_exit.Size = new System.Drawing.Size(65, 23);
            this.button3_exit.TabIndex = 4;
            this.button3_exit.Text = "Wyjście";
            this.button3_exit.UseVisualStyleBackColor = true;
            this.button3_exit.Click += new System.EventHandler(this.button3_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::clicker.Properties.Resources.watykan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3_exit);
            this.Controls.Add(this.ButtonLevelTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.siano);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label siano;
        private Button button2;
        private TextBox ButtonLevelTextBox;
        private Button button3_exit;
    }
}