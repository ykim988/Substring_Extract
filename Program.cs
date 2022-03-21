using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Substring_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantitate a list
            List<string> searchitem = new List<string>();

            //Read logfile
            string[] lines = System.IO.File.ReadAllLines(@"C:\Test\LO729_2022-02-24_101104.log");

            //Store search key into a variable
            string searchkey = "Maximum recorded tip load values: Position error ";

            //loop through the logfile string array (lines) and check for search key. If exist, add to the list (searchitem)
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(searchkey))//checking whether the searchkey contains in the string array
                {
                    int found = lines[i].IndexOf("error ");

                    string extractedValue = lines[i].Substring(found + 6, 6);

                    searchitem.Add(extractedValue);//adding the matching item to the list 
                }

                //I don't know what this does. figure it out!
                //string searchresult = string.Join(Environment.NewLine, searchitem);

            }



        }
    }
}
