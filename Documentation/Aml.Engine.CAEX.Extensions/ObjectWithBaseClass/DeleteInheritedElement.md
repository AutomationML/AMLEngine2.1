ObjectWithBaseClass.DeleteInheritedElement Method
=================================================
AutomationML 2.1 APIDeletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted".

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool DeleteInheritedElement(
	this IClassWithBaseClassReference classWithBaseClass,
	string elementName,
	Type elementType
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]  
The class with base class.

##### *elementName*
Type: [System.String][3]  
Name of the element which should be deleted.

##### *elementType*
Type: [System.Type][4]  
Type of the element which should be deleted.

#### Return Value
Type: [Boolean][5]  
true, if an inherited property was found and could be deleted; otherwise false.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IClassWithBaseClassReference][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ObjectWithBaseClass Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.type
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png