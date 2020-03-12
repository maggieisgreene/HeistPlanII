using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistPlanII
{
  class Program
  {
    static void Main(string[] args)
    {
      List<IRobber> rolodex = new List<IRobber>();

      rolodex.Add(new Hacker()
      {
        Name = "Spidey",
        SkillLevel = 89,
        PercentageCut = 25
      });

      rolodex.Add(new Muscle()
      {
        Name = "Hulk",
        SkillLevel = 78,
        PercentageCut = 25
      });

      rolodex.Add(new LockSpecialist()
      {
        Name = "Bill Nye",
        SkillLevel = 92,
        PercentageCut = 30
      });

      rolodex.Add(new Muscle()
      {
        Name = "Margot Robbie",
        SkillLevel = 100,
        PercentageCut = 5
      });

      rolodex.Add(new Hacker()
      {
        Name = "Big Bird",
        SkillLevel = 100,
        PercentageCut = 15
      });

      foreach (var robber in rolodex)
      {
        Console.WriteLine($"{robber.Name} is on board with this mission and has a skill level of {robber.SkillLevel}!");
      }

      while (true)
      {
        Console.WriteLine("Enter the name of the robber you'd like to add!");
        var name = Console.ReadLine();
        if (name == "")
        {
          break;
        }

        Console.WriteLine($"Now we need to give {name} an assignment! Choose one of the following.");
        Console.WriteLine("Hacker (Disables Alarms) || Muscle (Disarms Guards) || Lock Specialist (Cracks Vault)");
        var assignment = Console.ReadLine().ToLower();

        Console.Write($"What is {name}'s skill level (1-100)? ");
        var skill = int.Parse(Console.ReadLine());

        Console.Write($"What percentage cut does {name} demand for each mission? ");
        var cut = int.Parse(Console.ReadLine());

        if (assignment.Contains("hacker"))
        {
          rolodex.Add(new Hacker()
          {
            Name = name,
            SkillLevel = skill,
            PercentageCut = cut,
          });
        }
        else if (assignment.Contains("muscle"))
        {
          rolodex.Add(new Muscle()
          {
            Name = name,
            SkillLevel = skill,
            PercentageCut = cut
          });
        }
        else
        {
          rolodex.Add(new LockSpecialist()
          {
            Name = name,
            SkillLevel = skill,
            PercentageCut = cut
          });
        }
      }

      foreach (var robber in rolodex)
      {
        Console.WriteLine($"{robber.Name} is on board with this mission and has a skill level of {robber.SkillLevel}!");
      }

      Random random = new Random();

      var alarm = random.Next(0, 101);
      var vault = random.Next(0, 101);
      var security = random.Next(0, 101);
      var cash = random.Next(50000, 1000000);

      Dictionary<string, int> allScores = new Dictionary<string, int>();
      allScores.Add("Alarm", alarm);
      allScores.Add("Vault", vault);
      allScores.Add("Security Guard", security);

      var leastSecure = allScores.OrderBy(num => num.Value).FirstOrDefault();
      var mostSecure = allScores.OrderByDescending(num => num.Value).FirstOrDefault();

      var bank = new Bank()
      {
        AlarmScore = alarm,
        VaultScore = vault,
        SecurityGuardScore = security,
        CashOnHand = cash
      };

      Console.WriteLine($"Least secure: {leastSecure.Key}");
      Console.WriteLine($"Most secure: {mostSecure.Key}");

      foreach (var robber in rolodex)
      {
        Console.WriteLine($"{rolodex.IndexOf(robber)} | {robber.Name} is a {robber.Specialty}! Skill level is at a whopping {robber.SkillLevel} and wants {robber.PercentageCut}% of the earnings!");
      }

      var crew = new List<IRobber>();
      var crewPercentageCutTotal = 100;

      while (true)
      {
        Console.WriteLine("Enter the number of the robber you'd like to include in your crew!");
        var chosen = Console.ReadLine();

        if (string.IsNullOrEmpty(chosen))
        {
          break;
        }
        else
        {
          var robberIndex = int.Parse(chosen);

          if (robberIndex < rolodex.Count || robberIndex >= 0)
          {
            crew.Add(rolodex[robberIndex]);
          }
        }
      }
    }
  }
}