// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace StockMarket
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;

    /// <summary>
    /// Utility class have the all logical parts
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Buys the shares.
        /// this method have the details about the  which company have how much Available shares 
        /// </summary>
        public void BuyShares()
        {
            Label:
            try
            {
                
                //// Here Deserialize the JSON file means here get the all details into the data object
                StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));

                //// Changing the console color to look good
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("  *****  Capgemini Company Details About The Shares  ***** \n");

                //// This foreach loop for showing the details about the capgemini shares and price of shares
                //// here StockDataManagment.CapgeminiRecord have a class  CapgeminiRecord
                ////  and get the value from json file and print that data
                foreach (StockDataManagment.CapgeminiRecord i in data.Capgemini)
                {
                    Console.WriteLine("   Available Shares : " + i.Available_Shares + "  Share Price " + i.Share_Price + "\n");
                }

                //// Changing the console color to look good
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n  *****  TATA Company Details About The Shares  ***** \n");

                //// This foreach loop for showing the details about the TATA shares and price of shares
                //// here StockDataManagment.TATARecord have a class  TATARecord
                ////  and get the value from json file and print that data
                foreach (StockDataManagment.TATARecord i in data.TATA)
                {
                    Console.WriteLine("   Available Shares : " + i.Available_Shares + "  Share Price " + i.Share_Price);
                }

                //// Changing the console color to look good
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n Enter 1 For Capgemini And 2 For  TATA ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Utility.Capgemini();
                        break;
                    case 2:
                        Utility.TATA();
                        break;
                    default:
                        Console.WriteLine("Wrong input please enter valid input");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto Label;
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
         
        
        /// <summary>
        /// Capgemini method have the all details about the capgemini shares market
        /// how much shares are available in capgemini and what is price of 1 share
        /// </summary>
        public static void Capgemini()
        {
            //// https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            //// this is used from this site
            DateTime now = DateTime.Now;

            //// date the todays date to store into Holders.json as well as Transaction.json 
            string date = now.ToString("MM/dd/yyyy");
            ////Type namenameType = date.GetType();
            ////Console.WriteLine(namenameType);
            ///// store the value into the Holders.json file since your are buy this share
            string since = now.ToString("yyyy");

            string campany = "Capgemini_Holders";
            string companyname = "Capgemini";
            Console.ForegroundColor = ConsoleColor.Green;
            Label:
            try
            {
                Console.WriteLine(" Enter the Amount To Your  Account ");
                int amount = Convert.ToInt32(Console.ReadLine());

                //// Here we are checking the value should be > 0
                try
                {
                    if (amount > 0)
                    {

                        Console.WriteLine("Enter Your Name ");
                        string name = Console.ReadLine();
                        ////Deserilize the JSON file to take the value from the json file
                        StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));
                        int share_price = 0;
                        int shares = 0;
                        int total = 0;
                        int myshares = 0;
                        int number_of_holders = 0;
                        foreach (StockDataManagment.CapgeminiRecord i in data.Capgemini)
                        {
                            share_price = i.Share_Price;
                            ////Console.WriteLine(" Share Rate : "+share_price);
                            shares = i.Available_Shares;
                            number_of_holders = i.Number_Of_Shares_Holder;
                        }
                        //// Changing the console color to look good
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine(" Share Price is  " + share_price);
                        Console.WriteLine(" Available Share is  " + shares);
                        Console.WriteLine(" How much share do you want to Buy ");
                        myshares = Convert.ToInt32(Console.ReadLine());
                        total = myshares * share_price;

                        //// Here we are checking the Amount Should be less Than Total amount
                        if (total <= amount)
                        {
                            //// Reduce the Total amount of capgemini
                            amount = amount - total;

                            // here we are updating the number_of_holders in Company.json file
                            // And add the one more holder in this file
                            // Reduce the share
                            // Increase the total share price
                            Holders(name, amount, myshares, campany, date, since);
                            Utility utility = new Utility();
                            ////  CompanyDetails(name, myshares, companyname);
                            //// name is the name of person who buy the share 
                            //// company name which company give him shares when that store in date
                            //// How much amount he has and after buying how much amount(total) is left that is in amount
                            Transaction(name, companyname, date, total, amount, myshares);
                          ////  utility.SellShares(name,amount,myshares);
                        }
                        else
                        {
                            Console.WriteLine("Your Account Amount is Less to Buy " + myshares);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Amount");
                    }
                }
                catch (FormatException e3)
                {
                    Console.WriteLine(e3.Message);
                }
            }
            
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto Label;
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                goto Label;
            }
        }

        /// <summary>
        /// Here have the all details about the TATA Company
        /// How many share available or how much price of per share that all are info inside this function
        /// </summary>
        public static void TATA()
        {
            //// https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
            //// this is used from this site
            DateTime now = DateTime.Now;

            //// date the todays date to store into Holders.json as well as Transaction.json 
            string date = now.ToString("MM/dd/yyyy");
            ////Type namenameType = date.GetType();
            ////Console.WriteLine(namenameType);
            ///// store the value into the Holders.json file since your are buy this share
            string since = now.ToString("yyyy");

            string campany = "TATA_Holders";
            string companyname = "TATA";

            //// Changing the console color to look good
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Enter the Amount To Your  Account ");
            int amount = Convert.ToInt32(Console.ReadLine());

            ////Amount should be greater than zero
            if (amount > 0)
            {
                Console.WriteLine("Enter Your Name ");
                string name = Console.ReadLine();
                StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));
                int share_price = 0;
                int shares = 0;
                int total = 0;
                int myshares = 0;
                int number_of_holders = 0;
                foreach (StockDataManagment.TATARecord i in data.TATA)
                {
                    share_price = i.Share_Price;
                    ////Console.WriteLine(" Share Rate : "+share_price);
                    shares = i.Available_Shares;
                    number_of_holders = i.Number_Of_Shares_Holder;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" Share Price is  " + share_price);
                Console.WriteLine(" Available Share is  " + shares);
                Console.WriteLine(" How much share do you want to Buy ");
                myshares = Convert.ToInt32(Console.ReadLine());
                total = myshares * share_price;

                ////Total amount should be less than equal amount
                if (total <= amount)
                {
                    amount = amount - total;
                    //// here we are updating the number_of_holders in Company.json file
                    //// And add the one more holder in this file
                    //// Reduce the share
                    //// Increase the total share price
                    Holders(name, amount, myshares, campany, date, since);
                    ////  CompanyDetails(name, myshares, companyname);
                    Transaction(name, companyname, date, total, amount, myshares);
                    
                }
                else
                {
                    Console.WriteLine("Your Account Amount is Less to Buy " + myshares);
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Amount");
            }
        }

        /// <summary>
        /// Holders Method have details about the Sgare Holder Means who buying the Share From which Company and how much 
        /// price of each share that all info inside this method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="amount"></param>
        /// <param name="myshare"></param>
        /// <param name="company"></param>
        /// <param name="date"></param>
        /// <param name="since"></param>
        public static void Holders(string name, int amount, int myshare, string company, string date, string since)
        {
            try
            {
                // var newRiceMember = "{'Name': '" + riceName + "' ,'Weight':" + riceWeight + ",'Price':" + ricePrice + "}";
                var newMember = "{'Name': '" + name + "','Shares':'" + myshare + "','Money':'" + amount + "','Since':'" + since + "','Date':'" + date + "','Company':'" + company + "'}";
                //// FilePath have the path of that file where JSON file is stored

                //// Get the all indo from the file and also we are use the insert data into the JSOn file also
                string filePath = @"C:\Users\admin\source\repos\OOPS\StockMarket\Holders.json";
                var json = File.ReadAllText(filePath);
                var jsonObj = JObject.Parse(json);

                var holderArray = jsonObj.GetValue(company) as JArray;

                var newCompany = JObject.Parse(newMember);

                holderArray.Add(newCompany);

                jsonObj[company] = holderArray;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, newJsonResult);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Holder Added Successfully");
            }catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        /// Transactio file  have the all details about the Transaction 
        /// who buy the share and from but the share from which company that all 
        /// info have the inside this method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="companyname"></param>
        /// <param name="date"></param>
        /// <param name="total"></param>
        /// <param name="ramount"></param>
        /// <param name="share"></param>
        public static void Transaction(string name, string companyname, string date, int total, int ramount, int share)
        {
            try
            {
                var newMember = "{'Name': '" + name + "','Company':'" + companyname + "','Date':'" + date + "','Shares':'" + share + "','Deducated_Amount':'" + total + "','Total_Amount':'" + ramount + "'}";

                ////FilePath have the pathof the JSON file to read  write data into the json file
                string filePath = @"C:\Users\admin\source\repos\OOPS\StockMarket\Transaction.json";
                var json = File.ReadAllText(filePath);
                var jsonObj = JObject.Parse(json);

                var holderArray = jsonObj.GetValue("Transaction") as JArray;

                var newCompany = JObject.Parse(newMember);

                holderArray.Add(newCompany);

                jsonObj["Transaction"] = holderArray;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, newJsonResult);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Transaction Added Successfully");

                StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Transaction.json"));

                //// Changing the console color to look good
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\n \t******************************** Transaction Details ********************************\n\n");

                //// Changing the console color to look goodss
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(" \t Name\t Company\t Date\t\t Shares\t Deducated_Amount\t Total_Amount\n");
                foreach (StockDataManagment.TransactionRecord i in data.Transaction)
                {
                    //// Changing the console color to look good
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" \t " + i.Name + "\t " + i.Company + "\t " + i.Date + "\t " + i.Shares + "\t " + i.Deducated_Amount + "\t\t\t" + i.Total_Amount);
                    Console.WriteLine();
                }

                Console.WriteLine("\n");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// CompanyDetails have the details about the company and how much share have the company and
        /// here we are deducting the share from the each company also the Update total amount
        /// </summary>
        /// <param name="name"></param>
        /// <param name="myshare"></param>
        /// <param name="company"></param>
        public static void CompanyDetails(string name, int myshare, string company)
        {

            StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Company.json"));
            int share_price = 0;
            int shares = 0;
            int total = 0;
            int mytotal = 0;
            int myshares = 0;
            int number_of_holders = 0;
            foreach (StockDataManagment.CapgeminiRecord i in data.Capgemini)
            {
                share_price = i.Share_Price;
                mytotal = myshares * share_price;
                //// Console.WriteLine(" Share Rate : "+share_price);
                shares = i.Available_Shares;
                shares = shares - myshares;
               //// Console.WriteLine(" Share Rate : " + shares);
                number_of_holders = i.Number_Of_Shares_Holder;
                number_of_holders = number_of_holders + 1;
                //// Console.WriteLine(" Share Holders : " + number_of_holders);

                total = i.Total_Shares_Price;

                total = total - mytotal;
            }
        }

        /************************* Sell Shares *************************************/
        /// <summary>
        /// 
        /// </summary>
        public  void SellShares()
        {
            StockDataManagment data = JsonConvert.DeserializeObject<StockDataManagment>(File.ReadAllText(@"C:\Users\admin\source\repos\OOPS\StockMarket\Holders.json"));

           //// string name;
            string amount="";
            string myshares="";
            foreach (StockDataManagment.Capgemini_Holders i in data.CapgeminiHolder)
            {
                amount = i.Money;
                ////Console.WriteLine(" Share Rate : "+share_price);
                myshares = i.Shares;
               
            }
            StockDataManagment.Capgemini_Holders stockData = new StockDataManagment.Capgemini_Holders();

            stockData.Shares = myshares;
            
            stockData.Money = amount;
            data.CapgeminiHolder.Add(stockData);
            string filePath = @"C:\Users\admin\source\repos\OOPS\StockMarket\Holders.json";
            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, newJsonResult);
        }

    }
}