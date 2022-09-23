
namespace LibraryBookEC
{
    partial class Library
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
            this.SyncLibraryButton = new System.Windows.Forms.Button();
            this.OpenBookButton = new System.Windows.Forms.Button();
            this.UploadLibraryButton = new System.Windows.Forms.Button();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SyncLibraryButton
            // 
            this.SyncLibraryButton.Location = new System.Drawing.Point(12, 367);
            this.SyncLibraryButton.Name = "SyncLibraryButton";
            this.SyncLibraryButton.Size = new System.Drawing.Size(231, 71);
            this.SyncLibraryButton.TabIndex = 1;
            this.SyncLibraryButton.Text = "Sync Library";
            this.SyncLibraryButton.UseVisualStyleBackColor = true;
            this.SyncLibraryButton.Click += new System.EventHandler(this.SyncLibraryButton_Click);
            // 
            // OpenBookButton
            // 
            this.OpenBookButton.Location = new System.Drawing.Point(557, 367);
            this.OpenBookButton.Name = "OpenBookButton";
            this.OpenBookButton.Size = new System.Drawing.Size(231, 71);
            this.OpenBookButton.TabIndex = 2;
            this.OpenBookButton.Text = "Open Book";
            this.OpenBookButton.UseVisualStyleBackColor = true;
            this.OpenBookButton.Click += new System.EventHandler(this.OpenBookButton_Click);
            // 
            // UploadLibraryButton
            // 
            this.UploadLibraryButton.Location = new System.Drawing.Point(285, 367);
            this.UploadLibraryButton.Name = "UploadLibraryButton";
            this.UploadLibraryButton.Size = new System.Drawing.Size(231, 71);
            this.UploadLibraryButton.TabIndex = 3;
            this.UploadLibraryButton.Text = "Upload Library";
            this.UploadLibraryButton.UseVisualStyleBackColor = true;
            this.UploadLibraryButton.Click += new System.EventHandler(this.UploadLibraryButton_Click);
            // 
            // BookListBox
            // 
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 25;
            this.BookListBox.Location = new System.Drawing.Point(12, 12);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(776, 329);
            this.BookListBox.TabIndex = 4;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookListBox);
            this.Controls.Add(this.UploadLibraryButton);
            this.Controls.Add(this.OpenBookButton);
            this.Controls.Add(this.SyncLibraryButton);
            this.Name = "Library";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SyncLibraryButton;
        private System.Windows.Forms.Button OpenBookButton;
        private System.Windows.Forms.Button UploadLibraryButton;
        private System.Windows.Forms.ListBox BookListBox;
    }
}

