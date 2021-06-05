
namespace Quark_Exam
{
    partial class CreadorTiendaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.crearTiendaBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(103, 21);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(195, 20);
            this.nombreTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de tienda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección";
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(64, 47);
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(234, 20);
            this.direccionTxt.TabIndex = 2;
            // 
            // crearTiendaBtn
            // 
            this.crearTiendaBtn.Location = new System.Drawing.Point(59, 113);
            this.crearTiendaBtn.Name = "crearTiendaBtn";
            this.crearTiendaBtn.Size = new System.Drawing.Size(209, 23);
            this.crearTiendaBtn.TabIndex = 4;
            this.crearTiendaBtn.Text = "Crear Tienda";
            this.crearTiendaBtn.UseVisualStyleBackColor = true;
            this.crearTiendaBtn.Click += new System.EventHandler(this.crearTiendaBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.direccionTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // CreadorTiendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 155);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crearTiendaBtn);
            this.Name = "CreadorTiendaForm";
            this.Text = "Creacion de Tienda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.Button crearTiendaBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

