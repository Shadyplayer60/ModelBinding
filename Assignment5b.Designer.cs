namespace ModelBinding
{
    partial class Assignment5b
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
            components = new System.ComponentModel.Container();
            personGridView = new DataGridView();
            btnSave = new Button();
            personBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)personGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // personGridView
            // 
            personGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personGridView.Location = new Point(12, 12);
            personGridView.Name = "personGridView";
            personGridView.RowHeadersWidth = 51;
            personGridView.Size = new Size(479, 266);
            personGridView.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(177, 84);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Assignment5b
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 396);
            Controls.Add(btnSave);
            Controls.Add(personGridView);
            Name = "Assignment5b";
            Text = "Assignment 5b";
            Load += Assignment5b_Load;
            ((System.ComponentModel.ISupportInitialize)personGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personGridView;
        private Button btnSave;
        private BindingSource BindingSource;
    }
}
