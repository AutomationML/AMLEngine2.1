ReferenceElement Class
======================
AutomationML 2.1 APIReferenceElement is a Tuple of an XElement and the Name of an Attributes, which is used to reference another Element. The reference may be used as a key to find the referenced Element.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Tuple][2]&lt;[XElement][3], [String][4]>  
    **Aml.Engine.Services.ReferenceElement**  

  **Namespace:**  [Aml.Engine.Services][5]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public class ReferenceElement : Tuple<XElement, string>, 
	ICAEXReference
```

The **ReferenceElement** type exposes the following members.


Properties
----------

                   | Name                         | Description                                                  
------------------ | ---------------------------- | ------------------------------------------------------------ 
![Public property] | [CaexObject][6]              | Gets the CAEX object which owns the reference.               
![Public property] | [Element][7]                 | Gets the XML node.                                           
![Public property] | [ReferenceAttributeName][8]  | Gets the name of the reference attribute of the [Element][7] 
![Public property] | [ReferenceAttributeValue][9] | gets the value of the Reference Attribute                    


Methods
-------

                 | Name              | Description                                                                                                                
---------------- | ----------------- | -------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [Equals][10]      | Determines whether the specified [Object][1] is equal to this instance. (Overrides [Tuple&lt;T1, T2>.Equals(Object)][11].) 
![Public method] | [GetHashCode][12] | Returns a hash code for this instance. (Overrides [Tuple&lt;T1, T2>.GetHashCode()][13].)                                   


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][5]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: https://docs.microsoft.com/dotnet/api/system.tuple-2
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../README.md
[6]: CaexObject.md
[7]: Element.md
[8]: ReferenceAttributeName.md
[9]: ReferenceAttributeValue.md
[10]: Equals.md
[11]: https://docs.microsoft.com/dotnet/api/system.tuple-2.equals#System_Tuple_2_Equals_System_Object_
[12]: GetHashCode.md
[13]: https://docs.microsoft.com/dotnet/api/system.tuple-2.gethashcode#System_Tuple_2_GetHashCode
[14]: https://www.automationml.org
[15]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"