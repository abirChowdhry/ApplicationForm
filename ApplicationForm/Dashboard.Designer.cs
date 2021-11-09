
namespace ApplicationForm
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfileUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userMenuToolStripMenuItem
            // 
            this.userMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem,
            this.userProfileUpdateToolStripMenuItem,
            this.userDeleteToolStripMenuItem,
            this.userDeleteToolStripMenuItem1});
            this.userMenuToolStripMenuItem.Name = "userMenuToolStripMenuItem";
            this.userMenuToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.userMenuToolStripMenuItem.Text = "User Menu";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userListToolStripMenuItem.Text = "User Registration";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // userProfileUpdateToolStripMenuItem
            // 
            this.userProfileUpdateToolStripMenuItem.Name = "userProfileUpdateToolStripMenuItem";
            this.userProfileUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userProfileUpdateToolStripMenuItem.Text = "User List";
            // 
            // userDeleteToolStripMenuItem
            // 
            this.userDeleteToolStripMenuItem.Name = "userDeleteToolStripMenuItem";
            this.userDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userDeleteToolStripMenuItem.Text = "User Profile Update";
            // 
            // userDeleteToolStripMenuItem1
            // 
            this.userDeleteToolStripMenuItem1.Name = "userDeleteToolStripMenuItem1";
            this.userDeleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.userDeleteToolStripMenuItem1.Text = "User Delete";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 245);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfileUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDeleteToolStripMenuItem1;
    }
}