namespace bruh
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.choiceLabel = new System.Windows.Forms.Label();
            this.sceneBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(1, 289);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(483, 152);
            this.outputLabel.TabIndex = 1;
            // 
            // choiceLabel
            // 
            this.choiceLabel.Location = new System.Drawing.Point(490, 289);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(309, 153);
            this.choiceLabel.TabIndex = 2;
            // 
            // sceneBox
            // 
            this.sceneBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sceneBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sceneBox.Location = new System.Drawing.Point(0, 0);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(800, 286);
            this.sceneBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sceneBox.TabIndex = 3;
            this.sceneBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sceneBox);
            this.Controls.Add(this.choiceLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label choiceLabel;
        private System.Windows.Forms.PictureBox sceneBox;
    }
}

