namespace Generics_Tests.Interfaces
{
    interface IModels
    {
    }
    interface IContravariant<in A> { }
    interface IExtContravariant<in A> : IContravariant<A> { }
}
