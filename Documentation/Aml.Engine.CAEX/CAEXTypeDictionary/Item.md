CAEXTypeDictionary.Item Property
================================
AutomationML 2.1 APIGets or sets the data type associated with the specified key.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public Type this[
	string caexTagName
] { get; }
```

#### Parameters

##### *caexTagName*
Type: [System.String][2]  
 The key. The caexTagName is concatenated with the "Type" extension, to match a Type name of a CAEX wrapper class.

#### Return Value
Type: [Type][3]  
Type.

See Also
--------

#### Reference
[CAEXTypeDictionary Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.type
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png