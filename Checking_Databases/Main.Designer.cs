namespace Checking_Databases
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PMenu = new System.Windows.Forms.Panel();
            this.LClose = new System.Windows.Forms.Label();
            this.LSettings = new System.Windows.Forms.Label();
            this.LHistory = new System.Windows.Forms.Label();
            this.LMain = new System.Windows.Forms.Label();
            this.LMenu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LSubtitle = new System.Windows.Forms.Label();
            this.btnCheckStart = new System.Windows.Forms.Button();
            this.checkList = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSettings = new System.Windows.Forms.Panel();
            this.Style2 = new System.Windows.Forms.PictureBox();
            this.LFont = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.Style1 = new System.Windows.Forms.PictureBox();
            this.LStyle = new System.Windows.Forms.Label();
            this.cbTumbler = new System.Windows.Forms.CheckBox();
            this.cbLang = new System.Windows.Forms.ComboBox();
            this.LLanguage = new System.Windows.Forms.Label();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.LConSrt = new System.Windows.Forms.Label();
            this.PMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            this.PSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Style2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style1)).BeginInit();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PMenu.BackColor = System.Drawing.Color.DarkOrange;
            this.PMenu.Controls.Add(this.LClose);
            this.PMenu.Controls.Add(this.LSettings);
            this.PMenu.Controls.Add(this.LHistory);
            this.PMenu.Controls.Add(this.LMain);
            this.PMenu.Controls.Add(this.LMenu);
            this.PMenu.Controls.Add(this.button1);
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(60, 600);
            this.PMenu.TabIndex = 5;
            // 
            // LClose
            // 
            this.LClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LClose.AutoEllipsis = true;
            this.LClose.BackColor = System.Drawing.Color.DarkOrange;
            this.LClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LClose.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LClose.ForeColor = System.Drawing.Color.White;
            this.LClose.Location = new System.Drawing.Point(-190, 272);
            this.LClose.Name = "LClose";
            this.LClose.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LClose.Size = new System.Drawing.Size(250, 60);
            this.LClose.TabIndex = 10;
            this.LClose.Text = "Выход";
            this.LClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LClose.Click += new System.EventHandler(this.LClose_Click);
            this.LClose.MouseLeave += new System.EventHandler(this.LClose_MouseLeave);
            this.LClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LClose_MouseMove);
            // 
            // LSettings
            // 
            this.LSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LSettings.AutoEllipsis = true;
            this.LSettings.BackColor = System.Drawing.Color.DarkOrange;
            this.LSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LSettings.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LSettings.ForeColor = System.Drawing.Color.White;
            this.LSettings.Location = new System.Drawing.Point(-190, 212);
            this.LSettings.Name = "LSettings";
            this.LSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LSettings.Size = new System.Drawing.Size(250, 60);
            this.LSettings.TabIndex = 9;
            this.LSettings.Text = "Настройки";
            this.LSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LSettings.Click += new System.EventHandler(this.LSettings_Click);
            this.LSettings.MouseLeave += new System.EventHandler(this.LSettings_MouseLeave);
            this.LSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LSettings_MouseMove);
            // 
            // LHistory
            // 
            this.LHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LHistory.AutoEllipsis = true;
            this.LHistory.BackColor = System.Drawing.Color.DarkOrange;
            this.LHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LHistory.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LHistory.ForeColor = System.Drawing.Color.White;
            this.LHistory.Location = new System.Drawing.Point(-190, 152);
            this.LHistory.Name = "LHistory";
            this.LHistory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LHistory.Size = new System.Drawing.Size(250, 60);
            this.LHistory.TabIndex = 7;
            this.LHistory.Text = "История";
            this.LHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LHistory.Click += new System.EventHandler(this.LHistory_Click);
            this.LHistory.MouseLeave += new System.EventHandler(this.LHistory_MouseLeave);
            this.LHistory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LHistory_MouseMove);
            // 
            // LMain
            // 
            this.LMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LMain.AutoEllipsis = true;
            this.LMain.BackColor = System.Drawing.Color.DarkOrange;
            this.LMain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LMain.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMain.ForeColor = System.Drawing.Color.White;
            this.LMain.Location = new System.Drawing.Point(-190, 92);
            this.LMain.Name = "LMain";
            this.LMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LMain.Size = new System.Drawing.Size(250, 60);
            this.LMain.TabIndex = 6;
            this.LMain.Text = "Главная";
            this.LMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LMain.Click += new System.EventHandler(this.LMain_Click);
            this.LMain.MouseLeave += new System.EventHandler(this.LMain_MouseLeave);
            this.LMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LMain_MouseMove);
            // 
            // LMenu
            // 
            this.LMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LMenu.AutoSize = true;
            this.LMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LMenu.ForeColor = System.Drawing.Color.White;
            this.LMenu.Location = new System.Drawing.Point(-183, 15);
            this.LMenu.Name = "LMenu";
            this.LMenu.Size = new System.Drawing.Size(95, 37);
            this.LMenu.TabIndex = 6;
            this.LMenu.Text = "Меню";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Location = new System.Drawing.Point(10, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LSubtitle
            // 
            this.LSubtitle.AutoSize = true;
            this.LSubtitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubtitle.ForeColor = System.Drawing.Color.White;
            this.LSubtitle.Location = new System.Drawing.Point(66, 15);
            this.LSubtitle.Name = "LSubtitle";
            this.LSubtitle.Size = new System.Drawing.Size(116, 37);
            this.LSubtitle.TabIndex = 6;
            this.LSubtitle.Text = "Главная";
            // 
            // btnCheckStart
            // 
            this.btnCheckStart.AutoSize = true;
            this.btnCheckStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStart.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckStart.ForeColor = System.Drawing.Color.White;
            this.btnCheckStart.Location = new System.Drawing.Point(73, 104);
            this.btnCheckStart.Name = "btnCheckStart";
            this.btnCheckStart.Size = new System.Drawing.Size(229, 37);
            this.btnCheckStart.TabIndex = 7;
            this.btnCheckStart.Text = "Провести тестирование";
            this.btnCheckStart.UseVisualStyleBackColor = true;
            this.btnCheckStart.Visible = false;
            // 
            // checkList
            // 
            this.checkList.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.checkList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.checkList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.checkList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.checkList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.checkList.EnableHeadersVisualStyles = false;
            this.checkList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkList.Location = new System.Drawing.Point(73, 104);
            this.checkList.Name = "checkList";
            this.checkList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.checkList.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.checkList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.checkList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.checkList.Size = new System.Drawing.Size(815, 484);
            this.checkList.TabIndex = 14;
            this.checkList.Visible = false;
            // 
            // cid
            // 
            this.cid.HeaderText = "id";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество тестируемых";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Группа";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "База данных";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // PSettings
            // 
            this.PSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSettings.AutoScroll = true;
            this.PSettings.Controls.Add(this.Style2);
            this.PSettings.Controls.Add(this.LFont);
            this.PSettings.Controls.Add(this.cbFont);
            this.PSettings.Controls.Add(this.Style1);
            this.PSettings.Controls.Add(this.LStyle);
            this.PSettings.Controls.Add(this.cbTumbler);
            this.PSettings.Controls.Add(this.cbLang);
            this.PSettings.Controls.Add(this.LLanguage);
            this.PSettings.Controls.Add(this.txtConStr);
            this.PSettings.Controls.Add(this.LConSrt);
            this.PSettings.ForeColor = System.Drawing.Color.Transparent;
            this.PSettings.Location = new System.Drawing.Point(73, 104);
            this.PSettings.Name = "PSettings";
            this.PSettings.Size = new System.Drawing.Size(815, 484);
            this.PSettings.TabIndex = 15;
            this.PSettings.Visible = false;
            // 
            // Style2
            // 
            this.Style2.Image = global::Checking_Databases.Properties.Resources.Style2;
            this.Style2.Location = new System.Drawing.Point(233, 266);
            this.Style2.Name = "Style2";
            this.Style2.Size = new System.Drawing.Size(185, 98);
            this.Style2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Style2.TabIndex = 10;
            this.Style2.TabStop = false;
            this.Style2.Click += new System.EventHandler(this.Style2_Click);
            // 
            // LFont
            // 
            this.LFont.AutoSize = true;
            this.LFont.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LFont.Location = new System.Drawing.Point(3, 393);
            this.LFont.Name = "LFont";
            this.LFont.Size = new System.Drawing.Size(60, 21);
            this.LFont.TabIndex = 9;
            this.LFont.Text = "Шрифт";
            // 
            // cbFont
            // 
            this.cbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFont.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFont.ForeColor = System.Drawing.Color.White;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(7, 443);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(216, 29);
            this.cbFont.TabIndex = 8;
            // 
            // Style1
            // 
            this.Style1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Style1.Image = global::Checking_Databases.Properties.Resources.Style1;
            this.Style1.Location = new System.Drawing.Point(7, 266);
            this.Style1.Name = "Style1";
            this.Style1.Size = new System.Drawing.Size(185, 98);
            this.Style1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Style1.TabIndex = 6;
            this.Style1.TabStop = false;
            this.Style1.Click += new System.EventHandler(this.Style1_Click);
            // 
            // LStyle
            // 
            this.LStyle.AutoSize = true;
            this.LStyle.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStyle.Location = new System.Drawing.Point(3, 216);
            this.LStyle.Name = "LStyle";
            this.LStyle.Size = new System.Drawing.Size(104, 21);
            this.LStyle.TabIndex = 5;
            this.LStyle.Text = "Оформление";
            // 
            // cbTumbler
            // 
            this.cbTumbler.AutoSize = true;
            this.cbTumbler.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTumbler.Location = new System.Drawing.Point(7, 501);
            this.cbTumbler.Name = "cbTumbler";
            this.cbTumbler.Size = new System.Drawing.Size(481, 25);
            this.cbTumbler.TabIndex = 4;
            this.cbTumbler.Text = "Показывать ведомость в режиме предворительного просмотра";
            this.cbTumbler.UseVisualStyleBackColor = true;
            // 
            // cbLang
            // 
            this.cbLang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLang.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLang.ForeColor = System.Drawing.Color.White;
            this.cbLang.FormattingEnabled = true;
            this.cbLang.Location = new System.Drawing.Point(7, 158);
            this.cbLang.Name = "cbLang";
            this.cbLang.Size = new System.Drawing.Size(186, 29);
            this.cbLang.TabIndex = 3;
            // 
            // LLanguage
            // 
            this.LLanguage.AutoSize = true;
            this.LLanguage.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LLanguage.Location = new System.Drawing.Point(3, 108);
            this.LLanguage.Name = "LLanguage";
            this.LLanguage.Size = new System.Drawing.Size(44, 21);
            this.LLanguage.TabIndex = 2;
            this.LLanguage.Text = "Язык";
            // 
            // txtConStr
            // 
            this.txtConStr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtConStr.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConStr.ForeColor = System.Drawing.Color.White;
            this.txtConStr.Location = new System.Drawing.Point(7, 50);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(720, 29);
            this.txtConStr.TabIndex = 1;
            // 
            // LConSrt
            // 
            this.LConSrt.AutoSize = true;
            this.LConSrt.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LConSrt.Location = new System.Drawing.Point(3, 0);
            this.LConSrt.Name = "LConSrt";
            this.LConSrt.Size = new System.Drawing.Size(161, 21);
            this.LConSrt.TabIndex = 0;
            this.LConSrt.Text = "Строка подключения";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.PSettings);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.LSubtitle);
            this.Controls.Add(this.checkList);
            this.Controls.Add(this.btnCheckStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.PMenu.ResumeLayout(false);
            this.PMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            this.PSettings.ResumeLayout(false);
            this.PSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Style2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LSettings;
        private System.Windows.Forms.Label LHistory;
        private System.Windows.Forms.Label LMain;
        private System.Windows.Forms.Label LMenu;
        private System.Windows.Forms.Label LClose;
        private System.Windows.Forms.Label LSubtitle;
        private System.Windows.Forms.Button btnCheckStart;
        private System.Windows.Forms.DataGridView checkList;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel PSettings;
        private System.Windows.Forms.Label LConSrt;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.PictureBox Style1;
        private System.Windows.Forms.Label LStyle;
        private System.Windows.Forms.CheckBox cbTumbler;
        private System.Windows.Forms.ComboBox cbLang;
        private System.Windows.Forms.Label LLanguage;
        private System.Windows.Forms.TextBox txtConStr;
        private System.Windows.Forms.Label LFont;
        private System.Windows.Forms.PictureBox Style2;
    }
}