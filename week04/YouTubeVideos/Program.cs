// Ce fichier est le point d'entrée du programme.
// Il crée les vidéos et leurs commentaires, les ajoute à une liste,
// puis affiche toutes les informations pour chaque vidéo.
// Il n'y a aucune interaction utilisateur, comme demandé.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Liste qui contiendra toutes les vidéos.
        List<Video> videos = new List<Video>();

        // --- Vidéo 1 ---
        Video video1 = new Video("Analyse technique EUR/USD", "TraderMax", 620);
        video1.AjouterCommentaire(new Comment("Sophie", "Super explication, merci !"));
        video1.AjouterCommentaire(new Comment("Jean", "Est-ce que ça marche aussi sur GBP/USD ?"));
        video1.AjouterCommentaire(new Comment("Ricardo", "J'ai testé cette stratégie, ça fonctionne bien."));
        videos.Add(video1);

        // --- Vidéo 2 ---
        Video video2 = new Video("Introduction au Smart Money Concept", "FXAcademy", 945);
        video2.AjouterCommentaire(new Comment("Alicia", "Enfin une explication claire du SMC !"));
        video2.AjouterCommentaire(new Comment("Marc", "Tu peux faire une vidéo sur les order blocks ?"));
        video2.AjouterCommentaire(new Comment("Nadia", "Abonnée direct, merci pour le contenu."));
        video2.AjouterCommentaire(new Comment("Kevin", "Ça confirme ce que j'avais appris ailleurs."));
        videos.Add(video2);

        // --- Vidéo 3 ---
        Video video3 = new Video("Gestion du risque en trading", "PipMaster", 780);
        video3.AjouterCommentaire(new Comment("Claudia", "La règle du 1% par trade change tout."));
        video3.AjouterCommentaire(new Comment("Steve", "Merci, ça m'a évité de tout perdre."));
        video3.AjouterCommentaire(new Comment("Farah", "Vidéo très claire et bien structurée."));
        videos.Add(video3);

        // --- Vidéo 4 ---
        Video video4 = new Video("Backtester sa stratégie forex en Python", "CodeAndTrade", 1120);
        video4.AjouterCommentaire(new Comment("Junior", "Ça tombe bien, je fais exactement ça en ce moment."));
        video4.AjouterCommentaire(new Comment("Elisa", "Tu utilises quelle librairie pour les graphiques ?"));
        video4.AjouterCommentaire(new Comment("Tom", "Excellent, j'attendais ce genre de contenu."));
        videos.Add(video4);

        // Boucle qui parcourt chaque vidéo de la liste, une par une.
        foreach (Video video in videos)
        {
            // Affichage des informations de base de la vidéo.
            Console.WriteLine($"Titre : {video.GetTitre()}");
            Console.WriteLine($"Auteur : {video.GetAuteur()}");
            Console.WriteLine($"Durée : {video.GetDuree()} secondes");
            Console.WriteLine($"Nombre de commentaires : {video.GetNombreCommentaires()}");
            Console.WriteLine("Commentaires :");

            // Boucle qui parcourt chaque commentaire de la vidéo actuelle.
            foreach (Comment commentaire in video.GetCommentaires())
            {
                Console.WriteLine($" - {commentaire.GetNom()} : {commentaire.GetTexte()}");
            }

            // Ligne vide pour séparer visuellement chaque vidéo à l'affichage.
            Console.WriteLine();
        }
    }
}