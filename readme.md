## AMLEngine2.1 
### AutomationML 2.1 Application Programming Interface

The AMLEngine2.1 allows you to process AutomationML documents with a provided Application Programming Interface, 
based on the .NET Framework. Using the API you interact with CAEX-Elements and AutomationML-Objects.
This AMLEngine is an advanced development of the AMLEngine Version 3.x which only supports AutomationML Version 2.0
and the CAEX Version 2.15. This new development also supports AutomationML Version 2.1 which is based on CAEX Version 3.0. 

A detailed overview of the differences between CAEX 2.15 and CAEX 3.0 is presented [here](Documentation/changes.md).

A short guide explaining a migration strategy to adpat applications, using AMLEngine Version 3.x, to the Aml.Engine is presented [here](adaption.md).

To see a complete documentation of the Aml.Engine look [here](Documentation/readme.md).

### Download 

The AMLEngine2.1 is published as  the named package **Aml.Engine** on nuget at https://www.nuget.org/packages/Aml.Engine.

### Getting started

See the documentation and examine the provided [examples](Samples/readme.md/). There are various basic examples and advanced examples. 
A special adaption section describes the steps to be executed, how old code, using the former AMLEngine v3.x.x, can be adapted to
the new engine.

### A short introduction to the application of the engine

1. Create a new empty Document, add content and save it.

```c#
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

// create a new empty document
var caexDocument = CAEXDocument.New_CAEXDocument();

// add content to the ROOT CAEXFile element
var myIH = caexDocument.CAEXFile.New_InstanceHierarchy("myIH");

caexDocument.SaveToFile ("myfile.aml", true);
```

2. Load the created Document
```c#
using Aml.Engine.CAEX;


// load a document
var caexDocument = CAEXDocument.LoadFromFile("myfile.aml");

// get the InstanceHierarchy
var myIH = caexDocument.CAEXFile.InstanceHierarchy[0];

// add more content
myIH.InternalElement.Append ("Ie1");
```

3. Use of  AutomationML standard classes
```c#
using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;

var caexDocument = CAEXDocument.New_CAEXDocument();

// adds the base libraries to the document
AutomationMLInterfaceClassLibType.InterfaceClassLib(caexDocument);
AutomationMLBaseRoleClassLibType.RoleClassLib(caexDocument);

// add an InstanceHierarchy to the ROOT CAEXFile element
var myIH = caexDocument.CAEXFile.New_InstanceHierarchy("myIH");

// add an InternalElement
var ie = myIH.InternalElement.Append ("ie");

// assign the AutomationMLBaseRole
ie.AddRoleClassReference(AutomationMLBaseRoleClassLib.AutomationMLBaseRole);

```

