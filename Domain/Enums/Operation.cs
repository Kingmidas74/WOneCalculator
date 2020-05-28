namespace Domain
{
    public enum OperationId : int {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
    }
    public class Operation {
        public OperationId OperationId { get; set; }
        public string Value { get; set; }
    }
}