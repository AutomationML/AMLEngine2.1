ObjectWithAttributes Class
==========================
AutomationML 2.1 APIExtension methods for all objects with Attribute collections.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.ObjectWithAttributes**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ObjectWithAttributes
```

The **ObjectWithAttributes** type exposes the following members.


Methods
-------

                                                | Name                                                                                                 | Description                                                                                                                                                                                                               
----------------------------------------------- | ---------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member]![Code example] | [AddAttributeTypeReference(IObjectWithAttributes, AttributeFamilyType, Boolean, Boolean, String)][3] | Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a [AttributeType][4] object.                                                 
![Public method]![Static member]![Code example] | [AddAttributeTypeReference(IObjectWithAttributes, String, Boolean, Boolean, String)][5]              | Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a [AttributeType][4] object.                       
![Public method]![Static member]                | [CopyAttributesFrom][6]                                                                              | Copies all attribute of the source object with attributes to the target object including children                                                                                                                         
![Public method]![Static member]                | [GetAttribute][7]                                                                                    | **Obsolete.**Gets the first attribute with the specified name from the attribute collection of the CAEX object.                                                                                                           
![Public method]![Static member]                | [New_Attribute][8]                                                                                   | Appends a new Attribute object with the defined name to the specified CAEX object.                                                                                                                                        
![Public method]![Static member]                | [SetAttributeValue(IObjectWithAttributes, String, Double)][9]                                        | Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double 
![Public method]![Static member]                | [SetAttributeValue(IObjectWithAttributes, String, String)][10]                                       | Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created.                                                          
![Public method]![Static member]                | [SetAttributeValue(IObjectWithAttributes, String, String, String, String)][11]                       | Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.                                         
![Public method]![Static member]                | [SetAttributeValue(IObjectWithAttributes, String, Double, Double, String, String)][12]               | Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double 
![Public method]![Static member]                | [SetAttributeValue(IObjectWithAttributes, String, String, String, String, String, String)][13]       | Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.                                         


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AddAttributeTypeReference.md
[4]: ../../Aml.Engine.CAEX/AttributeType/README.md
[5]: AddAttributeTypeReference_1.md
[6]: CopyAttributesFrom.md
[7]: GetAttribute.md
[8]: New_Attribute.md
[9]: SetAttributeValue.md
[10]: SetAttributeValue_2.md
[11]: SetAttributeValue_3.md
[12]: SetAttributeValue_1.md
[13]: SetAttributeValue_4.md
[14]: https://www.automationml.org
[15]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Code example]: ../../icons/CodeExample.png "Code example"