namespace ges_cours_absence.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Etudiant Etudiant { get; set; }
        public Cours Cours { get; set; }
    }
}