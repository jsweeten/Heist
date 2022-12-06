using System;

namespace Heist
{
    public class Hacker : IRobber
    {
        public string Name { get; }
        public int SkillLevel { get; }
        public int PercentageCut { get; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security by {SkillLevel} points.");
            if (bank.AlarmScore < 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}