// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using System;
using System.Diagnostics;

namespace Aml.Engine.Wiki.Snippets
{
    /// <summary>
    /// Attributes samples: <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Attributes
    /// </summary>
    internal static class Attributes
    {
        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Attributes#Attribute-Values-and-Attribute-Datatypes"></see>
        /// </summary>
        /// <param name="document"></param>
        internal static void AttributeValuesAndDataTypes(CAEXDocument document)
        {
            // adds a raw attribute - without value and datatype - to an element
            var instanceHierarchy = document.CAEXFile.InstanceHierarchy.Append("ih1");
            var element1 = instanceHierarchy.InternalElement.Append("element1");
            var attribute1 = element1.Attribute.Append("attribute1");

            // Attributes provide 'Value'- and 'AttributeDataType'- properties
            // The value property is of type 'string' which means that the user
            // has to define the correct xml format for the desired data type himself.

            // storing a date time value, using 'Value' and 'AttributeDataType'.
            attribute1.Value = System.Xml.XmlConvert.ToString(DateTime.Now, System.Xml.XmlDateTimeSerializationMode.Local);
            attribute1.AttributeDataType = AttributeTypeType.ClrToXmlType(typeof(DateTime));

            // Attributes provide the 'AttributeValue'- property (also 'DefaultAttributeValue')
            // This property selects the correct xml encoding and decoding,
            // depending of the assigned AttributeDataType.
            attribute1.AttributeValue = DateTime.Now;
            attribute1.DefaultAttributeValue = DateTime.MinValue;

            // ensure, that the saved value preserves the data type
            Debug.Assert(attribute1.AttributeValue is DateTime);

            // assignment of a value which doesn't fit to the defined AttributeDataType is rejected
            attribute1.AttributeValue = 1.0;
            Debug.Assert(attribute1.AttributeValue.Equals(1.0) == false);

            // reset the datatype to change the value and type
            attribute1.AttributeDataType = AttributeTypeType.ClrToXmlType(typeof(double));
            attribute1.AttributeValue = 1.0;

            // ensure, that the saved value preserves the changed data type
            Debug.Assert(attribute1.AttributeValue is double);
        }
    }
}