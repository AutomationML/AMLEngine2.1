AMLEngineAdapter.New_RoleRequirements Method (InternalElementType, String)
==========================================================================


**Note: This API is now obsolete.**
Adding a new RoleRequirements element to this InternalElement using the defined roleClassPath. It is only allowed to add one RoleRequirements node in CAEX 2.15.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use AddRoleClassReference Method instead.", false)]
public static RoleRequirementsType New_RoleRequirements(
	this InternalElementType internalElement,
	string roleClassPath
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The internal element.

##### *roleClassPath*
Type: [System.String][3]  
The role class path.

#### Return Value
Type: [RoleRequirementsType][4]  
 RoleRequirementsType. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/RoleRequirementsType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png