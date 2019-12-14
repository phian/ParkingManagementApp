namespace ParkingManagement_GUI
{
    partial class UC_Note
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Note_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Note_Panel
            // 
            this.Note_Panel.Location = new System.Drawing.Point(0, 3);
            this.Note_Panel.Name = "Note_Panel";
            this.Note_Panel.Size = new System.Drawing.Size(1589, 829);
            this.Note_Panel.TabIndex = 0;
            // 
            // UC_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Note_Panel);
            this.Name = "UC_Note";
            this.Size = new System.Drawing.Size(1583, 829);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Note_Panel;
    }
}
