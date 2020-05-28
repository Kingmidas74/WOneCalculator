using System;

namespace Domain
{
    public partial class OperationHistory : Entity
    {
        public virtual OperationId Operation {get;set;}
        public double FirstOperand {get;set;}
        public double SecondOperand {get;set;}
    }
}