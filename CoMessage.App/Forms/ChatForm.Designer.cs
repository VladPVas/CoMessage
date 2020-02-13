namespace CoMessageApp.Forms
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.btSendMessage = new System.Windows.Forms.Button();
            this.reWriteMessage = new System.Windows.Forms.RichTextBox();
            this.ilstMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlChatList = new System.Windows.Forms.Panel();
            this.pnlChatListHandle = new System.Windows.Forms.Panel();
            this.lbxChatList = new System.Windows.Forms.ListBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbUserNickname = new System.Windows.Forms.Label();
            this.lbUserStatus = new System.Windows.Forms.Label();
            this.btShowChatList = new System.Windows.Forms.Button();
            this.lbxChat = new System.Windows.Forms.ListBox();
            this.btChatInfo = new System.Windows.Forms.Button();
            this.picChatListLogo = new System.Windows.Forms.PictureBox();
            this.btAddChat = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.pnlChatList.SuspendLayout();
            this.pnlChatListHandle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChatListLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSendMessage
            // 
            this.btSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btSendMessage.BackgroundImage = global::CoMessageApp.Properties.Resources.sendFile;
            this.btSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSendMessage.FlatAppearance.BorderSize = 0;
            this.btSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSendMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btSendMessage.Location = new System.Drawing.Point(693, 492);
            this.btSendMessage.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(52, 88);
            this.btSendMessage.TabIndex = 0;
            this.btSendMessage.Text = "->";
            this.btSendMessage.UseVisualStyleBackColor = false;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // reWriteMessage
            // 
            this.reWriteMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reWriteMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.reWriteMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reWriteMessage.ForeColor = System.Drawing.Color.DarkCyan;
            this.reWriteMessage.Location = new System.Drawing.Point(293, 492);
            this.reWriteMessage.Name = "reWriteMessage";
            this.reWriteMessage.Size = new System.Drawing.Size(336, 88);
            this.reWriteMessage.TabIndex = 2;
            this.reWriteMessage.Text = "";
            this.reWriteMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reWriteMessage_KeyDown);
            // 
            // ilstMain
            // 
            this.ilstMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstMain.ImageStream")));
            this.ilstMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstMain.Images.SetKeyName(0, "icons8_info_24px.png");
            // 
            // pnlChatList
            // 
            this.pnlChatList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChatList.Controls.Add(this.pnlChatListHandle);
            this.pnlChatList.Controls.Add(this.lbxChatList);
            this.pnlChatList.Location = new System.Drawing.Point(0, 3);
            this.pnlChatList.Name = "pnlChatList";
            this.pnlChatList.Size = new System.Drawing.Size(290, 577);
            this.pnlChatList.TabIndex = 8;
            // 
            // pnlChatListHandle
            // 
            this.pnlChatListHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pnlChatListHandle.Controls.Add(this.picChatListLogo);
            this.pnlChatListHandle.Controls.Add(this.btAddChat);
            this.pnlChatListHandle.Controls.Add(this.btSettings);
            this.pnlChatListHandle.Location = new System.Drawing.Point(0, -3);
            this.pnlChatListHandle.Name = "pnlChatListHandle";
            this.pnlChatListHandle.Size = new System.Drawing.Size(293, 40);
            this.pnlChatListHandle.TabIndex = 1;
            // 
            // lbxChatList
            // 
            this.lbxChatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxChatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbxChatList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxChatList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxChatList.FormattingEnabled = true;
            this.lbxChatList.IntegralHeight = false;
            this.lbxChatList.ItemHeight = 72;
            this.lbxChatList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.lbxChatList.Location = new System.Drawing.Point(0, 40);
            this.lbxChatList.Margin = new System.Windows.Forms.Padding(0);
            this.lbxChatList.Name = "lbxChatList";
            this.lbxChatList.Size = new System.Drawing.Size(293, 537);
            this.lbxChatList.TabIndex = 0;
            this.lbxChatList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxChatList_DrawItem);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.pnlMain.Controls.Add(this.lbUserNickname);
            this.pnlMain.Controls.Add(this.btChatInfo);
            this.pnlMain.Controls.Add(this.lbUserStatus);
            this.pnlMain.Controls.Add(this.btShowChatList);
            this.pnlMain.Location = new System.Drawing.Point(293, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(453, 40);
            this.pnlMain.TabIndex = 9;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // lbUserNickname
            // 
            this.lbUserNickname.AutoSize = true;
            this.lbUserNickname.Location = new System.Drawing.Point(46, 14);
            this.lbUserNickname.Name = "lbUserNickname";
            this.lbUserNickname.Size = new System.Drawing.Size(89, 13);
            this.lbUserNickname.TabIndex = 3;
            this.lbUserNickname.Text = "<UserNickname>";
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.AutoSize = true;
            this.lbUserStatus.Location = new System.Drawing.Point(137, 14);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(71, 13);
            this.lbUserStatus.TabIndex = 3;
            this.lbUserStatus.Text = "<UserStatus>";
            this.lbUserStatus.Visible = false;
            this.lbUserStatus.Click += new System.EventHandler(this.lbUserStatus_Click);
            // 
            // btShowChatList
            // 
            this.btShowChatList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btShowChatList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btShowChatList.FlatAppearance.BorderSize = 0;
            this.btShowChatList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowChatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btShowChatList.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btShowChatList.Location = new System.Drawing.Point(0, 0);
            this.btShowChatList.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btShowChatList.Name = "btShowChatList";
            this.btShowChatList.Size = new System.Drawing.Size(40, 40);
            this.btShowChatList.TabIndex = 0;
            this.btShowChatList.Text = "<<";
            this.btShowChatList.UseVisualStyleBackColor = false;
            this.btShowChatList.Click += new System.EventHandler(this.btShowChatList_Click);
            // 
            // lbxChat
            // 
            this.lbxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.lbxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxChat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbxChat.IntegralHeight = false;
            this.lbxChat.ItemHeight = 100;
            this.lbxChat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.lbxChat.Location = new System.Drawing.Point(293, 43);
            this.lbxChat.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbxChat.Name = "lbxChat";
            this.lbxChat.Size = new System.Drawing.Size(452, 444);
            this.lbxChat.TabIndex = 10;
            this.lbxChat.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxChat_DrawItem);
            this.lbxChat.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbxChat_MeasureItem);
            this.lbxChat.SizeChanged += new System.EventHandler(this.lbxChat_SizeChanged);
            this.lbxChat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxChat_MouseDoubleClick);
            // 
            // btChatInfo
            // 
            this.btChatInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btChatInfo.BackgroundImage = global::CoMessageApp.Properties.Resources.information_24px;
            this.btChatInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btChatInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChatInfo.FlatAppearance.BorderSize = 0;
            this.btChatInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChatInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btChatInfo.Location = new System.Drawing.Point(413, 0);
            this.btChatInfo.Name = "btChatInfo";
            this.btChatInfo.Size = new System.Drawing.Size(40, 40);
            this.btChatInfo.TabIndex = 1;
            this.btChatInfo.UseVisualStyleBackColor = false;
            // 
            // picChatListLogo
            // 
            this.picChatListLogo.BackColor = System.Drawing.Color.Transparent;
            this.picChatListLogo.BackgroundImage = global::CoMessageApp.Properties.Resources.ChatForm__ChatListLogo;
            this.picChatListLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picChatListLogo.ErrorImage = null;
            this.picChatListLogo.InitialImage = null;
            this.picChatListLogo.Location = new System.Drawing.Point(0, 0);
            this.picChatListLogo.Name = "picChatListLogo";
            this.picChatListLogo.Size = new System.Drawing.Size(130, 40);
            this.picChatListLogo.TabIndex = 1;
            this.picChatListLogo.TabStop = false;
            // 
            // btAddChat
            // 
            this.btAddChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btAddChat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddChat.BackgroundImage")));
            this.btAddChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAddChat.FlatAppearance.BorderSize = 0;
            this.btAddChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btAddChat.Location = new System.Drawing.Point(208, 0);
            this.btAddChat.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btAddChat.Name = "btAddChat";
            this.btAddChat.Size = new System.Drawing.Size(40, 40);
            this.btAddChat.TabIndex = 0;
            this.btAddChat.UseVisualStyleBackColor = false;
            this.btAddChat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSettings
            // 
            this.btSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btSettings.BackgroundImage = global::CoMessageApp.Properties.Resources.icon_settings_41x41;
            this.btSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSettings.FlatAppearance.BorderSize = 0;
            this.btSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btSettings.Location = new System.Drawing.Point(249, 0);
            this.btSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(40, 40);
            this.btSettings.TabIndex = 0;
            this.btSettings.UseVisualStyleBackColor = false;
            this.btSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAddFile
            // 
            this.btAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.btAddFile.BackgroundImage = global::CoMessageApp.Properties.Resources.addFile;
            this.btAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAddFile.FlatAppearance.BorderSize = 0;
            this.btAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btAddFile.Location = new System.Drawing.Point(635, 492);
            this.btAddFile.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(52, 88);
            this.btAddFile.TabIndex = 0;
            this.btAddFile.Text = "+";
            this.btAddFile.UseVisualStyleBackColor = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(748, 583);
            this.Controls.Add(this.lbxChat);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlChatList);
            this.Controls.Add(this.reWriteMessage);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.btSendMessage);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.pnlChatList.ResumeLayout(false);
            this.pnlChatListHandle.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChatListLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.RichTextBox reWriteMessage;
        private System.Windows.Forms.ImageList ilstMain;
        private System.Windows.Forms.Panel pnlChatList;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lbUserNickname;
        private System.Windows.Forms.Button btChatInfo;
        private System.Windows.Forms.Label lbUserStatus;
        private System.Windows.Forms.Button btShowChatList;
        private System.Windows.Forms.ListBox lbxChatList;
        private System.Windows.Forms.ListBox lbxChat;
        private System.Windows.Forms.Panel pnlChatListHandle;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.PictureBox picChatListLogo;
        private System.Windows.Forms.Button btAddChat;
    }
}