namespace API.Models
{
    public class Presentation
    {
        public string Name { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Location { get; set; } = string.Empty;

        public Presentation(string name, DateTime fromDate, DateTime toDate, string location)
        {
            Name = name;
            FromDate = fromDate;
            ToDate = toDate;
            Location = location;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Presentation other)
            {
                // only name, because it's the only thing that can be used to identify a presentation
                return Name == other.Name;
            }
            return false;
        }

        // Overrides for HashSet
        public override int GetHashCode()
        {
            // only name, because it's the only thing that can be used to identify a presentation
            return Name.GetHashCode();
        }
    }
}
