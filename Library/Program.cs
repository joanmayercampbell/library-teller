using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //set the rental dates for each type via a static field
                //implement

            //create a list a propulate it with the date in our file
            FileIO getFile = new FileIO();

            //populate mediaToRent with the values returned from getFile instead of an empty list e.g. "new List<string>();"
            //implement
     
            List<string> mediaToRent =  getFile.ReturnMediaFile(@"..\..\Media.txt");       
            
            //create a new list for us to use to store our media objects to rent
            List<Media> rentedMedia = new List<Media>();

            //for each line from the rental 
            foreach(string s in mediaToRent)
            {
                //match each needed component
                //populae with your regex to match the format

                Match match = Regex.Match(s, @"Type\:\s*(.*),Title\:\s*(.*),Length\:\s*(.*)");
                if (match.Success)
                {
                    //populate each component with the values from your capture groups
                    string type = match.Groups[1].ToString();
                    string title = match.Groups[2].ToString();
                    string length = match.Groups[3].ToString();

                    //using the components we got figure out which type of object we should create and insert
                    if (type.Equals("Book"))
                    {
                        //create a book object
                        Book newBook = new Book();
                        //populate the book object with a title and length
                        newBook.Title = title;
                        newBook.Length = length;
                        rentedMedia.Add(newBook); 
                    }

                    if (type.Equals("DVD"))
                    {
                        DVD newDVD = new DVD();

                        newDVD.Title = title;
                        newDVD.Length = length;
                        rentedMedia.Add(newDVD);
                    }

                    if (type.Equals("Magazine"))
                    {
                        Magazine newMagazine = new Magazine();

                        newMagazine.Title = title;
                        newMagazine.Length = length;
                        rentedMedia.Add(newMagazine);
                    }

                                      
                }
            }

            //for each media item we have in the list print the details for each
            foreach (Media mediaItem in rentedMedia)
            {
                mediaItem.PrintMediaDetails();
            }

            // output the rented list to a file
            // get number of newMedia items
            int numberOfItems = rentedMedia.Count;

            // initialize the array according to the number of items
            String[] allRecords = new string[numberOfItems];

            // for each item in the newMedia object put the information 
            // in the array
            int i = 0;
            foreach (Media eachMedia in rentedMedia)
            {
                allRecords[i] = rentedMedia.ToString();
                i++;

            }
            getFile.UpdateMediaFile(allRecords);

            //halt the program so we can read the output
            Console.ReadKey();
        }
    }
}
