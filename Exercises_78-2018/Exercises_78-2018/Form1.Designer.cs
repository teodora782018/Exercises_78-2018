namespace Exercises_78_2018
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.Unos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(354, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 404);
            this.listBox1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Ime";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(29, 170);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(45, 20);
            this.labelIndex.TabIndex = 2;
            this.labelIndex.Text = "Index";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Location = new System.Drawing.Point(29, 270);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(45, 20);
            this.labelPoint.TabIndex = 3;
            this.labelPoint.Text = "Poeni";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(85, 267);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(129, 27);
            this.txtPoint.TabIndex = 5;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(85, 167);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(125, 27);
            this.txtIndex.TabIndex = 6;
            // 
            // Unos
            // 
            this.Unos.Location = new System.Drawing.Point(68, 338);
            this.Unos.Name = "Unos";
            this.Unos.Size = new System.Drawing.Size(142, 47);
            this.Unos.TabIndex = 7;
            this.Unos.Text = "Unos";
            this.Unos.UseVisualStyleBackColor = true;
            this.Unos.Click += new System.EventHandler(this.Unos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Unos);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button Unos;
    }
}

