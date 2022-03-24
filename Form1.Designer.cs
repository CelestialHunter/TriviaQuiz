
namespace Lab5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exitBT = new System.Windows.Forms.Button();
            this.testLB = new System.Windows.Forms.Label();
            this.cnpLB = new System.Windows.Forms.Label();
            this.cnpTB = new System.Windows.Forms.TextBox();
            this.testCB = new System.Windows.Forms.ComboBox();
            this.numeLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.titleLB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeTB
            // 
            this.numeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeTB.BackColor = System.Drawing.Color.DarkGray;
            this.numeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeTB.ForeColor = System.Drawing.Color.White;
            this.numeTB.Location = new System.Drawing.Point(326, 76);
            this.numeTB.Margin = new System.Windows.Forms.Padding(16);
            this.numeTB.Name = "numeTB";
            this.numeTB.Size = new System.Drawing.Size(278, 23);
            this.numeTB.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.exitBT, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.testLB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cnpLB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numeTB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cnpTB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.testCB, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.numeLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startBT, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.titleLB, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // exitBT
            // 
            this.exitBT.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.exitBT, 2);
            this.exitBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.exitBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBT.Location = new System.Drawing.Point(171, 366);
            this.exitBT.Margin = new System.Windows.Forms.Padding(16);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(433, 44);
            this.exitBT.TabIndex = 7;
            this.exitBT.Text = "Părăsire Aplicație";
            this.exitBT.UseVisualStyleBackColor = false;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // testLB
            // 
            this.testLB.AutoSize = true;
            this.testLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testLB.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.testLB.ForeColor = System.Drawing.Color.White;
            this.testLB.Location = new System.Drawing.Point(171, 216);
            this.testLB.Margin = new System.Windows.Forms.Padding(16);
            this.testLB.Name = "testLB";
            this.testLB.Size = new System.Drawing.Size(123, 43);
            this.testLB.TabIndex = 5;
            this.testLB.Text = "Test";
            this.testLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.testLB.Visible = false;
            // 
            // cnpLB
            // 
            this.cnpLB.AutoSize = true;
            this.cnpLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnpLB.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnpLB.ForeColor = System.Drawing.Color.White;
            this.cnpLB.Location = new System.Drawing.Point(171, 141);
            this.cnpLB.Margin = new System.Windows.Forms.Padding(16);
            this.cnpLB.Name = "cnpLB";
            this.cnpLB.Size = new System.Drawing.Size(123, 43);
            this.cnpLB.TabIndex = 4;
            this.cnpLB.Text = "CNP";
            this.cnpLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cnpTB
            // 
            this.cnpTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cnpTB.BackColor = System.Drawing.Color.DarkGray;
            this.cnpTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnpTB.ForeColor = System.Drawing.Color.White;
            this.cnpTB.Location = new System.Drawing.Point(326, 151);
            this.cnpTB.Margin = new System.Windows.Forms.Padding(16);
            this.cnpTB.Name = "cnpTB";
            this.cnpTB.Size = new System.Drawing.Size(278, 23);
            this.cnpTB.TabIndex = 1;
            // 
            // testCB
            // 
            this.testCB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testCB.BackColor = System.Drawing.Color.DarkGray;
            this.testCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testCB.ForeColor = System.Drawing.Color.White;
            this.testCB.FormattingEnabled = true;
            this.testCB.Location = new System.Drawing.Point(326, 216);
            this.testCB.Margin = new System.Windows.Forms.Padding(16);
            this.testCB.Name = "testCB";
            this.testCB.Size = new System.Drawing.Size(278, 23);
            this.testCB.TabIndex = 2;
            this.testCB.Visible = false;
            // 
            // numeLB
            // 
            this.numeLB.AutoSize = true;
            this.numeLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeLB.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeLB.ForeColor = System.Drawing.Color.White;
            this.numeLB.Location = new System.Drawing.Point(171, 66);
            this.numeLB.Margin = new System.Windows.Forms.Padding(16);
            this.numeLB.Name = "numeLB";
            this.numeLB.Size = new System.Drawing.Size(123, 43);
            this.numeLB.TabIndex = 3;
            this.numeLB.Text = "Nume";
            this.numeLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.Gray;
            this.tableLayoutPanel1.SetColumnSpan(this.startBT, 2);
            this.startBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.startBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBT.Location = new System.Drawing.Point(171, 291);
            this.startBT.Margin = new System.Windows.Forms.Padding(16);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(433, 43);
            this.startBT.TabIndex = 6;
            this.startBT.Text = "Start Test";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // titleLB
            // 
            this.titleLB.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLB, 2);
            this.titleLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLB.Font = new System.Drawing.Font("Gabriel Weiss\' Friends Font", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLB.ForeColor = System.Drawing.Color.Yellow;
            this.titleLB.Location = new System.Drawing.Point(158, 0);
            this.titleLB.Name = "titleLB";
            this.titleLB.Size = new System.Drawing.Size(459, 50);
            this.titleLB.TabIndex = 8;
            this.titleLB.Text = "Trivia Quiz";
            this.titleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Quiz";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox testCB;
        private System.Windows.Forms.Label numeLB;
        private System.Windows.Forms.Label cnpLB;
        private System.Windows.Forms.Label testLB;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.TextBox cnpTB;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Label titleLB;
    }
}

