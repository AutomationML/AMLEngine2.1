ExternalDataReference.AddDocumentReference Method
=================================================
Adds a document with the specified external reference interface to the document element. If the given internal element is not a document element or the defined class path to the external reference interface is not derived from the standard base class no interface is added.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InterfaceClassType AddDocumentReference(
	this InternalElementType documentElement,
	string referenceName,
	string externalDataReferenceInterfaceClassPath = "AutomationMLBPRInterfaceClassLib/ExternalDataReference"
)
```

#### Parameters

##### *documentElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The document element.

##### *referenceName*
Type: [System.String][3]  
The name for the referencing interface.

##### *externalDataReferenceInterfaceClassPath* (Optional)
Type: [System.String][3]  
The external data reference interface class path.

#### Return Value
Type: [InterfaceClassType][4]  
 The InterfaceClass which is created as a reference to the external data. 
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InternalElementType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][5] or [Extension Methods (C# Programming Guide)][6].

Exceptions
----------

Exception                   | Condition                                  
--------------------------- | ------------------------------------------ 
[NullReferenceException][7] | Element is not contained in a CAEXDocument 


See Also
--------

#### Reference
[ExternalDataReference Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: ../../Aml.Engine.CAEX/InterfaceClassType/README.md
[5]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[6]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[7]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png