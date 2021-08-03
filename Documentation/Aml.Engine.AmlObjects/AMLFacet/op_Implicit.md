AMLFacet Implicit Conversion (AMLFacet to ObjectWithAMLAttributes)
==================================================================
AutomationML 2.1 APIConversion to get access to specific AutomationML defined Attributes

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static implicit operator ObjectWithAMLAttributes (
	AMLFacet facet
)
```

#### Parameters

##### *facet*
Type: [Aml.Engine.AmlObjects.AMLFacet][2]  
The 'AMLFacet' CAEX object.

#### Return Value
Type: [ObjectWithAMLAttributes][3]  
 The AMLFacet object, converted to an [ObjectWithAMLAttributes][3] type, which provides access to specific AML defined attributes. 

Exceptions
----------

Exception                  | Condition     
-------------------------- | ------------- 
[ArgumentNullException][4] | attributeType 


See Also
--------

#### Reference
[AMLFacet Class][2]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../ObjectWithAMLAttributes/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png