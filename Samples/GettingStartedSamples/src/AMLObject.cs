// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

namespace Samples
{
    /// <summary>
    /// This class provides sample methods to create internalelements
    /// </summary>
    internal static class AMLObject
    {
        /// <summary>
        /// Adds an internal element as a new aml object without a class reference to the provided container.
        /// </summary>
        /// <param name="container">The element container.</param>
        /// <param name="elementName">Name of the element.</param>
        /// <returns></returns>
        internal static InternalElementType AddObjectWithoutClassReference(IInternalElementContainer container, string elementName)
        {
            return container.InternalElement.Append(elementName);

            // alternative ways providing some attribute values:
            // container.InternalElement.Append(("Name", elementName));
            // container.InternalElement.Append(("ID","ROOT"),("Name", elementName));
        }

        /// <summary>
        /// Adds an internal element as a new aml object with a class reference to the provided container.
        /// </summary>
        /// <param name="container">The element container.</param>
        /// <param name="elementName">Name of the element.</param>
        /// <returns></returns>
        internal static InternalElementType AddObjectWithClassReference(IInternalElementContainer container, string elementName)
        {
            // check if a suitable class exists which can be used here
            // it is assumed, that the class can be found with the ID 'AMLCLASS1'
            var amlDocument = container.CAEXDocument();
            var amlClass = amlDocument.FindByID("AMLCLASS1");
            if (amlClass == null)
            {
                // create a suitable aml class to be instantiated as an aml object.
                // we use the InternalElement with the ROOT ID as object template
                var amlObject = amlDocument.FindByID("ROOT") as InternalElementType;

                if (amlObject != null)
                {
                    amlClass = AMLClass.AddAmlClassFromAMLObjectTemplate("AMLCLASS1", amlObject);
                    amlClass.Name = "AMLClass derived from root";
                }
            }

            if (amlClass is not SystemUnitFamilyType systemUnitClass)
            {
                return null;
            }
            var newAmlObject = container.InternalElement.Insert(systemUnitClass.CreateClassInstance(), false);
            newAmlObject.Name = elementName;

            return newAmlObject;
        }
    }
}