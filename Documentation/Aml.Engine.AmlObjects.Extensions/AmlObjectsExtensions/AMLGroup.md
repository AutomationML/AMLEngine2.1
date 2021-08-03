AmlObjectsExtensions.AMLGroup Method
====================================
AutomationML 2.1 APIConverts an InternalElementType to an AMLGroup.

  **Namespace:**  [Aml.Engine.AmlObjects.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static AMLGroup AMLGroup(
	this InternalElementType internalElement
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The InternalElement object.

#### Return Value
Type: [AMLGroup][3]  
An AMLGroup object.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Remarks
-------
 The conversion doesn't create the AMLGroup if the internalElement is not an AMLGroup Use [Create(CAEXDocument, String)][6] method to create a Group. 

See Also
--------

#### Reference
[AmlObjectsExtensions Class][7]  
[Aml.Engine.AmlObjects.Extensions Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: ../../Aml.Engine.AmlObjects/AMLGroup/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: ../../Aml.Engine.AmlObjects/AMLGroup/Create.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png