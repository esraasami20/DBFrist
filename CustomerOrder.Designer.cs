
namespace DBFrist
{
    partial class CustomerOrder
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
            this.CusOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CusName = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // CusOrder
            // 
            this.CusOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusOrder.Location = new System.Drawing.Point(220, 74);
            this.CusOrder.Name = "CusOrder";
            this.CusOrder.RowHeadersWidth = 51;
            this.CusOrder.RowTemplate.Height = 24;
            this.CusOrder.Size = new System.Drawing.Size(503, 276);
            this.CusOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order For Customer : ";
            // 
            // CusName
            // 
            this.CusName.AutoSize = true;
            this.CusName.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusName.ForeColor = System.Drawing.Color.Red;
            this.CusName.Location = new System.Drawing.Point(522, 22);
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(201, 32);
            this.CusName.TabIndex = 2;
            this.CusName.Text = "Customer Name";
            this.CusName.Click += new System.EventHandler(this.CusName_Click);
            // 
            // addOrder
            // 
            this.addOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addOrder.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrder.Location = new System.Drawing.Point(427, 376);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(145, 54);
            this.addOrder.TabIndex = 10;
            this.addOrder.Text = "Close";
            this.addOrder.UseVisualStyleBackColor = false;
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.CusName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CusOrder);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "CustomerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrder";
            ((System.ComponentModel.ISupportInitialize)(this.CusOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CusOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CusName;
        private System.Windows.Forms.Button addOrder;
    }
}