IUniqueName.UniqueCAEXName Method (XElement, String)
====================================================
Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
string UniqueCAEXName(
	XElement sequence,
	string elementTagName
)
```

#### Parameters

##### *sequence*
Type: [System.Xml.Linq.XElement][2]  
The sequence of elements.

##### *elementTagName*
Type: [System.String][3]  
Name of the element tag.

#### Return Value
Type: [String][3]  
 a unique name using the registered default extended with an added number, representing the maximal number 

See Also
--------

#### Reference
[IUniqueName Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png