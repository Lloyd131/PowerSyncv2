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
            button2 = new Button();
            ttbdo = new Button();
            panel2 = new Panel();
            label2 = new Label();
            bldglayoutFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 42, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(ttbdo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 550);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 113);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ttbdo
            // 
            ttbdo.BackColor = Color.FromArgb(37, 42, 64);
            ttbdo.Dock = DockStyle.Top;
            ttbdo.FlatAppearance.BorderSize = 0;
            ttbdo.FlatStyle = FlatStyle.Flat;
            ttbdo.Font = new Font("SansSerif", 12F, FontStyle.Bold, GraphicsUnit.Point, 2);
            ttbdo.ForeColor = Color.White;
            ttbdo.Location = new Point(0, 84);
            ttbdo.Name = "ttbdo";
            ttbdo.Size = new Size(134, 29);
            ttbdo.TabIndex = 0;
            ttbdo.TabStop = false;
            ttbdo.Text = "TTBDO\r\n";
            ttbdo.UseVisualStyleBackColor = false;
            ttbdo.Click += button1_Click;
            ttbdo.Leave += ttbdo_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 84);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 12);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 1;
            label2.Text = "Buildings:\r\n";
            // 
            // bldglayoutFormLoader
            // 
            bldglayoutFormLoader.Location = new Point(160, 0);
            bldglayoutFormLoader.Name = "bldglayoutFormLoader";
            bldglayoutFormLoader.Size = new Size(994, 538);
            bldglayoutFormLoader.TabIndex = 3;
            // 
            // frmControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1184, 550);
            Controls.Add(bldglayoutFormLoader);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmControl";
            Text = "frmControl";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button ttbdo;
        private Label label2;
        private Panel panel2;
        private Panel bldglayoutFormLoader;
        private Button button2;
    }
}