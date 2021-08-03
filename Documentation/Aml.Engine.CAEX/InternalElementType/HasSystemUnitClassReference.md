InternalElementType.HasSystemUnitClassReference Method
======================================================
AutomationML 2.1 APIDetermines whether this InternalElement object has an associated reference to the specified SystemUnitClass. If inheritance relations between systemUnitClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified SystemUnitClass is either identical to a referenced SystemUnitClass or a referenced SystemUnitClass is derived from the specified SystemUnitClass.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool HasSystemUnitClassReference(
	SystemUnitFamilyType systemUnitClass,
	bool regardInheritance = false
)
```

#### Parameters

##### *systemUnitClass*
Type: [Aml.Engine.CAEX.SystemUnitFamilyType][2]  
The SystemUnitClass object.

##### *regardInheritance* (Optional)
Type: [System.Boolean][3]  
 if set to `true` inheritance relations are regarded (default is `false`).

#### Return Value
Type: [Boolean][3]  
`true` if this InternalElement object has an associated reference to the specified SystemUnitClass; otherwise, `false`. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | roleClass 


See Also
--------

#### Reference
[InternalElementType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../SystemUnitFamilyType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png