using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Git
    {
        public static Credentials Authenticate(string username, string password)
        {
            var basicAuthentication = new Credentials(username, password);
            return basicAuthentication;
        }

        public static Repository CreateRepository(string name, GitHubClient client)
        {
            // Create 
            try
            {
                var repository = new NewRepository(name)
                {
                    AutoInit = false,
                    Description = "",
                    LicenseTemplate = "mit",
                    Private = true
                };
                var newRepository = Task.Run(async () => await client.Repository.Create(repository)).GetAwaiter().GetResult();

                Console.WriteLine("The respository {0} was created.", newRepository.FullName);
                return newRepository;

            }
            catch (AggregateException e)
            {
                Console.WriteLine("Error occured. {0}", e.Message);
                return null;
            }
        }

        public static LinkedList<string> PushExistingRepository(string url)
        {
            LinkedList<string> output = new LinkedList<string>();
            output.AddLast(CommandPrompt.Execute("git remote add origin " + url));
            output.AddLast(CommandPrompt.Execute("git push -u origin master"));
            return output;
        }
    }
}
