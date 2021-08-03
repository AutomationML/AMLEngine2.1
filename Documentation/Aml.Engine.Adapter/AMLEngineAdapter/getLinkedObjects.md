AMLEngineAdapter.getLinkedObjects Method
========================================


**Note: This API is now obsolete.**
Getting a List of LinkedObjects object of this SystemUnitClass containing references to the concrete referenced InternalElements via an InternalLink.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Direct enumeration of the InternalLink property is supported", 
	false)]
public static List<LinkedObjects> getLinkedObjects(
	this SystemUnitClassType systemUnitClass
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitClassType][2]  
The system unit class.

#### Return Value
Type: [List][3]&lt;[LinkedObjects][4]>  
 A list of linkedObjects for this SystemUnitClass. This list is empty if no InternalLink exists 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1
[4]: ../LinkedObjects/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png