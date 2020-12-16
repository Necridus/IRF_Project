DF9YEV	A	C	C	B

Elvégzendő feladatok:
A) Olvasás CSV fájlból
C) Adott tulajdonságú elemek törlése egy listából
C) Diagram rajzolás + kapcsolódó adatok megjelenítése (pl.: DataGridView)
B) Enumeráció létrehozása és használata


A feladat elvégzésének terve:
Terveim szerint a program demográfiai adatok vizualizációjára lesz alkalmas. 
Egy csv fájl beolvasása után kiszűrhetőek lesznek azon sorok, melyek egy előre meghatározott tulajdonsággal rendelkeznek (például: férfiak vagy 65 év felettiek). Terveim szerint szükséges lesz a felhasználó megerősítése hozzá.
A szerkesztést követően kirajzolódik a datagridview-ban szereplő adatsor egy diagramba.

Ehhez a szükséges .csv fájlt elkészítem, mely Vezetéknév, Keresztnév, Kor, Nem, Iskolai végzettség és Van-e munkája oszlopokat tartalmaz.
Az enumeráció a nemekkel kapcsolatos lesz.
A három osztály: személy, enum (az enumeráció nem osztály, tévedtem, amikor beleszámoltam), megerősító ablak
Terveim szerint a törlendő adatok Comboboxokkal és gombokkal választhatóak majd ki.

----------------

FONTOS!

A program lehető legrugalmasabb működése érdekében nem automatikusan az előre létrehozott fájlt olvassuk be, hanem egy OpenFileDialog segítségével lehet tallózni.
Én a szoftver működésének demonstrálásához egy fájlt készítettem el, ami a projekt mappájában található "people.csv".
Olyan fájlokat képes még kezelni a program, amelyek ugyanígy vannak felépítve, mint ezen fájl.

----------------

Változtatás a tervekhez képest:

- a megerősítő ablakot elhagytam, mert a program mérete nem igényli a felhasználó megerősítését,
  hiszen pillanatok alatt rekreálni lehet az adott vizualizációt.
- a személy osztály mellé készítettem a Charthoz szükséges ChartData class-t, valamint a súgó- és vezérlőgombok származtatott osztályait.