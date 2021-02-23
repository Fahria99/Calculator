namespace calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Input1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.subbutton = new System.Windows.Forms.Button();
            this.dividebutton = new System.Windows.Forms.Button();
            this.multiolicationbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input1
            // 
            this.Input1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input1.Location = new System.Drawing.Point(45, 84);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(130, 30);
            this.Input1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstNumber";
            // 
            // Input2
            // 
            this.Input2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input2.Location = new System.Drawing.Point(297, 88);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(130, 28);
            this.Input2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastNumber";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(152, 168);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(160, 43);
            this.Result.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(204, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(60, 250);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(62, 60);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "+";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // subbutton
            // 
            this.subbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbutton.Location = new System.Drawing.Point(60, 316);
            this.subbutton.Name = "subbutton";
            this.subbutton.Size = new System.Drawing.Size(62, 84);
            this.subbutton.TabIndex = 7;
            this.subbutton.Text = "-";
            this.subbutton.UseVisualStyleBackColor = true;
            this.subbutton.Click += new System.EventHandler(this.subbutton_Click);
            // 
            // dividebutton
            // 
            this.dividebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebutton.Location = new System.Drawing.Point(170, 250);
            this.dividebutton.Name = "dividebutton";
            this.dividebutton.Size = new System.Drawing.Size(75, 60);
            this.dividebutton.TabIndex = 8;
            this.dividebutton.Text = "/";
            this.dividebutton.UseVisualStyleBackColor = true;
            this.dividebutton.Click += new System.EventHandler(this.dividebutton_Click);
            // 
            // multiolicationbutton
            // 
            this.multiolicationbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiolicationbutton.Location = new System.Drawing.Point(170, 316);
            this.multiolicationbutton.Name = "multiolicationbutton";
            this.multiolicationbutton.Size = new System.Drawing.Size(75, 84);
            this.multiolicationbutton.TabIndex = 9;
            this.multiolicationbutton.Text = "*";
            this.multiolicationbutton.UseVisualStyleBackColor = true;
            this.multiolicationbutton.Click += new System.EventHandler(this.multiolicationbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Location = new System.Drawing.Point(297, 295);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(130, 34);
            this.resetbutton.TabIndex = 10;
            this.resetbutton.Text = "RESET";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(472, 474);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.multiolicationbutton);
            this.Controls.Add(this.dividebutton);
            this.Controls.Add(this.subbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button subbutton;
        private System.Windows.Forms.Button dividebutton;
        private System.Windows.Forms.Button multiolicationbutton;
        private System.Windows.Forms.Button resetbutton;
    }
}

