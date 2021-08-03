MappingTypeExtensions.Insert_InterfaceNameMapping Method
========================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Appends the InterfaceNameMapping object to the defined Mapping object

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use mappingObject.Insert instead")]
public static void Insert_InterfaceNameMapping(
	this MappingType mappingObject,
	InterfaceNameMappingType interfaceNameMapping
)
```

#### Parameters

##### *mappingObject*
Type: [Aml.Engine.CAEX.MappingType][2]  
The Mapping object

##### *interfaceNameMapping*
Type: [Aml.Engine.CAEX.InterfaceNameMappingType][3]  
The interface name mapping.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [MappingType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
Use of this method is restricted to CAEX Version 2.15.

See Also
--------

#### Reference
[MappingTypeExtensions Class][6]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/MappingType/README.md
[3]: ../../Aml.Engine.CAEX/InterfaceNameMappingType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png