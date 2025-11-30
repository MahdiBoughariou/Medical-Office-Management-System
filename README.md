# Système de Gestion de Cabinet Médical 🏥

Ce projet est une solution complète de gestion pour un cabinet médical. Il se compose d'une **application Desktop** pour le personnel médical (médecin et secrétaire) et d'une **interface Web** permettant aux patients de consulter leurs rendez-vous.

> **Projet académique - 2ème année Génie Logiciel**
> **Auteur :** Mahdi Boughariou

---

## 📑 Table des matières
- [Aperçu du projet](#aperçu-du-projet)
- [Fonctionnalités](#fonctionnalités)
  - [Application Desktop](#application-desktop)
  - [Application Web](#application-web)
- [Architecture & Base de données](#architecture--base-de-données)
- [Technologies utilisées](#technologies-utilisées)
- [Installation et Configuration](#installation-et-configuration)
- [Captures d'écran](#captures-décran)

---

## Aperçu du projet

Le système vise à informatiser les processus quotidiens d'un cabinet médical. Il permet une gestion sécurisée des dossiers patients, la planification des rendez-vous, la gestion des stocks de médicaments, et la création de consultations avec ordonnances automatisées.

Le projet est divisé en deux modules principaux :
1. **GestionCabinetVf** : Application Windows Forms (.NET) pour la gestion interne.
2. **GestionCabinetWeb** : Application ASP.NET Core MVC pour l'accès patient.

---

## Fonctionnalités

### 🖥️ Application Desktop (GestionCabinetVf)

L'application sécurise l'accès via une page de connexion (`Login`) et redirige l'utilisateur selon son rôle (Secrétaire ou Médecin).

#### Espace Secrétaire
* **Gestion des Patients** : Ajouter, modifier, supprimer et rechercher des patients (par nom ou téléphone).
* **Gestion des Rendez-vous** : Planifier des rendez-vous, visualiser la liste, modifier les dates ou annuler.

#### Espace Médecin
Le médecin dispose des mêmes droits que la secrétaire pour les patients, avec des fonctionnalités médicales supplémentaires :
* **Gestion des Médicaments** :
    * Ajout de médicaments avec catégorie (Antibiotiques, Antalgiques, etc.) et description.
    * Recherche et gestion du stock.
* **Gestion des Consultations** :
    * Création de consultations liées à un patient.
    * Saisie des détails (Maladie, Symptômes, Remarques).
    * **Génération d'ordonnances** : Ajout de médicaments à la consultation avec dosage spécifique.
* **Historique** : Visualisation de l'historique complet des consultations et des prescriptions passées.

### 🌐 Application Web (GestionCabinetWeb)

Une interface responsive et simple pour les patients :
* **Authentification simple** : Le patient saisit son numéro de téléphone.
* **Consultation de statut** :
    * Si un rendez-vous est prévu : Affiche la date et l'heure.
    * Si aucun rendez-vous futur : Affiche la date du dernier rendez-vous passé.
    * Gestion des erreurs (ex: "Patient non trouvé").

---

## Architecture & Base de données

Le projet repose sur une base de données relationnelle SQL (`cabinet_medical.sql`).

**Principales tables :**
* `utilisateur` (Gestion des rôles et login)
* `patient` (Informations personnelles)
* `rdv` (Rendez-vous liés aux patients)
* `medicament` & `categorie`
* `consultation` & `ordonnance`
* `medicament_ordonnance` (Table de liaison pour les doses prescrites)

---

## Technologies utilisées

* **Langage** : C#
* **Desktop** : .NET Framework (Windows Forms)
* **Web** : ASP.NET Core MVC
* **Base de données** : MySQL / MariaDB (via XAMPP/WAMP)
* **Outils** : Visual Studio, SQL Server Management Studio (ou phpMyAdmin)

---

## Installation et Configuration

### 1. Base de données
1.  Assurez-vous d'avoir un serveur SGBD (comme MySQL via XAMPP).
2.  Créez une base de données nommée `cabinet_medical`.
3.  Importez le fichier `cabinet_medical.sql` fourni dans ce dépôt pour créer les tables et les données initiales.

### 2. Application Desktop (GestionCabinetVf)
1.  Ouvrez la solution dans **Visual Studio**.
2.  Vérifiez la chaîne de connexion (Connection String) dans le fichier de configuration (`App.config` ou dans le code `DbContext`) pour qu'elle corresponde à votre serveur local.
3.  Compilez et lancez le projet.

### 3. Application Web (GestionCabinetWeb)
1.  Ouvrez le dossier `GestionCabinetWeb` dans Visual Studio ou VS Code.
2.  Configurez la chaîne de connexion dans `appsettings.json`.
3.  Lancez l'application via IIS Express ou la CLI `dotnet run`.

---

## Captures d'écran
Retrouvez le détail complet des interfaces dans le fichier `Rapport.pdf` inclus dans ce dépôt.

---
**Réalisé par :** Mahdi Boughariou
