namespace ges_cours_absence.Models
{
    public class Inscription
    {
        public int Id { get; set; }
        public int AnneeScolaire { get; set; }
        public Etudiant Etudiant { get; set; }

        public Classe Classe { get; set; }
    }
}