namespace _10_th_grade_first
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
            this.DRAW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DRAW
            // 
            this.DRAW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DRAW.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRAW.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DRAW.Location = new System.Drawing.Point(0, 381);
            this.DRAW.Name = "DRAW";
            this.DRAW.Size = new System.Drawing.Size(800, 69);
            this.DRAW.TabIndex = 0;
            this.DRAW.Text = "DRAW";
            this.DRAW.UseCompatibleTextRendering = true;
            this.DRAW.UseVisualStyleBackColor = true;
            this.DRAW.Click += new System.EventHandler(this.DRAW_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.small);
            this.Controls.Add(this.big);
            this.Controls.Add(this.DRAW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DRAW;
        private System.Windows.Forms.Button big;
        private System.Windows.Forms.Button small;
    }
}

