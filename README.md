# SI_Devoir6
## Exercice — Pizza Builder (5 patrons)  10 points
    • Class diagram avec draw.io  7 points
    • Code C#    3 point

Créer un système de commande de pizza qui utilise :
    • Builder (construire la pizza)
    • Chain of Responsibility (pipeline de préparation)
    • Observer (notifications)
    • Decorator (extras dynamiques)
    • State (états de la commande)

## 1) Builder (Pizza)
Pizza (size, dough, sauce, toppings, price)
3 types de pizza:
    • Italian,
    • hawaiian,
    • vegetarian

## 2) Chain of Responsibility (préparation)

    a. Chaîne obligatoire : 
    b. ValidateOrderHandler
    c. PrepareHandler
    d. BakeHandler
    e. CutHandler
    f. PackHandler
    g. DispatchHandler


Attention : Chaque handler : 
exécute son étape
met à jour l’état (State) + notifie (Observer)
stoppe si erreur (ex: commande invalide)
## 3) Observer (notifications)
    • IOrderObserver
    • CustomerAppObserver
    • KitchenScreenObserver
    • DeliveryAppObserver
À chaque changement d’état, notifier tous les observers.

## 4) Decorator (extras)
Créer une interface IPizzaComponent avec :
    • GetDescription()
    • GetPrice()

Créer des decorators:
    • ExtraCheeseDecorator
    • StuffedCrustDecorator
    • SpicySauceDecorator
    • GlutenFreeDecorator
Appliquer 0..N decorators après le Build().

## 5) State (états de commande)
États minimum :
    a) Created
    b) Validated
    c) Preparing
    d) Baking
    e) Packed
    f) Dispatched
    g) Delivered
    h) Cancelled

Règles :
transitions autorisées uniquement (ex: pas Baking → Created)
un handler Chain of Responsibility déclenche la transition correspondante
 Scénario de test :
    1. Construire une pizza (Builder)
    2. Ajouter 2 extras (Decorator)
    3. Attacher 3 observers (Observer)
    4. Lancer la chaîne (Chain of Responsibility)
    5. Afficher :
        5.1. description + prix final
        5.2. historique des états
        5.3. messages reçus par observers
