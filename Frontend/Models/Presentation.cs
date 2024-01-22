namespace Frontend.Models
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
                return Name == other.Name && FromDate == other.FromDate && ToDate == other.ToDate && Location == other.Location;
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
