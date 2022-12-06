using System;

namespace Heist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set;}
        public int SkillLevel { get; set;}
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is using their golden toothpick to disable the vault lock. Decreased vault score by {SkillLevel} points.");
            if (bank.VaultScore < 0)
            {
                Console.WriteLine($"{Name} has cracked the lock!");
            }
        }
    }
}