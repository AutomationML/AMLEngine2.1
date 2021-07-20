using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using System;
using System.Diagnostics;
using System.Linq;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateSampleAMLDocument();
        }

        /// <summary>
        /// Creates a sample aml document with automationml standard libraries and one aml object.
        /// </summary>
        /// <returns></returns>
        static CAEXDocument CreateSampleAMLDocument ()
        {
            // creates a new aml document using the default schema, which is CAEX3.0
            var amlDocument = CAEXDocument.New_CAEXDocument();
            
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
            var line=ih.InternalElement.Append("AssemblyLine");

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
    }
}
