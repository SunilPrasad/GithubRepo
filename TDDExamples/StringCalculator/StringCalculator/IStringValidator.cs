namespace StringCalculator
{
    public interface IStringValidator
    {
        bool Validate(string number,out int numInt);
    }
}