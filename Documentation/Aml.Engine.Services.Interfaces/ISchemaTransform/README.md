ISchemaTransform Interface
==========================
AutomationML 2.1 APIThis interface class defines a service interface for a schema transformation service

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface ISchemaTransform : IAMLService
```

The **ISchemaTransform** type exposes the following members.


Methods
-------

                 | Name             | Description                                                                                                                                            
---------------- | ---------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [TransformTo][2] | Method to do a schema transformation for the provided document to the defined schema. This method can be used for upward and downward transformations. 


Events
------

                | Name                       | Description                                                               
--------------- | -------------------------- | ------------------------------------------------------------------------- 
![Public event] | [TransformationEnded][3]   | Raised from the ShemaTransform service when a transformation has ended.   
![Public event] | [TransformationStarted][4] | Raised from the ShemaTransform service when a transformation has started. 


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.IAMLService][5]  

[1]: ../README.md
[2]: TransformTo.md
[3]: TransformationEnded.md
[4]: TransformationStarted.md
[5]: ../IAMLService/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public event]: ../../icons/pubevent.gif "Public event"