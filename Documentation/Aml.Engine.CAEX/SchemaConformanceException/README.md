SchemaConformanceException Class
================================
AutomationML 2.1 APIException for violations of the CAEX Schema. An example for a violation is the insertion of more than one RoleRequirement object into an InternalElement.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Exception][2]  
    [System.ApplicationException][3]  
      **Aml.Engine.CAEX.SchemaConformanceException**  

  **Namespace:**  [Aml.Engine.CAEX][4]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[SerializableAttribute]
public class SchemaConformanceException : ApplicationException
```


Constructors
------------

                 | Name                                               | Description                                                                                            
---------------- | -------------------------------------------------- | ------------------------------------------------------------------------------------------------------ 
![Public method] | [SchemaConformanceException()][5]                  | Initializes a new instance of the **SchemaConformanceException** class.                                
![Public method] | [SchemaConformanceException(String)][6]            | Initializes a new instance of the **SchemaConformanceException**-class with the defined error message. 
![Public method] | [SchemaConformanceException(String, Exception)][7] | Initializes a new instance of the **SchemaConformanceException** class.                                


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][4]  
[System.ApplicationException][3]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: https://docs.microsoft.com/dotnet/api/system.exception
[3]: https://docs.microsoft.com/dotnet/api/system.applicationexception
[4]: ../README.md
[5]: _ctor.md
[6]: _ctor_1.md
[7]: _ctor_2.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"