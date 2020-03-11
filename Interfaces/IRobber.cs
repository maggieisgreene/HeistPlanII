namespace HeistPlanII
{
  public interface IRobber
  {
    string Name { get; set; }
    string Specialty { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }

    public void PerformSkill(Bank Bank)
    {

    }
  }
}