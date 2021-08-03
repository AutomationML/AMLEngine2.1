ExternalInterfaceType.HasInterfaceClassReference Method
=======================================================
AutomationML 2.1 APIDetermines whether this ExternalInterface object has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasInterfaceClassReference(
	InterfaceFamilyType interfaceClass,
	bool regardInheritance = false
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.InterfaceFamilyType][2]  
The InterfaceClass object.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this ExternalInterface object has an associated reference to the specified InterfaceClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][4] | interfaceClass 


See Also
--------

#### Reference
[ExternalInterfaceType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../InterfaceFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png