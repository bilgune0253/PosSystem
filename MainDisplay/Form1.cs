using PosLibrary.Data;
using PosLibrary.Models;
using System.Data;

namespace MainDisplay
{
    public partial class Form1 : Form
    {
        private Database _database;
        private ProductRepository _productRepository;
        private DataTable _cartDataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            SetupDataGridView();
        }
        private void InitializeDatabase()
        {
            try
            {
                // Database файлын FULL PATH - таны pos.db файлын яг зам
                string dbPath = @"C:\Users\bilguun\source\repos\PosSystem\PosSystem\bin\Debug\net8.0\pos.db"; // ЭНД ТАНЫ ФАЙЛЫН ЗАМ БИЧНЭ ҮҮ

                // Эсвэл таны project folder дор байгаа бол:
                // string dbPath = @"C:\Users\YourUsername\source\repos\PosSystem\bin\Debug\pos.db";

                // Database холболт үүсгэх
                _database = new Database(dbPath);
                _productRepository = new ProductRepository(_database);

                // Database initialize хийх (шинэ файл үүсгэх хэрэггүй бол энэ хэсгийг comment хий)
                // var initializer = new DatabaseInitializer(dbPath);
                // initializer.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database холболтод алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupDataGridView()
        {
            // DataTable үүсгэх сагсны өгөгдлөөр - таны design-ийн column нэрүүдтэй яг тохируулна
            _cartDataTable = new DataTable();
            _cartDataTable.Columns.Add("ProductId", typeof(int));
            _cartDataTable.Columns.Add("Name", typeof(string));           // Header: Name
            _cartDataTable.Columns.Add("Quantity", typeof(int));          // Header: Quantity  
            _cartDataTable.Columns.Add("UnitPrice", typeof(decimal));     // Header: UnitPrice
            _cartDataTable.Columns.Add("Total", typeof(decimal));         // Header: Total

            // DataGridView тохируулах
            if (dataGridView1 != null)
            {
                dataGridView1.DataSource = _cartDataTable;

                // ProductId багана нуух
                if (dataGridView1.Columns["ProductId"] != null)
                    dataGridView1.Columns["ProductId"].Visible = false;

                // Баганы тохиргоо - таны design дээрх нэрүүдтэй яг тохирно
                if (dataGridView1.Columns["Name"] != null)
                {
                    dataGridView1.Columns["Name"].Width = 350;
                    dataGridView1.Columns["Name"].ReadOnly = true;
                }

                if (dataGridView1.Columns["Quantity"] != null)
                {
                    dataGridView1.Columns["Quantity"].Width = 250;
                    dataGridView1.Columns["Quantity"].ReadOnly = false; // Edit хийж болно
                }

                if (dataGridView1.Columns["UnitPrice"] != null)
                {
                    dataGridView1.Columns["UnitPrice"].Width = 250;
                    dataGridView1.Columns["UnitPrice"].DefaultCellStyle.Format = "N0"; // Тоо форматлах
                    dataGridView1.Columns["UnitPrice"].ReadOnly = true;
                }

                if (dataGridView1.Columns["Total"] != null)
                {
                    dataGridView1.Columns["Total"].Width = 250;
                    dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N0"; // Тоо форматлах
                    dataGridView1.Columns["Total"].ReadOnly = true;
                }

                // DataGridView-ийн ерөнхий тохиргоо
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

                // Event handler нэмэх
                dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
                dataGridView1.KeyDown += DataGridView1_KeyDown;
            }
        }
        public void AddProductToCartByName(string productName)
        {
            try
            {
                var product = _productRepository.GetProductByName(productName);
                if (product != null)
                {
                    AddProductToCart(product);
                }
                else
                {
                    MessageBox.Show($"'{productName}' нэртэй бараа олдсонгүй!", "Алдаа",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Барааг хайхад алдаа: {ex.Message}", "Алдаа",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProductToCart(Product product)
        {
            try
            {
                // Сагсанд байгаа эсэхийг шалгах
                var existingRow = _cartDataTable.AsEnumerable()
                    .FirstOrDefault(row => row.Field<int>("ProductId") == product.Id);

                if (existingRow != null)
                {
                    // Байвал тоо хэмжээг нэмэх
                    int currentQuantity = existingRow.Field<int>("Quantity");
                    int newQuantity = currentQuantity + 1;

                    existingRow["Quantity"] = newQuantity;
                    existingRow["Total"] = newQuantity * product.Price;
                }
                else
                {
                    // Шинээр нэмэх
                    var newRow = _cartDataTable.NewRow();
                    newRow["ProductId"] = product.Id;
                    newRow["Name"] = product.Name;
                    newRow["Quantity"] = 1;
                    newRow["UnitPrice"] = product.Price;
                    newRow["Total"] = product.Price;

                    _cartDataTable.Rows.Add(newRow);
                }

                // Нийт дүн тооцоолох
                UpdateTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Барааг сагсанд нэмэхэд алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataRow row in _cartDataTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }

            // Нийт дүнг form дээр харуулах (Label эсвэл TextBox байх ёстой)
            // Жишээ: lblTotalAmount.Text = $"Нийт: ₮{totalAmount:N0}";
            TotalAmountlabel.Text = $"Нийт: ₮{totalAmount:N0}";

        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Quantity")
                {
                    try
                    {
                        var row = _cartDataTable.Rows[e.RowIndex];
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);

                        // Тоо хэмжээ 0-ээс бага байвал устгах
                        if (quantity <= 0)
                        {
                            _cartDataTable.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            row["Total"] = quantity * unitPrice;
                        }

                        UpdateTotalAmount();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Тоо хэмжээ шинэчлэхэд алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            _cartDataTable.Rows.RemoveAt(row.Index);
                        }
                    }
                    UpdateTotalAmount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Мөр устгахад алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ClearCart()
        {
            _cartDataTable.Clear();
            UpdateTotalAmount();
        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            _cartDataTable.Rows.RemoveAt(row.Index);
                        }
                    }
                    UpdateTotalAmount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Мөр устгахад алдаа: {ex.Message}", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Устгах мөрийг сонгоно уу!", "Мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductToCartByName("Croissant");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductToCartByName("Eclair");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProductToCartByName("Choco_mousse");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
