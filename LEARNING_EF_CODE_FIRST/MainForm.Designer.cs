namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

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
			this.addSomeNewPeopleButton = new System.Windows.Forms.Button();
			this.displayPeopleButton = new System.Windows.Forms.Button();
			this.peopleListBox = new System.Windows.Forms.ListBox();
			this.peopleDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// addSomeNewPeopleButton
			// 
			this.addSomeNewPeopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addSomeNewPeopleButton.Location = new System.Drawing.Point(12, 12);
			this.addSomeNewPeopleButton.Name = "addSomeNewPeopleButton";
			this.addSomeNewPeopleButton.Size = new System.Drawing.Size(854, 23);
			this.addSomeNewPeopleButton.TabIndex = 0;
			this.addSomeNewPeopleButton.Text = "Add Some New People";
			this.addSomeNewPeopleButton.UseVisualStyleBackColor = true;
			this.addSomeNewPeopleButton.Click += new System.EventHandler(this.addSomeNewPeopleButton_Click);
			// 
			// displayPeopleButton
			// 
			this.displayPeopleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayPeopleButton.Location = new System.Drawing.Point(12, 41);
			this.displayPeopleButton.Name = "displayPeopleButton";
			this.displayPeopleButton.Size = new System.Drawing.Size(854, 23);
			this.displayPeopleButton.TabIndex = 1;
			this.displayPeopleButton.Text = "Display People";
			this.displayPeopleButton.UseVisualStyleBackColor = true;
			this.displayPeopleButton.Click += new System.EventHandler(this.displayPeopleButton_Click);
			// 
			// peopleListBox
			// 
			this.peopleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.peopleListBox.FormattingEnabled = true;
			this.peopleListBox.Location = new System.Drawing.Point(12, 70);
			this.peopleListBox.Name = "peopleListBox";
			this.peopleListBox.Size = new System.Drawing.Size(854, 108);
			this.peopleListBox.TabIndex = 2;
			// 
			// peopleDataGridView
			// 
			this.peopleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.peopleDataGridView.Location = new System.Drawing.Point(12, 184);
			this.peopleDataGridView.Name = "peopleDataGridView";
			this.peopleDataGridView.Size = new System.Drawing.Size(854, 285);
			this.peopleDataGridView.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 481);
			this.Controls.Add(this.peopleDataGridView);
			this.Controls.Add(this.peopleListBox);
			this.Controls.Add(this.displayPeopleButton);
			this.Controls.Add(this.addSomeNewPeopleButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addSomeNewPeopleButton;
		private System.Windows.Forms.Button displayPeopleButton;
		private System.Windows.Forms.ListBox peopleListBox;
		private System.Windows.Forms.DataGridView peopleDataGridView;
	}
}
