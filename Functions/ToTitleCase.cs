using System.Globalization;
using System.Threading;

namespace HiSystems.Interpreter.Functions
{
    public class ToTitleCase : Function
    {
        public override string Name
        {
            get
            {
                return "ToTitleCase";
            }
        }

        public override Literal Execute(IConstruct[] arguments)
        {
            string ret = null;

            base.EnsureArgumentCountIs(arguments, 1);

            string toparse = base.GetTransformedArgument<Text>(arguments, argumentIndex: 0);
            toparse = toparse.ToLowerInvariant();

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo text = cultureInfo.TextInfo;

            ret = text.ToTitleCase(toparse);

            return new Text(ret);
        }
    }
}