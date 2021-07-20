// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using System.Diagnostics;

namespace Samples
{
    /// <summary>
    /// This class provides sample methods to create and insert attributes to aml objects
    /// </summary>
    internal static class AMLObjectAttribute
    {
        /// <summary>
        /// Adds an attribute to the aml object with a double value.
        /// </summary>
        /// <param name="amlObject">The aml object.</param>
        internal static void AddAttributeWithDoubleValue(IObjectWithAttributes amlObject)
        {
            // assigns a new named double attribute, note that the attributeDataType property
            // is set to xs:double automatically
            var att = amlObject.SetAttributeValue("Length", 280.76);
            Debug.Assert(att.AttributeDataType == "xs:double");
        }

        /// <summary>
        /// Adds an attribute to the aml object, using a standard attribute type.
        /// </summary>
        /// <param name="amlObject">The aml object.</param>
        internal static void AddAttributeUsingStandardAttributeType(IObjectWithAttributes amlObject)
        {
            // assigns a new attribute from a defined standard attribute type
            amlObject.AddAttributeTypeReference(AutomationMLBaseAttributeTypeLib.Cardinality, false, true, "cardinality");
        }

        /// <summary>
        /// Adds an attribute to the aml object, using the instantiation method provided by attribute type.
        /// </summary>
        /// <param name="amlObject">The aml object.</param>
        internal static void AddAttributeUsingInstantiation(IObjectWithAttributes amlObject)
        {
            var amlDocument = amlObject.CAEXDocument();

            // alternative to add attribute
            // 1. Find the attribute type
            var attributeType = amlDocument.FindByPath(AutomationMLBaseAttributeTypeLib.Direction) as AttributeFamilyType;

            // 2. Create the instance and assign a name
            var attribute = attributeType.CreateClassInstance();
            attribute.Name = "direction";

            // 3. Insert the instance
            amlObject.Attribute.Insert(attribute);
        }
    }
}