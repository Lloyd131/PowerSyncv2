namespace PowerSync
{
    partial class newbldg
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
            label1 = new Label();
            label2 = new Label();
            bldgname = new TextBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            panel1 = new Panel();
            done = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(304, 31);
            label1.TabIndex = 0;
            label1.Text = "Enter Building Details:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 0;
            label2.Text = "Building Name:\r\n";
            label2.Click += label2_Click;
            // 
            // bldgname
            // 
            bldgname.BorderStyle = BorderStyle.None;
            bldgname.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            bldgname.Location = new Point(206, 62);
            bldgname.Name = "bldgname";
            bldgname.Size = new Size(312, 27);
            bldgname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(90, 54);
            label3.TabIndex = 2;
            label3.Text = "Floors:\r\n\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Font = new Font("SansSerif", 13.8F, FontStyle.Bold);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(12, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(47, 31);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("SansSerif", 13.8F, FontStyle.Bold);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(76, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(47, 31);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("SansSerif", 13.8F, FontStyle.Bold);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(150, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(47, 31);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("SansSerif", 13.8F, FontStyle.Bold);
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(225, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(47, 31);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "4";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Location = new Point(117, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 60);
            panel1.TabIndex = 7;
            // 
            // done
            // 
            done.FlatAppearance.BorderSize = 0;
            done.FlatStyle = FlatStyle.Flat;
            done.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            done.ForeColor = Color.White;
            done.Location = new Point(427, 109);
            done.Name = "done";
            done.Size = new Size(131, 60);
            done.TabIndex = 8;
            done.Text = "DONE";
            done.UseVisualStyleBackColor = true;
            done.Click += button2_Click;
            // 
            // newbldg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 64);
            ClientSize = new Size(1465, 838);
            Controls.Add(done);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(bldgname);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "newbldg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newbldg";
            Load += newbldg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox bldgname;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Panel panel1;
        private Button done;
    }
}