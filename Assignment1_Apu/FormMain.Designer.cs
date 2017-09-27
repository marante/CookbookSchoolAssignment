using System;
using System.Windows.Forms;

namespace Assignment1_Apu
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BtnRecipeAddIngredients = new System.Windows.Forms.Button();
            this.RecipeDropdownCategory = new System.Windows.Forms.ComboBox();
            this.RecipeTextbox = new System.Windows.Forms.TextBox();
            this.AddNewRecipe = new System.Windows.Forms.GroupBox();
            this.MealTypeDropdownList = new System.Windows.Forms.ComboBox();
            this.RecipeNameTextBox = new System.Windows.Forms.TextBox();
            this.lblCategoryOfRecipe = new System.Windows.Forms.Label();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.BtnAddRecipe = new System.Windows.Forms.Button();
            this.RecipeListbox = new System.Windows.Forms.ListBox();
            this.BtnEditRecipe = new System.Windows.Forms.Button();
            this.lblListboxDescrip = new System.Windows.Forms.Label();
            this.lblListBoxNoOfIngredients = new System.Windows.Forms.Label();
            this.lblListBoxCategory = new System.Windows.Forms.Label();
            this.lblListBoxNameOfRecipe = new System.Windows.Forms.Label();
            this.lblListboxDish = new System.Windows.Forms.Label();
            this.BtnDeleteRecipe = new System.Windows.Forms.Button();
            this.mnuFileStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewRecipe.SuspendLayout();
            this.mnuFileStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRecipeAddIngredients
            // 
            this.BtnRecipeAddIngredients.BackColor = System.Drawing.SystemColors.Control;
            this.BtnRecipeAddIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRecipeAddIngredients.Location = new System.Drawing.Point(358, 61);
            this.BtnRecipeAddIngredients.Name = "BtnRecipeAddIngredients";
            this.BtnRecipeAddIngredients.Size = new System.Drawing.Size(115, 24);
            this.BtnRecipeAddIngredients.TabIndex = 0;
            this.BtnRecipeAddIngredients.Text = "Add ingredients";
            this.BtnRecipeAddIngredients.UseVisualStyleBackColor = false;
            this.BtnRecipeAddIngredients.Click += new System.EventHandler(this.BtnRecipeAddIngredients_Click);
            // 
            // RecipeDropdownCategory
            // 
            this.RecipeDropdownCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RecipeDropdownCategory.FormattingEnabled = true;
            this.RecipeDropdownCategory.Location = new System.Drawing.Point(133, 61);
            this.RecipeDropdownCategory.Name = "RecipeDropdownCategory";
            this.RecipeDropdownCategory.Size = new System.Drawing.Size(105, 24);
            this.RecipeDropdownCategory.TabIndex = 1;
            // 
            // RecipeTextbox
            // 
            this.RecipeTextbox.Location = new System.Drawing.Point(21, 117);
            this.RecipeTextbox.Multiline = true;
            this.RecipeTextbox.Name = "RecipeTextbox";
            this.RecipeTextbox.Size = new System.Drawing.Size(452, 257);
            this.RecipeTextbox.TabIndex = 2;
            // 
            // AddNewRecipe
            // 
            this.AddNewRecipe.Controls.Add(this.MealTypeDropdownList);
            this.AddNewRecipe.Controls.Add(this.RecipeNameTextBox);
            this.AddNewRecipe.Controls.Add(this.lblCategoryOfRecipe);
            this.AddNewRecipe.Controls.Add(this.lblNameOfRecipe);
            this.AddNewRecipe.Controls.Add(this.RecipeTextbox);
            this.AddNewRecipe.Controls.Add(this.BtnRecipeAddIngredients);
            this.AddNewRecipe.Controls.Add(this.RecipeDropdownCategory);
            this.AddNewRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewRecipe.Location = new System.Drawing.Point(12, 44);
            this.AddNewRecipe.Name = "AddNewRecipe";
            this.AddNewRecipe.Size = new System.Drawing.Size(484, 419);
            this.AddNewRecipe.TabIndex = 3;
            this.AddNewRecipe.TabStop = false;
            this.AddNewRecipe.Text = "Add New Recipe";
            // 
            // MealTypeDropdownList
            // 
            this.MealTypeDropdownList.BackColor = System.Drawing.SystemColors.Control;
            this.MealTypeDropdownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MealTypeDropdownList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MealTypeDropdownList.FormattingEnabled = true;
            this.MealTypeDropdownList.Location = new System.Drawing.Point(244, 62);
            this.MealTypeDropdownList.Name = "MealTypeDropdownList";
            this.MealTypeDropdownList.Size = new System.Drawing.Size(105, 24);
            this.MealTypeDropdownList.TabIndex = 5;
            // 
            // RecipeNameTextBox
            // 
            this.RecipeNameTextBox.Location = new System.Drawing.Point(133, 27);
            this.RecipeNameTextBox.Name = "RecipeNameTextBox";
            this.RecipeNameTextBox.Size = new System.Drawing.Size(340, 22);
            this.RecipeNameTextBox.TabIndex = 4;
            // 
            // lblCategoryOfRecipe
            // 
            this.lblCategoryOfRecipe.AutoSize = true;
            this.lblCategoryOfRecipe.Location = new System.Drawing.Point(6, 61);
            this.lblCategoryOfRecipe.Name = "lblCategoryOfRecipe";
            this.lblCategoryOfRecipe.Size = new System.Drawing.Size(63, 16);
            this.lblCategoryOfRecipe.TabIndex = 4;
            this.lblCategoryOfRecipe.Text = "Category";
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(6, 27);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(100, 16);
            this.lblNameOfRecipe.TabIndex = 3;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // BtnAddRecipe
            // 
            this.BtnAddRecipe.Location = new System.Drawing.Point(25, 487);
            this.BtnAddRecipe.Name = "BtnAddRecipe";
            this.BtnAddRecipe.Size = new System.Drawing.Size(460, 23);
            this.BtnAddRecipe.TabIndex = 3;
            this.BtnAddRecipe.Text = "Add recipe";
            this.BtnAddRecipe.UseVisualStyleBackColor = true;
            this.BtnAddRecipe.Click += new System.EventHandler(this.BtnRecipeAdd_Click);
            // 
            // RecipeListbox
            // 
            this.RecipeListbox.DisplayMember = "DisplayString";
            this.RecipeListbox.FormattingEnabled = true;
            this.RecipeListbox.Location = new System.Drawing.Point(540, 122);
            this.RecipeListbox.Name = "RecipeListbox";
            this.RecipeListbox.Size = new System.Drawing.Size(452, 329);
            this.RecipeListbox.TabIndex = 4;
            // 
            // BtnEditRecipe
            // 
            this.BtnEditRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEditRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEditRecipe.Location = new System.Drawing.Point(623, 486);
            this.BtnEditRecipe.Name = "BtnEditRecipe";
            this.BtnEditRecipe.Size = new System.Drawing.Size(136, 24);
            this.BtnEditRecipe.TabIndex = 5;
            this.BtnEditRecipe.Text = "Edit";
            this.BtnEditRecipe.UseVisualStyleBackColor = false;
            this.BtnEditRecipe.Click += new System.EventHandler(this.BtnEditRecipe_Click);
            // 
            // lblListboxDescrip
            // 
            this.lblListboxDescrip.AutoSize = true;
            this.lblListboxDescrip.Location = new System.Drawing.Point(892, 80);
            this.lblListboxDescrip.Name = "lblListboxDescrip";
            this.lblListboxDescrip.Size = new System.Drawing.Size(60, 13);
            this.lblListboxDescrip.TabIndex = 6;
            this.lblListboxDescrip.Text = "Description";
            // 
            // lblListBoxNoOfIngredients
            // 
            this.lblListBoxNoOfIngredients.AutoSize = true;
            this.lblListBoxNoOfIngredients.Location = new System.Drawing.Point(720, 76);
            this.lblListBoxNoOfIngredients.MaximumSize = new System.Drawing.Size(60, 0);
            this.lblListBoxNoOfIngredients.Name = "lblListBoxNoOfIngredients";
            this.lblListBoxNoOfIngredients.Size = new System.Drawing.Size(39, 26);
            this.lblListBoxNoOfIngredients.TabIndex = 7;
            this.lblListBoxNoOfIngredients.Text = "No. of ingred.";
            // 
            // lblListBoxCategory
            // 
            this.lblListBoxCategory.AutoSize = true;
            this.lblListBoxCategory.Location = new System.Drawing.Point(775, 80);
            this.lblListBoxCategory.Name = "lblListBoxCategory";
            this.lblListBoxCategory.Size = new System.Drawing.Size(49, 13);
            this.lblListBoxCategory.TabIndex = 8;
            this.lblListBoxCategory.Text = "Category";
            // 
            // lblListBoxNameOfRecipe
            // 
            this.lblListBoxNameOfRecipe.AutoSize = true;
            this.lblListBoxNameOfRecipe.Location = new System.Drawing.Point(530, 80);
            this.lblListBoxNameOfRecipe.Name = "lblListBoxNameOfRecipe";
            this.lblListBoxNameOfRecipe.Size = new System.Drawing.Size(35, 13);
            this.lblListBoxNameOfRecipe.TabIndex = 9;
            this.lblListBoxNameOfRecipe.Text = "Name";
            // 
            // lblListboxDish
            // 
            this.lblListboxDish.AutoSize = true;
            this.lblListboxDish.Location = new System.Drawing.Point(839, 80);
            this.lblListboxDish.Name = "lblListboxDish";
            this.lblListboxDish.Size = new System.Drawing.Size(28, 13);
            this.lblListboxDish.TabIndex = 10;
            this.lblListboxDish.Text = "Dish";
            // 
            // BtnDeleteRecipe
            // 
            this.BtnDeleteRecipe.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDeleteRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeleteRecipe.Location = new System.Drawing.Point(778, 486);
            this.BtnDeleteRecipe.Name = "BtnDeleteRecipe";
            this.BtnDeleteRecipe.Size = new System.Drawing.Size(136, 24);
            this.BtnDeleteRecipe.TabIndex = 11;
            this.BtnDeleteRecipe.Text = "Delete";
            this.BtnDeleteRecipe.UseVisualStyleBackColor = false;
            this.BtnDeleteRecipe.Click += new System.EventHandler(this.BtnDeleteRecipe_Click);
            // 
            // mnuFileStrip
            // 
            this.mnuFileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuFileStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuFileStrip.Name = "mnuFileStrip";
            this.mnuFileStrip.Size = new System.Drawing.Size(1004, 24);
            this.mnuFileStrip.TabIndex = 12;
            this.mnuFileStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.toolStripSeparator,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.xMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
            this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNew.Text = "&New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
            this.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpen.Text = "&Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
            this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveAs.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromXMLFileToolStripMenuItem,
            this.exportToXMLFileToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // importFromXMLFileToolStripMenuItem
            // 
            this.importFromXMLFileToolStripMenuItem.Name = "importFromXMLFileToolStripMenuItem";
            this.importFromXMLFileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.importFromXMLFileToolStripMenuItem.Text = "Import from XML file";
            // 
            // exportToXMLFileToolStripMenuItem
            // 
            this.exportToXMLFileToolStripMenuItem.Name = "exportToXMLFileToolStripMenuItem";
            this.exportToXMLFileToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportToXMLFileToolStripMenuItem.Text = "Export to XML file";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 544);
            this.Controls.Add(this.BtnDeleteRecipe);
            this.Controls.Add(this.lblListboxDish);
            this.Controls.Add(this.lblListBoxNameOfRecipe);
            this.Controls.Add(this.lblListBoxCategory);
            this.Controls.Add(this.lblListBoxNoOfIngredients);
            this.Controls.Add(this.lblListboxDescrip);
            this.Controls.Add(this.BtnEditRecipe);
            this.Controls.Add(this.RecipeListbox);
            this.Controls.Add(this.BtnAddRecipe);
            this.Controls.Add(this.AddNewRecipe);
            this.Controls.Add(this.mnuFileStrip);
            this.MainMenuStrip = this.mnuFileStrip;
            this.Name = "FormMain";
            this.Text = "Apu\'s Cook Book";
            this.AddNewRecipe.ResumeLayout(false);
            this.AddNewRecipe.PerformLayout();
            this.mnuFileStrip.ResumeLayout(false);
            this.mnuFileStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRecipeAddIngredients;
        private System.Windows.Forms.ComboBox RecipeDropdownCategory;
        private System.Windows.Forms.TextBox RecipeTextbox;
        private System.Windows.Forms.GroupBox AddNewRecipe;
        private System.Windows.Forms.TextBox RecipeNameTextBox;
        private System.Windows.Forms.Label lblCategoryOfRecipe;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.Button BtnAddRecipe;
        private System.Windows.Forms.ListBox RecipeListbox;
        private System.Windows.Forms.Button BtnEditRecipe;
        private System.Windows.Forms.Label lblListboxDescrip;
        private System.Windows.Forms.Label lblListBoxNoOfIngredients;
        private System.Windows.Forms.Label lblListBoxCategory;
        private System.Windows.Forms.Label lblListBoxNameOfRecipe;
        private System.Windows.Forms.ComboBox MealTypeDropdownList;
        private Label lblListboxDish;
        private Button BtnDeleteRecipe;
        private MenuStrip mnuFileStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuFileExit;
        private ToolStripMenuItem xMLToolStripMenuItem;
        private ToolStripMenuItem importFromXMLFileToolStripMenuItem;
        private ToolStripMenuItem exportToXMLFileToolStripMenuItem;
    }
}

