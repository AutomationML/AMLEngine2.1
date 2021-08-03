AMLEngineAdapter.getReferencedClass Method
==========================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Getting the XML Node for a class path.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use the FindByPath method from the CAEXDocument or the Services.ServiceLocator.QueryService.FindByPath method instead", 
	false)]
public static XElement getReferencedClass(
	this CAEXBasicObject caexObject,
	string referencedClassPath
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *referencedClassPath*
Type: [System.String][3]  
The full path to the referenced class. Hierarchies are separated via slash "/"

#### Return Value
Type: [XElement][4]  
 The XML Node of the desired class, or null if none found. Use FindFastByID for speed optimizations. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png