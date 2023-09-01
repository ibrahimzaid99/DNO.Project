namespace DNO
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
            dgv = new DataGridView();
            text_name = new TextBox();
            num__duration = new NumericUpDown();
            cm = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            btn_show = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num__duration).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(0, 218);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(801, 229);
            dgv.TabIndex = 0;
            dgv.RowHeaderMouseDoubleClick += dgv_RowHeaderMouseDoubleClick;
            // 
            // text_name
            // 
            text_name.Location = new Point(134, 20);
            text_name.Name = "text_name";
            text_name.Size = new Size(125, 27);
            text_name.TabIndex = 1;
            // 
            // num__duration
            // 
            num__duration.Location = new Point(338, 91);
            num__duration.Name = "num__duration";
            num__duration.Size = new Size(150, 27);
            num__duration.TabIndex = 2;
            // 
            // cm
            // 
            cm.FormattingEnabled = true;
            cm.Location = new Point(626, 20);
            cm.Name = "cm";
            cm.Size = new Size(151, 28);
            cm.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 23);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 4;
            label1.Text = "Topics";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 5;
            label2.Text = "Course Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 28);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Course Name";
            // 
            // button1_add
            // 
            button1_add.Location = new Point(58, 177);
            button1_add.Name = "button1_add";
            button1_add.Size = new Size(94, 29);
            button1_add.TabIndex = 7;
            button1_add.Text = "Add";
            button1_add.UseVisualStyleBackColor = true;
            button1_add.Click += button1_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(262, 177);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 8;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(469, 177);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(94, 29);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(671, 177);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(94, 29);
            btn_show.TabIndex = 10;
            btn_show.Text = "Topics";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_show);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(button1_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cm);
            Controls.Add(num__duration);
            Controls.Add(text_name);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)num__duration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox text_name;
        private NumericUpDown num__duration;
        private ComboBox cm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1_add;
        private Button btn_edit;
        private Button btn_delete;
        private Button btn_show;
    }
}