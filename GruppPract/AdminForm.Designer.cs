
namespace GruppPract
{
    partial class AdminForm
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
            this.listBoxAdminRecipeName = new System.Windows.Forms.ListBox();
            this.buttonAdminSearch = new System.Windows.Forms.Button();
            this.labelAdminSearch = new System.Windows.Forms.Label();
            this.textBoxAdminSearch = new System.Windows.Forms.TextBox();
            this.buttonAdminDeleteRecipe = new System.Windows.Forms.Button();
            this.textBoxAdminRecipeType = new System.Windows.Forms.TextBox();
            this.textBoxAdminRecipieName = new System.Windows.Forms.TextBox();
            this.textBoxAdminRecipeDescription = new System.Windows.Forms.TextBox();
            this.labelAdminRecipeType = new System.Windows.Forms.Label();
            this.labelAdminRecipeName = new System.Windows.Forms.Label();
            this.labelAdminRecipieDescription = new System.Windows.Forms.Label();
            this.buttonAdminAddRecipe = new System.Windows.Forms.Button();
            this.buttonAdminUpdateRecipe = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAdminRecipeName
            // 
            this.listBoxAdminRecipeName.FormattingEnabled = true;
            this.listBoxAdminRecipeName.Location = new System.Drawing.Point(23, 82);
            this.listBoxAdminRecipeName.Name = "listBoxAdminRecipeName";
            this.listBoxAdminRecipeName.Size = new System.Drawing.Size(200, 160);
            this.listBoxAdminRecipeName.TabIndex = 16;
            // 
            // buttonAdminSearch
            // 
            this.buttonAdminSearch.Location = new System.Drawing.Point(23, 53);
            this.buttonAdminSearch.Name = "buttonAdminSearch";
            this.buttonAdminSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminSearch.TabIndex = 14;
            this.buttonAdminSearch.Text = "Search";
            this.buttonAdminSearch.UseVisualStyleBackColor = true;
            this.buttonAdminSearch.Click += new System.EventHandler(this.buttonAdminSearch_Click);
            // 
            // labelAdminSearch
            // 
            this.labelAdminSearch.AutoSize = true;
            this.labelAdminSearch.Location = new System.Drawing.Point(20, 11);
            this.labelAdminSearch.Name = "labelAdminSearch";
            this.labelAdminSearch.Size = new System.Drawing.Size(73, 13);
            this.labelAdminSearch.TabIndex = 9;
            this.labelAdminSearch.Text = "Search recipe";
            // 
            // textBoxAdminSearch
            // 
            this.textBoxAdminSearch.Location = new System.Drawing.Point(23, 27);
            this.textBoxAdminSearch.Name = "textBoxAdminSearch";
            this.textBoxAdminSearch.Size = new System.Drawing.Size(200, 20);
            this.textBoxAdminSearch.TabIndex = 8;
            // 
            // buttonAdminDeleteRecipe
            // 
            this.buttonAdminDeleteRecipe.Location = new System.Drawing.Point(23, 248);
            this.buttonAdminDeleteRecipe.Name = "buttonAdminDeleteRecipe";
            this.buttonAdminDeleteRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminDeleteRecipe.TabIndex = 18;
            this.buttonAdminDeleteRecipe.Text = "Delete";
            this.buttonAdminDeleteRecipe.UseVisualStyleBackColor = true;
            this.buttonAdminDeleteRecipe.Click += new System.EventHandler(this.buttonAdminDeleteRecipe_Click);
            // 
            // textBoxAdminRecipeType
            // 
            this.textBoxAdminRecipeType.Location = new System.Drawing.Point(265, 27);
            this.textBoxAdminRecipeType.Name = "textBoxAdminRecipeType";
            this.textBoxAdminRecipeType.Size = new System.Drawing.Size(105, 20);
            this.textBoxAdminRecipeType.TabIndex = 19;
            // 
            // textBoxAdminRecipieName
            // 
            this.textBoxAdminRecipieName.Location = new System.Drawing.Point(376, 27);
            this.textBoxAdminRecipieName.Name = "textBoxAdminRecipieName";
            this.textBoxAdminRecipieName.Size = new System.Drawing.Size(134, 20);
            this.textBoxAdminRecipieName.TabIndex = 19;
            // 
            // textBoxAdminRecipeDescription
            // 
            this.textBoxAdminRecipeDescription.Location = new System.Drawing.Point(265, 82);
            this.textBoxAdminRecipeDescription.Multiline = true;
            this.textBoxAdminRecipeDescription.Name = "textBoxAdminRecipeDescription";
            this.textBoxAdminRecipeDescription.Size = new System.Drawing.Size(245, 160);
            this.textBoxAdminRecipeDescription.TabIndex = 19;
            // 
            // labelAdminRecipeType
            // 
            this.labelAdminRecipeType.AutoSize = true;
            this.labelAdminRecipeType.Location = new System.Drawing.Point(262, 11);
            this.labelAdminRecipeType.Name = "labelAdminRecipeType";
            this.labelAdminRecipeType.Size = new System.Drawing.Size(31, 13);
            this.labelAdminRecipeType.TabIndex = 20;
            this.labelAdminRecipeType.Text = "Type";
            // 
            // labelAdminRecipeName
            // 
            this.labelAdminRecipeName.AutoSize = true;
            this.labelAdminRecipeName.Location = new System.Drawing.Point(373, 11);
            this.labelAdminRecipeName.Name = "labelAdminRecipeName";
            this.labelAdminRecipeName.Size = new System.Drawing.Size(35, 13);
            this.labelAdminRecipeName.TabIndex = 21;
            this.labelAdminRecipeName.Text = "Name";
            // 
            // labelAdminRecipieDescription
            // 
            this.labelAdminRecipieDescription.AutoSize = true;
            this.labelAdminRecipieDescription.Location = new System.Drawing.Point(262, 63);
            this.labelAdminRecipieDescription.Name = "labelAdminRecipieDescription";
            this.labelAdminRecipieDescription.Size = new System.Drawing.Size(60, 13);
            this.labelAdminRecipieDescription.TabIndex = 22;
            this.labelAdminRecipieDescription.Text = "Description";
            // 
            // buttonAdminAddRecipe
            // 
            this.buttonAdminAddRecipe.Location = new System.Drawing.Point(265, 248);
            this.buttonAdminAddRecipe.Name = "buttonAdminAddRecipe";
            this.buttonAdminAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminAddRecipe.TabIndex = 23;
            this.buttonAdminAddRecipe.Text = "Add";
            this.buttonAdminAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAdminAddRecipe.Click += new System.EventHandler(this.buttonAdminAddRecipe_Click);
            // 
            // buttonAdminUpdateRecipe
            // 
            this.buttonAdminUpdateRecipe.Location = new System.Drawing.Point(435, 248);
            this.buttonAdminUpdateRecipe.Name = "buttonAdminUpdateRecipe";
            this.buttonAdminUpdateRecipe.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminUpdateRecipe.TabIndex = 24;
            this.buttonAdminUpdateRecipe.Text = "Update";
            this.buttonAdminUpdateRecipe.UseVisualStyleBackColor = true;
            this.buttonAdminUpdateRecipe.Click += new System.EventHandler(this.buttonAdminUpdateRecipe_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(435, 290);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 25;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 325);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonAdminUpdateRecipe);
            this.Controls.Add(this.buttonAdminAddRecipe);
            this.Controls.Add(this.labelAdminRecipieDescription);
            this.Controls.Add(this.labelAdminRecipeName);
            this.Controls.Add(this.labelAdminRecipeType);
            this.Controls.Add(this.textBoxAdminRecipeDescription);
            this.Controls.Add(this.textBoxAdminRecipieName);
            this.Controls.Add(this.textBoxAdminRecipeType);
            this.Controls.Add(this.buttonAdminDeleteRecipe);
            this.Controls.Add(this.listBoxAdminRecipeName);
            this.Controls.Add(this.buttonAdminSearch);
            this.Controls.Add(this.labelAdminSearch);
            this.Controls.Add(this.textBoxAdminSearch);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAdminRecipeName;
        private System.Windows.Forms.Button buttonAdminSearch;
        private System.Windows.Forms.Label labelAdminSearch;
        private System.Windows.Forms.TextBox textBoxAdminSearch;
        private System.Windows.Forms.Button buttonAdminDeleteRecipe;
        private System.Windows.Forms.TextBox textBoxAdminRecipeType;
        private System.Windows.Forms.TextBox textBoxAdminRecipieName;
        private System.Windows.Forms.TextBox textBoxAdminRecipeDescription;
        private System.Windows.Forms.Label labelAdminRecipeType;
        private System.Windows.Forms.Label labelAdminRecipeName;
        private System.Windows.Forms.Label labelAdminRecipieDescription;
        private System.Windows.Forms.Button buttonAdminAddRecipe;
        private System.Windows.Forms.Button buttonAdminUpdateRecipe;
        private System.Windows.Forms.Button buttonLogOut;
    }
}