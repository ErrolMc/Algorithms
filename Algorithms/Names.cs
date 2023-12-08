
namespace Algorithms
{
    public static class Names
    {
        static List<string> firstNames = new List<string>
        {
            "Emma", "Liam", "Olivia", "Noah", "Ava", "Isabella", "Sophia", "Jackson", "Lucas", "Mia",
            "Ethan", "Amelia", "Harper", "Evelyn", "Abigail", "Ella", "Alexander", "Henry", "Daniel", "Aiden",
            "Matthew", "Joseph", "Benjamin", "Charlotte", "Scarlett", "Madison", "Aria", "Grace", "Chloe", "Zoe",
            "Nora", "Lily", "Lillian", "Avery", "Sofia", "Jackson", "Lucas", "Aiden", "Oliver", "Muhammad",
            "Elijah", "James", "Liam", "Emma", "Olivia", "Sophia", "Ava", "Mia", "Isabella", "Riley", "Aria",
            "Zoe", "Amelia", "Lily", "Emily", "Layla", "Madelyn", "Hannah", "Aaliyah", "Evelyn", "Harper",
            "Grace", "Chloe", "Avery", "Sofia", "Ellie", "Scarlett", "Penelope", "Zoey", "Mila", "Genesis",
            "Luna", "Stella", "Ariana", "Leah", "Violet", "Nova", "Hazel", "Aurora", "Savannah", "Audrey",
            "Brooklyn", "Bella", "Claire", "Skylar", "Lucy", "Paisley", "Everly", "Anna", "Caroline", "Sarah"
        };

        static List<string> lastNames = new List<string>
        {
            "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
            "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
            "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King",
            "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter",
            "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins",
            "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey",
            "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez",
            "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross",
            "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington"
        };

        public static string RandomName()
        {
            Random random = Program.Random;

            string first = firstNames[random.Next(firstNames.Count)];
            string last = lastNames[random.Next(lastNames.Count)];

            return first + " " + last;
        }
    }
}
