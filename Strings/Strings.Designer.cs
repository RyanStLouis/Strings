namespace Strings
{
    partial class frmStrings
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
            this.txtStringOne = new System.Windows.Forms.TextBox();
            this.txtStringTwo = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblString = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStringOne
            // 
            this.txtStringOne.Location = new System.Drawing.Point(29, 63);
            this.txtStringOne.Name = "txtStringOne";
            this.txtStringOne.Size = new System.Drawing.Size(100, 20);
            this.txtStringOne.TabIndex = 0;
            // 
            // txtStringTwo
            // 
            this.txtStringTwo.Location = new System.Drawing.Point(29, 101);
            this.txtStringTwo.Name = "txtStringTwo";
            this.txtStringTwo.Size = new System.Drawing.Size(100, 20);
            this.txtStringTwo.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(29, 182);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(26, 24);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(125, 16);
            this.lblString.TabIndex = 3;
            this.lblString.Text = "Enter two strings.";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(122, 141);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 4;
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtStringTwo);
            this.Controls.Add(this.txtStringOne);
            this.Name = "frmStrings";
            this.Text = "Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStringOne;
        private System.Windows.Forms.TextBox txtStringTwo;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblAnswer;
    }
}

