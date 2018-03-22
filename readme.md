## AMLEngine2.1 
### AutomationML 2.1 Application Programming Interface

The AMLEngine2.1 allows you to process AutomationML documents with a provided Application Programming Interface, 
based on the .NET Framework. Using the API you interact with CAEX-Elements and AutomationML-Objects.
This AMLEngine is an advanced development of the AMLEngine Version 3.x which only supports AutomationML Version 2.0
and the CAEX Version 2.15. This new development also supports AutomationML Version 2.1 which is based on CAEX Version 3.0. 

### Download 

The AMLEngine2.1 is published as  the named package **Aml.Engine** on nuget at https://www.nuget.org/packages/Aml.Engine.

### Getting started

Download the zipped documentation and go to the provided examples. There are various basic examples and advanced examples. 
A special adaption section describes the steps to be executed, if old code, using the former AMLEngine v3.x.x, can be adapted to
the new engine.

### A short introduction to the application of the engine

1. Create a new empty Document, add content and save it.

```csharp
// create a new empty document
var caexDocument = CAEXDocument.New_CAEXDocument();

// add content to the ROOT CAEXFile element
var myIH = caexDocument.CAEXFile.New_InstanceHierarchy("myIH");

caexDocument.SaveToFile ("myfile.aml", true);
```

2. Load the created Document
```csharp
// load a document
var caexDocument = CAEXDocument.LoadFromFile("myfile.aml");

// get the InstanceHierarchy
var myIH = caexDocument.CAEXFile.InstanceHierarchy[0];

// add more content
myIH.InternalElement.Append ("Ie1")
```