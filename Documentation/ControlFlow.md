# Řízení toku programu

<a id="summary"></a><span style="font-size: 16px;">**Obsah:**</span>
<!-- TOC -->
1. [Podmínky](#conditionals)
2. [Cykly](#loops)
3. [Výjimky](#exception-handling)
4. [Řídící příkazy](#control-statemens)
<!-- /TOC -->

## Rozdělení

- <a id="conditionals"></a><span style="font-size: 18px;"> ***Podmínky (Conditionals / Selection statements)*** </span>
<br>

  - **`if`, `else if`, `else`**

    - **základní větvení** programu dle podmínky
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

       <br>

  - **`switch`, `case`, `default`**

    - **výběr z více možností**
    - lepší než řetězec *if-else*
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
        switch (playerstate)
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

        <br>

  - **Ternární operátor `? :`**

    - **zkratka** pro `if-else`
    - **syntaxe: `condition ? trueValue : falseValue`**
    - **kratší zápis**
    - přehlednost
    - rychlejší psaní

    - **Použití:**
      - jednoduchá podmínka
      - přiřazení hodnoty do proměnné
      - kód zůstane čitelný
        - **Příklady správného použití:**

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

        <br>

    - **⚠️ Nepoužívat, když:**
      - podmínka je složitá
      - potřebuješ provést více příkazů
      - kód by byl hůře čitelný
        - **Příklady špatného použití**

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
            Math.Sqrt(ComplexCalculatio(x) + AnotherComplexMethod(y)) :
            ProcessNegativeValue(TransformInput(x, y));
        ```

[Zpět na obsah](#summary)<br>

- <a id="loops"></a><span style="font-size: 18px;"> **Cykly (Loops / Iteration statements)** </span>
<br>

  - **`for`**
    - opakuje několikrát kód v něm obsažený
    - když je **předem znám** počet opakování
    - **syntaxe: `for (initialization; condition; increment) { code; }`**
      - **Herní příklad:**

        ```csharp
        // Začni na 0, pokračuj dokud i < počtu nepřátel,
        // po každém kroku i zvyš o 1
        for (int i = 0; i < enemies.Length; i++) 
        {
            enemies[i].Attack(); // Útok nepřítele na pozici 'i' v indexu
        }
        ```

    <br>

  - **`foreach`**
    - procházení kolekcí (List, pole)
    - zopakuje blok kódu pro **každou** položku v kolekci
    - nemusí se řešit indexy
    - používá se datový typ co je v kolekci uložen
    - **syntaxe: `foreach (type variable in collectionName) { code; }`**
      - **Herní příklad:**

        ```csharp
        // Zkontroluj každý item v inventáři, jestli se dá použít
        foreach (Item item in player.Inventory)
        {
            item.CheckIfUsable();
        }
        ```

    <br>

  - **`while`**
    - opakuje kód, **dokud platí** podmínka
    - když **není znám** předem počet opakování
    - **⚠️ pozor na nekonečné cykly** - podmínka se **musí někdy změnit**
    - **syntaxe: `while (condition) { code; }`**
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

    <br>

  - **`do-while`**
    - kód se **nejdříve provede**, pak se kontroluje podmínka
    - zaručuje **alespoň jedno provedení**
    - **syntaxe: `do { code; } while (condition);`**
      - **Herní příklad:**

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

    <br>

[Zpět na obsah](#summary)<br><br>

- <a id="exception-handling"></a><span style="font-size: 18px;"> **Výjimky (Exception Handling / Exception-handling statements)** </span>

  - B
  - B
  - B

[Zpět na obsah](#summary)<br>

- <a id="control-statemens"></a><span style="font-size: 18px;"> **Řídící příkazy (Control Statements / Jump statements)** </span>

  1. B
  2. B
  3. B

<br>[Zpět na obsah](#summary)<br><br>

\| ⬅️[Datové typy](ValueTypes.md) \| ⬆️ [Zpět na seznam souborů](index.md) ⬆️ \| [Další kapitola - Programovací logika](ControlFlow.md)➡️ \|
