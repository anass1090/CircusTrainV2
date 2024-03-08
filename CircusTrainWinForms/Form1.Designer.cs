namespace CircusTrainWinForms
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
            this.listWagons = new System.Windows.Forms.ListBox();
            this.listAnimalsInWagon = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listWagons
            // 
            this.listWagons.FormattingEnabled = true;
            this.listWagons.Location = new System.Drawing.Point(289, 100);
            this.listWagons.Name = "listWagons";
            this.listWagons.Size = new System.Drawing.Size(120, 95);
            this.listWagons.TabIndex = 0;
            // 
            // listAnimalsInWagon
            // 
            this.listAnimalsInWagon.FormattingEnabled = true;
            this.listAnimalsInWagon.Location = new System.Drawing.Point(434, 100);
            this.listAnimalsInWagon.Name = "listAnimalsInWagon";
            this.listAnimalsInWagon.Size = new System.Drawing.Size(120, 95);
            this.listAnimalsInWagon.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listAnimalsInWagon);
            this.Controls.Add(this.listWagons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listWagons;
        private System.Windows.Forms.ListBox listAnimalsInWagon;
    }
}

