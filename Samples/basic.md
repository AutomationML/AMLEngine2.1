# Basic code examples

These code examples show basic principles for AutomationML application development using the Aml.Engine.

### Basic Examples

#### 1. Loading a Document

``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.LoadFromFile ("myFile.aml");
```

#### 2. Saving a Document

``` C#
using Aml.Engine.CAEX;

CAEXDocument.SaveToFile ("myFile.aml", true);
```

#### 3. Creation of a new CAEX document containing  Internal Elements

``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
var myIE = myIH.InternalElement.Append("myIE");
```

#### 4. Accessing properties using Indexers

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

#### 5. Traversing a Document

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
#### 6. InternalElement creation by class instantiation.

``` C#
using Aml.Engine.CAEX;

var document = CAEXDocument.New_Document ();
var myIH = document.CAEXFile.InstanceHierarchy.Append("myIH");
var mySlib = document.CAEXFile.SystemUnitClassLib.Append("mySlib");
var mySuc = mySlib.SystemUnitClass.Append("suClass");

// insert a new class instance (InternalElement) to the InstanceHierarchy
var myIE = myIH.Insert (mySuc.CreateClassInstance());
```
#### 7. Creation of instance to instance relations with InternalLinks

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
#### 8. Creation of class to class relations using AutomationML Base Classes

#### See Also

- [IClassWithBaseClassReference](../Documentation/Aml.Engine.CAEX/IClassWithBaseClassReference/README.md/)
- [BaseClass](../Documentation/Aml.Engine.CAEX/InterfaceFamilyType/BaseClass.md/), 
- [InterfaceClassLib](../Documentation/Aml.Engine.AmlObjects/AutomationMLInterfaceClassLibType/README.md/) 
- [MakeAutomationMLBaseInterface](../Documentation/Aml.Engine.AmlObjects/AutomationMLInterfaceClassLib/MakeAutomationMLBaseInterface.md/)

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
    
    // creates a class relation to the AutomationML Base Interface Class
    myIC.MakeAutomationMLBaseInterface();
}
```

#### 9. Serialization of a class to an AdditionalInformation Element

``` C#
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

// class to be serialized into an AdditionalInformation element, the derivation from
// AdditionalInformationContent gives access to the AdditionalInformation CAEX owner.
// The derivation is optional.
[Serializable]
class MyClass: AdditionalInformationContent
{
	string MyProperty {get;set;}
}

// associate a user defined class to a SystemUnitClassLib's AdditionalInformation via serialization
static void WriteClassToAdditionalInformation()
{
	var document = CAEXDocument.New_Document ();
	var slib = document.CAEXFile.SystemUnitClassLib.Append("SLib");
	
	// create an instance of MyClass
	var myClass = new MyClass {MyProperty="some data"};
    
    // assignment allows to access the owner of the element
    myClass.CaexObject = slib;
	
	// serialize this instance into the additional information of the created library
	slib.SerializedAdditionalInformation<MyClass>().Append(myClass);
	
	document.SaveToFile ("Customized.aml");
}	

// read serialized user defined class from a SystemUnitClassLib's AdditionalInformation via deserialization
static void ReadClassFromAdditionalInformation()
{
	var document = CAEXDocument.LoadFromFile ("Customized.aml");
	var slib = document.CAEXFile.SystemUnitClassLib[0];
	
	// access the deserialized instance of MyClass
	var myClass = slib.SerializedAdditionalInformation<MyClass>()[0];	
}	

```


## See Also


#### Other Resources

- [Document validation](validation.md)
- [Query service](queries.md)
- [Advanced document processing using services](service.md)
