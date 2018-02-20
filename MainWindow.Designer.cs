namespace WindowsLogsViewer
{
    partial class WindowsLogsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsLogsViewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.serversList = new System.Windows.Forms.ToolStripButton();
            this.refreshRate = new System.Windows.Forms.ToolStripComboBox();
            this.eventLogTable = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogTable)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serversList,
            this.refreshRate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // serversList
            // 
            this.serversList.Image = global::WindowsLogsViewer.Properties.Resources.connection2;
            this.serversList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.serversList.Name = "serversList";
            this.serversList.Size = new System.Drawing.Size(64, 22);
            this.serversList.Text = "Servers";
            this.serversList.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // refreshRate
            // 
            this.refreshRate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshRate.Items.AddRange(new object[] {
            "Every 30 seconds",
            "Every 5 minutes",
            "Every 30 minutes",
            "Every 2 hours"});
            this.refreshRate.Name = "refreshRate";
            this.refreshRate.Size = new System.Drawing.Size(121, 25);
            this.refreshRate.Click += new System.EventHandler(this.refreshRate_Click);
            // 
            // eventLogTable
            // 
            this.eventLogTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.eventLogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventLogTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventLogTable.Location = new System.Drawing.Point(0, 25);
            this.eventLogTable.Name = "eventLogTable";
            this.eventLogTable.Size = new System.Drawing.Size(1021, 730);
            this.eventLogTable.TabIndex = 1;
            this.eventLogTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // WindowsLogsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 755);
            this.Controls.Add(this.eventLogTable);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowsLogsViewer";
            this.Text = "Windows logs viewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton serversList;
        private System.Windows.Forms.DataGridView eventLogTable;
        private System.Windows.Forms.ToolStripComboBox refreshRate;
    }
}

