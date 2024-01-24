# Donde esta la biblioteca

## Sujet 

Vous allez réaliser une petite application qui vous permettra de gérer une liste de bibliothèque ayant des livres à louer.
Une petite BDD sera jointe au projet qu'on va essayer d'enrichir au maximum.
L'idée est d'être en autonomie par Groupe de 2.

Le but du projet est de voir un maximum de choses que .NET peut vous apporter donc n'hésitez pas à demander au prof.

### Critère de qualité

- Indentation
- En Anglais ou en Français mais garder la même logique tout du long
- Nommage :
  - "Singulier" pour un objet simple et "Pluriel" pour une liste 
  - PascalCase : Pour les noms de classe et interface...
  - camelCase : Pour les variables
  - _camelCase : Pour les variables déclaré au niveau de la classe

## TODO

### Etape 1 :

Créer une application console nommé LibraryManager. N'oubliez pas d'ajouter le nuget : Microsoft.Extensions.Hosting
Et mettre en place son architecture de projets (ClassLibrary) :
- BusinessLayer
- Services
- BusinessObjects
- DataAccessLayer

PS : Votre projet créer avec la solution fait office de StartUp

Créer une méthode Main dans le `Program.cs` grâce aux recommandations VS.


### Ressources

- StackOverflow
- Doc Microsoft

### Raccourcis utiles 

- Recommandation VS : `Alt + Entrée`
- Renommer un élément et ses références : `(Hold) CTRL + R + R`
- Créer une propriété : `(Write) prop + Tab`
- Créer un constructeur: `(Write) ctor + Tab`
- Redirection sur la classe concernée : `F12`
- Redirection sur la classe concrète concernée : `Ctrl + F12`
- Afficher le contenu de l'élément dans un encart : `Alt + F12`
- Lancer en Debug : `F5`
- Faire continuer le programme : `F5`
- Instruction suivante : `F10`
- Instruction suivante dans la méthode : `F11`
