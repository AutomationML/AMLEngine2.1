SchemaTransformationEventArgs Class
===================================
AutomationML 2.1 APIEvent arguments for schema transformation events


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.EventArgs][2]  
    **Aml.Engine.Services.Interfaces.SchemaTransformationEventArgs**  

  **Namespace:**  [Aml.Engine.Services.Interfaces][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class SchemaTransformationEventArgs : EventArgs
```

The **SchemaTransformationEventArgs** type exposes the following members.


Constructors
------------

                 | Name                               | Description                                                                
---------------- | ---------------------------------- | -------------------------------------------------------------------------- 
![Public method] | [SchemaTransformationEventArgs][4] | Initializes a new instance of the **SchemaTransformationEventArgs** class. 


Properties
----------

                   | Name                | Description                       
------------------ | ------------------- | --------------------------------- 
![Public property] | [SourceDocument][5] | Gets the source document.         
![Public property] | [TargetDocument][6] | Gets or sets the target document. 
![Public property] | [TargetSchema][7]   | Gets the target schema.           


See Also
--------

#### Reference
[Aml.Engine.Services.Interfaces Namespace][3]  
[System.EventArgs][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: https://docs.microsoft.com/dotnet/api/system.eventargs
[3]: ../README.md
[4]: _ctor.md
[5]: SourceDocument.md
[6]: TargetDocument.md
[7]: TargetSchema.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"