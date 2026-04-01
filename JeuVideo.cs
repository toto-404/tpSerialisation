class JeuVideo
{
    private string titre;
    private string studio;
    private double prix;

    //les propriétés pubmliques
    public string Titre
    {

        get { return titre; }
        set { titre = value; }
    }

    public string Studio
    {
        get { return studio; }
        set { studio = value; }
    }

    public double Prix
    {
        get { return prix; }
        set { prix = value; }
    }

    //constructeur vide et constructeur avec paramètres
    public JeuVideo()
    {
        
    }
    public JeuVideo (string titre, string studio, double px)
    {
        this.titre = titre;
        this.studio = studio;
        this.prix =px;
    }

}