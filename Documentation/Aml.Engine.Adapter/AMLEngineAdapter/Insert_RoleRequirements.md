AMLEngineAdapter.Insert_RoleRequirements Method
===============================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Inserting a RoleRequirement to this InternalElement. An exception is thrown if a RoleRequirements is already existent.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use Insert Method instead", false)]
public static void Insert_RoleRequirements(
	this InternalElementType internalElement,
	RoleRequirementsType roleRequirement
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The internal element.

##### *roleRequirement*
Type: [Aml.Engine.CAEX.RoleRequirementsType][3]  
The RoleRequirement to insert

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                       | Condition                                                                                                                                             
------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- 
[SchemaConformanceException][6] | A RoleRequirements node is already existent. It is not allowed to add more than one RoleRequirements node to current element according to CAEX Schema 


See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: ../../Aml.Engine.CAEX/RoleRequirementsType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: ../../Aml.Engine.CAEX/SchemaConformanceException/README.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png