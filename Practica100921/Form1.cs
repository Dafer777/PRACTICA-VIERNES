using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica100921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetProduct_Click(object sender, EventArgs e)
        {
            selectsProductname();
        }

        //metodo para recuperar los nombres de los productos
        private void selectsProductname()
        {
            //query
            List<string> productList = (
                from product in Product.GetProducts()
                select product.productName
                ).ToList();

            //recorrer la coleccion y llenar el listBox
            foreach (var product in productList)
                lstProductsNames.Items.Add(product);
        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            //fill datagridview
            //add coluns
            dgAllProducts.Columns.Add("codProduct", "CODIGO PRODUCTO");
            dgAllProducts.Columns.Add("name", "NOMBRE");
            dgAllProducts.Columns.Add("descripcion", "DESCRIPCION");
            dgAllProducts.Columns.Add("precio", "PRECIO DE COMPRA");
            dgAllProducts.Columns.Add("category", "CATEGORIA");

            foreach (var product in selectAllProducts())
            {
                //llenar el datagriedview
                dgAllProducts.Rows.Add(product.codProduct, product.productName, product.productDescription,
                    product.buyPrice,product.Category);
            }
        }

        //OBTENER LOS PRODUCTOS
        private List<Product> selectAllProducts()
        {
            List<Product> getAllProducts = (
                from Product in Product.GetProducts()
                select new Product()
                {
                    codProduct = Product.codProduct,
                    productName = Product.productName,
                    productDescription = Product.productDescription,
                    buyPrice = Product.buyPrice,
                    Category = Product.Category
                }
                    ).ToList();
            return getAllProducts;
        }
    }
}
