namespace ProyectoAutos.Presentacion
{
    partial class TiposAEForm
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
            this.tipoMetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CancelMetroButton = new MetroFramework.Controls.MetroButton();
            this.OkMetroButton = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoMetroTextBox
            // 
            // 
            // 
            // 
            this.tipoMetroTextBox.CustomButton.Image = null;
            this.tipoMetroTextBox.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.tipoMetroTextBox.CustomButton.Name = "";
            this.tipoMetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tipoMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tipoMetroTextBox.CustomButton.TabIndex = 1;
            this.tipoMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tipoMetroTextBox.CustomButton.UseSelectable = true;
            this.tipoMetroTextBox.CustomButton.Visible = false;
            this.tipoMetroTextBox.Lines = new string[0];
            this.tipoMetroTextBox.Location = new System.Drawing.Point(98, 104);
            this.tipoMetroTextBox.MaxLength = 50;
            this.tipoMetroTextBox.Name = "tipoMetroTextBox";
            this.tipoMetroTextBox.PasswordChar = '\0';
            this.tipoMetroTextBox.PromptText = "Ingrese un tipo";
            this.tipoMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tipoMetroTextBox.SelectedText = "";
            this.tipoMetroTextBox.SelectionLength = 0;
            this.tipoMetroTextBox.SelectionStart = 0;
            this.tipoMetroTextBox.ShortcutsEnabled = true;
            this.tipoMetroTextBox.Size = new System.Drawing.Size(292, 23);
            this.tipoMetroTextBox.TabIndex = 4;
            this.tipoMetroTextBox.UseSelectable = true;
            this.tipoMetroTextBox.WaterMark = "Ingrese un tipo";
            this.tipoMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tipoMetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 104);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Tipo:";
            // 
            // CancelMetroButton
            // 
            this.CancelMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.cancel_24px;
            this.CancelMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelMetroButton.Location = new System.Drawing.Point(284, 156);
            this.CancelMetroButton.Name = "CancelMetroButton";
            this.CancelMetroButton.Size = new System.Drawing.Size(106, 58);
            this.CancelMetroButton.TabIndex = 5;
            this.CancelMetroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelMetroButton.UseSelectable = true;
            this.CancelMetroButton.Click += new System.EventHandler(this.CancelMetroButton_Click);
            // 
            // OkMetroButton
            // 
            this.OkMetroButton.BackgroundImage = global::ProyectoAutos.Presentacion.Properties.Resources.ok_24px;
            this.OkMetroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OkMetroButton.Location = new System.Drawing.Point(43, 156);
            this.OkMetroButton.Name = "OkMetroButton";
            this.OkMetroButton.Size = new System.Drawing.Size(106, 58);
            this.OkMetroButton.TabIndex = 6;
            this.OkMetroButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OkMetroButton.UseSelectable = true;
            this.OkMetroButton.Click += new System.EventHandler(this.OkMetroButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TiposAEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 259);
            this.Controls.Add(this.CancelMetroButton);
            this.Controls.Add(this.OkMetroButton);
            this.Controls.Add(this.tipoMetroTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TiposAEForm";
            this.Text = "Tipos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CancelMetroButton;
        private MetroFramework.Controls.MetroButton OkMetroButton;
        private MetroFramework.Controls.MetroTextBox tipoMetroTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}