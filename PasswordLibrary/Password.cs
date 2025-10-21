using System.Text.RegularExpressions;

namespace PasswordLibrary
{
    public static class Password
    {
        public static bool IsPasswordValidate(string password)
            => password.Length >= 8 && Regex.IsMatch(password, @"^*\d+[a-z]+[A-Z]+[\W]");

        public static bool IsVibe() => throw new NotImplementedException();
    }
}
