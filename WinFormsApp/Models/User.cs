namespace WinFormsApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public int GenderId { get; set; }
        public int CityId { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public City City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int? Flat { get; set; }

        public string Comment { get; set; }
    }
}
