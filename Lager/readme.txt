📌 Projektbeschreibung: Lagerverwaltung
Funktionen:

Startseite
- Überblick zu alle Funktionen
- Weiterleitung zu den einzelnen Funktionen


📦 Artikel anlegen (Name, Artikelnummer, Preis, Anzahl)
- Frontend = Seite - Maxi
- Backend = Datenbank - Phili

📋 Alle Artikel anzeigen

🔍 Nach Artikelnummer suchen
- F done


🗑️ Artikel löschen
- F done 

Technologie:

.NET MAUI

SQLite als lokale Datenbank (über Microsoft.Data.Sqlite)

📌 Datenbankmodell
Tabelle: Artikel

Feldname	Datentyp
id	INTEGER (Primärschlüssel, Auto-Inkrement)
artikelNummer	TEXT
name	TEXT
preis	REAL
anzahl	INTEGER

