# Datové typy

<a id="summary"></a><span style="font-size: 16px;">**Obsah:**</span>
<!-- TOC -->

1. [Hodnotové typy](#value-types)

    - [Celočíselné](#integer)
    - [Desetinná čísla](#floating-point)
    - [Logika a znaky](#boolean-character-types)
    - [Speciální pro UNITY 3D](#unity-specific-types)
    - [Uživatelské](#user-defined-types)

2. [Referenční typy](#reference-types)

    - [Základní](#basic-reference-types)
    - [Kolekce a pole](#collections-arrays)

<!-- /TOC -->
## Rozdělení

- <span style="font-size: 18px;"> **Hodnotové typy (Value types)** </span>

  - <a id="integer"></a><span style="font-size: 16px;"> ***Celočíselné (Integer types)*** </span>

    1. `int number = 0;`
  
       - **základní pro hry** - počítadla, ID, indexy
       - **výchozí** pro celá čísla
       - příklad: zdraví, skóre, počet předmětů
       - rozsah -2,1M - 2,1M
  
    2. `byte number = 0;`
  
       - **specifické situace, optimalizace**
       - barvy (0-255) - RGB, malé hodnoty
       - procenta (0-100)
       - paměťově úsporný
       - rozsah 0-255

    3. `long number = 0l;`
  
       - pro **velká** celá čísla
       - celkové skóre, universální ID
       - může se psát s **l nebo L** na konci (`long BigNumber = 100l;`)
       - když `int` nestačí

  [Zpět na obsah](#summary)<br>
  
  - <a id="floating-point"></a><span style="font-size: 16px;"> ***Desetinná čísla (Floating-point Types)*** </span>

    1. `float pixelX = 125.8f;`

        - **základní pro UNITY 3D** - pozice, rotace, fyzika
        - příklady : `transform.position`, `Vector3`, `Quaternion`
        - používat **cíleně** - když stačí menší přesnost
        - **MUSÍ** se psát s **f nebo F** na konci
        - 2D grafika, UI
        - embedded systémy (hodinky, senzory, termostaty atd), kde je paměť limitovaná

    2. `double number = 3.14d;`

        - používat **nejčastěji mimo UNITY 3D**
        - výpočty s měřeními (výška, váha...), vědecké výpočty
        - pozice objektů ve 3D hrách, statistika, obecná matematika
        - může se psát s **d** na konci

    3. `decimal money = 99.99m;`

        - používat **cíleně**
        - přesnost v **desítkové soustavě**
        - **MUSÍ** se používat s **m nebo M** na konci
        - celkově finanční systém, kde zaokrouhlování není přijatelné
        - **ekonomika her** - herní měna, obchody, nákupy, systémy

  [Zpět na obsah](#summary)<br>

  - <a id="boolean-character-types"></a><span style="font-size: 16px"> ***Logické a znakové typy (Boolean & Character types)*** </span>

    1. `bool check = true;`

        - **logické podmínky** - true / false
        - použití : `if (IsActive)`, `while (continue)`

    2. `char character = 'A';`

        - **jeden** Unicode znak
        - musí být v **jednoduchých uvozovkách**: `'A'`, `'č'`, `'1'`
        - pro jednotlivé znaky či symboly

  [Zpět na obsah](#summary)<br>

  - <a id="unity-specific-types"></a><span style="font-size: 16px"> ***Unity-specifické typy (Unity-specific Value types)*** </span>

    1. `Vector3 pozice = new Vector3(1.0f, 2.0f, 3.0f);`
       - **základní typ pro pozice v prostoru**
       - X, Y, Z souřadnice
       - použití: transform.position, pohyb objektů

  [Zpět na obsah](#summary)<br>

  - <a id="user-defined-types"></a><span style="font-size: 16px"> ***Uživatelské hodnotové typy (User-defined Value types)*** </span>

    1. `struct StructName { public int X; public int Y; }`

        - **ideální pro UNITY 3D** - Vector3, Quaternion, Color
        - pro **malé** datové struktury (**jako ID, pozice**)
        - chová se jako číslo - při přiřazení se kopíruje
        - použít pro data, která jsou **jednoduchá a neměnná**

    2. `enum EnumName { Hodnota1, Hodnota2, Hodnota3 }`

        - **výčtový typ (Enumeration type)** pro předdefinované možnosti (dny, stavy)
        - **časté ve hrách** - stavy hry, typy předmětů, AI stavy
        - **částečně** nahrazuje if/else pro výběr z předem daných možností
        - zlepšuje čitelnost kódu
        - **občas** se používá s throw
        - **příklad:** `enum StavHrace { Beh, Skok, Utok, Smrt }`

  [Zpět na obsah](#summary)<br>

- <a id="reference-types"></a><span style="font-size: 18px"> **Referenční typy (Reference types)** </span>

  - <a id="basic-reference-types"></a><span style="font-size: 16px"> ***Základní referenční typy*** </span>

    1. `string stringName = "Text";`

        - textový typ
        - i když se do něj napíše číslo, bere se jako text, ne int atd.
        - neměnný (immutable)

    2. `class className { more code }`

        - uživatelský referenční typ
        - dědičnost, polymorfismus
        - větší popis [zde](Classes.md)

    3. `object objectName = value;`

        - **používat velice výjimečně** - ztráta bezpečnosti jednotlivých typů
        - základní typ všech typů
        - může obsahovat cokoliv
        - `object data = 10;` - ukládá číslo
        - `object text = "Ahoj";` - ukládá text
        - `object seznam = new List<string>();` - ukládá kolekci
        - **nevýhoda** - při čtení musíš přetypovat `int cislo = (int)data;`

  [Zpět na obsah](#summary)<br>

  - <a id="collections-arrays"></a><span style="font-size: 16px"> **Kolekce a pole (Collections and arrays)** </span>

    - <a id="array"></a><span style="font-size: 16px;"> ***Pole (Array)*** </span>
  
      1. `dataType[] arrayName = {1, 2};`

         - **pevná velikost** (po vytvoření nelze přidávat ani odebírat položky)
         - přístup přes **index od 0**: `arrayName[0]` - první položka (1)
         - položky jsou uloženy za sebou
         - rychlé, ale méně flexibilní než List

    - <a id="collections"></a><span style="font-size: 16px;"> ***Kolekce (Collections)*** </span>

        <span style="display: block; padding-left: 100px; text-decoration: underline; font-size: 16px;">**Vlastnosti kolekcí**</span>

      - lze přidávat, odebírat, procházet položky
      - počet položek se může měnit za běhu
      - kapacita prakticky neomezená (záleží na RAM)
      - dynamicky rostou podle potřeby <br><br>

      1. ``List<dataType> listName = new List<dataType>();``

         - **seznamy (nepřátel, předmětů, efektů atd)**
         - čtení podle pozice položky (index), začíná **od 0**
         - procházení v pevném pořadí
         - hledá se pomaleji - musí projít všechny položky
         - `Add()`, `Remove()`, `Count`
         - použití na : seznam úkolů, hráčů, předmětů atd.

      2. `Dictionary<keyType, valueType> slovnik = new Dictionary<keyType, valueType>();`

         - **slovník**
         - ukládáš věci pod názvem (klíčem)
         - rychlé vyhledání hodnoty podle klíče
         - `Add()`, `Remove()`, `ContainsKey()`
         - použití na : nastavení, statistiky, vyhledávání atd

  <br>[Zpět na obsah](#summary)<br><br>
