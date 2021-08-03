CAEXSequenceExtension.OfInterfaceClass Method
=============================================
AutomationML 2.1 APIGets all ExternalInterfaces from the specified sequence, which are instances of a specific InterfaceClass

  **Namespace:**  [Aml.Engine.CAEX.Linq][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IEnumerable<ExternalInterfaceType> OfInterfaceClass(
	this ExternalInterfaceSequence sequence,
	InterfaceFamilyType interfaceClass
)
```

#### Parameters

##### *sequence*
Type: [Aml.Engine.CAEX.ExternalInterfaceSequence][2]  
The Sequence of External Interfaces

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][3]  
The required Interface Class

#### Return Value
Type: [IEnumerable][4]&lt;[ExternalInterfaceType][5]>  
External Interfaces which are instances of the defined class.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [ExternalInterfaceSequence][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[CAEXSequenceExtension Class][8]  
[Aml.Engine.CAEX.Linq Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceSequence/README.md
[3]: ../../Aml.Engine.CAEX/InterfaceFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png