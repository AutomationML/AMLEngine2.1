LookupService.IsMaster Method (InternalElementType)
===================================================
Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool IsMaster(
	InternalElementType internalElement
)
```

#### Parameters

##### *internalElement*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The InternalElement object.

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-InternalElement; otherwise, `false`. 
#### Implements
[IQuery.IsMaster(InternalElementType)][4]  


Exceptions
----------

Exception                  | Condition       
-------------------------- | --------------- 
[ArgumentNullException][5] | internalElement 


See Also
--------

#### Reference
[LookupService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/IsMaster_2.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png