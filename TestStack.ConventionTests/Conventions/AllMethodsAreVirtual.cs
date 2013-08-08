﻿namespace TestStack.ConventionTests.Conventions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using TestStack.ConventionTests.ConventionData;
    using TestStack.ConventionTests.Internal;

    public class AllMethodsAreVirtual : IConvention<Types, MethodInfo>
    {
        public string ConventionTitle { get { return "Methods must be virtual"; } }

        public IEnumerable<MethodInfo> GetFailingData(Types data)
        {
            return data.TypesToVerify.SelectMany(t => t.NonVirtualMethods());
        }
    }
}