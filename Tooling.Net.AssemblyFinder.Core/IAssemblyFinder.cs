using System;
using System.Collections.Generic;
using System.Reflection;

namespace Tooling.Net.AssemblyFinder.Core
{
    public interface IAssemblyFinder
    {
        /// <summary>
        /// Returns all class that implement the defined interface, of inherits of a class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="onlyConcreteClasses"></param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType<T>(bool onlyConcreteClasses = true);

        /// <summary>
        /// Returns all class that implement the defined interface, of inherits of a class
        /// </summary>
        /// <param name="assignTypeFrom"></param>
        /// <param name="onlyConcreteClasses"></param>
        /// <returns></returns>
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreteClasses = true);
        
        /// <summary>Gets tne assemblies related to the current implementation.</summary>
        /// <returns>A list of assemblies that should be loaded by the Nop factory.</returns>
        IList<Assembly> GetAssemblies();
    }
}
