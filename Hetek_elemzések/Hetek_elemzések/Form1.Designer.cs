
namespace Hetek_elemzések
{
    partial class Howold_s
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
            this.Howold_t = new System.Windows.Forms.NumericUpDown();
            this.Howold = new System.Windows.Forms.Label();
            this.Name_t = new System.Windows.Forms.TextBox();
            this.Name_s = new System.Windows.Forms.Label();
            this.who_t = new System.Windows.Forms.ComboBox();
            this.who_s = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Howold_t)).BeginInit();
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
            // Howold_t
            // 
            this.Howold_t.Location = new System.Drawing.Point(84, 226);
            this.Howold_t.Name = "Howold_t";
            this.Howold_t.Size = new System.Drawing.Size(120, 22);
            this.Howold_t.TabIndex = 4;
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
            // Name_t
            // 
            this.Name_t.Location = new System.Drawing.Point(98, 348);
            this.Name_t.Name = "Name_t";
            this.Name_t.Size = new System.Drawing.Size(100, 22);
            this.Name_t.TabIndex = 6;
            // 
            // Name_s
            // 
            this.Name_s.AutoSize = true;
            this.Name_s.Location = new System.Drawing.Point(121, 287);
            this.Name_s.Name = "Name_s";
            this.Name_s.Size = new System.Drawing.Size(49, 17);
            this.Name_s.TabIndex = 7;
            this.Name_s.Text = "Neved";
            // 
            // who_t
            // 
            this.who_t.FormattingEnabled = true;
            this.who_t.Location = new System.Drawing.Point(503, 114);
            this.who_t.Name = "who_t";
            this.who_t.Size = new System.Drawing.Size(121, 24);
            this.who_t.TabIndex = 8;
            // 
            // who_s
            // 
            this.who_s.AutoSize = true;
            this.who_s.Location = new System.Drawing.Point(500, 65);
            this.who_s.Name = "who_s";
            this.who_s.Size = new System.Drawing.Size(113, 17);
            this.who_s.TabIndex = 9;
            this.who_s.Text = "Hány szám van?";
            // 
            // Howold_s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.who_s);
            this.Controls.Add(this.who_t);
            this.Controls.Add(this.Name_s);
            this.Controls.Add(this.Name_t);
            this.Controls.Add(this.Howold);
            this.Controls.Add(this.Howold_t);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Which);
            this.Controls.Add(this.Bt);
            this.Name = "Howold_s";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Howold_t)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Label Which;
        private System.Windows.Forms.CheckBox Male;
        private System.Windows.Forms.CheckBox Female;
        private System.Windows.Forms.NumericUpDown Howold_t;
        private System.Windows.Forms.Label Howold;
        private System.Windows.Forms.TextBox Name_t;
        private System.Windows.Forms.Label Name_s;
        private System.Windows.Forms.ComboBox who_t;
        private System.Windows.Forms.Label who_s;
    }
}

