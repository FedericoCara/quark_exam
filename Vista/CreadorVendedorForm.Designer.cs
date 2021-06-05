
namespace Quark_Exam.Vista
{
    partial class CreadorVendedorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codigoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crearVendedorBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.codigoTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.apellidoTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 106);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código";
            // 
            // codigoTxt
            // 
            this.codigoTxt.Location = new System.Drawing.Point(64, 73);
            this.codigoTxt.Name = "codigoTxt";
            this.codigoTxt.Size = new System.Drawing.Size(234, 20);
            this.codigoTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(64, 21);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(234, 20);
            this.nombreTxt.TabIndex = 0;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(64, 47);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(234, 20);
            this.apellidoTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // crearVendedorBtn
            // 
            this.crearVendedorBtn.Location = new System.Drawing.Point(62, 138);
            this.crearVendedorBtn.Name = "crearVendedorBtn";
            this.crearVendedorBtn.Size = new System.Drawing.Size(209, 23);
            this.crearVendedorBtn.TabIndex = 7;
            this.crearVendedorBtn.Text = "Crear Vendedor";
            this.crearVendedorBtn.UseVisualStyleBackColor = true;
            this.crearVendedorBtn.Click += new System.EventHandler(this.crearVendedorBtn_Click);
            // 
            // CreadorVendedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 179);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crearVendedorBtn);
            this.Name = "CreadorVendedorForm";
            this.Text = "Creador Vendedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button crearVendedorBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codigoTxt;
    }
}