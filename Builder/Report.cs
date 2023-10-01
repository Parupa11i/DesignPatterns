using System;
namespace Builder
{
    public class Report
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public void ShowReport()
        {
            Console.WriteLine("Header is: " + Header);
            Console.WriteLine("Body is: " + Body);
            Console.WriteLine("Footer is: " + Footer);
        }
    }
}
