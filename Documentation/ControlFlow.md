# Řízení toku programu

---

<a id="summary"></a><span style="font-size: 16px;">**Obsah:**</span>
<!-- TOC -->
1. [Podmínky](#conditionals)
2. [Cykly](#loops)
3. [Výjimky](#exception-handling)
4. [Řídící příkazy](#control-statemens)
<!-- /TOC -->

---

## Rozdělení

- <a id="conditionals"></a><span style="font-size: 18px;"> ***Podmínky (Conditionals / Selection statements)*** </span>
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`if`, `else if`, `else`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **základní větvení** programu dle podmínky

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->
      - **Syntaxe:**

        ```csharp
        if (condition) { code; }
        else if (another condition) { code; }
        else { code; }
        ```

      - **Herní příklad:**

        ```csharp
        if (health <= 0)
        {
           Die();
        }
        else if (health < 20)
        {
           ShowLowHealthWarning();
        }
        else
        {
           ContinueGame();
        }
        ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - **`switch`, `case`, `default`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **výběr z více možností**
    - lepší než řetězec *if-else*
      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->
      - **Syntaxe:**

        ```csharp
        switch (variable)
        {
           case value1: code; break;
           case value2: code; break;
           default: code; break;
        }
        ```

      - **Herní příklad**

        ```csharp
        switch (playerState)
        {
            case PlayerState.Running:
                PlayRunAnimation();
                break;
            case PlayerState.Jumping:
                PlayJumpAnimation();
                break;
            default:
                PlayIdleAnimation();
                break;
        }
        ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

  - **Ternární operátor `? :`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **zkratka** pro `if-else`
    - **syntaxe: `condition ? trueValue : falseValue`**
    - **kratší zápis**
    - přehlednost
    - rychlejší psaní

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->
    - **Použití:**
      - jednoduchá podmínka
      - přiřazení hodnoty do proměnné
      - kód zůstane čitelný

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

        - **Příklady správného použití:**

            <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

            ```csharp
            // Pokud je přes osmnáct, je dospělý
            string message = (age >= 18) ? "Dospělý" : "Dítě"; 

            // Přiřazení hodnoty
            int number = 10;
            string result = (number > 5) ? "Větší než 5" : "Menší nebo rovno 5";
            Console.WriteLine(result); // Vypíše: "Větší než 5"

            // S čísly
            int score = 85;
            string grade = (score >= 90) ? "A" : 
                (score >= 80) ? "B" : 
                (score >= 70) ? "C" : "F";
            Console.WriteLine(grade); // Vypíše: "B"

            // Vrácení hodnoty z metody
            public string EvenOrUneven(int number)
            {
            return (number % 2 == 0) ? "Sudé" : "Liché";
            }  
            ```

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **⚠️ Nepoužívat, když:**

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - podmínka je složitá
      - potřebuješ provést více příkazů
      - kód by byl hůře čitelný

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

        - **Příklady špatného použití**

            <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

            ```csharp

            // ⬇️ Když je potřeba provést více příkazů ⬇️

            // Tohle NEFUNGUJE - TO může vracet jen hodnotu, ne provádět příkazy
            // Použití je pouze if-else
            bool jeAdmin = true;
            jeAdmin ? (
            Console.WriteLine("Vítejte admin"),
            LogLoginAttempt(),
            GrantPermissions()
            ) : Console.WriteLine("Přístup odepřen");

            // ⬇️ Složitě vnořené podmínky ⬇️

            // Hůře čitelné, přehlednější s if-else
            string result = (user != null) ? 
                   ((user.Age > 18) ? 
                   ((user.IsVerified) ? "Přístup povolen" : "Neověřený uživatel") : 
                  "Nedostatečný věk") : 
                   "Uživatel neexistuje";

            // ⬇️ Když je potřeba jen jedna větev (bez else) ⬇️

            // Špatně - vynucená else větev, i když není potřeba
            string message = (errorCount > 0) ? $"Počet chyb: {errorCount}" : null;
            if (message != null)
            Console.WriteLine(message);

            // ⬇️ Metody s VOID návratovým typem ⬇️

            // Špatně - TO musí vracet hodnotu
            // Správně je if-else
            (isValid) ? SaveToDatabase() : ShowError();

            // ⬇️ Když podmínka mění stav více proměnných

            int successCount = 0;
            int failCount = 0;

            // Hrozný kód - TO vrací hodnotu, která je ignorována
            _ = (operationSucceeded) ? successCount++ : failCount++;

            // ⬇️ Složité výpočty nebo volání metod ⬇️

            // Správně by to mělo být pomocí if-else rozloženo na části
            var result = (x > 0) ?
                Math.Sqrt(ComplexCalculation(x) + AnotherComplexMethod(y)) :
                ProcessNegativeValue(TransformInput(x, y));
            ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

    [Zpět na obsah](#summary)

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

- <a id="loops"></a><span style="font-size: 18px;"> **Cykly (Loops / Iteration statements)** </span>
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`for`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - opakuje několikrát kód v něm obsažený
    - když je **předem znám** počet opakování
    - **syntaxe: `for (initialization; condition; increment) { code; }`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        // Začni na 0, pokračuj dokud i < počtu nepřátel,
        // po každém kroku i zvyš o 1
        for (int i = 0; i < enemies.Length; i++) 
        {
            enemies[i].Attack(); // Útok nepřítele na pozici 'i' v indexu
        }
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`foreach`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - procházení kolekcí (List, pole)
    - zopakuje blok kódu pro **každou** položku v kolekci
    - nemusí se řešit indexy
    - používá se datový typ co je v kolekci uložen
    - **syntaxe: `foreach (type variable in collectionName) { code; }`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        ```csharp
        // Zkontroluj každý item v inventáři, jestli se dá použít
        foreach (Item item in player.Inventory)
        {
            item.CheckIfUsable();
        }
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`while`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - opakuje kód, **dokud platí** podmínka
    - když **není znám** předem počet opakování
    - **⚠️ pozor na nekonečné cykly** - podmínka se **musí někdy změnit**
    - **syntaxe: `while (condition) { code; }`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad**

        ```csharp
         // Hráč hází kostkou dokud nepadne 6
        int diceRoll = 0;
        while (diceRoll != 6)
        {
            diceRoll = Random.Range(1, 7);
            Console.WriteLine($"Padlo: {diceRoll}");
        }
        Console.WriteLine("Konečně šestka!");
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`do-while`**

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - kód se **nejdříve provede**, pak se kontroluje podmínka
    - zaručuje **alespoň jedno provedení**
    - **syntaxe: `do { code; } while (condition);`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        // Hráč musí zadat platné jméno (alespoň jednou se zeptá)
        string playerName;
        do 
        {
          Console.Write("Zadej své jméno: ");
          playerName = Console.ReadLine();
        } 
        while (string.IsNullOrEmpty(playerName));
      
        Console.WriteLine($"Vítej, {playerName}!");
        ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

    [Zpět na obsah](#summary)

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

- <a id="exception-handling"></a><span style="font-size: 18px;"> **Výjimky (Exception Handling / Exception-handling statements)** </span>
<span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

  - B
  - B
  - B

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

    [Zpět na obsah](#summary)

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

- <a id="control-statemens"></a><span style="font-size: 18px;"> **Řídící příkazy (Control Statements / Jump statements)** </span>
<span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

  1. B
  2. B
  3. B

<span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

[Zpět na obsah](#summary)

<span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

\| ⬅️[Datové typy](ValueTypes.md) \| ⬆️ [Zpět na seznam souborů](index.md) ⬆️ \| [Další kapitola - Programovací logika](ControlFlow.md)➡️ \|
