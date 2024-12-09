using ges_cours_absence.Data;
using ges_cours_absence.Models;

public static class SeedData
{

    public static void Initialize(IServiceProvider serviceProvider, ApplicationDbContext context)
    {
        if (context.Classes.Any() || context.Cours.Any() || context.Professeurs.Any())
        { return; }
        var professeur1 = new Professeur
        {
            Nom = "Dupont",
            Prenom = "Jean",
            Specialite = "Mathematiques",
            Grade = "Professeur",
        };
        var professeur2 = new Professeur
        {
            Nom = "Martin",
            Prenom = "Pierre",
            Specialite = "Physique",
            Grade = "Maître de Conférences",
        };

        context.Professeurs.AddRange(professeur1, professeur2);
        context.SaveChanges();

        var classe1 = new Classe
        {
            Libelle = "Classe A",
            Filiere = "Informatique"
        };
        var classe2 = new Classe
        {
            Libelle = "Classe B",
            Filiere = "Biologie"
        };

        context.Classes.AddRange(classe1, classe2);
        context.SaveChanges();

        var cours1 = new Cours
        {
            Module = "Mathématiques Avancées",
            Date = DateTime.UtcNow,
            HeureDebut = TimeSpan.FromHours(8),
            HeureFin = TimeSpan.FromHours(10),
            NombreHeures = 2,
            Semestre = "Semestre 1",
            Professeur = professeur1
        };
        var cours2 = new Cours
        {
            Module = "Physique Générale",
            Date = DateTime.UtcNow,
            HeureDebut = TimeSpan.FromHours(10),
            HeureFin = TimeSpan.FromHours(12),
            NombreHeures = 2,
            Semestre = "Semestre 1",
            Professeur = professeur2
        };

        context.Cours.AddRange(cours1, cours2);
        context.SaveChanges();

        var detailCoursClasse1 = new DetailCoursClasse
        {
            Cours = cours1,
            Classe = classe1
        };
        var detailCoursClasse2 = new DetailCoursClasse
        {
            Cours = cours2,
            Classe = classe2
        };

        context.DetailCoursClasses.AddRange(detailCoursClasse1, detailCoursClasse2);
        context.SaveChanges();

        var etudiant1 = new Etudiant
        {
            Matricule = "ETU001",
            NomComplet = "Ali Diop",
            Adresse = "Dakar, Sénégal"
        };
        var etudiant2 = new Etudiant
        {
            Matricule = "ETU002",
            NomComplet = "Moussa Fall",
            Adresse = "Thiès, Sénégal"
        };

        context.Etudiants.AddRange(etudiant1, etudiant2);
        context.SaveChanges();

        var inscription1 = new Inscription
        {
            Etudiant = etudiant1,
            Classe = classe1,
            AnneeScolaire = 2024
        };
        var inscription2 = new Inscription
        {
            Etudiant = etudiant2,
            Classe = classe2,
            AnneeScolaire = 2024
        };

        context.Inscriptions.AddRange(inscription1, inscription2);
        context.SaveChanges();

        var absence1 = new Absence
        {
            Etudiant = etudiant1,
            Cours = cours1,
            Date = DateTime.UtcNow
        };
        var absence2 = new Absence
        {
            Etudiant = etudiant2,
            Cours = cours2,
            Date = DateTime.UtcNow
        };

        context.Absences.AddRange(absence1, absence2);
        context.SaveChanges();
    }
}