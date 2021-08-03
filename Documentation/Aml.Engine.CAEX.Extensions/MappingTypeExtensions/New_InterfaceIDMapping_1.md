MappingTypeExtensions.New_InterfaceIDMapping Method (MappingType, String, String)
=================================================================================
Adding a new InterfaceIDMapping to the defined Mapping object. An InterfaceIDMapping allows the definition of the mapping between Interfaces of corresponding RoleClasses and SystemUnitClasses.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InterfaceIDMappingType New_InterfaceIDMapping(
	this MappingType mappingObject,
	string systemUnitInterfaceID,
	string roleInterfaceID
)
```

#### Parameters

##### *mappingObject*
Type: [Aml.Engine.CAEX.MappingType][2]  
The Mapping object

##### *systemUnitInterfaceID*
Type: [System.String][3]  
The ID of the interface in the SystemUnitClass

##### *roleInterfaceID*
Type: [System.String][3]  
The ID of the interface in the RoleClass

#### Return Value
Type: [InterfaceIDMappingType][4]  
The new InterfaceIDMapping element
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [MappingType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Remarks
-------
Use of this method is restricted to CAEX Version 3.0 and above.

See Also
--------

#### Reference
[MappingTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/MappingType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/InterfaceIDMappingType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png