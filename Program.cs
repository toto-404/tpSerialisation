namespace tpSerialisation;

class Program
{
    static void Main(string[] args)
    {
        //objet gestion jeux
        GestionJeux gestion = new GestionJeux();

        //creation de jeux
        JeuVideo j1 = new JeuVideo("Minecraft", "Mojang", 29.99);
        JeuVideo j2 = new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", 59.99);
        JeuVideo j3 = new JeuVideo("The Witcher 3", "CD Projekt", 39.99);

        //ajout des jeux à la gestion
        gestion.AjoutJeu(j1);
        gestion.AjoutJeu(j2);
        gestion.AjoutJeu(j3);

        //affichage des jeux
        Console.WriteLine("Liste des jeux 🎮🎮🎮:");
        gestion.AfficheJeux();

    }
}
