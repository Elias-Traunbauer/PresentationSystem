using API.Models;

namespace API.Services
{
    public class PresentationService
    {
        // in-memory storage -> hashset for O(1) access
        public static HashSet<Presentation> Presentations { get; } = new HashSet<Presentation>();

        public PresentationService()
        {
            // add some presentations
            Presentations.Add(new Presentation("SlideLizard Intro", new DateTime(2024, 1, 1), new DateTime(2024, 1, 1), "Besprechnungsraum 1"));
            Presentations.Add(new Presentation("DevOps Intro", new DateTime(2024, 1, 3), new DateTime(2024, 1, 3), "Besprechnungsraum 2B"));
            Presentations.Add(new Presentation("Mittagessen mit Volker Hebsthofer", new DateTime(2024, 1, 7), new DateTime(2024, 1, 7), "Mensa"));
            Presentations.Add(new Presentation("Mittagessen mit Franz Gimplinger", new DateTime(2024, 2, 7), new DateTime(2024, 2, 7), "Mensa"));
            Presentations.Add(new Presentation("Güther See Besprechung", new DateTime(2023, 12, 25), new DateTime(2023, 12, 25), "BSPR01"));
            Presentations.Add(new Presentation("Azure VM Intro", new DateTime(2023, 12, 22), new DateTime(2023, 12, 22), "Besprechnungsraum 2B"));
        }

        /// <summary>
        /// Returns all presentations.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Presentation> GetPresentations()
        {
            return Presentations;
        }

        /// <summary>
        /// Returns a presentation by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Presentation? GetPresentation(string name)
        {
            return Presentations.FirstOrDefault(p => p.Name == name);
        }

        /// <summary>
        /// Adds a presentation to the in-memory storage.
        /// </summary>
        /// <param name="presentation">Presentation to persist</param>
        /// <returns>Whether the presentation was persisted (no duplicate names)</returns>
        public bool AddPresentation(Presentation presentation)
        {
            // add presentation and handle duplicates

            var persisted = Presentations.Add(presentation);

            return persisted;
        }
    }
}
