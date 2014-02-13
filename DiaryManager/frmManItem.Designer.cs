namespace DiaryManager
{
    partial class frmManItem
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
            this.title = new System.Windows.Forms.Label();
            this.event0Label = new System.Windows.Forms.Label();
            this.event1Label = new System.Windows.Forms.Label();
            this.event2Label = new System.Windows.Forms.Label();
            this.event0 = new System.Windows.Forms.RichTextBox();
            this.event1 = new System.Windows.Forms.RichTextBox();
            this.event2 = new System.Windows.Forms.RichTextBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(101, 29);
            this.title.TabIndex = 0;
            this.title.Text = "**计划";
            // 
            // event0Label
            // 
            this.event0Label.AutoSize = true;
            this.event0Label.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.event0Label.Location = new System.Drawing.Point(12, 70);
            this.event0Label.Name = "event0Label";
            this.event0Label.Size = new System.Drawing.Size(59, 20);
            this.event0Label.TabIndex = 0;
            this.event0Label.Text = "事件0";
            // 
            // event1Label
            // 
            this.event1Label.AutoSize = true;
            this.event1Label.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.event1Label.Location = new System.Drawing.Point(234, 70);
            this.event1Label.Name = "event1Label";
            this.event1Label.Size = new System.Drawing.Size(59, 20);
            this.event1Label.TabIndex = 0;
            this.event1Label.Text = "事件1";
            // 
            // event2Label
            // 
            this.event2Label.AutoSize = true;
            this.event2Label.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.event2Label.Location = new System.Drawing.Point(459, 70);
            this.event2Label.Name = "event2Label";
            this.event2Label.Size = new System.Drawing.Size(59, 20);
            this.event2Label.TabIndex = 0;
            this.event2Label.Text = "事件2";
            // 
            // event0
            // 
            this.event0.Location = new System.Drawing.Point(17, 107);
            this.event0.Name = "event0";
            this.event0.Size = new System.Drawing.Size(198, 94);
            this.event0.TabIndex = 2;
            this.event0.Text = "";
            // 
            // event1
            // 
            this.event1.Location = new System.Drawing.Point(238, 107);
            this.event1.Name = "event1";
            this.event1.Size = new System.Drawing.Size(198, 94);
            this.event1.TabIndex = 2;
            this.event1.Text = "";
            // 
            // event2
            // 
            this.event2.Location = new System.Drawing.Point(463, 107);
            this.event2.Name = "event2";
            this.event2.Size = new System.Drawing.Size(198, 94);
            this.event2.TabIndex = 2;
            this.event2.Text = "";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noteLabel.Location = new System.Drawing.Point(13, 213);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(49, 20);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "备注";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(17, 254);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(419, 94);
            this.notes.TabIndex = 2;
            this.notes.Text = "";
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acceptButton.Location = new System.Drawing.Point(515, 267);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(92, 30);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "确认修改";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancleButton
            // 
            this.cancleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancleButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancleButton.Location = new System.Drawing.Point(515, 303);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(92, 30);
            this.cancleButton.TabIndex = 3;
            this.cancleButton.Text = "取消";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // frmManItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 360);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.event2);
            this.Controls.Add(this.event1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.event0);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.event2Label);
            this.Controls.Add(this.event1Label);
            this.Controls.Add(this.event0Label);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManItem";
            this.Text = "管理项";
            this.Load += new System.EventHandler(this.frmManItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;

       
        private System.Windows.Forms.Label event0Label;
        private System.Windows.Forms.Label event1Label;
        private System.Windows.Forms.Label event2Label;
        private System.Windows.Forms.RichTextBox event0;
        private System.Windows.Forms.RichTextBox event1;
        private System.Windows.Forms.RichTextBox event2;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancleButton;
    }
}