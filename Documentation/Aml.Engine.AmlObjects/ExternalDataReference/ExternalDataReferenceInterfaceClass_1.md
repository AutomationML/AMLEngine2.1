ExternalDataReference.ExternalDataReferenceInterfaceClass Method (InterfaceClassLibType)
========================================================================================
Gets the ExternalDataReference InterfaceClass from the AutomationMLBPRInterfaceClassLib.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static InterfaceFamilyType ExternalDataReferenceInterfaceClass(
	this InterfaceClassLibType automationMLBPRInterfaceClassLib
)
```

#### Parameters

##### *automationMLBPRInterfaceClassLib*
Type: [Aml.Engine.CAEX.InterfaceClassLibType][2]  
The AutomationMLBPRInterfaceClassLib.

#### Return Value
Type: [InterfaceFamilyType][3]  
The 'ExternalDataReference' InterfaceClass.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [InterfaceClassLibType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

Exceptions
----------

Exception                   | Condition                                                                                                        
--------------------------- | ---------------------------------------------------------------------------------------------------------------- 
[ArgumentNullException][6]  | automationMLBPRInterfaceClassLib                                                                                 
[NullReferenceException][7] | Couldn't locate the ExternalDataReference InterfaceClass or Couldn't locate the CAEX file of the InterfaceClass. 


See Also
--------

#### Reference
[ExternalDataReference Class][8]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InterfaceClassLibType/README.md
[3]: ../../Aml.Engine.CAEX/InterfaceFamilyType/README.md
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png