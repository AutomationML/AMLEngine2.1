AMLEngineAdapter.CloneNode Method
=================================
AutomationML 2.1 API

**Note: This API is now obsolete.**
Clones the node.

  **Namespace:**  [Aml.Engine.Adapter][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[ObsoleteAttribute("Use CAEXWrapper.Copy.")]
public static CAEXWrapper CloneNode(
	this CAEXBasicObject caexObject,
	bool deepClone,
	bool assignNewGuidsToIEs
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *deepClone*
Type: [System.Boolean][3]  
if set to `true` [deep clone].

##### *assignNewGuidsToIEs*
Type: [System.Boolean][3]  
if set to `true` [assign new GUIDs to IEs].

#### Return Value
Type: [CAEXWrapper][4]  
 The cloned node CAEXWrapper. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [CAEXBasicObject][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

See Also
--------

#### Reference
[AMLEngineAdapter Class][7]  
[Aml.Engine.Adapter Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png