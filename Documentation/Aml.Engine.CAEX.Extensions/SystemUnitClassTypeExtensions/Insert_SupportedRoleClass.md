SystemUnitClassTypeExtensions.Insert_SupportedRoleClass Method
==============================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserts the SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use SupportedRoleClass.Insert")]
public static void Insert_SupportedRoleClass(
	this SystemUnitClassType systemUnitClass,
	SupportedRoleClassType supportedRoleClassElement,
	bool asFirst = true
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The SystemUnitClass object

##### *supportedRoleClassElement*
Type: [Aml.Engine.CAEX.SupportedRoleClassType][3]  
The supported role class element.

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
Inserted at first position if set to `true`, otherwise appended at last position

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: ../../Aml.Engine.CAEX/SupportedRoleClassType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png