using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIWebApplication.data
{
    public class Repository
    {
        public User GetUser(string word)
        {
            using(var client = new WebClient())
            {
                client.Headers["User-Agent"] = "anything";
                try
                {
                    string result = client.DownloadString($"https://api.github.com/users/{word}");

                    User user = JsonConvert.DeserializeObject<User>(result);
                    client.Headers["User-Agent"] = "anything";
                    string result2 = client.DownloadString($"https://api.github.com/users/{word}/repos");
                    user.Repos = JsonConvert.DeserializeObject<List<Repos>>(result2);
                    return user;
                }
                catch
                {
                    return null;
                }
                
            }
            
        }
    }
}
