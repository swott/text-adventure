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

- <a id="value-types"></a><span style="font-size: 18px;"> **Hodnotové typy (Value types)** </span>

  - <a id="integer"></a><span style="font-size: 16px;"> ***Celočíselné (Integer types)*** </span>
  
    1. `int`
  
       - **výchozí** pro celá čísla
       - rozsah -2,1M - 2,1M
  
    2. `byte`
  
       - **specifické situace**, paměťově úsporný
       - rozsah 0-255

    3. `long`
  
       - pro **velmi velká** celá čísla
       - může se psát s **l nebo L** na konci (`long BigNumber = 100l;`)
       - když `int` nestačí
  
  - <a id="floating-point"></a><span style="font-size: 16px;"> ***Desetinná čísla (Floating-point Types)*** </span>

    1. `double`

        - používat **nejčastěji** 
        - výpočty s měřeními (výška, váha...), vědecké výpočty
        - pozice objektů ve 3D hrách, statistika, obecná matematika
        - může se psát s **d** na konci (`double Number = 3.14d;`)

    2. `decimal`

        - používat **cíleně**
        - přesnost v **desítkové soustavě**
        - **MUSÍ** se používat s **m nebo M** na konci (`decimal Price = 99.99m;`)
        - celkově finanční systém, kde zaokrouhlování není přijatelné

    3. `float`

        - používat **cíleně** - když stačí menší přesnost
        - **MUSÍ** se psát s **f nebo F** na konci (`float pixelX = 125.8f;`)
        - 2D grafika, UI
        - embedded systémy (hodinky, senzory, termostaty atd), kde je paměť limitovaná

  - <a id="boolean-character-types"></a><span style="font-size: 16px"> ***Logické a znakové typy (Boolean & Character types)*** </span>

    1. `bool`

        - **logické podmínky** - true / false

    2. `char`

        - **jeden** Unicode znak

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

- <a id="collections"></a><span style="font-size: 18px"> **Kolekce a pole (Collections and arrays)** </span>
- <a id="static-collections"></a><span style="font-size: 16px;"> ***Pole*** </span>
  
    1. `x[]`
  
       - **pole (array)**
       - Použití : `int[] PoleCisel = {2, 4, 6};` (jdou i stringy atd)
       - pevná velikost (po vytvoření nelze přidávat ani odebírat prvky)
       - jednotlivé prvky jsou uloženy za sebou a přistupuje se k nim **od 0**
       - rychlé, ale méně flexibilní
 


    2. `byte`
  
       - **specifické situace**, paměťově úsporný
       - rozsah 0-255

    3. `long`
  
       - pro **velmi velká** celá čísla
       - když `int` nestačí
  
  - <a id="floating-point"></a><span style="font-size: 16px;"> ***Desetinná čísla (Floating-point Types)*** </span>

    1. `double`

        - používat <span style="font-size: 16px;"> **nejčastěji** </span>
        - výpočty s měřeními (výška, váha...), vědecké výpočty
        - pozice objektů ve hrách, statistika, obecná matematika

    2. `decimal`

        - používat <span style="font-size: 16px;"> **cíleně** </span>
        - přesnost v desítkové soustavě
        - celkově finanční systém -> zaokrouhlování není přijatelné

    3. `float`

        - jen <span style="font-size: 16px;"> **SPECIFICKÉ PŘÍLEŽITOSTI** </span>
  
## 2. Řízení toku programu

## 3. Metody a funkce
