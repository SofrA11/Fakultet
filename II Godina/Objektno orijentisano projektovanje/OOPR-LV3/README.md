# OOPR-LV3
III Лабораторијска вежба из објектно орјентисаног пројектовања, креирање WIndows Forms App(. NET Framework), коришћењем програмског језика C#.
Cilj vežbe:
Upoznavanje sa razvojnim okruženjem Microsoft Visual Studio. Kreiranje windows form aplikacije. Dodavanje kontrola na 
formi, podešavanje razmeštaja i postavljanje svojstava za dodate kontrole na formi. Obrada događaja koje kontrole hvataju.

Zadatak:
1. Kreirati formu kao što je prikazana na sledećoj slici

![OOPR-LV3-SLIKA](https://user-images.githubusercontent.com/107811123/233790633-fe13c6bb-3d63-4198-a35d-b593e28a510b.png)


2. Za polja Ime i Prezime zabranjen je unos karaktera sa tastature koji nisu slova (Ispitivanje se vrši nakon klika na taster 
na tastaturi).
3. Telefon mora biti unet u sledećem formatu +381 11 5659898, inače upozoriti korisnika da je pogrešno uneo telefon.
Upozorenje prikazati u trenutku kada se prelazi na drugu kontrolu.
4. Datum rodjenja mora biti prikazan u formatu kao na slici.
5. Pamćenje osobe moguće je samo ukoliko su sva polja popunjena (dugme Zapamti).
6. Dugme Zapamti dodaje osobu u listu osoba i nakon toga dodata osoba se prikazuje kao prva u ListBox-u.
7. Dugme Ponisti briše sadržaj iz kontrola koje se odnose na unos podataka i postavlja datum rođenja na trenutni sistemski 
datum.
8. Dugme Obrisi izabranu osobu uklanja iz liste osoba izabranu osobu
9. Dugme Obrisi listu osoba brise sve unete osobe iz liste.
10. Dugme Sortiraj listu omogućava sortiranje liste po nekom kriterijumu koji je odabran iz padajuće liste (PO IMENU, PO 
PREZIMENU, PO DATUMU RODJENJA). Funkcija za sortiranje ne sme imati ulazne argumente. Kriterijum na osnovu 
čega se vrši sortiranje realizovati pomoću delegata.
11. Prilikom zatvaranja forme potrebno je pitati korisnika da li se slaže sa tom akcijom zatvaranja forme.
12. Nakon svake akcije klika na neko dugme, akciju ispratiti odgovarajućom porukom u MessageBox-u.
13. Dvostrukim klikom na neku stavku iz liste automatski se popunjavaju sve kontrole koje se odnose na seleketovanu osobu 
iz liste.
14. Omogućiti editovanje podataka o izabranoj osobi (Osoba se odabere iz liste. Podaci o osobi se automatski pri tome 
popune. Nakon izmena nekih podataka dugme Zapamti ponaša se kao dugme za ažuriranje. Zapamćen objekat iz liste se 
ne uklanja već se menjaju odgovarajuće vrednosti (Ime, Prezime, ....)).
15. Forma je fiksnih dimenzija.
16. Urediti TabOrder za sve kontrole na formi.
17. Nakon klika na dugme Zapamti focus se prebacauje na tekstualno polje Ime.
18. Kreirati listu osoba tako da je ta lista jedinstvena za ceo projekat i zabraniti njeno višestruko instanciranje.
19. Klase sa podacima i funkcijama razdvojiti u posebne projekte.
20. Napisati metodu proširenja sa klasu DateTime koja će uvek vraćati trenutno sistemsko vreme u formatu dd.MM.yyyy. 
HH:mm.
21. Dvostruki klik na formu prikazuje MessageBox sa trenutnim sistemskim vremenom (iskoristiti napisanu metodu 
proširenja za klasu DateTime).
22. Koristiti svojstvo DataSource iz klase ListBox-a za prikazivanje svih zapamćenih osoba.
23. ComboBox je potrebno inicijalizovati van konstruktora i to pre prikazivanja forme.
24. Pridružiti proizvoljne ikonice dugmićima.
