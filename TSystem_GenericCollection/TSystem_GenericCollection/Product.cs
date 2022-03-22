using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_GenericCollection
{
    class Product
    {
        private int code;
        private string p_name;
        private double price;


        public Product(int code,string p_name,double price)
        {
            this.code = code;
            this.p_name = p_name;
            this.price = price;
        }
        public override string ToString()
        {
            return code+" "+p_name+" "+price;
        }

    }
}
