namespace PowerSync
{
    partial class BldgLayout
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
            buildingpnl = new Panel();
            label1 = new Label();
            flooctrlrpnl = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            OFF = new Button();
            ON = new Button();
            Status = new Label();
            indicator = new Panel();
            label2 = new Label();
            buildingpnl.SuspendLayout();
            flooctrlrpnl.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buildingpnl
            // 
            buildingpnl.Controls.Add(label1);
            buildingpnl.Dock = DockStyle.Top;
            buildingpnl.Location = new Point(0, 0);
            buildingpnl.Name = "buildingpnl";
            buildingpnl.Size = new Size(994, 308);
            buildingpnl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 109);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Building Layout";
            // 
            // flooctrlrpnl
            // 
            flooctrlrpnl.Controls.Add(panel1);
            flooctrlrpnl.Location = new Point(0, 314);
            flooctrlrpnl.Name = "flooctrlrpnl";
            flooctrlrpnl.Size = new Size(317, 212);
            flooctrlrpnl.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(OFF);
            panel1.Controls.Add(ON);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(indicator);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(40, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 209);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 28);
            label3.TabIndex = 4;
            label3.Text = "1st Floor";
            // 
            // OFF
            // 
            OFF.BackColor = Color.DarkGray;
            OFF.FlatAppearance.BorderSize = 0;
            OFF.FlatStyle = FlatStyle.Flat;
            OFF.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            OFF.ForeColor = Color.White;
            OFF.Location = new Point(147, 132);
            OFF.Name = "OFF";
            OFF.Size = new Size(71, 29);
            OFF.TabIndex = 3;
            OFF.Text = "OFF";
            OFF.UseVisualStyleBackColor = false;
            OFF.Click += OFF_Click;
            // 
            // ON
            // 
            ON.BackColor = Color.DarkGray;
            ON.FlatAppearance.BorderSize = 0;
            ON.FlatStyle = FlatStyle.Flat;
            ON.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            ON.ForeColor = Color.White;
            ON.Location = new Point(36, 132);
            ON.Name = "ON";
            ON.Size = new Size(71, 29);
            ON.TabIndex = 3;
            ON.Text = "ON";
            ON.UseVisualStyleBackColor = false;
            ON.Click += ON_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.FlatStyle = FlatStyle.Flat;
            Status.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.FromArgb(37, 42, 64);
            Status.Location = new Point(97, 88);
            Status.Name = "Status";
            Status.Size = new Size(0, 28);
            Status.TabIndex = 2;
            // 
            // indicator
            // 
            indicator.BackColor = Color.FromArgb(37, 42, 64);
            indicator.Location = new Point(61, 86);
            indicator.Name = "indicator";
            indicator.Size = new Size(30, 30);
            indicator.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 49);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 0;
            label2.Text = "BREAKER STATUS:";
            // 
            // BldgLayout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(994, 538);
            Controls.Add(flooctrlrpnl);
            Controls.Add(buildingpnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BldgLayout";
            Text = "BldgLayout";
            buildingpnl.ResumeLayout(false);
            buildingpnl.PerformLayout();
            flooctrlrpnl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel buildingpnl;
        private Panel flooctrlrpnl;
        private Label label1;
        private Panel panel1;
        private Button ON;
        private Label Status;
        private Panel indicator;
        private Label label2;
        private Button OFF;
        private Label label3;
    }
}