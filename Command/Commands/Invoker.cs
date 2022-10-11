using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class Invoker
    {
        private List<IOperation> operations = new List<IOperation>();

        public void ReceiveOperation(IOperation operation)
        {
            operations.Add(operation);
        }

        public void ExecuteOperations()
        {
            operations.ForEach(op => op.Execute());
            operations.Clear();
        }
    }
}
