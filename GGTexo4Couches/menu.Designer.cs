namespace GGTexo4Couches
{
    partial class menu
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
            menuStrip1 = new MenuStrip();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            categorieToolStripMenuItem = new ToolStripMenuItem();
            groupeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(916, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categorieToolStripMenuItem, groupeToolStripMenuItem });
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(59, 20);
            gestionToolStripMenuItem.Text = "Gestion";
            // 
            // categorieToolStripMenuItem
            // 
            categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            categorieToolStripMenuItem.Size = new Size(180, 22);
            categorieToolStripMenuItem.Text = "Categorie";
            // 
            // groupeToolStripMenuItem
            // 
            groupeToolStripMenuItem.Name = "groupeToolStripMenuItem";
            groupeToolStripMenuItem.Size = new Size(180, 22);
            groupeToolStripMenuItem.Text = "Groupe";
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 492);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "menu";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem categorieToolStripMenuItem;
        private ToolStripMenuItem groupeToolStripMenuItem;
    }
}
