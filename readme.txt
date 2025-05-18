Dieses Unity-Projekt ist ein VR-Spiel, in dem der Spieler mit Bäumen und einem Vogel interagiert. 
Das Hauptziel besteht darin, Bäume auszuwählen, zu denen der Vogel fliegen soll, bevor diese verschwinden. 
Das Spiel verwendet das XR Interaction Toolkit für die VR-Funktionalität.

Grundkonzept

- Bäume erscheinen zufällig in der Spielwelt
- Der Spieler kann mit einem Pointer auf Bäume zeigen, um den Vogel dorthin zu schicken
- Wenn der Vogel einen Baum erreicht, bevor dieser verschwindet, erhält der Spieler Punkte
- Wenn ein Baum verschwindet, bevor der Vogel ihn erreicht, verliert der Spieler Punkte
- Das Spiel hat ein Zeitlimit, nach dessen Ablauf der Endpunktestand angezeigt wird

Spielablauf

1. Das Spiel beginnt mit dem Hauptmenü 
2. Nach dem Start erscheinen Bäume in der Spielwelt 
3. Der Spieler zeigt mit dem VR-Controller auf einen Baum. Durch Drücken der hinteren Taste am rechten Controller wird ein Zeigestrahlt mit begrenzter Länge genutzt, um einen Baum auszuwählen. Aufgrund der begrenzten Reichweite des Strahls muss der Benutzer sich durch das Spielfeld bewegen.
4. Ein ausgewählter Baum wird blau.
5. Der Vogel fliegt zum ausgewählten Baum 
6. Wenn der Vogel den Baum erreicht, bevor dieser verschwindet, erhält der Spieler Punkte 
7. Bäume wachsen, altern und verschwinden mit der Zeit 
8. Nach Ablauf der Spielzeit wird der Endpunktestand angezeigt 


Spiellogik

Die Bäume
    wachsen von einer Startgröße bis zur maximalen Größe
    pulsieren und rotes blinken kurz vor dem Verschwinden
    umfallen und versinken beim Verschwinden (mit Rotationen)

Der Vogel
    bewegt sich zum ausgewählten Baum
    kreist um den Baum, wenn er ihn erreicht hat

Das Drücken der Leertaste ermöglicht das Umschalten zwischen verschiedenen Kameraansichten (Aufgabeteil G):
    Erste-Person-Perspektive
    Dritte-Person-Perspektive
    Vogelperspektive

Punkte
    erhöhen sich, wenn der Vogel einen Baum rechtzeitig erreicht
    verringern sich, wenn ein Baum verschwindet, bevor der Vogel ihn erreicht

Timer 
    zeigt das Ablauf der Spielzeit

Menu
    verwaltet die Funktionen "Spiel starten" und "Spiel beenden"