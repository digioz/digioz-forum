namespace digioz.Forum.Helpers
{
    public class StringHelper
    {
        public string GenerateRandomPassword()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 16)  // Generate a 16-character password
                .Select(s => s[random.Next(s.Length)])
                .ToArray());
        }
    }
}
