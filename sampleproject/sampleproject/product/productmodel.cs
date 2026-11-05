using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleproject.product
{
    internal class productmodel
    {
        private string name;
        private string description;
        private float purchaseprice;
        private float saleprice;
        private float discount;

       

        public productmodel()
        {

        }
        public productmodel(string name,string description, float purchaseprice,float saleprice,float discount)
        {
            this.name = name;
            this.description = description;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void setdiscription(string discription)
        {
            this.description = discription;
        } 
        public void setprchase(float  prchase){ 
    }
}
