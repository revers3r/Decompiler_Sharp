namespace CS_Decompiler
{
    partial class Load
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.main_panel = new System.Windows.Forms.Panel();
            this.Tree_List = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IL_Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.editbox1_panel = new System.Windows.Forms.Panel();
            this.Path_Name = new System.Windows.Forms.Label();
            this.path_button = new System.Windows.Forms.Button();
            this.FilePath_edit = new System.Windows.Forms.TextBox();
            this.member_tree = new System.Windows.Forms.TreeView();
            this.main_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.IL_Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.editbox1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.Tree_List);
            this.main_panel.Controls.Add(this.groupBox1);
            this.main_panel.Controls.Add(this.member_tree);
            this.main_panel.Location = new System.Drawing.Point(12, 12);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1003, 521);
            this.main_panel.TabIndex = 0;
            // 
            // Tree_List
            // 
            this.Tree_List.AutoSize = true;
            this.Tree_List.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Tree_List.Font = new System.Drawing.Font("AmeriGarmnd BT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tree_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Tree_List.Location = new System.Drawing.Point(18, 52);
            this.Tree_List.Name = "Tree_List";
            this.Tree_List.Size = new System.Drawing.Size(147, 19);
            this.Tree_List.TabIndex = 5;
            this.Tree_List.Text = "- Assembly Members";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.IL_Menu);
            this.groupBox1.Controls.Add(this.editbox1_panel);
            this.groupBox1.Location = new System.Drawing.Point(363, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 520);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(608, 86);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IL_Menu
            // 
            this.IL_Menu.Controls.Add(this.tabPage1);
            this.IL_Menu.Controls.Add(this.tabPage2);
            this.IL_Menu.Location = new System.Drawing.Point(12, 179);
            this.IL_Menu.Name = "IL_Menu";
            this.IL_Menu.SelectedIndex = 0;
            this.IL_Menu.Size = new System.Drawing.Size(612, 320);
            this.IL_Menu.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "C# Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(-4, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(607, 293);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(604, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IL Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Black;
            this.richTextBox2.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox2.Location = new System.Drawing.Point(0, 1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(604, 292);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // editbox1_panel
            // 
            this.editbox1_panel.Controls.Add(this.Path_Name);
            this.editbox1_panel.Controls.Add(this.path_button);
            this.editbox1_panel.Controls.Add(this.FilePath_edit);
            this.editbox1_panel.Location = new System.Drawing.Point(16, 20);
            this.editbox1_panel.Name = "editbox1_panel";
            this.editbox1_panel.Size = new System.Drawing.Size(609, 46);
            this.editbox1_panel.TabIndex = 0;
            // 
            // Path_Name
            // 
            this.Path_Name.AutoSize = true;
            this.Path_Name.Font = new System.Drawing.Font("굴림", 11F);
            this.Path_Name.Location = new System.Drawing.Point(78, 15);
            this.Path_Name.Name = "Path_Name";
            this.Path_Name.Size = new System.Drawing.Size(52, 15);
            this.Path_Name.TabIndex = 2;
            this.Path_Name.Text = "Path : ";
            // 
            // path_button
            // 
            this.path_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.path_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.path_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.path_button.Location = new System.Drawing.Point(487, 13);
            this.path_button.Name = "path_button";
            this.path_button.Size = new System.Drawing.Size(78, 23);
            this.path_button.TabIndex = 1;
            this.path_button.Text = "Ok";
            this.path_button.UseVisualStyleBackColor = false;
            this.path_button.Click += new System.EventHandler(this.path_button_Click);
            // 
            // FilePath_edit
            // 
            this.FilePath_edit.Location = new System.Drawing.Point(136, 15);
            this.FilePath_edit.Name = "FilePath_edit";
            this.FilePath_edit.Size = new System.Drawing.Size(332, 21);
            this.FilePath_edit.TabIndex = 0;
            // 
            // member_tree
            // 
            this.member_tree.Location = new System.Drawing.Point(16, 80);
            this.member_tree.Name = "member_tree";
            this.member_tree.Size = new System.Drawing.Size(325, 423);
            this.member_tree.TabIndex = 2;
            this.member_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.member_tree_AfterSelect);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1027, 545);
            this.ControlBox = false;
            this.Controls.Add(this.main_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.Text = "CS Decompiler";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.IL_Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.editbox1_panel.ResumeLayout(false);
            this.editbox1_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel editbox1_panel;
        private System.Windows.Forms.Button path_button;
        private System.Windows.Forms.TextBox FilePath_edit;
        private System.Windows.Forms.TabControl IL_Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Path_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TreeView member_tree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Tree_List;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

