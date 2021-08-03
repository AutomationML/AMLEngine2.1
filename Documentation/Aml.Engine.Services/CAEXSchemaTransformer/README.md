CAEXSchemaTransformer Class
===========================
AutomationML 2.1 APIThis class defines a service for a schema transformation. The service supports transformation of CAEX documents from CAEX Version 2.15 to version 3.0 and back. Backwards transformation can result in a loss of information.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Services.CAEXSchemaTransformer**  

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class CAEXSchemaTransformer : ISchemaTransform, 
	IAMLService
```

The **CAEXSchemaTransformer** type exposes the following members.


Methods
-------

                                 | Name             | Description                                                                                                                                            
-------------------------------- | ---------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [Register][3]    | Registration of a new [ISchemaTransform][4]                                                                                                            
![Public method]                 | [TransformTo][5] | Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations. 
![Public method]![Static member] | [UnRegister][6]  | Unregisters this service                                                                                                                               


Events
------

                | Name                       | Description                                                               
--------------- | -------------------------- | ------------------------------------------------------------------------- 
![Public event] | [TransformationEnded][7]   | Raised from the ShemaTransform service when a transformation has ended.   
![Public event] | [TransformationStarted][8] | Raised from the ShemaTransform service when a transformation has started. 


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][2]  
[Aml.Engine.Services.Interfaces.ISchemaTransform][4]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: Register.md
[4]: ../../Aml.Engine.Services.Interfaces/ISchemaTransform/README.md
[5]: TransformTo.md
[6]: UnRegister.md
[7]: TransformationEnded.md
[8]: TransformationStarted.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public event]: ../../icons/pubevent.gif "Public event"