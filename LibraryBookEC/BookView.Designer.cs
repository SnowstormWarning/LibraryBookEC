
namespace LibraryBookEC
{
    partial class BookView
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.RemoveBookmarkButton = new System.Windows.Forms.Button();
            this.AddBookmarkButton = new System.Windows.Forms.Button();
            this.UpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(746, 922);
            this.TextBox.TabIndex = 0;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.Location = new System.Drawing.Point(12, 940);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(128, 54);
            this.PreviousPageButton.TabIndex = 1;
            this.PreviousPageButton.Text = "Prev";
            this.PreviousPageButton.UseVisualStyleBackColor = true;
            this.PreviousPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // NextPageButton
            // 
            this.NextPageButton.Location = new System.Drawing.Point(630, 940);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(128, 54);
            this.NextPageButton.TabIndex = 2;
            this.NextPageButton.Text = "Next";
            this.NextPageButton.UseVisualStyleBackColor = true;
            this.NextPageButton.Click += new System.EventHandler(this.NextPageButton_Click);
            // 
            // RemoveBookmarkButton
            // 
            this.RemoveBookmarkButton.Location = new System.Drawing.Point(146, 940);
            this.RemoveBookmarkButton.Name = "RemoveBookmarkButton";
            this.RemoveBookmarkButton.Size = new System.Drawing.Size(161, 54);
            this.RemoveBookmarkButton.TabIndex = 3;
            this.RemoveBookmarkButton.Text = "- Bookmark";
            this.RemoveBookmarkButton.UseVisualStyleBackColor = true;
            this.RemoveBookmarkButton.Click += new System.EventHandler(this.RemoveBookmarkButton_Click);
            // 
            // AddBookmarkButton
            // 
            this.AddBookmarkButton.Location = new System.Drawing.Point(465, 940);
            this.AddBookmarkButton.Name = "AddBookmarkButton";
            this.AddBookmarkButton.Size = new System.Drawing.Size(159, 54);
            this.AddBookmarkButton.TabIndex = 4;
            this.AddBookmarkButton.Text = "+ Bookmark";
            this.AddBookmarkButton.UseVisualStyleBackColor = true;
            this.AddBookmarkButton.Click += new System.EventHandler(this.AddBookmarkButton_Click);
            // 
            // UpDown
            // 
            this.UpDown.Location = new System.Drawing.Point(323, 953);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(120, 31);
            this.UpDown.TabIndex = 5;
            this.UpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 1006);
            this.Controls.Add(this.UpDown);
            this.Controls.Add(this.AddBookmarkButton);
            this.Controls.Add(this.RemoveBookmarkButton);
            this.Controls.Add(this.NextPageButton);
            this.Controls.Add(this.PreviousPageButton);
            this.Controls.Add(this.TextBox);
            this.Name = "BookView";
            this.Text = "BookView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button RemoveBookmarkButton;
        private System.Windows.Forms.Button AddBookmarkButton;
        private System.Windows.Forms.NumericUpDown UpDown;
    }
}