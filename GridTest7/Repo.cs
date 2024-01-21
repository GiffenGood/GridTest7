namespace GridTest.Client;

public static class Repo
{
    static readonly List<Patient> patients = new List<Patient>();

    static Repo()
    {
        string[] firstNames = { "James", "Mary", "John", "Patricia", "Robert", "Jennifer", "Michael", "Linda", "William", "Elizabeth",
            "David", "Barbara", "Richard", "Susan", "Joseph", "Jessica", "Thomas", "Sarah", "Charles", "Karen", "Christopher" };
        string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
            "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin", "Lee" };

        Random rnd = new Random();
        for (int i = 0; i < 21; i++)
        {
            var patient = new Patient
            {
                Id = i + 1,
                FirstName = firstNames[i],
                LastName = lastNames[i],
                DateOfBirth = RandomDateOfBirth(rnd)
            };
            patients.Add(patient);
        }

        static DateTime RandomDateOfBirth(Random rnd)
        {
            int year = rnd.Next(DateTime.Today.Year - 100, DateTime.Today.Year - 18); // Ensure age is at least 18
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);

            return new DateTime(year, month, day);
        }
    }

    public static  Task<List<Patient>> GetPatients()
    {
        return Task.FromResult(patients);
    }
}