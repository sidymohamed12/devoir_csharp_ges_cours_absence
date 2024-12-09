namespace ges_cours_absence.Models
{
    public class Professeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Specialite { get; set; }
        public string Grade { get; set; }

        public List<Cours>? Cours { get; set; } = new List<Cours>();
    }
}