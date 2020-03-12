using System;

namespace HeistPlanII
{
  public class LockSpecialist : IRobber
  {
    public string Name { get; set; }
    public string Specialty { get; set; } = "lock specialist";
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }
    public void PerformSkill(Bank Bank)
    {
      Bank.VaultScore -= SkillLevel;

      if (Bank.VaultScore <= 0)
      {
        Console.WriteLine($"{Name} has opened the vault doors, finally!");
      }
      else
      {
        Console.WriteLine($"{Name} is picking the locks on the vault. Decreased security {SkillLevel} points!");
      }
    }
  }
}