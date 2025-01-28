namespace PowerSync
{
    partial class frmControl
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
            panel1 = new Panel();
            add = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            bldgA = new Button();
            ttbdo = new Button();
            ctrlpnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 30, 54);
            panel1.Controls.Add(add);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 838);
            panel1.TabIndex = 0;
            // 
            // add
            // 
            add.FlatAppearance.BorderSize = 0;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(-3, 467);
            add.Name = "add";
            add.Size = new Size(181, 60);
            add.TabIndex = 1;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            add.Leave += add_Leave;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 76);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 0;
            label1.Text = "BUILDINGS:";
            // 
            // panel2
            // 
            panel2.Controls.Add(bldgA);
            panel2.Controls.Add(ttbdo);
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 379);
            panel2.TabIndex = 1;
            // 
            // bldgA
            // 
            bldgA.FlatAppearance.BorderSize = 0;
            bldgA.FlatStyle = FlatStyle.Flat;
            bldgA.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bldgA.ForeColor = Color.White;
            bldgA.Location = new Point(9, 84);
            bldgA.Name = "bldgA";
            bldgA.Size = new Size(166, 60);
            bldgA.TabIndex = 1;
            bldgA.Text = "2 Floors";
            bldgA.UseVisualStyleBackColor = true;
            bldgA.Click += bldgA_Click;
            // 
            // ttbdo
            // 
            ttbdo.FlatAppearance.BorderSize = 0;
            ttbdo.FlatStyle = FlatStyle.Flat;
            ttbdo.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ttbdo.ForeColor = Color.White;
            ttbdo.Location = new Point(9, 0);
            ttbdo.Name = "ttbdo";
            ttbdo.Size = new Size(166, 60);
            ttbdo.TabIndex = 0;
            ttbdo.Text = "TTBDO";
            ttbdo.UseVisualStyleBackColor = true;
            ttbdo.Click += button1_Click;
            ttbdo.Leave += ttbdo_Leave;
            // 
            // ctrlpnlFormLoader
            // 
            ctrlpnlFormLoader.Dock = DockStyle.Top;
            ctrlpnlFormLoader.Location = new Point(181, 0);
            ctrlpnlFormLoader.Name = "ctrlpnlFormLoader";
            ctrlpnlFormLoader.Size = new Size(1284, 835);
            ctrlpnlFormLoader.TabIndex = 1;
            // 
            // frmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1465, 838);
            Controls.Add(ctrlpnlFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmControl";
            Text = "frmControl";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ttbdo;
        private Label label1;
        private Button add;
        private Panel ctrlpnlFormLoader;
        private Panel panel3;
        private Button bldgA;
    }
}