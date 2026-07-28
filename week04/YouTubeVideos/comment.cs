// Ce fichier contient la classe "Comment".
// Sa seule responsabilité : stocker le nom de la personne
// qui a commenté, et le texte du commentaire.

using System;

public class Comment
{
    // Champs privés : les données sont protégées, accessibles
    // seulement via les propriétés publiques ci-dessous.
    private string nom;
    private string texte;

    // Constructeur : crée un commentaire avec un nom et un texte.
    public Comment(string nom, string texte)
    {
        this.nom = nom;
        this.texte = texte;
    }

    // Propriété publique en lecture seule pour accéder au nom.
    public string GetNom()
    {
        return nom;
    }

    // Propriété publique en lecture seule pour accéder au texte.
    public string GetTexte()
    {
        return texte;
    }
}