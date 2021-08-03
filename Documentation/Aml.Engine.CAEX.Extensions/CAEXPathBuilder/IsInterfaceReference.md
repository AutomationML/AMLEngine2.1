CAEXPathBuilder.IsInterfaceReference Method
===========================================
AutomationML 2.1 APIDetermines, if the path is build using an interface separator. This method is able to distinguish if an interface separator char is used in an interface name and is escaped

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool IsInterfaceReference(
	string classReference
)
```

#### Parameters

##### *classReference*
Type: [System.String][2]  
The class reference.

#### Return Value
Type: [Boolean][3]  
`true`, if the provided class reference is an interface reference.

Remarks
-------
 This method should only be used for CAEXDocuments based on CAEX Version 2.15 

See Also
--------

#### Reference
[CAEXPathBuilder Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png