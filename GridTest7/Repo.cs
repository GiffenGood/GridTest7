namespace GridTest.Client;

public static class Repo
{
    static readonly List<Patient> patients = new List<Patient>();

    static Repo()
    {
        for (var i = 0; i < 100; i++)
        {
            patients.Add(new Patient
            {
                Id = i,
                FirstName = $"First {i}",
                LastName = $"Last {i}",
                DateOfBirth = DateTime.Now.AddYears(-i * 18)
            });
        }
    }

    public static  Task<List<Patient>> GetPatients()
    {
        return Task.FromResult(patients);
    }
}