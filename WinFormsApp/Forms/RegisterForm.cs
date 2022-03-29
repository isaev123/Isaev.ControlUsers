using WinFormsApp.Core;
using WinFormsApp.Models;

namespace WinFormsApp.Forms
{
    public partial class RegisterForm : Form
    {
        private AppDbContext dbContext = new AppDbContext();

        public RegisterForm()
        {
            InitializeComponent();

            Gender[] genders = dbContext.Genders.ToArray();
            foreach (Gender gender in genders)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Id = gender.Id;
                item.Title = gender.Title;

                comboBoxGender.Items.Add(item);
            }

            comboBoxGender.SelectedIndex = 0;

            City[] cities = dbContext.Cities.ToArray();
            foreach (City city in cities)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Id = city.Id;
                item.Title = city.Title;

                comboBoxCity.Items.Add(item);
            }

            comboBoxCity.SelectedIndex = 0;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) == true)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            User user = new User();
            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;

            user.LastName = textBoxLastName.Text;
            user.FirstName = textBoxFirstName.Text;
            user.MiddleName = textBoxMiddleName.Text;

            user.DateOfBirth = dateTimePickerDateOfBirth.Value.ToUniversalTime();
            user.GenderId = (comboBoxGender.SelectedItem as ComboBoxItem).Id;

            user.Email = textBoxEmail.Text;
            user.Phone = textBoxPhone.Text;

            user.CityId = (comboBoxCity.SelectedItem as ComboBoxItem).Id;
            user.Street = textBoxStreet.Text;
            user.House = textBoxHouse.Text;

            if (string.IsNullOrWhiteSpace(textBoxFlat.Text) == true)
            {
                user.Flat = null;
            }
            else
            {
                user.Flat = int.Parse(textBoxFlat.Text);
            }

            user.Comment = textBoxComment.Text;

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            MessageBox.Show($"Вы успешно зарегистрировались!");

            Close();
        }

        private class ComboBoxItem
        {
            public int Id { get; set; }
            public string Title { get; set; }

            public override string ToString()
            {
                return Title;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
