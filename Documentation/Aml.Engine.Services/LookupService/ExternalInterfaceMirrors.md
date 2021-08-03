LookupService.ExternalInterfaceMirrors Method
=============================================
AutomationML 2.1 APIReturns all Mirrors of the specified ExternalInterface

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ExternalInterfaceType> ExternalInterfaceMirrors(
	ExternalInterfaceType master
)
```

#### Parameters

##### *master*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The master.

#### Return Value
Type: [IEnumerable][3]&lt;[ExternalInterfaceType][2]>  
 An enumeration of mirror ExternalInterface objects 
#### Implements
[IQuery.ExternalInterfaceMirrors(ExternalInterfaceType)][4]  


Exceptions
----------

Exception                    | Condition 
---------------------------- | --------- 
[NotImplementedException][5] |           


See Also
--------

#### Reference
[LookupService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/ExternalInterfaceMirrors.md
[5]: https://docs.microsoft.com/dotnet/api/system.notimplementedexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png