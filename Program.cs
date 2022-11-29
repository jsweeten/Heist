using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("----------------");
            Console.WriteLine("Please enter your criminal alias:");
            string Alias = Console.ReadLine();
            Console.WriteLine("Enter your level of skill:");
            string Skill = Console.ReadLine();
            Console.WriteLine("What is your team member's courage factor (0.0 - 2.0)?");
            string Courage = Console.ReadLine();

            TeamMember Member1 = new TeamMember(Alias, int.Parse(Skill), double.Parse(Courage));
            Console.WriteLine(Member1.Name + " " + Member1.SkillLevel + " " + Member1.CourageFactor);
        }
    }
}