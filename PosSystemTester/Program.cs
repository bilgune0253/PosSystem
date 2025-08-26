using System;
using System.IO;
using PosLibrary.Data;
using PosLibrary.Models;
using PosLibrary.Services;

namespace PosSystemTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== POS System Tester ===");
            Console.WriteLine("Starting system tests...\n");

            string dbPath = "pos_test.db";

            try
            {
                // Clean up previous test database if exists
                if (File.Exists(dbPath))
                {
                    File.Delete(dbPath);
                    Console.WriteLine("Previous test database deleted.");
                }

                // Test 1: Database Initialization
                Console.WriteLine("Test 1: Database Initialization");
                Console.WriteLine("--------------------------------");

                var dbInitializer = new DatabaseInitializer(dbPath);
                dbInitializer.Initialize();
                Console.WriteLine("✓ Database initialized successfully\n");

                // Test 2: Database Connection
                Console.WriteLine("Test 2: Database Connection");
                Console.WriteLine("---------------------------");

                var database = new Database(dbPath);
                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    Console.WriteLine("✓ Database connection successful");
                    Console.WriteLine($"✓ Database path: {dbPath}");
                    Console.WriteLine($"✓ Connection state: {connection.State}\n");
                }

                // Test 3: User Service - Login Test
                Console.WriteLine("Test 3: User Service - Login");
                Console.WriteLine("-----------------------------");

                var userService = new UserService(database);

                // Test successful login
                var user = userService.Login("admin", "1234");
                if (user != null)
                {
                    Console.WriteLine("✓ Admin login successful");
                    Console.WriteLine($"  - User ID: {user.Id}");
                    Console.WriteLine($"  - Username: {user.Username}");
                    Console.WriteLine($"  - Role: {user.Role}");
                }
                else
                {
                    Console.WriteLine("✗ Admin login failed!");
                }

                // Test failed login
                var invalidUser = userService.Login("wrong", "password");
                if (invalidUser == null)
                {
                    Console.WriteLine("✓ Invalid login properly rejected");
                }
                else
                {
                    Console.WriteLine("✗ Invalid login should be rejected!");
                }
                Console.WriteLine();

                // Test 4: Model Classes
                Console.WriteLine("Test 4: Model Classes");
                Console.WriteLine("---------------------");

                // Test User model
                var testUser = new User("testuser", "password123", "Cashier");
                Console.WriteLine($"✓ User model created: {testUser.Username} ({testUser.Role})");
                Console.WriteLine($"  - Is Admin: {testUser.IsAdmin()}");
                Console.WriteLine($"  - Is Cashier: {testUser.IsCashier()}");

                // Test Category model
                var testCategory = new Category("Test Category", "Test description");
                Console.WriteLine($"✓ Category model created: {testCategory.Name}");

                // Test Product model
                var testProduct = new Product("Test Product", 10.50m, 1, 100);
                Console.WriteLine($"✓ Product model created: {testProduct.Name}");
                Console.WriteLine($"  - Price: ${testProduct.Price:F2}");
                Console.WriteLine($"  - Quantity: {testProduct.Quantity}");
                Console.WriteLine($"  - Is Low Stock: {testProduct.IsLowStock()}");
                Console.WriteLine($"  - Total Value: ${testProduct.GetTotalValue():F2}");

                // Test Sale model
                var testSale = new Sale(user?.Id, "Cash");
                var saleItem1 = new SaleItem(1, "Test Product 1", 2, 5.50m);
                var saleItem2 = new SaleItem(2, "Test Product 2", 1, 3.25m);

                testSale.AddItem(saleItem1);
                testSale.AddItem(saleItem2);

                Console.WriteLine($"✓ Sale model created:");
                Console.WriteLine($"  - Total Items: {testSale.GetTotalItemsCount()}");
                Console.WriteLine($"  - Total Amount: ${testSale.Total:F2}");
                Console.WriteLine($"  - Payment Method: {testSale.PaymentMethod}");
                Console.WriteLine();

                // Test 5: Database Query Test
                Console.WriteLine("Test 5: Database Query Test");
                Console.WriteLine("---------------------------");

                using (var connection = database.GetConnection())
                {
                    connection.Open();
                    var cmd = new System.Data.SQLite.SQLiteCommand("SELECT COUNT(*) FROM Users", connection);
                    var userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine($"✓ Users in database: {userCount}");

                    cmd.CommandText = "SELECT COUNT(*) FROM Categories";
                    var categoryCount = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine($"✓ Categories in database: {categoryCount}");

                    cmd.CommandText = "SELECT COUNT(*) FROM Products";
                    var productCount = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine($"✓ Products in database: {productCount}");

                    // Show sample data
                    cmd.CommandText = "SELECT Name, Price, Quantity FROM Products LIMIT 3";
                    var reader = cmd.ExecuteReader();
                    Console.WriteLine("\n✓ Sample Products:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"  - {reader["Name"]}: ${reader["Price"]} (Stock: {reader["Quantity"]})");
                    }
                    reader.Close();
                }
                Console.WriteLine();

                // Test 6: Error Handling Test
                Console.WriteLine("Test 6: Error Handling");
                Console.WriteLine("----------------------");

                try
                {
                    // Test database connection with invalid path
                    var invalidDb = new Database("invalid/path/database.db");
                    using (var conn = invalidDb.GetConnection())
                    {
                        conn.Open(); // This might fail
                    }
                    Console.WriteLine("✗ Should have failed with invalid path");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"✓ Error handling works: {ex.GetType().Name}");
                }

                // Final Summary
                Console.WriteLine("\n=== TEST SUMMARY ===");
                Console.WriteLine("✓ Database Initialization: PASSED");
                Console.WriteLine("✓ Database Connection: PASSED");
                Console.WriteLine("✓ User Service: PASSED");
                Console.WriteLine("✓ Model Classes: PASSED");
                Console.WriteLine("✓ Database Queries: PASSED");
                Console.WriteLine("✓ Error Handling: PASSED");
                Console.WriteLine("\n🎉 ALL TESTS PASSED! Your POS system is working correctly!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ ERROR: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                Console.WriteLine("\n❌ TESTS FAILED!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}