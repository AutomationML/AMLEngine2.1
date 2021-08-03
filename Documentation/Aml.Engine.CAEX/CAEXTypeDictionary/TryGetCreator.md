CAEXTypeDictionary.TryGetCreator Method
=======================================
Tries to get the constructor function which can be used to create a CAEX wrapper for an CAEX element with the provided element name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool TryGetCreator(
	string elementName,
	out Func<XElement, CAEXWrapper> creatorFunc
)
```

#### Parameters

##### *elementName*
Type: [System.String][2]  
The local name of the CAEX element.

##### *creatorFunc*
Type: [System.Func][3]&lt;[XElement][4], [CAEXWrapper][5]>  
The function to create the CAEX wrapper.

#### Return Value
Type: [Boolean][6]  
trueif a function exists.

See Also
--------

#### Reference
[CAEXTypeDictionary Class][7]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.func-2
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[5]: ../CAEXWrapper/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png