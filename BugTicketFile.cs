using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MidTermTicketSystem
{
    public class BugTicketFile
    {
        public List<Ticket> Tickets { get; set; }
        public string filePath { get; set;}

        public BugTicketFile(string bugFile){
            filePath = bugFile;
            Tickets = new List<Ticket>();

            StreamReader sr = new StreamReader(filePath);
            while (!sr.EndOfStream){
                Ticket ticket = new Ticket();
                string line = sr.ReadLine();
                string[] ticketDetails = line.Split(',');
                ticket.id = ticketDetails[0];
                ticket.summary = ticketDetails[1];
                ticket.status = ticketDetails[2];
                ticket.submitter = ticketDetails[3];
                ticket.assigned = ticketDetails[4];
                ticket.watcher = ticketDetails[5];
                Tickets.Add(ticket);
            }
            sr.Close();
        }
    }
}