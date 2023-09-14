using FacadePattern.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        private readonly OperationA _operationA;
        private readonly OperationB _operationB;
        private readonly OperationC _operationC;

        public Facade(OperationA operationA , OperationB operationB, OperationC operationC)
        {
            _operationA = operationA;
            _operationB = operationB;
            _operationC = operationC;
        }

        public void OperateAandC()
        {
            _operationA.Operate();
            _operationC.Operate();
        }

        public void FullOperation()
        {
            _operationA.Operate();
            _operationB.Operate();
            _operationC.Operate();
        }
    }
}
