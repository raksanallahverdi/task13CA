namespace Task5
{
    public static class Program
    {
        public static void Main()
        {


            SocialMedia linkedin = new SocialMedia();
            linkedin.AddFriend("Raksana", new List<string> { "saalam", "nece", "sen" });
            linkedin.AddFriend("Nezrin", new List<string> { "sagol", "men", "sen" });
            linkedin.RemoveFriend("Raksana");
            linkedin.GetAllFriendsByUsername("Nezrin");
            Console.ReadLine();



        }
    }
}
