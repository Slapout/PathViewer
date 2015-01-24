namespace PathViewer
{
    partial class FormPathViewer
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
            this.lvPaths = new System.Windows.Forms.ListView();
            this.PathColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPaths
            // 
            this.lvPaths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PathColumn});
            this.lvPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPaths.FullRowSelect = true;
            this.lvPaths.Location = new System.Drawing.Point(0, 0);
            this.lvPaths.Name = "lvPaths";
            this.lvPaths.Size = new System.Drawing.Size(891, 423);
            this.lvPaths.TabIndex = 0;
            this.lvPaths.UseCompatibleStateImageBehavior = false;
            this.lvPaths.View = System.Windows.Forms.View.Details;
            // 
            // PathColumn
            // 
            this.PathColumn.Text = "Path";
            this.PathColumn.Width = 1000;
            // 
            // FormPathViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 423);
            this.Controls.Add(this.lvPaths);
            this.Name = "FormPathViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPaths;
        private System.Windows.Forms.ColumnHeader PathColumn;
    }
}

