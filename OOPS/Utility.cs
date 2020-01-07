// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Utility class for all programs.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<Rice> rice { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<Pulses> pulses { get; set; }

        /// <summary>
        /// Gets or sets the wheats.
        /// </summary>
        /// <value>
        /// The wheats.
        /// </value>
        public List<Wheats> wheats { get; set; }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
      public List<Stock> Stock { get; set; }

        /// <summary>
        /// Inventory management which reads JSON file.
        /// </summary>
        public static void InventoryManagement()
        {
            double totalRicePrice = 0;
            double totalPulsePrice = 0;
            double totalWheatPrice = 0;
            //// FilePath have the path of that file where JSON file is stored
            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
            StreamReader streamReader = new StreamReader(filePath);
            string read = streamReader.ReadToEnd();
            InventoryDataManagement inventoryData = (InventoryDataManagement)JsonConvert.DeserializeObject(read, typeof(InventoryDataManagement));

            Console.WriteLine("********* Rice ********\n");
            //// foreach class print the class Rice 
            //// Rice class have details type of Rice
            foreach (Rice objectRice in inventoryData.rice)
            {
                string name = objectRice.Name;
                double weight = objectRice.Weight;
                double price = objectRice.Price;
                totalRicePrice = totalRicePrice + (price * weight);
                Console.WriteLine("Rice Name : " + name);
                Console.WriteLine("Rice Weight : " + weight);
                Console.WriteLine("Rice Price : " + price);
                double ricePrice = price * weight;
                Console.WriteLine("Total Price Of " + objectRice.Name + " Is : " + ricePrice + "\n");
            }

            Console.WriteLine("Total Amount of Rice Is : " + totalRicePrice + "\n");

            Console.WriteLine("********* Pulses ********\n");
            //// foreach class print the class Pulses 
            //// Pulses class have details type of Pulses
            foreach (Pulses objectPulse in inventoryData.pulses)
            {
                string name = objectPulse.Name;
                double weight = objectPulse.Weight;
                double price = objectPulse.Price;
                totalPulsePrice = totalPulsePrice + (price * weight);
                Console.WriteLine("Pulse Name : " + name);
                Console.WriteLine("Pulse Weight : " + weight);
                Console.WriteLine("Pulse Price : " + price);
                double pulsePrice = price * weight;
                Console.WriteLine("Total Price Of " + objectPulse.Name + " Is : " + pulsePrice + "\n");
            }

            Console.WriteLine("Total Amount of Pulse Is : " + totalPulsePrice + "\n");

            Console.WriteLine("********* Wheats ********\n");
            //// foreach class print the class Wheats 
            //// Wheats class have details type of Wheats
            foreach (Wheats objectWheat in inventoryData.wheats)
            {
                string name = objectWheat.Name;
                double weight = objectWheat.Weight;
                double price = objectWheat.Price;
                totalWheatPrice = totalWheatPrice + (price * weight);
                Console.WriteLine("Wheat Name : " + name);
                Console.WriteLine("Wheat Weight : " + weight);
                Console.WriteLine("Wheat Price : " + price);
                double wheatPrice = price * weight;
                Console.WriteLine("Total Price Of " + objectWheat.Name + " Is : " + wheatPrice + "\n");
            }

            Console.WriteLine("Total Amount of Wheat Is : " + totalWheatPrice);
            streamReader.Close();
        }

        /// <summary>
        /// Adds the inventory.
        /// </summary>
        public static void AddInventory()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine(" 1 : Add Rice \n 2 : Add Pulses \n 3 : Add Wheats \n 4 : Exit");
                    Console.WriteLine("Enter In Which Inventory To Add : ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Rice Name : ");
                            string riceName = Console.ReadLine();

                            Console.WriteLine("Enter Rice Weight : ");
                            double riceWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Rice Price : ");
                            double ricePrice = Convert.ToDouble(Console.ReadLine());
                            var newRiceMember = "{'Name': '" + riceName + "' ,'Weight':" + riceWeight + ",'Price':" + ricePrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var riceArray = jsonObj.GetValue("Rice") as JArray;
                                var newRice = JObject.Parse(newRiceMember);
                                riceArray.Add(newRice);
                                jsonObj["Rice"] = riceArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter Pulse Name : ");
                            string pulseName = Console.ReadLine();

                            Console.WriteLine("Enter Pulse Weight : ");
                            double pulseWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Pulse Price : ");
                            double pulsePrice = Convert.ToDouble(Console.ReadLine());
                            var newPulseMember = "{'Name': '" + pulseName + "' ,'Weight':" + pulseWeight + ",'Price':" + pulsePrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var riceArray = jsonObj.GetValue("Rice") as JArray;
                                var newPulse = JObject.Parse(newPulseMember);
                                riceArray.Add(newPulse);
                                jsonObj["Pulses"] = riceArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                                System.Console.WriteLine();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);                                
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter Wheat Name : ");
                            string wheatName = Console.ReadLine();

                            Console.WriteLine("Enter Wheat Weight : ");
                            double wheatWeight = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Wheat Price : ");
                            double wheatPrice = Convert.ToDouble(Console.ReadLine());
                            var newWheatMember = "{'Name': '" + wheatName + "' ,'Weight':" + wheatWeight + ",'Price':" + wheatPrice + "}";

                            try
                            {
                                //// FilePath have the path of that file where JSON file is stored
                                string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                                var json = File.ReadAllText(filePath);
                                var jsonObj = JObject.Parse(json);
                                var wheatArray = jsonObj.GetValue("Wheats") as JArray;
                                var newWheat = JObject.Parse(newWheatMember);
                                wheatArray.Add(newWheat);
                                jsonObj["Wheats"] = wheatArray;
                                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                File.WriteAllText(filePath, newJsonResult);
                                Console.WriteLine("Inventory Added Successfully");
                            }
                            catch (FileNotFoundException fnot)
                            {
                                Console.WriteLine(fnot.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Add Error : " + e.Message);
                            }

                            break;
                        case 4:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Choice Not Found");
                            break;
                    }
                }
            }
            catch (FormatException e1)
                {
                Console.WriteLine(e1.Message);
            }
        }

        public static void UpdateInventory()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1 : Update Rice \n 2 : Update Pulses \n 3 : Update Wheats \n 4 : Exit");
                Console.WriteLine("Select Inventory To Update : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray riceArray = (JArray)jsonObj["Rice"];
                            Console.WriteLine("Enter Rice Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in riceArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Rice Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Rice Weight : ");
                                update["Weight"] = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter New Rice Price : ");
                                update["Price"] = Convert.ToInt32(Console.ReadLine());
                                found = true;
                            }

                            jsonObj["Rice"] = riceArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 2:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray pulseArray = (JArray)jsonObj["Pulses"];
                            Console.WriteLine("Enter Pulse Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in pulseArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Pulse Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Pulse Weight : ");
                                update["Weight"] = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter New Pulse Price : ");
                                update["Price"] = Convert.ToInt32(Console.ReadLine());
                                found = true;
                            }

                            jsonObj["Pulses"] = pulseArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter valid Input");
                        }

                        break;
                    case 3:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray wheatArray = (JArray)jsonObj["Wheats"];
                            Console.WriteLine("Enter Wheat Name To Update");
                            string updateName = Console.ReadLine();
                            bool found = false;
                            foreach (var update in wheatArray.Where(obj => obj["Name"].Value<string>() == updateName))
                            {
                                Console.WriteLine("Enter New Wheat Name : ");
                                update["Name"] = Console.ReadLine();
                                Console.WriteLine("Enter New Wheat Weight : ");
                                update["Weight"] = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter New Wheat Price : ");
                                update["Price"] = Convert.ToInt32(Console.ReadLine());
                                found = true;
                            }

                            jsonObj["Wheats"] = wheatArray;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(filePath, output);
                            Console.WriteLine("Inventory Updated Successfully");
                            if (!found)
                            {
                                Console.WriteLine(updateName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choice Not Found");
                        break;
                }
            }
        }

        public static void DeleteInventory()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(" 1 : Delete Rice \n 2 : Delete Pulses \n 3 : Delete Wheats \n 4 : Exit");
                Console.WriteLine("Select Inventory To Delete : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray riceArray = (JArray)jsonObj["Rice"];
                            Console.WriteLine("Enter Rice Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Rice"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = riceArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    riceArray.Remove(itemToDelete);
                                    jsonObj["Rice"] = riceArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 2:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray pulseArray = (JArray)jsonObj["Pulses"];
                            Console.WriteLine("Enter Pulse Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Pulses"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = pulseArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    pulseArray.Remove(itemToDelete);
                                    jsonObj["Pulses"] = pulseArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter valid Input");
                        }

                        break;
                    case 3:
                        try
                        {
                            //// FilePath have the path of that file where JSON file is stored
                            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\Inventry.json";
                            var json = File.ReadAllText(filePath);
                            var jsonObj = JObject.Parse(json);
                            JArray wheatArray = (JArray)jsonObj["Wheats"];
                            Console.WriteLine("Enter Pulse Name To Delete : ");
                            string deleteName = Console.ReadLine();
                            bool found = false;
                            foreach (var delete in jsonObj["Wheats"])
                            {
                                if (delete["Name"] + string.Empty == deleteName)
                                {
                                    var itemToDelete = wheatArray.FirstOrDefault(obj => obj["Name"].Value<string>() == deleteName);
                                    wheatArray.Remove(itemToDelete);
                                    jsonObj["Wheats"] = wheatArray;
                                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                                    File.WriteAllText(filePath, output);
                                    Console.WriteLine("Inventory Deleted Successfully");
                                    found = true;
                                    return;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine(deleteName + " Is Not Found");
                            }
                        }
                        catch (FileNotFoundException fnot)
                        {
                            Console.WriteLine(fnot.Message);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter Valid Input");
                        }

                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choice Not Found");
                        break;
                }
            }
        }

        /************************** Print the Player Cards *******************************************************************************/

        /// <summary>
        /// The random is uses to generate the random cards within the bundle of cards
        /// </summary>
       private readonly Random random = new Random();

        /// <summary>
        /// this array is use to give the cards with some symbols that are in cards game only
        /// </summary>
        private readonly string[] suite = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private int i, j;

        /// <summary>
        /// this array is use to have the all cards
        /// </summary>
     private readonly string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        /// <summary>
        /// The player Array is use to store the all values into the Two-D Array
        /// Player array have the 10 rows and  all are the 165 elements
        /// </summary>
        private readonly string[,] player = new string[9, 4];

        /// <summary>
        /// The sorting array use to sort the array
        /// </summary>
       private readonly string[,] sorting = new string[4, 9];

        /// <summary>
        /// Sorts the specified player.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <param name="n">The n.</param>
        public void Sort(int[,] player, int n)
        {
           ////string temp;
            string[,] sort = new string[9, 4];
            for (this.i = 0; this.i < 3; this.i++)
            {
                for (this.j = 0; this.j < 4; this.j++)
                {
                    int index = this.random.Next(this.rank.Length);
                    string card = Convert.ToString(index);
                   this.sorting[this.i, this.j] = this.rank[index];
                    /*if (i==2)
                    {
                        if (sorting[j].CompareTo(sorting[j + 1]) > 0)
                        {
                            temp = sorting[j];
                            sorting[j] = sorting[j + 1];
                            sorting[j + 1] = temp;
                        }*/
                    // }    
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Display the Player Cards");
            Console.WriteLine("------------------------------");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int s = this.random.Next(this.suite.Length);

                    Console.Write(this.sorting[i, j] + " " + this.suite[s] + " | ");
                    if (i == 2 && j == 0)
                    {
                        ////  player[i, j] = rank[index];
                        break;
                    }
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("------------------------------");
        }
        /******************************* Stock Report ***********************************************/
        /// <summary>
        /// Displies the report.
        /// </summary>
        public static void DisplyReport()
        {
            double totalshares = 0;

            string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\stockreport.json";
            StreamReader streamReader = new StreamReader(filePath);
           
            string read = streamReader.ReadToEnd();
            StockAccount stockdata = (StockAccount)JsonConvert.DeserializeObject(read, typeof(StockAccount));


         

            //// Console.Write("Name : " + stockdata.name + "\n");
            Console.WriteLine("****************************** Stock Report ***********************************");

            foreach (Stock stockObject in stockdata.Stock)
            {
                string name = stockObject.Name;
                int numberofshare = stockObject.Numberofshare;
                double price = stockObject.Price;

                Console.Write("Name : " + name + "\n");
                Console.Write("price : " + price + "\n");
                Console.Write("Number of Shares : " + numberofshare + "\n");
                totalshares = price * numberofshare;
                Console.WriteLine("The Total Share is : " + totalshares);
                Console.WriteLine("\n");
            }
             
        }

        /// <summary>
        /// Adds the data.
        /// </summary>
        public static void AddData()
        {
            Label:
            try
            {
                Console.WriteLine("How much stock do you want to Add : ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter  The " + i + " Name Of Stock: ");
                    string riceName = Console.ReadLine();

                    Console.WriteLine("Enter number of shares : ");
                    double riceWeight = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter  Price : ");
                    double ricePrice = Convert.ToDouble(Console.ReadLine());
                    var newRiceMember = "{'Name': '" + riceName + "' ,'Weight':" + riceWeight + ",'Price':" + ricePrice + "}";


                    //// FilePath have the path of that file where JSON file is stored
                    string filePath = "C:\\Users\\admin\\source\\repos\\OOPS\\OOPS\\stockreport.json";
                    var json = File.ReadAllText(filePath);
                    var jsonObj = JObject.Parse(json);
                    var riceArray = jsonObj.GetValue("Stock") as JArray;
                    var newRice = JObject.Parse(newRiceMember);
                    riceArray.Add(newRice);
                    jsonObj["Stock"] = riceArray;
                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(filePath, newJsonResult);
                    Console.WriteLine("Stock Added Successfully");
                }
            }
            catch (FormatException format)
            {
                Console.WriteLine(format.Message);
                goto Label;
            }
            catch (FileNotFoundException fnot)
            {
                Console.WriteLine(fnot.Message);
                goto Label;
            }
            catch (Exception e)
            {
                Console.WriteLine("Add Error : " + e.Message);
                goto Label;
            }
        }
    }
}
