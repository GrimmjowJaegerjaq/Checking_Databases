namespace Checking_Databases
{
    partial class TestList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestList));
            this.LTitle = new System.Windows.Forms.Label();
            this.cbDMS = new System.Windows.Forms.ComboBox();
            this.selectList = new System.Windows.Forms.ListBox();
            this.btnChecking = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectChecking = new System.Windows.Forms.Button();
            this.LResult = new System.Windows.Forms.Label();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F);
            this.LTitle.ForeColor = System.Drawing.Color.White;
            this.LTitle.Location = new System.Drawing.Point(135, 23);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(311, 50);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Список тестов";
            this.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDMS
            // 
            this.cbDMS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbDMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDMS.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDMS.ForeColor = System.Drawing.Color.White;
            this.cbDMS.FormattingEnabled = true;
            this.cbDMS.ItemHeight = 21;
            this.cbDMS.Location = new System.Drawing.Point(79, 85);
            this.cbDMS.Name = "cbDMS";
            this.cbDMS.Size = new System.Drawing.Size(157, 29);
            this.cbDMS.TabIndex = 1;
            this.cbDMS.SelectedIndexChanged += new System.EventHandler(this.cbDMS_SelectedIndexChanged);
            // 
            // selectList
            // 
            this.selectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.selectList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectList.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectList.ForeColor = System.Drawing.Color.White;
            this.selectList.FormattingEnabled = true;
            this.selectList.ItemHeight = 21;
            this.selectList.Location = new System.Drawing.Point(79, 319);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(692, 170);
            this.selectList.TabIndex = 9;
            this.selectList.DoubleClick += new System.EventHandler(this.selectList_DoubleClick);
            this.selectList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectList_KeyDown);
            // 
            // btnChecking
            // 
            this.btnChecking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChecking.AutoSize = true;
            this.btnChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChecking.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChecking.ForeColor = System.Drawing.Color.White;
            this.btnChecking.Location = new System.Drawing.Point(617, 85);
            this.btnChecking.Name = "btnChecking";
            this.btnChecking.Size = new System.Drawing.Size(154, 33);
            this.btnChecking.TabIndex = 6;
            this.btnChecking.Text = "Проверить";
            this.btnChecking.UseVisualStyleBackColor = true;
            this.btnChecking.Click += new System.EventHandler(this.btnChecking_Click);
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 21;
            this.cbType.Location = new System.Drawing.Point(242, 85);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(143, 29);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtConStr
            // 
            this.txtConStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtConStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConStr.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConStr.ForeColor = System.Drawing.Color.White;
            this.txtConStr.Location = new System.Drawing.Point(79, 125);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(510, 29);
            this.txtConStr.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.AutoSize = true;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(617, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.AutoSize = true;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(268, 505);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 33);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.AutoSize = true;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(472, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelectChecking
            // 
            this.btnSelectChecking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectChecking.AutoSize = true;
            this.btnSelectChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectChecking.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectChecking.ForeColor = System.Drawing.Color.White;
            this.btnSelectChecking.Location = new System.Drawing.Point(617, 241);
            this.btnSelectChecking.Name = "btnSelectChecking";
            this.btnSelectChecking.Size = new System.Drawing.Size(154, 33);
            this.btnSelectChecking.TabIndex = 8;
            this.btnSelectChecking.Text = "Проверить запрос";
            this.btnSelectChecking.UseVisualStyleBackColor = true;
            this.btnSelectChecking.Click += new System.EventHandler(this.btnSelectChecking_Click);
            // 
            // LResult
            // 
            this.LResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LResult.AutoEllipsis = true;
            this.LResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LResult.ForeColor = System.Drawing.Color.SpringGreen;
            this.LResult.Location = new System.Drawing.Point(80, 277);
            this.LResult.Name = "LResult";
            this.LResult.Size = new System.Drawing.Size(509, 39);
            this.LResult.TabIndex = 13;
            // 
            // txtSelect
            // 
            this.txtSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSelect.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelect.ForeColor = System.Drawing.Color.White;
            this.txtSelect.Location = new System.Drawing.Point(80, 169);
            this.txtSelect.Multiline = true;
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(509, 105);
            this.txtSelect.TabIndex = 5;
            this.txtSelect.Enter += new System.EventHandler(this.txtSelect_Enter);
            this.txtSelect.Leave += new System.EventHandler(this.txtSelect_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBName.ForeColor = System.Drawing.Color.White;
            this.txtDBName.Location = new System.Drawing.Point(391, 85);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(198, 29);
            this.txtDBName.TabIndex = 3;
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // TestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.LResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSelectChecking);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtConStr);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnChecking);
            this.Controls.Add(this.selectList);
            this.Controls.Add(this.cbDMS);
            this.Controls.Add(this.LTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestList";
            this.SizeChanged += new System.EventHandler(this.TestList_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.TestList_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.ComboBox cbDMS;
        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.Button btnChecking;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtConStr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelectChecking;
        private System.Windows.Forms.Label LResult;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDBName;
    }
}