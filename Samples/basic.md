# Basic code examples

These code examples show basic principles for AutomationML application development using the AMLEngine.



### Basic Examples
&nbsp;<ol><li id="Loading">
Loading a Document


**C#**<br />
``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.LoadFromFile ("myFile.aml");
```
</li><li id="Saving">
Saving a Document


**C#**<br />
``` C#
using Aml.Engine.CAEX;

CAEXDocument.SaveToFile ("myFile.aml", true);
```
</li><li id="Creation">
Creation of a new CAEX document with InternaElements


**C#**<br />
``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
var myIE = myIH.InternalElement.Append("myIE");
```
</li><li id="Accessing">
Indexers


**C#**<br />
``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
myIH.Version = "1.0";

// Get the first CAEXElement from the sequence of elements
myIH = document.CAEXFile.InstanceHierarchy[0];

// Get the first CAEXElement from the sequence of elements with the name "myIH"
myIH = document.CAEXFile.InstanceHierarchy["myIH"];

// Get the first CAEXElement with a specific attribute AND value from the sequence of elements
myIH = document.CAEXFile.InstanceHierarchy[(Name:"Version", Value:"1.0")];
```
</li><li id="BrowseExample">
Traversing a Document.


**C#**<br />
``` C#
using Aml.Engine.CAEX;
var document = CAEXDocument.LoadFromFile("myFile.aml");

// browse the Instance Hierarchies in the file
foreach (var instanceHierary in document.CaexFile.InstanceHierarchy)
{
        // browse all InternalElements deep and import the internal Elements to your system
        foreach (var internalElement in instanceHierarchy.Descendants<InternalElementType>())
        {
            // ToDo: import internal Element
        }
}
```
</li><li id="InstanceCreation">
Application of instantiation of a SystemUnitClass to insert an InternalElement.


**C#**<br />
``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
var mySlib = document.CAEXFile.SystemUnitClassLib.Append("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("suClass");

// insert a new class instance (InternalElement) to the InstanceHierarchy
var myIE = myIH.Insert (mySuc.CreateClassInstance());
```
</li><li id="InternalLink">
Creation of instance to instance relations using InternalLinks


**C#**<br />
``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
var myIClib = document.CAEXFile.InterfaceClassLib.Append("myIClib");
var myIC = myIClib.InterfaceClass.Append("myIC");

// create an InternalElement which is a common parent to hold the InternalLink
var linkParent = myIH.InternalElement.Append ("linkParent");

// create the instances
var myIEA = linkParent.InternalElement.Append ("myIEA");
var myIEB = linkParent.InternalElement.Append ("myIEB");

// create the Interfaces for the InternalLink connection
myIEA.ExternalInterface.Append ("a");
myIEB.ExternalInterface.Append ("b");

// create the instance to instance relation
var relation = InternalLinkType.New_InternalLink (myIEA.ExternalInterface["a"], myIEB.ExternalInterface["b"], "rel1");

// an alternative way is, to use the InternalLink collection
// var relation = linkParent.InternalLink.Append ("rel1");
// relation.AInterface = myIEA.ExternalInterface["a"];
// relation.BInterface = myIEB.ExternalInterface["b"];
```
</li><li id="BaseClass">
Creation of class to class relations using AutomationML Base Classes.


see also: 
- [IClassWithBaseClassReference](../Documentation/Aml.Engine.CAEX/IClassWithBaseClassReference/README.md/)
- [BaseClass](../Documentation/Aml.Engine.CAEX/InterfaceFamilyType/README.md/), 
- [InterfaceClassLib](../Documentation/Aml.Engine.AmlObjects/AutomationMLInterfaceClassLibType/README.md/) 
- [MakeAutomationMLBaseInterface](../Documentation/Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/README.md/)


**C#**<br />
``` C#
using Aml.Engine.CAEX;
using Aml.Engine.AmlObjects;

var document = CAEXDocument.New_Document ();

// the first solution shows an implementation, which uses existing libraries and classes
void methodWithClasses ()
{
        // add the AutomationMLInterfaceClassLib
        var amlBaseICLib = AutomationMLInterfaceClassLibType.InterfaceClassLib(document);

        var myIClib = document.CAEXFile.InterfaceClassLib.Append("myIClib");

        var myIC = myIClib.InterfaceClass.Append("myICClass");
        var myIC.BaseClass = amlBaseICLib.AutomationMLClass(AutomationMLInterfaceClassLib.AutomationMLBaseInterface);
}

// the second solution shows an implementation, which uses the standardized class path
void methodWithClassPath ()
{
        var myIClib = document.CAEXFile.InterfaceClassLib.Append("myIClib");

        var myIC = myIClib.InterfaceClass.Append("myICClass");

}
```
</li></ol>&nbsp;
