namespace ProfTest
{
    partial class f1Q
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1Q));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb1QTrue = new System.Windows.Forms.RadioButton();
            this.rb1QFalse = new System.Windows.Forms.RadioButton();
            this.btnTo2Q = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Каким кодовым словом вызывается";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "переменная типа целое число?";
            // 
            // rb1QTrue
            // 
            this.rb1QTrue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb1QTrue.AutoSize = true;
            this.rb1QTrue.BackColor = System.Drawing.Color.Transparent;
            this.rb1QTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1QTrue.Location = new System.Drawing.Point(88, 136);
            this.rb1QTrue.Name = "rb1QTrue";
            this.rb1QTrue.Size = new System.Drawing.Size(42, 20);
            this.rb1QTrue.TabIndex = 2;
            this.rb1QTrue.TabStop = true;
            this.rb1QTrue.Text = "int";
            this.rb1QTrue.UseVisualStyleBackColor = false;
            // 
            // rb1QFalse
            // 
            this.rb1QFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb1QFalse.AutoSize = true;
            this.rb1QFalse.BackColor = System.Drawing.Color.Transparent;
            this.rb1QFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb1QFalse.Location = new System.Drawing.Point(321, 136);
            this.rb1QFalse.Name = "rb1QFalse";
            this.rb1QFalse.Size = new System.Drawing.Size(74, 20);
            this.rb1QFalse.TabIndex = 2;
            this.rb1QFalse.TabStop = true;
            this.rb1QFalse.Text = "double";
            this.rb1QFalse.UseVisualStyleBackColor = false;
            // 
            // btnTo2Q
            // 
            this.btnTo2Q.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTo2Q.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTo2Q.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTo2Q.Location = new System.Drawing.Point(147, 180);
            this.btnTo2Q.Name = "btnTo2Q";
            this.btnTo2Q.Size = new System.Drawing.Size(165, 52);
            this.btnTo2Q.TabIndex = 3;
            this.btnTo2Q.Text = "Далее";
            this.btnTo2Q.UseVisualStyleBackColor = false;
            this.btnTo2Q.Click += new System.EventHandler(this.btnTo2Q_Click);
            // 
            // f1Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProfTest.Properties.Resources._478985058;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnTo2Q);
            this.Controls.Add(this.rb1QFalse);
            this.Controls.Add(this.rb1QTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f1Q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb1QTrue;
        private System.Windows.Forms.RadioButton rb1QFalse;
        private System.Windows.Forms.Button btnTo2Q;
    }
}