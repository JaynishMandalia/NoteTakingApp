namespace NoteTakingClient
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.btnUpdateNote = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnCreateNote = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPage = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnDeleteNote);
            this.panelMenu.Controls.Add(this.btnUpdateNote);
            this.panelMenu.Controls.Add(this.btnAddNote);
            this.panelMenu.Controls.Add(this.btnCreateNote);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(246, 514);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteNote.FlatAppearance.BorderSize = 0;
            this.btnDeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNote.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteNote.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteNote.Image")));
            this.btnDeleteNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNote.Location = new System.Drawing.Point(0, 300);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnDeleteNote.Size = new System.Drawing.Size(246, 100);
            this.btnDeleteNote.TabIndex = 4;
            this.btnDeleteNote.Text = "     Delete Note";
            this.btnDeleteNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // btnUpdateNote
            // 
            this.btnUpdateNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateNote.FlatAppearance.BorderSize = 0;
            this.btnUpdateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNote.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateNote.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateNote.Image")));
            this.btnUpdateNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNote.Location = new System.Drawing.Point(0, 200);
            this.btnUpdateNote.Name = "btnUpdateNote";
            this.btnUpdateNote.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnUpdateNote.Size = new System.Drawing.Size(246, 100);
            this.btnUpdateNote.TabIndex = 3;
            this.btnUpdateNote.Text = "     Update Note";
            this.btnUpdateNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateNote.UseVisualStyleBackColor = true;
            this.btnUpdateNote.Click += new System.EventHandler(this.btnUpdateNote_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNote.FlatAppearance.BorderSize = 0;
            this.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNote.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddNote.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNote.Image")));
            this.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNote.Location = new System.Drawing.Point(0, 100);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnAddNote.Size = new System.Drawing.Size(246, 100);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "     Add Note";
            this.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnCreateNote
            // 
            this.btnCreateNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateNote.FlatAppearance.BorderSize = 0;
            this.btnCreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNote.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreateNote.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateNote.Image")));
            this.btnCreateNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNote.Location = new System.Drawing.Point(0, 0);
            this.btnCreateNote.Name = "btnCreateNote";
            this.btnCreateNote.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCreateNote.Size = new System.Drawing.Size(246, 100);
            this.btnCreateNote.TabIndex = 1;
            this.btnCreateNote.Text = "     Notes";
            this.btnCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateNote.UseVisualStyleBackColor = true;
            this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("SF Pro Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelTitleBar.Location = new System.Drawing.Point(246, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(718, 78);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(50, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(338, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPage
            // 
            this.panelDesktopPage.BackColor = System.Drawing.Color.LightGray;
            this.panelDesktopPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktopPage.BackgroundImage")));
            this.panelDesktopPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktopPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPage.Location = new System.Drawing.Point(246, 78);
            this.panelDesktopPage.Name = "panelDesktopPage";
            this.panelDesktopPage.Size = new System.Drawing.Size(718, 436);
            this.panelDesktopPage.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(964, 514);
            this.Controls.Add(this.panelDesktopPage);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Kepp Notes";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnUpdateNote;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnCreateNote;
        private System.Windows.Forms.Button btnDeleteNote;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPage;
        private System.Windows.Forms.Button btnClose;
    }
}