ObjectWithBaseClass.OverriddenElement Method
============================================
AutomationML 2.1 APIDetermines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static XElement OverriddenElement(
	this IClassWithBaseClassReference classWithBaseClass,
	string elementName,
	Type elementType
)
```

#### Parameters

##### *classWithBaseClass*
Type: [Aml.Engine.CAEX.IClassWithBaseClassReference][2]  
the base class containing the element

##### *elementName*
Type: [System.String][3]  
Name of the element.

##### *elementType*
Type: [System.Type][4]  
Type of the element.

#### Return Value
Type: [XElement][5]  
The overridden element if it exists; otherwise `null`.
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
[5]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png