namespace Syncfusion_style
{
    partial class Form2
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
            this.choosebutton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosebutton1
            // 
            this.choosebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosebutton1.Location = new System.Drawing.Point(12, 12);
            this.choosebutton1.Name = "choosebutton1";
            this.choosebutton1.Size = new System.Drawing.Size(81, 28);
            this.choosebutton1.TabIndex = 0;
            this.choosebutton1.Text = "Choose";
            this.choosebutton1.UseVisualStyleBackColor = true;
            this.choosebutton1.Click += new System.EventHandler(this.choosebutton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 26);
            this.textBox1.TabIndex = 1;
            // 
            // playbutton
            // 
            this.playbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.Location = new System.Drawing.Point(450, 14);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(81, 28);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "Play";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Go to Metro Form ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.choosebutton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choosebutton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button button1;
    }
}