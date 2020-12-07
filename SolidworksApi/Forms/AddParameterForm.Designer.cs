namespace SolidworksApi.Forms
{
    partial class AddParameterForm
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
            this.btnAddParameterToList = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddParameterToList
            // 
            this.btnAddParameterToList.Location = new System.Drawing.Point(167, 152);
            this.btnAddParameterToList.Name = "btnAddParameterToList";
            this.btnAddParameterToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddParameterToList.TabIndex = 1;
            this.btnAddParameterToList.Text = "Add";
            this.btnAddParameterToList.UseVisualStyleBackColor = true;
            this.btnAddParameterToList.Click += new System.EventHandler(this.btnAddParameterToList_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(142, 108);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 7;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(142, 69);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(142, 32);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 9;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(50, 108);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(85, 17);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height(mm):";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(50, 69);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(88, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length(mm):";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(50, 32);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(80, 17);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width(mm):";
            // 
            // AddParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 428);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnAddParameterToList);
            this.Name = "AddParameterForm";
            this.Text = "AddParameterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddParameterToList;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
    }
}