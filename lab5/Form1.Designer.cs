namespace lab5
{
    partial class Form2
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addTaskToolStripMenuItem = new ToolStripMenuItem();
            editTaskToolStripMenuItem = new ToolStripMenuItem();
            deletTaskToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            title = new TextBox();
            Description = new TextBox();
            Limit = new TextBox();
            Priority = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Save = new Button();
            Delete = new Button();
            label1 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(655, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(112, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(112, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addTaskToolStripMenuItem, editTaskToolStripMenuItem, deletTaskToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addTaskToolStripMenuItem
            // 
            addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            addTaskToolStripMenuItem.Size = new Size(131, 22);
            addTaskToolStripMenuItem.Text = "Add task";
            addTaskToolStripMenuItem.Click += addTaskToolStripMenuItem_Click;
            // 
            // editTaskToolStripMenuItem
            // 
            editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            editTaskToolStripMenuItem.Size = new Size(131, 22);
            editTaskToolStripMenuItem.Text = "Edit task";
            editTaskToolStripMenuItem.Click += editTaskToolStripMenuItem_Click;
            // 
            // deletTaskToolStripMenuItem
            // 
            deletTaskToolStripMenuItem.Name = "deletTaskToolStripMenuItem";
            deletTaskToolStripMenuItem.Size = new Size(131, 22);
            deletTaskToolStripMenuItem.Text = "Delete task";
            deletTaskToolStripMenuItem.Click += deletTaskToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 379);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += editTaskToolStripMenuItem_Click;
            // 
            // title
            // 
            title.Location = new Point(385, 27);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 2;
            // 
            // Description
            // 
            Description.Location = new Point(385, 85);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Size = new Size(257, 294);
            Description.TabIndex = 3;
            // 
            // Limit
            // 
            Limit.Location = new Point(385, 56);
            Limit.Name = "Limit";
            Limit.Size = new Size(257, 23);
            Limit.TabIndex = 4;
            // 
            // Priority
            // 
            Priority.Location = new Point(542, 27);
            Priority.Name = "Priority";
            Priority.Size = new Size(100, 23);
            Priority.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Desciption";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 59);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 8;
            label3.Text = "Term limit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 30);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Priority";
            // 
            // Save
            // 
            Save.Location = new Point(385, 386);
            Save.Name = "Save";
            Save.Size = new Size(122, 23);
            Save.TabIndex = 10;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(520, 386);
            Delete.Name = "Delete";
            Delete.Size = new Size(122, 23);
            Delete.TabIndex = 11;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 30);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 30);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Name";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 421);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(Delete);
            Controls.Add(Save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Priority);
            Controls.Add(Limit);
            Controls.Add(Description);
            Controls.Add(title);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "To do List";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addTaskToolStripMenuItem;
        private ToolStripMenuItem editTaskToolStripMenuItem;
        private ToolStripMenuItem deletTaskToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox listBox1;
        private TextBox title;
        private TextBox Description;
        private TextBox Limit;
        private TextBox Priority;
        private Label Title;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Save;
        private Button Delete;
        private Label label1;
        private Label label5;
    }
}