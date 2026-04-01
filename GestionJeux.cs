class GestionJeux
{
    private List<JeuVideo> listeJeux = new List<JeuVideo>();

    //methode pour ajouter

    public void AjoutJeu(JeuVideo jeu)
    {
        listeJeux.Add(jeu);
    }

    //methode pour supprimer un jeu
    public void SupprimeJeu(JeuVideo jeu)
    {
        listeJeux.Remove(jeu);
    }

    //methode pour afficher les jeux=

    public void AfficheJeux()
    {
        foreach (JeuVideo jeu in listeJeux)
        {
            Console.WriteLine("---");
            Console.WriteLine("Titre: " + jeu.Titre);
            Console.WriteLine("Studio: " + jeu.Studio);
            Console.WriteLine("Prix: " + jeu.Prix);
        }
    }

    //methode permettant de sauvegarder la liste dans un fichier csv
    public void SauvegardeCSV(string nomFichier)
    {
        using (StreamWriter sw = new StreamWriter(nomFichier))
        {
            foreach (JeuVideo jeu in listeJeux)
            {
                sw.WriteLine($"{jeu.Titre};{jeu.Studio};{jeu.Prix}");
            }
        }
    }

    //methode pour verifier si ficher existe
    public bool FichierExiste(string nomFichier)
    {
        return File.Exists(nomFichier);
    }
}