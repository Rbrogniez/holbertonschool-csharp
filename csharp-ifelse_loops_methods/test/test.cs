 #!/bin/bash
  2
  3 # Créer le répertoire dotnet s'il n'existe pas
  4 mkdir -p $HOME/dotnet
  5
  6 # Extraire le contenu de l'archive dotnet dans le répertoire dotnet
  7 tar zxf dotnet-sdk-2.1.818-linux-x64.tar.gz -C $HOME/dotnet
  8
  9 # Définir la variable d'environnement DOTNET_ROOT
 10 export DOTNET_ROOT=$HOME/dotnet
 11
 12 # Ajouter dotnet au PATH
 13 export PATH=$PATH:$HOME/dotnet    
