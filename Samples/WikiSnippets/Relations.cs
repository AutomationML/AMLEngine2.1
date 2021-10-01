// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using System;
using System.Diagnostics;

namespace Aml.Engine.Wiki.Snippets
{
    /// <summary>
    /// Relation samples: <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Relations
    /// </summary>
    internal static class Relations
    {
        internal static T CreateClassInstance<T> (this IInstantiable<T> amlClass, string name) where T: CAEXBasicObject
        {
            var caexInstance = amlClass.CreateClassInstance();
            (caexInstance as CAEXObject).Name = name;

            return caexInstance;
        }


        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Relations#externalinterface-creation-by-class-instantiation"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CreateInterfaceClassInstance(CAEXDocument document)
        {
            // add a new logistic project as an Instance Hierarchy
            var logisticsProject = document.CAEXFile.InstanceHierarchy.Append("LogisticsProject");

            // import the standard AutomationML Interfaceclass library into the document
            var interfaceClassLib = AutomationMLInterfaceClassLibType.InterfaceClassLib(document);

            // add a distributing switch to your project
            var dswitch = logisticsProject.New_InternalElement("distributing switch");

            // the switch should contain one input and two outputs
            // the standard interface class 'order' is used to model the distribution
            var order = document.FindByPath(AutomationMLInterfaceClassLib.Order) as InterfaceFamilyType;

            if (order == null)
            {
                throw new Exception("The standard interface class 'Order' doesnot exist");
            }

            // create three new class instances (ExternalInterface),
            // the instances contain the interface class attribute 'Direction'
            var input = order.CreateClassInstance("in");
            var out1 = order.CreateClassInstance("out1");
            var out2 = order.CreateClassInstance("out2");

            // the direction value is needed, because CAEX doesnot
            // provide directed instance to instance relations
            input.Attribute["Direction"].Value = "In";
            out1.Attribute["Direction"].Value = "Out";
            out2.Attribute["Direction"].Value = "Out";

            // the direction attribute is defined in the standard attribute type library
            // the possible values are defined in a nominal value constraint
            // you can ensure, that the assigned values are in the nominal value collection
            // see the attrubte examples in the wiki for details.

            dswitch.Insert(input);
            dswitch.Insert(out1, asFirst: false);
            dswitch.Insert(out2, asFirst: false);
        }

        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Relations#InternalElement-creation-by-class-instantiation"/>
        /// </summary>
        /// <param name="document"></param>
        internal static void CreateSystemUnitClassInstance(CAEXDocument document)
        {
            // add a new engineering project as an Instance Hierarchy and a SystemUnitClass Library
            // which provides devices to be used in the project
            var engineeringProject = document.CAEXFile.InstanceHierarchy.Append("EngineeringProject");
            var devices = document.CAEXFile.SystemUnitClassLib.Append("Devices");

            // Adding a Product as a new SystemUnitClass to the SystemUnitClassLib
            var motionController = devices.SystemUnitClass.Append("ControllerS400");
            // the technical data of the product is provided by an ECLASS identifier
            motionController.Attribute.Append("ECLASS").Value = "19234103";

            // Insertion of a new class instance (InternalElement) in the InstanceHierarchy
            // The instance also contains the ECLASS attributes of the class
            engineeringProject.Insert(motionController.CreateClassInstance("CS400_1"));
            var ctrl1 = engineeringProject.InternalElement[0];

            // The class-instance relation is saved in the InternalElement
            Debug.Assert(ctrl1.SystemUnitClass.Equals(motionController));
            Debug.Assert(ctrl1.RefBaseSystemUnitPath == motionController.CAEXPath());

            // In this example, it might be better to read the attributes from an ECLASS catalog and
            // not assign the ECLASS identifier to the instance
            var ctrl2 = engineeringProject.InternalElement.Append("S400_ECLASS_resolved");

            static void AddECLASSAttributes(InternalElementType element, SystemUnitFamilyType eclass)
            {
                // add the class reference without any attributes
                element.SystemUnitClass = eclass;
                if (eclass.Attribute["ECLASS"].Value == "19234103")
                {
                    // you need a ECLASS license to get the data, this is only an example
                    element.SetAttributeValue("MC_Power", 220.0);
                }
            }

            AddECLASSAttributes(ctrl2, motionController);
        }

        /// <summary>
        /// <see href="https://github.com/AutomationML/AMLEngine2.1/wiki/Relations#RoleRequirement-creation-by-class-instantiation"></see>
        /// </summary>
        /// <param name="document"></param>
        internal static void RoleInstantiation(CAEXDocument document)
        {
            // adding a RoleClass library and a role class
            var roleClassLib = document.CAEXFile.RoleClassLib.Append("AutomationRoleClasses");
            var switchRole = roleClassLib.RoleClass.Append("Switch");

            // adding attributes to the roleClass
            switchRole.Attribute.Append("NumberOfPoles").AttributeDataType = AttributeTypeType.ClrToXmlType(typeof(int));
            switchRole.Attribute.Append("NumberOfThrows").AttributeDataType = AttributeTypeType.ClrToXmlType(typeof(int));

            // creating an Instance hierarchy and some instances of switches
            var engineeringProject = document.CAEXFile.InstanceHierarchy.Append("EngineeringProject");
            var pushButtonSwitch = engineeringProject.InternalElement.Append("pushButtonSwitch");

            // make this element to a switch by insertion of a RoleClass instance
            // the RoleClass instance is a RoleRequirement object which is inserted
            // into the RoleRequirements colllection of the element. The role class attributes
            // are copied to the created RoleRequirement object, too.
            pushButtonSwitch.Insert(switchRole.CreateClassInstance());

            // Alternate RoleClass assignment, here it is necessary to explicity request the creation of the attributes
            // by setting the 'addInstance' parameter to 'true'. The 'addUnique' is set to false here, because the
            // element contains this role class assignment already. Multiple assignments of the same RoleClass are
            // not excluded. The 'addSupportedRoleClass' is an obsolete parameter in CAEX 3.0 documents.
            pushButtonSwitch.AddRoleClassReference(switchRole, addSupportedRoleClass: false, addUnique: false, addInstance: true);

            // if you want to copy the RoleClass attributes to the InternalElement
            pushButtonSwitch.CopyAttributesFrom(switchRole, includingValues: false);
        }
    }
}