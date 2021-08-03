SystemUnitClassType.InsertAfter Method
======================================
Inserts the provided CAEX object as a new sibling after this CAEX object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual void InsertAfter(
	InternalElementType caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The CAEX object to be inserted.


Exceptions
----------

Exception                       | Condition                                                            
------------------------------- | -------------------------------------------------------------------- 
[ArgumentNullException][3]      | caexObject                                                           
[SchemaConformanceException][4] | The provided object is not allowed to be a sibling of this instance. 


See Also
--------

#### Reference
[SystemUnitClassType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[4]: ../SchemaConformanceException/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png