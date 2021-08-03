AMLEngineAdapter.getReferencedInterfaceName Method
==================================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Getting the name of the referenced Interface.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use CAEXPathBuilder.ExternalInterfaceNameInInternalLinkReference")]
public static string getReferencedInterfaceName(
	this CAEXBasicObject caexObject,
	string reference
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *reference*
Type: [System.String][3]  
A reference to a interface class in form GUID:InterfaceClass

#### Return Value
Type: [String][3]  
 The name of the referenced interface class or string.empty if separator char not found in string 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[AMLEngineAdapter Class][6]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png