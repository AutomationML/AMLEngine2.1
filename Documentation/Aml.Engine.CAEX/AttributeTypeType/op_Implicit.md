AttributeTypeType Implicit Conversion (AttributeTypeType to ObjectWithAMLAttributes)
====================================================================================
Conversion to get access to specific AutomationML defined Attributes

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static implicit operator ObjectWithAMLAttributes (
	AttributeTypeType attributeType
)
```

#### Parameters

##### *attributeType*
Type: [Aml.Engine.CAEX.AttributeTypeType][2]  
The 'AttributeType' CAEX object.

#### Return Value
Type: [ObjectWithAMLAttributes][3]  
 The AttributeType object, converted to an [ObjectWithAMLAttributes][3] type, which provides access to specific AML defined attributes. 

Exceptions
----------

Exception                  | Condition     
-------------------------- | ------------- 
[ArgumentNullException][4] | attributeType 


See Also
--------

#### Reference
[AttributeTypeType Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../../Aml.Engine.AmlObjects/ObjectWithAMLAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png