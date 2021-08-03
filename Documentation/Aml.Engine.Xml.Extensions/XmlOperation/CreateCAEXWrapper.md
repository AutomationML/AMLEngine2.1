XmlOperation.CreateCAEXWrapper Method
=====================================
Wraps the provided Xml-Element into an element specific CAEXWrapper object.

  **Namespace:**  [Aml.Engine.Xml.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXWrapper CreateCAEXWrapper(
	this XElement element
)
```

#### Parameters

##### *element*
Type: [System.Xml.Linq.XElement][2]  
the Xml-Element

#### Return Value
Type: [CAEXWrapper][3]  
The specific CAEXWrapper object if the element is a CAEX element; otherwise null
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [XElement][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[XmlOperation Class][6]  
[Aml.Engine.Xml.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[3]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png