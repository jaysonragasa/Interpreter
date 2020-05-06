namespace HiSystems.Interpreter.Functions
{
    public class ToUpper : Function
    {
        public override string Name
        {
            get
            {
                return "ToUpper";
            }
        }

        public override Literal Execute(IConstruct[] arguments)
        {
            base.EnsureArgumentCountIs(arguments, 1);

            string toparse = base.GetTransformedArgument<Text>(arguments, argumentIndex: 0);

            return new Text(toparse.ToUpperInvariant());
        }
    }
}