SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles Method
==============================================================
Gets the supported Roles and the inherited roles from base classes.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static List<SupportedRoleClassType> GetDerivedSupportedRoles(
	this SystemUnitFamilyType systemUnitClass,
	bool includeOwn = true
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitFamilyType][2]  

[Missing &lt;param name="systemUnitClass"/> documentation for "M:Aml.Engine.CAEX.Extensions.SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles(Aml.Engine.CAEX.SystemUnitFamilyType,System.Boolean)"]


##### *includeOwn* (Optional)
Type: [System.Boolean][3]  

[Missing &lt;param name="includeOwn"/> documentation for "M:Aml.Engine.CAEX.Extensions.SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles(Aml.Engine.CAEX.SystemUnitFamilyType,System.Boolean)"]


#### Return Value
Type: [List][4]&lt;[SupportedRoleClassType][5]>  
List&lt;SupportedRoleClassType>.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitFamilyType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[SystemUnitFamilyTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[5]: ../../Aml.Engine.CAEX/SupportedRoleClassType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png