class GestionJeux
{
    private List <JeuVideo> listeJeux = new List<JeuVideo>();

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
      foreach(JeuVideo jeu in listeJeux)
        {
            Console.WriteLine("---");
            Console.WriteLine("Titre: " + jeu.Titre);
            Console.WriteLine("Studio: " + jeu.Studio);
            Console.WriteLine("Prix: " + jeu.Prix);
        }
    }

}