namespace Checking_Databases
{
    partial class CheckingDB
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
            this.LTitle = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.btnStartAndStop = new System.Windows.Forms.Button();
            this.listData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LTitle.AutoSize = true;
            this.LTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LTitle.ForeColor = System.Drawing.Color.White;
            this.LTitle.Location = new System.Drawing.Point(69, 30);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(190, 37);
            this.LTitle.TabIndex = 2;
            this.LTitle.Text = "Тестирование";
            // 
            // LStatus
            // 
            this.LStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LStatus.ForeColor = System.Drawing.Color.White;
            this.LStatus.Location = new System.Drawing.Point(72, 91);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(368, 23);
            this.LStatus.TabIndex = 4;
            this.LStatus.Text = "PDB vs SDB1";
            this.LStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStartAndStop
            // 
            this.btnStartAndStop.AutoSize = true;
            this.btnStartAndStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAndStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartAndStop.ForeColor = System.Drawing.Color.White;
            this.btnStartAndStop.Location = new System.Drawing.Point(680, 86);
            this.btnStartAndStop.Name = "btnStartAndStop";
            this.btnStartAndStop.Size = new System.Drawing.Size(94, 33);
            this.btnStartAndStop.TabIndex = 5;
            this.btnStartAndStop.Text = "Запустить";
            this.btnStartAndStop.UseVisualStyleBackColor = true;
            this.btnStartAndStop.Click += new System.EventHandler(this.btnStartAndStop_Click);
            // 
            // listData
            // 
            this.listData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.listData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listData.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listData.ForeColor = System.Drawing.Color.White;
            this.listData.FormattingEnabled = true;
            this.listData.ItemHeight = 21;
            this.listData.Location = new System.Drawing.Point(76, 137);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(698, 401);
            this.listData.TabIndex = 6;
            // 
            // CheckingDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.btnStartAndStop);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckingDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckingDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Button btnStartAndStop;
        private System.Windows.Forms.ListBox listData;
    }
}