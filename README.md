# XamarinGestNer
Application android réalisé en C# à l'aide de Xamarin

I – Présentation de la situation professionnelle  

 

Le port a fait construire un nouvel entrepôt, qu’il compte louer aux entreprises de déchargement des navires et aux entreprises de transports routiers. Ces entreprises sont propriétaires de containeurs et ont la responsabilité de de l’acheminement ou le stockage des marchandises qu’ils contiennent. Le port de Cherbourg veut faire élaborer un logiciel de gestion de l’entrepôt afin de connaître, en temps réel, les emplacements occupés, les emplacements disponibles, le nombre de containers et le taux de remplissage… Ces fonctionnalités ne sont pas implémentées dans le logiciel existant GEscale. 

 

Mon travail lors de ce projet est de mettre en place un applicatif Android, permettant pour chacun des propriétaires de containeurs, de visualiser en temps-réel ses containers en cours de stockage dans un l’entrepôt avec pour information : L’emplacement, le numéro, la date de stockage ainsi que le code pays du container. 

 

II – Description de l’environnement de réalisation  

Environnement de développement   

TFS (Team Foundation Server) nous a permis la gestion des différentes versions de l’application ainsi que la répartition des taches de chaque membre l’équipe.  

L’application Android a été créé sur Visual Studio à l’aide du Framework Xamarin en C# et axml pour pouvoir créer le visuel de l’applicatif Android. Cette applicatif Android est associé à une base de données local SQLite et à terme, permettra une réplication en temps réel entre la base de donnée locale SQLite et SQL server en ligne. 

 

Environnement de production  

A terme l’application pourra être déployée sur les mobiles Android des propriétaires de containers. 

  

III – Production réalisées   

A partir de la documentation technique et du cahier des charges des implémentations à apporter, mon travail a consisté à :  

 

    Faire une Maquette  

    Mise en place d’une architecture modèle en couche de l’applicatif 

    Mise en place d’une base de données locale SQLite 

    Implémentation de la vue selon les données chargées à partir de la base de données locale SQLite 

    Mise en place de test unitaire 
    
    
    Maquette de l'application :
    
     
