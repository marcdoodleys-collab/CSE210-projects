// Ce fichier contient la classe "Video".
// Sa responsabilité : stocker le titre, l'auteur, la durée,
// et la liste des commentaires laissés sur cette vidéo.

using System;
using System.Collections.Generic;

public class Video
{
    // Champs privés : les données de base de la vidéo.
    private string titre;
    private string auteur;
    private int duree; // en secondes

    // Champ privé : la liste des commentaires liés à cette vidéo.
    // Le type List<Comment> veut dire "une liste d'objets Comment".
    private List<Comment> commentaires;

    // Constructeur : crée une vidéo avec son titre, auteur, et durée.
    // La liste de commentaires est créée vide au départ.
    public Video(string titre, string auteur, int duree)
    {
        this.titre = titre;
        this.auteur = auteur;
        this.duree = duree;
        commentaires = new List<Comment>();
    }

    // Méthode publique : ajoute un commentaire à la liste.
    // L'utilisateur de Video n'a pas besoin de savoir comment
    // la liste est gérée en interne, il appelle juste cette méthode.
    public void AjouterCommentaire(Comment commentaire)
    {
        commentaires.Add(commentaire);
    }

    // Méthode publique : retourne le nombre de commentaires.
    // C'est un exemple simple d'abstraction : au lieu de faire
    // "commentaires.Count" depuis Program.cs, on cache ce détail
    // derrière une méthode nommée clairement.
    public int GetNombreCommentaires()
    {
        return commentaires.Count;
    }

    // Méthodes publiques simples pour accéder aux informations de base.
    public string GetTitre()
    {
        return titre;
    }

    public string GetAuteur()
    {
        return auteur;
    }

    public int GetDuree()
    {
        return duree;
    }

    // Méthode publique : retourne la liste complète des commentaires,
    // pour que Program.cs puisse les afficher un par un.
    public List<Comment> GetCommentaires()
    {
        return commentaires;
    }
}