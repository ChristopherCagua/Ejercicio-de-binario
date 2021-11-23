
namespace EJERCICIOS
{
    partial class frmejercicios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.casilla1 = new System.Windows.Forms.CheckBox();
            this.casilla2 = new System.Windows.Forms.CheckBox();
            this.casilla3 = new System.Windows.Forms.CheckBox();
            this.casilla4 = new System.Windows.Forms.CheckBox();
            this.casilla5 = new System.Windows.Forms.CheckBox();
            this.casilla6 = new System.Windows.Forms.CheckBox();
            this.casilla7 = new System.Windows.Forms.CheckBox();
            this.casilla8 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un entero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(262, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(58, 252);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(99, 50);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // casilla1
            // 
            this.casilla1.AutoSize = true;
            this.casilla1.Location = new System.Drawing.Point(39, 36);
            this.casilla1.Name = "casilla1";
            this.casilla1.Size = new System.Drawing.Size(15, 14);
            this.casilla1.TabIndex = 4;
            this.casilla1.UseVisualStyleBackColor = true;
            this.casilla1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // casilla2
            // 
            this.casilla2.AutoSize = true;
            this.casilla2.Location = new System.Drawing.Point(84, 36);
            this.casilla2.Name = "casilla2";
            this.casilla2.Size = new System.Drawing.Size(15, 14);
            this.casilla2.TabIndex = 5;
            this.casilla2.UseVisualStyleBackColor = true;
            // 
            // casilla3
            // 
            this.casilla3.AutoSize = true;
            this.casilla3.Location = new System.Drawing.Point(133, 35);
            this.casilla3.Name = "casilla3";
            this.casilla3.Size = new System.Drawing.Size(15, 14);
            this.casilla3.TabIndex = 6;
            this.casilla3.UseVisualStyleBackColor = true;
            // 
            // casilla4
            // 
            this.casilla4.AutoSize = true;
            this.casilla4.Location = new System.Drawing.Point(182, 35);
            this.casilla4.Name = "casilla4";
            this.casilla4.Size = new System.Drawing.Size(15, 14);
            this.casilla4.TabIndex = 7;
            this.casilla4.UseVisualStyleBackColor = true;
            // 
            // casilla5
            // 
            this.casilla5.AutoSize = true;
            this.casilla5.Location = new System.Drawing.Point(237, 36);
            this.casilla5.Name = "casilla5";
            this.casilla5.Size = new System.Drawing.Size(15, 14);
            this.casilla5.TabIndex = 8;
            this.casilla5.UseVisualStyleBackColor = true;
            // 
            // casilla6
            // 
            this.casilla6.AutoSize = true;
            this.casilla6.Location = new System.Drawing.Point(289, 36);
            this.casilla6.Name = "casilla6";
            this.casilla6.Size = new System.Drawing.Size(15, 14);
            this.casilla6.TabIndex = 9;
            this.casilla6.UseVisualStyleBackColor = true;
            // 
            // casilla7
            // 
            this.casilla7.AutoSize = true;
            this.casilla7.Location = new System.Drawing.Point(349, 35);
            this.casilla7.Name = "casilla7";
            this.casilla7.Size = new System.Drawing.Size(15, 14);
            this.casilla7.TabIndex = 10;
            this.casilla7.UseVisualStyleBackColor = true;
            // 
            // casilla8
            // 
            this.casilla8.AutoSize = true;
            this.casilla8.Location = new System.Drawing.Point(417, 35);
            this.casilla8.Name = "casilla8";
            this.casilla8.Size = new System.Drawing.Size(15, 14);
            this.casilla8.TabIndex = 11;
            this.casilla8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.casilla1);
            this.groupBox1.Controls.Add(this.casilla8);
            this.groupBox1.Controls.Add(this.casilla2);
            this.groupBox1.Controls.Add(this.casilla7);
            this.groupBox1.Controls.Add(this.casilla3);
            this.groupBox1.Controls.Add(this.casilla6);
            this.groupBox1.Controls.Add(this.casilla4);
            this.groupBox1.Controls.Add(this.casilla5);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equivalente en Binario";
            // 
            // frmejercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmejercicios";
            this.Text = "frmejercicios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.CheckBox casilla1;
        private System.Windows.Forms.CheckBox casilla2;
        private System.Windows.Forms.CheckBox casilla3;
        private System.Windows.Forms.CheckBox casilla4;
        private System.Windows.Forms.CheckBox casilla5;
        private System.Windows.Forms.CheckBox casilla6;
        private System.Windows.Forms.CheckBox casilla7;
        private System.Windows.Forms.CheckBox casilla8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}