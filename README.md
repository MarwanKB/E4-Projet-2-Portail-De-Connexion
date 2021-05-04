# PORTAIL DE CONNEXION 
## Présentation 
Le but de ce programme consiste à proposer à l'utilisateur d'effectuer une inscription ou de se connecter. Les Données saisies seront stockés sur la BASE DE DONNEE

LE SCRIPT SE TROUVE DANS : c:/utilisateurs/mboubchir/repos/source/generationMDP

## L'INSCRIPTION : 

L'utilisateur devra entré un PSEUDO, et un mot de passe qu'il devra confirmer.
Les deux mots de passes entrés seront comparés s'ils sont identiques l'insertion à la base de donnée s'effectuera
Dans le cas échéant, un message d'erreur s'affichera l'informant que la saisie du mot de passe est incorrect

BASE DE DONNEE :
Tout sera stocké sur la base de donnée.
L'utilisateur possedera un ID (Auto incrémenté)
Un NomD'utilisateur
Un MotDePasse (Crypté en SHA256)

Lors de l'insertion la saisie du mot de passe sera récupérée, puis sera crypté en SHA256

## LA CONNEXION 
Pour la connexion la fenêtre comporte 2 zone de saisie et un bouton validé
L'utilisateur entrera son Identifiant et son mot de passe.
Le mot de passe est récupéré, Crypté puis comparé avec le Mot de Passe stocké dans la base de donnée.
Si les données saisies sont correctes, la connexion s'établie. 
Dans le cas contraire : Les champs sont éffacés et un message s'affiche indiquant à l'utilisateur que la connexion n'a pas pu aboutir.
