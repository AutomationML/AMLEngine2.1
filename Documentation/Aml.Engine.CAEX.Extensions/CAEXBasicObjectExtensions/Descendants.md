CAEXBasicObjectExtensions.Descendants Method (CAEXWrapper, Type)
================================================================
Finds the descendants of the provided CAEX object which are of the given type.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<CAEXBasicObject> Descendants(
	this CAEXWrapper caexObject,
	Type caexType
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][2]  
The CAEX object.

##### *caexType*
Type: [System.Type][3]  
CAEX element type of the descendants.

#### Return Value
Type: [IEnumerable][4]&lt;[CAEXBasicObject][5]>  
 The descendants of the CAEX object which are of the given type. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXWrapper][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][8] | caexObject 


See Also
--------

#### Reference
[CAEXBasicObjectExtensions Class][9]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.type
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png