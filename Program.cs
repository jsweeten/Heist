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
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(Member.Name + " " + Member.SkillLevel + " " + Member.CourageFactor);
                Console.WriteLine();
                Console.WriteLine();

                Members.Add(Member);
                numOfMembers++;
            }
            Console.WriteLine($"There are {numOfMembers} criminals in your crew");
            Console.WriteLine("How many times would you like to try? (1 - 5)");
            int Trials = int.Parse(Console.ReadLine());

            foreach (TeamMember Member in Members)
            {
                TeamSkillLevel += Member.SkillLevel;
            };

            for (int i = 0; i < Trials; i++)
                {
            Console.WriteLine("Your Crew's Skill Level: " + TeamSkillLevel);
            Random rnd = new Random();
            int luck = rnd.Next(-10, 10);
            int BankDifficulty = 100 + luck;
            Console.WriteLine("Bank Difficulty Level: " + BankDifficulty);
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine();

            if (TeamSkillLevel > BankDifficulty)
            {
                Console.WriteLine("Your Crew Got Away! Success!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Go directly to JAIL. Do not pass go, do not collect $200.");
                Console.WriteLine();
            }
            };
            // foreach (TeamMember Member in Members)
            //     {
            //         Console.WriteLine($"Name: {Member.Name}\n Skill Level: {Member.SkillLevel}\n Courage Factor: {Member.CourageFactor}" );
            //     }
        }
    }
}