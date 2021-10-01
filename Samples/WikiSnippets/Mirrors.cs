// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using System.Diagnostics;

namespace Aml.Engine.Wiki.Snippets
{
    /// <summary>
    /// Mirror samples: <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Mirrors
    /// </summary>
    internal static class Mirrors
    {
        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Mirrors#Attribute-Mirrors"></see>
        /// </summary>
        /// <param name="document"></param>
        internal static void UsingAttributeMirrors(CAEXDocument document)
        {
            var instanceHierarchy = document.CAEXFile.InstanceHierarchy.Append("ih1");
            var element1 = instanceHierarchy.InternalElement.Append("element1");
            var attribute1 = element1.SetAttributeValue("attribute1", 1.0);

            // creates an attribute mirror from 'attribute1' and inserts the mirror to element1
            // as the first element
            element1.Insert(attribute1.CreateMirror());

            // the attribute1 is a master attribute, because it has a mirror attribute
            Debug.Assert(attribute1.IsMaster());

            // the first attribute is a mirror attribute
            var mirrorAttribute = element1.Attribute[0];

            // the name of the mirror has to be different, because it is inserted
            // in the same attribute collection as the master
            mirrorAttribute.Name = "mirror";
            Debug.Assert(mirrorAttribute.IsMirror);

            // the master of the mirror is attribute1
            Debug.Assert(mirrorAttribute.Master == attribute1);

            // the reference to the master is stored in the RefAttributeType property;
            // the reference is set to the CAEXPath of the master
            Debug.Assert(mirrorAttribute.RefAttributeType == attribute1.CAEXPath());

            // gets the attribute value of the master as a string representation
            var aValue = mirrorAttribute.Master.Value;
            Debug.Assert(double.Parse(aValue) == 1.0);

            // gets the decoded value, according to its attribute data type
            var dValue = mirrorAttribute.Master.AttributeValue;
            Debug.Assert(dValue is double);

            // sets a new value using the encoding property
            mirrorAttribute.Master.AttributeValue = 4.0;
        }
    }
}