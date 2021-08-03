LookupService.IsMaster Method (ExternalInterfaceType)
=====================================================
AutomationML 2.1 APIDetermines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool IsMaster(
	ExternalInterfaceType externalInterface
)
```

#### Parameters

##### *externalInterface*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The ExternalInterface element.

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-ExternalInterface; otherwise, `false`. 
#### Implements
[IQuery.IsMaster(ExternalInterfaceType)][4]  


Exceptions
----------

Exception                  | Condition         
-------------------------- | ----------------- 
[ArgumentNullException][5] | externalInterface 


See Also
--------

#### Reference
[LookupService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/IsMaster_1.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png