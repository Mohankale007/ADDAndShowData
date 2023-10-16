namespace ADD_SHOW_FORM
{
    partial class Form1
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            aDDINFORMATIONToolStripMenuItem = new ToolStripMenuItem();
            sHOWINFORMATIONToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 175);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDDINFORMATIONToolStripMenuItem, sHOWINFORMATIONToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(756, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDDINFORMATIONToolStripMenuItem
            // 
            aDDINFORMATIONToolStripMenuItem.Name = "aDDINFORMATIONToolStripMenuItem";
            aDDINFORMATIONToolStripMenuItem.Size = new Size(125, 20);
            aDDINFORMATIONToolStripMenuItem.Text = "ADD INFORMATION";
            aDDINFORMATIONToolStripMenuItem.Click += aDDINFORMATIONToolStripMenuItem_Click;
            // 
            // sHOWINFORMATIONToolStripMenuItem
            // 
            sHOWINFORMATIONToolStripMenuItem.Name = "sHOWINFORMATIONToolStripMenuItem";
            sHOWINFORMATIONToolStripMenuItem.Size = new Size(136, 20);
            sHOWINFORMATIONToolStripMenuItem.Text = "SHOW INFORMATION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 483);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDDINFORMATIONToolStripMenuItem;
        private ToolStripMenuItem sHOWINFORMATIONToolStripMenuItem;
    }
}