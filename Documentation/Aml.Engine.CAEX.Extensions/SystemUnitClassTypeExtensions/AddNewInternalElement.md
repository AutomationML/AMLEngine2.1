SystemUnitClassTypeExtensions.AddNewInternalElement Method
==========================================================
Creates a new InternalElement and inserts it after the last InternalElement of the parent if the elementName is unique among the child's. The ChangeMode is set to the Value 'Create'

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InternalElementType AddNewInternalElement(
	this SystemUnitClassType systemUnitClass,
	string elementName
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
 Parent of the new InternalElement

##### *elementName*
Type: [System.String][3]  
 Name of the new InternalElement

#### Return Value
Type: [InternalElementType][4]  
 the new InternalElement or null, if the elementName is not unique 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[SystemUnitClassTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png