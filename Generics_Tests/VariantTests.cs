using Generics_Tests.Models;
using System.Collections.Generic;
using Xunit;

public class VariantTests
{
    [Fact]
    public void Interface_Covariance()
    {
        IEnumerable<Derived> d = new List<Derived>();
        IEnumerable<Base> b = d;

        Assert.Equal(b, d);
    }

    [Fact]
    public void Method_Covariance()
    {
        var derived = new Derived();
        var @base = new Base();

        @base = methods.ContravariantFunction(@base);

        Assert.True(true);
    }

    [Fact]
    public void Contravariant_Interface()
    {
        IContravariant<Base> @interface = new BaseT<Base>();
        IContravariant<Derived> @derived_interface = new BaseT<Derived>();

        @derived_interface = @interface;

        Assert.True(true);
    }

    [Fact]
    public void Contravariant_Function()
    {
        var derived = new Derived();
        var @base = new Base();

        @base = methods.ContravariantFunction(derived);

        Assert.True(true);
    }
}

