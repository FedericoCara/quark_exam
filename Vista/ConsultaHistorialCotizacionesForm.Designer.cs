
namespace Quark_Exam.Vista
{
    partial class ConsultaHistorialCotizacionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.historialGridView = new System.Windows.Forms.DataGridView();
            this.numeroColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPrendaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizacionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historialGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // historialGridView
            // 
            this.historialGridView.AllowUserToAddRows = false;
            this.historialGridView.AllowUserToDeleteRows = false;
            this.historialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroColumn,
            this.fechaColumn,
            this.tipoPrendaColumn,
            this.calidadColumn,
            this.cantidadColumn,
            this.cotizacionColumn,
            this.detallesColumn});
            this.historialGridView.Location = new System.Drawing.Point(13, 12);
            this.historialGridView.Name = "historialGridView";
            this.historialGridView.Size = new System.Drawing.Size(794, 507);
            this.historialGridView.TabIndex = 0;
            // 
            // numeroColumn
            // 
            this.numeroColumn.HeaderText = "Número";
            this.numeroColumn.Name = "numeroColumn";
            this.numeroColumn.ReadOnly = true;
            // 
            // fechaColumn
            // 
            this.fechaColumn.HeaderText = "Fecha";
            this.fechaColumn.Name = "fechaColumn";
            this.fechaColumn.ReadOnly = true;
            // 
            // tipoPrendaColumn
            // 
            this.tipoPrendaColumn.HeaderText = "Tipo Prenda";
            this.tipoPrendaColumn.Name = "tipoPrendaColumn";
            this.tipoPrendaColumn.ReadOnly = true;
            // 
            // calidadColumn
            // 
            this.calidadColumn.HeaderText = "Calidad";
            this.calidadColumn.Name = "calidadColumn";
            this.calidadColumn.ReadOnly = true;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Cantidad";
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.ReadOnly = true;
            // 
            // cotizacionColumn
            // 
            this.cotizacionColumn.HeaderText = "Cotización";
            this.cotizacionColumn.Name = "cotizacionColumn";
            this.cotizacionColumn.ReadOnly = true;
            // 
            // detallesColumn
            // 
            this.detallesColumn.HeaderText = "Detalles";
            this.detallesColumn.Name = "detallesColumn";
            this.detallesColumn.ReadOnly = true;
            this.detallesColumn.Width = 150;
            // 
            // ConsultaHistorialCotizacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 531);
            this.Controls.Add(this.historialGridView);
            this.MaximumSize = new System.Drawing.Size(835, 570);
            this.MinimumSize = new System.Drawing.Size(835, 570);
            this.Name = "ConsultaHistorialCotizacionesForm";
            this.Text = "ConsultaHistorialCotizaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaHistorialCotizacionesForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.historialGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historialGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPrendaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotizacionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesColumn;
    }
}