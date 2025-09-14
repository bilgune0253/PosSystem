using System.Data;
using System.Data.SQLite;
using System.Xml.Linq;
namespace Stock1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=C:\Users\bilguun\source\repos\PosSystem\PosSystem\bin\Debug\net8.0\pos.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
        }
        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Products", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    colId.DataPropertyName = "Id";
                    colBarcode.DataPropertyName = "Barcode";
                    colName.DataPropertyName = "Name";
                    colPrice.DataPropertyName = "Price";
                    colCategoryId.DataPropertyName = "CategoryId";
                    colQuantity.DataPropertyName = "Quantity";

                    dgvStock.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtPrice.Text) ||
                    string.IsNullOrEmpty(txtQty.Text))
                {
                    MessageBox.Show("Бүх талбарыг бөглөнө үү!");
                    return;
                }

                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(
                        "INSERT INTO Products (Barcode, Name, Price, CategoryId, Quantity) VALUES (@Barcode, @Name, @Price, @CategoryId, @Qty)", con);

                    cmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@CategoryId", Convert.ToInt32(txtCategoryId.Text)); 
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQty.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Бүтээгдэхүүн амжилттай нэмэгдлээ!");
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа гарлаа: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
