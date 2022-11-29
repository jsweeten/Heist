using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {

        static void Main(string[] args)
        {
            string Alias = "member";
            int numOfMembers = 0;
            List<TeamMember> Members = new List<TeamMember>();
            int TeamSkillLevel = 0;
            Random rnd = new Random();
            int luck = rnd.Next(-10, 10);
            int BankDifficulty = 100 + luck;

            while (Alias != "")
            {

                Console.WriteLine("Plan your heist!");
                Console.WriteLine("----------------");
                Console.WriteLine("Please enter your criminal alias:");
                Alias = Console.ReadLine();
                if (Alias == "")
                {
                    break;
                }
                Console.WriteLine("Enter your level of skill:");
                string Skill = Console.ReadLine();
                Console.WriteLine("What is your team member's courage factor (0.0 - 2.0)?");
                string Courage = Console.ReadLine();

                TeamMember Member = new TeamMember(Alias, int.Parse(Skill), double.Parse(Courage));
                Console.WriteLine(Member.Name + " " + Member.SkillLevel + " " + Member.CourageFactor);



                Members.Add(Member);
                numOfMembers++;
            }
            Console.WriteLine($"There are {numOfMembers}");

            foreach (TeamMember Member in Members)
            {
                TeamSkillLevel += Member.SkillLevel;
            }
            Console.WriteLine(TeamSkillLevel);
            Console.WriteLine(BankDifficulty);
            if (TeamSkillLevel > BankDifficulty)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("JAIL");
            }
            // foreach (TeamMember Member in Members)
            //     {
            //         Console.WriteLine($"Name: {Member.Name}\n Skill Level: {Member.SkillLevel}\n Courage Factor: {Member.CourageFactor}" );
            //     }
        }
    }
}