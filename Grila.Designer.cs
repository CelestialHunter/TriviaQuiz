
namespace Lab5
{
    partial class Grila
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
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.punctajLB = new System.Windows.Forms.Label();
            this.nextBT = new System.Windows.Forms.Button();
            this.intrebariLB = new System.Windows.Forms.Label();
            this.numeLB = new System.Windows.Forms.Label();
            this.numeTB = new System.Windows.Forms.TextBox();
            this.pictureIB = new System.Windows.Forms.PictureBox();
            this.prevBT = new System.Windows.Forms.Button();
            this.intrebariTB = new System.Windows.Forms.TextBox();
            this.punctajTB = new System.Windows.Forms.TextBox();
            this.textLB = new System.Windows.Forms.Label();
            this.answersFL = new System.Windows.Forms.FlowLayoutPanel();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIB)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 5;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.90909F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.90909F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.layout.Controls.Add(this.punctajLB, 0, 3);
            this.layout.Controls.Add(this.nextBT, 3, 3);
            this.layout.Controls.Add(this.intrebariLB, 3, 0);
            this.layout.Controls.Add(this.numeLB, 0, 0);
            this.layout.Controls.Add(this.numeTB, 2, 0);
            this.layout.Controls.Add(this.pictureIB, 4, 2);
            this.layout.Controls.Add(this.prevBT, 2, 3);
            this.layout.Controls.Add(this.intrebariTB, 4, 0);
            this.layout.Controls.Add(this.punctajTB, 1, 3);
            this.layout.Controls.Add(this.textLB, 0, 1);
            this.layout.Controls.Add(this.answersFL, 0, 2);
            this.layout.Location = new System.Drawing.Point(12, 12);
            this.layout.Name = "layout";
            this.layout.RowCount = 4;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.Size = new System.Drawing.Size(776, 426);
            this.layout.TabIndex = 0;
            // 
            // punctajLB
            // 
            this.punctajLB.AutoSize = true;
            this.punctajLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.punctajLB.ForeColor = System.Drawing.Color.White;
            this.punctajLB.Location = new System.Drawing.Point(3, 382);
            this.punctajLB.Name = "punctajLB";
            this.punctajLB.Size = new System.Drawing.Size(117, 44);
            this.punctajLB.TabIndex = 7;
            this.punctajLB.Text = "Punctaj";
            this.punctajLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextBT
            // 
            this.nextBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.nextBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBT.ForeColor = System.Drawing.Color.White;
            this.nextBT.Location = new System.Drawing.Point(430, 390);
            this.nextBT.Margin = new System.Windows.Forms.Padding(8);
            this.nextBT.Name = "nextBT";
            this.nextBT.Size = new System.Drawing.Size(160, 28);
            this.nextBT.TabIndex = 6;
            this.nextBT.Text = "Întrebarea Următoare";
            this.nextBT.UseVisualStyleBackColor = true;
            this.nextBT.Click += new System.EventHandler(this.nextBT_Click);
            // 
            // intrebariLB
            // 
            this.intrebariLB.AutoSize = true;
            this.intrebariLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intrebariLB.ForeColor = System.Drawing.Color.White;
            this.intrebariLB.Location = new System.Drawing.Point(425, 0);
            this.intrebariLB.Name = "intrebariLB";
            this.intrebariLB.Size = new System.Drawing.Size(170, 42);
            this.intrebariLB.TabIndex = 1;
            this.intrebariLB.Text = "Număr Întrebări / Test";
            this.intrebariLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeLB
            // 
            this.numeLB.AutoSize = true;
            this.layout.SetColumnSpan(this.numeLB, 2);
            this.numeLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numeLB.ForeColor = System.Drawing.Color.White;
            this.numeLB.Location = new System.Drawing.Point(3, 0);
            this.numeLB.Name = "numeLB";
            this.numeLB.Size = new System.Drawing.Size(240, 42);
            this.numeLB.TabIndex = 0;
            this.numeLB.Text = "Candidat";
            this.numeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeTB
            // 
            this.numeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numeTB.BackColor = System.Drawing.Color.Gray;
            this.numeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeTB.ForeColor = System.Drawing.SystemColors.Info;
            this.numeTB.Location = new System.Drawing.Point(254, 9);
            this.numeTB.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.numeTB.Name = "numeTB";
            this.numeTB.ReadOnly = true;
            this.numeTB.Size = new System.Drawing.Size(160, 23);
            this.numeTB.TabIndex = 2;
            // 
            // pictureIB
            // 
            this.pictureIB.BackColor = System.Drawing.Color.Transparent;
            this.pictureIB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureIB.Location = new System.Drawing.Point(614, 185);
            this.pictureIB.Margin = new System.Windows.Forms.Padding(16);
            this.pictureIB.Name = "pictureIB";
            this.pictureIB.Size = new System.Drawing.Size(146, 181);
            this.pictureIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIB.TabIndex = 4;
            this.pictureIB.TabStop = false;
            // 
            // prevBT
            // 
            this.prevBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.prevBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevBT.ForeColor = System.Drawing.Color.White;
            this.prevBT.Location = new System.Drawing.Point(254, 390);
            this.prevBT.Margin = new System.Windows.Forms.Padding(8);
            this.prevBT.Name = "prevBT";
            this.prevBT.Size = new System.Drawing.Size(160, 28);
            this.prevBT.TabIndex = 5;
            this.prevBT.Text = "Întrebarea Precedentă";
            this.prevBT.UseVisualStyleBackColor = true;
            this.prevBT.Visible = false;
            // 
            // intrebariTB
            // 
            this.intrebariTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.intrebariTB.BackColor = System.Drawing.Color.Gray;
            this.intrebariTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intrebariTB.ForeColor = System.Drawing.SystemColors.Info;
            this.intrebariTB.Location = new System.Drawing.Point(606, 9);
            this.intrebariTB.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.intrebariTB.Name = "intrebariTB";
            this.intrebariTB.ReadOnly = true;
            this.intrebariTB.Size = new System.Drawing.Size(162, 23);
            this.intrebariTB.TabIndex = 3;
            this.intrebariTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // punctajTB
            // 
            this.punctajTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.punctajTB.BackColor = System.Drawing.Color.Gray;
            this.punctajTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.punctajTB.ForeColor = System.Drawing.Color.Gold;
            this.punctajTB.Location = new System.Drawing.Point(131, 392);
            this.punctajTB.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.punctajTB.Name = "punctajTB";
            this.punctajTB.ReadOnly = true;
            this.punctajTB.Size = new System.Drawing.Size(107, 23);
            this.punctajTB.TabIndex = 8;
            this.punctajTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textLB
            // 
            this.textLB.AutoSize = true;
            this.layout.SetColumnSpan(this.textLB, 5);
            this.textLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLB.Font = new System.Drawing.Font("Noto Sans ExtCond ExtLt", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLB.ForeColor = System.Drawing.Color.White;
            this.textLB.Location = new System.Drawing.Point(3, 42);
            this.textLB.Name = "textLB";
            this.textLB.Size = new System.Drawing.Size(770, 127);
            this.textLB.TabIndex = 9;
            this.textLB.Text = "label1";
            this.textLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answersFL
            // 
            this.layout.SetColumnSpan(this.answersFL, 4);
            this.answersFL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answersFL.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.answersFL.Location = new System.Drawing.Point(3, 172);
            this.answersFL.Name = "answersFL";
            this.answersFL.Padding = new System.Windows.Forms.Padding(16);
            this.answersFL.Size = new System.Drawing.Size(592, 207);
            this.answersFL.TabIndex = 10;
            // 
            // Grila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layout);
            this.Name = "Grila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Quiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Grila_FormClosed);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label intrebariLB;
        private System.Windows.Forms.Label numeLB;
        private System.Windows.Forms.TextBox numeTB;
        private System.Windows.Forms.TextBox intrebariTB;
        private System.Windows.Forms.PictureBox pictureIB;
        private System.Windows.Forms.Button prevBT;
        private System.Windows.Forms.Button nextBT;
        private System.Windows.Forms.Label punctajLB;
        private System.Windows.Forms.TextBox punctajTB;
        private System.Windows.Forms.Label textLB;
        private System.Windows.Forms.FlowLayoutPanel answersFL;
    }
}