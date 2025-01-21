# Guide de Lancement de l'Application HeatPro HoloLens

## Prérequis
- Un PC avec Visual Studio installé
- Une HoloLens connectée au même réseau Wi-Fi que le PC

## Étapes de Déploiement

### 1. Ouvrir le projet
1. Ouvrir le dossier `Solution` à la racine du projet.
2. Ouvrir le fichier `QrCodeReader.sln` avec Visual Studio.

### 2. Configuration de Visual Studio
3. Configurer Visual Studio pour HoloLens :
   - Sélectionner la configuration `Master`.
   - Choisir l'architecture `ARM64`.  
   ![Capture d'écran](image.jpg)
4. Dans le menu de sélection de la cible de déploiement, choisir `Ordinateur Distant`.

### 3. Paramétrage de la connexion
5. Ouvrir l'onglet `Projet` > `Propriétés`.
6. Dans `Propriétés de configurations`, sélectionner `Débogage`.
7. Renseigner l'adresse IPV4 de l'HoloLens dans `Nom de l'ordinateur` (trouvable dans l'Hololens `Paramètres` > `Réseau et Internet` > `...`.
8. Définir le mode d'authentification sur `Universel (Protocol non chiffré)`.
9. Appliquer puis valider.

### 4. Lancer l'application
10. S'assurer que le PC et l'HoloLens sont connectés au même réseau Wi-Fi.
11. Sélectionner `Déboguer` > `Executer sans déboguage`.
12. Patienter le temps du déploiement.

### 5. Pairage avec l'HoloLens (premier déploiement uniquement)
13. Lors du premier déploiement, une demande de PIN apparaîtra. Pour en générer un :
    - Sur l'HoloLens, aller dans `Paramètres` > `Mises à jour & Sécurité` > `Pour les développeurs`.
    - Sélectionner `Coupler` pour afficher le PIN.
    - Saisir le PIN dans Visual Studio et finaliser le pairage.

### 6. Utilisation de l'application
14. Patienter le temps du déploiement.
15. L'application devrait maintenant être lancée.
16. Scanner un QR Code généré par l'application HeatPro (de très près pour un bon fonctionnement).

-> Une page web contenant la fiche constructeur de la machine en intervention devrait s'ouvrir !

