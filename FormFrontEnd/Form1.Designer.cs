namespace FormFrontEnd
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnGet = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(194, 410);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(77, 25);
            this.lblOutput.TabIndex = 17;
            this.lblOutput.Text = "Label4";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(200, 323);
            this.btnGet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(180, 42);
            this.btnGet.TabIndex = 13;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(72, 210);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 25);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Diameter";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(72, 152);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 25);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Height";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(72, 94);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 25);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Color";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(200, 196);
            this.txtDiameter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(210, 31);
            this.txtDiameter.TabIndex = 11;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(200, 146);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(210, 31);
            this.txtHeight.TabIndex = 10;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(200, 90);
            this.txtColor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(210, 31);
            this.txtColor.TabIndex = 9;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(200, 269);
            this.btnSet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(180, 42);
            this.btnSet.TabIndex = 12;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 525);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnSet);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblOutput;
        internal System.Windows.Forms.Button btnGet;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDiameter;
        internal System.Windows.Forms.TextBox txtHeight;
        internal System.Windows.Forms.TextBox txtColor;
        internal System.Windows.Forms.Button btnSet;
    }
}

