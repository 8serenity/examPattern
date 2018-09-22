using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace exam
{
    public class OperationManager
    {
        public List<Command> Commands { get; set; }

        public double CurrentTime { get; set; }

        public void RunOperations()
        {
            foreach (var command in Commands)
            {
                command.Operation.Start();
            }

        }

        public void Initialize()
        {
            TimerCallback tm = new TimerCallback(Execute);

            Timer timer = new Timer(tm, null, 0, 5000);
        }


        public async void Execute(object obj)
        {
            await Task.Run(() => RunOperations());
            ClearOperations();
        }

        public void ClearOperations()
        {
            Commands.Clear();
        }

        public void AddOperation(Command command)
        {
            Commands.Add(command);
        }
    }
}
