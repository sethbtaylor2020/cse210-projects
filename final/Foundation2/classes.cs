using System;
using System.Collections.Concurrent;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

class Customer
{
    public string Fname;
    public string Lname;

    public Customer(string fname, string lname)
    {
        Fname = fname;
        Lname = lname;

    }
    public string GetFullName()
    {
        return $"{Fname} {Lname}";
    }
}

class Product
{
    public string Productname;
    public string Productid;
    public int Cost;
    public int Amount;

    public Product(string productname, string productid, int cost, int amount)
    {
        Productname = productname;
        Productid = productid;
        Cost = cost;
        Amount = amount;
    }
        public int GetTotalCost()
        {
            return Cost * Amount;
        }
    }
class PersonAddress
{
    public string Address;
    public bool InUSA;

    public PersonAddress(string address, bool inUSA)
    {
        Address = address;
        InUSA = inUSA;
    }
}

class Order
{
    public Customer Customer;
    public PersonAddress Address;
    public List<Product> Products = new List<Product>();

    public Order(Customer customer, PersonAddress address)
    {
        Customer = customer;
        Address = address;
    }

    //listing out everything
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public int GetTotalCost()
    {
        int total = 0;
        foreach (Product product in Products)
        {
            total += product.GetTotalCost();
        }
        // Add shipping cost
        total += Address.InUSA ? 5 : 35;
        return total;
    }
     public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in Products)
        {
            label += $"- {product.Productname} (ID: {product.Productid})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{Customer.GetFullName()}\n{Address.Address}";
    }
}