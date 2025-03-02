---

![](img/AutomationML-Logo.png)

---

# AMLEngine2.1 

## News

Version 4.4.2 of the Aml.Engine provides a new extension method to serialize a user defined class into a CAEX `AdditionalInformation` element. There is a new [basic solution example](Samples/basic.md) (Nr. 9), explaining how to use the new extension method.

The [sample solutions](Samples/readme.md) include new solutions that explain, how to use the AutomationML library service. Among other things, it is shown how all documents published by the AutomationML Association can be loaded and used via the `AMLFileService`.

The AMLEngine2.1 API Reference Guide has been updated and is now available at https://automationml.github.io/AMLEngine2.1/. A diagram of the complete CAEX data model is included. It can be downloaded from https://automationml.github.io/AMLEngine2.1/media/CAEXClassDiagram.png.

New Wiki Pages are added:
- Working with [external libraries and classes](https://github.com/AutomationML/AMLEngine2.1/wiki/Externals).
- Using [Indices](https://github.com/AutomationML/AMLEngine2.1/wiki/Indices) to speed up queries.
- New Examples to access elements in [structured Attributes](https://github.com/AutomationML/AMLEngine2.1/wiki/Attributes#Structure-Attributes).


## Important Note

Please note a problem according to [DocumentVersionInformation in CAEXFiles](https://github.com/AutomationML/AMLEngine2.1/wiki/DocumentVersions) 

### AutomationML 2.1 Application Programming Interface

The AMLEngine2.1 allows you to process AutomationML documents with a provided Application Programming Interface, 
based on the .NET Framework. Using the API you interact with CAEX-Elements and AutomationML-Objects.
This AMLEngine is an advanced development of the AMLEngine Version 3.x which only supports AutomationML Version 2.0
and the CAEX Version 2.15. This new development also supports AutomationML Version 2.1 which is based on CAEX Version 3.0. 

A detailed overview of the differences between CAEX 2.15 and CAEX 3.0 is presented [here](https://github.com/AutomationML/AMLEngine2.1/wiki/changes).

A short guide explaining a migration strategy to adapt applications, using AMLEngine Version 3.x, to the Aml.Engine is presented [here](adaption.md).

To see a complete documentation of the Aml.Engine API reference guide look [here](https://automationml.github.io/AMLEngine2.1/).

Additional documentations with more examples are included in the [Wiki](https://github.com/AutomationML/AMLEngine2.1/wiki)

### Download 

The AMLEngine2.1 is published in the core package [**Aml.Engine**](https://www.nuget.org/packages/Aml.Engine) on nuget at https://www.nuget.org/packages/Aml.Engine and additional [extension packages](https://www.nuget.org/packages?q=Aml.Engine).

### Getting started

See the [documentation](https://github.com/AutomationML/AMLEngine2.1/wiki) and examine the provided [examples](Samples/readme.md/). There are various basic examples and advanced examples. 
A special adaption section describes the steps to be executed, how old code, using the former `AMLEngine` v3.x.x, can be adapted to the new engine.

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

