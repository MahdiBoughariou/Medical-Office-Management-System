-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 04 mai 2025 à 16:50
-- Version du serveur : 10.4.27-MariaDB
-- Version de PHP : 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `cabinet_medical`
--

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE `categorie` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`id`, `nom`) VALUES
(1, 'Antalgiques'),
(2, 'Anti-inflammatoires'),
(3, 'Antibiotiques'),
(4, 'Antiviraux'),
(5, 'Antifongiques'),
(6, 'Antihistaminiques'),
(7, 'Antidépresseurs'),
(8, 'Anxiolytiques'),
(9, 'Antipsychotiques'),
(10, 'Antihypertenseurs'),
(11, 'Diurétiques'),
(12, 'Antidiabétiques'),
(13, 'Hormones'),
(14, 'Vaccins'),
(15, 'Vitamines'),
(16, 'Minéraux'),
(17, 'Antiacides'),
(18, 'Antispasmodiques'),
(19, 'Laxatifs'),
(20, 'Antidiarrhéiques');

-- --------------------------------------------------------

--
-- Structure de la table `consultation`
--

CREATE TABLE `consultation` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `date_consultation` datetime DEFAULT current_timestamp(),
  `questions_reponses` text DEFAULT NULL,
  `maladie` text DEFAULT NULL,
  `remarques` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `categorie_id` int(11) DEFAULT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`id`, `nom`, `categorie_id`, `description`) VALUES
(1, 'Doliprane', 1, 'Antalgique à base de paracétamol, utilisé pour les douleurs légères à modérées et la fièvre.'),
(2, 'Profénid', 2, 'Anti-inflammatoire non stéroïdien (AINS) à base de kétoprofène, utilisé contre les douleurs et inflammations.'),
(3, 'Augmentin', 3, 'Antibiotique combinant amoxicilline et acide clavulanique, utilisé pour les infections bactériennes.'),
(4, 'Tamiflu', 4, 'Antiviral à base d’oseltamivir, utilisé pour traiter et prévenir la grippe.'),
(5, 'Fungizone', 5, 'Antifongique à base d’amphotéricine B, utilisé pour les infections fongiques graves.'),
(6, 'Zyrtec', 6, 'Antihistaminique à base de cétirizine, utilisé contre les allergies.'),
(7, 'Laroxyl', 7, 'Antidépresseur tricyclique à base d’amitriptyline.'),
(8, 'Lexomil', 8, 'Anxiolytique à base de bromazépam, utilisé pour les troubles anxieux.'),
(9, 'Largactil', 9, 'Antipsychotique à base de chlorpromazine, utilisé en psychiatrie.'),
(10, 'Coveram', 10, 'Médicament antihypertenseur combinant périndopril et amlodipine.'),
(11, 'Lasilix', 11, 'Diurétique à base de furosémide, utilisé contre l’hypertension et l’œdème.'),
(12, 'Diamicron', 12, 'Antidiabétique oral à base de gliclazide, utilisé dans le diabète de type 2.'),
(13, 'Lévothyrox', 13, 'Hormone thyroïdienne de substitution à base de lévothyroxine.'),
(14, 'Vaxigrip', 14, 'Vaccin contre la grippe saisonnière.'),
(15, 'Bion 3', 15, 'Complexe multivitaminé et minéraux pour renforcer l’immunité.'),
(16, 'Magné B6', 16, 'Complément alimentaire à base de magnésium et vitamine B6 contre la fatigue.'),
(17, 'Gaviscon', 17, 'Antiacide à base d’alginate, utilisé contre les brûlures d’estomac et le reflux.'),
(18, 'Spasfon', 18, 'Antispasmodique à base de phloroglucinol, utilisé contre les spasmes digestifs.'),
(19, 'Dulcolax', 19, 'Laxatif à base de bisacodyl, utilisé contre la constipation occasionnelle.'),
(20, 'Smecta', 20, 'Antidiarrhéique à base de diosmectite, utilisé pour traiter la diarrhée aiguë.'),
(29, 'abcde', 2, 'pour la toux');

-- --------------------------------------------------------

--
-- Structure de la table `medicament_ordonnance`
--

CREATE TABLE `medicament_ordonnance` (
  `id` int(11) NOT NULL,
  `ordonnance_id` int(11) NOT NULL,
  `medicament_id` int(11) NOT NULL,
  `dose` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

CREATE TABLE `ordonnance` (
  `id` int(11) NOT NULL,
  `consultation_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

CREATE TABLE `patient` (
  `id` int(11) NOT NULL,
  `nom` varchar(100) NOT NULL,
  `prenom` varchar(100) NOT NULL,
  `date_naissance` date NOT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `telephone` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `rdv`
--

CREATE TABLE `rdv` (
  `id` int(11) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `date_rdv` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `username` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`id`, `username`, `password`, `role`) VALUES
(1, 'med', 'med123', 'medecin'),
(2, 'sec', 'sec123', 'secretaire');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `categorie`
--
ALTER TABLE `categorie`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `consultation`
--
ALTER TABLE `consultation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_medicament_categorie` (`categorie_id`);

--
-- Index pour la table `medicament_ordonnance`
--
ALTER TABLE `medicament_ordonnance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `ordonnance_id` (`ordonnance_id`),
  ADD KEY `medicament_id` (`medicament_id`);

--
-- Index pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD PRIMARY KEY (`id`),
  ADD KEY `consultation_id` (`consultation_id`);

--
-- Index pour la table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD PRIMARY KEY (`id`),
  ADD KEY `patient_id` (`patient_id`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `categorie`
--
ALTER TABLE `categorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pour la table `consultation`
--
ALTER TABLE `consultation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT pour la table `medicament_ordonnance`
--
ALTER TABLE `medicament_ordonnance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT pour la table `patient`
--
ALTER TABLE `patient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT pour la table `rdv`
--
ALTER TABLE `rdv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `consultation`
--
ALTER TABLE `consultation`
  ADD CONSTRAINT `consultation_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD CONSTRAINT `fk_medicament_categorie` FOREIGN KEY (`categorie_id`) REFERENCES `categorie` (`id`);

--
-- Contraintes pour la table `medicament_ordonnance`
--
ALTER TABLE `medicament_ordonnance`
  ADD CONSTRAINT `medicament_ordonnance_ibfk_1` FOREIGN KEY (`ordonnance_id`) REFERENCES `ordonnance` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `medicament_ordonnance_ibfk_2` FOREIGN KEY (`medicament_id`) REFERENCES `medicament` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `ordonnance_ibfk_1` FOREIGN KEY (`consultation_id`) REFERENCES `consultation` (`id`) ON DELETE CASCADE;

--
-- Contraintes pour la table `rdv`
--
ALTER TABLE `rdv`
  ADD CONSTRAINT `rdv_ibfk_1` FOREIGN KEY (`patient_id`) REFERENCES `patient` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
