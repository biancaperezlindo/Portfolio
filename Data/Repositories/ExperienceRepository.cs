using Portfolio.Data;

namespace Portfolio;
    public class ExperienceRepository
    {
        // public List<Experience> Experiences;
        private readonly ApplicationContext _context;
        public ExperienceRepository( ApplicationContext context)
        {
            _context = context;
        }

        public int AddExperience(Experience newExperience)
        {
            _context.Experiences.Add(newExperience);
            _context.SaveChanges();
            return newExperience.Id;
        }

        public List<Experience> GetAll()
        {
            return _context.Experiences.Where(a => a.State == "Active").ToList();
        }

        public Experience? Get(int Id)
        {
            return _context.Experiences.Where(a => a.State == "Active").FirstOrDefault(a => a.Id == Id);
        }

        public bool Delete(int id)
        {
            var experiencesToDelete = _context.Experiences.FirstOrDefault(a => a.Id == id);
            if(experiencesToDelete is not null)
            {
                experiencesToDelete.State = "Deleted";
                _context.Experiences.Update(experiencesToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }