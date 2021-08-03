AMLEngineAdapter.AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects Method
======================================================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
This Method assigns new GUIds to the SystemUnitClass and its subordinate Children, which have an ID. The References to the old IDs in Mirrors and InternalLinks are redirected to the new ID. If a Reference is not found in any of the subordinate Elements, the Reference will not be changed.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Make a copy instead and replace the existing class using the copy", 
	true)]
public static void AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects(
	this SystemUnitClassType systemUnitClass,
	bool includeSystemUnitClasses = false
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The system unit class.

##### *includeSystemUnitClasses* (Optional)
Type: [System.Boolean][3]  
if set to `true` [include system unit classes].

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
 If you want an assignment of new GUIDs with updated references, make a copy of the SystemUnitClass and replace the old class with the new class. 

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png