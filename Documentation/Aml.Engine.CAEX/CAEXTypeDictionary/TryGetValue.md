CAEXTypeDictionary.TryGetValue Method
=====================================
AutomationML 2.1 APITries to get the value.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool TryGetValue(
	string caexTagName,
	out Type t
)
```

#### Parameters

##### *caexTagName*
Type: [System.String][2]  
Name of the CAEX tag.

##### *t*
Type: [System.Type][3]  
The type.

#### Return Value
Type: [Boolean][4]  
`true` if type is registered, `false` otherwise.

See Also
--------

#### Reference
[CAEXTypeDictionary Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.type
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png