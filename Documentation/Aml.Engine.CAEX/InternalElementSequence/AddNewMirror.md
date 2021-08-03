InternalElementSequence.AddNewMirror Method
===========================================
AutomationML 2.1 APIAdds a new mirror InternalElement to this sequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public InternalElementType AddNewMirror(
	InternalElementType masterInternalElement
)
```

#### Parameters

##### *masterInternalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The master internal element.

#### Return Value
Type: [InternalElementType][2]  
 The newly created Mirror 

Exceptions
----------

Exception                  | Condition             
-------------------------- | --------------------- 
[ArgumentNullException][3] | masterInternalElement 


See Also
--------

#### Reference
[InternalElementSequence Class][4]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png