ExternalDataReference.AddDocumentElement Method
===============================================
Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class [ExternalDataRoleClassPath][1] or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the [ExternalDataRoleClassPath][1] no document element is added (returns null).

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InternalElementType AddDocumentElement(
	this SystemUnitClassType internalElement,
	string name,
	string externalDataRoleClassPath = "AutomationMLBPRRoleClassLib/ExternalData"
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.SystemUnitClassType][3]  
 The internalElement.

##### *name*
Type: [System.String][4]  
 The name of the document element.

##### *externalDataRoleClassPath* (Optional)
Type: [System.String][4]  
 The Role class path to a role class, derived from the ExternalData Role Class [ExternalDataRoleClassPath][1]

#### Return Value
Type: [InternalElementType][5]  
 created InternalElementType document element or `null` if the role class is invalid 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [SystemUnitClassType][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

See Also
--------

#### Reference
[ExternalDataReference Class][8]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ExternalDataRoleClassPath.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png