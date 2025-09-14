using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PosLibrary.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username шаардлагатай")]
        [MinLength(3, ErrorMessage = "Username хамгийн багадаа 3 тэмдэгт байх ёстой")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password шаардлагатай")]
        [MinLength(4, ErrorMessage = "Password хамгийн багадаа 4 тэмдэгт байх ёстой")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Role шаардлагатай")]
        public string Role { get; set; } = "Cashier";

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        public User() { }

        public User(string username, string password, string role = "Cashier")
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public bool IsAdmin() => Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        public bool IsCashier() => Role.Equals("Cashier", StringComparison.OrdinalIgnoreCase);
    }

    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name shaardlagatai")]
        [MinLength(2, ErrorMessage = "Category name hamgiin bagadaa 2 temdegt baih ystoi!")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public List<Product> Products { get; set; } = new List<Product>();

        public Category() { }

        public Category(string name, string? description = null)
        {
            Name = name;
            Description = description;
        }
    }

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name шаардлагатай")]
        public string Name { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "une ni 0 ees ih baih ystoi")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Category songoh shaardlagatai")]
        public int CategoryId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "too hemjee surug baij bolohgui")]
        public int Quantity { get; set; }

        public int MinQuantity { get; set; } = 5;
        public string? Barcode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        public Category? Category { get; set; }
        public string CategoryName { get; set; } = string.Empty; 

        public Product() { }

        public Product(string name, decimal price, int categoryId, int quantity)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
            Quantity = quantity;
        }

        public bool IsLowStock() => Quantity <= MinQuantity;
        public bool IsOutOfStock() => Quantity == 0;
        public decimal GetTotalValue() => Price * Quantity;
    }

    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [Range(0, double.MaxValue, ErrorMessage = "Нийт дүн сөрөг байж болохгүй")]
        public decimal Total { get; set; }

        public int? UserId { get; set; } 
        public string PaymentMethod { get; set; } = "Cash";

        public User? User { get; set; }
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();

        public Sale() { }

        public Sale(int? userId = null, string paymentMethod = "Cash")
        {
            UserId = userId;
            PaymentMethod = paymentMethod;
        }

        public void CalculateTotal()
        {
            Total = Items.Sum(item => item.TotalPrice);
        }

        public int GetTotalItemsCount()
        {
            return Items.Sum(item => item.Quantity);
        }

        public void AddItem(SaleItem item)
        {
            Items.Add(item);
            CalculateTotal();
        }

        public void RemoveItem(SaleItem item)
        {
            Items.Remove(item);
            CalculateTotal();
        }
    }

    public class SaleItem
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Тоо хэмжээ 1-ээс их байх ёстой")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Үнэ 0-ээс их байх ёстой")]
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice { get; set; } 

        public Sale? Sale { get; set; }
        public Product? Product { get; set; }

        public SaleItem() { }

        public SaleItem(int productId, string productName, int quantity, decimal unitPrice)
        {
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            CalculateTotal();
        }

        public void CalculateTotal()
        {
            TotalPrice = Quantity * UnitPrice;
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
            CalculateTotal();
        }
    }

    public class SalesReport
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalSales { get; set; }
        public int TotalTransactions { get; set; }
        public int TotalItemsSold { get; set; }
        public List<Sale> Sales { get; set; } = new List<Sale>();

        public decimal GetAverageTransactionValue()
        {
            return TotalTransactions > 0 ? TotalSales / TotalTransactions : 0;
        }
    }

    public class StockAlert
    {
        public Product Product { get; set; }
        public string AlertType { get; set; } 
        public DateTime AlertDate { get; set; } = DateTime.Now;

        public StockAlert(Product product, string alertType)
        {
            Product = product;
            AlertType = alertType;
        }
    }
}