namespace SolidworksApi
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerateCube = new System.Windows.Forms.Button();
            this.dgvParameter = new System.Windows.Forms.DataGridView();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnGenerateCubesList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(638, 339);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 39);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Oluştur";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGenerateCube
            // 
            this.btnGenerateCube.Location = new System.Drawing.Point(638, 256);
            this.btnGenerateCube.Name = "btnGenerateCube";
            this.btnGenerateCube.Size = new System.Drawing.Size(85, 64);
            this.btnGenerateCube.TabIndex = 1;
            this.btnGenerateCube.Text = "Küp oluştur";
            this.btnGenerateCube.UseVisualStyleBackColor = true;
            this.btnGenerateCube.Visible = false;
            this.btnGenerateCube.Click += new System.EventHandler(this.btnGenerateCube_Click);
            // 
            // dgvParameter
            // 
            this.dgvParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Width,
            this.Length,
            this.Height});
            this.dgvParameter.Location = new System.Drawing.Point(12, 12);
            this.dgvParameter.Name = "dgvParameter";
            this.dgvParameter.RowTemplate.Height = 24;
            this.dgvParameter.Size = new System.Drawing.Size(345, 164);
            this.dgvParameter.TabIndex = 4;
            // 
            // Width
            // 
            this.Width.HeaderText = "Width";
            this.Width.Name = "Width";
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            // 
            // Height
            // 
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(381, 12);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(88, 45);
            this.btnAddParameter.TabIndex = 5;
            this.btnAddParameter.Text = "Add Parameter";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            this.btnAddParameter.Click += new System.EventHandler(this.btnAddParameter_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(40, 285);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 17);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width:";
            this.lblWidth.Visible = false;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(40, 322);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(52, 17);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            this.lblLength.Visible = false;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(40, 361);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 17);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Height";
            this.lblHeight.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(107, 285);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Visible = false;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(107, 322);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 22);
            this.txtLength.TabIndex = 3;
            this.txtLength.Visible = false;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(107, 361);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 3;
            this.txtHeight.Visible = false;
            // 
            // btnGenerateCubesList
            // 
            this.btnGenerateCubesList.Location = new System.Drawing.Point(381, 83);
            this.btnGenerateCubesList.Name = "btnGenerateCubesList";
            this.btnGenerateCubesList.Size = new System.Drawing.Size(88, 50);
            this.btnGenerateCubesList.TabIndex = 6;
            this.btnGenerateCubesList.Text = "Generate Cubes";
            this.btnGenerateCubesList.UseVisualStyleBackColor = true;
            this.btnGenerateCubesList.Click += new System.EventHandler(this.btnGenerateCubesList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateCubesList);
            this.Controls.Add(this.btnAddParameter);
            this.Controls.Add(this.dgvParameter);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnGenerateCube);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGenerateCube;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.Button btnAddParameter;
        public System.Windows.Forms.DataGridView dgvParameter;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnGenerateCubesList;
    }
}

