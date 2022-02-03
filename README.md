# 13WalknerM-KinderaddiererConsole Aufgabenbeschreibung

### Projektbeschreibung: 
Dieses Projekt dient der Einarbeitung in Untiy für die selbstständige Erstellung zukünftiger 2D Projekte. 
Ein einfaches Unity 2D Projekt wird erstellt, als WebGL exportiert und auf GitHub Pages veröffentlicht. 
Das Projekt enthält eine Szene. Die Szene besteht aus einem screenindependent Canvas (960x600).
Auf dem Canvas befindet sich mindestens ein Text und ein Image GameObject. 
Die Benennung der Objekte in der Hierarchy, wie auch die Benennung der Elemente in der Project Pane, folgt der PascalCase Notation.

### Entwicklungsplattform: 
Windows 10, Unity 2020.3.18f1, Visual Studio Version 2019 Community

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

### Visuelle Einblicke in das Projekt: 
https://3ahmns2122mtin.github.io/13WalknerM-KinderaddiererConsole/

### Notwendiges für die Ausführung: 
Für den Export in WebGL muss das Modul WebGL in Unity installiert sein.

### Anforderungen:  
- [x] Anlegen eines 2D Unityprojekts mit Namen HelloAgain-yourKürzel
- [x] In Assets einen Folder MyGame erstellen und den Scenes Folder in diesen MyGame Folder ziehen
- [x] Im Ordner Scenes die SampleScene in HelloAgain umbenennen
- [x] Im Game View Einstellung 960x600 einstellen
- [x] Der Szene ein Canvas GameObject hinzufügen
- [x] Das Canvas screenindependent einstellen: 
- [x] Canvas Componente Render Mode auf Screen Space – Camera einstellen und in Render Camera die Main Camera reinziehen.
- [x] Canvas Scaler UI Scale Mode, Scale With Screen Size einstellen und als Reference Resolution 960 x 600 einstellen.
- [x] Dem Canvas GameObject ein Text GameObject hinzufügen: „Hello again, here is yourKürzel speaking :) 
- [x] Dieses Text GameObject umbenennen in Welcome
- [x] Dem Canvas GameObject ein Image GameObject hinzufügen (Abmessung/Auflösung > 960x600)
- [x] Dieses Image GameObject umbennen in Background
- [x] Anordnung in der Hierarchy so ändern, dass der Background hinter dem Text liegt
- [x] Im Ornder Assets > MyGame  einen Ordner Sprites anlegen, alle im Projekt verwendeten Sprites, die wir hinzufügen, dort ablegen.
- [x] In das Image GameObject mit Namen Background ein Sprite in die Image Source ziehen 
- [x] Assets und ProjectSettings Folders auf GitHub laden
- [x] Readme updaten
- [x] WebGL exportieren in HelloAgain-yourKürzel > docs
- [x] Upload auf GitHub
- [x] WebGL Pages Einstellen
- [x] Link in Readme einfügen

### Optionale Aufgabenstellung:
- [ ] Grafische Aufbereitung des Projekts
- [ ] Zusätzliche Text und Sprite Elemente einfügen und platzieren
- [ ] Text visuell ändern: color, font, font style, etc.
- [ ] Textmesh pro GameObject einfügen und manipulieren 
- [x] Color Tint Playmode einstellen

### Lessons Learned:
| Neu gelernt | Wiederholung | Vertiefung | Lernstoff                                                                             |
|-------------|--------------|------------|---------------------------------------------------------------------------------------|
|             |              |      x      | Anlegen eines 2D Unityprojektes                                                       |
|     x        |              |            | Screenindependent Design für 2D Einstellung des Canvas                                |
|     x        |              |            | GameView Auflösung Einstellung                                                        |
|             |       x       |            | Verwendung und Manipulation von UI Elementen Text, Image                              |
|             |      x        |            | Anordnung GameObjects in Hierarchy hat Auswirkung auf Anordnung der Elemente im Spiel |
|             |      x       |            | Unity Editor Komponenten: Game View, Scene View, Hierarchy, Inspector, Project        |
|      x       |              |            | (optional) Color Tint Playmode                                                        |
|              |       x       |            | WebGL exportieren                                                                     |
|             |              |      x      | WebGL auf GitHub Pages veröffentlichen                                                |

Limitations
  1) Problem
  2) was ist das Problem
