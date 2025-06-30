using System.Drawing;
using CG.Domain.Entities;
using CG.Domain.Enum;

namespace CG.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string FIO { get; set; }
        public string Age { get; set; }
        public string Avatar { get; set; }
        public string Roles { get; set; }
        public int CoursesCount { get; set; }
        public int WebinarsCount { get; set; }
        public int StudentsCount { get; set; }
        public int Lessons {  get; set; }
        public ChessTitle ChessTitle { get; set; }
        public int Stag {  get; set; }
        public int YearReceiveTitle { get; set; }
        public int Rating { get; set; }
        public bool EmailConfirmed { get; set; }
        public string ProfileLichess { get; set; }
        public string UserName { get; set; }
        public DateTime DateBirthday { get; set; }
        public Sex Sex { get; set; }
        public string Trophy { get; set; }
        public string PhoneNumber { get; set; }
        public LichessUsers? LichessData { get; set; }
        public int PerfsId { get; set; }
        public Perfs Perfs { get; set; }

    }
}
