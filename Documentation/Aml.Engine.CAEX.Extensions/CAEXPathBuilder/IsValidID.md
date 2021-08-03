CAEXPathBuilder.IsValidID Method
================================
Determines whether the specified string can represent an ID

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsValidID(
	string idString,
	CAEXDocument document = null
)
```

#### Parameters

##### *idString*
Type: [System.String][2]  
The identifier string.

##### *document* (Optional)
Type: [Aml.Engine.CAEX.CAEXDocument][3]  

[Missing &lt;param name="document"/> documentation for "M:Aml.Engine.CAEX.Extensions.CAEXPathBuilder.IsValidID(System.String,Aml.Engine.CAEX.CAEXDocument)"]


#### Return Value
Type: [Boolean][4]  
`true` if the specified identifier string can be used as an identifier; otherwise, `false`. 

Remarks
-------
 This method should only be used for testing strings which are retrieved from an attribute where an ID is a valid value. It is not possible to distinguish a Name from an ID, because it exists neither a defined syntax for object names nor for object IDs. Only if the UUID format is used to represent an ID the ID format is recognized. 

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png