using Microsoft.EntityFrameworkCore;
using WinFormsApp.Core;
using WinFormsApp.Models;

namespace WinFormsApp.Forms
{
    public partial class MainForm : Form
    {
        private AppDbContext dbContext = new AppDbContext();

        public MainForm()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Пароль");
            dataGridView1.Columns.Add("LastName", "Фамилия");
            dataGridView1.Columns.Add("FirstName", "Имя");
            dataGridView1.Columns.Add("MiddleName", "Отчество");
            dataGridView1.Columns.Add("DateOfBirth", "Дата рождения");
            dataGridView1.Columns.Add("Gender", "Пол");
            dataGridView1.Columns.Add("Email", "Адрес электронной почты");
            dataGridView1.Columns.Add("Phone", "Номер телефона");
            dataGridView1.Columns.Add("City", "Город проживания");
            dataGridView1.Columns.Add("Street", "Улица");
            dataGridView1.Columns.Add("House", "Дом");
            dataGridView1.Columns.Add("Flat", "Квартира");

            UpdateData();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            dataGridView1.Rows.Clear();

            User[] users = dbContext.Users
                .Include(x => x.Gender)
                .Include(x => x.City)
                .ToArray();

            foreach (User user in users)
            {
                object[] values = new object[]
                {
                    user.Id,
                    user.Login,
                    user.Password,
                    user.LastName,
                    user.FirstName,
                    user.MiddleName,
                    user.DateOfBirth,
                    user.Gender.Title,
                    user.Email,
                    user.Phone,
                    user.City.Title,
                    user.Street,
                    user.House,
                    user.Flat
                };

                dataGridView1.Rows.Add(values);
            }
        }
    }
}
