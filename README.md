# Prérequis
* Installer Visual studio Code
* Installer .Net Core SDK 2.2

# Préparation de la structure de la solution
* mkdir isen.DotNet
* cd isen.DotNet
* git init
* touch .gitignore(Ou créer un fichier à partir de VSC)
* puis récupérer un gitignore spécifique à .Net Core

Créer un repository sur GitHub
* git remote add origin https://github.com/AntonnGazagne/isen-.NetCore.git
* faire un commit initial de nos sources:
* * git add .
* * git commit -m "initial commit"
* * git push origin master

* Créer un projet Console, dans un sous-dossier src:
* Créer le dossier src/ et naviguer dedans

* Dans le dossier src, créer isen.DotNet.ConsoleApp et naviguer dedans

* Créer le projet console : dotnet new console

* Créer le fichier solution(.sln):

* naviguer vers la racine du projet

* Créer le fichier .sln: dotnet new sln

* ajouter les différents éléments de la solution à ce projet(projet console)

* * dotnet sln add src/isen.DotNet.ConsoleApp/

* Créer un dossier src/isen.DotNet.Library et naviguer dedans
* Avec la CLI .Net (dont l'interface en ligne de commande,que l'on utilise depuis le début), créer un projet de type 'librairie de classe': 
dotnet new classlib

Référencer ce nouveau projet dans le fichier de solution (.sln)
Depuis la racine: dotnet sln add src/isen.DotNet.Library
