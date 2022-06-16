namespace PasswordsApp
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
            this.components = new System.ComponentModel.Container();
            this.PasswordChoosingHolder = new System.Windows.Forms.FlowLayoutPanel();
            this.MainBG = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BreakdownResultsGroup = new System.Windows.Forms.GroupBox();
            this.PasswordSummaryGroup = new System.Windows.Forms.GroupBox();
            this.TotalRatingTitle = new System.Windows.Forms.Label();
            this.CharactersBreakdownGroup = new System.Windows.Forms.GroupBox();
            this.RemovePointsSpecial = new System.Windows.Forms.Label();
            this.NumericRemovePoints = new System.Windows.Forms.Label();
            this.UpperRemovePoints = new System.Windows.Forms.Label();
            this.LowerRemovePoints = new System.Windows.Forms.Label();
            this.SpecialCharactersPoints = new System.Windows.Forms.Label();
            this.SpecialCharactersAmount = new System.Windows.Forms.Label();
            this.SpecialCharactersTitle = new System.Windows.Forms.Label();
            this.NumericalCharactersPoints = new System.Windows.Forms.Label();
            this.NumericalCharactersAmount = new System.Windows.Forms.Label();
            this.NumericalCharactersTitle = new System.Windows.Forms.Label();
            this.UppercaseCharactersPoints = new System.Windows.Forms.Label();
            this.UppercaseCharactersAmount = new System.Windows.Forms.Label();
            this.UppercaseCharactersTitle = new System.Windows.Forms.Label();
            this.LowercaseCharactersPoints = new System.Windows.Forms.Label();
            this.LowercaseCharactersAmount = new System.Windows.Forms.Label();
            this.LowercaseCharactersTitle = new System.Windows.Forms.Label();
            this.PasswordEntry = new System.Windows.Forms.GroupBox();
            this.CompletedCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordEntryBox = new System.Windows.Forms.TextBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalPointsText = new System.Windows.Forms.Label();
            this.MainBG.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BreakdownResultsGroup.SuspendLayout();
            this.PasswordSummaryGroup.SuspendLayout();
            this.CharactersBreakdownGroup.SuspendLayout();
            this.PasswordEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordChoosingHolder
            // 
            this.PasswordChoosingHolder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordChoosingHolder.AutoScroll = true;
            this.PasswordChoosingHolder.AutoSize = true;
            this.PasswordChoosingHolder.Location = new System.Drawing.Point(6, 19);
            this.PasswordChoosingHolder.MaximumSize = new System.Drawing.Size(156, 394);
            this.PasswordChoosingHolder.MinimumSize = new System.Drawing.Size(156, 394);
            this.PasswordChoosingHolder.Name = "PasswordChoosingHolder";
            this.PasswordChoosingHolder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PasswordChoosingHolder.Size = new System.Drawing.Size(156, 394);
            this.PasswordChoosingHolder.TabIndex = 2;
            // 
            // MainBG
            // 
            this.MainBG.BackColor = System.Drawing.Color.Gray;
            this.MainBG.Controls.Add(this.groupBox1);
            this.MainBG.Controls.Add(this.BreakdownResultsGroup);
            this.MainBG.Controls.Add(this.PasswordEntry);
            this.MainBG.Location = new System.Drawing.Point(12, 12);
            this.MainBG.Name = "MainBG";
            this.MainBG.Size = new System.Drawing.Size(776, 426);
            this.MainBG.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PasswordChoosingHolder);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BreakdownResultsGroup
            // 
            this.BreakdownResultsGroup.Controls.Add(this.PasswordSummaryGroup);
            this.BreakdownResultsGroup.Controls.Add(this.CharactersBreakdownGroup);
            this.BreakdownResultsGroup.Location = new System.Drawing.Point(177, 4);
            this.BreakdownResultsGroup.Name = "BreakdownResultsGroup";
            this.BreakdownResultsGroup.Size = new System.Drawing.Size(596, 346);
            this.BreakdownResultsGroup.TabIndex = 8;
            this.BreakdownResultsGroup.TabStop = false;
            this.BreakdownResultsGroup.Text = "Breakdown / Results";
            // 
            // PasswordSummaryGroup
            // 
            this.PasswordSummaryGroup.Controls.Add(this.TotalPointsText);
            this.PasswordSummaryGroup.Controls.Add(this.TotalRatingTitle);
            this.PasswordSummaryGroup.Location = new System.Drawing.Point(7, 230);
            this.PasswordSummaryGroup.Name = "PasswordSummaryGroup";
            this.PasswordSummaryGroup.Size = new System.Drawing.Size(583, 109);
            this.PasswordSummaryGroup.TabIndex = 1;
            this.PasswordSummaryGroup.TabStop = false;
            this.PasswordSummaryGroup.Text = "Password Summary";
            // 
            // TotalRatingTitle
            // 
            this.TotalRatingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalRatingTitle.Location = new System.Drawing.Point(6, 16);
            this.TotalRatingTitle.Name = "TotalRatingTitle";
            this.TotalRatingTitle.Size = new System.Drawing.Size(94, 23);
            this.TotalRatingTitle.TabIndex = 16;
            this.TotalRatingTitle.Text = "Total Points:";
            // 
            // CharactersBreakdownGroup
            // 
            this.CharactersBreakdownGroup.Controls.Add(this.RemovePointsSpecial);
            this.CharactersBreakdownGroup.Controls.Add(this.NumericRemovePoints);
            this.CharactersBreakdownGroup.Controls.Add(this.UpperRemovePoints);
            this.CharactersBreakdownGroup.Controls.Add(this.LowerRemovePoints);
            this.CharactersBreakdownGroup.Controls.Add(this.SpecialCharactersPoints);
            this.CharactersBreakdownGroup.Controls.Add(this.SpecialCharactersAmount);
            this.CharactersBreakdownGroup.Controls.Add(this.SpecialCharactersTitle);
            this.CharactersBreakdownGroup.Controls.Add(this.NumericalCharactersPoints);
            this.CharactersBreakdownGroup.Controls.Add(this.NumericalCharactersAmount);
            this.CharactersBreakdownGroup.Controls.Add(this.NumericalCharactersTitle);
            this.CharactersBreakdownGroup.Controls.Add(this.UppercaseCharactersPoints);
            this.CharactersBreakdownGroup.Controls.Add(this.UppercaseCharactersAmount);
            this.CharactersBreakdownGroup.Controls.Add(this.UppercaseCharactersTitle);
            this.CharactersBreakdownGroup.Controls.Add(this.LowercaseCharactersPoints);
            this.CharactersBreakdownGroup.Controls.Add(this.LowercaseCharactersAmount);
            this.CharactersBreakdownGroup.Controls.Add(this.LowercaseCharactersTitle);
            this.CharactersBreakdownGroup.Location = new System.Drawing.Point(7, 18);
            this.CharactersBreakdownGroup.Name = "CharactersBreakdownGroup";
            this.CharactersBreakdownGroup.Size = new System.Drawing.Size(583, 206);
            this.CharactersBreakdownGroup.TabIndex = 0;
            this.CharactersBreakdownGroup.TabStop = false;
            this.CharactersBreakdownGroup.Text = "Characters Breakdown";
            // 
            // RemovePointsSpecial
            // 
            this.RemovePointsSpecial.Location = new System.Drawing.Point(92, 177);
            this.RemovePointsSpecial.Name = "RemovePointsSpecial";
            this.RemovePointsSpecial.Size = new System.Drawing.Size(184, 23);
            this.RemovePointsSpecial.TabIndex = 15;
            this.RemovePointsSpecial.Text = "Points:";
            // 
            // NumericRemovePoints
            // 
            this.NumericRemovePoints.Location = new System.Drawing.Point(92, 131);
            this.NumericRemovePoints.Name = "NumericRemovePoints";
            this.NumericRemovePoints.Size = new System.Drawing.Size(184, 23);
            this.NumericRemovePoints.TabIndex = 14;
            this.NumericRemovePoints.Text = "Points:";
            // 
            // UpperRemovePoints
            // 
            this.UpperRemovePoints.Location = new System.Drawing.Point(92, 85);
            this.UpperRemovePoints.Name = "UpperRemovePoints";
            this.UpperRemovePoints.Size = new System.Drawing.Size(184, 23);
            this.UpperRemovePoints.TabIndex = 13;
            this.UpperRemovePoints.Text = "Points:";
            // 
            // LowerRemovePoints
            // 
            this.LowerRemovePoints.Location = new System.Drawing.Point(92, 39);
            this.LowerRemovePoints.Name = "LowerRemovePoints";
            this.LowerRemovePoints.Size = new System.Drawing.Size(184, 23);
            this.LowerRemovePoints.TabIndex = 12;
            this.LowerRemovePoints.Text = "Points:";
            // 
            // SpecialCharactersPoints
            // 
            this.SpecialCharactersPoints.Location = new System.Drawing.Point(6, 177);
            this.SpecialCharactersPoints.Name = "SpecialCharactersPoints";
            this.SpecialCharactersPoints.Size = new System.Drawing.Size(80, 23);
            this.SpecialCharactersPoints.TabIndex = 11;
            this.SpecialCharactersPoints.Text = "Points:";
            // 
            // SpecialCharactersAmount
            // 
            this.SpecialCharactersAmount.Location = new System.Drawing.Point(196, 154);
            this.SpecialCharactersAmount.Name = "SpecialCharactersAmount";
            this.SpecialCharactersAmount.Size = new System.Drawing.Size(80, 23);
            this.SpecialCharactersAmount.TabIndex = 10;
            this.SpecialCharactersAmount.Text = "Amount:";
            // 
            // SpecialCharactersTitle
            // 
            this.SpecialCharactersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpecialCharactersTitle.Location = new System.Drawing.Point(6, 154);
            this.SpecialCharactersTitle.Name = "SpecialCharactersTitle";
            this.SpecialCharactersTitle.Size = new System.Drawing.Size(184, 23);
            this.SpecialCharactersTitle.TabIndex = 9;
            this.SpecialCharactersTitle.Text = "Special Characters Breakdown:";
            // 
            // NumericalCharactersPoints
            // 
            this.NumericalCharactersPoints.Location = new System.Drawing.Point(6, 131);
            this.NumericalCharactersPoints.Name = "NumericalCharactersPoints";
            this.NumericalCharactersPoints.Size = new System.Drawing.Size(80, 23);
            this.NumericalCharactersPoints.TabIndex = 8;
            this.NumericalCharactersPoints.Text = "Points:";
            // 
            // NumericalCharactersAmount
            // 
            this.NumericalCharactersAmount.Location = new System.Drawing.Point(196, 108);
            this.NumericalCharactersAmount.Name = "NumericalCharactersAmount";
            this.NumericalCharactersAmount.Size = new System.Drawing.Size(80, 23);
            this.NumericalCharactersAmount.TabIndex = 7;
            this.NumericalCharactersAmount.Text = "Amount:";
            // 
            // NumericalCharactersTitle
            // 
            this.NumericalCharactersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NumericalCharactersTitle.Location = new System.Drawing.Point(6, 108);
            this.NumericalCharactersTitle.Name = "NumericalCharactersTitle";
            this.NumericalCharactersTitle.Size = new System.Drawing.Size(184, 23);
            this.NumericalCharactersTitle.TabIndex = 6;
            this.NumericalCharactersTitle.Text = "Numerical Characters Breakdown:";
            // 
            // UppercaseCharactersPoints
            // 
            this.UppercaseCharactersPoints.Location = new System.Drawing.Point(6, 85);
            this.UppercaseCharactersPoints.Name = "UppercaseCharactersPoints";
            this.UppercaseCharactersPoints.Size = new System.Drawing.Size(80, 23);
            this.UppercaseCharactersPoints.TabIndex = 5;
            this.UppercaseCharactersPoints.Text = "Points:";
            // 
            // UppercaseCharactersAmount
            // 
            this.UppercaseCharactersAmount.Location = new System.Drawing.Point(196, 62);
            this.UppercaseCharactersAmount.Name = "UppercaseCharactersAmount";
            this.UppercaseCharactersAmount.Size = new System.Drawing.Size(80, 23);
            this.UppercaseCharactersAmount.TabIndex = 4;
            this.UppercaseCharactersAmount.Text = "Amount:";
            // 
            // UppercaseCharactersTitle
            // 
            this.UppercaseCharactersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UppercaseCharactersTitle.Location = new System.Drawing.Point(6, 62);
            this.UppercaseCharactersTitle.Name = "UppercaseCharactersTitle";
            this.UppercaseCharactersTitle.Size = new System.Drawing.Size(184, 23);
            this.UppercaseCharactersTitle.TabIndex = 3;
            this.UppercaseCharactersTitle.Text = "Uppercase Characters Breakdown:";
            // 
            // LowercaseCharactersPoints
            // 
            this.LowercaseCharactersPoints.Location = new System.Drawing.Point(6, 39);
            this.LowercaseCharactersPoints.Name = "LowercaseCharactersPoints";
            this.LowercaseCharactersPoints.Size = new System.Drawing.Size(80, 23);
            this.LowercaseCharactersPoints.TabIndex = 2;
            this.LowercaseCharactersPoints.Text = "Points:";
            // 
            // LowercaseCharactersAmount
            // 
            this.LowercaseCharactersAmount.Location = new System.Drawing.Point(196, 16);
            this.LowercaseCharactersAmount.Name = "LowercaseCharactersAmount";
            this.LowercaseCharactersAmount.Size = new System.Drawing.Size(80, 23);
            this.LowercaseCharactersAmount.TabIndex = 1;
            this.LowercaseCharactersAmount.Text = "Amount:";
            // 
            // LowercaseCharactersTitle
            // 
            this.LowercaseCharactersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LowercaseCharactersTitle.Location = new System.Drawing.Point(6, 16);
            this.LowercaseCharactersTitle.Name = "LowercaseCharactersTitle";
            this.LowercaseCharactersTitle.Size = new System.Drawing.Size(184, 23);
            this.LowercaseCharactersTitle.TabIndex = 0;
            this.LowercaseCharactersTitle.Text = "Lowercase Characters Breakdown:";
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Controls.Add(this.CompletedCheckbox);
            this.PasswordEntry.Controls.Add(this.PasswordEntryBox);
            this.PasswordEntry.Location = new System.Drawing.Point(454, 356);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(319, 70);
            this.PasswordEntry.TabIndex = 7;
            this.PasswordEntry.TabStop = false;
            this.PasswordEntry.Text = "Please Enter your Passwords, Click the tick once you\'re done";
            // 
            // CompletedCheckbox
            // 
            this.CompletedCheckbox.AutoSize = true;
            this.CompletedCheckbox.Location = new System.Drawing.Point(6, 47);
            this.CompletedCheckbox.Name = "CompletedCheckbox";
            this.CompletedCheckbox.Size = new System.Drawing.Size(76, 17);
            this.CompletedCheckbox.TabIndex = 6;
            this.CompletedCheckbox.Text = "Completed";
            this.CompletedCheckbox.UseVisualStyleBackColor = true;
            this.CompletedCheckbox.CheckedChanged += new System.EventHandler(this.CompletedCheckbox_CheckedChanged);
            // 
            // PasswordEntryBox
            // 
            this.PasswordEntryBox.Location = new System.Drawing.Point(6, 21);
            this.PasswordEntryBox.MaxLength = 15;
            this.PasswordEntryBox.Name = "PasswordEntryBox";
            this.PasswordEntryBox.Size = new System.Drawing.Size(319, 20);
            this.PasswordEntryBox.TabIndex = 5;
            this.PasswordEntryBox.TabStop = false;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(PasswordsApp.Form1);
            // 
            // TotalPointsText
            // 
            this.TotalPointsText.Location = new System.Drawing.Point(106, 16);
            this.TotalPointsText.Name = "TotalPointsText";
            this.TotalPointsText.Size = new System.Drawing.Size(84, 23);
            this.TotalPointsText.TabIndex = 16;
            this.TotalPointsText.Text = "Points:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainBG);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainBG.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BreakdownResultsGroup.ResumeLayout(false);
            this.PasswordSummaryGroup.ResumeLayout(false);
            this.CharactersBreakdownGroup.ResumeLayout(false);
            this.PasswordEntry.ResumeLayout(false);
            this.PasswordEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PasswordChoosingHolder;
        private System.Windows.Forms.Panel MainBG;
        private System.Windows.Forms.TextBox PasswordEntryBox;
        private System.Windows.Forms.GroupBox PasswordEntry;
        private System.Windows.Forms.CheckBox CompletedCheckbox;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.GroupBox BreakdownResultsGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CharactersBreakdownGroup;
        private System.Windows.Forms.Label NumericalCharactersPoints;
        private System.Windows.Forms.Label NumericalCharactersAmount;
        private System.Windows.Forms.Label NumericalCharactersTitle;
        private System.Windows.Forms.Label UppercaseCharactersPoints;
        private System.Windows.Forms.Label UppercaseCharactersAmount;
        private System.Windows.Forms.Label UppercaseCharactersTitle;
        private System.Windows.Forms.Label LowercaseCharactersPoints;
        private System.Windows.Forms.Label LowercaseCharactersAmount;
        private System.Windows.Forms.Label LowercaseCharactersTitle;
        private System.Windows.Forms.Label SpecialCharactersPoints;
        private System.Windows.Forms.Label SpecialCharactersAmount;
        private System.Windows.Forms.Label SpecialCharactersTitle;
        private System.Windows.Forms.GroupBox PasswordSummaryGroup;
        private System.Windows.Forms.Label RemovePointsSpecial;
        private System.Windows.Forms.Label NumericRemovePoints;
        private System.Windows.Forms.Label UpperRemovePoints;
        private System.Windows.Forms.Label LowerRemovePoints;
        private System.Windows.Forms.Label TotalRatingTitle;
        private System.Windows.Forms.Label TotalPointsText;
    }
}

