CAEXWrapper.GetXAttributeValue Method
=====================================
AutomationML 2.1 APIGets the value of the Xml-Attribute with the specified attribute name of the wrapped Xml-Element.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public string GetXAttributeValue(
	XName attributeName
)
```

#### Parameters

##### *attributeName*
Type: [System.Xml.Linq.XName][2]  
The name of the attribute.

#### Return Value
Type: [String][3]  
The attribute value if the attribute is defined, otherwise `null`.

See Also
--------

#### Reference
[CAEXWrapper Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png