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
        public string Role { get; set; } = "Cashier"; // Default role

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        // Constructor
        public User() { }

        public User(string username, string password, string role = "Cashier")
        {
            Username = username;
            Password = password;
            Role = role;
        }

        // Helper methods
        public bool IsAdmin() => Role.Equals("Admin", StringComparison.OrdinalIgnoreCase);
        public bool IsCashier() => Role.Equals("Cashier", StringComparison.OrdinalIgnoreCase);
    }

    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name шаардлагатай")]
        [MinLength(2, ErrorMessage = "Category name хамгийн багадаа 2 тэмдэгт байх ёстой")]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation property
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

        [Range(0.01, double.MaxValue, ErrorMessage = "Үнэ 0-ээс их байх ёстой")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Category сонгох шаардлагатай")]
        public int CategoryId { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Тоо хэмжээ сөрөг байж болохгүй")]
        public int Quantity { get; set; }

        public int MinQuantity { get; set; } = 5; // Low stock warning
        public string? Barcode { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;

        // Navigation properties
        public Category? Category { get; set; }
        public string CategoryName { get; set; } = string.Empty; // For display purposes

        public Product() { }

        public Product(string name, decimal price, int categoryId, int quantity)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
            Quantity = quantity;
        }

        // Helper methods
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

        public int? UserId { get; set; } // Which user made the sale
        public string PaymentMethod { get; set; } = "Cash";

        // Navigation properties
        public User? User { get; set; }
        public List<SaleItem> Items { get; set; } = new List<SaleItem>();

        public Sale() { }

        public Sale(int? userId = null, string paymentMethod = "Cash")
        {
            UserId = userId;
            PaymentMethod = paymentMethod;
        }

        // Helper methods
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
        public string ProductName { get; set; } = string.Empty; // Store product name at time of sale

        [Range(1, int.MaxValue, ErrorMessage = "Тоо хэмжээ 1-ээс их байх ёстой")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Үнэ 0-ээс их байх ёстой")]
        public decimal UnitPrice { get; set; } // Price per unit at time of sale

        public decimal TotalPrice { get; set; } // Quantity * UnitPrice

        // Navigation properties
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

        // Helper methods ss
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

    // Additional helper class for reporting
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

    // Product stock alert class
    public class StockAlert
    {
        public Product Product { get; set; }
        public string AlertType { get; set; } // "Low Stock" or "Out of Stock"
        public DateTime AlertDate { get; set; } = DateTime.Now;

        public StockAlert(Product product, string alertType)
        {
            Product = product;
            AlertType = alertType;
        }
    }
}