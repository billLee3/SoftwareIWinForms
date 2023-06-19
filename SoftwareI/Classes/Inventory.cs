using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareI.Classes
{
    internal class Inventory
    {
        //Lists for access by functions
        public BindingList<Product> AllProducts { get; set; }
        public BindingList<Part> AllParts { get; set; }

        //Default constructor
        public Inventory()
        {
            AllProducts = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }
        //Initializes the lists
        public Inventory(BindingList<Product> products, BindingList<Part> parts)
        {
            AllProducts = products;
            AllParts = parts;
        }
        
        public void addProduct(Product product)
        {
            AllProducts.Add(product);
        }
       
        public bool deleteProduct(int productID)
        {
            var product = lookupProduct(productID);
            return AllProducts.Remove(product);
        }

        public Product lookupProduct(int productID)
        {
            foreach (Product product in AllProducts)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return new Product();
        }

        public void updateProduct(int productID, Product updatedProduct)
        {
            //looking up the product from the list and saving to a variable
            var product = lookupProduct(productID);
            //Finding the index of the product in the list
            int index = AllProducts.IndexOf(product);
            //If the entry is not in the list then just return. 
            if (index == -1)
            {
                return;
            }
            else
            {
                //Saves over the product in the correct index. Replacing the original entry at the same index
                AllProducts[index] = updatedProduct;
            }
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return new InHouse();
        }

        public bool deletePart(int partID)
        {
            var part = LookupPart(partID);
            return AllParts.Remove(part);
        }


        public void updatePart(int partID, Part updatedPart)
        {
            //Same functionality as the product update but just with the Part List. 
            var part = LookupPart(partID);
            int index = AllParts.IndexOf(part);
            if (index == -1)
            {
                return;
            }
            else
            {
                AllParts[index] = updatedPart;
            }
        }

    }
}
