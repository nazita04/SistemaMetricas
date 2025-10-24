namespace SistemaMetricas
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAreas = new System.Windows.Forms.ToolStripButton();
            this.tsbTipos = new System.Windows.Forms.ToolStripButton();
            this.tbsTickets = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoTicket = new System.Windows.Forms.ToolStripButton();
            this.tbsReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAreas,
            this.tsbTipos,
            this.tbsTickets,
            this.tsbNuevoTicket,
            this.tbsReportes,
            this.tsbUsuarios});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbAreas
            // 
            this.tsbAreas.Image = ((System.Drawing.Image)(resources.GetObject("tsbAreas.Image")));
            this.tsbAreas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAreas.Name = "tsbAreas";
            this.tsbAreas.Size = new System.Drawing.Size(122, 28);
            this.tsbAreas.Text = "Config. de Áreas";
            this.tsbAreas.Visible = false;
            this.tsbAreas.Click += new System.EventHandler(this.tsbAreas_Click);
            // 
            // tsbTipos
            // 
            this.tsbTipos.Image = ((System.Drawing.Image)(resources.GetObject("tsbTipos.Image")));
            this.tsbTipos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTipos.Name = "tsbTipos";
            this.tsbTipos.Size = new System.Drawing.Size(119, 28);
            this.tsbTipos.Text = "Config. de tipos";
            this.tsbTipos.Visible = false;
            this.tsbTipos.Click += new System.EventHandler(this.tsbTipos_Click);
            // 
            // tbsTickets
            // 
            this.tbsTickets.Image = ((System.Drawing.Image)(resources.GetObject("tbsTickets.Image")));
            this.tbsTickets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsTickets.Name = "tbsTickets";
            this.tbsTickets.Size = new System.Drawing.Size(125, 28);
            this.tbsTickets.Text = "config. de tickets";
            this.tbsTickets.Visible = false;
            this.tbsTickets.Click += new System.EventHandler(this.tsbTickets_Click);
            // 
            // tsbNuevoTicket
            // 
            this.tsbNuevoTicket.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevoTicket.Image")));
            this.tsbNuevoTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTicket.Name = "tsbNuevoTicket";
            this.tsbNuevoTicket.Size = new System.Drawing.Size(104, 28);
            this.tsbNuevoTicket.Text = "Nuevo Ticket";
            this.tsbNuevoTicket.Visible = false;
            this.tsbNuevoTicket.Click += new System.EventHandler(this.tsbNuevoTicket_Click);
            // 
            // tbsReportes
            // 
            this.tbsReportes.Image = ((System.Drawing.Image)(resources.GetObject("tbsReportes.Image")));
            this.tbsReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsReportes.Name = "tbsReportes";
            this.tbsReportes.Size = new System.Drawing.Size(98, 28);
            this.tbsReportes.Text = "Reportes (0)";
            this.tbsReportes.Visible = false;
            this.tbsReportes.Click += new System.EventHandler(this.tsbReportes_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(80, 28);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Visible = false;
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlContainer.Location = new System.Drawing.Point(0, 33);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(746, 396);
            this.pnlContainer.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 444);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAreas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripButton tsbTipos;
        private System.Windows.Forms.ToolStripButton tsbNuevoTicket;
        private System.Windows.Forms.ToolStripButton tbsTickets;
        private System.Windows.Forms.ToolStripButton tbsReportes;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
    }
}