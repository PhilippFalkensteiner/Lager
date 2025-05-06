using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lager.Models {
    class Product {
        public int Product_Id { get; set; }
        public int Article_Number { get; set; }
        public string Product_Name { get; set; }

        private double _Product_Price;
        public double Product_Price {
            get { return _Product_Price; }
            set {
                if (value > 0) {
                    _Product_Price = value;
                }
            }
        }
        public int Product_Stock { get; set; }

        public Product() : this(0, 0, "", 0.0, 0) { }
        public Product(int product_Id, int article_Number, string product_Name, double product_Price, int product_Stock) {
            Product_Id = product_Id;
            Article_Number = article_Number;
            Product_Name = product_Name;
            Product_Price = product_Price;
            Product_Stock = product_Stock;
        }







    }
}
