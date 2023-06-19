using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareI.Classes
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductInStock { get; set; }
        public int ProductMin { get; set; }
        public int ProductMax { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }

        //Empty default constructor
        public Product()
        {
            
        }
        public Product(string productname, double productprice, int productinstock, int productmin, int productmax, BindingList<Part> parts)
        {
            ProductID = GlobalConfig.ProductCount;
            ProductName = productname;
            ProductPrice = productprice;
            ProductInStock = productinstock;
            ProductMin = productmin;
            ProductMax = productmax;
            AssociatedParts = parts;
        }

        public Product(int productID, string productname, double productprice, int productinstock, int productmin, int productmax, BindingList<Part> parts)
        {
            ProductID = productID;
            ProductName = productname;
            ProductPrice = productprice;
            ProductInStock = productinstock;
            ProductMin = productmin;
            ProductMax = productmax;
            AssociatedParts = parts;
        }

        //addProduct
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool deleteAssociatedPart(int partid)
        {
            var part = lookupAssociatedPart(partid);
            return AssociatedParts.Remove(part);
        }

        public Part lookupAssociatedPart(int partid)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partid)
                {
                    return part;
                }
            }
            // return a default value. 
            return new InHouse();
        }

        public void updateAssociatedPart(int partid, Part updatedAssociatedPart)
        {
            //Finding the part by id
            var part = lookupAssociatedPart(partid);

            int index = AssociatedParts.IndexOf(part);
            //if index returns negative one we don't want to update the part
            if (index == -1)
            {
                return;
            }
            else
            {
                // We want to replace the index of the part we looked up via the part id. Replaces the values of the part in the same index. 
                // Could also get around this by locking down the partID numbers as static members assigned at creation. However there would be gaps when removing. 
                AssociatedParts[index] = updatedAssociatedPart;
            }
        }
    }
}
