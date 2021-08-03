AttributeTypeType.GetDouble Method
==================================
AutomationML 2.1 APIParse the Attribute Value string as double. If the string can not be parsed, a format exception is returned. This method uses the XmlConvert [ToDouble(String)][1] method and a fall back conversion, if the first conversion fails.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public double GetDouble()
```

#### Return Value
Type: [Double][3]  
Double.

Exceptions
----------

Exception            | Condition 
-------------------- | --------- 
[FormatException][4] |           


See Also
--------

#### Reference
[AttributeTypeType Class][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.xml.xmlconvert.todouble#System_Xml_XmlConvert_ToDouble_System_String_
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.double
[4]: https://docs.microsoft.com/dotnet/api/system.formatexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png