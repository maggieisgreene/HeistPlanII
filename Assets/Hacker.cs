using System;

namespace HeistPlanII
{
  public class Hacker : IRobber
  {
    public string Name { get; set; }
    public string Specialty { get; set; } = "hacker";
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill(Bank Bank)
    {
      Bank.AlarmScore -= SkillLevel;

      if (Bank.AlarmScore <= 0)
      {
        Console.WriteLine($"{Name} has successfully disabled the alarm!");
      }
      else
      {
        Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points!");
      }
    }
  }
}