namespace Shotgun.Surgery.App
{
    public class Number
    {
        public int? Value { get; private set; }
        private static int Except = 18;
        private Number(int? value)
        {
            Value = value;
        }

        public static Number Create(int? value = null)
        {
            if (value == null)
            {
                return new Number(GetRandomNumber());
            }
            return new Number(value);
        }

        private static int? GetRandomNumber()
        {
            int randomNumber = new Random().Next(1, 21);
            return randomNumber == Except ? randomNumber + 1 : randomNumber;
        }
    }
}
