create database syndic;
go
use syndic;
go
--Creation Et Gestion De Table Type_Utilisateur

create table type_utilisateur
(
id_type int identity ,
nom_type varchar(100) ,
archive bit ,
constraint pk_type_utilisatuer primary key (id_type)

);


go
--Creation Et Gestion De Table Utilisateur

create table utilisateur
(
id_utilisateur int identity ,
login varchar(50) ,
password varchar(150) ,
salt varchar(250) ,
id_type int ,
id_table int ,
archive bit,
constraint pk_utilisateur primary key (id_utilisateur) ,
constraint fk_utilisateur_type foreign key (id_type) references type_utilisateur (id_type)
);


go
--Creation Et Gestion De Table Connexion

create table connexion
(
id_connexion int identity ,
date_connexion date ,
id_utilisateur int ,
archive bit,
constraint pk_connexion primary key (id_connexion) ,
constraint fk_connexion_utilisateur foreign key (id_utilisateur) references utilisateur (id_utilisateur)
);


go
--Creation Et Gestion De Table Journal

create table journal
(
id_journal int identity ,
id_utlisateur int ,
date_action date ,
action varchar(50) ,
table_action varchar(50) ,
anciennes_valeurs text ,
nouvelles_valeurs text ,
archive bit,
constraint pk_journal primary key (id_journal) ,
constraint fk_journal_utilisateur foreign key (id_utlisateur) references utilisateur (id_utilisateur)
);


go
--Creation Et Gestion De Table Message

create table message
(
id_message int identity ,
objet varchar(250) ,
message text ,
fichier varchar(100) ,
date_message date ,
de int ,
archive bit,
constraint pk_message primary key (id_message) ,
constraint fk_message_utilisateur foreign key (de) references utilisateur (id_utilisateur)
);


go
--Creation Et Gestion De Table Message_Utilisateur

create table message_utilisateur
(
id_message int identity ,
a int ,
archive bit,
constraint fk_messageut_message foreign key (id_message) references message (id_message) ,
constraint fk_messageut_utilisateur foreign key (a) references utilisateur (id_utilisateur)
);


go
--Creation Et Gestion De Table Pays

create table pays
(
id_pays int identity ,
nom_pays varchar(50) ,
constraint pk_pays primary key (id_pays)
);


go
--Creation Et Gestion De Table Ville

create table ville
(
id_ville int identity ,
nom_ville varchar(50) ,
id_pays int ,
constraint pk_ville primary key (id_ville) ,
constraint fk_ville_pays foreign key (id_pays) references pays (id_pays)
);

go
--Creation Et Gestion De Table Type_Employe

create table type_employe
(
id_type int identity ,
nom_type varchar(50) ,
archive bit ,
constraint pk_type_emp primary key (id_type)
);

go
--Creation Et Gestion De Table Employe

create table employe
(
id_employe int identity ,
nom varchar(50) ,
prenom varchar(50) ,
adresse varchar(250) ,
code_postal int ,
telephone varchar(20) ,
email varchar(250) ,
num_cnss int ,
actif bit ,
id_ville int ,
id_type_employe int ,
archive bit ,
constraint pk_employe primary key (id_employe) ,
constraint fk_employe_ville foreign key (id_ville) references ville (id_ville) ,
constraint fk_employe_type foreign key (id_type_employe) references type_employe (id_type)
);

go
--Creation Et Gestion De Table Contrat

create table contrat
(
id_contrat int identity ,
id_employe int ,
date_debut date ,
date_fin date ,
salaire money ,
archive bit ,
constraint pk_contrat primary key (id_contrat) ,
constraint fk_contrat_employe foreign key (id_employe) references employe (id_employe)
);

go
--Creation Et Gestion De Table Document_Employe

create table document_employe
(
id_document int identity ,
nom varchar(200) ,
fichier varchar(200) ,
id_employe int ,
archive bit ,
constraint pk_document_emp primary key (id_document) ,
constraint fk_documnet_employe foreign key (id_employe) references employe (id_employe)
);

go
--Creation Et Gestion De Table Remarque_Employe

create table remarque_employe
(
id_remarque int identity ,
nom varchar(200) ,
remarque text ,
id_employe int ,
archive bit ,
constraint pk_remarque primary key (id_remarque) ,
constraint fk_remarque_employe foreign key (id_employe) references employe (id_employe)
);

go
--Creation Et Gestion De Table Conge_Employe

create table conge_employe
(
id_conge int identity ,
id_employe int ,
date_sortie date ,
date_entree date ,
archive bit ,
constraint pk_conge primary key (id_conge) ,
constraint fk_conge_employe foreign key (id_employe) references employe (id_employe)
);


go
--Creation Et Gestion De Table Absence_employe

create table absence_employe
(
id_absence int identity ,
id_employe int ,
date_absence date ,
archive bit ,
constraint pk_absence_employe primary key (id_absence) ,
constraint fk_absenceEmp_Employe foreign key (id_employe) references employe (id_employe)
);

go
--Creation Et Gestion De Table Repos_employe

create table repos_employe
(
id_repos int identity ,
id_employe int ,
nb_jour int ,
jours varchar(200) ,
archive bit ,
constraint pk_repos primary key (id_repos) ,
constraint fk_repos_employe foreign key (id_repos) references employe (id_employe)
);


go
--Creation Et Gestion De Table Residence

create table residence
(
id_residence int identity ,
nom varchar(150) ,
adresse varchar(150) ,
code_postal int ,
id_ville int ,
titrefoncier varchar(200) ,
archive bit ,
constraint pk_residence primary key (id_residence) ,
constraint fk_residence_ville foreign key (id_ville) references ville (id_ville)
);

go
--Creation Et Gestion De Table Type_Recette

create table type_recette
(
id_type int identity ,
nomtype varchar(100) ,
archive bit ,
constraint pk_type_recette primary key (id_type)
);

go
--Creation Et Gestion De Table Recette

create table recette
(
id_recette int ,
montant money ,
id_type int ,
archive bit ,
constraint pk_recette primary key (id_recette) ,
constraint fk_recette_Typerecette foreign key (id_type) references type_recette(id_type)
);

go
--Creation et Gestion De Table Document_Recette

create table document_recette
(
id_document int identity ,
nomDocument varchar(100) ,
ficher varchar(250) ,
id_recette int ,
archive bit ,
constraint pk_documentRecette primary key (id_document) ,
constraint fk_documentRec_recette foreign key (id_recette) references recette (id_recette) 
);

go
--Creation et Gestion De Table Remarque_Recette

create table remarque_recette
(
id_remarque int identity ,
nomRemarqur varchar(100) ,
remarque text ,
id_recette int ,
archive bit ,
constraint pk_remarque_recette primary key (id_remarque) ,
constraint fk_remarqueRec_recette foreign key (id_recette) references recette (id_recette)
);

go
--Creation Et Gestion De Table Immeuble

create table immeuble
(
id_immeuble int identity ,
nom varchar(150) ,
id_residence int ,
titrefoncier varchar(200) ,
paiment varchar(50) , -- il a remplir par mois/annee
archive bit ,
constraint pk_immeuble primary key (id_immeuble) ,
constraint fk_immeuble_residence foreign key (id_residence) references residence (id_residence)
);

go
--Creation Et Gestion De Table Type_Bien

create table type_bien
(
id_type int identity ,
nom varchar(100) ,
archive bit ,
constraint pk_type_bien primary key (id_type)
);

go
--Creation Et Gestion De Table Proprietaire

create table proprietaire
(
id_proprietaire int identity ,
nom varchar(50) ,
prenom varchar(100) ,
adresse varchar(250) ,
code_postale int ,
telephone varchar(20) ,
email varchar(250) ,
id_ville int ,
archive bit ,
constraint pk_proprietaire primary key (id_proprietaire) ,
constraint fk_proprietaire_ville foreign key (id_ville) references ville (id_ville)
);


go
--Creation Et Gestion De Table Type_Cotisation

create table type_cotisation
(
id_type int identity ,
nomType varchar(50) ,
archive bit ,
constraint pk_typeCotisation primary key (id_type)
);

go
--Creation Et Gestion De Table Recette

create table cotisation
(
id_cotisation int identity ,
date_cotisation date ,
montant money ,
id_proprietaire int ,
id_typeCotisation int ,
archive bit ,
constraint pk_cotisation primary key (id_cotisation) ,
constraint fk_cotisation_proprietaire foreign key (id_proprietaire) references proprietaire (id_proprietaire) ,
constraint fk_cotisation_type foreign key (id_typeCotisation) references type_cotisation (id_type)
);

go
--Creation Et Gestion De Table Document_Cotisation

create table document_cotisation
(
id_document int identity ,
nomDocument varchar(200) ,
ficher varchar(250) ,
id_cotisation int ,
archive bit ,
constraint pk_documentCotisation primary key (id_document) ,
constraint fk_document_cotisation foreign key (id_cotisation) references cotisation (id_cotisation)
)

go
--Creation Et Gestion De Table Remarque_Cotisation

create table remarque_cotisation
(
id_remarque int identity ,
nomremarque varchar(200) ,
remarque text ,
id_cotisation int ,
archive bit ,
constraint pk_remarqueCotisation primary key (id_remarque) ,
constraint fk_remarque_cotisation foreign key (id_cotisation) references cotisation (id_cotisation)
);

go
--Creation Et Gestion De Table Conteur_Eau

create table conteur_eau
(
id_conteurEau int identity ,
consomation float ,
date_controle date ,
archive bit ,
constraint pk_conteurEau primary key (id_conteurEau)

);

go
--Creation Et Gestion De Table Bien

create table bien
(
id_bien int identity ,
NomApparetemnt varchar(150) ,
etage int ,
superficie float ,
charges money ,
id_immeuble int ,
id_type_bien int,
id_proprietaire int ,
titrefoncier varchar(200) ,
id_conteurEau int ,
archive bit ,
constraint pk_bien primary key (id_bien) ,
constraint fk_bien_immeuble foreign key (id_bien) references immeuble (id_immeuble) ,
constraint fk_bien_type foreign key (id_type_bien) references type_bien (id_type) ,
constraint fk_bien_proprietaire foreign key (id_proprietaire) references proprietaire (id_proprietaire) ,
constraint fk_bien_conteurEau foreign key (id_conteurEau) references conteur_eau (id_conteurEau)
);

go
--Creation Et Gestion De Table Acquisition

create table acquisition
(
id_bien int ,
id_proprietaire int ,
date_acquisition date ,
archive bit ,
constraint pk_acquisition primary key (id_bien,id_proprietaire) ,
constraint fk_acquisition_bien foreign key (id_bien) references bien(id_bien) ,
constraint fk_acquisition_proprietaire foreign key (id_proprietaire) references proprietaire(id_proprietaire)
);

go

--Creation Et Gestion De Table Echeance

create table echeance
(
id_echeance int identity ,
mois int ,
annee int ,
montant money ,
montant_recu money ,
id_bien int ,
archive bit ,
constraint pk_echeance primary key (id_echeance) ,
constraint fk_echeance_bien foreign key (id_bien) references bien (id_bien)
);

go

--Creation Et Gestion De Table REcette_Echeance

create table cotisation_echeance
(
id_cotisation int ,
id_echeance int ,
archive bit ,

constraint pk_cotisation_echeance primary key (id_cotisation,id_echeance),
constraint fk_cotisationEch_cotisation foreign key (id_cotisation) references cotisation (id_cotisation),
constraint fk_cotisationEch_eheance foreign key (id_echeance) references echeance (id_echeance) 

);

go
--Creation Et Gestion De Table Document_Bien

create table document_bien
(
id_document int identity ,
nom varchar(150) ,
fichier varchar(150) ,
id_bien int ,
archive bit ,
constraint pk_document_bien primary key (id_document) ,
constraint fk_documentBien_bien foreign key (id_bien) references bien (id_bien)
);

go
--Creation Et Gestion De Table Remarque_Bien

create table remarque_bien
(
id_remarque int identity ,
nom varchar(150) ,
remarque text ,
id_bien int ,
archive bit ,
constraint pk_remarque_bien primary key (id_remarque) ,
constraint fk_remarqueBien_bien foreign key (id_bien) references bien (id_bien)
);

go
--Creation Et Gestion De Table Type_Facture

create table type_paiement
(
id_type int identity ,
nom varchar(50) ,
archive bit ,
constraint pk_type_paiement primary key (id_type)
);

go
--Creation Et Gestion De Table Fournisseur

create table fournisseur
(
id_fournisseur int identity ,
nom varchar(50) ,
prenom varchar(50) ,
telephone varchar(20) ,
email varchar(250) ,
ice int ,
archive bit ,
constraint pk_fournisseur primary key (id_fournisseur)
);

go
--Creation Et Gestion De Table Facture

create table facture
(
id_facture int identity ,
designation varchar(250) ,
date_facture date ,
montant money ,
id_employe int ,
id_fournisseur int ,
id_type_paiement int ,
numCheque int ,
numVirement int ,
archive bit ,
constraint pk_facture primary key (id_facture) ,
constraint fk_facture_typeFacture foreign key(id_type_paiement) references type_paiement (id_type) ,
constraint fk_facture_fournisseur foreign key (id_fournisseur) references fournisseur (id_fournisseur)
);

go
--Creation Et Gestion De Table Document_Facture

create table document_facture
(
id_document int identity ,
nom varchar(150) ,
fichier varchar(150) ,
id_facture int ,
archive bit ,
constraint pk_document_facture primary key (id_document) ,
constraint fk_documentFact_facture foreign key (id_facture) references facture (id_facture)
);

go
--Creation Et Gestion De Table Remarque_Facture

create table remarque_facture
(
id_remaque int identity ,
nom varchar(150) ,
remarque text ,
id_facture int ,
constraint pk_remarque_facture primary key (id_remaque) ,
constraint fk_remarqueFac_facture foreign key (id_facture) references facture (id_facture)
);

go
--Creation Et Gestion De Table Rubrique

create table rubrique
(
id_rubrique int identity ,
nomrubrique varchar(200) ,
archive bit ,
constraint pk_rubrique primary key (id_rubrique)
);

go
--Creation Et Gestion De Table Article

create table article
(
id_article int identity ,
designation varchar(250) ,
qteMinimum int ,
id_rubrique int ,
qtestock int ,
archive bit ,
constraint pk_produit primary key (id_article) ,
constraint fk_article_rubrique foreign key (id_rubrique) references rubrique (id_rubrique)
);

go
--Creation Et Gestion De Table Achat

create table achat
(
id_article int ,
id_facture int ,
qteAchat int ,
prix money ,
archive bit ,
constraint pk_achat primary key (id_facture,id_article) ,
constraint fk_achat_article foreign key (id_article) references article (id_article) ,
constraint fk_achat_facture foreign key (id_facture) references facture (id_facture)
);

-- constraint fk_bien_immeuble foreign key (id_bien) references immeuble (id_immeuble) ,
--alter table Bien add constraint fk_bien_immeuble foreign key (id_immeuble) references immeuble(id_immeuble) ;

