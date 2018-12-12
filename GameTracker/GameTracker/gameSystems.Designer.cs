namespace GameTracker
{
    partial class gameSystems
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showAllSysBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sysNameTxt = new System.Windows.Forms.TextBox();
            this.sysPubTxt = new System.Windows.Forms.TextBox();
            this.sysMenuTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(358, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(318, 386);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 197);
            this.dataGridView1.TabIndex = 1;
            // 
            // showAllSysBtn
            // 
            this.showAllSysBtn.Location = new System.Drawing.Point(555, 58);
            this.showAllSysBtn.Name = "showAllSysBtn";
            this.showAllSysBtn.Size = new System.Drawing.Size(121, 23);
            this.showAllSysBtn.TabIndex = 2;
            this.showAllSysBtn.Text = "Show All Systems";
            this.showAllSysBtn.UseVisualStyleBackColor = true;
            this.showAllSysBtn.Click += new System.EventHandler(this.showAllSysBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Game System";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sysNameTxt
            // 
            this.sysNameTxt.Location = new System.Drawing.Point(13, 87);
            this.sysNameTxt.Name = "sysNameTxt";
            this.sysNameTxt.Size = new System.Drawing.Size(100, 20);
            this.sysNameTxt.TabIndex = 4;
            // 
            // sysPubTxt
            // 
            this.sysPubTxt.Location = new System.Drawing.Point(13, 114);
            this.sysPubTxt.Name = "sysPubTxt";
            this.sysPubTxt.Size = new System.Drawing.Size(100, 20);
            this.sysPubTxt.TabIndex = 5;
            // 
            // sysMenuTxt
            // 
            this.sysMenuTxt.Location = new System.Drawing.Point(13, 141);
            this.sysMenuTxt.Name = "sysMenuTxt";
            this.sysMenuTxt.Size = new System.Drawing.Size(100, 20);
            this.sysMenuTxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "System Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "System Publish Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "System Manufacturer";
            // 
            // gameSystems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sysMenuTxt);
            this.Controls.Add(this.sysPubTxt);
            this.Controls.Add(this.sysNameTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showAllSysBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "gameSystems";
            this.Text = "gameSystems";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showAllSysBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sysNameTxt;
        private System.Windows.Forms.TextBox sysPubTxt;
        private System.Windows.Forms.TextBox sysMenuTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}