using System;
using System.Threading;

class Program{

    static public void Main(String[] args){
        List list = new List();
        Console.WriteLine("Welcome to Woopi's to do list!");
        Console.WriteLine("\n");
        Thread.Sleep(1000);
        int cycle = 0;

        string input;
        do{
            if(cycle > 0){
            Console.WriteLine("Type view to view list.");
            Console.WriteLine("Type add to create a new activity.");
            Console.WriteLine("Type edit to edit an activity.");
            Console.WriteLine("Type complete once you have completed an activity.");
            Console.WriteLine("Type quit if you want to stop the application.");
            input = Console.ReadLine();
            }else{
                System.Console.WriteLine("type add to create a new activity.");
                input = Console.ReadLine();
            }
            
            switch(input.ToUpper()){
                case "VIEW":
                System.Console.WriteLine("Your list is");
                list.getList();
                Console.WriteLine("\n");
                break;

                case "ADD":
                    Console.WriteLine("type your activity here:");
                    string activity = Console.ReadLine();
                    list.addItem(cycle, activity);
                    Console.WriteLine("Your new list is: ");
                    list.getList();
                    Console.WriteLine("\n");
                    cycle = cycle + 1;
                    Thread.Sleep(1000);
                    break;

                case "EDIT":
                    while(true){
                    Console.WriteLine("What's the # of the item you would like to edit?");
                    list.getList();
                    int index = int.Parse(Console.ReadLine()) - 1;
                        if(index >= cycle || index < 0){
                            Console.WriteLine("Invalid choice, try again");
                            Console.WriteLine("Your # must be " + cycle + " or lower");
                            } else{
                    System.Console.WriteLine("What would you like to change it to?");
                    string newItem = Console.ReadLine();
                    list.editItem(index, newItem);
                    Console.WriteLine("Your new list is: ");
                    list.getList();
                    Console.WriteLine("\n");
                    Thread.Sleep(1000);
                    break;
                        }
                    }
                    continue;

                case "COMPLETE":
                while(true){
                    Console.WriteLine("What's the # of the task you completed?");
                    list.getList();
                    int completed = int.Parse(Console.ReadLine()) - 1;
                    if(completed >= cycle || completed < 0){
                        Console.WriteLine("Invalid choice, try again");
                        Console.WriteLine("Your # must be " + cycle + " or lower");
                    }else{
                    list.completeItem(completed);
                    Console.WriteLine("Your new list is: ");
                    list.getList();
                    Console.WriteLine("\n");
                    Thread.Sleep(1000);
                    break;
                    }
                }
                continue;

                case "QUIT":
                    System.Console.WriteLine("Are you sure you want to quit? y/n");
                    string quitInput = Console.ReadLine();
                    if(quitInput == "y"){
                        return;
                    }
                    else if(quitInput == "n"){
                        break;
                    }
                return;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    Console.WriteLine("\n");
                    break;
            }


        } while(input != "QUIT");

    }
}