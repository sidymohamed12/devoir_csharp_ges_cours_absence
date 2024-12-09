namespace ges_cours_absence.Models
{
    public class DetailCoursClasse
    {
        public int Id { get; set; }
        public int CoursId { get; set; }
        public Cours Cours { get; set; }
        public Classe Classe { get; set; }
    }
}