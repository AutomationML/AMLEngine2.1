ObjectWithBaseClass Class
=========================
AutomationML 2.1 APIExtensions for all classes which implement the [IClassWithBaseClassReference][1] interface.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.CAEX.Extensions.ObjectWithBaseClass**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ObjectWithBaseClass
```

The **ObjectWithBaseClass** type exposes the following members.


Methods
-------

                                 | Name                                                    | Description                                                                                                                                                                                                                                                                                                                                             
-------------------------------- | ------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [DeleteInheritedElement][4]                             | Deletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted".                                                                                            
![Public method]![Static member] | [GetDerivedAttributes][5]                               | Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.                                                                                                            
![Public method]![Static member] | [GetDerivedInterfaces][6]                               | Gets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overwritten, only the last defined is contained.                                                                                    
![Public method]![Static member] | [GetInheritedAttributes][7]                             | Gets a collection of Attribute objects that are inherited from base classes. The own attributes are included in the enumeration.                                                                                                                                                                                                                        
![Public method]![Static member] | [GetInheritedAttributesAndDescendants][8]               | Gets a list of Attribute objects that are inherited from base classes. The List will also contain the elements own Attribute objects, if the parameter is set (default). If an Attribute is overwritten, only the last defined is contained.                                                                                                            
![Public method]![Static member] | [GetInheritedElements][9]                               | Gets a collection of InternalElement objects that are inherited from base classes. As default, the own InternalElements are included in the enumeration.                                                                                                                                                                                                
![Public method]![Static member] | [GetInheritedInterfaces][10]                            | Gets a collection of ExternalInterface objects that are inherited from base classes.                                                                                                                                                                                                                                                                    
![Public method]![Static member] | [GetInheritedInterfacesAndDescendants][11]              | Gets a list of ExternalInterface objects that are inherited from base classes. The List will also contain the elements own ExternalInterface objects, if the parameter is set (default). If an ExternalInterface is overridden, only the last defined is contained. The result also contains the nested interface descendants of an external interface. 
![Public method]![Static member] | [InheritedElements&lt;TInheritedElement>][12]           | Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes.                                                                                                                                                                                                                                                 
![Public method]![Static member] | [IsInherited][13]                                       | Determines, if the specified element is an inherited element. To be an inherited element, it has to be an AttributeType, ExternalInterfaceType or InternalElementType element.                                                                                                                                                                          
![Public method]![Static member] | [IsOverridden][14]                                      | Determines, if an element of a class with an inheritance relation to a base class is an overridden element, what means a base class contains an element which is considered as equal to the provided element. In most cases, equality is defined by equality of the element names.                                                                      
![Public method]![Static member] | [OverriddenElement][15]                                 | Determines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName.                                                                                                              
![Public method]![Static member] | [ReferencedClassName(IClassWithBaseClassReference)][16] | Name of the referenced Class without path information.                                                                                                                                                                                                                                                                                                  
![Public method]![Static member] | [ReferencedClassName(InterfaceClassType)][17]           | Name of the referenced InterfaceClass without path information.                                                                                                                                                                                                                                                                                         
![Public method]![Static member] | [ReferencedClassName(InternalElementType)][18]          | Name of the referenced SystemUnitClass without path information.                                                                                                                                                                                                                                                                                        


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][3]  

[1]: ../../Aml.Engine.CAEX/IClassWithBaseClassReference/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: DeleteInheritedElement.md
[5]: GetDerivedAttributes.md
[6]: GetDerivedInterfaces.md
[7]: GetInheritedAttributes.md
[8]: GetInheritedAttributesAndDescendants.md
[9]: GetInheritedElements.md
[10]: GetInheritedInterfaces.md
[11]: GetInheritedInterfacesAndDescendants.md
[12]: InheritedElements__1.md
[13]: IsInherited.md
[14]: IsOverridden.md
[15]: OverriddenElement.md
[16]: ReferencedClassName.md
[17]: ReferencedClassName_1.md
[18]: ReferencedClassName_2.md
[19]: https://www.automationml.org
[20]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"