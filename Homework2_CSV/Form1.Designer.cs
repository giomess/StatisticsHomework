namespace CSVandUnivariat
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HasHeaderCheckBox = new System.Windows.Forms.CheckBox();
            this.SeparatorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnivariatGridView = new System.Windows.Forms.DataGridView();
            this.UnivariatLabel = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelativeFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnivariatGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(12, 35);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(827, 403);
            this.GridView.TabIndex = 0;
            this.GridView.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView_ColumnHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Enabled = false;
            this.FilePathTextBox.Location = new System.Drawing.Point(46, 6);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.ReadOnly = true;
            this.FilePathTextBox.Size = new System.Drawing.Size(336, 23);
            this.FilePathTextBox.TabIndex = 2;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(388, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // HasHeaderCheckBox
            // 
            this.HasHeaderCheckBox.AutoSize = true;
            this.HasHeaderCheckBox.Location = new System.Drawing.Point(576, 8);
            this.HasHeaderCheckBox.Name = "HasHeaderCheckBox";
            this.HasHeaderCheckBox.Size = new System.Drawing.Size(87, 19);
            this.HasHeaderCheckBox.TabIndex = 4;
            this.HasHeaderCheckBox.Text = "Has Header";
            this.HasHeaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // SeparatorTextBox
            // 
            this.SeparatorTextBox.Location = new System.Drawing.Point(535, 6);
            this.SeparatorTextBox.Name = "SeparatorTextBox";
            this.SeparatorTextBox.Size = new System.Drawing.Size(35, 23);
            this.SeparatorTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Separator:";
            // 
            // UnivariatGridView
            // 
            this.UnivariatGridView.AllowUserToAddRows = false;
            this.UnivariatGridView.AllowUserToDeleteRows = false;
            this.UnivariatGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnivariatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnivariatGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.RelativeFrequency});
            this.UnivariatGridView.Location = new System.Drawing.Point(845, 53);
            this.UnivariatGridView.Name = "UnivariatGridView";
            this.UnivariatGridView.ReadOnly = true;
            this.UnivariatGridView.RowHeadersVisible = false;
            this.UnivariatGridView.RowTemplate.Height = 25;
            this.UnivariatGridView.Size = new System.Drawing.Size(286, 385);
            this.UnivariatGridView.TabIndex = 7;
            // 
            // UnivariatLabel
            // 
            this.UnivariatLabel.AutoSize = true;
            this.UnivariatLabel.Location = new System.Drawing.Point(845, 35);
            this.UnivariatLabel.Name = "UnivariatLabel";
            this.UnivariatLabel.Size = new System.Drawing.Size(36, 15);
            this.UnivariatLabel.TabIndex = 8;
            this.UnivariatLabel.Text = "None";
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // RelativeFrequency
            // 
            this.RelativeFrequency.HeaderText = "Relative Frequency (Percentage)";
            this.RelativeFrequency.Name = "RelativeFrequency";
            this.RelativeFrequency.ReadOnly = true;
            this.RelativeFrequency.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.UnivariatLabel);
            this.Controls.Add(this.UnivariatGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SeparatorTextBox);
            this.Controls.Add(this.HasHeaderCheckBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnivariatGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridView;
        private Label label1;
        private TextBox FilePathTextBox;
        private Button LoadButton;
        private OpenFileDialog OpenFileDialog;
        private CheckBox HasHeaderCheckBox;
        private TextBox SeparatorTextBox;
        private Label label2;
        private DataGridView UnivariatGridView;
        private Label UnivariatLabel;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn RelativeFrequency;
    }
}