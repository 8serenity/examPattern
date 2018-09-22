using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        public static OperationManager Manager { get; set; }

        static void Main(string[] args)
        {
            int input;

            Manager = new OperationManager();

            Manager.Commands = new List<Command>();

            Manager.Initialize();


            do
            {
                Console.WriteLine("Choose action: 1: Add 2: Update 3: Delete \n0 to exit");
                var userInput = Console.ReadLine();

                input = int.Parse(userInput);

                AddOperation(input);

                Console.Clear();
            } while (input != 0);
        }

        private static void AddOperation(int input)
        {
            switch (input)
            {
                case 1:
                    Manager.AddOperation(new Command { Operation = new Task(AddUser) });
                    break;
                case 2:
                    Manager.AddOperation(new Command { Operation = new Task(UpdateUser) });
                    break;
                case 3:
                    Manager.AddOperation(new Command { Operation = new Task(DeleteUser) });
                    break;
            }
        }

        private static void DeleteUser()
        {

                Console.WriteLine("Deleting user");
        }

        private static void UpdateUser()
        {
                Console.WriteLine("Updating user");
        }

        private static void AddUser()
        {
                Console.WriteLine("Adding user");
        }
    }
}
