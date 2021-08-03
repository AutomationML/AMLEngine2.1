CAEXSequenceExtension.OfRoleClass Method (CAEXSequence&lt;RoleRequirementsType>, RoleFamilyType)
================================================================================================
AutomationML 2.1 APIGets all RoleRequirements from the specified sequence, which are instances of a specific RoleClass

  **Namespace:**  [Aml.Engine.CAEX.Linq][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<RoleRequirementsType> OfRoleClass(
	this CAEXSequence<RoleRequirementsType> sequence,
	RoleFamilyType roleClass
)
```

#### Parameters

##### *sequence*
Type: [Aml.Engine.CAEX.CAEXSequence][2]&lt;[RoleRequirementsType][3]>  
The Sequence of Role Requirements

##### *roleClass*
Type: [Aml.Engine.CAEX.RoleFamilyType][4]  
The required Role Class

#### Return Value
Type: [IEnumerable][5]&lt;[RoleRequirementsType][3]>  
RoleRequirements which are instances of the defined class.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXSequence][2]&lt;[RoleRequirementsType][3]>. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[CAEXSequenceExtension Class][8]  
[Aml.Engine.CAEX.Linq Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXSequence_1/README.md
[3]: ../../Aml.Engine.CAEX/RoleRequirementsType/README.md
[4]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png