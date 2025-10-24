namespace SistemaMetricas
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grdAreas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdCrearArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAreas)).BeginInit();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Abm";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSubTitle.Location = new System.Drawing.Point(11, 26);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(169, 20);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Configuración de Áreas";
            // 
            // grdAreas
            // 
            this.grdAreas.AllowUserToAddRows = false;
            this.grdAreas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAreas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAreas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdAreas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grdAreas.Location = new System.Drawing.Point(11, 62);
            this.grdAreas.Margin = new System.Windows.Forms.Padding(2);
            this.grdAreas.Name = "grdAreas";
            this.grdAreas.RowHeadersWidth = 62;
            this.grdAreas.RowTemplate.Height = 28;
            this.grdAreas.Size = new System.Drawing.Size(626, 311);
            this.grdAreas.TabIndex = 2;
            this.grdAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAreas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregar.ForeColor = System.Drawing.Color.White;
            this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
            this.cmdAgregar.Location = new System.Drawing.Point(587, 8);
            this.cmdAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(50, 31);
            this.cmdAgregar.TabIndex = 3;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // pnlPanel
            // 
            this.pnlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPanel.Controls.Add(this.lblEstado);
            this.pnlPanel.Controls.Add(this.cmbEstado);
            this.pnlPanel.Controls.Add(this.button1);
            this.pnlPanel.Controls.Add(this.cmdCancelar);
            this.pnlPanel.Controls.Add(this.cmdCrearArea);
            this.pnlPanel.Controls.Add(this.label2);
            this.pnlPanel.Controls.Add(this.txtDescripcion);
            this.pnlPanel.Controls.Add(this.label1);
            this.pnlPanel.Controls.Add(this.txtArea);
            this.pnlPanel.Location = new System.Drawing.Point(97, 83);
            this.pnlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(415, 166);
            this.pnlPanel.TabIndex = 11;
            this.pnlPanel.Visible = false;
            this.pnlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(22, 86);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.Visible = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "V",
            "C"});
            this.cmbEstado.Location = new System.Drawing.Point(22, 105);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(173, 21);
            this.cmbEstado.TabIndex = 15;
            this.cmbEstado.Text = "V";
            this.cmbEstado.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(377, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 29);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Location = new System.Drawing.Point(217, 100);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 27);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdCrearArea
            // 
            this.cmdCrearArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCrearArea.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdCrearArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCrearArea.ForeColor = System.Drawing.Color.White;
            this.cmdCrearArea.Location = new System.Drawing.Point(312, 100);
            this.cmdCrearArea.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCrearArea.Name = "cmdCrearArea";
            this.cmdCrearArea.Size = new System.Drawing.Size(91, 27);
            this.cmdCrearArea.TabIndex = 4;
            this.cmdCrearArea.Text = "Crear Area";
            this.cmdCrearArea.UseVisualStyleBackColor = false;
            this.cmdCrearArea.Click += new System.EventHandler(this.cmdCrearArea_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(217, 58);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(176, 23);
            this.txtDescripcion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Área:";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArea.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(19, 57);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(176, 23);
            this.txtArea.TabIndex = 1;
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 380);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.grdAreas);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAreas";
            this.Text = "frmAreas";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAreas)).EndInit();
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.DataGridView grdAreas;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCrearArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}