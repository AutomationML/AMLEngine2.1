CAEXPathBuilder.PathPart Method (XElement, Boolean)
===================================================
AutomationML 2.1 APItransforms the name of the defined element to a path Part (special characters are escaped).

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string PathPart(
	XElement element,
	bool useId = false
)
```

#### Parameters

##### *element*
Type: [System.Xml.Linq.XElement][2]  
 The element.

##### *useId* (Optional)
Type: [System.Boolean][3]  
 if set to `true` use the Elements ID, otherwise use its name.

#### Return Value
Type: [String][4]  
 System.String. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png