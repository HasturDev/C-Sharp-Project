using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using RestSharp;

namespace WindowsFormFirstAttempt
{
    
    static class Program
    {

       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           

            var client = new RestClient("https://opentdb.com/api.php?amount=1&type=boolean");
            var request = new RestRequest(Method.GET);
            var reponse = client.Execute<IResults>(request);

        }  

        public class IResults
        {
            public int response_code { get; set; }
            public List<Result> results { get; set; }
        }

        public class Result
        {
            public string type { get; set; }
            public string difficulty { get; set; }
            public string question { get; set; }
            public string correct_answer { get; set; }
            public List<string> incorrect_answer { get; set; }
        }
    }
}
