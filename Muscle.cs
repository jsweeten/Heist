using System;

namespace Heist
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set;}
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is using their big muscles to disable the bank guards. Decreased vault score by {SkillLevel} points.");
            if (bank.SecurityGuardScore < 0)
            {
                Console.WriteLine($"{Name} has hogtied the guards!");
            }
        }
    }
}