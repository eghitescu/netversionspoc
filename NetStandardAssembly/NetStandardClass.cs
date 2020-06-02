using System;
using System.Runtime.CompilerServices;
using NetFrameworkAssembly;

namespace NetStandardAssembly
{
    public class NetStandardClass
    {
        public string PropertyFromNetStandard => "NetStandardClassProperty";

        public string MethodThatCallsSpecificNetFramework()
        {
            try
            {
                var result = new NetFrameworkClass().NetFrameworkSpecificProperty;
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return $"exception caught {e.Message}";
            }
        }

        public string PropertyFromNetFramework => (new NetFrameworkClass()).AnyProperty;
    }
}
