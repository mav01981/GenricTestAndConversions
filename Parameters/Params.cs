using System.Diagnostics;

namespace Parameters
{
    static class Params
    {
        public static void doSomething(ref string phrase)
        {
            phrase = "workcompleted";
            Debug.WriteLine(phrase);
        }
        public static void doSomethingElse(out string phrase)
        {
            phrase = "workcompleted";
            Debug.WriteLine(phrase);
        }
        public static string dosomethingFunction(ref string phrase)
        {
            phrase = "workcompleted";
            return "";
        }

        public static string dosomethingElseFunction(out string phrase)
        {
            phrase = "workcompleted";
            return "";
        }
    }
}
