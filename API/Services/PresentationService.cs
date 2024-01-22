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
            Presentations.Add(new Presentation("Presentation 1", new DateTime(2021, 1, 1), new DateTime(2021, 1, 2), "Location 1"));
            Presentations.Add(new Presentation("Presentation 2", new DateTime(2021, 1, 3), new DateTime(2021, 1, 4), "Location 2"));
            Presentations.Add(new Presentation("Presentation 3", new DateTime(2021, 1, 5), new DateTime(2021, 1, 6), "Location 3"));
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
