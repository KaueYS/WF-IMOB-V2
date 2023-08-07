namespace WFImobiliaria2
{
    partial class frmPossiveisCompradores
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
            this.grdPossiveisCompradores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPossiveisCompradores)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPossiveisCompradores
            // 
            this.grdPossiveisCompradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPossiveisCompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPossiveisCompradores.Location = new System.Drawing.Point(12, 38);
            this.grdPossiveisCompradores.MultiSelect = false;
            this.grdPossiveisCompradores.Name = "grdPossiveisCompradores";
            this.grdPossiveisCompradores.ReadOnly = true;
            this.grdPossiveisCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPossiveisCompradores.Size = new System.Drawing.Size(960, 575);
            this.grdPossiveisCompradores.TabIndex = 1;
            // 
            // frmPossiveisCompradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grdPossiveisCompradores);
            this.MaximizeBox = false;
            this.Name = "frmPossiveisCompradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de consulta";
            this.Load += new System.EventHandler(this.frmPossiveisCompradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPossiveisCompradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPossiveisCompradores;
    }
}