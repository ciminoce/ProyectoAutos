namespace ProyectoAutos.Presentacion
{
    partial class MenuPrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposMetroTile = new MetroFramework.Controls.MetroTile();
            this.SalirMetroTile = new MetroFramework.Controls.MetroTile();
            this.MarcasMetroTile = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.autosToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.autosToolStripMenuItem.Text = "Autos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tiposMetroTile
            // 
            this.tiposMetroTile.ActiveControl = null;
            this.tiposMetroTile.BackColor = System.Drawing.Color.Lime;
            this.tiposMetroTile.Location = new System.Drawing.Point(112, 330);
            this.tiposMetroTile.Name = "tiposMetroTile";
            this.tiposMetroTile.Size = new System.Drawing.Size(166, 103);
            this.tiposMetroTile.TabIndex = 3;
            this.tiposMetroTile.Text = "Tipos";
            this.tiposMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tiposMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources.tesla_model_x_48px;
            this.tiposMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tiposMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tiposMetroTile.UseCustomBackColor = true;
            this.tiposMetroTile.UseSelectable = true;
            this.tiposMetroTile.UseTileImage = true;
            this.tiposMetroTile.Click += new System.EventHandler(this.tiposMetroTile_Click);
            // 
            // SalirMetroTile
            // 
            this.SalirMetroTile.ActiveControl = null;
            this.SalirMetroTile.BackColor = System.Drawing.Color.Gainsboro;
            this.SalirMetroTile.Location = new System.Drawing.Point(772, 407);
            this.SalirMetroTile.Name = "SalirMetroTile";
            this.SalirMetroTile.Size = new System.Drawing.Size(166, 115);
            this.SalirMetroTile.TabIndex = 3;
            this.SalirMetroTile.Text = "Salir";
            this.SalirMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalirMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources.enter_48px;
            this.SalirMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalirMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.SalirMetroTile.UseCustomBackColor = true;
            this.SalirMetroTile.UseSelectable = true;
            this.SalirMetroTile.UseTileImage = true;
            this.SalirMetroTile.Click += new System.EventHandler(this.SalirMetroTile_Click);
            // 
            // MarcasMetroTile
            // 
            this.MarcasMetroTile.ActiveControl = null;
            this.MarcasMetroTile.BackColor = System.Drawing.Color.Red;
            this.MarcasMetroTile.Location = new System.Drawing.Point(112, 209);
            this.MarcasMetroTile.Name = "MarcasMetroTile";
            this.MarcasMetroTile.Size = new System.Drawing.Size(166, 115);
            this.MarcasMetroTile.TabIndex = 3;
            this.MarcasMetroTile.Text = "Marcas";
            this.MarcasMetroTile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MarcasMetroTile.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources.ferrari_48px;
            this.MarcasMetroTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MarcasMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MarcasMetroTile.UseCustomBackColor = true;
            this.MarcasMetroTile.UseSelectable = true;
            this.MarcasMetroTile.UseTileImage = true;
            this.MarcasMetroTile.Click += new System.EventHandler(this.MarcasMetroTile_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Blue;
            this.metroTile1.Location = new System.Drawing.Point(293, 209);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(161, 224);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Autos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::ProyectoAutos.Presentacion.Properties.Resources.cars_48px;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 555);
            this.ControlBox = false;
            this.Controls.Add(this.tiposMetroTile);
            this.Controls.Add(this.SalirMetroTile);
            this.Controls.Add(this.MarcasMetroTile);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipalForm";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile MarcasMetroTile;
        private MetroFramework.Controls.MetroTile tiposMetroTile;
        private MetroFramework.Controls.MetroTile SalirMetroTile;
    }
}

