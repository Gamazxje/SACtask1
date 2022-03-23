namespace Michaeltask1
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
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblWorth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(289, 174);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 31);
            this.numAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "How old is the textbook?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much did you pay for it?";
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 1;
            this.numericPrice.Location = new System.Drawing.Point(294, 290);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(120, 31);
            this.numericPrice.TabIndex = 3;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(289, 380);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(125, 46);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(735, 380);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(182, 46);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "End the quote";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(735, 128);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(70, 25);
            this.lblWorth.TabIndex = 6;
            this.lblWorth.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 758);
            this.Controls.Add(this.lblWorth);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblWorth;
    }
}

