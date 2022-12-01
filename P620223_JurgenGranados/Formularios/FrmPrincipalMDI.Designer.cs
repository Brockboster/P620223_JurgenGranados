using System;

namespace P620223_JurgenGranados.Formularios
{
    partial class FrmPrincipalMDI
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
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gALERIADEREPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorRangoDeFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeInventarioActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.reimpresionDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.BackColor = System.Drawing.Color.DarkGray;
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOSToolStripMenuItem,
            this.pROCESOSToolStripMenuItem,
            this.gALERIADEREPORTESToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // mANTENIMIENTOSToolStripMenuItem
            // 
            this.mANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator1,
            this.clientesToolStripMenuItem,
            this.toolStripSeparator2,
            this.impuestosToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.categoriasDeInventarioToolStripMenuItem,
            this.toolStripSeparator3,
            this.proveedoresToolStripMenuItem});
            this.mANTENIMIENTOSToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mANTENIMIENTOSToolStripMenuItem.Image = global::P620223_JurgenGranados.Properties.Resources.Mant;
            this.mANTENIMIENTOSToolStripMenuItem.Name = "mANTENIMIENTOSToolStripMenuItem";
            this.mANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.mANTENIMIENTOSToolStripMenuItem.Text = "MANTENIMIENTOS";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // categoriasDeInventarioToolStripMenuItem
            // 
            this.categoriasDeInventarioToolStripMenuItem.Name = "categoriasDeInventarioToolStripMenuItem";
            this.categoriasDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.categoriasDeInventarioToolStripMenuItem.Text = "Categorias de Inventario";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(199, 6);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pROCESOSToolStripMenuItem.Image = global::P620223_JurgenGranados.Properties.Resources.proce;
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // gALERIADEREPORTESToolStripMenuItem
            // 
            this.gALERIADEREPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorRangoDeFechasToolStripMenuItem,
            this.ventasPorClientToolStripMenuItem,
            this.ventasPorUsuarioToolStripMenuItem,
            this.toolStripSeparator4,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeProveedoresToolStripMenuItem,
            this.listaDeInventarioActualToolStripMenuItem,
            this.toolStripSeparator5,
            this.reimpresionDeFacturaToolStripMenuItem});
            this.gALERIADEREPORTESToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gALERIADEREPORTESToolStripMenuItem.Image = global::P620223_JurgenGranados.Properties.Resources.gallery;
            this.gALERIADEREPORTESToolStripMenuItem.Name = "gALERIADEREPORTESToolStripMenuItem";
            this.gALERIADEREPORTESToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.gALERIADEREPORTESToolStripMenuItem.Text = "GALERIA DE REPORTES";
            // 
            // ventasPorRangoDeFechasToolStripMenuItem
            // 
            this.ventasPorRangoDeFechasToolStripMenuItem.Name = "ventasPorRangoDeFechasToolStripMenuItem";
            this.ventasPorRangoDeFechasToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ventasPorRangoDeFechasToolStripMenuItem.Text = "Ventas por rango de Fechas";
            // 
            // ventasPorClientToolStripMenuItem
            // 
            this.ventasPorClientToolStripMenuItem.Name = "ventasPorClientToolStripMenuItem";
            this.ventasPorClientToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ventasPorClientToolStripMenuItem.Text = "Ventas por Client";
            // 
            // ventasPorUsuarioToolStripMenuItem
            // 
            this.ventasPorUsuarioToolStripMenuItem.Name = "ventasPorUsuarioToolStripMenuItem";
            this.ventasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.ventasPorUsuarioToolStripMenuItem.Text = "Ventas por Usuario";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(215, 6);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            this.listadoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores";
            // 
            // listaDeInventarioActualToolStripMenuItem
            // 
            this.listaDeInventarioActualToolStripMenuItem.Name = "listaDeInventarioActualToolStripMenuItem";
            this.listaDeInventarioActualToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listaDeInventarioActualToolStripMenuItem.Text = "Lista de Inventario Actual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(215, 6);
            // 
            // reimpresionDeFacturaToolStripMenuItem
            // 
            this.reimpresionDeFacturaToolStripMenuItem.Name = "reimpresionDeFacturaToolStripMenuItem";
            this.reimpresionDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.reimpresionDeFacturaToolStripMenuItem.Text = "Reimpresion de Factura";
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.aCERCADEToolStripMenuItem.Image = global::P620223_JurgenGranados.Properties.Resources.about1;
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MnuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmPrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P5 Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipalMDI_FormClosed);
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gALERIADEREPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
        private EventHandler toolStripComboBox1_Click;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorRangoDeFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listaDeInventarioActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem reimpresionDeFacturaToolStripMenuItem;
    }
}