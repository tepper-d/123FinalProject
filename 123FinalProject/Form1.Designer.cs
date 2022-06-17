namespace _123FinalProject
{
    partial class PuppyDuplicator
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
            this.btnClone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(104, 91);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(94, 29);
            this.btnClone.TabIndex = 0;
            this.btnClone.Text = "&Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // PuppyDuplicator
            // 
            this.AcceptButton = this.btnClone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 211);
            this.Controls.Add(this.btnClone);
            this.Name = "PuppyDuplicator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puppy Duplicator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClone;
    }
}