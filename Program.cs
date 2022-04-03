using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MidTermTicketSystem
{
    class Program
    {


        static void Main(string[] args)
        {
            string bugFile = Directory.GetCurrentDirectory() + "\\tickets.csv";
            string enhancementFile = Directory.GetCurrentDirectory() + "\\Enhancements.csv";
            string taskFile = Directory.GetCurrentDirectory() + "\\Task.csv";

            string choice = "";
            string choice2 ="";
            do{
                Console.WriteLine("1. Create a ticket");
                Console.WriteLine("2. Display all tickets");
                Console.WriteLine("3. Search for ticket");
                Console.WriteLine("Anything else to quit");
                choice = Console.ReadLine();
                Console.WriteLine("");


                if (choice == "1"){
                    Console.WriteLine("1. Bug/Defect");
                    Console.WriteLine("2. Enhancement");
                    Console.WriteLine("3. Task");
                    choice2 = Console.ReadLine();
                    Console.WriteLine("");

                    if (choice2 == "1"){
                        Console.WriteLine("What is the tickets ID?");
                        string ID = Console.ReadLine();
                        Console.WriteLine("A short ticket summary please.");
                        string summary = Console.ReadLine();
                        Console.WriteLine("What is the tickets status?");
                        string status = Console.ReadLine();
                        Console.WriteLine("What is the priority level of the ticket?");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        string submitter = Console.ReadLine();
                        Console.WriteLine("Who was assigned the ticket?");
                        string assigned = Console.ReadLine();
                        Console.WriteLine("Who is watching the ticket?");
                        string watcher = Console.ReadLine();
                        Console.WriteLine("What is the severity?");
                        string severity = Console.ReadLine();
                        string tempTicket = ID+", "+ summary+", "+status+", "+priority+", "+submitter+", "+assigned+", "+watcher+", "+severity;
                        Ticket Bug = new BugTicket {
                            id = ID,
                            summary = summary,
                            status =  status,
                            priority = priority,
                            submitter = submitter,
                            assigned = assigned,
                            watcher = watcher,
                            severity = severity,

                        };
                        using (StreamWriter sw = File.AppendText(bugFile)){
                            sw.WriteLine();
                            sw.WriteLine(tempTicket);
                        }
                    }

                    else if (choice2 == "2"){
                        Console.WriteLine("What is the tickets ID?");
                        string ID = Console.ReadLine();
                        Console.WriteLine("A short ticket summary please.");
                        string summary = Console.ReadLine();
                        Console.WriteLine("What is the tickets status?");
                        string status = Console.ReadLine();
                        Console.WriteLine("What is the priority level of the ticket?");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        string submitter = Console.ReadLine();
                        Console.WriteLine("Who was assigned the ticket?");
                        string assigned = Console.ReadLine();
                        Console.WriteLine("Who is watching the ticket?");
                        string watcher = Console.ReadLine();
                        Console.WriteLine("What is the software?");
                        string software = Console.ReadLine();
                        Console.WriteLine("What is the cost?");
                        string cost = Console.ReadLine();
                        Console.WriteLine("What is the reason?");
                        string reason = Console.ReadLine();
                        Console.WriteLine("What is the estimate?");
                        string estimate = Console.ReadLine();
                        string tempTicket = ID+", "+ summary+", "+status+", "+priority+", "+submitter+", "+assigned+", "+watcher+", "+software+", "+cost+", "+reason+", "+estimate;
                        Ticket Enhancement = new Enhancements {
                            id = ID,
                            summary = summary,
                            status =  status,
                            priority = priority,
                            submitter = submitter,
                            assigned = assigned,
                            watcher = watcher,
                            software = software,
                            cost =  cost,
                            reason = reason,
                            estimate = estimate,
                        };
                        using (StreamWriter sw = File.AppendText(enhancementFile)){
                            sw.WriteLine();
                            sw.WriteLine(tempTicket);
                        }
                    }
                    else if (choice2 == "3"){
                        Console.WriteLine("What is the tickets ID?");
                        string ID = Console.ReadLine();
                        Console.WriteLine("A short ticket summary please.");
                        string summary = Console.ReadLine();
                        Console.WriteLine("What is the tickets status?");
                        string status = Console.ReadLine();
                        Console.WriteLine("What is the priority level of the ticket?");
                        string priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        string submitter = Console.ReadLine();
                        Console.WriteLine("Who was assigned the ticket?");
                        string assigned = Console.ReadLine();
                        Console.WriteLine("Who is watching the ticket?");
                        string watcher = Console.ReadLine();
                        Console.WriteLine("What is the project name?");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is the due date?");
                        string dueDate = Console.ReadLine();
                        string tempTicket = ID+", "+ summary+", "+status+", "+priority+", "+submitter+", "+assigned+", "+watcher+", "+name+", "+dueDate;
                        Ticket task = new Task {
                            id = ID,
                            summary = summary,
                            status =  status,
                            priority = priority,
                            submitter = submitter,
                            assigned = assigned,
                            watcher = watcher,
                            name = name,
                            dueDate = dueDate,
                        };
                        using (StreamWriter sw = File.AppendText(taskFile)){
                            sw.WriteLine();
                            sw.WriteLine(tempTicket);
                        }
                    }
                    
                }else if (choice == "2"){
                    //display all tickets
                    string ticket = File.ReadAllText("Tickets.csv");
                    string enhance = File.ReadAllText("Enhancements.csv");
                    string task = File.ReadAllText("Task.csv");
                    Console.WriteLine("Bugs:");
                    Console.WriteLine(ticket);
                    Console.WriteLine("Enhancements:");
                    Console.WriteLine(enhance);
                    Console.WriteLine("Tasks:");
                    Console.WriteLine(task);
                }else if(choice == "3"){
                    //Find a ticket
                    string choice3 ="";
                    do{
                        Console.WriteLine("Select what to search by");
                        Console.WriteLine("1. Status");
                        Console.WriteLine("2. Priority");
                        Console.WriteLine("3. Submitter");
                        choice2 = Console.ReadLine();
                        if (choice2 == "1"){
                            Console.Write("Search Status: ");
                            string find = Console.ReadLine();
                            Console.WriteLine("");
                            
                        }else if(choice2 == "2"){
                            Console.Write("Search Priority: ");
                            string find = Console.ReadLine();
                            Console.WriteLine("");

                        }else if (choice2 == "3"){
                            Console.Write("Search Submitter: ");
                            string find = Console.ReadLine();
                            Console.WriteLine("");

                        }
                    }while(choice3 =="1" || choice3 == "2" || choice3 == "3");
                }

            } while (choice =="1" || choice == "2" || choice == "3");

        }
    }
}
