ExternalDataReference.ExternalDataRoleClass Method (RoleClassLibType)
=====================================================================
AutomationML 2.1 APIGets the 'ExternalData' RoleClass from the AutomationMLBPRRoleClassLib.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static RoleFamilyType ExternalDataRoleClass(
	this RoleClassLibType automationMLBPRRoleClassLib
)
```

#### Parameters

##### *automationMLBPRRoleClassLib*
Type: [Aml.Engine.CAEX.RoleClassLibType][2]  
The AutomationMLBPRRoleClassLib.

#### Return Value
Type: [RoleFamilyType][3]  
The ExternalData RoleClass.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [RoleClassLibType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                   | Condition                                   
--------------------------- | ------------------------------------------- 
[NullReferenceException][6] | Couldn't locate the ExternalData role class 


See Also
--------

#### Reference
[ExternalDataReference Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/RoleClassLibType/README.md
[3]: ../../Aml.Engine.CAEX/RoleFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png