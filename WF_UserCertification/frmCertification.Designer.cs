namespace WF_UserCertification
{
    partial class frmCertification
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdUsersInfo = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCorreo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGetUsersData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsersInfo)).BeginInit();
            this.grpCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdUsersInfo
            // 
            this.grdUsersInfo.AllowUserToAddRows = false;
            this.grdUsersInfo.AllowUserToDeleteRows = false;
            this.grdUsersInfo.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsersInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUsersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsersInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Nombre,
            this.Estatus,
            this.UserGroups});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUsersInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdUsersInfo.Location = new System.Drawing.Point(13, 69);
            this.grdUsersInfo.Name = "grdUsersInfo";
            this.grdUsersInfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUsersInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUsersInfo.Size = new System.Drawing.Size(664, 150);
            this.grdUsersInfo.TabIndex = 1;
            this.grdUsersInfo.Visible = false;
            // 
            // Username
            // 
            this.Username.HeaderText = "Cuenta";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // UserGroups
            // 
            this.UserGroups.HeaderText = "Grupo(s)";
            this.UserGroups.Name = "UserGroups";
            this.UserGroups.ReadOnly = true;
            // 
            // grpCorreo
            // 
            this.grpCorreo.Controls.Add(this.textBox2);
            this.grpCorreo.Controls.Add(this.lblFrom);
            this.grpCorreo.Controls.Add(this.textBox1);
            this.grpCorreo.Controls.Add(this.lblTo);
            this.grpCorreo.Location = new System.Drawing.Point(13, 222);
            this.grpCorreo.Name = "grpCorreo";
            this.grpCorreo.Size = new System.Drawing.Size(664, 183);
            this.grpCorreo.TabIndex = 2;
            this.grpCorreo.TabStop = false;
            this.grpCorreo.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(7, 21);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(7, 54);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To:";
            // 
            // btnGetUsersData
            // 
            this.btnGetUsersData.Location = new System.Drawing.Point(13, 13);
            this.btnGetUsersData.Name = "btnGetUsersData";
            this.btnGetUsersData.Size = new System.Drawing.Size(134, 23);
            this.btnGetUsersData.TabIndex = 0;
            this.btnGetUsersData.Text = "Obtener usuarios";
            this.btnGetUsersData.UseVisualStyleBackColor = true;
            this.btnGetUsersData.Click += new System.EventHandler(this.btnGetUsersData_Click);
            // 
            // frmCertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 417);
            this.Controls.Add(this.btnGetUsersData);
            this.Controls.Add(this.grpCorreo);
            this.Controls.Add(this.grdUsersInfo);
            this.Name = "frmCertification";
            this.Text = "Certificación de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.grdUsersInfo)).EndInit();
            this.grpCorreo.ResumeLayout(false);
            this.grpCorreo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdUsersInfo;
        private System.Windows.Forms.GroupBox grpCorreo;
        private System.Windows.Forms.Button btnGetUsersData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroups;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTo;
    }
}

