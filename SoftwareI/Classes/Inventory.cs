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
        public BindingList<Product> AllProducts { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            AllProducts = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }
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
            var product = lookupProduct(productID);
            int index = AllProducts.IndexOf(product);
            if (index == -1)
            {
                return;
            }
            else
            {
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
