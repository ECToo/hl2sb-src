﻿namespace FriendManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selfControl = new FriendManager.FriendControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.friendsFlow = new FriendManager.FriendsListControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.setAliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add( this.selfControl );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 210, 56 );
            this.panel1.TabIndex = 0;
            // 
            // selfControl
            // 
            this.selfControl.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 39 ) ) ) ) );
            this.selfControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selfControl.Location = new System.Drawing.Point( 3, 3 );
            this.selfControl.Name = "selfControl";
            this.selfControl.Size = new System.Drawing.Size( 204, 46 );
            this.selfControl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add( this.friendsFlow );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point( 0, 56 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 210, 414 );
            this.panel2.TabIndex = 1;
            // 
            // friendsFlow
            // 
            this.friendsFlow.AutoScroll = true;
            this.friendsFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.friendsFlow.Location = new System.Drawing.Point( 0, 0 );
            this.friendsFlow.Name = "friendsFlow";
            this.friendsFlow.Size = new System.Drawing.Size( 208, 412 );
            this.friendsFlow.TabIndex = 0;
            this.friendsFlow.WrapContents = false;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 39 ) ) ) ) );
            this.contextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.setAliasToolStripMenuItem,
            this.removeAliasToolStripMenuItem} );
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.ShowImageMargin = false;
            this.contextMenu.Size = new System.Drawing.Size( 121, 48 );
            // 
            // setAliasToolStripMenuItem
            // 
            this.setAliasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setAliasToolStripMenuItem.Name = "setAliasToolStripMenuItem";
            this.setAliasToolStripMenuItem.Size = new System.Drawing.Size( 120, 22 );
            this.setAliasToolStripMenuItem.Text = "Set Alias";
            this.setAliasToolStripMenuItem.Click += new System.EventHandler( this.setAliasToolStripMenuItem_Click );
            // 
            // removeAliasToolStripMenuItem
            // 
            this.removeAliasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeAliasToolStripMenuItem.Name = "removeAliasToolStripMenuItem";
            this.removeAliasToolStripMenuItem.Size = new System.Drawing.Size( 120, 22 );
            this.removeAliasToolStripMenuItem.Text = "Remove Alias";
            this.removeAliasToolStripMenuItem.Click += new System.EventHandler( this.removeAliasToolStripMenuItem_Click );
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 38 ) ) ) ), ( ( int )( ( ( byte )( 39 ) ) ) ) );
            this.ClientSize = new System.Drawing.Size( 210, 470 );
            this.Controls.Add( this.panel2 );
            this.Controls.Add( this.panel1 );
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 8, 200 );
            this.Name = "MainForm";
            this.Text = "Friends";
            this.Shown += new System.EventHandler( this.MainForm_Shown );
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.MainForm_FormClosing );
            this.Resize += new System.EventHandler( this.MainForm_Resize );
            this.panel1.ResumeLayout( false );
            this.panel2.ResumeLayout( false );
            this.contextMenu.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FriendControl selfControl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem setAliasToolStripMenuItem;
        private FriendsListControl friendsFlow;
        private System.Windows.Forms.ToolStripMenuItem removeAliasToolStripMenuItem;
    }
}