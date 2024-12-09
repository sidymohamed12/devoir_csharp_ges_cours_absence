
namespace ges_cours_absence.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Filiere { get; set; }

        public List<Etudiant>? Etudiants { get; set; } = new List<Etudiant>();
        public List<DetailCoursClasse>? detailCoursClasses { get; set; } = new List<DetailCoursClasse>();
    }
}