//-----------------------------------------------------------------------
// <copyright file="AddressBookOperations.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creater name="Ajay Lodale"/>
//-----------------------------------------------------------------------
namespace StockMarket
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json; 

    /// <summary>
    /// Address Book Operations class
    /// </summary>
    public class AddressBookOperations
    {
        /// <summary>
        /// Read from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>read from file</returns>
        public static string ReadFromFile(string path)
        {
            //// read the path from file
            using (StreamReader streamReader = new StreamReader(path))
            {
                //// rread file at end
                string jsonString = streamReader.ReadToEnd();
                streamReader.Close();
                return jsonString;
            }
        }

        /// <summary>
        /// Get the detail of address book.
        /// </summary>
        public static void GetDetailOfAddressBook()
        {
            ConstantClass constantClass = new ConstantClass();
            ////read file upto end
            string readFile = ReadFromFile(constantClass.addressBook);
            ////take list of model class & convert json string to c sharp object
            IList<AddressBookModel> addressBookList = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
            ////take details of user one by one
            foreach (AddressBookModel addressObj in addressBookList)
            {
                ////Printing the details 
                Console.WriteLine("***********************************************************");
                Console.WriteLine("Name: " + addressObj.firstName + " " + addressObj.lastName);
                Console.WriteLine("Addresss: " + addressObj.city + ", " + addressObj.state + " " + addressObj.zip);
                Console.WriteLine("Phone Number: " + addressObj.phoneNum);
            }
        }
        /// <summary>
        /// Adds the person.
        /// </summary>
        public static void AddPerson()
        {
            ////take variables for get details of user
            string firstName, lastName, city, state, zip, phoneNum;
            ////validation for name
            Regex validation = new Regex("^[a-zA-Z]*$");
            ////take name of user
            Console.WriteLine("Enter the first name");
            firstName = Console.ReadLine();
            ////this loop validate the name of user
            //while (validation.IsMatch(firstName) == false)
            //{
            //    Console.WriteLine("Invalid first name! Please enter characters only");
            //    ////retake name from  user
            //    Console.WriteLine("Reenter the first name");
            //    firstName = Console.ReadLine();
            //}

            Console.WriteLine("Enter the last name");
            lastName = Console.ReadLine();
            ////this loop validate the name of user
            while (validation.IsMatch(lastName) == false)
            {
                Console.WriteLine("Invalid last name! Please enter the characters only");
                ////retake name from  user
                Console.WriteLine("Reenter the last name");
                lastName = Console.ReadLine();
            }

            ////take name of city
            Console.WriteLine("Enter the city");
            city = Console.ReadLine();
            ////take name of state
            Console.WriteLine("Enetr the state");
            state = Console.ReadLine();
            ////this loop validate the name of user
            while (validation.IsMatch(state) == false)
            {
                Console.WriteLine("Invalid state! Please enter the characters only");
                ////retake  name of state
                Console.WriteLine("Reenter the state");
                state = Console.ReadLine();
            }

            ////take zipcode
            Console.WriteLine("Enter the zip code");
            zip = Console.ReadLine();
            ////check the zip code of the user is in digit or length is 6
            if (Regex.IsMatch(zip, @"[0-9]{6}"))
            {
                zip = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect format! Please enter only digits & length should be 6");
                ////re take zip code 
                Console.WriteLine("Reenter zip");
                zip = Console.ReadLine();
            }

            Console.WriteLine("Enter the phone number");
            phoneNum = Console.ReadLine();
            ////check the zip code of the user is in digit or length is 10
            if (Regex.IsMatch(phoneNum, @"[0-9]{10}"))
            {
                phoneNum = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect format! Please enter only digits & length should be 10");
                ////re take phone number
                Console.WriteLine("Reenter phone number");
                phoneNum = Console.ReadLine();
            }

            ////store into list of stock object 
            IList<AddressBookModel> addressBookModel = new List<AddressBookModel>();
            ////create model class object & take values 
            AddressBookModel addressBookModel1 = new AddressBookModel()
            {
                firstName = firstName,
                lastName = lastName,
                city = city,
                state = state,
                zip = zip,
                phoneNum = phoneNum
            };
            ConstantClass constantClass = new ConstantClass();
            ////read file 
            string read = ReadFromFile(constantClass.addressBook);
            ////store into list of stock object  & convert json to object
            addressBookModel = JsonConvert.DeserializeObject<List<AddressBookModel>>(read);
            addressBookModel.Add(addressBookModel1);
            ////convert object to json string
            string jsonConverter = JsonConvert.SerializeObject(addressBookModel);
            ////write all text into json file
            File.WriteAllText(constantClass.addressBook, jsonConverter);
            Console.WriteLine("Added Successfully.............");
        }

        /// <summary>
        /// Update the person.
        /// </summary>
        public static void UpdatePerson()
        {
            try
            {
                ConstantClass constant = new ConstantClass();
                bool flag = true;
                ////this loop continues call upto flag is true
                while (flag)
                {
                    ////user have choices for updating details
                    Console.WriteLine("***********************************************************");
                    Console.WriteLine("What Do you want to update");
                    Console.WriteLine(" 1: Phone Number\n 2: Address\n 3: Exit");
                    ////take choice of user
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ////path of json file
                            string filePath = constant.addressBook;
                            ////read file upto end
                            string readFile = ReadFromFile(filePath);
                            ////take name from user 
                            Console.WriteLine("Enter your name");
                            string name = Console.ReadLine();

                            List<AddressBookModel> userList = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
                            ////this loop is use for to check where should update.
                            foreach (AddressBookModel objStock in userList)
                            {
                                string newUserUpdate = objStock.firstName;
                                ////it check user is match or not.
                                if (name.Equals(newUserUpdate))
                                {
                                    ////if match user name then take new phone number & update it
                                    Console.WriteLine("Enter new Phone Number");
                                    string newPhoneNum = Console.ReadLine();
                                    if (Regex.IsMatch(newPhoneNum, @"[0-9]{10}"))
                                    {
                                        newPhoneNum = Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Incorrect format! Please enter only digits & length should be 10");
                                        Console.WriteLine("Reenter phone number");
                                        newPhoneNum = Console.ReadLine();
                                    }
                                    ////it removes first value &
                                    userList.Remove(objStock);
                                    ////it add new value
                                    userList.Add(new AddressBookModel
                                    {
                                        firstName = objStock.firstName,
                                        lastName = objStock.lastName,
                                        city = objStock.city,
                                        state = objStock.state,
                                        zip = objStock.zip,
                                        phoneNum = newPhoneNum
                                    });
                                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                                    ////write or update the user account details.
                                    StreamWriter streamWriter = new StreamWriter(filePath);
                                    streamWriter.WriteLine(updateUserData);
                                    streamWriter.Close();
                                    Console.WriteLine("Phone Number Updated Successfully");
                                    break;
                                }
                            }

                            break;
                        case 2:
                            bool flag1 = true;
                            while (flag1)
                            {
                                Console.WriteLine("****************************************************");
                                Console.WriteLine("What you want to update");
                                Console.WriteLine(" 1: City\n 2: State\n 2: Exit");
                                Console.WriteLine("Enter your choice");
                                int ch = Convert.ToInt32(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        filePath = constant.addressBook;
                                        readFile = ReadFromFile(filePath);
                                        ////Console.WriteLine(readFile);
                                        Console.WriteLine("Enter your name");
                                        string name1 = Console.ReadLine();

                                        List<AddressBookModel> userList1 = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
                                        ////this loop is use for to check where should update.
                                        foreach (AddressBookModel objStock in userList1)
                                        {
                                            string newUserUpdate = objStock.firstName;
                                            ////it check user is match or not.
                                            if (name1.Equals(newUserUpdate))
                                            {
                                                ////if match user name then take new phone number & update it
                                                Console.WriteLine("Enter new City");
                                                string newCity = Console.ReadLine();
                                                ////it removes first value &
                                                userList1.Remove(objStock);
                                                ////it add new value
                                                userList1.Add(new AddressBookModel
                                                {
                                                    firstName = objStock.firstName,
                                                    lastName = objStock.lastName,
                                                    city = newCity,
                                                    state = objStock.state,
                                                    zip = objStock.zip,
                                                    phoneNum = objStock.phoneNum
                                                });
                                                string updateUserData = JsonConvert.SerializeObject(userList1, Formatting.Indented);
                                                ////write or update the user account details.
                                                StreamWriter streamWriter = new StreamWriter(filePath);
                                                streamWriter.WriteLine(updateUserData);
                                                streamWriter.Close();
                                                Console.WriteLine("City Updated Successfully");
                                                break;
                                            }
                                        }

                                        break;
                                    case 2:
                                        filePath = constant.addressBook;
                                        readFile = ReadFromFile(filePath);
                                        ////Console.WriteLine(readFile);
                                        Console.WriteLine("Enter your name");
                                        string name2 = Console.ReadLine();

                                        List<AddressBookModel> userList2 = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
                                        ////this loop is use for to check where should update.
                                        foreach (AddressBookModel objStock in userList2)
                                        {
                                            string newUserUpdate = objStock.firstName;
                                            ////it check user is match or not.
                                            if (name2.Equals(newUserUpdate))
                                            {
                                                ////if match user name then take new phone number & update it
                                                Console.WriteLine("Enter new State");
                                                string newState = Console.ReadLine();
                                                ////it removes first value &
                                                userList2.Remove(objStock);
                                                ////it add new value
                                                userList2.Add(new AddressBookModel
                                                {
                                                    firstName = objStock.firstName,
                                                    lastName = objStock.lastName,
                                                    city = objStock.city,
                                                    state = newState,
                                                    zip = objStock.zip,
                                                    phoneNum = objStock.phoneNum
                                                });
                                                string updateUserData = JsonConvert.SerializeObject(userList2, Formatting.Indented);
                                                ////write or update the user account details.
                                                StreamWriter streamWriter = new StreamWriter(filePath);
                                                streamWriter.WriteLine(updateUserData);
                                                streamWriter.Close();
                                                Console.WriteLine("State Updated Successfully");
                                                break;
                                            }
                                        }

                                        break;
                                    case 3:
                                        flag1 = false;
                                        break;
                                }
                            } 

                            break;
                            case 3:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Updation" + e.Message);
            }
        }

        /// <summary>
        /// Delete the person.
        /// </summary>
        public static void DeletePerson()
        {
            ConstantClass constant = new ConstantClass();
            string filePath = constant.addressBook;
            string readFile = ReadFromFile(filePath);
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            List<AddressBookModel> userList = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
            ////this loop is use for to check where should update.
            foreach (AddressBookModel objStock in userList)
            {
                string newUserUpdate = objStock.firstName;
                ////it check user is match or not.
                if (name.Equals(newUserUpdate))
                {
                    userList.Remove(objStock);
                    string updateUserData = JsonConvert.SerializeObject(userList, Formatting.Indented);
                    ////write or update the user account details.
                    StreamWriter streamWriter = new StreamWriter(filePath);
                    streamWriter.WriteLine(updateUserData);
                    streamWriter.Close();
                    break;
                }
            }

            Console.WriteLine("User Detailes Deleted SuccessFully.............");
        }

        /// <summary>
        /// Sort the last name of the by.
        /// </summary>
        public static void SortByLastName()
        {
            ConstantClass constant = new ConstantClass();
            string filePath = constant.addressBook;
            string readFile = ReadFromFile(filePath);
            List<AddressBookModel> userList = JsonConvert.DeserializeObject<List<AddressBookModel>>(readFile);
            string[] arrayNames = new string[userList.Capacity];
            int i = 0;
             foreach (AddressBookModel modelNames in userList)
             {
                arrayNames[i] = modelNames.lastName;
                i++;
            }

            Array.Sort(arrayNames);
            Console.Write("Sorted Entries in the Address Book by Last Names");
            foreach (string names in arrayNames)
             {
                Console.WriteLine(names);
             }
        }
    }
}