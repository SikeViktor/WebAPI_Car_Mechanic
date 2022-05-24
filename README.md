# WebAPI_Car_Mechanic



Szoftverfejlesztés C# nyelven nagyvállalati környezetben nevű tárgy során elkészített beadandó. 
Egy autószerelő műhelyben működő kliens - szerver alkalmazás implementálása.
C# alapú szerver, adatbázissal, 2 wpf-el.

## Munka felvevő kliens - .NET WPF    :   WebAPI_Car_Mechanic_Office
    > Az ügyintéző irodájában működik.

    ### Az érkező ügyfelek adatait tudja felvenni
    - Ügyfél neve    
    - Autó típusa és rendszáma    
    - Az autó hibájának rövid leírásá (kötelező mező = nem lehet üres)

    ### Látja a felvett munkákat
    - Időrendi sorrendben rendezve dátum és idó szerint
    - Egy kiválasztott munka adatait
        - Meg tudja nézni
        - Módosítani tudja

## Autószerelő kliens - .NET WPF   :   WebAPI_Car_Mechanic_Workshop
    > Az autószerelő műhelyben működik.

    ### Látja a felvett munkákat
    - Időrendi sorrendben rendezve dátum és idő szerint
    - Ki tud választani egy munkát
        - Aminek az állapotát változtathatja
            - `Felvett munka` -> `Elvégzés alatt` -> `Befejezett`
            
## Szerver - .NET WEB API alkalmazás (önálló konzol alkalmazás)     :     WebAPI_Car_Mechanic_Server
    ### Tárolja és szolgáltatja a bevitt adatokat
    - Adatok tárolása: adatbázis(Entity FWK)
    - Indításkor betölti a korábbi adatokat          

