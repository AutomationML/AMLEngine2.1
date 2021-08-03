// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using System.Linq;

namespace Samples
{
    /// <summary>
    /// This class provides methods to create systemunitclasses 
    /// </summary>
    internal static class AMLClass
    {
        /// <summary>
        /// Adds a new aml class as a systemUnitClass to a systemUnitClass library.
        /// </summary>
        /// <param name="document">The aml document.</param>
        /// <param name="guid">The unique identifier for the new aml class.</param>
        /// <returns></returns>
        internal static SystemUnitFamilyType AddAmlClass(CAEXDocument document, string guid)
        {
            // first, we need a class library to insert a systemUnitClass
            var classLib = document.CAEXFile.SystemUnitClassLib.FirstOrDefault() ??
                document.CAEXFile.SystemUnitClassLib.Append("AMLClassLib");

            // name and id are assigned using the value tuple mode of the append method
            return classLib.SystemUnitClass.Append(("Name", "AMLClass"), ("ID", guid));
        }

        /// <summary>
        /// Adds a new aml class as a systemUnitClass to a systemUnitClass library. The aml class is created
        /// using an existing aml object as a template.
        /// </summary>
        /// <param name="guid">The unique identifier for the new aml class.</param>
        /// <param name="amlObjectTemplate">The aml object, used as a template.</param>
        /// <returns></returns>
        internal static SystemUnitFamilyType AddAmlClassFromAMLObjectTemplate(string guid, InternalElementType amlObjectTemplate)
        {
            var amlDocument = amlObjectTemplate.CAEXDocument();

            // first, we need a class library to insert a systemUnitClass
            var classLib = amlDocument.CAEXFile.SystemUnitClassLib.FirstOrDefault() ??
                amlDocument.CAEXFile.SystemUnitClassLib.Append("AMLClassLib");

            var amlClass = classLib.SystemUnitClass.Insert(amlObjectTemplate.CreateSystemUnitClass());
            amlClass.ID = guid;

            // the already existing internal element children should not be included in the class
            amlClass.InternalElement.Remove();
            return amlClass;
        }
    }
}