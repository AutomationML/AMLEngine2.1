ExternalInterfaceType Implicit Conversion (ExternalInterfaceType to ObjectWithAMLAttributes)
============================================================================================
AutomationML 2.1 APIConversion to get access to specific AutomationML defined Attributes, assigned to the specified External Interface object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static implicit operator ObjectWithAMLAttributes (
	ExternalInterfaceType interfaceClass
)
```

#### Parameters

##### *interfaceClass*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The CAEX External Interface object.

#### Return Value
Type: [ObjectWithAMLAttributes][3]  
 The InterfaceClass object, converted to an [ObjectWithAMLAttributes][3] type, which provides access to specific AML defined attributes. 

Exceptions
----------

Exception                  | Condition      
-------------------------- | -------------- 
[ArgumentNullException][4] | interfaceClass 


See Also
--------

#### Reference
[ExternalInterfaceType Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../../Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png