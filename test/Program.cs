﻿using System;
using System.Collections.Specialized;
using System.Net;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var wb = new WebClient();
            var data = new NameValueCollection();
            string url = "WebhookUrlHere.com";

            Console.WriteLine("Please Enter Your Name");
            data["username"] = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Write What You Want To Say Here");
                data["content"] = Console.ReadLine();

                var response = wb.UploadValues(url, "POST", data);
            }

        }
    }
}
