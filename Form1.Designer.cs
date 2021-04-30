
namespace DBFrist
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCus = new System.Windows.Forms.ListBox();
            this.emps = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numOfOrder = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addOrder = new System.Windows.Forms.Button();
            this.addDetail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxpro = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.Quntity = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // listBoxCus
            // 
            this.listBoxCus.FormattingEnabled = true;
            this.listBoxCus.ItemHeight = 16;
            this.listBoxCus.Location = new System.Drawing.Point(39, 80);
            this.listBoxCus.Name = "listBoxCus";
            this.listBoxCus.Size = new System.Drawing.Size(169, 292);
            this.listBoxCus.TabIndex = 1;
            this.listBoxCus.SelectedIndexChanged += new System.EventHandler(this.listBoxCus_SelectedIndexChanged);
            // 
            // emps
            // 
            this.emps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emps.FormattingEnabled = true;
            this.emps.Location = new System.Drawing.Point(235, 80);
            this.emps.Name = "emps";
            this.emps.Size = new System.Drawing.Size(129, 24);
            this.emps.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Number Of Orders";
            // 
            // numOfOrder
            // 
            this.numOfOrder.AutoSize = true;
            this.numOfOrder.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfOrder.Location = new System.Drawing.Point(333, 205);
            this.numOfOrder.Name = "numOfOrder";
            this.numOfOrder.Size = new System.Drawing.Size(31, 33);
            this.numOfOrder.TabIndex = 5;
            this.numOfOrder.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(285, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Customer Order";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(480, 462);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(146, 19);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Employee Full Data";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(564, 80);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrder.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.Location = new System.Drawing.Point(788, 427);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(145, 54);
            this.addOrder.TabIndex = 9;
            this.addOrder.Text = "Add Oreder";
            this.addOrder.UseVisualStyleBackColor = false;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // addDetail
            // 
            this.addDetail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDetail.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDetail.Location = new System.Drawing.Point(956, 424);
            this.addDetail.Name = "addDetail";
            this.addDetail.Size = new System.Drawing.Size(149, 57);
            this.addDetail.TabIndex = 10;
            this.addDetail.Text = "Add Details";
            this.addDetail.UseVisualStyleBackColor = false;
            this.addDetail.Click += new System.EventHandler(this.addDetail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(876, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quntity";
            // 
            // listBoxpro
            // 
            this.listBoxpro.FormattingEnabled = true;
            this.listBoxpro.ItemHeight = 16;
            this.listBoxpro.Location = new System.Drawing.Point(1212, 80);
            this.listBoxpro.Name = "listBoxpro";
            this.listBoxpro.Size = new System.Drawing.Size(177, 292);
            this.listBoxpro.TabIndex = 14;
            this.listBoxpro.SelectedIndexChanged += new System.EventHandler(this.listBoxpro_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1206, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Products";
            // 
            // unitPrice
            // 
            this.unitPrice.Location = new System.Drawing.Point(1041, 158);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(143, 22);
            this.unitPrice.TabIndex = 15;
            // 
            // Quntity
            // 
            this.Quntity.Location = new System.Drawing.Point(1041, 248);
            this.Quntity.Name = "Quntity";
            this.Quntity.Size = new System.Drawing.Size(143, 22);
            this.Quntity.TabIndex = 16;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Matura MT Script Capitals", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(1243, 462);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(146, 19);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Employee Full Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.Quntity);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.listBoxpro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addDetail);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.numOfOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emps);
            this.Controls.Add(this.listBoxCus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCus;
        private System.Windows.Forms.ComboBox emps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numOfOrder;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button addDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxpro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unitPrice;
        private System.Windows.Forms.TextBox Quntity;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}

