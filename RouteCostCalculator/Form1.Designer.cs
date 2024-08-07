namespace RouteCostCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.lblUnder12 = new System.Windows.Forms.Label();
            this.GrB1 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ComboPass12 = new Guna.UI.WinForms.GunaComboBox();
            this.ComboPass = new Guna.UI.WinForms.GunaComboBox();
            this.ComboTo = new Guna.UI.WinForms.GunaComboBox();
            this.ComboFrom = new Guna.UI.WinForms.GunaComboBox();
            this.lblTotFare = new System.Windows.Forms.Label();
            this.BtnCalculate = new Guna.UI.WinForms.GunaButton();
            this.GrB2 = new Guna.UI.WinForms.GunaGroupBox();
            this.RtbBill = new System.Windows.Forms.RichTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.GrB1.SuspendLayout();
            this.GrB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Navy;
            this.lblFrom.Location = new System.Drawing.Point(75, 86);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Navy;
            this.lblTo.Location = new System.Drawing.Point(75, 132);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 17);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "To";
            // 
            // lblFare
            // 
            this.lblFare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFare.AutoSize = true;
            this.lblFare.BackColor = System.Drawing.Color.Transparent;
            this.lblFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.ForeColor = System.Drawing.Color.Navy;
            this.lblFare.Location = new System.Drawing.Point(65, 448);
            this.lblFare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(91, 20);
            this.lblFare.TabIndex = 6;
            this.lblFare.Text = "Total Fare";
            // 
            // lblPassengers
            // 
            this.lblPassengers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.BackColor = System.Drawing.Color.Transparent;
            this.lblPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassengers.ForeColor = System.Drawing.Color.Navy;
            this.lblPassengers.Location = new System.Drawing.Point(75, 205);
            this.lblPassengers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(121, 17);
            this.lblPassengers.TabIndex = 7;
            this.lblPassengers.Text = "No of Passengers";
            // 
            // lblUnder12
            // 
            this.lblUnder12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnder12.AutoSize = true;
            this.lblUnder12.BackColor = System.Drawing.Color.Transparent;
            this.lblUnder12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnder12.ForeColor = System.Drawing.Color.Navy;
            this.lblUnder12.Location = new System.Drawing.Point(75, 248);
            this.lblUnder12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnder12.Name = "lblUnder12";
            this.lblUnder12.Size = new System.Drawing.Size(182, 17);
            this.lblUnder12.TabIndex = 9;
            this.lblUnder12.Text = "No of Passengers under 12";
            // 
            // GrB1
            // 
            this.GrB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrB1.BackColor = System.Drawing.Color.Transparent;
            this.GrB1.BaseColor = System.Drawing.Color.Transparent;
            this.GrB1.BorderColor = System.Drawing.Color.Navy;
            this.GrB1.BorderSize = 3;
            this.GrB1.Controls.Add(this.gunaLabel1);
            this.GrB1.Controls.Add(this.ComboPass12);
            this.GrB1.Controls.Add(this.ComboPass);
            this.GrB1.Controls.Add(this.ComboTo);
            this.GrB1.Controls.Add(this.ComboFrom);
            this.GrB1.Controls.Add(this.lblTo);
            this.GrB1.Controls.Add(this.lblUnder12);
            this.GrB1.Controls.Add(this.lblFrom);
            this.GrB1.Controls.Add(this.lblPassengers);
            this.GrB1.LineColor = System.Drawing.Color.White;
            this.GrB1.LineTop = 0;
            this.GrB1.Location = new System.Drawing.Point(27, 117);
            this.GrB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrB1.Name = "GrB1";
            this.GrB1.Radius = 20;
            this.GrB1.Size = new System.Drawing.Size(440, 303);
            this.GrB1.TabIndex = 12;
            this.GrB1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel1.Location = new System.Drawing.Point(73, 21);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(296, 25);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Route No 001 Colombo - Kandy";
            // 
            // ComboPass12
            // 
            this.ComboPass12.BackColor = System.Drawing.Color.Transparent;
            this.ComboPass12.BaseColor = System.Drawing.Color.White;
            this.ComboPass12.BorderColor = System.Drawing.Color.Silver;
            this.ComboPass12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboPass12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPass12.FocusedColor = System.Drawing.Color.Empty;
            this.ComboPass12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboPass12.ForeColor = System.Drawing.Color.Black;
            this.ComboPass12.FormattingEnabled = true;
            this.ComboPass12.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboPass12.Location = new System.Drawing.Point(269, 244);
            this.ComboPass12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboPass12.Name = "ComboPass12";
            this.ComboPass12.OnHoverItemBaseColor = System.Drawing.Color.MediumBlue;
            this.ComboPass12.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboPass12.Radius = 10;
            this.ComboPass12.Size = new System.Drawing.Size(71, 26);
            this.ComboPass12.TabIndex = 15;
            // 
            // ComboPass
            // 
            this.ComboPass.BackColor = System.Drawing.Color.Transparent;
            this.ComboPass.BaseColor = System.Drawing.Color.White;
            this.ComboPass.BorderColor = System.Drawing.Color.Silver;
            this.ComboPass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboPass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPass.FocusedColor = System.Drawing.Color.Empty;
            this.ComboPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboPass.ForeColor = System.Drawing.Color.Black;
            this.ComboPass.FormattingEnabled = true;
            this.ComboPass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboPass.Location = new System.Drawing.Point(269, 201);
            this.ComboPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboPass.Name = "ComboPass";
            this.ComboPass.OnHoverItemBaseColor = System.Drawing.Color.MediumBlue;
            this.ComboPass.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboPass.Radius = 10;
            this.ComboPass.Size = new System.Drawing.Size(71, 26);
            this.ComboPass.TabIndex = 14;
            // 
            // ComboTo
            // 
            this.ComboTo.BackColor = System.Drawing.Color.Transparent;
            this.ComboTo.BaseColor = System.Drawing.Color.White;
            this.ComboTo.BorderColor = System.Drawing.Color.Silver;
            this.ComboTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTo.FocusedColor = System.Drawing.Color.Empty;
            this.ComboTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboTo.ForeColor = System.Drawing.Color.Black;
            this.ComboTo.FormattingEnabled = true;
            this.ComboTo.Location = new System.Drawing.Point(163, 128);
            this.ComboTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboTo.Name = "ComboTo";
            this.ComboTo.OnHoverItemBaseColor = System.Drawing.Color.MediumBlue;
            this.ComboTo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboTo.Radius = 10;
            this.ComboTo.Size = new System.Drawing.Size(177, 26);
            this.ComboTo.TabIndex = 13;
            // 
            // ComboFrom
            // 
            this.ComboFrom.BackColor = System.Drawing.Color.Transparent;
            this.ComboFrom.BaseColor = System.Drawing.Color.White;
            this.ComboFrom.BorderColor = System.Drawing.Color.Silver;
            this.ComboFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboFrom.FocusedColor = System.Drawing.Color.Empty;
            this.ComboFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboFrom.ForeColor = System.Drawing.Color.Black;
            this.ComboFrom.FormattingEnabled = true;
            this.ComboFrom.Location = new System.Drawing.Point(163, 82);
            this.ComboFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboFrom.Name = "ComboFrom";
            this.ComboFrom.OnHoverItemBaseColor = System.Drawing.Color.MediumBlue;
            this.ComboFrom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ComboFrom.Radius = 10;
            this.ComboFrom.Size = new System.Drawing.Size(177, 26);
            this.ComboFrom.TabIndex = 12;
            // 
            // lblTotFare
            // 
            this.lblTotFare.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotFare.AutoSize = true;
            this.lblTotFare.BackColor = System.Drawing.Color.Transparent;
            this.lblTotFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotFare.ForeColor = System.Drawing.Color.Black;
            this.lblTotFare.Location = new System.Drawing.Point(170, 448);
            this.lblTotFare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotFare.Name = "lblTotFare";
            this.lblTotFare.Size = new System.Drawing.Size(0, 20);
            this.lblTotFare.TabIndex = 13;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCalculate.Animated = true;
            this.BtnCalculate.AnimationHoverSpeed = 0.07F;
            this.BtnCalculate.AnimationSpeed = 0.03F;
            this.BtnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.BtnCalculate.BaseColor = System.Drawing.Color.Navy;
            this.BtnCalculate.BorderColor = System.Drawing.Color.White;
            this.BtnCalculate.BorderSize = 2;
            this.BtnCalculate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCalculate.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCalculate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Image = null;
            this.BtnCalculate.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCalculate.Location = new System.Drawing.Point(324, 440);
            this.BtnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.OnHoverBaseColor = System.Drawing.Color.White;
            this.BtnCalculate.OnHoverBorderColor = System.Drawing.Color.Navy;
            this.BtnCalculate.OnHoverForeColor = System.Drawing.Color.Navy;
            this.BtnCalculate.OnHoverImage = null;
            this.BtnCalculate.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCalculate.Radius = 10;
            this.BtnCalculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCalculate.Size = new System.Drawing.Size(107, 31);
            this.BtnCalculate.TabIndex = 14;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // GrB2
            // 
            this.GrB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrB2.BackColor = System.Drawing.Color.Transparent;
            this.GrB2.BaseColor = System.Drawing.Color.Transparent;
            this.GrB2.BorderColor = System.Drawing.Color.Navy;
            this.GrB2.BorderSize = 3;
            this.GrB2.Controls.Add(this.RtbBill);
            this.GrB2.Controls.Add(this.gunaLabel2);
            this.GrB2.LineColor = System.Drawing.Color.White;
            this.GrB2.LineTop = 0;
            this.GrB2.Location = new System.Drawing.Point(509, 117);
            this.GrB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrB2.Name = "GrB2";
            this.GrB2.Radius = 20;
            this.GrB2.Size = new System.Drawing.Size(282, 303);
            this.GrB2.TabIndex = 17;
            this.GrB2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // RtbBill
            // 
            this.RtbBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbBill.Location = new System.Drawing.Point(20, 72);
            this.RtbBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RtbBill.Name = "RtbBill";
            this.RtbBill.ReadOnly = true;
            this.RtbBill.Size = new System.Drawing.Size(243, 196);
            this.RtbBill.TabIndex = 17;
            this.RtbBill.Text = "";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Navy;
            this.gunaLabel2.Location = new System.Drawing.Point(87, 21);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(114, 25);
            this.gunaLabel2.TabIndex = 16;
            this.gunaLabel2.Text = "Bill Preview";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 508);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "© Thiwanka Imalshan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrB2);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.lblTotFare);
            this.Controls.Add(this.GrB1);
            this.Controls.Add(this.lblFare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Fare Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrB1.ResumeLayout(false);
            this.GrB1.PerformLayout();
            this.GrB2.ResumeLayout(false);
            this.GrB2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label lblUnder12;
        private Guna.UI.WinForms.GunaGroupBox GrB1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox ComboPass12;
        private Guna.UI.WinForms.GunaComboBox ComboPass;
        private Guna.UI.WinForms.GunaComboBox ComboTo;
        private Guna.UI.WinForms.GunaComboBox ComboFrom;
        private System.Windows.Forms.Label lblTotFare;
        private Guna.UI.WinForms.GunaButton BtnCalculate;
        private Guna.UI.WinForms.GunaGroupBox GrB2;
        private System.Windows.Forms.RichTextBox RtbBill;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Label label1;
    }
}

