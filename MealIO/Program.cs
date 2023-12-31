namespace MealIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
		// test
        start:
            Console.Title = "MealIO (meal generator)";
            string title = @"
			
                   :-                                                                     
                    ++                                                                    
                 .  +*                                                                    
               :+  :=      -----:                                . . . .-. .   .-. .-. .  . .-.   .-. .-.                          
              -#.   ::-::--+--::-                                | | | |-  |   |   | | |\/| |-     |  | |                           
              ## .+=: -+*#########*+=:                           `.'.' `-' `-' `-' `-' '  ` `-'    '  `-'                           
              :*:.--==++**#############=                                                  
                .           ..::--==++**+              ___           ___           ___           ___                    ___               
              .+#######################*+             /  /\         /  /\         /  /\         /  /\       ___        /  /\            
          .====.#=::###################+:====        /  /::|       /  /::\       /  /::\       /  /:/      /__/\      /  /::\              
          .====##:  ####################*====       /  /:|:|      /  /:/\:\     /  /:/\:\     /  /:/       \__\:\    /  /:/\:\            
                #:  ###################*           /  /:/|:|__   /  /::\ \:\   /  /::\ \:\   /  /:/        /  /::\  /  /:/  \:\                             
                #:  ###################+          /__/:/_|::::\ /__/:/\:\ \:\ /__/:/\:\_\:\ /__/:/      __/  /:/\/ /__/:/ \__\:\                            
                #:  ###################+          \__\/  /~~/:/ \  \:\ \:\_\/ \__\/  \:\/:/ \  \:\     /__/\/:/    \  \:\ /  /:/                            
                #:  ###################+                /  /:/   \  \:\ \:\        \__\::/   \  \:\    \  \::/      \  \:\  /:/                             
                *-..###################+               /  /:/     \  \:\_\/        /  /:/     \  \:\    \  \:\       \  \:\/:/                             
                .-====================-                \__\/         \__\/         \__\/       \__\/     \__\/        \__\__/     ";

            Console.WriteLine(title);

            Console.WriteLine("\nMAIN MENU:");
            Console.WriteLine("\n>>  Press ENTER to Start");
            Console.WriteLine(">>  Press DOWN ARROW for Tutorial");
            Console.WriteLine(">>  Press UP ARROW for About");

            ConsoleKeyInfo keyPressed = Console.ReadKey(true);


            if (keyPressed.Key == ConsoleKey.Enter)
            {
                Console.WriteLine(" ");
            }

            else if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                Console.Write("MealIO Tutorial:");
                Console.Write("\n");
                Console.Write("We would need to ask the specifications below:\n-Budget\n-Appetite\n-Main Dish\n-Methods of Cooking");
                Console.Write("\nFor each of these specifications, there would be choices, so just pick the number that best suits your pallete");
                Console.Write("\nFor example, for the budget section, \n1. low\n2. mid\n3. high");
                Console.Write("\nJust pick one of the choices then you would proceed to the next section\nThat is all!");
                Console.Write("\nPress enter to start program. ");
                Console.ReadKey();
            }

            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                Console.WriteLine("MealIO is a project made for partial fulfillment of the requirements for the subject ITEC 102.");
                Console.WriteLine("\nBackground: The creators of this program was greatly inspired by their everyday dilemma of 'what to cook'.");
                Console.WriteLine("This program has the intent of helping students in deciding their meal of the day.");
                Console.WriteLine("\nA very simple program for a great cause. That's MealIO.");
                Console.WriteLine("\n\nMade by BSCS1A students: \nCataluna, Guia Marie C. \nFlores, Melea Sophia M. \nNapili, Alezandra M. \nS.Y. 2023-2024");
                Console.WriteLine("\n\nYou will automatically proceed to the program. Press any key.");
                Console.ReadKey();
            }

            Console.Clear();
            char budget = GetChoice("How much budget do you have for this meal?:\n1. low\n2. mid\n3. high\n= ", new char[] { '1', '2', '3' });
            char appetite = GetChoice("\nWhat level is your appetite?:\n1. low\n2. mid\n3. high\n= ", new char[] { '1', '2', '3' });
            char main = GetChoice("\nWhat is your main dish?\n1. chicken\n2. canned\n3. fish\n4. beef\n5. vegetable\n6. instant noodles\n7. frozen foods\n8. pork\n= ", new char[] { '1', '2', '3', '4', '5', '6', '7', '8' });
            char method = GetChoice("\nWhat cooking method do you prefer for your meal?\n1. stew\n2. steamed\n3. saute\n4. fried\n5. soup\n= ", new char[] { '1', '2', '3', '4', '5' });

            string mealCode = $"{budget}{appetite}{main}{method}";

            Console.Clear();
            switch (mealCode)
            {
                //low appetite
                //chicken
                case "1111":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Chicken Tinola \n\nIngredients: \n1/2 kg chicken, cut into serving pieces \n1 tablespoon cooking oil \nhalf onion, peeled and sliced \n2 cloves garlic, minced \n1 thumb-sized ginger, julienned \n1 bunch of malunggay leaves \nSalt to taste \nGround black pepper to taste \n1.5 liters water \n\nInstructions: \n1. In a pot, heat cooking oil over medium heat. Sauté garlic, onion, and ginger until fragrant. \n2. Add the chicken pieces and cook until they start to turn brown. \n3. Pour water into the pot and bring it to a boil. Simmer until the chicken is almost tender. \n4. Add the sliced green papayas (or chayote) to the pot and cook until they start to soften. (optional) \n5. Season the salt and ground black pepper according to your taste. \n6. Add malunggay leaves. Cook until the leaves are wilted.");
                    break;
                case "1112":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Simple Steamed Chicken Recipe \n\nIngredients: \n4 small boneless, skinless chicken thighs or drumsticks \n2 tablespoons soy sauce \n1 tablespoon oyster sauce (optional) \n1 teaspoon oil \n1 teaspoon sugar \n1/2 teaspoon black pepper \n1-inch piece of ginger, sliced \n\nInstructions: \n1. Clean and pat dry the chicken thighs or drumsticks. \n2. In a bowl, mix soy sauce, oyster sauce, sesame oil, sugar, black pepper,and sliced ginger. Stir well to combine. \n3. Coat the chicken pieces with the marinade, ensuring they are well covered. Allow it to marinate for at least 15-30 minutes. \n4. Prepare your steamer. If you don't have a steamer, you can use a large pot with a steaming rack or a makeshift \nsteamer using a heatproof plate or bowl placed inside a larger pot. \n5. Place the marinated chicken pieces on the steaming rack or in the makeshift steamer. Ensure some space between the pieces for even cooking. \n6. Steam the chicken for about 20-25 minutes or until cooked through. The internal temperature of the chicken should reach 165°F (74°C). \n7. Once the chicken is cooked, garnish with chopped green onions or cilantro if desired.");
                    break;
                case "1113":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Ginisang Sayote with Chicken \n\nIngredients: \n1/2 kilos Sayote or Chayote, about 2 small pcs \n300 grams Chicken breast sliced \n2 pcs tomatoes sliced \n1 pc red onion chopped finely\n2 cloves Garlic minced\n1 Tbsp. Fish sauce or patis \n2 cubes Knorr chicken broth cubes \n2 Tbsp. Cooking oil \n1 cup water \n\nInstructions: \n1. Before peeling the sayote, cut the top about half an inch and allow the sap to flow then rub it with the top you removed from the sayote in a circular motion. A the transparent sap will turn to white, similar to cream of tartar. This procedure will remove the sticky sap so it will not stick to your hands when you peel and slice the sayote. \n2. Peel and slice in half the sayote and remove the seed with a spoon. Thinly slice the sayote, about 1/2 inch thick. \n3. In a wok, put cooking oil and saute garlic until brown, then onion until cooked, then followed by the tomatoes. \n4. When the tomatoes are tender, saute the chicken breast for at least 1 minute then put the fish sauce and cover. \n5. Simmer for about 3 minutes and add a little water if the ingredients looks dry. \n6. Then put the sayote and mix with the rest of the ingredients. \n7. Pour the 1 cup of water and the chicken cubes then simmer until cooked.");
                    break;
                case "1114":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Filipino-style Fried Chicken \n\nIngredients: \n1/2 kg chicken wings or drumettes \n1/8 cup calamansi or lemon juice \n1/4 cup soy sauce \n1/2 head garlic, peeled and minced \n1/2 tsp salt \n1/2 tsp ground black pepper \n1/2 cup all-purpose flour \nCooking oil for frying \nInstructions: \n1. In a bowl, combine the calamansi or lemon juice, soy sauce, garlic, salt, and ground black pepper. Mix well. \n2. Add the chicken wings or drumettes to the bowl and marinate for at least 30 minutes. \n3. In a separate bowl, mix together the all-purpose flour, salt, and ground black pepper. \n4. Coat the chicken pieces in the flour mixture. \n5. Heat the cooking oil in a deep pan or wok. \n6. Fry the chicken pieces until golden brown and crispy. \n7. Drain on paper towels. \n8. Serve hot. \n\nNote: You can save the leftover for later.");
                    break;
                case "1115":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Homemade Chicken Soup \n\nIngredients: \n1/2 kg chicken \n1 small carrots, peeled and chopped \n1 onion, chopped \n2 cloves garlic, minced\n1 teaspoon salt\n1/2 teaspoon black pepper\n8 cups water\n\nInstructions:\n1. Place the chicken in a large pot and add enough water to cover it. Bring to a boil over high heat. \n2. Reduce the heat to low and simmer for 1 hour. \n3. Remove the chicken from the pot and let it cool. Once it’s cool enough to handle, remove the meat from the bones and shred it into bite-sized pieces. \n4. Return the chicken bones to the pot and add the carrots, onion, garlic, salt, and black pepper. \n5. Bring the soup to a boil over high heat. \n6. Reduce the heat to low and simmer for 1 hour. \n7. Add the shredded chicken back to the pot and stir to combine. \n8.Serve hot and enjoy!");
                    break;
                //canned
                case "1121":
                    Console.Clear();
                    Console.WriteLine("I'm sorry, this method of cooking is not applicable to this dish. I suggest trying other methods.");
                    break;
                case "1122":
                    Console.Clear();
                    Console.WriteLine("I'm sorry, this method of cooking is not applicable to this dish. I suggest trying other methods.");
                    break;
                case "1123":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sauteed Tuna with Kangkong (Water Spinach) \n\nIngredients: \n1 can of tuna in oil \n1 bunch of kangkong (water spinach), leaves and tender stems only \n1 small onion, chopped \n2 cloves garlic, minced \n1/4 cup water \n1 tablespoon cooking oil \nSalt and pepper to taste \n\nInstructions: \n1. Heat the cooking oil in a pan over medium heat. \n2. Add the garlic and onion and saute until fragrant. \n3. Add the tuna and cook for 2-3 minutes or until slightly browned. \n4. Add the kangkong and cook for 5-7 minutes or until tender. \n5. Pour in the water and let it simmer for 2-3 minutes or until the sauce thickens. \n6. Season with salt and pepper to taste.");
                    break;
                case "1124":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fried Canned Sardines \n\nIngredients: \n1 can of sardines (in tomato sauce or oil) \n1/2 cup of flour \n1/2 teaspoon of salt \n1/4 teaspoon of black pepper \n1/4 teaspoon of garlic paste \n1/4 teaspoon of onion, minced \n1 egg \n1 tablespoon of water \nCooking oil \n\nInstructions: \n1. Drain the sardines and remove any bones. \n2. In a bowl, mix together the flour, salt, black pepper, garlic powder, and onion powder. \n3. In another bowl, beat the egg and water together. \n4. Dip each sardine in the egg mixture, then coat it in the flour mixture. \n5. Heat the cooking oil in a pan over medium-high heat. \n6. Fry the sardines in the hot oil until they are golden brown on both sides. \n7. Remove the sardines from the pan and place them on a paper towel to drain any excess oil. \n8. Serve hot with rice or your favorite side dish.");
                    break;
                case "1125":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Misua Patola Soup \n\nIngredients: \n1 can of sardines (155g) \n1 small of patola \n1 pack of misua \n1 small onion, chopped \n2 cloves of garlic, minced \n2 cups of water \n1 tbsp of cooking oil \nSalt and pepper to taste \n\nInstructions: \n1. Heat the cooking oil in a pot over medium heat. \n2. Add the garlic and onion and sauté until fragrant. \n3. Add the sardines and cook for 2 minutes. \n4. Add the patola and cook for another 2 minutes. \n5. Pour in the water and bring to a boil. \n6. Add the misua and cook for 2-3 minutes. \n7. Season with salt and pepper to taste.");
                    break;
                //fish
                case "1131":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "1132":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "1133":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "1134":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "1135":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "1141":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "1142":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "1143":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "1144":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "1145":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "1151":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "1152":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1153":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1154":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1155":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "1161":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1162":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1163":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1164":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1165":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "1171":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1172":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1173":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1174":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1175":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "1181":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1182":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1183":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1184":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1185":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //mid appetite
                //chicken
                case "1211":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1212":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1213":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1214":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1215":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //canned
                case "1221":
                    Console.Clear();
                    Console.WriteLine("1121");
                    break;
                case "1222":
                    Console.Clear();
                    Console.WriteLine("1122");
                    break;
                case "1223":
                    Console.Clear();
                    Console.WriteLine("1123");
                    break;
                case "1224":
                    Console.Clear();
                    Console.WriteLine("1124");
                    break;
                case "1225":
                    Console.Clear();
                    Console.WriteLine("1125");
                    break;
                //fish
                case "1231":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "1232":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "1233":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "1234":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "1235":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "1241":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "1242":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "1243":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "1244":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "1245":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "1251":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "1252":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1253":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1254":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1255":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "1261":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1262":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1263":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1264":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1265":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "1271":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1272":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1273":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1274":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1275":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "1281":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1282":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1283":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1284":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1285":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //high appetite
                //chicken
                case "1311":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1312":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1313":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1314":
                    Console.WriteLine("1114");
                    break;
                case "1315":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //canned
                case "1321":
                    Console.Clear();
                    Console.WriteLine("1121");
                    break;
                case "1322":
                    Console.Clear();
                    Console.WriteLine("1122");
                    break;
                case "1323":
                    Console.Clear();
                    Console.WriteLine("1123");
                    break;
                case "1324":
                    Console.Clear();
                    Console.WriteLine("1124");
                    break;
                case "1325":
                    Console.Clear();
                    Console.WriteLine("1125");
                    break;
                //fish
                case "1331":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "1332":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "1333":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "1334":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "1335":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "1341":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "1342":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "1343":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "1344":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "1345":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "1351":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "1352":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1353":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1354":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1355":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "1361":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1362":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1363":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1364":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1365":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "1371":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1372":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1373":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1374":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1375":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "1381":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "1382":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "1383":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "1384":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "1385":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;

                //mid budget
                //low appetite
                //chicken
                case "2111":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2112":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2113":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2114":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2115":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //canned
                case "2121":
                    Console.Clear();
                    Console.WriteLine("1121");
                    break;
                case "2122":
                    Console.Clear();
                    Console.WriteLine("1122");
                    break;
                case "2123":
                    Console.Clear();
                    Console.WriteLine("1123");
                    break;
                case "2124":
                    Console.Clear();
                    Console.WriteLine("1124");
                    break;
                case "2125":
                    Console.Clear();
                    Console.WriteLine("1125");
                    break;
                //fish
                case "2131":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "2132":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "2133":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "2134":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "2135":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "2141":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "2142":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "2143":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "2144":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "2145":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "2151":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "2152":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2153":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2154":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2155":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "2161":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2162":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2163":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2164":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2165":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "2171":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2172":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2173":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2174":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2175":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "2181":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2182":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2183":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2184":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2185":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //mid appetite
                //chicken
                case "2211":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2212":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2213":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2214":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2215":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //canned
                case "2221":
                    Console.Clear();
                    Console.WriteLine("1121");
                    break;
                case "2222":
                    Console.Clear();
                    Console.WriteLine("1122");
                    break;
                case "2223":
                    Console.Clear();
                    Console.WriteLine("1123");
                    break;
                case "2224":
                    Console.Clear();
                    Console.WriteLine("1124");
                    break;
                case "2225":
                    Console.Clear();
                    Console.WriteLine("1125");
                    break;
                //fish
                case "2231":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "2232":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "2233":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "2234":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "2235":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "2241":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "2242":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "2243":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "2244":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "2245":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "2251":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "2252":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2253":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2254":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2255":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "2261":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2262":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2263":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2264":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2265":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "2271":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2272":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2273":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2274":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2275":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "2281":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2282":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2283":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2284":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2285":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //high appetite
                //chicken
                case "2311":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2312":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2313":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2314":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2315":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //canned
                case "2321":
                    Console.Clear();
                    Console.WriteLine("1121");
                    break;
                case "2322":
                    Console.Clear();
                    Console.WriteLine("1122");
                    break;
                case "2323":
                    Console.Clear();
                    Console.WriteLine("1123");
                    break;
                case "2324":
                    Console.Clear();
                    Console.WriteLine("1124");
                    break;
                case "2325":
                    Console.Clear();
                    Console.WriteLine("1125");
                    break;
                //fish
                case "2331":
                    Console.Clear();
                    Console.WriteLine("1131");
                    break;
                case "2332":
                    Console.Clear();
                    Console.WriteLine("1132");
                    break;
                case "2333":
                    Console.Clear();
                    Console.WriteLine("1133");
                    break;
                case "2334":
                    Console.Clear();
                    Console.WriteLine("1134");
                    break;
                case "2335":
                    Console.Clear();
                    Console.WriteLine("1135");
                    break;
                //beef
                case "2341":
                    Console.Clear();
                    Console.WriteLine("1141");
                    break;
                case "2342":
                    Console.Clear();
                    Console.WriteLine("1142");
                    break;
                case "2343":
                    Console.Clear();
                    Console.WriteLine("1143");
                    break;
                case "2344":
                    Console.Clear();
                    Console.WriteLine("1144");
                    break;
                case "2345":
                    Console.Clear();
                    Console.WriteLine("1145");
                    break;
                //vegetable
                case "2351":
                    Console.Clear();
                    Console.WriteLine("1151");
                    break;
                case "2352":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2353":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2354":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2355":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //instant noodles
                case "2361":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2362":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2363":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2364":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2365":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //frozen foods
                case "2371":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2372":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2373":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2374":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2375":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;
                //pork
                case "2381":
                    Console.Clear();
                    Console.WriteLine("1111");
                    break;
                case "2382":
                    Console.Clear();
                    Console.WriteLine("1112");
                    break;
                case "2383":
                    Console.Clear();
                    Console.WriteLine("1113");
                    break;
                case "2384":
                    Console.Clear();
                    Console.WriteLine("1114");
                    break;
                case "2385":
                    Console.Clear();
                    Console.WriteLine("1115");
                    break;

                //high budget
                //low appetite
                //chicken
                case "3111":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3112":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3113":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3114":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3115":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //canned
                case "3121":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Canned Beef Stew \n\nIngredients: \n500g canned beef chunks or canned corned beef \n2 cans of mixed vegetables (corn, peas, carrots) \n1 can of diced tomatoes \n1 large onion, finely chopped \n3 cloves garlic, minced \n2 tablespoons cooking oil \n4 cups beef broth (you can use bouillon cubes to save costs) \n2 large potatoes, peeled and diced \n2 carrots, peeled and sliced \n1 teaspoon dried thyme \nSalt and pepper to taste \n\nInstructions: \n1. In a large pot, heat oil over medium heat. Add chopped onions and minced garlic. Sauté until the onions are soft and translucent. \n2. Add the canned beef chunks or corned beef to the pot. Break it up with a spoon and cook until browned. \n3. Pour in the can of diced tomatoes and the cans of mixed vegetables (drained). Stir well. \n4. Add the diced potatoes and sliced carrots to the pot. \n5. Pour in the beef broth and add dried thyme. Bring the stew to a boil, then reduce the heat to low and let it simmer for about 20-25 minutes or until the potatoes and carrots are tender. \n6. Season the stew with salt and pepper to taste. Adjust the seasoning as needed. \n7. Simmer for an additional 5-10 minutes to allow the flavors to meld. \n8. Serve the beef and vegetable stew hot. You can enjoy it as is or with a side of crusty bread.");
                    break;
                case "3122":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Chicken and Vegetable Medley. \n\nIngredients: \n2 cans of canned chicken breast, drained \n1 cup broccoli florets \n1 cup sliced carrots \n1 bell pepper, thinly sliced (any color) \n2 tablespoons soy sauce \n1 tablespoon oyster sauce \n1 tablespoon sesame oil \n1 tablespoon rice vinegar \n1 tablespoon honey or brown sugar \n1 teaspoon grated ginger \n2 cloves garlic, minced \n2 green onions, chopped (for garnish) \n\nInstructions: \n1. Set up a steamer or use a large pot with a steaming rack. \n2. Shred the canned chicken breast into bite-sized pieces and place them in a heatproof dish suitable for steaming. \n3. Arrange broccoli florets, sliced carrots, and bell pepper over the shredded chicken. \n4. In a bowl, whisk together soy sauce, oyster sauce, sesame oil, rice vinegar, honey (or brown sugar), grated ginger, and minced garlic. \n5. Drizzle the sauce over the chicken and vegetables, ensuring even coverage. \n6. Place the dish in the steamer or on the rack inside the pot. Cover and steam for approximately 15-20 minutes or until the chicken is heated through and the vegetables are tender. \n7. Sprinkle chopped green onions over the steamed chicken and vegetable medley. \n8. Serve the dish while hot.");
                    break;
                case "3123":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sauteed Corned Beef with Potatoes and Caramelized Onions \n\nIngredients: \n2 cans of high-quality corned beef \n4 medium-sized potatoes, peeled and diced \n2 large onions, thinly sliced \n4 cloves garlic, minced \n3 tablespoons olive oil \n1 tablespoon Dijon mustard \n1 tablespoon balsamic vinegar \nFresh thyme leaves, for garnish \nSalt and pepper to taste \n\nInstructions: \n1. In a large skillet, heat olive oil over medium heat. Add thinly sliced onions and cook slowly over low heat until they caramelize, stirring occasionally. This process may take 20-30 minutes for rich flavor. \n2. While the onions are caramelizing, boil the diced potatoes until they are just fork-tender. Drain and set aside. \n3. Once the onions are caramelized, add minced garlic to the skillet and sauté for an additional 1-2 minutes until fragrant. \n4. Add the canned corned beef to the skillet, breaking it up with a spoon. Allow it to brown slightly, stirring occasionally. \n5. Add the boiled diced potatoes to the skillet. Mix well with the corned beef. \n6. In a small bowl, whisk together Dijon mustard and balsamic vinegar. Pour this mixture over the corned beef and potatoes. Stir to combine. \n7. Season with salt and pepper to taste. Adjust the seasoning as needed. \n8. Allow the mixture to cook for an additional 5-7 minutes, ensuring the flavors meld. \n9. Garnish the sauteed corned beef with fresh thyme leaves just before serving.");
                    break;
                case "3124":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fried Canned Chicken Adobo Spring Rolls: \n\nIngredients: \n2 cans of shredded canned chicken adobo \n1 cup finely shredded cabbage \n1/2 cup grated carrots \n1/2 cup thinly sliced bell peppers (any color) \n1/4 cup chopped green onions \n2 cloves garlic, minced \n1 tablespoon soy sauce \n1 tablespoon oyster sauce \n1 teaspoon sesame oil \nSpring roll wrappers (store-bought) \nCooking oil for frying \nSweet chili sauce or your favorite dipping sauce \n\nInstructions: \n1. In a large bowl, combine shredded canned chicken adobo, shredded cabbage, grated carrots, sliced bell peppers, chopped green onions, minced garlic, soy sauce, oyster sauce, and sesame oil. Mix well until all ingredients are combined. \n2. Place a spring roll wrapper on a clean surface. Spoon a generous amount of the chicken adobo filling onto the center of the wrapper. \n3. Fold the sides of the wrapper over the filling, then fold the bottom and roll tightly into a spring roll. Seal the edge with a little water. \n4. In a deep skillet or pot, heat cooking oil for frying. \n5. Carefully place the spring rolls into the hot oil, a few at a time, and fry until they are golden brown and crispy, usually about 3-4 minutes. \n6. Transfer the fried spring rolls to a plate lined with paper towels to absorb excess oil. \n7. Serve the chicken adobo spring rolls hot with sweet chili sauce or your favorite dipping sauce on the side.");
                    break;
                case "3125":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Chickpea and Vegetable Soup with Canned Tomatoes: \n\nIngredients: \n2 cans of chickpeas, drained and rinsed \n1 can of diced tomatoes (400g) \n1 large onion, finely chopped \n2 carrots, peeled and diced \n2 celery stalks, chopped \n3 cloves garlic, minced \n1 medium potato, peeled and diced \n1 teaspoon cumin \n1 teaspoon smoked paprika \n1 teaspoon dried thyme \n1 bay leaf \n6 cups vegetable or chicken broth \nSalt and black pepper to taste \n2 tablespoons olive oil \nFresh parsley for garnish (optional) \n\nInstructions: \n1. In a large pot, heat olive oil over medium heat. Add chopped onion, carrots, celery, and garlic. Sauté until the vegetables are softened. \n2. Add diced potatoes, cumin, smoked paprika, dried thyme, bay leaf, salt, and black pepper to the pot. Stir well to coat the vegetables in the spices. \n3. Pour in the canned diced tomatoes with their juices and add the drained chickpeas. Stir to combine. \n4. Pour in the vegetable or chicken broth. Bring the soup to a boil. \n5. Reduce the heat to low, cover the pot, and let the soup simmer for about 20-25 minutes or until the vegetables are tender. \n6. Taste and adjust the seasoning with additional salt and pepper if needed. \n7. Ladle the soup into bowls. Garnish with fresh parsley if desired. Serve hot.");
                    break;
                //fish
                case "3131":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sweet and sour Lapu-lapu\n\nIngredients:\n\nFor the Fish:\n1 whole lapu-lapu (grouper), cleaned and scaled\nSalt and pepper to taste\nCornstarch for dredging\nCooking oil for frying\n\nFor the Sweet and Sour Sauce:\n1 cup pineapple juice\n3 tablespoons ketchup\n2 tablespoons soy sauce\n3 tablespoons vinegar\n4 tablespoons brown sugar\n1 cup water\n1 onion, sliced\n1 bell pepper, sliced\n1 carrot, julienned\n1 cup pineapple chunks (fresh or canned)\nSalt and pepper to taste\n2 tablespoons cornstarch (dissolved in 2 tablespoons water) for thickening\n\nInstructions:\n1. Clean and scale the lapu-lapu. Make diagonal cuts on both sides of the fish.\n2. Season the fish with salt and pepper.\n3. Dredge the fish in cornstarch, ensuring it's coated evenly.\n4. Heat cooking oil in a deep pan or wok.\n5. Fry the lapu-lapu until golden brown and cooked through.\n6. Set aside on paper towels to drain excess oil.\n7. In a bowl, mix pineapple juice, ketchup, soy sauce, vinegar, and brown sugar. Adjust the sweetness and sourness according to your taste.\n8. In a separate pan, sauté onions, bell peppers, and carrots until they are slightly tender.\n9. Add pineapple chunks and continue to cook for a few more minutes.\n10. Pour the sweet and sour sauce over the sautéed vegetables. Bring it to a simmer.\n11. Adjust the seasoning with salt and pepper.\n12. Stir in the dissolved cornstarch and water mixture to thicken the sauce. Stir continuously to avoid lumps.\n13. Pour the sweet and sour sauce over the fried lapu-lapu.\n14. Garnish with additional pineapple chunks, if desired.");
                    break;
                case "3132":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Lapu-lapu \n\nIngredients: \n2 Lapu-Lapu fillets (about 200-250g each), scaled and cleaned \n2 tablespoons light soy sauce \n1 tablespoon oyster sauce \n1 tablespoon sesame oil \n1 tablespoon ginger, julienned \n2 cloves garlic, minced \n1-2 stalks green onions, chopped \nSalt and black pepper to taste \n1 tablespoon cooking oil \n1 lemon or calamansi (for serving) \n\nInstructions: \n1. Pat the Lapu-Lapu fillets dry with a paper towel. Score the skin with a few diagonal cuts to help the flavors penetrate. \n2. In a small bowl, mix together soy sauce, oyster sauce, sesame oil, ginger, minced garlic, chopped green onions, salt, and pepper. \n3. Rub the marinade all over the Lapu-Lapu fillets, making sure to get the flavors into the cuts. Allow it to marinate for at least 15-30 minutes. \n4. While marinating, set up your steamer. Add water to the steamer and bring it to a boil. \n5. Place the marinated Lapu-Lapu fillets in the steamer basket. Steam for about 10-15 minutes or until the fish is opaque and flakes easily. \n6. Test the doneness by poking the thickest part of the fish with a fork. If the flesh flakes easily, the Lapu-Lapu is done. \n7. In a small pan, heat cooking oil. Pour the heated oil over the steamed Lapu-Lapu. This will release the flavors of the ginger and garlic. \n8. the steamed Lapu-Lapu with lemon or calamansi wedges on the side");
                    break;
                case "3133":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Monkfish Couscous \n\nIngredients: \n375g monkfish \n1tbsp olive oil \n1 small very thinly sliced into rings onion \n15g raisins \n20g cashew nuts \n1 seeded and sliced small red pepper \n2 peeled, seeded, and sliced tomatoes \n175ml fish stock \n1/2 tbsp chopped parsley \nSalt and ground pepper \n\nFor the couscous: \n150g couscous \n250g water \n\nInstructions: \n1. Debone and de-skin the monkfish, if necessary, and cut into bite-size chunks using a sharp knife. \n2. Heat half of the oil in a saucepan or flameproof casserole and fry about a quarter of the onion rings for 5-6 minutes until they are a dark golden brown. Transfer to a plate lined with kitchen paper. \n3. Add the raisins and stir-fry for 30-60 seconds until they begin to plump up. Transfer to the plate with onion rings. \n4. Add the cashew nuts to the pan and stir-fry for 30-60 seconds until golden. Place on the plate with the onion and raisins and set aside. \n5. Heat the remaining oil in the pan and add the remaining onion rings and cook until golden. Then add the pepper slices. Cook over a fairly high heat for 6-8 minutes until the peppers are soft, stirring occasionally. \n6. Add the tomatoes and add the fish stock, reduce the heat and simmer for 10 minutes. \n7. Bring the water for the couscous to a boil. Once boiled, pour into a bowl filled with couscous and stir once or twice. Set aside for 10 minutes so that the couscous can absorb the liquid, then fluff up with a fork. Cover and keep warm. \n8. Add the fish to the peppers and onion, partially cover and simmer for 6-8 minutes unti the fish is tender, stirring gently occasionally. Season to taste with salt and pepper. \n9. Pile the couscous on to a large serving plate and make a hollow in the middle. \n10. Pour over the monkfish and peppers with all that sauce. Sprinkle with the parsley and the reserved onion rings, raisins, and cashew nuts.");
                    break;
                case "3134":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fish Cake with Cucumber Relish \n\nIngredients: \n\nFor the fish cake \n200g cod fillets, cut into chunks \n20ml red curry paste \n1 egg \n20ml fish sauce \n1 tsp granulated sugar \n20ml cornflour \n1 calamansi \n10ml chopped coriander \n30g finely sliced green beans\nOil for frying \n\nFor the cucumber relish \n40ml rice vinegar \n40ml water \n35g sugar \n1 head pickled garlic \n1 small quartered and sliced cucumber \n1 finely chopped onion \n10ml finely chopped root ginger \n\nInstructions: \n1. To make the cucumber relish, bring the vinegar, water and sugar to the boil. Stir until the sugar dissolves, then remove from the heat and cool. \n2. Combine the rest of the relish ingredients together in a bowl and pour over the vinegar mixture. \n3. Combine the fish, curry paste and egg in a food processor or in a pestle and mortar, until no visible chunks are left. \n4. Transfer the mixture to a bowl add the rest of the ingredients, except for the oil, and mix well. \n5. Mold and shape the mixture into cakes about 2in wide and ¼ in thick. \n6. Heat the oil in a wok or deep fryer. Fry the fish cakes, a few at a time, for about 4-5 minutes or until golden brown. \n7. Remove and drain on kitchen paper.");
                    break;
                case "3135":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sinigang na Lapu-lapu \n\nIngredients: \n2 Lapu-Lapu fillets (about 200-250g each) \n1 small eggplant, sliced \n1 medium-sized radish, peeled and sliced \n1 bundle string beans (sitaw), cut into 2-inch lengths \n1 medium-sized tomato, quartered \n1 medium-sized onion, peeled and sliced \n2 green chili peppers (siling haba) \n1 packet (about 40g) sinigang mix (tamarind soup mix) \n1 liter water \nFish sauce (patis) or salt, to taste Pepper to taste \nFresh kangkong, washed and trimmed \n\nInstructions: \n1. In a pot, bring 1 liter of water to a boil. \n2. Once the water is boiling, add the eggplant, radish, string beans, tomato, and onion to the pot. \n3. Add the sinigang mix to the pot. Stir well to dissolve the mix into the water. \n4. Carefully add the Lapu-Lapu fillets to the pot. Let it simmer until the vegetables are tender and the fish is cooked. \n5. Season the soup with fish sauce or salt and pepper according to your taste preference. Adjust the sourness by adding more sinigang mix if needed. \n6. Add the green chili peppers to the pot. Adjust the quantity based on your desired level of spiciness. \n7. Once the fish and vegetables are cooked, add the fresh kangkong to the pot. Cook for an additional 2-3 minutes until the leafy greens are wilted. \n8. Ladle the Sinigang na Lapu-Lapu into bowls and serve hot. ");
                    break;
                //beef
                case "3141":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef Stew \n\nIngredients: \n1 tbsp plain flour \n1 tsp dried thyme \n500g braising or stewing beef, cut into large cubes \n1/2 tbsp olive oil \n1 small onion, roughly chopped \n200g tomato paste \n3/4 cup beef stock \n1/2cup water \n1 garlic clove, crushed \n1 tbsp tomato puree \n1 cup shelled fresh peas \n½ tsp sugar \nSalt and ground black pepper \n\nInstructions: \n1. Put the flour in a shallow dish and season with the thyme, salt, and pepper. Add the beef and coat evenly. \n2. Heat the oil in a pan. Add the beef and brown all sides over a medium heat. Remove and drain the meat on paper towels. \n3. Add the onion to the pan, scraping the base of the pan to mix in any sediment. Cook for 3 minutes, stirring until softened. \n4. Then, stir in the tomato paste, stock, water, garlic, and tomato puree. Bring to a boil while stirring. \n5. Return the beef to the pan and stir well to coat with the sauce. Cover and cook for about an hour. \n6. Stir in the peas and the sugar. Cook once more for 30 minutes, or until the beef is tender. \n7. Taste for seasoning before serving.");
                    break;
                case "3142":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Eggs with Beef \n\nIngredients: \n60g rump steak \n½ tsp grated ginger \n½ tsp fish sauce \nGround black pepper \n2 medium eggs \n¼ chicken stock or water \n1 tbsp chopped spring onion \n½ tbsp vegetable oil 1\n garlic clove, finely sliced \n\nInstructions: \n1. Finely chop the beef and place in a large bowl. Add the ginger fish sauce, and ground black pepper. \n2. Beat the eggs together with the stock. \n3. Stir the mixture into the beef, add the spring onions and beat together until well blended. Try to avoid making too many bubbles. \n4. Pour the mixture into a heatproof dish or individual ramekins \n5. Place in a steamer and steam over gentle heat for 10-15 minutes or until the custard is set. \n6. Meanwhile, heat the oil in a frying pan. Add the garlic and stir to break up any clumps and fry until golden. \n7. Before serving, pour the garlic and oil over the egg custards. Allow to cool slightly before serving.");
                    break;
                case "3143":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Balti Beef \n\nIngredients: \n1 small red pepper \n1 small green pepper \n½ tbsp oil \n1/2 tsp cumin \n1 tsp parsley, finely chopped \n1 small onion, cut into thick wedges \n1 garlic clove, crushed \n½ in ginger root \n1 red chili, finely chopped \n½ tbsp curry paste \nPinch of salt \n350g lean rump, cut into thick strips \n\nInstructions: \n1. Cut the red and green peppers into 1 in chunks. \n2. Heat the oil in a non-stick wok or frying pan and add the onion, garlic, ginger, cumin, parsley, and chili then fry for a further 5 minutes. \n3. Add the curry paste and salt and fry for a further 3-4 minutes. \n4. Add the pepper and stir-fry for about 5 minutes. \n5. Stir in the beef strips and continue to fry for 10-12 minutes or until the meat is tender. \n6. Serve while hot.");
                    break;
                case "3144":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Pepper Steak \n\nIngredients: \n2 tbsp black pepper, slightly crushed \n2 sirloin steak, about 225g each \n1 tbsp butter \n2 tsp vegetable oil \n2/3 cup whipping cream \n1 garlic clove, finely chopped \n\nInstructions: \n1. Put the steaks on a board and trim away any extra fat. Press the pepper onto both sides of the meat, coating it completely. \n2. Melt the butter with the oil in a heavy frying pan over a medium-high heat. Add the meat and cook for 6-7 minutes, turning once, until done as preferred. \n3. Transfer the steaks to a warmed serving platter or plates and cover to keep warm. \n4. Add the cream and the garlic, scraping the base of the pan. Boil gently over a medium heat for about 4 minutes until the cream has reduced by one-third. \n5. Stir any accumulated juice from the meat into the sauce. \n6. Pour the sauce over the steaks to serve.");
                    break;
                case "3145":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Eggs with Beef Soup \n\nIngredients: \n60g rump steak \n½ tsp grated ginger \n½ tsp fish sauce \nGround black pepper \n2 medium eggs \n¼ chicken stock or water \n1 tbsp chopped spring onion \n½ tbsp vegetable oil \n1 garlic clove, finely sliced \n4 cups water \n1 beef stock cube \n\nInstructions: \n1. Finely chop the beef and place in a large bowl. Add the ginger fish sauce, and ground black pepper. \n2. Beat the eggs together with the stock. \n3. Stir the mixture into the beef, add the spring onions and beat together until well blended. Try to avoid making too many bubbles. \n4. In a separate pot, bring the water to a boil. Once it reached to a boil, add in the egg and beef mixture and the beef cube stock then stir. \n5. Meanwhile, heat the oil in a frying pan. Add the garlic and stir to break up any clumps and fry until golden. \n6. Before serving, pour the garlic and oil over the soup.");
                    break;
                //vegetable
                case "3151":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Spiced Cauliflower \n\nIngredients: \n½ cauliflower \n1 medium tomato \n½ chopped onion \n1 crushed garlic clove \n1 seeded fresh green chili \n1.5ml ground turmeric \n15ml vegetable oil \n200ml coconut milk \n125ml water \n3ml sugar \n3ml tamarind pulp, soaked in 30ml warm water \nSalt \n\nInstructions: \n1. Trim the stalk from the cauliflower \n2. and divide into tiny florets. Skin the tomato(es) if liked. Chop the flesh into 1-2.5cm pieces. \n3. Grind the chopped onion, garlic, green chili, and ground turmeric together to a paste in a food processor or with a pestle and mortar. \n4. Heat the vegetable oil in a wok or large frying pan and fry the spice paste to bring out the aromatic flavors, without allowing it to brown. \n5. Add the cauliflower florets and toss well to coat in the spices. \n6. Stir in the coconut milk, water, sugar and s to taste. Simmer for 5 minutes. \n7. Strain the tamarind and reserve the juice. Add the tamarind juice and chopped tomatoes to the pan then cook for 2-3 minutes only. \n8. Taste and check the seasoning and serve.");
                    break;
                case "3152":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Pumpkin Pie: \n\nIngredients: \n2 cups pumpkin puree (canned or homemade) \n1/2 cup brown sugar \n1/4 cup granulated sugar \n1 teaspoon ground cinnamon \n1/2 teaspoon ground ginger \n1/4 teaspoon ground nutmeg \n1/4 teaspoon ground cloves \n1/2 teaspoon salt \n3 large eggs \n1 cup evaporated milk \nFor the Pie Crust: \n1 1/2 cups graham cracker crumbs \n1/3 cup melted butter \n1/4 cup granulated sugar \n\nInstructions: \n1. In a bowl, combine graham cracker crumbs, melted butter, and sugar until the mixture resembles wet sand. \n2. Press the mixture into the base and up the sides of a pie plate to form the crust. Use the back of a spoon to compact it. \n3. Place the crust in the refrigerator to set while you prepare the filling. \n4. In a large mixing bowl, whisk together the pumpkin puree, brown sugar, granulated sugar, cinnamon, ginger, nutmeg, cloves, and salt. \n5. Add the eggs one at a time, beating well after each addition. \n6. Gradually pour in the evaporated milk or half-and-half, mixing until the filling is smooth and well combined. \n7. Pour the pumpkin filling into the prepared graham cracker crust. \n8. Cover the pie with aluminum foil, creating a loose tent to allow steam to escape. \n9. Place the pie plate in a steamer basket over boiling water. Make sure the water doesn't touch the bottom of the pie plate. \n10. Cover the steamer and steam the pumpkin pie for about 45-60 minutes, or until the filling is set. Check for doneness by inserting a toothpick into the center; it should come out clean when the pie is ready. \n11. Once the steamed pumpkin pie is cooked, carefully remove it from the steamer. \n12. Allow it to cool at room temperature, and then refrigerate for a few hours or overnight to firm up the filling. \n13. Garnish the steamed pumpkin pie with whipped cream or a sprinkle of cinnamon before serving.");
                    break;
                case "3153":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Eggplant in Spicy Sauce: \n\nIngredients:\n225g eggplant \n2-3 whole dried chilies, soaked in water for 10 minutes \nVegetable oil \n½ clove finely chopped garlic \n2.5ml finely chopped fresh ginger \n50g thinly shredded lean pork (optional) \n8ml light soy sauce \n8ml brown sugar \n8ml chili bean sauce \n5ml cornflour paste \n\nInstructions: \n1. Cut the eggplant into short strips the size of chips – the skin can either be peeled or left on. \n2. Cut the soaked red chilies into two or three small pieces and discard the seeds. \n3. Heat the oil in a preheated wok and deep fry the eggplant chips for about 3-4 minutes or until limp. Remove and drain. \n4. Pour off the excess oil, leaving about 1tbsp in the wok. \n5. Add the garlic, ginger, and chilies, stir a few times, then add the pork. Stir fry the meat for about 1 minute or until it becomes pale, almost white in colour. \n6. Add all the seasonings, then increase the heat not bring the mixture to the boil. \n7. Add the eggplant to the wok, blend well and braise for 30-40 seconds, then thicken the sauce with cornflour paste, stirring until smooth.");
                    break;
                case "3154":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Vegetable Samosa: \n\nIngredients: \nFilo pastry or Lumpia wrapper \n2 medium potatoes, boiled and coarsely mashed \n40g thawed peas \n25g canned sweetcorn, drained \n2.5ml ground coriander \n2.5ml ground cumin \n1/2 finely chopped small onion \n1 finely chopped green chili \n15ml chopped coriander leaves \n1 lemon juice \nSalt to taste \n\nInstructions: \n1. Toss all the filling ingredients together in a large mixing bowl until they are well blended. \n2. Adjust the seasoning with salt and lemon juice if necessary. \n3. Heat a pan over medium heat and add cooking oil. \n4. Wrap the filling into the pastry or wrapper. \n5. Put it in the pan and fry until golden brown.");
                    break;
                case "3155":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Vegetable Soup \n\nIngredients: \n2 tablespoons olive oil \n1 large onion, diced \n3 cloves garlic, minced \n3 carrots, peeled and sliced \n3 celery stalks, sliced \n1 bell pepper, diced (any color) \n1 zucchini, diced \n1 cup green beans, chopped \n1 cup corn kernels (fresh or frozen) \n1 can (14 oz) diced tomatoes (with juices) \n6 cups vegetable broth \n1 teaspoon dried thyme \n1 teaspoon dried oregano \n1 bay leaf \nSalt and pepper to taste \n1 cup spinach or kale, chopped \n1 can (15 oz) cannellini beans, drained and rinsed \nFresh parsley, chopped (for garnish) \n\nInstructions: \n1. In a large pot, heat the olive oil over medium heat. Add diced onions and minced garlic. Sauté until the onions are translucent. \n2. Add carrots, celery, bell pepper, zucchini, green beans, and corn to the pot. Stir and cook for a few minutes until the vegetables start to soften. \n3. Pour in the diced tomatoes (with juices) and vegetable broth. Add dried thyme, dried oregano, bay leaf, salt, and pepper. Stir to combine. \n4. Bring the soup to a simmer and let it cook for about 15-20 minutes or until the vegetables are tender. \n5. Add chopped spinach or kale and cannellini beans to the soup. Cook for an additional 5 minutes until the greens are wilted and the beans are heated through. \n6. Taste the soup and adjust the seasoning if needed. Remove the bay leaf. \n7. Ladle the vegetable soup into bowls, garnish with fresh parsley, and serve hot. \n8. Add a splash of lemon juice or a sprinkle of grated Parmesan cheese just before serving for extra flavor. \n9. Experiment with different herbs and spices to suit your taste. \n10. If you like a bit of heat, you can add a pinch of red pepper flakes.");
                    break;
                //instant noodles
                case "3161":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3162":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3163":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3164":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3165":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //frozen foods
                case "3171":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3172":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3173":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3174":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3175":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //pork
                case "3181":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3182":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3183":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3184":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3185":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //mid appetite
                //chicken
                case "3211":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3212":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3213":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3214":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3215":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //canned
                case "3221":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef Stew with Canned Veggies \n\nIngredients: \n1 kg beef, cut into cubes \n2 cans of diced tomatoes \n1 can of tomato sauce \n2 cans of carrots \n2 cans of potatoes \n1 onion, chopped \n4 cloves of garlic, minced \n3 tablespoons of cooking oil \nSalt and pepper to taste \n\nInstructions: \n1. Heat the oil in a pot over medium heat. \n2. Add the onions and garlic and sauté until fragrant. \n3. Add the beef and cook until browned on all sides. \n4. Add the diced tomatoes, tomato sauce, and enough water to cover the beef. \n5. Bring to a boil, then reduce the heat and let simmer for 30 minutes. \n6. Add the carrots and potatoes and continue to simmer for another 15-20 minutes or until the vegetables are tender. \n7. Season with salt and pepper to taste.");
                    break;
                case "3222":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Canned Tuna and Vegetable Packets: \n\nIngredients: \n2 cans of tuna in water, drained \n2 cups mixed vegetables (carrots, peas, corn) \n1 bell pepper, thinly sliced \n1 zucchini, thinly sliced \n1 onion, thinly sliced \n2 cloves garlic, minced \n2 tablespoons soy sauce \n1 tablespoon sesame oil \n1 tablespoon rice vinegar \n1 tablespoon honey or brown sugar \n1 teaspoon grated ginger \nSalt and black pepper to taste \n4 sheets of parchment paper or aluminum foil \nInstructions: \n1. Set up a steamer or use a large pot with a steaming rack. \n2. In a bowl, mix mixed vegetables, bell pepper, zucchini, onion, and minced garlic. \n3. Tear off four large squares of parchment paper or aluminum foil. Divide the vegetable mixture equally among the sheets. \n4. Place drained tuna on top of each vegetable mound. \n5. In a small bowl, whisk together soy sauce, sesame oil, rice vinegar, honey (or brown sugar), grated ginger, salt, and black pepper. \n6. Drizzle the sauce evenly over each tuna and vegetable mound. Seal the packets by folding the parchment paper or foil and crimping the edges tightly. \n7. Place the packets in the steamer or on the rack inside the pot. Cover and steam for approximately 15-20 minutes or until the vegetables are tender. \n8. Carefully open the packets, and serve the steamed tuna and vegetables.");
                    break;
                case "3223":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sauteed Luncheon Meat with Vegetables \n\nIngredients: \n2 cans of luncheon meat (such as Spam), diced \n1 cup frozen mixed vegetables (peas, carrots, corn) \n1 large bell pepper, diced (any color) \n1 small onion, finely chopped \n2 cloves garlic, minced \n2 tablespoons cooking oil \n1 tablespoon soy sauce \n1 teaspoon Worcestershire sauce \n1/2 teaspoon garlic powder \n1/2 teaspoon onion powder \nSalt and pepper to taste \nCooked rice or bread (for serving) \n\nInstructions: \n1. In a large skillet, heat oil over medium heat. Add chopped onions and minced garlic. Sauté until the onions are soft and translucent. \n2. Add diced luncheon meat to the skillet. Cook for 5-7 minutes, stirring occasionally, until the luncheon meat is lightly browned. \n3. Add frozen mixed vegetables and diced bell pepper to the skillet. Continue to sauté for an additional 3-5 minutes until the vegetables are heated through and slightly tender. \n4. In a small bowl, mix together soy sauce, Worcestershire sauce, garlic powder, and onion powder. \n5. Pour the sauce mixture over the luncheon meat and vegetables. Stir well to coat evenly. \n6. Season with salt and pepper to taste. Adjust the seasoning as needed. \n7. Cook for an additional 2-3 minutes, allowing the flavors to meld. \n8. Serve the sauteed luncheon meat and vegetables while hot.");
                    break;
                case "3224":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fried Canned Tuna and Potato Patties: \n\nIngredients: \n2 cans of canned tuna in water, drained \n3 medium-sized potatoes, boiled and mashed \n1/2 cup finely chopped onions \n2 tablespoons chopped fresh cilantro or parsley \n1 teaspoon ground cumin \n1 teaspoon paprika \n1/2 teaspoon garlic powder \nSalt and black pepper to taste \n1 cup breadcrumbs \n2 eggs, beaten \nCooking oil for frying \nLemon wedges for serving \nOptional: Greek yogurt or sour cream for dipping \n\nInstructions: \n1. In a large mixing bowl, combine drained canned tuna, mashed potatoes, chopped onions, cilantro or parsley, ground cumin, paprika, garlic powder, salt, and black pepper. Mix well until all ingredients are evenly incorporated. \n2. Take a portion of the mixture and shape it into a patty. The size can be adjusted based on your preference. \n3. Set up a breading station with two bowls: one with beaten eggs and one with breadcrumbs. \n4. Dip each tuna and potato patty into the beaten eggs and then coat it in breadcrumbs, ensuring an even coating. \n5. In a large skillet, heat enough cooking oil over medium heat for shallow frying. \n6. Carefully place the coated patties into the hot oil. Fry for about 3-4 minutes on each side or until they are golden brown and crispy. \n7. Transfer the fried patties to a plate lined with paper towels to absorb excess oil. Season with additional salt and pepper if needed while they are still hot. \n8. Serve the fried tuna and potato patties hot with lemon wedges on the side. Optionally, offer Greek yogurt or sour cream for dipping.");
                    break;
                case "3225":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Black Bean and Corn Soup with Canned Ingredients: \n\nIngredients: \n2 cans of black beans, drained and rinsed \n1 can of whole kernel corn, drained \n1 can of diced tomatoes (400g) \n1 large onion, finely chopped \n2 bell peppers (any color), diced \n2 cloves garlic, minced \n1 teaspoon ground cumin \n1 teaspoon chili powder \n1/2 teaspoon smoked paprika \n6 cups vegetable or chicken broth \nSalt and black pepper to taste \n2 tablespoons vegetable oil \nJuice of 1 lime \nFresh cilantro for garnish (optional) \nSour cream or shredded cheese for serving (optional) \n\nInstructions: \n1. In a large pot, heat vegetable oil over medium heat. Add chopped onion, bell peppers, and garlic. Sauté until the vegetables are softened. \n2. Stir in ground cumin, chili powder, smoked paprika, salt, and black pepper. Cook for an additional 1-2 minutes until the spices are fragrant. \n3. Add the drained black beans, drained corn, and diced tomatoes with their juices to the pot. Stir well to combine with the sautéed vegetables. \n4. Pour in the vegetable or chicken broth. Bring the soup to a boil. \n5. Reduce the heat to low, cover the pot, and let the soup simmer for about 20-25 minutes, allowing the flavors to meld. \n6. Taste and adjust the seasoning as needed. Squeeze the lime juice into the soup and stir. \n7. Ladle the soup into bowls. Garnish with fresh cilantro if desired. Optionally, serve with a dollop of sour cream or a sprinkle of shredded cheesea");
                    break;
                //fish
                case "3231":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fish Curry \n\nIngredients: \n1 lapu-lapu \n1 calamansi \n45ml oil \n1 onion, chopped \n2 garlic cloves, crushed \n3 tbsp curry powder \n2 cups chopped tomatoes \n20ml peanut butter \n1/2 siling haba \n2 slices ginger \n600ml fish stock \nSalt and pepper to taste \n\nInstruction: \n1. Season the fish, inside and out with salt and pepper and place in a shallow bowl. \n2. Halve the lemon and squeeze the juice all over the fish. Cover loosely with clear film/plastic. Marinate for 2 hrs. \n3. Heat the oil in a large saucepan and fry the onions and garlic for 5-6 minutes until soft. Reduce the heat, add the curry powder and cook, stirring for a further 5 minutes. \n4. Stir the tomatoes and then the peanut butter, mixing well, then add the green pepper, ginger, and stock. \n5. Stir well and simmer gently for 10 minutes. \n6. Cut the fish into pieces and gently lower into the sauce. Simmer for a further 20 minutes or until the fish is cooked, then using a slotted spoon, transfer the fish to a plate. \n7. If the sauce is very thick, add a little extra stock or water. \n8. Return the fish to the sauce, cook gently to heat through and then serve immediately.");
                    break;
                case "3232":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Salmon \n\nIngredients: \n2 salmon fillets (about 6-8 ounces each) \n2 tablespoons soy sauce \n1 tablespoon rice vinegar \n1 tablespoon sesame oil \n1 tablespoon ginger, finely grated \n2 cloves garlic, minced \n1 tablespoon green onions, chopped \n1 teaspoon honey or maple syrup (optional, for a touch of sweetness) \nSesame seeds for garnish (optional) \n\nInstructions: \n1. Set up your steamer. If you don't have a steamer, you can use a makeshift one with a heatproof plate or bamboo steamer placed over a pot of simmering water. \n2. Pat the salmon fillets dry with a paper towel. If there are any bones, remove them using tweezers. \n3. In a bowl, mix soy sauce, rice vinegar, sesame oil, grated ginger, minced garlic, chopped green onions, and honey or maple syrup (if using). Stir the marinade well. \n4. Place the salmon fillets in a shallow dish or a plate with raised edges. Pour the marinade over the salmon, ensuring that it coats the fish evenly. Allow the salmon to marinate for at least 15-30 minutes. \n5. Place the marinated salmon fillets in the steamer basket. Steam for about 10-15 minutes, depending on the thickness of the fillets. The salmon is done when it flakes easily with a fork. \n6. Test the doneness by poking the thickest part of the fish with a fork. If the flesh flakes easily, the salmon is done. \n7. Carefully transfer the steamed salmon to serving plates. Garnish with sesame seeds if desired.");
                    break;
                case "3233":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Salmon Sealed with Egg \n\nIngredients: \n200g salmon, bones and skin removed \n5 trimmed mangetouts (sitcharo) \n1 sliced large mild onion \n4 tsp sugar \n1 tbsp soy sauce \n2 beaten eggs \n1/2 cup water \n\nInstructions: \n1. Flake the salmon and boil the mangetouts for 2-3 minutes then drain and slice finally. \n2. Put the onions in a frying pan, add the water and bring to the boil. Cook for 5 minutes over a moderate heat, then add sugar and soy sauce. Cook for another 5 minutes. \n3. Add the salmon and cook for 2-3 minutes or until the soup has evaporated. \n4. Pour the egg over to cover the surface. Sprinkle in the mangetouts and cover the pan. \n5. Cook for 1 minute over a moderate heat, until just set. Do not overcook or the eggs will curdle and separate. Transfer to a plate and serve.");
                    break;
                case "3234":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Salted Cod Fishcakes \n\nIngredients: \n200g potatoes, peeled and cubed \n50g salted cod, soaked in cold water for 48 hours \n1/2 tbsp olive oil \n1 small onion, finely chopped \n1 garlic clove, finely chopped \n1 tbsp chopped fresh parsley \n1 egg beaten, \nTabasco or chili sauce \nPlain flour, for dusting \nOil for frying \nSalt and freshly ground pepper \n\nInstructions: \n1. Cook the potatoes in a saucepan of boiling water for 10-12 minutes until tender. Drain well, then mash until smooth and set aside. \n2. Place the cod in a frying pan, add water to cover and bring to the boil. \n3. Drain the fish, then remove the skin and bones. Using a fork, break the flesh into small pieces. \n4. Heat the olive oil in a small saucepan and cook the onion and garlic for 5 minutes until softened. \n5. In a large bowl, mix together the mashed potato, flaked fish, parsley, and fried onion and garlic. Bind with the egg, then add salt, pepper and tabasco or chili sauce to taste. \n6. With floured hands, shape the mixture into balls. Flatten the balls slightly and place on a large floured plate. Chill for about 15 minutes. \n7. Heat a small amount of oil in a large frying pan. Cook the fish cakes for 3-4 minutes on each side until golden. \n8. Drain on kitchen paper and serve hot.");
                    break;
                case "3235":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Cod soup \n\nIngredients: \n250g cod fillets, cut into bite-sized pieces \n1 onion, finely chopped \n1 carrot, peeled and sliced \n1 potato, peeled and diced \n1 clove garlic, minced \n1 can (8 oz) diced tomatoes (undrained) \n2 cups fish or vegetable broth \nSalt and pepper to taste \n1 tbsp cooking oil \n\nInstructions: \n1. In a large pot, heat the cooking oil over medium heat. Add chopped onions, sliced carrots, diced potatoes, and minced garlic. Sauté for 4-5 minutes until the vegetables begin to soften. \n2. Pour in the diced tomatoes (with their juice) and stir. Add salt, and pepper. Cook for an additional 2-3 minutes. \n3. Add the fish or vegetable broth to the pot. Bring the mixture to a boil, then reduce the heat to low and let it simmer for about 10-15 minutes, allowing the vegetables to cook until tender. \n4. Gently add the bite-sized fish pieces to the simmering soup. Cook for an additional 5 minutes or until the fish is cooked through and flakes easily. \n5. Taste the soup and adjust the seasoning if needed with more salt and pepper. Ladle the hot soup into bowls.");
                    break;
                //beef
                case "3241":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Simmered Beef With Potatoes \n\nIngredients: \n2 medium potatoes, peeled \n150g beef topside, thinly sliced \n1 tbsp frozen peas \n1/2 tbsp oil \n1 medium onion, cut into wedges \n2 tbsp sugar \n3 tsp soy sauce \n\nInstructions: \n1. Cut each potato into quarters and soak them in cold water for 5 minutes. Drain well. \n2. Cut the beef into thin long strips. \n3. Pour hot water over the frozen peas and leave until thawed, then drain. \n4. Heat the oil in a deep frying pan. Remove from the heat and add the beef for 1 minute. \n5. Add the onion and potatoes, and fry for a further 2 minutes. \n6. Pour in the water and bring to a boil. Skim the broth carefully. Stir in the sugar, cover and simmer for a further 4-5 minutes. \n7. Finally, stir in the soy sauce for 2 miutes. \n8. Serve the beef and potatoes soup in a large bowl, sprinkled with peas.");
                    break;
                case "3242":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef Sticky Rice Balls \n\nIngredients: \n250g minced beef \n1 small egg \n1 tsp cornstarch \n2 spring onions, finely chopped \n1 tbsp chopped coriander \n1 tbsp fish sauce \nPinch of granulated sugar \nGround black pepper \n120g cooked sticky rice \nBanana leaves \nOil for brushing \nSweet chili sauce, to serve \n\nInstructions: \n1. In a mixing bowl, combine the minced beef, egg, cornstarch, spring onions, and coriander. Mix well and season with fish sauce, sugar and ground black pepper. \n2. Spread the cooked sticky rice on a plate or flat tray. \n3. Place a teaspoonful of the beef mixture on the bed of the rice. With damp hands, roll and shape the mixture in the rice to make a ball about the size of a walnut. Repeat the process with the rest. \n4. Line a bamboo steamer with banana leaf and lightly brush with oil. \n5. Place the beef balls on the leaves, spacing well apart to prevent them from sticking together. \n6. Steam over high heat for about 10 minutes. \n7. Remove and arrange on serving plates. Serve with sweet chili sauce to dip in.");
                    break;
                case "3243":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Cameroon Suya \n\nIngredients: \n250g frying steak \n1/4 tsp sugar \n1/2 tsp garlic granules \n1/2 tsp ground ginger \n1/2 tsp paprika \n1/2 tsp ground cinnamon \nPinch of chili powder \n1 tsp onion salt \n1/4 cup peanuts, finely crushed \nOil, for frying \n\nInstructions: \n1. Trim the steak of any fat and then cut into an inch wide strips. Place in a plate and set aside. \n2. Mix the sugar, garlic granules, spices, and onion salt together in a bowl. Add the crushed peauts. \n3. Add the mixture over the steak, mix well so that the spices are worked into the meat. \n4. Heat the oil in the pan and stir-fry the beef until browned. \n5. Serve while hot.");
                    break;
                case "3244":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steak And Potato Dinner \n\nIngredients: \n1 1/2 tbsp olive oil \n3 garlic cloves, crushed \n1/2 tsp coarse black pepper \n1/4 tsp chili powder \n1 tsp dried oregano \n1/2 tbsp cider vinegar \n2 boneless sirloin steaks \nSalt \n\nFor the potatoes: \n2 tbsp vegetable oil \n1 medium onion, chopped \n1/2 tsp salt \n400g potatoes, cooked and cubed \n1 green chili \n\nInstructions: \n1. Heat the olive oil in a pan. When hot, add the garlic and cook for about 3 minutes until brown, stir it often and do not let it burn. \n2. Transfer the garlic and oil to a shallow dish large enough to hold the steaks in a single layer. \n3. Add the pepper, spices, herbs, and vinegar to the garlic and stir to combine thoroughly. If necessary, add just enough water to obtain a moderately thick paste. \n4. Add the steaks to the mixture and turn to coat evenly on both sides. Cover and let sit for 2 hours. \n5. For the potatoes, heat the oil in a frying pan. Add the onions and salt. Cook over medium heat for about 5 minutes, until softened. \n6. Add the potatoes and chili. Cook, stirring occasionally, for 15-20 minutes until well browned. \n7. Season the steaks on both sides with salt to taste. Heat a ridged grill pan. \n8. When hot, add the steaks and cook, turning once, until done to your preference. \n9. Serve immediately, with the potatoes on the side.");
                    break;
                case "3245":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef Wonton Soup With Noodles \n\nIngredients: \n\nFor the Wontons: \n225g ground beef \n1/4 cup green onions, finely chopped \n1 tablespoon soy sauce \n1 teaspoon sesame oil \n1 teaspoon ginger, minced \n1 clove garlic, minced \n1 egg \nWonton wrappers (store-bought) \n\nFor the Soup: \n6 cups beef or vegetable broth \n1 cup bok choy, chopped \n1 cup mushrooms, sliced \n1 cup carrots, julienned \n1 tablespoon soy sauce (adjust to taste) \n1 teaspoon sesame oil \nSalt and pepper to taste \nNoodles \n\nInstructions: \n1. In a mixing bowl, combine ground beef, chopped green onions, soy sauce, sesame oil, minced ginger, minced garlic, and the egg. Mix well until all ingredients are combined. \n2. Place a small spoonful of the beef mixture in the center of a wonton wrapper. Moisten the edges of the wrapper with water and fold it in half to form a triangle, pressing the edges to seal. Bring the two opposite corners together and press to seal, creating a classic wonton shape. Repeat with the remaining wrappers and filling. \n3. In a large pot, bring the beef or vegetable broth to a simmer over medium heat. Add soy sauce, sesame oil, salt, and pepper to taste. \n4. Gently drop the wontons into the simmering broth. Cook for about 5-7 minutes or until the wontons are cooked through and float to the surface. \n5. Add chopped bok choy, sliced mushrooms, and julienned carrots to the soup. Simmer for an additional 5-7 minutes or until the vegetables are tender. \n6. Meanwhile, cook the noodles also in a separate pot. \n7. Taste the soup and adjust the seasoning with more soy sauce, salt, or pepper if needed. \n8. Place the cooked noodles into the bowls and ladle with hot soup and serve immediately.");
                    break;
                //vegetable
                case "3251":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Spinach with Potatoes \n\nIngredients: \n225g spinach \n1/2 tbsp oil \n1/2 thinly sliced onion \n1 crushed garlic clove \n1/2 in finely chopped root ginger \n350g largely diced potatoes \n1/2 tsp chili powder \n1/2 tsp salt \n1/4 cup water \n\nInstructions: \n1. Wash and trim the spinach, then blanch it in a saucepan of boiling water for about 3-4 minutes. \n2. Drain the spinach thoroughly and set aside. When it is cool enough to handle, use your hands to squeeze out any remaining liquid and set aside. \n3. Heat the oil in a large heavy-based saucepan and add the sliced onion, garlic cloves 4 and chopped ginger to the mustard seeds and fry for 5 minutes, stirring. \n4. Add the potato chunks, chili powder, salt and water and stir-fry for a further 8 minutes. \n5. Add the drained spinach. Cover the pan with a lid and simmer for 10-15 minutes or until the potatoes are tender.");
                    break;
                case "3252":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Carrot Cake \n\nIngredients: \n\nFor the Cake: \n2 cups grated carrots (about 3-4 medium-sized carrots) \n1 cup all-purpose flour \n1 cup granulated sugar \n1/2 cup vegetable oil \n3 large eggs \n1 teaspoon vanilla extract \n1 teaspoon ground cinnamon \n1/2 teaspoon ground nutmeg \n1/2 teaspoon baking powder \n1/2 teaspoon baking soda \n1/4 teaspoon salt \n\nFor the Cream Cheese Frosting: \n8 ounces cream cheese, softened \n1/2 cup unsalted butter, softened \n2 cups powdered sugar \n1 teaspoon vanilla extract \n\nInstructions: \n1. Fill a large pot with water, making sure it's deep enough to accommodate a steamer basket or a makeshift steaming setup. Place a heatproof plate or rack in the pot to keep the cake from direct contact with the water. \n2. In a large mixing bowl, whisk together the sugar, oil, eggs, and vanilla extract until well combined. \n3. In a separate bowl, whisk together the flour, cinnamon, nutmeg, baking powder, baking soda, and salt. \n4. Gradually add the dry ingredients to the wet ingredients, mixing until just combined. \n5. Fold in the grated carrots until evenly distributed in the batter. \n6. Pour the cake batter into a greased and floured cake pan that fits into your steamer setup. You can use a round or rectangular pan. \n7. Place the cake pan on the steamer basket or rack in the pot. \n8. Cover the pot with a lid and steam the cake over medium heat for 45-60 minutes, or until a toothpick inserted into the center comes out clean. \n9. While the cake is steaming, prepare the cream cheese frosting. In a mixing bowl, beat together the softened cream cheese, softened butter, powdered sugar, and vanilla extract until smooth and creamy. \n10. Once the cake is done steaming, carefully remove it from the pot and allow it to cool in the pan for a few minutes. \n11. Transfer the cake to a wire rack to cool completely. \n12. Once the cake is completely cooled, spread the cream cheese frosting evenly over the top. \n13. Slice and serve the steamed carrot cake.");
                    break;
                case "3253":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Chopsuey: \n\nIngredients:\n1 cup chicken breast or pork, thinly sliced \n1 cup shrimp, peeled and deveined \n1 cup broccoli florets \n1 cup cauliflower florets \n1 cup snow peas, trimmed \n1 cup carrots, julienned \n1 cup bell peppers (assorted colors), sliced \n1 cup cabbage, shredded \n1 cup baby corn \n1 cup snap peas \n1 cup tofu, cubed (optional) \n4 cloves garlic, minced \n1 onion, sliced \n2 tablespoons vegetable oil for stir-frying \n\nFor the Sauce: \n1/4 cup soy sauce \n1 cup chicken or vegetable broth \n1 tablespoon oyster sauce \n1 tablespoon cornstarch (dissolved in 2 tablespoons water) \nSalt and pepper to taste \n\nInstructions: \n1. In a bowl, mix soy sauce, chicken or vegetable broth, oyster sauce, and the dissolved cornstarch. Stir well to combine. Set aside. \n2. In a large wok or pan, heat 1 tablespoon of vegetable oil over medium-high heat. \n3. Add minced garlic and sliced onion. Sauté until fragrant and onions are translucent. \n4. Add sliced chicken or pork and cook until browned. \n5. If using tofu, add the cubed tofu and cook until lightly browned. \n6. Add shrimp and cook until they turn pink. \n7. Add the vegetables (broccoli, cauliflower, snow peas, carrots, bell peppers, cabbage, baby corn, and snap peas). Stir-fry for a few minutes until the vegetables are slightly tender but still crisp. \n8. Pour the prepared sauce over the stir-fried meat and vegetables. Stir well to coat everything with the sauce. \n9. Season with salt and pepper to taste. Adjust the seasoning according to your preference. \n10. Continue to cook for a few more minutes until the sauce thickens and coats the ingredients evenly. ");
                    break;
                case "3254":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Okoy \n\nIngredients:\n1 cup small shrimps, heads and shells on (cleaned and deveined) \n1 cup sweet potato, julienned \n1/2 cup flour \n1/2 cup cornstarch \n1/2 teaspoon baking powder \n1 teaspoon salt \n1/4 teaspoon ground black pepper \n1/2 cup water \n1 egg \nCooking oil for deep frying \n\nInstructions: \n1. Clean and devein the shrimps, leaving the heads and shells intact. Pat them dry with paper towels. \n2. In a bowl, combine flour, cornstarch, baking powder, salt, and ground black pepper. \n3. Add water gradually, stirring continuously to avoid lumps. \n4. Beat in the egg until the batter is smooth. \n5. Add the cleaned shrimps and julienned sweet potato to the batter. Mix well, ensuring that the shrimps and sweet potato are coated evenly. \n6. Heat cooking oil in a deep pan or wok over medium-high heat. \n7. Take a spoonful of the shrimp and batter mixture and carefully drop it into the hot oil, forming a small fritter. You can use a ladle to shape it. \n8. Fry until the edges are golden brown and crispy. Flip and fry the other side until evenly cooked. \n9. Remove the okoy from the oil and place it on a plate lined with paper towels to absorb excess oil.");
                    break;
                case "3255":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Potato Soup \n\nIngredients: \n4 cups potatoes, peeled and diced \n1 medium onion, finely chopped \n2 carrots, peeled and diced \n2 celery stalks, chopped \n3 cloves garlic, minced \n4 cups vegetable broth \n1 cup milk (whole milk or half-and-half for a creamier soup) \n3 tablespoons all-purpose flour \n3 tablespoons butter \nSalt and pepper to taste \nOptional toppings: shredded cheese, crispy bacon, chopped green onions, or sour cream \n\nInstructions: \n1. Peel and dice the potatoes, chop the onion, carrots, and celery, and mince the garlic. \n2. In a large pot, melt the butter over medium heat. Add the chopped onions, carrots, celery, and garlic. Sauté until the vegetables are softened, about 5-7 minutes. \n3. Add the diced potatoes to the pot and stir to combine with the sautéed vegetables. \n4. Sprinkle the flour over the vegetables and stir to create a roux. Cook for 2-3 minutes to remove the raw taste of the flour. \n5. Gradually pour in the vegetable broth, stirring constantly to avoid lumps. \n6. Bring the soup to a simmer and let it cook until the potatoes are tender, about 15-20 minutes. \n7. For a creamier texture, use an immersion blender to partially blend the soup. You can also transfer a portion of the soup to a blender, blend, and then return it to the pot. \n8. Pour in the milk and stir well. Simmer for an additional 5-10 minutes. \n9. Season the soup with salt and pepper to taste. \n10. Ladle the potato soup into bowls. Top with shredded cheese, crispy bacon, chopped green onions, or a dollop of sour cream if desired.");
                    break;
                //instant noodles
                case "3261":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3262":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3263":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3264":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3265":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //frozen foods
                case "3271":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3272":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3273":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3274":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3275":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //pork
                case "3281":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3282":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3283":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3284":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3285":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //high appetite
                //chicken
                case "3311":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3312":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3313":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3314":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3315":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //canned
                case "3321":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Canned chicken stew\n\nIngredients: \n500g canned chicken chunks (or shredded rotisserie chicken for added flavor) \n2 cans of mixed beans (kidney beans, black beans, or any variety of your choice, rinsed and drained) \n1 can of diced tomatoes \n1 large onion, finely chopped \n3 cloves garlic, minced \n2 tablespoons cooking oil \n4 cups chicken broth (you can use bouillon cubes to save costs) \n2 large carrots, peeled and sliced \n1 bell pepper, diced (any color) \n1 teaspoon dried oregano \nSalt and pepper to taste \n\nInstructions: \n1. In a large pot, heat oil over medium heat. Add chopped onions and minced garlic. Sauté until the onions are soft and translucent. \n2. Add the canned chicken chunks to the pot and cook until heated through. If using shredded rotisserie chicken, add it at a later step. \n3. Pour in the can of diced tomatoes and the cans of mixed beans (rinsed and drained). Stir well. \n4. Add the sliced carrots and diced bell pepper to the pot. \n5. Pour in the chicken broth and add dried oregano. Bring the stew to a boil, then reduce the heat to low and let it simmer for about 15-20 minutes. \n6. Season the stew with salt and pepper to taste. Adjust the seasoning as needed. \n7. If using shredded rotisserie chicken, add it now and let the stew simmer for an additional 5-10 minutes. \n8. Serve the chicken and bean stew hot. You can enjoy it as is or with a side of rice or crusty bread.");
                    break;
                case "3322":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Mackerel with Ginger and Soy Sauce \n\nIngredients: \n2 cans of mackerel fillets in water or oil, drained \n1 thumb-sized piece of ginger, julienned \n2 tablespoons soy sauce \n1 tablespoon oyster sauce \n1 tablespoon sesame oil \n2 green onions, finely chopped (for garnish) \n1 tablespoon rice vinegar \n1 teaspoon sugar \nCooked rice (for serving) \n\nInstructions: \n1. Prepare the Steamer. If you don't have a steamer, you can set up a makeshift one by placing a heatproof dish on a rack inside a large pot with a tight-fitting lid. Add water to the pot, ensuring that the water level is below the rack. \n2. Lay the drained mackerel fillets in a heatproof dish suitable for steaming. \n3. a bowl, combine soy sauce, oyster sauce, sesame oil, rice vinegar, and sugar. Mix well until the sugar is dissolved. \n4. Spread the julienned ginger over the mackerel fillets. Pour the sauce evenly over the fish. \n5. Place the dish in the steamer or on the rack inside the pot. Cover and steam over medium-high heat for about 10-15 minutes or until the mackerel is cooked through and flakes easily with a fork. \n6. Once the mackerel is cooked, sprinkle chopped green onions over the top for garnish. \n7. Serve the steamed mackerel with ginger and soy sauce over a bed of cooked rice.");
                    break;
                case "3323":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sauteed Ham with Pineapple \n\nIngredients: \n2 cans of canned ham, diced \n1 cup pineapple chunks (fresh or canned) \n1 large bell pepper, diced (any color) \n1 small red onion, thinly sliced \n2 cloves garlic, minced \n2 tablespoons cooking oil \n1 tablespoon soy sauce \n1 teaspoon honey or maple syrup \n1 teaspoon Dijon mustard \nSalt and pepper to taste \nChopped fresh parsley for garnish (optional) \n\nInstructions: \n1. In a large skillet, heat oil over medium heat. Add sliced onions and diced bell peppers. Sauté until they become tender and slightly caramelized. \n2. Add minced garlic to the skillet and sauté for an additional 30 seconds until fragrant. \n3. Add the diced canned ham to the skillet. Cook for 3-5 minutes, stirring occasionally, until the ham is lightly browned. \n4. In a small bowl, whisk together soy sauce, honey (or maple syrup), and Dijon mustard. \n5. Pour the soy sauce mixture over the ham and vegetables. Stir well to coat the ingredients evenly. \n6. Add pineapple chunks to the skillet. Continue to cook for an additional 2-3 minutes until the pineapple is heated through. \n7. Season with salt and pepper to taste. Adjust the seasoning as needed. \n8. Garnish with chopped fresh parsley if desired. \n9. Serve the sauteed ham with pineapple over cooked rice or noodles.");
                    break;
                case "3324":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fried Canned Corned Beef Patties: \n\nIngredients: \n2 cans of corned beef \n1 cup mashed potatoes (prepared in advance) \n1/2 cup finely chopped onions \n1/4 cup finely chopped bell peppers (any color) \n2 cloves garlic, minced \n1/2 cup all-purpose flour \n2 eggs, beaten \n1 cup breadcrumbs \nCooking oil for frying \nSalt and black pepper to taste \nOptional: Hot sauce or your favorite dipping sauce \nOptional: Chopped fresh herbs for garnish \n\nInstructions: \n1. In a large mixing bowl, combine the corned beef, mashed potatoes, chopped onions, chopped bell peppers, and minced garlic. \n2. Mix the ingredients thoroughly until well combined. \n3. Take a portion of the mixture and shape it into a patty. The size can be adjusted based on your preference. \n4. Set up a breading station with three bowls: one with flour, one with beaten eggs, and one with breadcrumbs. \n5. Coat each corned beef patty in flour, dip it in beaten eggs, and then coat it in breadcrumbs, ensuring an even coating. \n6. In a large skillet, heat enough cooking oil over medium heat for shallow frying. \n7. Carefully place the coated corned beef patties into the hot oil. Fry for about 3-4 minutes on each side or until they are golden brown and crispy. \n8. Transfer the fried patties to a plate lined with paper towels to absorb excess oil. Season with salt and black pepper while they are still hot. \n9. Optionally, garnish with chopped fresh herbs. Serve the fried corned beef patties hot with your favorite dipping sauce or a dash of hot sauce.");
                    break;
                case "3325":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Italian Sausage and White Bean Soup with Canned Ingredients: \n\nIngredients: \n2 cans of canned Italian sausage or canned sausages of your choice, sliced \n2 cans of white beans (cannellini or navy beans), drained and rinsed \n1 can of diced tomatoes (400g) \n1 large onion, finely chopped \n2 carrots, peeled and diced \n2 celery stalks, chopped \n3 cloves garlic, minced \n1 teaspoon dried oregano \n1 teaspoon dried basil \n1/2 teaspoon dried rosemary \n6 cups chicken or vegetable broth \nSalt and black pepper to taste \n2 tablespoons olive oil \nGrated Parmesan cheese for serving (optional) \nFresh parsley for garnish (optional) \n\nInstructions: \n1. In a large pot, heat olive oil over medium heat. Add chopped onion, carrots, celery, and garlic. Sauté until the vegetables are softened. \n2. Add the sliced canned Italian sausage or sausages of your choice to the pot. Sauté for 5-7 minutes until the sausage is browned. \n3. Stir in the drained white beans and the diced tomatoes with their juices. Mix well to combine. \n4. Add dried oregano, dried basil, and dried rosemary to the pot. Stir to incorporate the herbs. \n5. Pour in the chicken or vegetable broth. Bring the soup to a boil. \n6. Reduce the heat to low, cover the pot, and let the soup simmer for about 15-20 minutes to allow the flavors to meld. \n7. Taste and adjust the seasoning with salt and black pepper as needed. \n8. Ladle the soup into bowls. Garnish with fresh parsley and grated Parmesan cheese if desired. Serve hot.");
                    break;
                //fish
                case "3331":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fish Boulettes in Hot Tomato Sauce \n\nIngredients: \n350g cod\nbunch flat leaf parsley \n1 small egg \n1/4 cup white breadcrumbs \n3/4 tbsp olive oil \n1/2 tbsp lemon juice \nFor the sauce: /n1/2 very finely chopped onion \n1 crushed garlic clove \n3 peeled, seeded, and chopped tomato \n1 seeded and chopped green or red chili \n3 tbsp olive oil \n1/3 cup water \n1/2 tbsp lemon juice \n\nInstructions: \n1. Skin the fish and, if necessary, remove any bones. \n2. Cut the fish into large chunks and place in a blender or a food processor. \n3. Add in the parsley, egg, breadcrumbs, olive oil, and lemon juice. Season well with salt and pepper and process for process or blend for 10-20 seconds until the fish is finely chopped and all the ingredients are combined. \n4. Mold the mixture into small balls about the size of walnuts and place them in a single layer on a plate. \n5. To make the sauce, place the onion, garlic, tomatoes, chili, olive oil, and water in a saucepan; and bring to the boil and then simmer, partially covered, for 10-15 minutes until the sauce is slightly reduced. \n6. Add the lemon juice and then place the fish balls in the simmering sauce. \n7. Cover and simmer very gently for 12-15 minutes until the fish balls are cooked through, turning them over occasionally. \n8. Taste for seasoning and serve.");
                    break;
                case "3332":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Cod \n\nIngredients: \n2 cod fillets (about 6-8 ounces each) \n2 tablespoons soy sauce \n1 tablespoon rice vinegar \n1 tablespoon sesame oil \n1 tablespoon ginger, finely grated \n2 cloves garlic, minced \n1 tablespoon green onions, chopped \n1 teaspoon honey or maple syrup (optional, for sweetness) \nSesame seeds for garnish (optional) \n\nInstructions: \n1. Set up your steamer. If you don't have a steamer, you can use a makeshift one with a heatproof plate or bamboo steamer placed over a pot of simmering water. \n2. Pat the cod fillets dry with a paper towel. If there are any bones, remove them using tweezers. \n3. In a bowl, mix soy sauce, rice vinegar, sesame oil, grated ginger, minced garlic, chopped green onions, and honey or maple syrup (if using). Stir the marinade well. \n4. Place the cod fillets in a shallow dish or on a plate with raised edges. Pour the marinade over the cod, ensuring that it coats the fish evenly. Allow the cod to marinate for at least 15-30 minutes. \n5. Place the marinated cod fillets in the steamer basket. Steam for about 10-12 minutes, depending on the thickness of the fillets. The cod is done when it flakes easily with a fork. \n6. Test the doneness by poking the thickest part of the fish with a fork. If the flesh flakes easily, the cod is done. \n7. Carefully transfer the steamed cod to serving plates. Garnish with sesame seeds if desired.");
                    break;
                case "3333":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Sauteed Cod with Prawns: \n\nIngredients: \n375g cod fillets \n125g prawns \n1 tbsp olive oil \n1 chopped small onion \n1 cup fish stock \n\nFor the marinade: \n1 crushed garlic clove \n2 tsp ground cumin \n2 tsp paprika \nPinch of chili powder \n1 tbsp chopped parsley \n1 tbsp chopped fresh coriander \n1 1/2 tbsp vinegar \n1/2 tbsp lemon juice \nLemon wedges, to serve (optional) \n\nInstructions: \n1. First make the marinade by mixing the crushed garlic, spices, herbs, vinegar, and lemon juice together in a bowl. \n2. Skin the fish if necessary and remove any bones, then cut into large bite-size chunks. \n3. Remove the top and tail of the prawns and remove the shell. Using a sharp knife, cut along the back of each prawn and pull away and discard the dark thread. \n4. Place the fish and prawns in two separate shallow dishes, add half the marinade to each dish and stir well to coat evenly. \n5. Cover with clear film and set aside in a cool place for an hour. \n6. Heat the oil in a large pot and fry the onion for 2 minutes. Add the fish stock and cook for a further 5 minutes. \n7. Add the marinated fish, stir gently and cook for 4 minutes, then add the prawns and all the remaining marinade and cook for a further 5-6 minutes until the fish is tender and the prawns are pink. \n8. Serve in a bowls, with lemon wedges for squeezing if you wish.");
                    break;
                case "3334":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Cod Parcels \n\nIngredients: \n3/4 cup strong plain flour \n1 egg \n60g skinless cod fillet, diced \nGrated rind of half a lemon \n1 garlic clove, chopped \n1 small red chili, seeded and sliced \n1 1/2 tbsp chopped fresh parsley \n1 tbsp single cream \nOil for frying \n\nFor tomato oil: \n1 tomato, peeled, seeded, and finely diced \n1 1/2 tbsp virgin olive oil \n1/2 tbsp fresh lemon juice \nSalt and freshly ground black pepper \n\nInstructions: \n1. Place the flour, eggs, and ¼ tsp salt in a food processor or pestle and mortar; mix until the mixture forms a soft dough. \n2. Take out the dough and knead for 2-3 minutes then wrap in clear film. Chill the dough for 20 minutes. \n3. Place the cod, chili, and parsley in a food processor or pestle and mortar; mix until there are no chunks left in the mixture. \n4. Add the cream, with plenty of salt and pepper and mix again to form a very thick puree. \n5. Make the tomato oil by stirring the diced tomato with the olive oil and lemon juice in a bowl. Add salt to taste, then cover and chill. \n6. Roll out the dough on a lightly floured surface and cut out round shapes using a cutter. Divide the filling among half the rounds, then cover with the remaining rounds. \b7. Pinch the edges tightly to seal, trying to exclude as much air as possible. \n8. Heat the oil in a frying pan. Then place the dish into the pan and cook until golden brown. \n9. Transfer to a plate and drizzle with the tomato oil.");
                    break;
                case "3335":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fish Ball Soup \n\nIngredients: \n10g root ginger \n400g lapu-lapu, gutted and heads removed /n1 tbsp white miso paste \n1/4 tbsp sugar \n1 egg \n1 1/2 tbsp flour \n80g shiitake mushrooms \n1/2 leek or medium spring onion \n\nFor the soup: \n50ml water \n3 cups vegetable stock \n2 tbsp white miso paste \n\nInstructions: \n1. Grate the ginger and squeeze it well to yield ginger juice. \n2. Rinse the fish under cold water and clean it thoroughly, removing all the scales, skin, and bones. Cut the fish into small pieces. \n3. Add in the fish, miso, sugar, egg, and ginger juice in a food processor or in a pestle and mortar to turn it into a pate. Once done, transfer to a bowl and mix in the flour thoroughly. \n4. Remove the stems from the shiitake mushrooms and shred them. Cut the leek or spring onion into 4cm long strips. \n5. Bring the ingredients for the soup to a boil. \n6. Use two wet spoons to shape small portions of the fish mixture into bite-sized balls and drop them into the soup. Add the mushrooms and leeks or spring onion. \n7. Simmer until the fish balls float to the surface. Serve immediately in bowls.");
                    break;
                //beef
                case "3341":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Peppered Steak in Cream Sauce \n\nIngredients: \n350g frying steak \n1/2 tsp chili powder \n1 tbsp butter \n3 shallots, sliced \n1 garlic clove, crushed \n2 tbsp water \n3 tbsp single cream \nSalt and ground black pepper \nParsley, to garnish \n\nInstructions: \n1. Cut the meat into thin strips, discarding any fat or gristle. \n2. Season the meat with pepper and chili powder and leave to marinate in a cool place for 30 minutes. \n3. Melt the butter in a large frying pan and saute the meat for 4-5 minutes until browned on all sides. Transfer to a plate and set aside. \n4. Add the shallots and garlic to the pan, fry gently for a few minutes then add the water and sinner for 2 minutes. Stir in the single cream. \n5. Reduce the heat and adjust the seasoning. Stir in the meat and heat until hot bot not boiling. \n6. Serve while hot and garnish with parsley.");
                    break;
                case "3342":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef Wonton Soup \n\nIngredients: \n\nFor the Wontons: \n225g ground beef \n1/4 cup green onions, finely chopped \n1 tablespoon soy sauce \n1 teaspoon sesame oil \n1 teaspoon ginger, minced \n1 clove garlic, minced \n1 egg \nWonton wrappers (store-bought) \n\nFor the Soup: \n6 cups beef or vegetable broth \n1 cup bok choy, chopped \n1 cup mushrooms, sliced \n1 cup carrots, julienned \n1 tablespoon soy sauce (adjust to taste) \n1 teaspoon sesame oil \nSalt and pepper to taste \n\nInstructions: \n1. In a mixing bowl, combine ground beef, chopped green onions, soy sauce, sesame oil, minced ginger, minced garlic, and the egg. Mix well until all ingredients are combined. \n2. Place a small spoonful of the beef mixture in the center of a wonton wrapper. Moisten the edges of the wrapper with water and fold it in half to form a triangle, pressing the edges to seal. Bring the two opposite corners together and press to seal, creating a classic wonton shape. Repeat with the remaining wrappers and filling. \n3. In a large pot, bring the beef or vegetable broth to a simmer over medium heat. Add soy sauce, sesame oil, salt, and pepper to taste. \n4. Gently drop the wontons into the simmering broth. Cook for about 5-7 minutes or until the wontons are cooked through and float to the surface. \n5. Add chopped bok choy, sliced mushrooms, and julienned carrots to the soup. Simmer for an additional 5-7 minutes or until the vegetables are tender. \n6. Taste the soup and adjust the seasoning with more soy sauce, salt, or pepper if needed. \n7. Place the cooked noodles into the bowls and ladle with hot soup and serve immediately.");
                    break;
                case "3343":
                    Console.Clear();
                    Console.WriteLine("Veal Cutlets with Lemon \n\nIngredients: \n2 veal cutlets \n2 tbsp flour \n2 tbsp butter \n2 tbsp olive oil \n2 tbsp water \n1 1/2 tbsp lemon juice vSalt and ground black pepper \nLemon wedges, to serve \n\nInstructions: \n1. Put each veal cutlet between two sheets of clear film and pound until very thin. \n2. Cut the pounded cutlets in half of quarters, if you like, and coat them in flour, seasoned with salt and pepper. \n3. Melt the butter with half the oil in a large, frying pan until sizzling. Add as many cutlets as the pan will hold and fry over a medium heat for 2 minutes on each side until lightly colored. \n4. Remove the veal from the pan and keep hot. \n5. Add the remaining oil and cook the remaining cutlets in the same way and set aside. \n6. Remove the pan from the heat and add the water and lemon juice. Stir vigorously to mix with the pan juices. \n7. Then return the pan to the heat and return all the veal to the pan. Using a spoon, get the sauce to coat the veal. \n8. Shake the pan over a medium heat until all the cutlets are coated in the sauce and heated through. \n9. Serve at once, paired with lemon wedges.");
                    break;
                case "3344":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Japanese-Style Hamburgers \n\nIngredients: \n2 tbsp oil, plus extra for greasing hands \n1 small onion, finely chopped \n500g minced beef \n1 cup breadcrumbs \n1 egg \n1 tsp salt \nBlack pepper \n115g shiitake mushrooms, stems discarded, and sliced \n200g radish, finely grated \n1 1/2 tbsp soy sauce \n\nInstructions: \n1. Heat 1 tbsp oil in a frying pan and fry the onion gently until soft but not browned. Leave to cool. \n2. Put the minced beef with the fried onion, breadcrumbs, and egg. Season with salt and pepper. \n3. Knead the mixture well by hands until the ingredients are thoroughly combined and the mixture becomes sticky. It is important to keep the meat soft and juicy for this recipe. Divide the mixture into four. \n4. Put a little oil in your hands. Take a portion of the mixture and throw it from one hand to other. Repeat this process 5 or 6 times to remove any air. Then shape the mixture into thick burger patties. Repeat with the remaining mixture. \n5. Heat the remaining oil in a frying pan and add the burgers. Fry over a high heat until browned on one side, then turn over. \n6. Place the shiitake mushrooms in the pan, next to the burgers, cover and cook over a low heat for 3-4 minutes or until cooked through, stirring the mushrooms occasionally. \n7. Serve the burgers topped with the radish, mushrooms and soy sauce. \n8. It can be eaten with bread or rice.");
                    break;
                case "3345":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Beef And Herb Soup With Yogurt \n\nIngredients: \n1 large onion \n1 tbsp oil \n1/2 tbsp ground turmeric \n3 cups water \n120g minced beef \n1/2 cup rice \n2 tbsp parsley, chopped \n1 tbsp chives, chopped \n1/2 tbsp butter \n1 small garlic clove, finely chopped \nSalt and ground black pepper \nYogurt, to serve \n\nInstructions: \n1. Halve the onion and set aside the other one. Meanwhile, chop the other half then heat the oil in a large saucepan and fry the onion until golden brown. \n2. Add the turmeric, and water, bring to the boil, then reduce the heat and simmer for 20 minutes. \n3. Grate the remaining half of the onion into a bowl, add the minced beef and seasoning and mix well. \n4. Using your hands, shape the mixture into small balls, about the size of walnuts. \n5. Carefully add to the pan and simmer for 10 minutes. \n6. Add the rice, then stir in the parsley and chives and simmer for about 30 minutes, until the rice is tender, stirring frequently. \n7. Melt the butter in a small pan and gently fry the garlic. \n8. Ladle the soup into bowls and serve with yogurt.");
                    break;
                //vegetable
                case "3351":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Vegetables in Peanut Sauce \n\nIngredients: \n1/2 tbsp palm or vegetable oil \n1/2 chopped onion \n1 crushed garlic clove \n200g pureed canned tomatoes \n1 1/2 smooth peanut butter, preferably unsalted \n2 cups water \n1/2 tsp dried thyme \n1 chopped and seeded green chili \n1 vegetable stock cube \n2 carrots \n60g white cabbage \n90g okra \n1/4 red pepper \n1/4 cup vegetable stock \nSalt \n\nInstructions: \n1. Heat the oil in a large saucepan and fry the onion and garlic over a moderate heat for 5 minutes, stirring frequently. \n2. Add the tomatoes and peanut butter and stir well. \n3. Stir in the water, thyme, chilli, stock cube, and a little salt. Bring to the boil and then simmer gently, uncovered for about 35 minutes. \n4. Cut the carrots into sticks, slice the cabbage, top and tail the okra and seed and slice the red pepper. \n5. Place the vegetables in a saucepan with the stock, bring to the boil and cook until tender but still with a little 'bite'. \n6. Drain the vegetables and place in a warmed serving dish. \n7. Pour the sauce over the top and serve.");
                    break;
                case "3352":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Steamed Vegetable Medley with Quinoa: \n\nIngredients: \n\nFor the Steamed Vegetables: \nAssorted vegetables (e.g., broccoli, carrots, cauliflower, bell peppers, snap peas) \nOlive oil \nMinced garlic \nLemon juice \nSalt and pepper to taste \n\nFor the Quinoa: \n1 cup quinoa \n2 cups water or vegetable broth \nSalt to taste \n\nInstructions: \n1. Rinse the quinoa under cold water. \n2. In a saucepan, combine quinoa, water or vegetable broth, and a pinch of salt. \n3. Bring to a boil, then reduce the heat to low, cover, and simmer for 15-20 minutes, or until the quinoa is cooked and the liquid is absorbed. Fluff the quinoa with a fork. \n4. Wash and cut the vegetables into bite-sized pieces. \n5. In a steamer basket over boiling water, steam the vegetables for 5-10 minutes or until they are tender but still crisp. \n6. While steaming, heat olive oil in a pan over medium heat. Add minced garlic and sauté until fragrant. \n7. Once the vegetables are steamed, transfer them to the pan with garlic. Toss gently to coat the vegetables with garlic-infused oil. \n8. Squeeze fresh lemon juice over the vegetables and season with salt and pepper to taste. \n9. If desired, sprinkle fresh herbs over the vegetables. \n10. Spoon a portion of quinoa onto each plate. \n11. Top the quinoa with the steamed vegetable medley. \n12. Drizzle any remaining garlic-infused oil from the pan over the dish for added flavor. \n13. Serve the steamed vegetable and quinoa medley as a healthy and satisfying meal.");
                    break;
                case "3353":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Pineapple Fried Rice \n\nIngrdients:\n½ chopped pineapple \n15ml vegetable oil \n1 finely chopped small onion \n1 seeded and chopped green chilies \n100g small diced lean pork \n450g cooked rice \n1 chopped spring onion. \n15ml fish sauce \n\nInstructions: \n1. Remove the flesh of the pineapple by cutting round into the skin. Reserve the skin shells. \n2. Heat the oil in a wok or large frying pan. \n3. Add the onion and chilies and fry for about 3-5 minutes until softened. Add the pork and cook until its brown on all sides. Continue to stir-fry until the rice is thoroughly heated. \n4. Add the chopped pineapple and spring onion. Season with fish sauce and soy sauce. \n5. Place the dish into the pineapple shell.");
                    break;
                case "3354":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Fried Potato and Egg \n\nIngredients:\n1 large potato \n3 eggs \n1 pack breading mix \nCooking Oil \nSalt to taste \nPepper to taste \n\nInstruction \n1. Wash and peel the potatoes. \n2. Slice it into small dice cuts. \n3. Fry the potato till it soften. Set Aside. \n4. Put the eggs, breading mix, salt and pepper into a bowl and stir well. \n5. Add the potato into the bowl. \n6. Heat a pan over medium heat and add cooking oil. \n7. Fry the mixture until golden brown. Do not cook it all at once. Instead, fry it by batch. \n8. Place it on a tissue paper to absorb excess oil.");
                    break;
                case "3355":
                    Console.Clear();
                    Console.WriteLine("Your Meal: Bulanglang \n\nIngredients: \n1 sliced medium-sized eggplants \n1 sliced small-sized radish \n1/2 sliced squash \n1/2 bundle string beans (sitaw), cut into 2-inch pieces \n1/2 bundle swamp cabbage (kangkong), separated into stalks and leaves \n1 sliced medium-sized tomatoes \n1/2 sliced thumb-sized ginger \n2 pieces of okra, sliced (optional) \n2 pieces of green chili peppers (siling haba) \n1/2 liter rice washing (water used to rinse rice) \nSalt and fish sauce (patis) to taste \n1 tbsp cooking oil \n\nInstructions: \n1. Wash and prepare all the vegetables as mentioned above. \n2. In a large pot, heat the cooking oil over medium heat. \n3. Sauté ginger until fragrant. \n4. Add tomatoes and cook until softened. \n5. Pour in the rice washing (or water) into the pot. \n6. Add the radish, squash, and eggplants. Bring to a simmer. \n7. Season with salt and fish sauce according to your taste preference. \n8. Once the radish, squash, and eggplants are partially cooked, add the okra and string beans. \n9. Allow the vegetables to cook until they are tender but not overcooked. \n10. Add the swamp cabbage (kangkong) stalks and leaves. Cook until the greens are wilted. \n11. Add green chili peppers for a bit of heat. \n12. Taste the broth and adjust the seasoning with more salt or fish sauce if needed. \n13. Once all the vegetables are tender and cooked, remove the pot from heat.");
                    break;
                //instant noodles
                case "3361":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3362":
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3363":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3364":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3365":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //frozen foods
                case "3371":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3372":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3373":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3374":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3375":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                //pork
                case "3381":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3382":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3383":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3384":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
                case "3385":
                    Console.Clear();
                    Console.WriteLine("Your Meal: ");
                    break;
            }
            Console.WriteLine("\v===============================================================================================================================================================");
            Console.WriteLine("\vWould you like to retry the program?");
            Console.WriteLine(">>  Press DOWN ARROW if your satisfied with the suggested dish");
            Console.WriteLine(">>  Press UP ARROW if you want to run the program again");

            ConsoleKeyInfo keysPressed = Console.ReadKey(true);


            if (keysPressed.Key == ConsoleKey.DownArrow)
            {
                Console.Clear();
                string goodbye = @"
			
			
			
			
			
	    	 ________    __   __    ______    __   __    _    _      ___   ___   _____    _   _
	       /|__    __| /|  | |  | /|  __  | /|  \ |  | /| |  / /    /\  \_/  / /|  _  | /| | | |
	       ////| |//   /|  [_]  | /| |__| | /|   \|  | /| [_/ /      /\     /  /| | | | /| | | |
	    	   | |     /|   _   | /|  __  | /|  |\   | /|  _ <        /\   /   /| | | | /| | | |
	    	   | |     /|  [ ]  | /| |  | | /|  | \  | /| [ \ \        /| |    /| |_| | /| [_] |
	    	   | |     /|__| |__| /|_|  |_| /|__|  \_| /|_|  \_\       /|_|    /|_____| /|_____|
	    	   //      ////  //// ///   //  ////   //  ///   ///        ///    ///////  ///////   ";

                Console.WriteLine(goodbye);
            }
            else if (keysPressed.Key == ConsoleKey.UpArrow)
            {
                Console.Clear();
                goto start;

            }
        }

        static char GetChoice(string prompt, char[] validChoices)
        {
            Console.Write(prompt);
            char choice = Convert.ToChar(Console.ReadLine());
            while (Array.IndexOf(validChoices, choice) == -1)
            {
                Console.WriteLine("\nPlease enter a valid choice.");
                Console.Write(prompt);
                choice = Convert.ToChar(Console.ReadLine());
            }
            return choice;
        }
    }
    }
