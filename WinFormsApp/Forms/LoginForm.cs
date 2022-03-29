using WinFormsApp.Core;
using WinFormsApp.Models;

namespace WinFormsApp.Forms
{
    public partial class LoginForm : Form
    {
        private AppDbContext dbContext = new AppDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text) == true)
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) == true)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            User user = dbContext.Users.SingleOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (user == null) // Пользователь не найден
            {
                MessageBox.Show("Неверный логин и/или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show($"Привет, {user.LastName} {user.FirstName} {user.MiddleName}");

            Close();
        }
    }
}
