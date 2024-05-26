using System;
using System.Xml.Linq;

namespace Task5
{
	public class SocialMedia
	{
		Dictionary<string, List<string>> Friends = new();

		public SocialMedia()
		{
            Dictionary<string, List<string>> Friends = new();
        }

		public void AddFriend(string username, List<string> friends)
		{
            Friends.Add(username, friends);

		}
		public void RemoveFriend(string username)
		{
			Friends.Remove(username);
		}

        public void GetAllFriendsByUsername(string username)
        {
            if (Friends.ContainsKey(username))
            {
                foreach (var friend in Friends[username])
                {
                    Console.WriteLine($"{friend}");
                }
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
        }


    }
}

