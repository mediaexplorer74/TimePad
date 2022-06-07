
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json; 
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using TimePad.Models;


namespace TimePad.Converters
{
    internal class TimePadConverter
    {
        // TimePadItem ConvertJsonToPocketItem(JToken itemObject)
        public static TimePadItem ConvertJsonToPocketItem(JToken itemObject)
        {
            string goodObject = itemObject.ToString();
            int found = goodObject.IndexOf(":");
            goodObject = goodObject.Substring(found + 2);

            //RnD
            //found = s.LastIndexOf("}");                    
            //s = s.Substring(0, s.Length - 2);
            TimePadItem TimePadItem = JsonConvert.DeserializeObject<TimePadItem>(goodObject);

            // ************************
            JToken sObject = JsonConvert.SerializeObject(goodObject);

            //JToken authorsJsonElement = itemObject.Root.SelectToken("authors", false);
            JToken authorsJsonElement = sObject.Root.SelectToken("authors");

            if (authorsJsonElement != null)
            {
                //pocketItem.Authors = ConvertJsonToAuthors
                //    (sObject.Root.SelectToken("authors"));
            }
            else
            {
                //pocketItem.Authors = new List<PocketAuthor>();
            }


            //JToken imagesJsonElement = (itemObject.Root.SelectToken("images"));
            JToken imagesJsonElement = sObject.Root.SelectToken("image");

            if (imagesJsonElement != null)
            {
                //pocketItem.Images = ConvertJsonToImages(sObject.Root.SelectToken("images"));
            }
            else
            {
                //pocketItem.Images = new List<PocketImage>();
            }

            // ************************

            TimePadItem timepadItem = new TimePadItem();
            /*
            // RnD
            //JToken itemJsonDocument = itemObject.Root.SelectToken("list", false);
            JToken itemJsonDocument = JValue.Parse(itemObject.Root.ToString());//JsonDocument.Parse(itemObject.Value.ToString());
            PocketItem pocketItem = JsonConvert.DeserializeObject<PocketItem>(itemJsonDocument.SelectToken("list").ToString());


            //JsonElement 
            JToken authorsJsonElement;

            //if (itemJsonDocument.Root.SelectToken("authors", out authorsJsonElement))...
            authorsJsonElement = itemJsonDocument.Root.SelectToken("authors", false);            
            if (authorsJsonElement != null)
            {
                pocketItem.Authors = ConvertJsonToAuthors
                    (itemJsonDocument.Root.SelectToken("authors"));
            }
            else
            {
                pocketItem.Authors = new List<PocketAuthor>();
            }

            
            JToken imagesJsonElement = (itemJsonDocument.Root.SelectToken("images"));

            if (imagesJsonElement != null)
                pocketItem.Images = ConvertJsonToImages(itemJsonDocument.Root.SelectToken("images"));
            else
                pocketItem.Images = new List<PocketImage>();

            
            */

            return timepadItem;

        }//ConvertJsonToPocketItem



        // JsonElement
        private static List<TimePadAuthor> ConvertJsonToAuthors(JToken json)
        {
            List<TimePadAuthor> authors = new List<TimePadAuthor>();

            foreach (var itemObject in json.AsJEnumerable())//.EnumerateObject())
            {
                JToken itemJsonDocument = JToken.Parse(itemObject.ToString());
                TimePadAuthor author = JsonConvert.DeserializeObject<TimePadAuthor>
                    (itemJsonDocument.Root.ToString());

                authors.Add(author);
            }

            return authors;

        }//ConvertJsonToAuthors


        // ConvertJsonToImages
        private static List<TimePadImage> ConvertJsonToImages(JToken json)
        {
            List<TimePadImage> images = new List<TimePadImage>();

            foreach (var itemObject in json.AsJEnumerable())//.EnumerateObject())
            {
                var itemJsonDocument = JToken.Parse(itemObject.ToString());

                TimePadImage image = JsonConvert.DeserializeObject<TimePadImage>(itemJsonDocument.Root.ToString());
                images.Add(image);
            }

            return images;

        }//ConvertJsonToImages
    }
}
