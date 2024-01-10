namespace _174271_Itzel_Xhunaxhi_Flores_Ordaz
{
    partial class Form1
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lbHelloWorld = new System.Windows.Forms.Label();
            this.lbHelloWorld2 = new System.Windows.Forms.Label();
            this.lbHelloWorld3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(333, 268);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(75, 23);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "Click this";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lbHelloWorld
            // 
            this.lbHelloWorld.AutoSize = true;
            this.lbHelloWorld.Location = new System.Drawing.Point(287, 153);
            this.lbHelloWorld.Name = "lbHelloWorld";
            this.lbHelloWorld.Size = new System.Drawing.Size(20, 16);
            this.lbHelloWorld.TabIndex = 1;
            this.lbHelloWorld.Text = "ID";
            this.lbHelloWorld.Click += new System.EventHandler(this.lbHelloWorld_Click);
            // 
            // lbHelloWorld2
            // 
            this.lbHelloWorld2.AutoSize = true;
            this.lbHelloWorld2.Location = new System.Drawing.Point(287, 187);
            this.lbHelloWorld2.Name = "lbHelloWorld2";
            this.lbHelloWorld2.Size = new System.Drawing.Size(115, 16);
            this.lbHelloWorld2.TabIndex = 2;
            this.lbHelloWorld2.Text = "Nombre completo";
            this.lbHelloWorld2.Click += new System.EventHandler(this.lbHelloWorld2_Click);
            // 
            // lbHelloWorld3
            // 
            this.lbHelloWorld3.AutoSize = true;
            this.lbHelloWorld3.Location = new System.Drawing.Point(287, 221);
            this.lbHelloWorld3.Name = "lbHelloWorld3";
            this.lbHelloWorld3.Size = new System.Drawing.Size(52, 16);
            this.lbHelloWorld3.TabIndex = 3;
            this.lbHelloWorld3.Text = "Materia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHelloWorld3);
            this.Controls.Add(this.lbHelloWorld2);
            this.Controls.Add(this.lbHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lbHelloWorld;
        private System.Windows.Forms.Label lbHelloWorld2;
        private System.Windows.Forms.Label lbHelloWorld3;
    }
}

