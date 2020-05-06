namespace HiSystems.Interpreter.Functions
{
    public class Substring : Function
    {
        public override string Name
        {
            get
            {
                return "Substring";
            }
        }

        public override Literal Execute(IConstruct[] arguments)
        {
            base.EnsureArgumentCountIs(arguments, 3);

            string toparse = base.GetTransformedArgument<Text>(arguments, argumentIndex: 0);
            decimal index = base.GetTransformedArgument<Number>(arguments, argumentIndex: 1);
            decimal length = base.GetTransformedArgument<Number>(arguments, argumentIndex: 2);

            return new Text(
                toparse.Substring(
                    (int)index, 
                    (int)length)
            );
        }
    }
}