
namespace contacts_crud_demoo_new
{
    partial class CalculateDiscount
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
            this.components = new System.ComponentModel.Container();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCourseFee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PnlError = new System.Windows.Forms.Panel();
            this.LblEroor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelHeader.SuspendLayout();
            this.PnlError.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.PanelHeader.Controls.Add(this.lblTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(480, 67);
            this.PanelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(64, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "{title}";
            // 
            // txtCourseFee
            // 
            this.txtCourseFee.Location = new System.Drawing.Point(30, 78);
            this.txtCourseFee.Name = "txtCourseFee";
            this.txtCourseFee.Size = new System.Drawing.Size(322, 20);
            this.txtCourseFee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Course Fee";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(30, 152);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(322, 20);
            this.txtDiscount.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Discount Applied";
            // 
            // PnlError
            // 
            this.PnlError.BackColor = System.Drawing.Color.Tomato;
            this.PnlError.Controls.Add(this.LblEroor);
            this.PnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlError.Location = new System.Drawing.Point(0, 0);
            this.PnlError.Name = "PnlError";
            this.PnlError.Size = new System.Drawing.Size(390, 34);
            this.PnlError.TabIndex = 10;
            // 
            // LblEroor
            // 
            this.LblEroor.BackColor = System.Drawing.Color.Tomato;
            this.LblEroor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEroor.Location = new System.Drawing.Point(0, 0);
            this.LblEroor.Name = "LblEroor";
            this.LblEroor.Size = new System.Drawing.Size(390, 34);
            this.LblEroor.TabIndex = 11;
            this.LblEroor.Text = "First Name";
            this.LblEroor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PnlError);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCourseFee);
            this.panel1.Location = new System.Drawing.Point(38, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 232);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(169)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate Discount";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CalculateDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 379);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Name = "CalculateDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculate Discount";
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PnlError.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCourseFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel PnlError;
        private System.Windows.Forms.Label LblEroor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}