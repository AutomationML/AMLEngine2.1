IXMLWrapper Interface
=====================
AutomationML 2.1 APIXML related properties of a wrapped instance

  **Namespace:**  [Aml.Engine.XML][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public interface IXMLWrapper
```

The **IXMLWrapper** type exposes the following members.


Properties
----------

                   | Name          | Description                                                                                                                                                                                                            
------------------ | ------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public property] | [Document][2] | Gets the XDocument containing the XML node of this object. If the object has not been inserted into a document, the XDocument is `null`. Direct manipulations of the XML document are not monitored by the AML engine. 
![Public property] | [Exists][3]   | Determines, if this instance is wrapped around an existing XML node                                                                                                                                                    
![Public property] | [Node][4]     | Get the XML node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.                                                                                                           
![Public property] | [Owner][5]    | Gets the XML parent node of this instance. Direct manipulations of the XML node are not monitored by the AML engine.                                                                                                   
![Public property] | [TagName][6]  | Gets the Schema Tag name of this instance.                                                                                                                                                                             


See Also
--------

#### Reference
[Aml.Engine.XML Namespace][1]  

[1]: ../README.md
[2]: Document.md
[3]: Exists.md
[4]: Node.md
[5]: Owner.md
[6]: TagName.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"