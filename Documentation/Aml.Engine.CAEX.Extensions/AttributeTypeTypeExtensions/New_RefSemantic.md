AttributeTypeTypeExtensions.New_RefSemantic Method
==================================================
AutomationML 2.1 APIAppends a new RefSemantic object with the defined semantics to the specified CAEX object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static RefSemanticType New_RefSemantic(
	this AttributeTypeType caexObject,
	string semantic
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.AttributeTypeType][2]  
The CAEX object

##### *semantic*
Type: [System.String][3]  
A string, defining some external defined semantic source.

#### Return Value
Type: [RefSemanticType][4]  
The new RefSemantic object
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [AttributeTypeType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AttributeTypeTypeExtensions Class][7]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeTypeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/RefSemanticType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png