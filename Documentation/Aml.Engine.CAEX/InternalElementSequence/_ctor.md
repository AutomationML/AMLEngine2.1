InternalElementSequence Constructor
===================================
Initializes a new instance of the [InternalElementSequence][1] class.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public InternalElementSequence(
	XElement owner,
	Func<XElement, InternalElementType> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  
The owner.

##### *create*
Type: [System.Func][4]&lt;[XElement][3], [InternalElementType][5]>  
Function to create an [InternalElementType][5].


See Also
--------

#### Reference
[InternalElementSequence Class][1]  
[Aml.Engine.CAEX Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: ../InternalElementType/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png