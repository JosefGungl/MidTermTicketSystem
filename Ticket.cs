using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MidTermTicketSystem
{
    public class Ticket
    {
        public string id { get; set; }
        public string summary { get; set; }
        public string status { get; set; }
        public string priority { get; set; }
        public string submitter { get; set; }
        public string assigned { get; set; }
        public string watcher { get; set; } 
    }
    public class BugTicket:Ticket{
        public string severity{ get; set; }
    }
    public class Enhancements:Ticket{
        public string software{ get; set;}
        public string cost{ get; set;}
        public string reason{ get; set;}
        public string estimate{ get; set;}
    }
    public class Task:Ticket{
        public string name{ get; set;}
        public string dueDate{ get; set;}
    }
    

}