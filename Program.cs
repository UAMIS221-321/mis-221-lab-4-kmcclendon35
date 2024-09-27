Random random = new Random();
DisplayMenu();
string userChoice = "";
while(userChoice != "4"){
    DisplayMenu();
    userChoice = GetUserChoice();
    int randomRows = random.Next(8,13);
    RouteThem(userChoice, randomRows, random);
}

static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("What kind of pizza would you like?\n1. Plain topping-less pizza slice\n2. Cheese pizza slice\n3. Pepperoni pizza slice\n4. Exit");
}
static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteThem(string userChoice, int randomRows, Random random){
    switch(userChoice){
        case "1":
            Console.Clear();
            PlainPizza(randomRows);
            break;
        case "2":
            Console.Clear();
            CheesePizza(randomRows);
            break;
        case "3":
            Console.Clear();
            PepperoniPizza(randomRows, random);
            break;
        case "4":
            ExitProgram();
            break;
        default:
            InvalidInput();
            break;
    }
}

static void PlainPizza(int randomRows){
    System.Console.WriteLine("Plain Pizza - Rows: " + randomRows);
    for(int i = randomRows; i >= 0; i--){
        for(int j = 1; j <= i; j++){
            Console.Write("*\t");
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void CheesePizza(int randomRows){
    System.Console.WriteLine("Cheese Pizza - Rows: " + randomRows);
    for(int i = randomRows; i >= 0; i--){
        for(int j = 1; j <= i; j++){
            if(j == 1 || j == i || i == 0 || i == randomRows){
                System.Console.Write("*\t");
            } else {
                System.Console.Write("#\t");
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}

static void PepperoniPizza(int randomRows, Random random){
    System.Console.WriteLine("Pepperoni Pizza - Rows: " + randomRows);
    int randomValue = random.Next(1,10);
    int pepperonisPlaced = 0;
    for(int i = randomRows; i >= 0; i--){
        for(int j = 1; j <= i; j++){
            if(j == 1 || j == i || i == 0 || i == randomRows){
                System.Console.Write("*\t");
            } else {
                if(pepperonisPlaced < randomValue && random.Next(0, 2) == 0) {
                    Console.Write("[]\t"); 
                    pepperonisPlaced++;
                } else {
                System.Console.Write("#\t");
                }
            }
        }
        System.Console.WriteLine();
    }
    Pause();
}
static void ExitProgram(){
    System.Console.WriteLine("Goodbye");
}

static void InvalidInput(){
    System.Console.WriteLine("Invalid input");
    Pause();
}
static void Pause(){
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}
