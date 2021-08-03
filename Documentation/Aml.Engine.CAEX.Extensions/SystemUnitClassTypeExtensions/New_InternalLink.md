SystemUnitClassTypeExtensions.New_InternalLink Method
=====================================================
Inserts a new InternalLink as the first InternalLink if nothing else if explicit defined.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InternalLinkType New_InternalLink(
	this SystemUnitClassType systemUnitClass,
	string name,
	bool asFirst = true
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The SystemUnitClass object

##### *name*
Type: [System.String][3]  
The name of the InternalLink

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
if `true` insert at first InternalLink, otherwise at last InternalLink

#### Return Value
Type: [InternalLinkType][5]  
The new InternalLink element
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][8]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../../Aml.Engine.CAEX/InternalLinkType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png