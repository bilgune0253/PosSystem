using System;
using PosLibrary.Data;
using PosLibrary.Services;

class Program
{
    static void Main(string[] args)
    {
        string dbPath = "pos.db"; // current folder дээр pos.db үүсгэнэ  
        var dbInitializer = new DatabaseInitializer(dbPath);
        dbInitializer.Initialize();

        // Ensure the Database class is properly referenced  
        var db = new PosLibrary.Data.Database(dbPath);
        var userService = new UserService(db);

        

        // === Хэрэглэгчээс нэвтрэх мэдээлэл авах ===
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = ReadPassword(); // доороо бичсэн функц ашиглана

        // === Нэвтрэх шалгалт ===
        var user = userService.Login(username, password);
        if (user != null)
            Console.WriteLine($"\n✅ Logged in as {user.Username} ({user.Role})");
        else
            Console.WriteLine("\n❌ Login failed.");
    }

    // Password-ийг далдалж оруулах (**** гэж харуулдаггүй) функц
    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(intercept: true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*"); // * тэмдэг гаргаж өгнө
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b"); // нэг тэмдэг арилгах
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }
}
