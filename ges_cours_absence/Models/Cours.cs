namespace ges_cours_absence.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Module { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public int NombreHeures { get; set; }
        public string Semestre { get; set; }
        public Professeur Professeur { get; set; }

        public List<DetailCoursClasse>? detailCoursClasses { get; set; } = new List<DetailCoursClasse>();
        public List<Absence>? Absences { get; set; } = new List<Absence>();
    }
}