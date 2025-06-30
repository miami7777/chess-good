namespace CG.Helpers
{
    public static class UserHelper
    {
        public static string GetPrefixAge(int age)
        {
            string ageStr;
            if (age.ToString().EndsWith("5") || age.ToString().EndsWith("6") || age.ToString().EndsWith("7") || age.ToString().EndsWith("8") || age.ToString().EndsWith("9") || age.ToString().EndsWith("0"))
            {
                ageStr = $"{age} лет";
            }
            else
                            if (age.ToString().EndsWith("2") || age.ToString().EndsWith("3") || age.ToString().EndsWith("4"))
            {
                ageStr = $"{age} года";
            }
            else
            {
                ageStr = $"{age} год";
            }

            return ageStr;
        }
        public static string GenString(int len) 
        {
            var template = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringId = "";
            for (var i = 0; i<len; i++) {
                Random rnd = new Random();
                var randomNum = rnd.Next(0, template.Length-1);
                stringId += template[randomNum];
            }
            return stringId;
        }
    }
}
