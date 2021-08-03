RoleClassType Implicit Conversion (RoleClassType to ObjectWithAMLAttributes)
============================================================================
Conversion to get access to specific AutomationML defined Attributes

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static implicit operator ObjectWithAMLAttributes (
	RoleClassType caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.RoleClassType][2]  
The CAEX object.

#### Return Value
Type: [ObjectWithAMLAttributes][3]  
 The result of the conversion. 

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][4] | caexObject 


See Also
--------

#### Reference
[RoleClassType Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../../Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png