using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Models {
    public class Product {
        public int ProductId { get; set; }
        public int ArticleNumber { get; set; }
        public string ProductName { get; set; }

        private double _ProductPrice;
        public double ProductPrice {
            get { return _ProductPrice; }
            set {
                if (value > 0) {
                    _ProductPrice = value;
                }
            }
        }
        public int Product_Stock { get; set; }

        public Product() : this(0, 0, "", 0.0, 0) { }
        public Product(int product_Id, int article_Number, string product_Name, double product_Price, int product_Stock) {
            ProductId = product_Id;
            ArticleNumber = article_Number;
            ProductName = product_Name;
            ProductPrice = product_Price;
            Product_Stock = product_Stock;
        }
    }
}
