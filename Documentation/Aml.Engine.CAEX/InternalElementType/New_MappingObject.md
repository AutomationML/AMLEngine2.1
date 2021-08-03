InternalElementType.New_MappingObject Method
============================================
Adding a new MappingObject element to this InternalElement.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public MappingType New_MappingObject()
```

#### Return Value
Type: [MappingType][2]  
 The new MappingObject element if not existing, otherwise the existing. 

Exceptions
----------

Exception                       | Condition                                         
------------------------------- | ------------------------------------------------- 
[NullReferenceException][3]     | An InternalElement object doesn't exist!          
[SchemaConformanceException][4] | Raised if applied to CAEX 3.0 and later versions. 


Remarks
-------
 Only valid for CAEX 2.15. Don't use this method for later versions of CAEX. If used for later versions, a SchemaConformanceException is raised. 

See Also
--------

#### Reference
[InternalElementType Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../MappingType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.nullreferenceexception
[4]: ../SchemaConformanceException/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png