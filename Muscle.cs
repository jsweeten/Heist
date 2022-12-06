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
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is using their golden toothpick to disable the vault lock. Decreased vault score by 50 points.");
            if (bank.VaultScore < 0)
            {
                Console.WriteLine($"{Name} has cracked the lock!");
            }
        }
    }
}