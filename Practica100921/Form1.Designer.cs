
namespace Practica100921
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
            this.btngetnames = new System.Windows.Forms.Button();
            this.btngetdata = new System.Windows.Forms.Button();
            this.dgAllProducts = new System.Windows.Forms.DataGridView();
            this.lstProductsNames = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btngetnames
            // 
            this.btngetnames.Location = new System.Drawing.Point(42, 169);
            this.btngetnames.Name = "btngetnames";
            this.btngetnames.Size = new System.Drawing.Size(130, 23);
            this.btngetnames.TabIndex = 0;
            this.btngetnames.Text = "GetProductNames()";
            this.btngetnames.UseVisualStyleBackColor = true;
            this.btngetnames.Click += new System.EventHandler(this.GetProduct_Click);
            // 
            // btngetdata
            // 
            this.btngetdata.Location = new System.Drawing.Point(61, 426);
            this.btngetdata.Name = "btngetdata";
            this.btngetdata.Size = new System.Drawing.Size(111, 23);
            this.btngetdata.TabIndex = 1;
            this.btngetdata.Text = "GetAllProducts(";
            this.btngetdata.UseVisualStyleBackColor = true;
            this.btngetdata.Click += new System.EventHandler(this.btngetdata_Click);
            // 
            // dgAllProducts
            // 
            this.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAllProducts.Location = new System.Drawing.Point(210, 352);
            this.dgAllProducts.Name = "dgAllProducts";
            this.dgAllProducts.Size = new System.Drawing.Size(565, 216);
            this.dgAllProducts.TabIndex = 3;
            // 
            // lstProductsNames
            // 
            this.lstProductsNames.FormattingEnabled = true;
            this.lstProductsNames.Location = new System.Drawing.Point(223, 90);
            this.lstProductsNames.Name = "lstProductsNames";
            this.lstProductsNames.Size = new System.Drawing.Size(191, 238);
            this.lstProductsNames.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 597);
            this.Controls.Add(this.lstProductsNames);
            this.Controls.Add(this.dgAllProducts);
            this.Controls.Add(this.btngetdata);
            this.Controls.Add(this.btngetnames);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgAllProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btngetnames;
        private System.Windows.Forms.Button btngetdata;
        private System.Windows.Forms.DataGridView dgAllProducts;
        private System.Windows.Forms.ListBox lstProductsNames;
    }
}

