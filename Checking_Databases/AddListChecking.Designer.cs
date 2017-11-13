namespace Checking_Databases
{
    partial class AddListChecking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkList = new System.Windows.Forms.DataGridView();
            this.Namer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Database = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SMDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConStrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStudName = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTestCon = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            this.SuspendLayout();
            // 
            // checkList
            // 
            this.checkList.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.checkList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.checkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namer,
            this.Group,
            this.Database,
            this.SMDB,
            this.Type,
            this.ConStrCol});
            this.checkList.EnableHeadersVisualStyles = false;
            this.checkList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkList.Location = new System.Drawing.Point(67, 309);
            this.checkList.Name = "checkList";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.checkList.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.checkList.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.checkList.Size = new System.Drawing.Size(716, 190);
            this.checkList.TabIndex = 12;
            this.checkList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkList_CellContentClick);
            // 
            // Namer
            // 
            this.Namer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Namer.DefaultCellStyle = dataGridViewCellStyle13;
            this.Namer.HeaderText = "Имя";
            this.Namer.MinimumWidth = 10;
            this.Namer.Name = "Namer";
            this.Namer.Width = 140;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Group.HeaderText = "Группа";
            this.Group.MinimumWidth = 10;
            this.Group.Name = "Group";
            this.Group.Width = 90;
            // 
            // Database
            // 
            this.Database.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Database.HeaderText = "База данных";
            this.Database.Name = "Database";
            this.Database.Width = 120;
            // 
            // SMDB
            // 
            this.SMDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SMDB.HeaderText = "СУБД";
            this.SMDB.Name = "SMDB";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            // 
            // ConStrCol
            // 
            this.ConStrCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ConStrCol.HeaderText = "Строка соеденения";
            this.ConStrCol.Name = "ConStrCol";
            this.ConStrCol.Width = 160;
            // 
            // txtStudName
            // 
            this.txtStudName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtStudName.ForeColor = System.Drawing.Color.White;
            this.txtStudName.Location = new System.Drawing.Point(74, 113);
            this.txtStudName.Name = "txtStudName";
            this.txtStudName.Size = new System.Drawing.Size(424, 29);
            this.txtStudName.TabIndex = 1;
            this.txtStudName.Text = "Name";
            // 
            // txtDBName
            // 
            this.txtDBName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDBName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtDBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDBName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDBName.ForeColor = System.Drawing.Color.White;
            this.txtDBName.Location = new System.Drawing.Point(316, 162);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(182, 29);
            this.txtDBName.TabIndex = 5;
            this.txtDBName.Text = "Databases";
            this.txtDBName.TextChanged += new System.EventHandler(this.txtDBName_TextChanged);
            // 
            // cbView
            // 
            this.cbView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbView.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbView.ForeColor = System.Drawing.Color.White;
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(74, 213);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(182, 29);
            this.cbView.TabIndex = 4;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbView_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(316, 213);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(182, 29);
            this.cbType.TabIndex = 3;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGroup.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGroup.ForeColor = System.Drawing.Color.White;
            this.txtGroup.Location = new System.Drawing.Point(74, 162);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(182, 29);
            this.txtGroup.TabIndex = 2;
            this.txtGroup.Text = "Group";
            // 
            // txtConStr
            // 
            this.txtConStr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtConStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtConStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConStr.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConStr.ForeColor = System.Drawing.Color.White;
            this.txtConStr.Location = new System.Drawing.Point(74, 258);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(424, 29);
            this.txtConStr.TabIndex = 6;
            this.txtConStr.Text = "Connection string";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(567, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 33);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTestCon
            // 
            this.btnTestCon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTestCon.AutoSize = true;
            this.btnTestCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnTestCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestCon.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestCon.ForeColor = System.Drawing.Color.White;
            this.btnTestCon.Location = new System.Drawing.Point(567, 209);
            this.btnTestCon.Name = "btnTestCon";
            this.btnTestCon.Size = new System.Drawing.Size(201, 33);
            this.btnTestCon.TabIndex = 9;
            this.btnTestCon.Text = "Test connection";
            this.btnTestCon.UseVisualStyleBackColor = false;
            this.btnTestCon.Click += new System.EventHandler(this.btnTestCon_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(567, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(268, 505);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 33);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(60, 36);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(135, 37);
            this.lTitle.TabIndex = 11;
            this.lTitle.Text = "Create list";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(453, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 33);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddListChecking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTestCon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtConStr);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbView);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtStudName);
            this.Controls.Add(this.checkList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddListChecking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddListChecking";
            this.SizeChanged += new System.EventHandler(this.AddListChecking_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.AddListChecking_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView checkList;
        private System.Windows.Forms.TextBox txtStudName;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtConStr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTestCon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Database;
        private System.Windows.Forms.DataGridViewTextBoxColumn SMDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConStrCol;
    }
}