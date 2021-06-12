
namespace VentaMayorista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHist = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpPrenda = new System.Windows.Forms.GroupBox();
            this.chkChup = new System.Windows.Forms.CheckBox();
            this.chkCuello = new System.Windows.Forms.CheckBox();
            this.chkManga = new System.Windows.Forms.CheckBox();
            this.radPant = new System.Windows.Forms.RadioButton();
            this.radCam = new System.Windows.Forms.RadioButton();
            this.lblNombTiend = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.lblDirec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombVend = new System.Windows.Forms.Label();
            this.lblCodigotx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUnid = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.grpCalidad = new System.Windows.Forms.GroupBox();
            this.radStand = new System.Windows.Forms.RadioButton();
            this.radPrem = new System.Windows.Forms.RadioButton();
            this.grpPrecYCant = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.lblPrec = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblPrecFin = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.FechaForm = new System.Windows.Forms.DateTimePicker();
            this.lblCodVend = new System.Windows.Forms.Label();
            this.lblCotizN = new System.Windows.Forms.Label();
            this.lblCotizNum = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.grpPrenda.SuspendLayout();
            this.grpCalidad.SuspendLayout();
            this.grpPrecYCant.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHist
            // 
            this.btnHist.Location = new System.Drawing.Point(574, 144);
            this.btnHist.Name = "btnHist";
            this.btnHist.Size = new System.Drawing.Size(214, 23);
            this.btnHist.TabIndex = 1;
            this.btnHist.Text = "Historial Cotizaciones";
            this.btnHist.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(776, 84);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cotizador Express";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPrenda
            // 
            this.grpPrenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPrenda.Controls.Add(this.chkChup);
            this.grpPrenda.Controls.Add(this.chkCuello);
            this.grpPrenda.Controls.Add(this.chkManga);
            this.grpPrenda.Controls.Add(this.radPant);
            this.grpPrenda.Controls.Add(this.radCam);
            this.grpPrenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPrenda.Location = new System.Drawing.Point(12, 197);
            this.grpPrenda.Name = "grpPrenda";
            this.grpPrenda.Size = new System.Drawing.Size(400, 134);
            this.grpPrenda.TabIndex = 3;
            this.grpPrenda.TabStop = false;
            this.grpPrenda.Text = "Prenda";
            // 
            // chkChup
            // 
            this.chkChup.AutoSize = true;
            this.chkChup.Enabled = false;
            this.chkChup.Location = new System.Drawing.Point(144, 77);
            this.chkChup.Name = "chkChup";
            this.chkChup.Size = new System.Drawing.Size(79, 25);
            this.chkChup.TabIndex = 4;
            this.chkChup.Text = "Chupín";
            this.chkChup.UseVisualStyleBackColor = true;
            // 
            // chkCuello
            // 
            this.chkCuello.AutoSize = true;
            this.chkCuello.Location = new System.Drawing.Point(266, 29);
            this.chkCuello.Name = "chkCuello";
            this.chkCuello.Size = new System.Drawing.Size(108, 25);
            this.chkCuello.TabIndex = 3;
            this.chkCuello.Text = "Cuello Mao";
            this.chkCuello.UseVisualStyleBackColor = true;
            // 
            // chkManga
            // 
            this.chkManga.AutoSize = true;
            this.chkManga.Location = new System.Drawing.Point(144, 29);
            this.chkManga.Name = "chkManga";
            this.chkManga.Size = new System.Drawing.Size(116, 25);
            this.chkManga.TabIndex = 2;
            this.chkManga.Text = "Manga larga";
            this.chkManga.UseVisualStyleBackColor = true;
            // 
            // radPant
            // 
            this.radPant.AutoSize = true;
            this.radPant.Location = new System.Drawing.Point(24, 77);
            this.radPant.Name = "radPant";
            this.radPant.Size = new System.Drawing.Size(88, 25);
            this.radPant.TabIndex = 1;
            this.radPant.TabStop = true;
            this.radPant.Text = "Pantalón";
            this.radPant.UseVisualStyleBackColor = true;
            this.radPant.CheckedChanged += new System.EventHandler(this.radPant_CheckedChanged);
            // 
            // radCam
            // 
            this.radCam.AutoSize = true;
            this.radCam.Checked = true;
            this.radCam.Location = new System.Drawing.Point(24, 28);
            this.radCam.Name = "radCam";
            this.radCam.Size = new System.Drawing.Size(79, 25);
            this.radCam.TabIndex = 0;
            this.radCam.TabStop = true;
            this.radCam.Text = "Camisa";
            this.radCam.UseVisualStyleBackColor = true;
            this.radCam.CheckedChanged += new System.EventHandler(this.radCam_CheckedChanged);
            // 
            // lblNombTiend
            // 
            this.lblNombTiend.AutoSize = true;
            this.lblNombTiend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombTiend.Location = new System.Drawing.Point(12, 105);
            this.lblNombTiend.Name = "lblNombTiend";
            this.lblNombTiend.Size = new System.Drawing.Size(112, 21);
            this.lblNombTiend.TabIndex = 4;
            this.lblNombTiend.Text = "Tienda Quark";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 527);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 527);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDirec.Location = new System.Drawing.Point(574, 105);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(214, 21);
            this.lblDirec.TabIndex = 7;
            this.lblDirec.Text = "Dirección: Avenida Rocca 187";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 10);
            this.label2.TabIndex = 8;
            // 
            // lblNombVend
            // 
            this.lblNombVend.AutoSize = true;
            this.lblNombVend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombVend.Location = new System.Drawing.Point(12, 146);
            this.lblNombVend.Name = "lblNombVend";
            this.lblNombVend.Size = new System.Drawing.Size(237, 21);
            this.lblNombVend.TabIndex = 9;
            this.lblNombVend.Text = "Vendedor: Fernandez Rodrigo";
            // 
            // lblCodigotx
            // 
            this.lblCodigotx.AutoSize = true;
            this.lblCodigotx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigotx.Location = new System.Drawing.Point(255, 146);
            this.lblCodigotx.Name = "lblCodigotx";
            this.lblCodigotx.Size = new System.Drawing.Size(71, 21);
            this.lblCodigotx.TabIndex = 10;
            this.lblCodigotx.Text = "Código:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(244, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "|";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 10);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 5);
            this.label4.TabIndex = 13;
            // 
            // lblUnid
            // 
            this.lblUnid.AutoSize = true;
            this.lblUnid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnid.Location = new System.Drawing.Point(418, 197);
            this.lblUnid.Name = "lblUnid";
            this.lblUnid.Size = new System.Drawing.Size(165, 21);
            this.lblUnid.TabIndex = 14;
            this.lblUnid.Text = "Unidades disponibles: ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStock.Location = new System.Drawing.Point(589, 197);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 21);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "_____";
            // 
            // grpCalidad
            // 
            this.grpCalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCalidad.Controls.Add(this.radStand);
            this.grpCalidad.Controls.Add(this.radPrem);
            this.grpCalidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCalidad.Location = new System.Drawing.Point(418, 226);
            this.grpCalidad.Name = "grpCalidad";
            this.grpCalidad.Size = new System.Drawing.Size(126, 105);
            this.grpCalidad.TabIndex = 5;
            this.grpCalidad.TabStop = false;
            this.grpCalidad.Text = "Calidad";
            // 
            // radStand
            // 
            this.radStand.AutoSize = true;
            this.radStand.Location = new System.Drawing.Point(24, 59);
            this.radStand.Name = "radStand";
            this.radStand.Size = new System.Drawing.Size(81, 25);
            this.radStand.TabIndex = 1;
            this.radStand.TabStop = true;
            this.radStand.Text = "Standar";
            this.radStand.UseVisualStyleBackColor = true;
            // 
            // radPrem
            // 
            this.radPrem.AutoSize = true;
            this.radPrem.Checked = true;
            this.radPrem.Location = new System.Drawing.Point(24, 28);
            this.radPrem.Name = "radPrem";
            this.radPrem.Size = new System.Drawing.Size(92, 25);
            this.radPrem.TabIndex = 0;
            this.radPrem.TabStop = true;
            this.radPrem.Text = "Premium";
            this.radPrem.UseVisualStyleBackColor = true;
            // 
            // grpPrecYCant
            // 
            this.grpPrecYCant.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPrecYCant.Controls.Add(this.txtCantidad);
            this.grpPrecYCant.Controls.Add(this.lblCantidad);
            this.grpPrecYCant.Controls.Add(this.txtPrecio1);
            this.grpPrecYCant.Controls.Add(this.lblPrec);
            this.grpPrecYCant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpPrecYCant.Location = new System.Drawing.Point(12, 337);
            this.grpPrecYCant.Name = "grpPrecYCant";
            this.grpPrecYCant.Size = new System.Drawing.Size(223, 105);
            this.grpPrecYCant.TabIndex = 6;
            this.grpPrecYCant.TabStop = false;
            this.grpPrecYCant.Text = "Precio unitario y cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(81, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(110, 29);
            this.txtCantidad.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidad.Location = new System.Drawing.Point(6, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 21);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(81, 22);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(110, 29);
            this.txtPrecio1.TabIndex = 16;
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrec.Location = new System.Drawing.Point(6, 25);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(77, 21);
            this.lblPrec.TabIndex = 16;
            this.lblPrec.Text = "Precio :  $";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCotizar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCotizar.Location = new System.Drawing.Point(255, 397);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(214, 45);
            this.btnCotizar.TabIndex = 16;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblPrecFin
            // 
            this.lblPrecFin.AutoSize = true;
            this.lblPrecFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecFin.Location = new System.Drawing.Point(477, 415);
            this.lblPrecFin.Name = "lblPrecFin";
            this.lblPrecFin.Size = new System.Drawing.Size(124, 21);
            this.lblPrecFin.TabIndex = 19;
            this.lblPrecFin.Text = "Precio Final :  $";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.Location = new System.Drawing.Point(607, 415);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(87, 21);
            this.lblPrecioFinal.TabIndex = 20;
            this.lblPrecioFinal.Text = "___________";
            // 
            // FechaForm
            // 
            this.FechaForm.Location = new System.Drawing.Point(550, 228);
            this.FechaForm.Name = "FechaForm";
            this.FechaForm.Size = new System.Drawing.Size(238, 23);
            this.FechaForm.TabIndex = 21;
            // 
            // lblCodVend
            // 
            this.lblCodVend.AutoSize = true;
            this.lblCodVend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodVend.Location = new System.Drawing.Point(322, 146);
            this.lblCodVend.Name = "lblCodVend";
            this.lblCodVend.Size = new System.Drawing.Size(64, 21);
            this.lblCodVend.TabIndex = 22;
            this.lblCodVend.Text = "123456";
            // 
            // lblCotizN
            // 
            this.lblCotizN.AutoSize = true;
            this.lblCotizN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotizN.Location = new System.Drawing.Point(255, 373);
            this.lblCotizN.Name = "lblCotizN";
            this.lblCotizN.Size = new System.Drawing.Size(109, 21);
            this.lblCotizN.TabIndex = 23;
            this.lblCotizN.Text = "Cotización nº: ";
            // 
            // lblCotizNum
            // 
            this.lblCotizNum.AutoSize = true;
            this.lblCotizNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCotizNum.Location = new System.Drawing.Point(361, 373);
            this.lblCotizNum.Name = "lblCotizNum";
            this.lblCotizNum.Size = new System.Drawing.Size(19, 21);
            this.lblCotizNum.TabIndex = 24;
            this.lblCotizNum.Text = "0";
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(640, 197);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(127, 21);
            this.btnStock.TabIndex = 25;
            this.btnStock.Text = "Actualizar stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.lblCotizNum);
            this.Controls.Add(this.lblCotizN);
            this.Controls.Add(this.lblCodVend);
            this.Controls.Add(this.FechaForm);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblPrecFin);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.grpPrecYCant);
            this.Controls.Add(this.grpCalidad);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblUnid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigotx);
            this.Controls.Add(this.lblNombVend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDirec);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblNombTiend);
            this.Controls.Add(this.grpPrenda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnHist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPrenda.ResumeLayout(false);
            this.grpPrenda.PerformLayout();
            this.grpCalidad.ResumeLayout(false);
            this.grpCalidad.PerformLayout();
            this.grpPrecYCant.ResumeLayout(false);
            this.grpPrecYCant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHist;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpPrenda;
        private System.Windows.Forms.CheckBox chkChup;
        private System.Windows.Forms.CheckBox chkCuello;
        private System.Windows.Forms.CheckBox chkManga;
        private System.Windows.Forms.RadioButton radPant;
        private System.Windows.Forms.RadioButton radCam;
        private System.Windows.Forms.Label lblNombTiend;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombVend;
        private System.Windows.Forms.Label lblCodigotx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUnid;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox grpCalidad;
        private System.Windows.Forms.RadioButton radStand;
        private System.Windows.Forms.RadioButton radPrem;
        private System.Windows.Forms.GroupBox grpPrecYCant;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblPrecFin;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.DateTimePicker FechaForm;
        private System.Windows.Forms.Label lblCodVend;
        private System.Windows.Forms.Label lblCotizN;
        private System.Windows.Forms.Label lblCotizNum;
        private System.Windows.Forms.Button btnStock;
    }
}

