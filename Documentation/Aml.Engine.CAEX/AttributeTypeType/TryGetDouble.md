AttributeTypeType.TryGetDouble Method
=====================================
AutomationML 2.1 APITries to parse the Attribute Value string as double. This method uses the XmlConvert [ToDouble(String)][1] method and a fall back conversion, if the first conversion fails.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool TryGetDouble(
	out double doubleValue
)
```

#### Parameters

##### *doubleValue*
Type: [System.Double][3]  
The double value.

#### Return Value
Type: [Boolean][4]  
`true` if success, `false` otherwise.

See Also
--------

#### Reference
[AttributeTypeType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.double
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png