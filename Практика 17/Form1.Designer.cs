namespace Практика_17
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
            this.Binary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.choose = new System.Windows.Forms.GroupBox();
            this.ToSixteen = new System.Windows.Forms.RadioButton();
            this.ToTen = new System.Windows.Forms.RadioButton();
            this.ToEight = new System.Windows.Forms.RadioButton();
            this.Do = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.choose.SuspendLayout();
            this.SuspendLayout();
            // 
            // Binary
            // 
            this.Binary.AccessibleDescription = "Binary number";
            this.Binary.AccessibleName = "Binary number";
            this.Binary.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Binary.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Binary.Location = new System.Drawing.Point(567, 24);
            this.Binary.Margin = new System.Windows.Forms.Padding(4);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(205, 38);
            this.Binary.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число в двоичной системе счисления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Результат:";
            // 
            // Result
            // 
            this.Result.AccessibleName = "Result";
            this.Result.BackColor = System.Drawing.Color.LightGreen;
            this.Result.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Result.Location = new System.Drawing.Point(567, 82);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(205, 38);
            this.Result.TabIndex = 3;
            // 
            // choose
            // 
            this.choose.AccessibleName = "Choose system";
            this.choose.Controls.Add(this.ToSixteen);
            this.choose.Controls.Add(this.ToTen);
            this.choose.Controls.Add(this.ToEight);
            this.choose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choose.Location = new System.Drawing.Point(32, 157);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(323, 168);
            this.choose.TabIndex = 4;
            this.choose.TabStop = false;
            this.choose.Text = "Система счисления";
            // 
            // ToSixteen
            // 
            this.ToSixteen.AutoSize = true;
            this.ToSixteen.Location = new System.Drawing.Point(6, 119);
            this.ToSixteen.Name = "ToSixteen";
            this.ToSixteen.Size = new System.Drawing.Size(75, 35);
            this.ToSixteen.TabIndex = 5;
            this.ToSixteen.Text = "16";
            this.ToSixteen.UseVisualStyleBackColor = true;
            // 
            // ToTen
            // 
            this.ToTen.AutoSize = true;
            this.ToTen.Checked = true;
            this.ToTen.Location = new System.Drawing.Point(6, 78);
            this.ToTen.Name = "ToTen";
            this.ToTen.Size = new System.Drawing.Size(75, 35);
            this.ToTen.TabIndex = 6;
            this.ToTen.TabStop = true;
            this.ToTen.Text = "10";
            this.ToTen.UseVisualStyleBackColor = true;
            // 
            // ToEight
            // 
            this.ToEight.AutoSize = true;
            this.ToEight.Location = new System.Drawing.Point(6, 37);
            this.ToEight.Name = "ToEight";
            this.ToEight.Size = new System.Drawing.Size(60, 35);
            this.ToEight.TabIndex = 0;
            this.ToEight.Text = "8";
            this.ToEight.UseVisualStyleBackColor = true;
            // 
            // Do
            // 
            this.Do.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Do.Location = new System.Drawing.Point(389, 194);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(124, 113);
            this.Do.TabIndex = 5;
            this.Do.Text = "Считать";
            this.Do.UseVisualStyleBackColor = false;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(648, 194);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(124, 113);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(845, 356);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Do);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Binary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Перевод двоичного числа в различные системы счисления";
            this.choose.ResumeLayout(false);
            this.choose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Binary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.GroupBox choose;
        private System.Windows.Forms.RadioButton ToSixteen;
        private System.Windows.Forms.RadioButton ToTen;
        private System.Windows.Forms.RadioButton ToEight;
        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Button Exit;
    }
}

