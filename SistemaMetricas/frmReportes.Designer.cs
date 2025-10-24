namespace SistemaMetricas
{
    partial class frmReportes
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
            this.components = new System.ComponentModel.Container();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.btnTerminados = new System.Windows.Forms.Button();
            this.btnRechazados = new System.Windows.Forms.Button();
            this.btnEnCurso = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPendientes
            // 
            this.btnPendientes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPendientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPendientes.Location = new System.Drawing.Point(13, 53);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(151, 48);
            this.btnPendientes.TabIndex = 0;
            this.btnPendientes.Text = "Pendientes (0)";
            this.btnPendientes.UseVisualStyleBackColor = false;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // btnTerminados
            // 
            this.btnTerminados.BackColor = System.Drawing.Color.PaleGreen;
            this.btnTerminados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTerminados.Location = new System.Drawing.Point(170, 53);
            this.btnTerminados.Name = "btnTerminados";
            this.btnTerminados.Size = new System.Drawing.Size(158, 48);
            this.btnTerminados.TabIndex = 1;
            this.btnTerminados.Text = "Terminados (0)";
            this.btnTerminados.UseVisualStyleBackColor = false;
            this.btnTerminados.Click += new System.EventHandler(this.btnTerminados_Click);
            // 
            // btnRechazados
            // 
            this.btnRechazados.BackColor = System.Drawing.Color.Salmon;
            this.btnRechazados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRechazados.Location = new System.Drawing.Point(334, 53);
            this.btnRechazados.Name = "btnRechazados";
            this.btnRechazados.Size = new System.Drawing.Size(165, 48);
            this.btnRechazados.TabIndex = 2;
            this.btnRechazados.Text = "Rechazados (0)";
            this.btnRechazados.UseVisualStyleBackColor = false;
            this.btnRechazados.Click += new System.EventHandler(this.btnRechazados_Click);
            // 
            // btnEnCurso
            // 
            this.btnEnCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEnCurso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnCurso.Location = new System.Drawing.Point(505, 53);
            this.btnEnCurso.Name = "btnEnCurso";
            this.btnEnCurso.Size = new System.Drawing.Size(165, 48);
            this.btnEnCurso.TabIndex = 3;
            this.btnEnCurso.Text = "En curso (0)";
            this.btnEnCurso.UseVisualStyleBackColor = false;
            this.btnEnCurso.Click += new System.EventHandler(this.btnEnCurso_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.ContextMenuStrip = this.contextMenuStrip1;
            this.grdDatos.Location = new System.Drawing.Point(8, 154);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.Size = new System.Drawing.Size(763, 284);
            this.grdDatos.TabIndex = 4;
            this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "Exportar Html";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Titulo ",
            "Area ",
            "Prioridad",
            "Tipos",
            "FechaAlta",
            "Estado "});
            this.cmbFiltro.Location = new System.Drawing.Point(8, 128);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(182, 21);
            this.cmbFiltro.TabIndex = 6;
            this.cmbFiltro.Text = "Todos";
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(196, 128);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(575, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reportes";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 37);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total (0)";
            this.lblTotal.Click += new System.EventHandler(this.btnTerminados_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Beige;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(64, 9);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 22);
            this.textBox2.TabIndex = 10;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(696, 126);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 11;
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Visible = false;
            this.btnTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnEnCurso);
            this.Controls.Add(this.btnRechazados);
            this.Controls.Add(this.btnTerminados);
            this.Controls.Add(this.btnPendientes);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnTerminados;
        private System.Windows.Forms.Button btnRechazados;
        private System.Windows.Forms.Button btnEnCurso;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}