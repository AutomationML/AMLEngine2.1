namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btn_createCAEX = new System.Windows.Forms.Button();
            this.CAEXTreeView = new System.Windows.Forms.TreeView();
            this.btn_openCAEX = new System.Windows.Forms.Button();
            this.btn_SaveCAEX = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btn_ValidateCAEXFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myErrorListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_createCAEX
            // 
            this.btn_createCAEX.Location = new System.Drawing.Point(139, 12);
            this.btn_createCAEX.Name = "btn_createCAEX";
            this.btn_createCAEX.Size = new System.Drawing.Size(121, 36);
            this.btn_createCAEX.TabIndex = 0;
            this.btn_createCAEX.Text = "Create AutomationML";
            this.btn_createCAEX.UseVisualStyleBackColor = true;
            this.btn_createCAEX.Click += new System.EventHandler(this.Btn_CreateCAEX_Click);
            // 
            // CAEXTreeView
            // 
            this.CAEXTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CAEXTreeView.Location = new System.Drawing.Point(12, 53);
            this.CAEXTreeView.Name = "CAEXTreeView";
            this.CAEXTreeView.Size = new System.Drawing.Size(629, 215);
            this.CAEXTreeView.TabIndex = 1;
            // 
            // btn_openCAEX
            // 
            this.btn_openCAEX.Location = new System.Drawing.Point(12, 11);
            this.btn_openCAEX.Name = "btn_openCAEX";
            this.btn_openCAEX.Size = new System.Drawing.Size(121, 36);
            this.btn_openCAEX.TabIndex = 0;
            this.btn_openCAEX.Text = "Open AutomationML";
            this.btn_openCAEX.UseVisualStyleBackColor = true;
            this.btn_openCAEX.Click += new System.EventHandler(this.Btn_OpenCAEX_Click);
            // 
            // btn_SaveCAEX
            // 
            this.btn_SaveCAEX.Location = new System.Drawing.Point(266, 12);
            this.btn_SaveCAEX.Name = "btn_SaveCAEX";
            this.btn_SaveCAEX.Size = new System.Drawing.Size(121, 36);
            this.btn_SaveCAEX.TabIndex = 0;
            this.btn_SaveCAEX.Text = "Save AutomationML";
            this.btn_SaveCAEX.UseVisualStyleBackColor = true;
            this.btn_SaveCAEX.Click += new System.EventHandler(this.Btn_SaveCAEX_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.aml";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(15, 350);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(16, 13);
            this.lbl_FileName.TabIndex = 2;
            this.lbl_FileName.Text = "...";
            // 
            // btn_ValidateCAEXFile
            // 
            this.btn_ValidateCAEXFile.Location = new System.Drawing.Point(393, 12);
            this.btn_ValidateCAEXFile.Name = "btn_ValidateCAEXFile";
            this.btn_ValidateCAEXFile.Size = new System.Drawing.Size(121, 36);
            this.btn_ValidateCAEXFile.TabIndex = 0;
            this.btn_ValidateCAEXFile.Text = "Validate ";
            this.btn_ValidateCAEXFile.UseVisualStyleBackColor = true;
            this.btn_ValidateCAEXFile.Click += new System.EventHandler(this.Btn_ValidateCAEXFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Label ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_EtikettCAEXFile_Click);
            // 
            // myErrorListBox
            // 
            this.myErrorListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myErrorListBox.FormattingEnabled = true;
            this.myErrorListBox.Location = new System.Drawing.Point(12, 275);
            this.myErrorListBox.Name = "myErrorListBox";
            this.myErrorListBox.Size = new System.Drawing.Size(632, 69);
            this.myErrorListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 365);
            this.Controls.Add(this.myErrorListBox);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.CAEXTreeView);
            this.Controls.Add(this.btn_openCAEX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_ValidateCAEXFile);
            this.Controls.Add(this.btn_SaveCAEX);
            this.Controls.Add(this.btn_createCAEX);
            this.Name = "Form1";
            this.Text = "AutomationML Basic Tutorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createCAEX;
        private System.Windows.Forms.TreeView CAEXTreeView;
        private System.Windows.Forms.Button btn_openCAEX;
        private System.Windows.Forms.Button btn_SaveCAEX;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btn_ValidateCAEXFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox myErrorListBox;
    }
}

