using System;
using System.Data.SQLite;
using System.IO;

namespace PosLibrary.Data
{
    public class DatabaseInitializer
    {
        private readonly string _dbPath;

        public DatabaseInitializer(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Initialize()
        {
            bool isNewDatabase = false;

            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
                isNewDatabase = true;
                Console.WriteLine("Database file created: " + _dbPath);
            }

            using (var con = new SQLiteConnection($"Data Source={_dbPath}"))
            {
                con.Open();

                // Users table
                string usersTable = @"CREATE TABLE IF NOT EXISTS Users(
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Username TEXT NOT NULL UNIQUE,
                                        Password TEXT NOT NULL,
                                        Role TEXT NOT NULL,
                                        CreatedDate TEXT DEFAULT CURRENT_TIMESTAMP,
                                        IsActive INTEGER DEFAULT 1
                                    );";

                // Categories table
                string categoriesTable = @"CREATE TABLE IF NOT EXISTS Categories(
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL UNIQUE,
                                            Description TEXT,
                                            CreatedDate TEXT DEFAULT CURRENT_TIMESTAMP
                                          );";

                // Products table
                string productsTable = @"CREATE TABLE IF NOT EXISTS Products(
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            Name TEXT NOT NULL,
                                            Price REAL NOT NULL CHECK(Price >= 0),
                                            CategoryId INTEGER,
                                            Quantity INTEGER NOT NULL CHECK(Quantity >= 0),
                                            MinQuantity INTEGER DEFAULT 5,
                                            Barcode TEXT,
                                            CreatedDate TEXT DEFAULT CURRENT_TIMESTAMP,
                                            IsActive INTEGER DEFAULT 1,
                                            FOREIGN KEY(CategoryId) REFERENCES Categories(Id)
                                        );";

                // Sales table
                string salesTable = @"CREATE TABLE IF NOT EXISTS Sales(
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Date TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
                                        Total REAL NOT NULL CHECK(Total >= 0),
                                        UserId INTEGER,
                                        PaymentMethod TEXT DEFAULT 'Cash',
                                        FOREIGN KEY(UserId) REFERENCES Users(Id)
                                      );";

                // SaleItems table
                string saleItemsTable = @"CREATE TABLE IF NOT EXISTS SaleItems(
                                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                            SaleId INTEGER,
                                            ProductId INTEGER,
                                            ProductName TEXT NOT NULL,
                                            Quantity INTEGER CHECK(Quantity > 0),
                                            UnitPrice REAL CHECK(UnitPrice >= 0),
                                            TotalPrice REAL CHECK(TotalPrice >= 0),
                                            FOREIGN KEY(SaleId) REFERENCES Sales(Id),
                                            FOREIGN KEY(ProductId) REFERENCES Products(Id)
                                        );";

                // Create indexes for better performance
                string createIndexes = @"
                    CREATE INDEX IF NOT EXISTS idx_users_username ON Users(Username);
                    CREATE INDEX IF NOT EXISTS idx_products_category ON Products(CategoryId);
                    CREATE INDEX IF NOT EXISTS idx_sales_date ON Sales(Date);
                    CREATE INDEX IF NOT EXISTS idx_saleitems_sale ON SaleItems(SaleId);
                ";

                SQLiteCommand cmd = new SQLiteCommand(usersTable, con);
                cmd.ExecuteNonQuery();
                cmd.CommandText = categoriesTable; cmd.ExecuteNonQuery();
                cmd.CommandText = productsTable; cmd.ExecuteNonQuery();
                cmd.CommandText = salesTable; cmd.ExecuteNonQuery();
                cmd.CommandText = saleItemsTable; cmd.ExecuteNonQuery();
                cmd.CommandText = createIndexes; cmd.ExecuteNonQuery();

                Console.WriteLine("Tables created successfully.");

                // Insert default data only if it's a new database
                if (isNewDatabase)
                {
                    InsertDefaultData(cmd);
                }
            }
        }

        private void InsertDefaultData(SQLiteCommand cmd)
        {
            try
            {
                // Insert default admin user - password should be hashed in real application
                cmd.CommandText = @"INSERT OR IGNORE INTO Users (Username, Password, Role) 
                                   VALUES ('Bilguun','1234','Manager');";
                cmd.ExecuteNonQuery();

                // Insert default categories
                cmd.CommandText = @"INSERT OR IGNORE INTO Categories (Name, Description) 
                                   VALUES ('Drinks', 'Beverages and soft drinks'),
                                          ('Bakery', 'Food items and snacks');";                                         
                cmd.ExecuteNonQuery();

                // Insert default products
                cmd.CommandText = @"INSERT OR IGNORE INTO Products (Barcode, Name, Price, CategoryId, Quantity) 
                                   VALUES ('123456789','Soda', 1500, 1, 100);";
                                         
                cmd.ExecuteNonQuery();

                Console.WriteLine("Default data inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting default data: {ex.Message}");
            }
        }
    }
}