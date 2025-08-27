using System.Data.SQLite;
using PosLibrary.Models;

namespace PosLibrary.Data
{
    public class ProductRepository
    {
        private readonly Database _database;

        public ProductRepository(Database database)
        {
            _database = database;
        }

        // Бүх барааг авах
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();
                // Таны database-д байгаа багануудаар: Id, Barcode, Name, Price, CategoryId, Quantity
                string sql = @"SELECT p.Id, p.Barcode, p.Name, p.Price, p.CategoryId, 
                              p.Quantity, c.Name AS CategoryName
                              FROM Products p
                              LEFT JOIN Categories c ON p.CategoryId = c.Id";

                using (var command = new SQLiteCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Barcode = reader["Barcode"]?.ToString(),
                            Name = reader["Name"].ToString() ?? "",
                            Price = Convert.ToDecimal(reader["Price"]),
                            CategoryId = Convert.ToInt32(reader["CategoryId"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            IsActive = true, // Default утга (database-д байхгүй тул)
                            CategoryName = reader["CategoryName"]?.ToString() ?? ""
                        };
                        products.Add(product);
                    }
                }
            }
            return products;
        }

        // Нэрээр бараа хайх
        public Product? GetProductByName(string name)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT p.Id, p.Barcode, p.Name, p.Price, p.CategoryId, 
                              p.Quantity, c.Name AS CategoryName
                              FROM Products p
                              LEFT JOIN Categories c ON p.CategoryId = c.Id
                              WHERE p.Name = @name";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Barcode = reader["Barcode"]?.ToString(),
                                Name = reader["Name"].ToString() ?? "",
                                Price = Convert.ToDecimal(reader["Price"]),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                IsActive = true, // Default утга
                                CategoryName = reader["CategoryName"]?.ToString() ?? ""
                            };
                        }
                    }
                }
            }
            return null;
        }

        // ID-аар бараа авах
        public Product? GetProductById(int id)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT p.Id, p.Barcode, p.Name, p.Price, p.CategoryId, 
                              p.Quantity, c.Name AS CategoryName
                              FROM Products p
                              LEFT JOIN Categories c ON p.CategoryId = c.Id
                              WHERE p.Id = @id";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Barcode = reader["Barcode"]?.ToString(),
                                Name = reader["Name"].ToString() ?? "",
                                Price = Convert.ToDecimal(reader["Price"]),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                IsActive = true, // Default утга
                                CategoryName = reader["CategoryName"]?.ToString() ?? ""
                            };
                        }
                    }
                }
            }
            return null;
        }

        // Барааны тоо хэмжээ шинэчлэх
        public bool UpdateProductQuantity(int productId, int newQuantity)
        {
            try
            {
                using (var connection = _database.GetConnection())
                {
                    connection.Open();
                    string sql = "UPDATE Products SET Quantity = @quantity WHERE Id = @id";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@quantity", newQuantity);
                        command.Parameters.AddWithValue("@id", productId);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating product quantity: {ex.Message}");
                return false;
            }
        }

        // Категорийн дагуу бараа авах
        public List<Product> GetProductsByCategory(int categoryId)
        {
            var products = new List<Product>();

            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT p.Id, p.Barcode, p.Name, p.Price, p.CategoryId, 
                              p.Quantity, c.Name AS CategoryName
                              FROM Products p
                              LEFT JOIN Categories c ON p.CategoryId = c.Id
                              WHERE p.CategoryId = @categoryId";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@categoryId", categoryId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var product = new Product
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Barcode = reader["Barcode"]?.ToString(),
                                Name = reader["Name"].ToString() ?? "",
                                Price = Convert.ToDecimal(reader["Price"]),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                IsActive = true, // Default утга
                                CategoryName = reader["CategoryName"]?.ToString() ?? ""
                            };
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        // Barcod-оор бараа хайх (нэмэлт функц)
        public Product? GetProductByBarcode(string barcode)
        {
            using (var connection = _database.GetConnection())
            {
                connection.Open();
                string sql = @"SELECT p.Id, p.Barcode, p.Name, p.Price, p.CategoryId, 
                              p.Quantity, c.Name AS CategoryName
                              FROM Products p
                              LEFT JOIN Categories c ON p.CategoryId = c.Id
                              WHERE p.Barcode = @barcode";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@barcode", barcode);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Product
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Barcode = reader["Barcode"]?.ToString(),
                                Name = reader["Name"].ToString() ?? "",
                                Price = Convert.ToDecimal(reader["Price"]),
                                CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                IsActive = true, // Default утга
                                CategoryName = reader["CategoryName"]?.ToString() ?? ""
                            };
                        }
                    }
                }
            }
            return null;
        }
    }
}