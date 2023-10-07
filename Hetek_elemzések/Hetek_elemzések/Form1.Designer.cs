
namespace Hetek_elemzések
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
            this.Bt = new System.Windows.Forms.Button();
            this.Which = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.CheckBox();
            this.Female = new System.Windows.Forms.CheckBox();
            this.Laza = new System.Windows.Forms.NumericUpDown();
            this.Howold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Laza)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(586, 359);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(75, 23);
            this.Bt.TabIndex = 0;
            this.Bt.Text = "Kapcsolatt";
            this.Bt.UseVisualStyleBackColor = true;
            // 
            // Which
            // 
            this.Which.AutoSize = true;
            this.Which.Location = new System.Drawing.Point(81, 65);
            this.Which.Name = "Which";
            this.Which.Size = new System.Drawing.Size(115, 17);
            this.Which.TabIndex = 1;
            this.Which.Text = "Milyen a nemed?";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(71, 114);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(58, 21);
            this.Male.TabIndex = 2;
            this.Male.Text = "Férfi";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(204, 114);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(48, 21);
            this.Female.TabIndex = 3;
            this.Female.Text = "Nő";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Laza
            // 
            this.Laza.Location = new System.Drawing.Point(84, 226);
            this.Laza.Name = "Laza";
            this.Laza.Size = new System.Drawing.Size(120, 22);
            this.Laza.TabIndex = 4;
            // 
            // Howold
            // 
            this.Howold.AutoSize = true;
            this.Howold.Location = new System.Drawing.Point(81, 182);
            this.Howold.Name = "Howold";
            this.Howold.Size = new System.Drawing.Size(117, 17);
            this.Howold.TabIndex = 5;
            this.Howold.Text = "Hány éves vagy?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Howold);
            this.Controls.Add(this.Laza);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Which);
            this.Controls.Add(this.Bt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Laza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Label Which;
        private System.Windows.Forms.CheckBox Male;
        private System.Windows.Forms.CheckBox Female;
        private System.Windows.Forms.NumericUpDown Laza;
        private System.Windows.Forms.Label Howold;
    }
}

