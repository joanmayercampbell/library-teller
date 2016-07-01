using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO:IFileInterface 
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();

            try
            {
                          
              
                // read in all the records from the file specified in path and put it
                // into the media list 
                mediaFile =  File.ReadLines(path).ToList();                        
                               
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception e)
            {
                
                 Console.WriteLine(e);
            }

            // return the pointer to the media file
            return mediaFile;
        }

        // put all rented media into an output file
        public void UpdateMediaFile(string[] newMedia)
        {
            
            File.WriteAllLines(@"RentedMedia.txt", newMedia);
        }
    }
}
