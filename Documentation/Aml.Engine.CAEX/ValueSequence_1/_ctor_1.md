ValueSequence&lt;TDataType> Constructor (XElement, String, Predicate&lt;XElement>)
==================================================================================
Creates a new instance of the ValueSequence for the specified owner and the specified name which has to be a valid name for child elements, which can be filtered out from the owner by this name. The specified condition is used as an additional filter criteria.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public ValueSequence(
	XElement owner,
	string elementName,
	Predicate<XElement> condition
)
```

#### Parameters

##### *owner*
Type: [System.Xml.Linq.XElement][2]  
The owner.

##### *elementName*
Type: [System.String][3]  
The element name.

##### *condition*
Type: [System.Predicate][4]&lt;[XElement][2]>  
Filter criteria.


See Also
--------

#### Reference
[ValueSequence&lt;TDataType> Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.predicate-1
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png