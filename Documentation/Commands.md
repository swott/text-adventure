# Příkazy

## Datové typy

- <span style="font-size: 18px;"> **Hodnotové typy (Value types)** </span>

  - <span style="font-size: 16px;"> **Celočíselné** </span>
  
    1. `int`
  
       - **výchozí** pro celá čísla
       - rozsah -2,1M - 2,1M
  
    2. `byte`
  
       - paměťově úsporný
       - rozsah 0-255

    3. `long`
  
       - pro **velmi velká** celá čísla
       - když `int` nestačí
  

  - <span style="font-size: 16px;"> **Desetinná čísla** </span>

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

- <span style="font-size: 16px"> **Logické a znakové typy** </span>

    1. `bool`

        - **logické podmínky** - true / false

    2. `char`

        - jeden Unicode znak

- <span style="font-size: 16px"> **Uživatelské hodnotové typy** </span>

    1. `struct`

        - pro malé datové struktury (jako ID, pozice)
        - chová se jako číslo - při přiřazení se kopíruje
        - použít pro data, která jsou jednoduchá a neměnná

    2. `enum`

        - **výčtový typ** pro předdefinované možnosti (dny, stavy)
        - **částečně** nahrazuje if/else pro výběr z předem daných možností
        - zlepšuje čitelnost kódu
        - **občas** se používá s throw

## 2. Řízení toku programu

## 3. Metody a funkce
