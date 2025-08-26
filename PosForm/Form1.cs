using MainDisplay;
using PosLibrary.Data;
using PosLibrary.Services;
using ManagerDisplay;
namespace PosForm
{
    public partial class Form1 : Form
    {
        private string dbPath = @"C:\Users\bilguun\source\repos\PosSystem\PosSystem\bin\Debug\net8.0\pos.db";

        public Form1()
        {
            InitializeComponent();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUserName.Text;
            string password = txtPassword.Text;

            var db = new Database(dbPath);
            var userService = new UserService(db);

            var user = userService.Login(username, password);
            if (user != null)
            {
                // Role-г шалгах
                if (user.Username == "manager")
                {
                    MessageBox.Show("Амжилттай нэвтэрлээ! (Manager)");

                    var mainForm = new ManagerDisplay.Form1();
                    mainForm.Show();
                    this.Hide();
                }
                else if (user.Role.ToLower() == "seller")
                {
                    MessageBox.Show("Амжилттай нэвтэрлээ! (Seller)");

                    // Seller-д зориулсан өөр form байх бол энд нээх
                    var mainForm = new MainDisplay.Form1();  // эсвэл SellerForm
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Тодорхойгүй рольтой хэрэглэгч!");
                }
            }
            else
            {
                MessageBox.Show("Хэрэглэгчийн нэр эсвэл нууц үг буруу байна!");
            }
        }
    }
}
