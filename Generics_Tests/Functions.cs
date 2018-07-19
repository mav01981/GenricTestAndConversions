using System;
using Generics_Tests.Interfaces;
using Generics_Tests.Models;

static class methods
{
    internal static void GenericMethod<T>(ref T param) where T : Base
    {

    }

    internal static Derived CovariantFunction(Base param)
    {
        return new Derived() { };
    }

    internal static Base ContravariantFunction(IModels param)
    {
        return param as Base;
    }

    internal static bool isFunctionCovariant(string functionName)
    {
        //TO DO GENERATE METHOD using refelection
        return true;
    }
    internal static bool isMethodContravariant(string functionName)
    {
        //TO DO GENERATE METHOD  using refelection
        return true;
    }
}

interface IContravariant<in A> { };