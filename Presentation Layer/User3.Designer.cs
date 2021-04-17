
namespace Digital_Photo_Diary.Presentation_Layer
{
    partial class User3
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
            this.backButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.textOpenButton = new System.Windows.Forms.Button();
            this.photoOpenButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.browseButtonAlbum = new System.Windows.Forms.Button();
            this.browseButtonPhoto = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 42);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(665, 399);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(111, 42);
            this.refreshButton.TabIndex = 25;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // textOpenButton
            // 
            this.textOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOpenButton.Location = new System.Drawing.Point(665, 265);
            this.textOpenButton.Name = "textOpenButton";
            this.textOpenButton.Size = new System.Drawing.Size(123, 33);
            this.textOpenButton.TabIndex = 24;
            this.textOpenButton.Text = "Open Text";
            this.textOpenButton.UseVisualStyleBackColor = true;
            this.textOpenButton.Click += new System.EventHandler(this.textOpenButton_Click);
            // 
            // photoOpenButton
            // 
            this.photoOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoOpenButton.Location = new System.Drawing.Point(665, 182);
            this.photoOpenButton.Name = "photoOpenButton";
            this.photoOpenButton.Size = new System.Drawing.Size(123, 33);
            this.photoOpenButton.TabIndex = 23;
            this.photoOpenButton.Text = "Open Photo";
            this.photoOpenButton.UseVisualStyleBackColor = true;
            this.photoOpenButton.Click += new System.EventHandler(this.photoOpenButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select from the Album";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(16, 182);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(624, 199);
            this.dgv1.TabIndex = 21;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(234, 116);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // browseButtonAlbum
            // 
            this.browseButtonAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButtonAlbum.Location = new System.Drawing.Point(665, 63);
            this.browseButtonAlbum.Name = "browseButtonAlbum";
            this.browseButtonAlbum.Size = new System.Drawing.Size(90, 33);
            this.browseButtonAlbum.TabIndex = 19;
            this.browseButtonAlbum.Text = "Browse";
            this.browseButtonAlbum.UseVisualStyleBackColor = true;
            this.browseButtonAlbum.Click += new System.EventHandler(this.browseButtonAlbum_Click);
            // 
            // browseButtonPhoto
            // 
            this.browseButtonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButtonPhoto.Location = new System.Drawing.Point(665, 9);
            this.browseButtonPhoto.Name = "browseButtonPhoto";
            this.browseButtonPhoto.Size = new System.Drawing.Size(90, 33);
            this.browseButtonPhoto.TabIndex = 18;
            this.browseButtonPhoto.Text = "Browse";
            this.browseButtonPhoto.UseVisualStyleBackColor = true;
            this.browseButtonPhoto.Click += new System.EventHandler(this.browseButtonPhoto_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 26);
            this.textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 26);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Browse Text for the Photo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Browse Photo for the Album";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(665, 348);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 33);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // User3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.textOpenButton);
            this.Controls.Add(this.photoOpenButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButtonAlbum);
            this.Controls.Add(this.browseButtonPhoto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Name = "User3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User3_FormClosing);
            this.Load += new System.EventHandler(this.User3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button textOpenButton;
        private System.Windows.Forms.Button photoOpenButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button browseButtonAlbum;
        private System.Windows.Forms.Button browseButtonPhoto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}