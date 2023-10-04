namespace RichTextBoxControlIvanoKarkovic
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CitajButton = new System.Windows.Forms.Button();
            this.BrisiButton = new System.Windows.Forms.Button();
            this.SpremiButton = new System.Windows.Forms.Button();
            this.kutija = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CitajButton
            // 
            this.CitajButton.Location = new System.Drawing.Point(110, 46);
            this.CitajButton.Name = "CitajButton";
            this.CitajButton.Size = new System.Drawing.Size(75, 23);
            this.CitajButton.TabIndex = 2;
            this.CitajButton.Text = "Citaj";
            this.CitajButton.UseVisualStyleBackColor = true;
            this.CitajButton.Click += new System.EventHandler(this.CitajButton_Click);
            // 
            // BrisiButton
            // 
            this.BrisiButton.Location = new System.Drawing.Point(350, 46);
            this.BrisiButton.Name = "BrisiButton";
            this.BrisiButton.Size = new System.Drawing.Size(75, 23);
            this.BrisiButton.TabIndex = 3;
            this.BrisiButton.Text = "Brisi";
            this.BrisiButton.UseVisualStyleBackColor = true;
            this.BrisiButton.Click += new System.EventHandler(this.BrisiButton_Click);
            // 
            // SpremiButton
            // 
            this.SpremiButton.Location = new System.Drawing.Point(110, 345);
            this.SpremiButton.Name = "SpremiButton";
            this.SpremiButton.Size = new System.Drawing.Size(75, 23);
            this.SpremiButton.TabIndex = 4;
            this.SpremiButton.Text = "Spremi";
            this.SpremiButton.UseVisualStyleBackColor = true;
            this.SpremiButton.Click += new System.EventHandler(this.SpremiButton_Click);
            // 
            // kutija
            // 
            this.kutija.Location = new System.Drawing.Point(110, 107);
            this.kutija.Name = "kutija";
            this.kutija.Size = new System.Drawing.Size(315, 200);
            this.kutija.TabIndex = 5;
            this.kutija.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kutija);
            this.Controls.Add(this.SpremiButton);
            this.Controls.Add(this.BrisiButton);
            this.Controls.Add(this.CitajButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button CitajButton;
        private System.Windows.Forms.Button BrisiButton;
        private System.Windows.Forms.Button SpremiButton;
        private System.Windows.Forms.RichTextBox kutija;
    }
}

