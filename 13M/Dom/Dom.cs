using System;
using System.Collections.Generic;

class HiringProcess
{
    static void Main()
    {
        List<Candidate> candidates = new List<Candidate>
        {
            new Candidate { Name = "Иван", ExperienceYears = 5, HasRequiredSkills = true },
            new Candidate { Name = "Анна", ExperienceYears = 1, HasRequiredSkills = false },
            new Candidate { Name = "Олег", ExperienceYears = 3, HasRequiredSkills = true }
        };

        foreach (var candidate in candidates)
        {
            string result = CheckCandidate(candidate);
            Console.WriteLine($"{candidate.Name}: {result}");
        }
    }

    static string CheckCandidate(Candidate candidate)
    {
        if (candidate.ExperienceYears < 2 || !candidate.HasRequiredSkills)
        {
            return "Отклонен";
        }
        return "Приглашен на собеседование";
    }
}

class Candidate
{
    public string Name { get; set; }
    public int ExperienceYears { get; set; }
    public bool HasRequiredSkills { get; set; }
}
