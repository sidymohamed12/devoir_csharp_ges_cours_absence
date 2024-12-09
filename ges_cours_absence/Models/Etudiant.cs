namespace ges_cours_absence.Models
{
    public class Etudiant
    {
        public int Id { get; set; }
        public string Matricule { get; set; }
        public string NomComplet { get; set; }
        public string Adresse { get; set; }

        public List<Inscription>? Inscriptions { get; set; } = new List<Inscription>();
        public List<Absence>? Absences { get; set; } = new List<Absence>();
    }
}