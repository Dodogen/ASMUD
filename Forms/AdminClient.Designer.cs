namespace ASMUD.Forms
{
    partial class AdminClient
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
            this.dataGridView_Data = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Help = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_DateToday = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_Tools = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox_IsEditing = new System.Windows.Forms.CheckBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Data
            // 
            this.dataGridView_Data.AllowUserToOrderColumns = true;
            this.dataGridView_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_Data.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Data.Location = new System.Drawing.Point(259, 56);
            this.dataGridView_Data.Name = "dataGridView_Data";
            this.dataGridView_Data.RowHeadersWidth = 62;
            this.dataGridView_Data.RowTemplate.Height = 28;
            this.dataGridView_Data.Size = new System.Drawing.Size(942, 654);
            this.dataGridView_Data.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.button_Help);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 709);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button_Help
            // 
            this.button_Help.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.Font = new System.Drawing.Font("Monda", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Help.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button_Help.Location = new System.Drawing.Point(3, 3);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(251, 72);
            this.button_Help.TabIndex = 3;
            this.button_Help.Text = "Помощь";
            this.button_Help.UseVisualStyleBackColor = false;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBox_DateToday);
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 628);
            this.panel1.TabIndex = 5;
            // 
            // textBox_DateToday
            // 
            this.textBox_DateToday.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_DateToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DateToday.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_DateToday.Font = new System.Drawing.Font("Monda", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DateToday.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_DateToday.Location = new System.Drawing.Point(0, 593);
            this.textBox_DateToday.Multiline = true;
            this.textBox_DateToday.Name = "textBox_DateToday";
            this.textBox_DateToday.ReadOnly = true;
            this.textBox_DateToday.Size = new System.Drawing.Size(251, 35);
            this.textBox_DateToday.TabIndex = 0;
            this.textBox_DateToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel_Tools
            // 
            this.tableLayoutPanel_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel_Tools.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel_Tools.ColumnCount = 2;
            this.tableLayoutPanel_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39893F));
            this.tableLayoutPanel_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60106F));
            this.tableLayoutPanel_Tools.Controls.Add(this.checkBox_IsEditing, 1, 0);
            this.tableLayoutPanel_Tools.Controls.Add(this.textBox_Description, 0, 0);
            this.tableLayoutPanel_Tools.Location = new System.Drawing.Point(259, 1);
            this.tableLayoutPanel_Tools.Name = "tableLayoutPanel_Tools";
            this.tableLayoutPanel_Tools.RowCount = 1;
            this.tableLayoutPanel_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel_Tools.Size = new System.Drawing.Size(942, 56);
            this.tableLayoutPanel_Tools.TabIndex = 5;
            // 
            // checkBox_IsEditing
            // 
            this.checkBox_IsEditing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_IsEditing.AutoSize = true;
            this.checkBox_IsEditing.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox_IsEditing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_IsEditing.Font = new System.Drawing.Font("Monda", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_IsEditing.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBox_IsEditing.Location = new System.Drawing.Point(713, 3);
            this.checkBox_IsEditing.Name = "checkBox_IsEditing";
            this.checkBox_IsEditing.Size = new System.Drawing.Size(226, 50);
            this.checkBox_IsEditing.TabIndex = 0;
            this.checkBox_IsEditing.Text = "Редактировать";
            this.checkBox_IsEditing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_IsEditing.UseVisualStyleBackColor = false;
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Description.Font = new System.Drawing.Font("Monda", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(255)));
            this.textBox_Description.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_Description.Location = new System.Drawing.Point(3, 3);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(704, 50);
            this.textBox_Description.TabIndex = 1;
            this.textBox_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1201, 710);
            this.Controls.Add(this.dataGridView_Data);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel_Tools);
            this.Name = "AdminClient";
            this.Text = "AdminClient";
            this.Load += new System.EventHandler(this.AdminClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Data)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel_Tools.ResumeLayout(false);
            this.tableLayoutPanel_Tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Data;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_DateToday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Tools;
        private System.Windows.Forms.CheckBox checkBox_IsEditing;
        private System.Windows.Forms.TextBox textBox_Description;
    }
}