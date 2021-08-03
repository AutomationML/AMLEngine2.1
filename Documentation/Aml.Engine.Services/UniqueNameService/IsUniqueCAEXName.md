UniqueNameService.IsUniqueCAEXName Method
=========================================
AutomationML 2.1 APIDetermines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool IsUniqueCAEXName(
	XElement element
)
```

#### Parameters

##### *element*
Type: [System.Xml.Linq.XElement][2]  
The element.

#### Return Value
Type: [Boolean][3]  
`true` if the elements name is unique, otherwise `false`. 
#### Implements
[IUniqueName.IsUniqueCAEXName(XElement)][4]  


See Also
--------

#### Reference
[UniqueNameService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IUniqueName/IsUniqueCAEXName.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png