﻿// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Services;
using Aml.Engine.Services.Interfaces;

using System;
using System.Diagnostics;
using System.Linq;

namespace Samples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Document Creation
            var amlDocument = A_CreateSampleAMLDocument();

            // adding some properties to the created aml object in the document
            B_AddObjectProperties(amlDocument);

            // build a sample topology
            C_BuildATopology(amlDocument);

            // create aml object relations
            D_CreateRelations(amlDocument);

            amlDocument.SaveToFile("Sample.aml", true);

            // see what we have build here
            // starts the registered editor for .aml files
            var process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = System.IO.Path.GetFullPath("Sample.aml");
            process.Start();
        }

      


        /// <summary>
        /// Creates a sample aml document with automationml standard libraries and one aml object.
        /// </summary>
        /// <returns></returns>
        private static CAEXDocument A_CreateSampleAMLDocument()
        {
            // creates a new aml document using the default schema, which is CAEX3.0
            var amlDocument = CAEXDocument.New_CAEXDocument();

            // add some meta data
            var documentInformation = amlDocument.CAEXFile.SourceDocumentInformation.First();

            documentInformation.OriginID = typeof(Program).Assembly.GetName().Name;
            documentInformation.OriginName = typeof(Program).Assembly.GetName().Name;
            documentInformation.OriginRelease = typeof(Program).Assembly.GetName().Version.ToString();
            documentInformation.OriginVersion = typeof(Program).Assembly.GetName().Version.ToString();
            documentInformation.OriginVendor = "AutomationML";
            documentInformation.OriginVendorURL = "https://github.com/AutomationML/AMLEngine2.1";
            documentInformation.OriginProjectID = "AMLEngine2.1";
            documentInformation.OriginProjectTitle = "AMLEngine2.1 samples";
            documentInformation.LastWritingDateTime = DateTime.Now;

            // adds the standard base libraries to the document
            AutomationMLInterfaceClassLibType.InterfaceClassLib(amlDocument);
            AutomationMLBaseRoleClassLibType.RoleClassLib(amlDocument);

            // only CAEX3.0 documents allow to add an attribute type library. This should
            // be true for the new document
            if (amlDocument.Schema == CAEXDocument.CAEXSchema.CAEX3_0)
            {
                AutomationMLBaseAttributeTypeLibType.AttributeTypeLib(amlDocument);
            }

           
            // now you can use the standard role and interface classes
            // we will create some internal elements with standard class assignments now
            var ih = amlDocument.CAEXFile.InstanceHierarchy.Append("SomeAMLObjects");

            // you can reference the instance hierarchy like this:
            Debug.Assert(ih.Equals(amlDocument.CAEXFile.InstanceHierarchy[0]));
            Debug.Assert(ih.Equals(amlDocument.CAEXFile.InstanceHierarchy["SomeAMLObjects"]));

            // an automationML object InternalElement is added and named
            var line = AMLObject.AddObjectWithoutClassReference(ih, "Root");

            // we override the id, generated by the engine for this object
            line.ID = "ROOT";

            // the element gets an assigned role class. The standard role class path is used
            line.AddRoleClassReference(AutomationMLBaseRoleClassLib.ResourceStructure);

            // There exists an overload for this method which accepts the role class object.
            // To get the roleclass object, you have to search for it. It should be found because
            // the library has been added to the document before.
            var roleClass = amlDocument.FindByPath(AutomationMLBaseRoleClassLib.Resource) as RoleFamilyType;
            if (roleClass != null)
            {
                line.AddRoleClassReference(roleClass);
            }

            // the element has two rolereferences now.
            Debug.Assert(line.RoleReferences.Count() == 2);

            return amlDocument;
        }

        private static void B_AddObjectProperties(CAEXDocument amlDocument)
        {
            // get the object from the document using the assigned ID
            var amlObject = amlDocument.FindByID("ROOT");

            // alternatives are used in the assertions
            Debug.Assert(amlObject.Equals(amlDocument.CAEXFile.InstanceHierarchy[0].First()));
            Debug.Assert(amlObject.Equals(amlDocument.CAEXFile.InstanceHierarchy[0].InternalElement[0]));
            Debug.Assert(amlObject.Equals(amlDocument.CAEXFile.Descendants<InternalElementType>().First()));

            amlObject.Description = "This is an assembly line";

            // this object can have attributes
            if (amlObject is IObjectWithAttributes amlObjectWithAttributes)
            {
                AMLObjectAttribute.AddAttributeUsingStandardAttributeType(amlObjectWithAttributes);
                AMLObjectAttribute.AddAttributeUsingInstantiation(amlObjectWithAttributes);
                AMLObjectAttribute.AddAttributeWithDoubleValue(amlObjectWithAttributes);
            }

            // this object can have interfaces, see the alternatives to add interfaces
            if (amlObject is IObjectWithExternalInterface amlObjectWithInterfaces)
            {
                AMLObjectInterface.AddExternalInterfaceUsingStandardInterfaceClass(amlObjectWithInterfaces);
                AMLObjectInterface.AddExternalInterfaceUsingInstantiation(amlObjectWithInterfaces);
                AMLObjectInterface.AddExternalInterfaceWithoutClassreference(amlObjectWithInterfaces);
                AMLObjectInterface.AddExternalInterfaceAsCopy(amlObjectWithInterfaces);
            }
        }

        /// <summary>
        /// build a topology, starting from the root element.
        /// </summary>
        /// <param name="amlDocument">The aml document.</param>
        private static void C_BuildATopology(CAEXDocument amlDocument)
        {
            // get the object from the document using the assigned ID
            var amlObject = amlDocument.FindByID("ROOT") as InternalElementType;

            // the topology should consist of 4 levels
            var level = 4;

            AMLObjectChildren.AddElementChildren(amlObject, ref level);
        }

        /// <summary>
        /// create some relations between aml objects
        /// </summary>
        /// <param name="amlDocument">The aml document.</param>
        private static void D_CreateRelations(CAEXDocument amlDocument)
        {
            // get the object from the document using the assigned ID
            var amlObject = amlDocument.FindByID("ROOT") as InternalElementType;

            // first, find objects with external interfaces of type PPRConnector
            // we only want to interrelate thoses objects
            var connectorInterfaceReferences = ServiceLocator.QueryService.ElementsWithCAEXPathReference(amlObject, AutomationMLInterfaceClassLib.PPRConnector);

            // second, pair the elements in the collection to select the possible internal link partners
            var relationPartners = from a in connectorInterfaceReferences
                                   from b in connectorInterfaceReferences 
                                   select (a:a.CaexObject, b:b.CaexObject);
            var maxLinks = 8;
            // create some internal links from the collection
            foreach (var relation in relationPartners)
            {
                var first = relation.a as ExternalInterfaceType;
                var second = relation.b as ExternalInterfaceType;

                if (AMLObjectRelations.CreateAMLObjectRelationIfUnrelated (first, second))
                {
                    if (--maxLinks == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}