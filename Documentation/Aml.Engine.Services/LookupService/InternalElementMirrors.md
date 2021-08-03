LookupService.InternalElementMirrors Method
===========================================
AutomationML 2.1 APIReturns all Mirrors of the specified InternalElement

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<InternalElementType> InternalElementMirrors(
	InternalElementType master
)
```

#### Parameters

##### *master*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The master.

#### Return Value
Type: [IEnumerable][3]&lt;[InternalElementType][2]>  
 a collection of mirror InternalElements 
#### Implements
[IQuery.InternalElementMirrors(InternalElementType)][4]  


Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][5] | master    


See Also
--------

#### Reference
[LookupService Class][6]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/InternalElementMirrors.md
[5]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png