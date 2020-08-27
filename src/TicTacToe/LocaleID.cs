namespace TicTacToe
{
    public class LocaleID
    {
        public string Name { get; private set; }
        public string Value { get; private set; }

        public LocaleID(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
