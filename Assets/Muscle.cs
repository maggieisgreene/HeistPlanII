using System;

namespace HeistPlanII
{
  public class Muscle : IRobber
  {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank Bank)
    {
      Bank.SecurityGuardScore -= SkillLevel;

      if (Bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"{Name} has taken down security guards!");
      }
      else
      {
        Console.WriteLine($"{Name} is working on taking out the security guards. Decreased security {SkillLevel} points!");
      }
    }
  }
}