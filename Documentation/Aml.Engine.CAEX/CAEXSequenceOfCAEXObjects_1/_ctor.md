CAEXSequenceOfCAEXObjects&lt;T> Constructor (XElement, String, Func&lt;XElement, T>)
====================================================================================
Initializes a new instance of the [CAEXSequenceOfCAEXObjects&lt;T>][1] class.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public CAEXSequenceOfCAEXObjects(
	XElement owner,
	string caexName,
	Func<XElement, T> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  
The owner.

##### *caexName*
Type: [System.String][4]  
The CAEX element name.

##### *create*
Type: [System.Func][5]&lt;[XElement][3], [T][1]>  
The constructor function to create a wrapper.


See Also
--------

#### Reference
[CAEXSequenceOfCAEXObjects&lt;T> Class][1]  
[Aml.Engine.CAEX Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.func-2
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png