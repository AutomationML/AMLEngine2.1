// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

namespace Samples
{
    using Aml.Engine.AmlObjects;
    using Aml.Engine.CAEX;
    using Aml.Engine.CAEX.Extensions;
    using System.Linq;

    /// <summary>
    /// This class provides sample methods to add interfaces to aml objects
    /// </summary>
    internal static class AMLObjectInterface
    {
        /// <summary>
        /// Adds an external interface to the aml object, using a standard interface class.
        /// </summary> 
        /// <param name="amlObject">The aml object.</param>
        internal static void AddExternalInterfaceUsingStandardInterfaceClass (IObjectWithExternalInterface amlObject)
        {
            // assigns a new external interface, which references the standard PPRConnector interface class
            amlObject.AddInterfaceClassReference(AutomationMLInterfaceClassLib.PPRConnector, addUnique: false, addInstance: true, name: "connector1");
        }

        /// <summary>
        /// Adds an external interface to the aml object, using the instantiation method provided by interface class.
        /// </summary> 
        /// <param name="amlObject">The aml object.</param>
        internal static void AddExternalInterfaceUsingInstantiation (IObjectWithExternalInterface amlObject)
        {
            var amlDocument = amlObject.CAEXDocument();

            // alternative to add interfaces
            // 1. Find the interface class
            var interfaceClass = amlDocument.FindByPath(AutomationMLInterfaceClassLib.PPRConnector) as InterfaceFamilyType;
            
            // 2. Create the instance and assign a name
            var extInterface = interfaceClass.CreateClassInstance();
            extInterface.Name = "connector2";
            
            // 3. Insert the instance
            amlObject.ExternalInterface.Insert(extInterface, false);
        }


        /// <summary>
        /// Adds an external interface to the aml object without referencing an interface class.
        /// </summary> 
        /// <param name="amlObject">The aml object.</param>
        internal static void AddExternalInterfaceWithoutClassreference(IObjectWithExternalInterface amlObject)
        {
            // alternative a
            amlObject.ExternalInterface.Append("interfaceWithoutClass1");

            // alternative b, append as last
            amlObject.New_ExternalInterface("interfaceWithoutClass2", false);
        }


        /// <summary>
        /// Adds an external interface to the aml object by copying the first interface
        /// </summary> 
        /// <param name="amlObject">The aml object.</param>
        internal static void AddExternalInterfaceAsCopy(IObjectWithExternalInterface amlObject)
        {
            // create a copy from the first interface, it is ensured, that the interface ids are unique
            var copy = amlObject.ExternalInterface.First().Copy() as ExternalInterfaceType;

            copy.Name = $"copied from {((CAEXObject)amlObject).Name}";
            // insert the copy
            amlObject.ExternalInterface.Insert(copy, false);
        }
    }
}
