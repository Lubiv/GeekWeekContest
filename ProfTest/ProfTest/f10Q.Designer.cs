namespace ProfTest
{
    partial class f10Q
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f10Q));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb10QTrue = new System.Windows.Forms.RadioButton();
            this.rb10QFalse = new System.Windows.Forms.RadioButton();
            this.btnToResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Посещаете ли вы портал geekbrains.ru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(104, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "с целью обучения С#?";
            // 
            // rb10QTrue
            // 
            this.rb10QTrue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb10QTrue.AutoSize = true;
            this.rb10QTrue.BackColor = System.Drawing.Color.Transparent;
            this.rb10QTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb10QTrue.Location = new System.Drawing.Point(135, 120);
            this.rb10QTrue.Name = "rb10QTrue";
            this.rb10QTrue.Size = new System.Drawing.Size(43, 19);
            this.rb10QTrue.TabIndex = 1;
            this.rb10QTrue.TabStop = true;
            this.rb10QTrue.Text = "Да";
            this.rb10QTrue.UseVisualStyleBackColor = false;
            // 
            // rb10QFalse
            // 
            this.rb10QFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rb10QFalse.AutoSize = true;
            this.rb10QFalse.BackColor = System.Drawing.Color.Transparent;
            this.rb10QFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb10QFalse.Location = new System.Drawing.Point(314, 120);
            this.rb10QFalse.Name = "rb10QFalse";
            this.rb10QFalse.Size = new System.Drawing.Size(51, 19);
            this.rb10QFalse.TabIndex = 1;
            this.rb10QFalse.TabStop = true;
            this.rb10QFalse.Text = "Нет";
            this.rb10QFalse.UseVisualStyleBackColor = false;
            // 
            // btnToResult
            // 
            this.btnToResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToResult.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnToResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToResult.Location = new System.Drawing.Point(167, 163);
            this.btnToResult.Name = "btnToResult";
            this.btnToResult.Size = new System.Drawing.Size(155, 51);
            this.btnToResult.TabIndex = 2;
            this.btnToResult.Text = "Готово";
            this.btnToResult.UseVisualStyleBackColor = false;
            this.btnToResult.Click += new System.EventHandler(this.btnToResult_Click);
            // 
            // f10Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProfTest.Properties.Resources._478985058;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 237);
            this.Controls.Add(this.btnToResult);
            this.Controls.Add(this.rb10QFalse);
            this.Controls.Add(this.rb10QTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f10Q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb10QTrue;
        private System.Windows.Forms.RadioButton rb10QFalse;
        private System.Windows.Forms.Button btnToResult;
    }
}