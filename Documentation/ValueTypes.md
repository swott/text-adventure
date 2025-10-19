# Datové typy

---
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
---

## Rozdělení

- <a id="value-types"></a><span style="font-size: 18px;"> **Hodnotové typy (Value types)** </span>
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - <a id="integer"></a><span style="font-size: 16px;"> ***Celočíselné (Integer types)*** </span>
  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->
  
    - **`int number = 0;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **základní pro hry** - počítadla, ID, indexy
      - **výchozí** pro celá čísla
      - příklad: zdraví, skóre, počet předmětů
      - rozsah -2,1M - 2,1M

        <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->
  
    - **`byte number = 0;`**
  
      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **specifické situace, optimalizace**
      - barvy (0-255) - RGB, malé hodnoty
      - procenta (0-100)
      - paměťově úsporný
      - rozsah 0-255

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`long number = 0l;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - pro **velká** celá čísla
      - celkové skóre, universální ID
      - může se psát s **l nebo L** na konci (`long BigNumber = 100l;`)
      - když `int` nestačí

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)
  
  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - <a id="floating-point"></a><span style="font-size: 16px;"> ***Desetinná čísla (Floating-point Types)*** </span>
  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **`float pixelX = 125.8f;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **základní pro UNITY 3D** - pozice, rotace, fyzika
      - příklady : `transform.position`, `Vector3`, `Quaternion`
      - používat **cíleně** - když stačí menší přesnost
      - **MUSÍ** se psát s **f nebo F** na konci
      - 2D grafika, UI
      - embedded systémy (hodinky, senzory, termostaty atd), kde je paměť limitovaná

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`double number = 3.14d;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - používat **nejčastěji mimo UNITY 3D**
      - výpočty s měřeními (výška, váha...), vědecké výpočty
      - pozice objektů ve 3D hrách, statistika, obecná matematika
      - může se psát s **d** na konci

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`decimal money = 99.99m;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - používat **cíleně**
      - přesnost v **desítkové soustavě**
      - **MUSÍ** se používat s **m nebo M** na konci
      - celkově finanční systém, kde zaokrouhlování není přijatelné
      - **ekonomika her** - herní měna, obchody, nákupy, systémy

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)
  
  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - <a id="boolean-character-types"></a><span style="font-size: 16px"> ***Logické a znakové typy (Boolean & Character types)*** </span>
  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **`bool check = true;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **logické podmínky** - true / false
      - použití : `if (IsActive)`, `while (continue)`

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`char character = 'A';`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **jeden** Unicode znak
      - musí být v **jednoduchých uvozovkách**: `'A'`, `'č'`, `'1'`
      - pro jednotlivé znaky či symboly

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - <a id="unity-specific-types"></a><span style="font-size: 16px"> ***Unity-specifické typy (Unity-specific Value types)*** </span>
  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **`Vector3 pozice = new Vector3(1.0f, 2.0f, 3.0f);`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **základní typ pro pozice v prostoru**
      - X, Y, Z souřadnice
      - použití: transform.position, pohyb objektů

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - <a id="user-defined-types"></a><span style="font-size: 16px"> ***Uživatelské hodnotové typy (User-defined Value types)*** </span>
  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **`struct StructName { public int X; public int Y; }`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **ideální pro UNITY 3D** - Vector3, Quaternion, Color
      - pro **malé** datové struktury (**jako ID, pozice**)
      - chová se jako číslo - při přiřazení se kopíruje
      - použít pro data, která jsou **jednoduchá a neměnná**

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`enum EnumName { Hodnota1, Hodnota2, Hodnota3 }`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **výčtový typ (Enumeration type)** pro předdefinované možnosti (dny, stavy)
      - **časté ve hrách** - stavy hry, typy předmětů, AI stavy
      - **částečně** nahrazuje if/else pro výběr z předem daných možností
      - zlepšuje čitelnost kódu
      - **občas** se používá s throw
      - **příklad:** `enum StavHrace { Beh, Skok, Utok, Smrt }`

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

- <a id="reference-types"></a><span style="font-size: 18px"> **Referenční typy (Reference types)** </span>

  <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - <a id="basic-reference-types"></a><span style="font-size: 16px"> ***Základní referenční typy*** </span>
    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **`string stringName = "Text";`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - textový typ
      - i když se do něj napíše číslo, bere se jako text, ne int atd.
      - neměnný (immutable)

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`class className { more code }`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - uživatelský referenční typ
      - dědičnost, polymorfismus
      - větší popis [zde](Classes.md)

      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - **`object objectName = value;`**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **používat velice výjimečně** - ztráta bezpečnosti jednotlivých typů
      - základní typ všech typů
      - může obsahovat cokoliv
      - `object data = 10;` - ukládá číslo
      - `object text = "Ahoj";` - ukládá text
      - `object seznam = new List<string>();` - ukládá kolekci
      - **nevýhoda** - při čtení musíš přetypovat `int cislo = (int)data;`

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - <a id="collections-arrays"></a><span style="font-size: 16px"> **Kolekce a pole (Collections and arrays)** </span>
    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - <a id="array"></a><span style="font-size: 16px;"> ***Pole (Array)*** </span>
      <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      - **`dataType[] arrayName = {1, 2};`**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        - **pevná velikost** (po vytvoření nelze přidávat ani odebírat položky)
        - přístup přes **index od 0**: `arrayName[0]` - první položka (1)
        - položky jsou uloženy za sebou
        - rychlé, ale méně flexibilní než List
  
      <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

    - <a id="collections"></a><span style="font-size: 16px;"> ***Kolekce (Collections)*** </span>

      <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

        <span style="display: block; padding-left: 100px; text-decoration: underline; font-size: 16px;">**Vlastnosti kolekcí**</span>

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      - lze přidávat, odebírat, procházet položky
      - počet položek se může měnit za běhu
      - kapacita prakticky neomezená (záleží na RAM)
      - dynamicky rostou podle potřeby

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      - **``List<dataType> listName = new List<dataType>();``**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        - **seznamy (nepřátel, předmětů, efektů atd)**
        - čtení podle pozice položky (index), začíná **od 0**
        - procházení v pevném pořadí
        - hledá se pomaleji - musí projít všechny položky
        - `Add()`, `Remove()`, `Count`
        - použití na : seznam úkolů, hráčů, předmětů atd.

        <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

      - **`Dictionary<keyType, valueType> slovnik = new Dictionary<keyType, valueType>();`**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        - **slovník**
        - ukládáš věci pod názvem (klíčem)
        - rychlé vyhledání hodnoty podle klíče
        - `Add()`, `Remove()`, `ContainsKey()`
        - použití na : nastavení, statistiky, vyhledávání atd

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  [Zpět na obsah](#summary)

  <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

\| ❌ Žádná předešlá kapitola \| ⬆️ [Zpět na seznam souborů](index.md) \| [Další kapitola - Programovací logika](ControlFlow.md)➡️ \|
