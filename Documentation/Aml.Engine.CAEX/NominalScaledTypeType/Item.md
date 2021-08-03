NominalScaledTypeType.Item Property
===================================
Gets the type-decoded value and sets the type-encoded value for the nominal value attribute with the defined value.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public Object this[
	string nominalValue
] { get; set; }
```

#### Parameters

##### *nominalValue*
Type: [System.String][2]  


#### Return Value
Type: [Object][3]  

#### Implements
[IAttributeValueType.Item[String]][4]  


Remarks
-------
 This indexer should only be used, if the list of nominal values contains distinct values only. 

See Also
--------

#### Reference
[NominalScaledTypeType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.object
[4]: ../IAttributeValueType/Item.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png