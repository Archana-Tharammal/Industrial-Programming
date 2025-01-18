using System.Windows.Forms;

namespace Web_server
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
            textBox = new TextBox();
            go_button = new Button();
            refresh_button = new Button();
            forward_button = new Button();
            Backward_button = new Button();
            add_to_fav_button = new Button();
            html_Textbox = new TextBox();
            title = new Label();
            status_textbox = new TextBox();
            history_listBox = new ListBox();
            fav_label = new Label();
            hist_label = new Label();
            bulk_download = new Button();
            Edit_fav_button = new Button();
            Delete_fav_button = new Button();
            Delete_hist_button = new Button();
            favourite_listbox = new ListBox();
            Home_button = new Button();
            title_textBox = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(29, 73);
            textBox.Name = "textBox";
            textBox.Size = new Size(790, 27);
            textBox.TabIndex = 0;
            textBox.KeyDown += textBox_KeyDown;
            // 
            // go_button
            // 
            go_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            go_button.Location = new Point(852, 73);
            go_button.Name = "go_button";
            go_button.Size = new Size(110, 28);
            go_button.TabIndex = 1;
            go_button.Text = "Go";
            go_button.TextAlign = ContentAlignment.TopCenter;
            go_button.UseVisualStyleBackColor = true;
            go_button.Click += go_button_Click;
            // 
            // refresh_button
            // 
            refresh_button.Image = Properties.Resources.re1;
            refresh_button.Location = new Point(220, 27);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(36, 29);
            refresh_button.TabIndex = 2;
            refresh_button.TextAlign = ContentAlignment.MiddleLeft;
            refresh_button.UseVisualStyleBackColor = true;
            refresh_button.Click += refresh_button_Click_1;
            // 
            // forward_button
            // 
            forward_button.Location = new Point(112, 27);
            forward_button.Name = "forward_button";
            forward_button.Size = new Size(94, 29);
            forward_button.TabIndex = 3;
            forward_button.Text = "Forward";
            forward_button.UseVisualStyleBackColor = true;
            forward_button.Click += forward_button_Click;
            // 
            // Backward_button
            // 
            Backward_button.Location = new Point(12, 27);
            Backward_button.Name = "Backward_button";
            Backward_button.Size = new Size(94, 29);
            Backward_button.TabIndex = 4;
            Backward_button.Text = "Backward";
            Backward_button.UseVisualStyleBackColor = true;
            Backward_button.Click += Backward_button_Click;
            // 
            // add_to_fav_button
            // 
            add_to_fav_button.Image = Properties.Resources.h31;
            add_to_fav_button.Location = new Point(277, 27);
            add_to_fav_button.Name = "add_to_fav_button";
            add_to_fav_button.Size = new Size(33, 29);
            add_to_fav_button.TabIndex = 6;
            add_to_fav_button.UseVisualStyleBackColor = true;
            add_to_fav_button.Click += add_to_fav_button_Click_1;
            // 
            // html_Textbox
            // 
            html_Textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            html_Textbox.BackColor = SystemColors.ControlLightLight;
            html_Textbox.Location = new Point(271, 188);
            html_Textbox.Multiline = true;
            html_Textbox.Name = "html_Textbox";
            html_Textbox.ReadOnly = true;
            html_Textbox.ScrollBars = ScrollBars.Vertical;
            html_Textbox.Size = new Size(738, 435);
            html_Textbox.TabIndex = 8;
            html_Textbox.TextChanged += html_Textbox_TextChanged;
            // 
            // title
            // 
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 23;
            // 
            // status_textbox
            // 
            status_textbox.Location = new Point(271, 155);
            status_textbox.Name = "status_textbox";
            status_textbox.ReadOnly = true;
            status_textbox.Size = new Size(247, 27);
            status_textbox.TabIndex = 11;
            
            // 
            // history_listBox
            // 
            history_listBox.FormattingEnabled = true;
            history_listBox.Location = new Point(12, 367);
            history_listBox.Name = "history_listBox";
            history_listBox.Size = new Size(244, 204);
            history_listBox.TabIndex = 13;
            history_listBox.MouseClick += history_listBox_MouseClick;
            // 
            // fav_label
            // 
            fav_label.AutoSize = true;
            fav_label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fav_label.Location = new Point(12, 115);
            fav_label.Name = "fav_label";
            fav_label.Size = new Size(92, 25);
            fav_label.TabIndex = 14;
            fav_label.Text = "Favourites";
            // 
            // hist_label
            // 
            hist_label.AutoSize = true;
            hist_label.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hist_label.Location = new Point(12, 339);
            hist_label.Name = "hist_label";
            hist_label.Size = new Size(69, 25);
            hist_label.TabIndex = 15;
            hist_label.Text = "History";
            // 
            // bulk_download
            // 
            bulk_download.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bulk_download.Location = new Point(913, 27);
            bulk_download.Name = "bulk_download";
            bulk_download.Size = new Size(96, 29);
            bulk_download.TabIndex = 16;
            bulk_download.Text = "download";
            bulk_download.UseVisualStyleBackColor = true;
            bulk_download.Click += bulk_download_Click;
            // 
            // Edit_fav_button
            // 
            Edit_fav_button.Location = new Point(139, 106);
            Edit_fav_button.Name = "Edit_fav_button";
            Edit_fav_button.Size = new Size(46, 29);
            Edit_fav_button.TabIndex = 17;
            Edit_fav_button.Text = "Edit";
            Edit_fav_button.UseVisualStyleBackColor = true;
            Edit_fav_button.Click += Edit_fav_button_Click;
            // 
            // Delete_fav_button
            // 
            Delete_fav_button.Location = new Point(191, 106);
            Delete_fav_button.Name = "Delete_fav_button";
            Delete_fav_button.Size = new Size(65, 29);
            Delete_fav_button.TabIndex = 18;
            Delete_fav_button.Text = "Delete";
            Delete_fav_button.UseVisualStyleBackColor = true;
            Delete_fav_button.Click += Delete_fav_button_Click;
            // 
            // Delete_hist_button
            // 
            Delete_hist_button.BackgroundImageLayout = ImageLayout.Center;
            Delete_hist_button.Location = new Point(162, 335);
            Delete_hist_button.Name = "Delete_hist_button";
            Delete_hist_button.Size = new Size(94, 29);
            Delete_hist_button.TabIndex = 19;
            Delete_hist_button.Text = "Delete";
            Delete_hist_button.UseVisualStyleBackColor = true;
            Delete_hist_button.Click += Delete_hist_button_Click;
            // 
            // favourite_listbox
            // 
            favourite_listbox.FormattingEnabled = true;
            favourite_listbox.Location = new Point(12, 141);
            favourite_listbox.Name = "favourite_listbox";
            favourite_listbox.Size = new Size(244, 184);
            favourite_listbox.TabIndex = 20;
            favourite_listbox.SelectedIndexChanged += favourite_listbox_SelectedIndexChanged;
            // 
            // Home_button
            // 
            Home_button.Location = new Point(332, 27);
            Home_button.Name = "Home_button";
            Home_button.Size = new Size(94, 29);
            Home_button.TabIndex = 21;
            Home_button.Text = "Home";
            Home_button.UseVisualStyleBackColor = true;
            Home_button.Click += Home_button_Click;
            // 
            // title_textBox
            // 
            title_textBox.BackColor = SystemColors.Menu;
            title_textBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title_textBox.Location = new Point(284, 122);
            title_textBox.Name = "title_textBox";
            title_textBox.ReadOnly = true;
            title_textBox.Size = new Size(678, 30);
            title_textBox.TabIndex = 22;
            title_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1021, 635);
            Controls.Add(title_textBox);
            Controls.Add(Home_button);
            Controls.Add(favourite_listbox);
            Controls.Add(Delete_hist_button);
            Controls.Add(Delete_fav_button);
            Controls.Add(Edit_fav_button);
            Controls.Add(bulk_download);
            Controls.Add(hist_label);
            Controls.Add(fav_label);
            Controls.Add(history_listBox);
            Controls.Add(status_textbox);
            Controls.Add(title);
            Controls.Add(html_Textbox);
            Controls.Add(add_to_fav_button);
            Controls.Add(Backward_button);
            Controls.Add(forward_button);
            Controls.Add(refresh_button);
            Controls.Add(go_button);
            Controls.Add(textBox);
            KeyPreview = true;
            Name = "Form1";
            Text = "Web Browser";
            KeyDown += textBox_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button go_button;
        private Button refresh_button;
        private Button forward_button;
        private Button Backward_button;
        private Button add_to_fav_button;
        private TextBox http_Textbox;
        private TextBox html_Textbox;
        private Label title;
        private Label status;
        private TextBox status_textbox;
        private ListBox history_listBox;
        private Label fav_label;
        private Label hist_label;
        private Button bulk_download;
        private Button Edit_fav_button;
        private Button Delete_fav_button;
        private Button Delete_hist_button;
        private ListBox favourite_listbox;
        private Button Home_button;
        private TextBox title_textBox;
    }
}
