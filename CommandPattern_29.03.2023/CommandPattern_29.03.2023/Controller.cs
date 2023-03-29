using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Controller
    {
        protected ICommand command;
        public Controller(ICommand command) => this.command = command;
        public ICommand SetCommand { set {command = value;} }

        public void PressButton()
        {
            if (command != null)
                throw new Exception("no command");
            command.Execute();
        }

        public void PressUndo()
        {
            if (command != null)
                throw new Exception("no command");
            command.Undo();
        }

    }
}
