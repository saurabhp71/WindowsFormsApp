namespace WindowsFormsApp4
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblRahitech = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grdUserDetails = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUserDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(36, 163);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(43, 230);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(79, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(142, 163);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(176, 20);
            this.txtbxName.TabIndex = 2;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(149, 230);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(176, 20);
            this.txtbxAddress.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(40, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRahitech
            // 
            this.lblRahitech.AutoSize = true;
            this.lblRahitech.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRahitech.Location = new System.Drawing.Point(357, 33);
            this.lblRahitech.Name = "lblRahitech";
            this.lblRahitech.Size = new System.Drawing.Size(77, 23);
            this.lblRahitech.TabIndex = 5;
            this.lblRahitech.Text = "Rahitech";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(43, 91);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 23);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(142, 96);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(176, 20);
            this.txtbxID.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(383, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(219, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grdUserDetails
            // 
            this.grdUserDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUserDetails.Location = new System.Drawing.Point(353, 94);
            this.grdUserDetails.Name = "grdUserDetails";
            this.grdUserDetails.Size = new System.Drawing.Size(417, 191);
            this.grdUserDetails.TabIndex = 10;
            this.grdUserDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUserDetails_CellContentClick);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(566, 358);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 36);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.grdUserDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblRahitech);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUserDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRahitech;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtbxID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdUserDetails;
        private System.Windows.Forms.Button btnShow;
    }
}

