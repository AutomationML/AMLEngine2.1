// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

namespace Samples
{
    internal class GettingStartet
    {
        private void loadDocument()
        {
            // load a document
            var caexDocument = CAEXDocument.LoadFromFile("myfile.aml");

            // get the InstanceHierarchy
            var myIH = caexDocument.CAEXFile.InstanceHierarchy[0];

            // add more content
            myIH.InternalElement.Append("Ie1");
        }

        private void newDocument()
        {
            // create a new empty document
            var caexDocument = CAEXDocument.New_CAEXDocument();

            // add content to the ROOT CAEXFile element
            var myIH = caexDocument.CAEXFile.New_InstanceHierarchy("myIH");

            caexDocument.SaveToFile("myfile.aml", true);
        }

        private void AddStandardRoleClassReference()
        {
            var caexDocument = CAEXDocument.New_CAEXDocument();

            // adds the base libraries to the document
            AutomationMLInterfaceClassLibType.InterfaceClassLib(caexDocument);
            AutomationMLBaseRoleClassLibType.RoleClassLib(caexDocument);

            // add an InstanceHierarchy to the ROOT CAEXFile element
            var myIH = caexDocument.CAEXFile.New_InstanceHierarchy("myIH");

            // add an InternalElement
            var ie = myIH.InternalElement.Append("ie");

            // assign the AutomationMLBaseRole
            ie.AddRoleClassReference(AutomationMLBaseRoleClassLib.AutomationMLBaseRole);
        }
    }
}