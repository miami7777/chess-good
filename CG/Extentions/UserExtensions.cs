using CG.Domain;
using CG.Helpers;

namespace CG.Extentions
{
    public static class UserExtensions
    {
        public static string GetAge(this ApplicationUser user)
        {
            string ageStr = "возраст не указан";
            
            if (user.DateBirthday != default(DateTime))
            {
                var today = DateTime.Today;
                int age = today.Year - user.DateBirthday.Year;
                if (user.DateBirthday.Date > today.AddYears(-age)) age--;
                ageStr = UserHelper.GetPrefixAge(age);

            }
            return ageStr;
        }

        
    }
}
