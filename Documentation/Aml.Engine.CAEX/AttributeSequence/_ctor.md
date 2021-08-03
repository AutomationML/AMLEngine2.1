AttributeSequence Constructor
=============================
AutomationML 2.1 APIInitializes a new instance of the [AttributeSequence][1] class.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public AttributeSequence(
	XElement owner,
	Func<XElement, AttributeType> create
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][3]  
The owner.

##### *create*
Type: [System.Func][4]&lt;[XElement][3], [AttributeType][5]>  
The constructor function to create an Attribute wrapper.


See Also
--------

#### Reference
[AttributeSequence Class][1]  
[Aml.Engine.CAEX Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.func-2
[5]: ../AttributeType/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png