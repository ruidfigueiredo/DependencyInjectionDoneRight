using DependencyInjectionDoneRight.Abstractions;
using DependencyInjectionDoneRight.Implementations;
using StructureMap.Configuration.DSL;

namespace DependencyInjectionDoneRight.Mappings
{
    public class MappingsRegistry : Registry
    {
        public MappingsRegistry()
        {
            For<ISorter>().Use<BubbleSort>();
        }        
    }
}
