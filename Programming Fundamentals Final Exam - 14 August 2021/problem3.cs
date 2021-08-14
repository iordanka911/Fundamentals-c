using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> emails = new Dictionary<string, int>();
            Dictionary<string, int> receivedEmails = new Dictionary<string, int>();
            int capacity = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine()) != "Statistics")
            {

                string[] cmdArgs = command.Split("=");
                string commandName = cmdArgs[0];
                if (commandName == "Add")
                {

                    string user = cmdArgs[1];
                    int sent = int.Parse(cmdArgs[2]);
                    int received = int.Parse(cmdArgs[3]);

                    if (!emails.ContainsKey(user))
                    {
                        emails.Add(user, sent);
                        receivedEmails.Add(user, received);

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandName == "Message")
                {
                    string sender = command.Split("=")[1];
                    string receiver = command.Split("=")[2];
                    if (emails.ContainsKey(sender) && emails.ContainsKey(receiver))
                    {
                        emails[sender]++;
                        receivedEmails[receiver]++;
                        if ((emails[sender] + receivedEmails[sender]) >= capacity)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            emails.Remove(sender);
                            receivedEmails.Remove(sender);
                        }

                        if ((receivedEmails[receiver] + emails[receiver]) >= capacity)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            emails.Remove(receiver);
                            receivedEmails.Remove(receiver);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                else if (commandName == "Empty")
                {
                    string user = command.Split("=")[1];
                    if (user == "All")
                    {
                        emails.Clear();
                        receivedEmails.Clear();
                    }
                    else
                    {
                        if (emails.ContainsKey(user))
                        {
                            emails.Remove((user));
                            receivedEmails.Remove(user);
                        }
                        else
                        {
                            continue;
                            
                        }
                    }
                }
            }
            Console.WriteLine($"Users count: {emails.Count}");
            foreach (var kvp in receivedEmails.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
            {
                string user = kvp.Key;
                int receivedMessagesPerUser = kvp.Value;
                int sentMessagesPerUser = emails[user];
                int sum = sentMessagesPerUser + receivedMessagesPerUser;
                Console.WriteLine($"{user} - {sum}");
            }
        }
    }
}
                
