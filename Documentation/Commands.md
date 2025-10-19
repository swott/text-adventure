# Příkazy

<span style="font-size: 16px;">**Obsah:**</span>
<!-- TOC -->

1. [Hodnotové typy](#value-types)

    - [Celočíselné](#integer)
    - [Desetinná čísla](#floating-point)
    - [Logické a znakové typy](#boolean-character-types)
    - [Uživatelské hodnotové typy](#user-defined-types)

2.

3.

<!-- /TOC -->
## Datové typy

- <span style="font-size: 18px;"> **Hodnotové typy (Value types)** </span>

  - <a id="integer"></a><span style="font-size: 16px;"> ***Celočíselné (Integer types)*** </span>

    1. `int number = 0;`
  
       - **výchozí** pro celá čísla
       - rozsah -2,1M - 2,1M
  
    2. `byte number = 0;`
  
       - **specifické situace**, paměťově úsporný
       - rozsah 0-255

    3. `long number = 0l;`
  
       - pro **velmi velká** celá čísla
       - může se psát s **l nebo L** na konci (`long BigNumber = 100l;`)
       - když `int` nestačí

    <br>
  
  - <a id="floating-point"></a><span style="font-size: 16px;"> ***Desetinná čísla (Floating-point Types)*** </span>

    1. `double number = 3.14d;`

        - používat **nejčastěji**
        - výpočty s měřeními (výška, váha...), vědecké výpočty
        - pozice objektů ve 3D hrách, statistika, obecná matematika
        - může se psát s **d** na konci

    2. `decimal money = 99.99m;`

        - používat **cíleně**
        - přesnost v **desítkové soustavě**
        - **MUSÍ** se používat s **m nebo M** na konci
        - celkově finanční systém, kde zaokrouhlování není přijatelné

    3. `float pixelX = 125.8f;`

        - používat **cíleně** - když stačí menší přesnost
        - **MUSÍ** se psát s **f nebo F** na konci
        - 2D grafika, UI
        - embedded systémy (hodinky, senzory, termostaty atd), kde je paměť limitovaná

    <br>

  - <a id="boolean-character-types"></a><span style="font-size: 16px"> ***Logické a znakové typy (Boolean & Character types)*** </span>

    1. `bool check = true;`

        - **logické podmínky** - true / false

    2. `char`

        - **jeden** Unicode znak

    <br>

  - <a id="user-defined-types"></a><span style="font-size: 16px"> ***Uživatelské hodnotové typy (User-defined Value types)*** </span>

    1. `struct`

        - pro **malé** datové struktury (**jako ID, pozice**)
        - chová se jako číslo - při přiřazení se kopíruje
        - použít pro data, která jsou jednoduchá a neměnná

    2. `enum`

        - **výčtový typ (Enumeration type)** pro předdefinované možnosti (dny, stavy)
        - **částečně** nahrazuje if/else pro výběr z předem daných možností
        - zlepšuje čitelnost kódu
        - **občas** se používá s throw

<br>

- <a id="reference-types"></a><span style="font-size: 18px"> **Referenční typy (Reference types)** </span>

    1. `string`

        - textový typ
        - i když se do něj napíše číslo, bere se jako text, ne int atd.
        - neměnný (immutable)

    2. `class`

        - uživatelský referenční typ
        - dědičnost, polymorfismus
        - větší popis [zde](Classes.md)

    3. `object`

        - **používat výjimečně** - ztráta bezpečnosti jednotlivých typů
        - základní typ všech typů
        - může obsahovat cokoliv

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

         - **seznam**
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

## 2. Řízení toku programu

## 3. Metody a funkce
