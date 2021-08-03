ExternalDataReference.AddDocumentElementRole Method
===================================================
Add a role reference to a external data role class or derived role class defined with the given role class path as a supported role class to the internal element. If the specified role class path can not be identified as a derived role from the [ExternalDataRoleClassPath][1] no role reference is added (returns false).

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static bool AddDocumentElementRole(
	this InternalElementType internalElement,
	string externalDataRoleClassPath
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][3]  
The internalElement.

##### *externalDataRoleClassPath*
Type: [System.String][4]  
path to the role class

#### Return Value
Type: [Boolean][5]  
 true, if a supported role class with the defined path is added `false` if the role class is invalid 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][3]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][6] or [Extension Methods (C# Programming Guide)][7].

Exceptions
----------

Exception                   | Condition                                     
--------------------------- | --------------------------------------------- 
[NullReferenceException][8] | InternalElement not contained in CAEXDocument 


See Also
--------

#### Reference
[ExternalDataReference Class][9]  
[Aml.Engine.AmlObjects Namespace][2]  

[1]: ExternalDataRoleClassPath.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[7]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[8]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png