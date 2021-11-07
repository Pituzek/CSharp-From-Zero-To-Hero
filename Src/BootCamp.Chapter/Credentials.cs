namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public struct Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string name, string password)
        {
            Username = name;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {

            credentials = default;
            return false;
        }
    }

    //public readonly struct PersonData
    //{
    //    public readonly string Username;
    //    public readonly string Password;

    //    public PersonData(string username, string password)
    //    {
    //        Username = username;
    //        Password = password;
    //    }
    //}


}
