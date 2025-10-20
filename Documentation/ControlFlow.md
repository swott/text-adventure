# Řízení toku programu

---

<a id="summary"></a><span style="font-size: 16px;">**Obsah:**</span>
<!-- TOC -->

1. [Podmínky](#conditionals)
  
    <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

   - [`if-else`](#if-else)
   - [`switch`](#switch)
   - [`? : - Ternární operátor`](#ternary-operator)

    <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

2. [Cykly](#loops)

    <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

     - [`for`](#for)
     - [`foreach`](#foreach)
     - [`while`](#while)
     - [`do-while`](#do-while)

    <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

3. [Výjimky](#exception-handling)

    <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

    - [`try-catch`](#try-catch)
    - [`throw`](#throw)
    - [`finally`](#finally)

    <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

4. [Řídící příkazy](#control-statemens)

   <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

    - [`break`](#break)
    - [`continue`](#continue)
    - [`return`](#return)

    <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->
<!-- /TOC -->

---

## Rozdělení

- <a id="conditionals"></a><span style="font-size: 18px;"> ***Podmínky (Conditionals / Selection statements)*** </span>
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`if`, `else if`, `else`** <a id="if-else"></a>

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

  - **`switch`, `case`, `default`** <a id="switch"></a>

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

  - **Ternární operátor `? :`** <a id="ternary-operator"></a>

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

  - **`for`** <a id="for"></a>

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
            // Útok nepřítele na pozici 'i' v indexu
            enemies[i].Attack(); 
        }
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`foreach`** <a id="foreach"></a>

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

  - **`while`** <a id="while"></a>

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - opakuje kód, **dokud platí** podmínka
    - když **není znám** předem počet opakování
    - ⚠️ **pozor na nekonečné cykly** ⚠️
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

  - **`do-while`** <a id="do-while"></a>

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
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - ⚠️<span style="text-decoration: underline; font-size: 16px;">***Základní informace***</span>⚠️

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

    - **nechytej (catch) výjimky, které neumíš vyřešit!**
    - jak výjimku "vyřešíš", je **na tobě**
    - z **některých** se program **dokáže vzpamatovat**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - chyby při čtení souborů
      - validace uživatelských požadavku
      - a další

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - z **některých** se program **nevzpamatuje**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - došla operační paměť
      - nelze načíst kritickou knihovnu (library)
      - a další

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      ```csharp
      // Špatně - skrývání chyb:
      try { EntireGame(); }
      
      // Prázdný catch!
      catch (Exception) { }
      ---------------------------
      // Správně - ošetřuji jen konkrétní chyby
      try { LoadFile(); }

      // Toto už se dá řešit!
      catch (FileNotFoundException) { CreateFile(); }
      ```

      <span style="display: block; height: 1.6em;"></span> <!--"Nový řádek"-->

  - **``try-catch``** <a id="try-catch"></a>
  
    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->
  
    - **Při možnosti selhání kódu**
      - načítání souboru, síťová komunikace, práce s databází
    - **nejprve se pokusí provést** kód v `try` blocku
    - při chybě program **nespadne, ale jde** do `catch` bloku

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Syntaxe:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

          ```csharp
          try
          {
            // Kód, co může způsobit chybu
            dangerousOperation();
          }

          catch (ExceptionType variableName)
          {
            // Co se má stát, když chyba nastane
            Console.WriteLine($"Error: {variableName.Message}");
          }
          ```

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

          ```csharp
          try
          {
            // Pokus načíst uloženou hru
            GameSaveManager.LoadSave("autosave.dat");
          }

          catch (FileNotFoundException ex)
          {
            // Pokud soubor neexistuje, vytvoříme novou hru
            Console.WriteLine($"Save file not found: {ex.Message}");
            CreateNewGame();
          }

          catch (IOException ex)
          {
            // Obecná chyba práce se souborem
            Console.WriteLine($"File error: {ex.Message}");
          }
          ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`throw`** <a id="throw"></a>
  
    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->
  
    - ručně vyhodí výjimku a přeruší normální běh programu
    - **signál** neplatné situace (špatný vstup, neplatný stav)
    - **syntaxe: `throw new ExceptionType("Error description");`**

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        public void UseItem(Item item)
        {
          // Kontrola vstupních parametrů
          if (item == null)
              
              throw new ArgumentNullException(nameof(item), "Item cannot be null);

          // Kontrola herní logiky
          if (!inventory.Contains(item))
              
              throw new InvalidOperationException("Item not in inventory");

          // Pokud vše OK, použij item
          item.Use();
        }
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`finally`** <a id="finally"></a>

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - kód se **vždy** provede (ať nastala chyba nebo ne)
    - **zabránění úniku** zdrojů - **RESOURCE LEAK** ⚠️
    - **bezpečnost** - uvolnění zámků, spojení, souborů

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      - **Příklady** zdrojů nutných k **uvolnění/uzavření:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        - 📁 **Soubory** - musí se zavřít (nelze je pak otevřít)
        - 🌐 **Síťová spojení** - musí se ukončit ("pořád online"")
        - 💾 **Databázové spojení** - musí se uzavřít (jinak nelze zapisovat)
        - 🔒 **Zámky a mutexy** - musí se zavřít (ochrana dat při vícenásobném přístupu)
        - 🎮 **Herní zdroje** - textury, audio musí být uvolněny

        <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

      - **Syntaxe:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        try
        {
          // Práce s něčím důležitým
        }

        catch (Exception ex)
        {
          // Ošetření chyby
        }

        finally
        {
          // TOTO se provede VŽDY!
          CloseFile();
        }
        ```

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Příklady s RESOURCE LEAK**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        // ⬇️ Klasičtější příklad RESOURCE LEAK ⬇️

        FileStream file;

        try
        {
          // Práce se souborem
          file = File.Open("save.dat");
          ReadGameData(file);
        }
        catch (Exception ex)
        {
          // ⚠️ Když nastane chyba, soubor se nemusí zavřít - ÚNIK ZDROJŮ ⚠️
          Console.WriteLine($"Chyba: {ex.Message}");
          
          //Výjimku znovu vyhodíme a volající ji musí dále zpracovat 
          throw ex;
        }
        // Musí se dopsat TOTO:
        finally
        {
          file.Close()
        }
        // Kdyby následovalo
        // file.Close()
        // Při výjimce by k tomuto volání nedošlo
        ```

        ```csharp
        // ⬇️ Herní příklad RESOURCE LEAK ⬇️

        public void LoadAllTextures()
        {
          foreach (string textureName in textureList)
          {
            try
            {
              // Načte texturu do paměti
              Texture2D texture = LoadTexture(textureName);
              textures.Add(texture);
            }

            catch
            {
              // Chyba při načítání textury - přeskoč na další
              Console.WriteLine("Texture is not loaded");
              continue;
            }

            // ⚠️ Ale, bez finally, by se po pár chybách sekala hra! ⚠️
            ------------------------------------------------------------
            // Zatímco takto...

            finally
            {
              // Se uklidí i PŘI CHYBĚ!
              if (texture != null && !textures.Contains(texture))
                  texture.Dispose();
            }

          }
        }
        ```

        <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        Texture2D oldTexture = player.GetTexture();
        Texture2D texture = null;

        try
        {
          // Načti texturu a použij ji pro hráče
          texture = Content.Load<Texture2D>("hero.png");
          player.SetTexture(texture);
        }

        catch (ContentLoadException ex)
        {
          // Když se nenačte textura, použij náhradní
          Console.WriteLine($"Texture: {ex.Message} cannot be loaded!");
          texture = CreateDefaultTexture();
        }
        
        finally
        {
          // ⚠️ Ať už se textura načetla nebo ne,
          //      stará se MUSÍ UKLIDIT! ⚠️
          if (oldTexture != null)
              oldTexture.Dispose();
        }
        ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

    [Zpět na obsah](#summary)

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

- <a id="control-statemens"></a><span style="font-size: 18px;"> **Řídící příkazy (Control Statements / Jump statements)** </span>
<span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`break`** <a id="break"></a>
  
    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->
  
    - **okamžité ukončení** cyklu nebo switch
    - při nutnosti **předčasně skončit:**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **nález** hledané položky (nemusí se procházet zbytek)
      - podmínka pro pokračování **přestala platit**
      - **nastala chyba** nebo neočekávaná situace (selhalo načítání)
      - uživatel **zadal příkaz k přerušení** (ESC, nebo zrušit)
  
    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **syntaxe: `break;`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        foreach (Enemy enemy in enemies)
        {
          if (enemy.Type == EnemyType.Boss)
          {
              AttackBoss(enemy);
              break; // Našli jsme bosse, končíme hledání
          }
        }
        ```

    <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`continue`** <a id="continue"></a>
  
    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->
  
    - **přeskočení** aktuální iterace (opakování) cyklu
    - **pokračování s další položkou** v kolekci
    - potřeba **přeskočit položky**, ale **bez ukončení cyklu:**
  
      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **nerelevantní položka** pro aktuální operaci
      - **splněna podmínka** položky - není už potřeba použít
      - **špatný stav** položky - (neaktivní, neplatný, mrtvý)
      - zpracovává se **pouze část** položek

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **syntaxe: `continue;`**

      <span style="display: block; height: 0.4em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

        ```csharp
        // Projdi všechny nepřátele, ale mrtvé přeskoč
        foreach (Enemy enemy in enemies)
        {
          // Přeskočení mrtvých
          if (enemy.IsDead)
              continue;
          
          // Aktualizování živých nepřátel
          enemy.UpdateAi();
          enemy.move();
        }
        ----------------------------------------------
        // Zpracuj předměty určité kvality
        foreach (Item item in player.inventory)
        {
          // Přeskoč běžné
          if (item.Quality < ItemQuality.Rare)
              continue;

          // Použij jen vzácné
          ApplySpecialEffect(item);
        }
        ```

      <span style="display: block; height: 0.6em;"></span> <!--"Nový řádek"-->

  - **`return`** <a id="return"></a>

    <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **návrat z metody** s možností vrácení hodnoty
    - **okamžité ukončení** metody a předání výsledku
    - **předčasné dokončení** metody nebo **vrácení výsledku**

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - metoda **dokončila úkol** s výsledkem
      - **chyba nebo neplatný stav**
      - **nesplněná podmínka** - předčasný návrat
      - **validace vstupů** - neplatné parametry

      <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

    - **syntaxe:**

        <span style="display: block; height: 0.3em;"></span> <!--"Nový řádek"-->

      - **`return;`** pro `void` metody
      - **`return value;`** pro metody s návratovým typem

        <span style="display: block; height: 0.8em;"></span> <!--"Nový řádek"-->

      - **Herní příklad:**

        ```csharp
        // Metoda vracející poškození zbraně
        public int CalculateDamage(Weapon weapon, Player player)
        {
            // Validace vstupů - předčasný návrat
            if (weapon == null)
                return 0;
            
            // Podmínka nebyla splněna - předčasný návrat
            if (player.Strength < weapon.RequiredStrength)
                return weapon.BaseDamage / 2;
            
            // Normální návrat s výsledkem
            return weapon.BaseDamage + player.Strength;
        }
        ---------------------------------------------------------
        // Metoda pro kontrolu, zda může hráč použít schopnost
        public bool CanUseAbility(Player player, Ability ability)
        {
            // Různé důvody pro předčasný návrat
            if (player.Mana < ability.ManaCost)
                return false;
            
            if (ability.IsOnCooldown)
                return false;
            
            if (player.IsStunned)
                return false;
            
            // Všechny podmínky splněny
            return true;
        }
        ```

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

    [Zpět na obsah](#summary)

    <span style="display: block; height: 1em;"></span> <!--"Nový řádek"-->

\| ⬅️[Datové typy](ValueTypes.md) \| ⬆️ [Zpět na seznam souborů](index.md) ⬆️ \| [Další kapitola - WIP](index.md)➡️ \|
