using System;
using Xunit;

namespace Parameters
{
    public class UnitTest1
    {
        [Fact]
        public void Ref_()
        {
            string speech = "help me";

            Params.doSomething(ref speech);

            Assert.Equal("workcompleted", speech);
        }

        [Fact]
        public void Out_()
        {
            string speech = "help me";

            Params.doSomethingElse(out speech);

            Assert.Equal("workcompleted", speech);
        }

        [Fact]
        public void OutFunction_()
        {
            string speech = "help me";

           var output = Params.dosomethingElseFunction(out speech);

            Assert.Equal("workcompleted", speech);
        }
    }
}
