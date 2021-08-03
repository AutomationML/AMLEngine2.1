XmlSchemaElementInfo Class
==========================
This class defined methods and properties to access schema information for a schema element.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.Schema.XmlSchemaElementInfo**  

  **Namespace:**  [Aml.Engine.Schema][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class XmlSchemaElementInfo
```

The **XmlSchemaElementInfo** type exposes the following members.


Constructors
------------

                 | Name                      | Description                                        
---------------- | ------------------------- | -------------------------------------------------- 
![Public method] | [XmlSchemaElementInfo][3] | creates an instance for the defines schema element 


Properties
----------

                   | Name                    | Description                                                                 
------------------ | ----------------------- | --------------------------------------------------------------------------- 
![Public property] | [AllAttributes][4]      | Gets the schema elements for all attributes of this instance                
![Public property] | [Choices][5]            | Gets the names for all choices defined for this instance.                   
![Public property] | [MaxOccurrence][6]      | Gets the maximum occurrence.                                                
![Public property] | [Optional][7]           | Gets the names for all optional elements defined for this instance.         
![Public property] | [Required][8]           | Gets the names for all required elements defined for this instance.         
![Public property] | [RequiredAttributes][9] | Gets the names for all required attributes defined for this instance.       
![Public property] | [SchemaElement][10]     | Gets the defining schema element for this instance                          
![Public property] | [WithoutChoice][11]     | Gets the names of all elements in this instance which don't provide choices 


See Also
--------

#### Reference
[Aml.Engine.Schema Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: AllAttributes.md
[5]: Choices.md
[6]: MaxOccurrence.md
[7]: Optional.md
[8]: Required.md
[9]: RequiredAttributes.md
[10]: SchemaElement.md
[11]: WithoutChoice.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"