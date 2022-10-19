//Pedro Castaneda
//10-19-2022
//Restaurant Picker
//Create a program that asks user what our of the four types of food they are in the mood for. When they pick a category it will randomly generate 1 restaurant out of 10. user can choose to regenerate again or return to main menu.
//Peer Review is in READ.Me

bool run = true;
bool runCategory = true;
bool invalidAnswer = false;
string[] european = {"German Guys: 10438 Waterloo Road Highway 88, Stockton, CA 95212-9206", "Angelinas: 1563 E Fremont, Stockton, CA 95205", "The Old Spaghetti Factory: 2702 W March Ln, Stockton, CA 95219", "Strings Italian Cafe: 10628 Trinity Pkwy, Stockton, CA 95219", "Midtown Creperie & Cafe: 2311 Pacific Ave, Stockton, CA 95204", "Finnegan's Irish Pub & Restaurant: 6002 Pacific Ave, Stockton, CA 95207", "Kabob and Gyro House: 225 E Channel St Ste B, Stockton, CA 95202", "La Boulangerie: 2324 Grand Canal Blvd, Stockton, CA 95207", "Go Falafel Greek Food: 236 W Alpine Ave, Stockton, CA 95204", "Mezzo: 3499 Brookside Rd, Stockton, CA 95219"};
string[] asian = {"Pho Island", "Lotus Thai & Khmer Cuisines", "Spice it up!", "Jimmies Place", "Seoul Soon Dubu Tofu House", "Siamese Street Thai Restaurant", "Thai Me Up", "Mama's Pho & Sandwhiches", "Maroo Korean BBQ and Catering", "Saigon Bowl Noodle House"};
string[] latin = {"El Patio", "Cafe Platano Bar & Grill", "MasaLatina Latin American Kitchen", "Gladys Taqueria Y Pupuseria", "La Santaneca Pupuseria", "Streetzlan", "Reyes Pupuseria Y Taqueria", "Jalisco's Restaurant", "El Ranchito Restaurant", "El Comal Taco Truck"};
string[] american = {"The Kitchen at StoneBrier", "Market Tavern", "Wildfire Public House", "The Well", "FED", "The Black Rabbit", "Cast Iron Trading", "Fat City Brew & BBQ", "Prime Table", "Nash & Tender"};
Random r = new Random();
int resPicked;
string input;

while(run)
{
    invalidAnswer = false;
    Console.WriteLine("***Restaurant Picker***");
    Console.WriteLine("Choose option below (enter number or name)");
    Console.WriteLine("1. European");
    Console.WriteLine("2. Asian");
    Console.WriteLine("3. Latin");
    Console.WriteLine("4. American");
    Console.WriteLine("5. Exit");
    while(!invalidAnswer)
    {
        input = Console.ReadLine().ToLower();
        if(input == "1" || input == "euro" || input == "european")
        {
            EuroRes();
            invalidAnswer = true;
        }
        else if(input == "2" || input == "asian")
        {
            AsianRes();
            invalidAnswer = true;
        }
        else if(input == "3" || input == "latin")
        {
            LatinRes();
            invalidAnswer = true;
        }
        else if(input == "4" || input == "american")
        {
            AmericanRes();
            invalidAnswer = true;
        }
        else if(input == "5" || input == "exit")
        {
            invalidAnswer = true;
            run = false;
        }
        else
        {
            Console.WriteLine("Please enter number or name!");
            invalidAnswer = false;
        }
    }
}

void EuroRes()
{   
    runCategory = true;
    while(runCategory)
    {
        invalidAnswer = false;
        resPicked = r.Next(0, european.Length);
        Console.WriteLine($"We recommend: {european[resPicked]}");
        Console.WriteLine("");
        Console.WriteLine("Would you like to generate antoher restaurant or return to main menu? (gen/return)");
        while(!invalidAnswer)
        {
            input = Console.ReadLine().ToLower();
            if(input == "gen")
            {
                invalidAnswer = true;
                runCategory = true;
            }
            else if(input == "return")
            {
                invalidAnswer = true;
                runCategory = false;
            }
            else
            {
                Console.WriteLine("Please enter gen or return!");
                invalidAnswer = false;
            }
        }
    }
}

void AsianRes()
{
    runCategory = true;
    while(runCategory)
    {
        invalidAnswer = false;
        resPicked = r.Next(0, asian.Length);
        Console.WriteLine($"We recommend: {asian[resPicked]}");
        Console.WriteLine("");
        Console.WriteLine("Would you like to generate antoher restaurant or return to main menu? (gen/return)");
        while(!invalidAnswer)
        {
            input = Console.ReadLine().ToLower();
            if(input == "gen")
            {
                invalidAnswer = true;
                runCategory = true;
            }
            else if(input == "return")
            {
                invalidAnswer = true;
                runCategory = false;
            }
            else
            {
                Console.WriteLine("Please enter gen or return!");
                invalidAnswer = false;
            }
        }
    }
}

void LatinRes()
{   
    runCategory = true;
    while(runCategory)
    {
        invalidAnswer = false;
        resPicked = r.Next(0, latin.Length);
        Console.WriteLine($"We recommend: {latin[resPicked]}");
        Console.WriteLine("");
        Console.WriteLine("Would you like to generate antoher restaurant or return to main menu? (gen/return)");
        while(!invalidAnswer)
        {
            input = Console.ReadLine().ToLower();
            if(input == "gen")
            {
                invalidAnswer = true;
                runCategory = true;
            }
            else if(input == "return")
            {
                invalidAnswer = true;
                runCategory = false;
            }
            else
            {
                Console.WriteLine("Please enter gen or return!");
                invalidAnswer = false;
            }
        }
    }
}

void AmericanRes()
{   
    runCategory = true;
    while(runCategory)
    {
        invalidAnswer = false;
        resPicked = r.Next(0, american.Length);
        Console.WriteLine($"We recommend: {american[resPicked]}");
        Console.WriteLine("");
        Console.WriteLine("Would you like to generate antoher restaurant or return to main menu? (gen/return)");
        while(!invalidAnswer)
        {
            input = Console.ReadLine().ToLower();
            if(input == "gen")
            {
                invalidAnswer = true;
                runCategory = true;
            }
            else if(input == "return")
            {
                invalidAnswer = true;
                runCategory = false;
            }
            else
            {
                Console.WriteLine("Please enter gen or return!");
                invalidAnswer = false;
            }
        }
    }
}