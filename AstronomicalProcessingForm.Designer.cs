
namespace AstronomicalProcessing
{
    partial class AstronomicalProcessingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonFill = new System.Windows.Forms.Button();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonSequentialSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonMidExtreme = new System.Windows.Forms.Button();
            this.TextBoxMidExtreme = new System.Windows.Forms.TextBox();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.TextBoxMode = new System.Windows.Forms.TextBox();
            this.ButtonAverage = new System.Windows.Forms.Button();
            this.TextBoxAverage = new System.Windows.Forms.TextBox();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.TextBoxRange = new System.Windows.Forms.TextBox();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASTRONOMICAL PROCESSING";
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(24, 46);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInput.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TextBoxInput, "Enter a number");
            this.TextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(23, 72);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(101, 23);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "ADD ITEM";
            this.toolTip1.SetToolTip(this.ButtonAdd, "Add an item from the Text Box to the end of the list");
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(145, 72);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(97, 23);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "SORT";
            this.toolTip1.SetToolTip(this.ButtonSort, "Sort data in ascending order");
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(23, 102);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(101, 23);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "REMOVE ITEM";
            this.toolTip1.SetToolTip(this.ButtonRemove, "Select an item in the list to remove it");
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(145, 102);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(97, 23);
            this.ButtonSearch.TabIndex = 5;
            this.ButtonSearch.Text = "B SEARCH";
            this.toolTip1.SetToolTip(this.ButtonSearch, "Enter a number in the Text Box to search");
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(23, 132);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(101, 23);
            this.ButtonEdit.TabIndex = 6;
            this.ButtonEdit.Text = "EDIT ITEM";
            this.toolTip1.SetToolTip(this.ButtonEdit, "Select an item in the list to edit it");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonFill
            // 
            this.ButtonFill.Location = new System.Drawing.Point(145, 132);
            this.ButtonFill.Name = "ButtonFill";
            this.ButtonFill.Size = new System.Drawing.Size(97, 23);
            this.ButtonFill.TabIndex = 7;
            this.ButtonFill.Text = "FILL ARRAY";
            this.toolTip1.SetToolTip(this.ButtonFill, "Click to populate the list with randomly generated numbers");
            this.ButtonFill.UseVisualStyleBackColor = true;
            this.ButtonFill.Click += new System.EventHandler(this.ButtonFill_Click);
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(23, 200);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(100, 316);
            this.ListBoxOutput.TabIndex = 8;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 530);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(265, 22);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "-";
            // 
            // StripStatus
            // 
            this.StripStatus.Name = "StripStatus";
            this.StripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // ButtonSequentialSearch
            // 
            this.ButtonSequentialSearch.Location = new System.Drawing.Point(145, 161);
            this.ButtonSequentialSearch.Name = "ButtonSequentialSearch";
            this.ButtonSequentialSearch.Size = new System.Drawing.Size(97, 23);
            this.ButtonSequentialSearch.TabIndex = 10;
            this.ButtonSequentialSearch.Text = "S SEARCH";
            this.ButtonSequentialSearch.UseVisualStyleBackColor = true;
            this.ButtonSequentialSearch.Click += new System.EventHandler(this.ButtonSequentialSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calculations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Functions";
            // 
            // ButtonMidExtreme
            // 
            this.ButtonMidExtreme.Location = new System.Drawing.Point(145, 217);
            this.ButtonMidExtreme.Name = "ButtonMidExtreme";
            this.ButtonMidExtreme.Size = new System.Drawing.Size(97, 23);
            this.ButtonMidExtreme.TabIndex = 14;
            this.ButtonMidExtreme.Text = "MID-EXTREME";
            this.ButtonMidExtreme.UseVisualStyleBackColor = true;
            this.ButtonMidExtreme.Click += new System.EventHandler(this.ButtonMidExtreme_Click);
            // 
            // TextBoxMidExtreme
            // 
            this.TextBoxMidExtreme.Enabled = false;
            this.TextBoxMidExtreme.Location = new System.Drawing.Point(145, 247);
            this.TextBoxMidExtreme.Name = "TextBoxMidExtreme";
            this.TextBoxMidExtreme.ReadOnly = true;
            this.TextBoxMidExtreme.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMidExtreme.TabIndex = 15;
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(145, 275);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(97, 23);
            this.ButtonMode.TabIndex = 16;
            this.ButtonMode.Text = "MODE";
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // TextBoxMode
            // 
            this.TextBoxMode.Enabled = false;
            this.TextBoxMode.Location = new System.Drawing.Point(145, 304);
            this.TextBoxMode.Name = "TextBoxMode";
            this.TextBoxMode.ReadOnly = true;
            this.TextBoxMode.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMode.TabIndex = 17;
            // 
            // ButtonAverage
            // 
            this.ButtonAverage.Location = new System.Drawing.Point(145, 331);
            this.ButtonAverage.Name = "ButtonAverage";
            this.ButtonAverage.Size = new System.Drawing.Size(97, 23);
            this.ButtonAverage.TabIndex = 18;
            this.ButtonAverage.Text = "AVERAGE";
            this.ButtonAverage.UseVisualStyleBackColor = true;
            this.ButtonAverage.Click += new System.EventHandler(this.ButtonAverage_Click);
            // 
            // TextBoxAverage
            // 
            this.TextBoxAverage.Enabled = false;
            this.TextBoxAverage.Location = new System.Drawing.Point(145, 361);
            this.TextBoxAverage.Name = "TextBoxAverage";
            this.TextBoxAverage.ReadOnly = true;
            this.TextBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAverage.TabIndex = 19;
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(145, 388);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(97, 23);
            this.ButtonRange.TabIndex = 20;
            this.ButtonRange.Text = "RANGE";
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // TextBoxRange
            // 
            this.TextBoxRange.Enabled = false;
            this.TextBoxRange.Location = new System.Drawing.Point(145, 418);
            this.TextBoxRange.Name = "TextBoxRange";
            this.TextBoxRange.ReadOnly = true;
            this.TextBoxRange.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRange.TabIndex = 21;
            // 
            // AstronomicalProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 552);
            this.Controls.Add(this.TextBoxRange);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.TextBoxAverage);
            this.Controls.Add(this.ButtonAverage);
            this.Controls.Add(this.TextBoxMode);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.TextBoxMidExtreme);
            this.Controls.Add(this.ButtonMidExtreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSequentialSearch);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.ButtonFill);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "AstronomicalProcessingForm";
            this.Text = "Astronomical Processing";
            this.toolTip1.SetToolTip(this, "Click to populate array with randomly generated numbers");
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonFill;
        private System.Windows.Forms.ListBox ListBoxOutput;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatus;
        private System.Windows.Forms.Button ButtonSequentialSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonMidExtreme;
        private System.Windows.Forms.TextBox TextBoxMidExtreme;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.TextBox TextBoxMode;
        private System.Windows.Forms.Button ButtonAverage;
        private System.Windows.Forms.TextBox TextBoxAverage;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.TextBox TextBoxRange;
    }
}

