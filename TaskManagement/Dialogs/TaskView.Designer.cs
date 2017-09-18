namespace TaskManagement
{
    partial class TaskView
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
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateRequired = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelComments = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateCreated
            // 
            this.dateCreated.CustomFormat = "";
            this.dateCreated.Enabled = false;
            this.dateCreated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateCreated.Location = new System.Drawing.Point(100, 70);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(251, 20);
            this.dateCreated.TabIndex = 31;
            // 
            // cbUser
            // 
            this.cbUser.Enabled = false;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "Ivan",
            "Gosho",
            "Petyr",
            "Pesho",
            "Ivo"});
            this.cbUser.Location = new System.Drawing.Point(100, 280);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(251, 21);
            this.cbUser.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Assigned To";
            // 
            // cbState
            // 
            this.cbState.Enabled = false;
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(100, 253);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(251, 21);
            this.cbState.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "State";
            // 
            // cbType
            // 
            this.cbType.Enabled = false;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(100, 226);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(251, 21);
            this.cbType.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Type";
            // 
            // tbDesc
            // 
            this.tbDesc.Enabled = false;
            this.tbDesc.Location = new System.Drawing.Point(100, 122);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(251, 98);
            this.tbDesc.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Description";
            // 
            // dateRequired
            // 
            this.dateRequired.Location = new System.Drawing.Point(100, 96);
            this.dateRequired.Name = "dateRequired";
            this.dateRequired.Size = new System.Drawing.Size(251, 20);
            this.dateRequired.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Required Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Created Date";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 44);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(251, 20);
            this.tbId.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Id";
            // 
            // panelComments
            // 
            this.panelComments.Location = new System.Drawing.Point(357, 44);
            this.panelComments.Name = "panelComments";
            this.panelComments.Size = new System.Drawing.Size(284, 257);
            this.panelComments.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addCommentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addCommentToolStripMenuItem
            // 
            this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            this.addCommentToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.addCommentToolStripMenuItem.Text = "Add Comment";
            this.addCommentToolStripMenuItem.Click += new System.EventHandler(this.addCommentToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(548, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelComments);
            this.Controls.Add(this.dateCreated);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateRequired);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TaskView";
            this.Text = "TaskView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateRequired;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelComments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}