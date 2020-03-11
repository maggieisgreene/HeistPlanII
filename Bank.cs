using System.Collections.Generic;
using System.Linq;

namespace HeistPlanII
{
  public class Bank
  {
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }

    public int LeastSecure
    {
      get
      {
        List<int> AllSecurity = new List<int>() { AlarmScore, VaultScore, SecurityGuardScore };
        IEnumerable<int> Insecurity = AllSecurity.OrderBy(number => number);

        return Insecurity.FirstOrDefault();
      }
    }

    public int MostSecure
    {
      get
      {
        List<int> AllSecurity = new List<int>() { AlarmScore, VaultScore, SecurityGuardScore };
        IEnumerable<int> Security = AllSecurity.OrderByDescending(number => number);

        return Security.FirstOrDefault();
      }
    }

    public bool IsSecure
    {
      get
      {
        if (AlarmScore <= 0 || VaultScore <= 0 || SecurityGuardScore <= 0)
        {
          return false;
        }
        else
        {
          return true;
        }
      }
    }
  }
}