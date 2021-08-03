CAEXObject.CAEXPath Method
==========================
Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the [CAEXPathBuilder][1] to generate the CAEX path of an object according to the documents CAEX version.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public string CAEXPath()
```

#### Return Value
Type: [String][3]  
 The CAEX path. 
#### Implements
[ICAEXObject.CAEXPath()][4]  


Remarks
-------
 Paths require the definition of separators between different path elements. CAEX 2.15 distinguishes between 4 separator types: Alias separator, object separator, interface separator and attribute separator. In CAEX 3.0 only the separator types Alias separator and object separator are used. 

Please note that this method returns a different result than the [GetFullNodePath(ICAEXObject)][5] method, which always returns the path including the object names of all ancestor hierarchy levels.


See Also
--------

#### Reference
[CAEXObject Class][6]  
[Aml.Engine.CAEX Namespace][2]  

[1]: ../../Aml.Engine.CAEX.Extensions/CAEXPathBuilder/README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../ICAEXObject/CAEXPath.md
[5]: ../../Aml.Engine.CAEX.Extensions/CAEXObjectExtensions/GetFullNodePath.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png