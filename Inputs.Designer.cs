namespace TwitterProject
{
    partial class Inputs
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
            this.setInputs = new System.Windows.Forms.Button();
            this.cancelInput = new System.Windows.Forms.Button();
            this.clearInputs = new System.Windows.Forms.Button();
            this.inputListView = new System.Windows.Forms.ListView();
            this.inputHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // setInputs
            // 
            this.setInputs.Location = new System.Drawing.Point(12, 396);
            this.setInputs.Name = "setInputs";
            this.setInputs.Size = new System.Drawing.Size(75, 23);
            this.setInputs.TabIndex = 0;
            this.setInputs.Text = "Ok";
            this.setInputs.UseVisualStyleBackColor = true;
            // 
            // cancelInput
            // 
            this.cancelInput.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelInput.Location = new System.Drawing.Point(187, 396);
            this.cancelInput.Name = "cancelInput";
            this.cancelInput.Size = new System.Drawing.Size(75, 23);
            this.cancelInput.TabIndex = 1;
            this.cancelInput.Text = "Cancel";
            this.cancelInput.UseVisualStyleBackColor = true;
            // 
            // clearInputs
            // 
            this.clearInputs.Location = new System.Drawing.Point(102, 396);
            this.clearInputs.Name = "clearInputs";
            this.clearInputs.Size = new System.Drawing.Size(75, 23);
            this.clearInputs.TabIndex = 2;
            this.clearInputs.Text = "Clear";
            this.clearInputs.UseVisualStyleBackColor = true;
            this.clearInputs.Click += new System.EventHandler(this.clearInputs_Click);
            // 
            // inputListView
            // 
            this.inputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.inputHeader});
            this.inputListView.Location = new System.Drawing.Point(23, 13);
            this.inputListView.Name = "inputListView";
            this.inputListView.Size = new System.Drawing.Size(227, 377);
            this.inputListView.TabIndex = 3;
            this.inputListView.UseCompatibleStateImageBehavior = false;
            this.inputListView.View = System.Windows.Forms.View.Details;
            this.inputListView.SelectedIndexChanged += new System.EventHandler(this.inputListView_SelectedIndexChanged);
            // 
            // inputHeader
            // 
            this.inputHeader.Text = "Inputs";
            this.inputHeader.Width = 223;
            // 
            // Inputs
            // 
            this.AcceptButton = this.setInputs;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelInput;
            this.ClientSize = new System.Drawing.Size(284, 440);
            this.Controls.Add(this.inputListView);
            this.Controls.Add(this.clearInputs);
            this.Controls.Add(this.cancelInput);
            this.Controls.Add(this.setInputs);
            this.Name = "Inputs";
            this.Text = "Inputs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setInputs;
        private System.Windows.Forms.Button cancelInput;
        private System.Windows.Forms.Button clearInputs;
        private System.Windows.Forms.ListView inputListView;
        private System.Windows.Forms.ColumnHeader inputHeader;
    }
}