# Mein Projekt für die Casablanca-Bewerbung

Hier sind meine Lösungen für die Aufgabe im Bewerbungsprozess.  
Das Projekt besteht aus drei Teilen:

## 1. Merge-Sort in C#

Im Ordner `MergeSortProject` habe ich den Merge-Sort Algorithmus implementiert.  
In `MergeSortTests` gibt es dazu Unit-Tests, um sicherzustellen, dass die Sortierung richtig funktioniert.


Um die Tests laufen zu lassen einfach:
```
cd MergeSortTests
dotnet test
```

## 2. UML-Diagramm für das Preissystem

Die Datei `UML.png` zeigt mein Modell für die Preisberechnung:
- Alle wichtigen Klassen sind dargestellt: Season, BAR-Rate, PriceCategory, Room, MealPlan und PriceCalculator
- Die Beziehungen zeigen, wie die Klassen zusammenarbeiten. Eine PriceCategory kann mit einem oder mehreren Room-Instanzen verknüpft sein
- Die Idee dahinter ist, dass nur die BAR-Rate geändert wird und sich alle anderen Preise automatisch davon ableiten

## 3. REST-API für die Preisverwaltung

In der Datei `api.yaml` habe ich die API definiert:
- Man kann Saisonzeiten erstellen und löschen
- Preiskategorien können aktualisiert werden
- Die Datumsangaben für Saisonzeiten werden als Unix-Timestamps gespeichert
- Preisänderungen und Aufschläge werden als Dezimalwerte angegeben (z.B. 0.20 für +20%)

## Wie alles organisiert ist

```
Casablanca/
├── MergeSortProject/
├── MergeSortTests/
├── api.yaml
├── README.md
└── UML.png
```
