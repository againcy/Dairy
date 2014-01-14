namespace DiaryManager
{
    partial class frmCheckMan
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
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonSport = new System.Windows.Forms.Button();
            this.buttonBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteFood = new System.Windows.Forms.Button();
            this.deleteSport = new System.Windows.Forms.Button();
            this.deleteBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFood
            // 
            this.buttonFood.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFood.Location = new System.Drawing.Point(107, 7);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(134, 30);
            this.buttonFood.TabIndex = 1;
            this.buttonFood.Text = "查看或修改";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonSport
            // 
            this.buttonSport.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSport.Location = new System.Drawing.Point(107, 60);
            this.buttonSport.Name = "buttonSport";
            this.buttonSport.Size = new System.Drawing.Size(134, 30);
            this.buttonSport.TabIndex = 3;
            this.buttonSport.Text = "查看或修改";
            this.buttonSport.UseVisualStyleBackColor = true;
            this.buttonSport.Click += new System.EventHandler(this.buttonSport_Click);
            // 
            // buttonBill
            // 
            this.buttonBill.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBill.Location = new System.Drawing.Point(107, 113);
            this.buttonBill.Name = "buttonBill";
            this.buttonBill.Size = new System.Drawing.Size(134, 30);
            this.buttonBill.TabIndex = 5;
            this.buttonBill.Text = "查看或修改";
            this.buttonBill.UseVisualStyleBackColor = true;
            this.buttonBill.Click += new System.EventHandler(this.buttonBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "饮食记录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "锻炼记录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "收支记录";
            // 
            // deleteFood
            // 
            this.deleteFood.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteFood.Location = new System.Drawing.Point(268, 7);
            this.deleteFood.Name = "deleteFood";
            this.deleteFood.Size = new System.Drawing.Size(88, 30);
            this.deleteFood.TabIndex = 6;
            this.deleteFood.Text = "删除";
            this.deleteFood.UseVisualStyleBackColor = true;
            this.deleteFood.Click += new System.EventHandler(this.deleteFood_Click);
            // 
            // deleteSport
            // 
            this.deleteSport.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteSport.Location = new System.Drawing.Point(268, 60);
            this.deleteSport.Name = "deleteSport";
            this.deleteSport.Size = new System.Drawing.Size(88, 30);
            this.deleteSport.TabIndex = 6;
            this.deleteSport.Text = "删除";
            this.deleteSport.UseVisualStyleBackColor = true;
            this.deleteSport.Click += new System.EventHandler(this.deleteSport_Click);
            // 
            // deleteBill
            // 
            this.deleteBill.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteBill.Location = new System.Drawing.Point(268, 113);
            this.deleteBill.Name = "deleteBill";
            this.deleteBill.Size = new System.Drawing.Size(88, 30);
            this.deleteBill.TabIndex = 6;
            this.deleteBill.Text = "删除";
            this.deleteBill.UseVisualStyleBackColor = true;
            this.deleteBill.Click += new System.EventHandler(this.deleteBill_Click);
            // 
            // frmCheckMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 160);
            this.Controls.Add(this.deleteBill);
            this.Controls.Add(this.deleteSport);
            this.Controls.Add(this.deleteFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBill);
            this.Controls.Add(this.buttonSport);
            this.Controls.Add(this.buttonFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCheckMan";
            this.Text = "frmCheckMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonSport;
        private System.Windows.Forms.Button buttonBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteFood;
        private System.Windows.Forms.Button deleteSport;
        private System.Windows.Forms.Button deleteBill;

    }
}