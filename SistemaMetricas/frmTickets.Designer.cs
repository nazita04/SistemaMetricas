namespace SistemaMetricas
{
    partial class frmTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTickets));
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.grdTickets = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdModificarTicket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).BeginInit();
            this.pnlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSubTitle.Location = new System.Drawing.Point(274, 26);
            this.lblSubTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(177, 20);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Configuración de Tickets";
            // 
            // grdTickets
            // 
            this.grdTickets.AllowUserToAddRows = false;
            this.grdTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdTickets.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grdTickets.Location = new System.Drawing.Point(11, 64);
            this.grdTickets.Margin = new System.Windows.Forms.Padding(2);
            this.grdTickets.Name = "grdTickets";
            this.grdTickets.RowHeadersWidth = 62;
            this.grdTickets.RowTemplate.Height = 28;
            this.grdTickets.Size = new System.Drawing.Size(715, 311);
            this.grdTickets.TabIndex = 3;
            this.grdTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTickets_CellContentClick);
            this.grdTickets.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // pnlPanel
            // 
            this.pnlPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlPanel.Controls.Add(this.txtDescripcion);
            this.pnlPanel.Controls.Add(this.lblEstado);
            this.pnlPanel.Controls.Add(this.cmbEstado);
            this.pnlPanel.Controls.Add(this.button1);
            this.pnlPanel.Controls.Add(this.cmdCancelar);
            this.pnlPanel.Controls.Add(this.cmdModificarTicket);
            this.pnlPanel.Controls.Add(this.label2);
            this.pnlPanel.Location = new System.Drawing.Point(149, 81);
            this.pnlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(416, 264);
            this.pnlPanel.TabIndex = 12;
            this.pnlPanel.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(22, 130);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 120);
            this.txtDescripcion.TabIndex = 17;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(20, 40);
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
            "Pendiente",
            "Terminado",
            "En_Curso",
            "Rechazado"});
            this.cmbEstado.Location = new System.Drawing.Point(22, 60);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(173, 21);
            this.cmbEstado.TabIndex = 15;
            this.cmbEstado.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(378, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 29);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.Location = new System.Drawing.Point(272, 163);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 27);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdModificarTicket
            // 
            this.cmdModificarTicket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdModificarTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmdModificarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificarTicket.ForeColor = System.Drawing.Color.White;
            this.cmdModificarTicket.Location = new System.Drawing.Point(272, 100);
            this.cmdModificarTicket.Margin = new System.Windows.Forms.Padding(2);
            this.cmdModificarTicket.Name = "cmdModificarTicket";
            this.cmdModificarTicket.Size = new System.Drawing.Size(91, 27);
            this.cmdModificarTicket.TabIndex = 4;
            this.cmdModificarTicket.Text = "Modificar";
            this.cmdModificarTicket.UseVisualStyleBackColor = false;
            this.cmdModificarTicket.Click += new System.EventHandler(this.cmdModificarTicket_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción:";
            // 
            // frmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.grdTickets);
            this.Controls.Add(this.lblSubTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTickets";
            this.Text = "frmTickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).EndInit();
            this.pnlPanel.ResumeLayout(false);
            this.pnlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.DataGridView grdTickets;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdModificarTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}