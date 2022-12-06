using System;

namespace Heist
{
    public class Muscle : IRobber
    {
        public string Name { get; }
        public int SkillLevel { get; }
        public int PercentageCut { get; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is using their big muscles to disable the bank guards. Decreased vault score by {SkillLevel} points.");
            if (bank.VaultScore < 0)
            {
                Console.WriteLine($"{Name} has cracked the lock!");
            }
        }
    }
}