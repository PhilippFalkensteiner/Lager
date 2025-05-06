📌 Projektbeschreibung: Lagerverwaltung
Funktionen:

📦 Artikel anlegen (Name, Artikelnummer, Preis, Anzahl)

📋 Alle Artikel anzeigen

🔍 Nach Artikelnummer suchen

✏️ Artikelbestand ändern

🗑️ Artikel löschen

Technologie:

C# Konsolenanwendung

SQLite als lokale Datenbank (über Microsoft.Data.Sqlite)

📌 Datenbankmodell
Tabelle: Artikel

Feldname	Datentyp
id	INTEGER (Primärschlüssel, Auto-Inkrement)
artikelNummer	TEXT
name	TEXT
preis	REAL
anzahl	INTEGER

📌 Projektplan
Aufgabe	Zeit
Datenbank-Datei + Tabelle anlegen	15 Min
C#-Projekt einrichten + SQLite-Paket installieren	10 Min
Verbindung zur Datenbank herstellen	10 Min
CRUD-Funktionen programmieren	2 h
Tests	20 Min


