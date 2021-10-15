InheritanceExtensions Class
===========================
Extension methods to navigate the inheritance relations


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.InheritanceExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class InheritanceExtensions
```

The **InheritanceExtensions** type exposes the following members.


Properties
----------

                                   | Name                | Description                                                                                                                              
---------------------------------- | ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- 
![Public property]![Static member] | [DerivedClasses][3] | Gets the dictionary of derived classes. The dictionary has to be filled manually [AddClassDerivations(CAEXDocument, String, String)][4]. 


Methods
-------

                                 | Name                                                                                                  | Description                                                                                                                                                                                                                                                                                                                                                                                                        
-------------------------------- | ----------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [ChangeNameAndReferences&lt;T>][5]                                                                    | Changes the name of the CAEX class and all the references to the class in the whole CAEX document.                                                                                                                                                                                                                                                                                                                 
![Public method]![Static member] | [ClassIsDerivedFrom&lt;T>(IClassWithBaseClassReference&lt;T>, IClassWithBaseClassReference&lt;T>)][6] | Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the specified base class or identical to it. This method can be used, if the classes are distributed over different CAEX documents, the documents should be referenced by external references and alias references.                                                                                     
![Public method]![Static member] | [ClassIsDerivedFrom&lt;T>(IClassWithBaseClassReference&lt;T>, String)][7]                             | Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the external referenced document.                              
![Public method]![Static member] | [ClassIsDerivedFrom&lt;T>(CAEXDocument, String, String)][8]                                           | Determines, if the class, specified with the given class path is directly or indirectly (across multiple generations) a descendant of the class or identical to it, which is uniquely identified with the specified baseClass path. The base class path or the referenced class path may contain alias identifiers. If alias identifiers are present, the method tries to load the externally referenced document. 
![Public method]![Static member] | [CopyTreeAndChangeReferences&lt;T>][9]                                                                | Creates a copy of the source class and all its child classes and assigns the provided name to the copy. Including references to objects in the original class tree are redirected to objects in the copied tree. The copy is inserted into the provided parent object.                                                                                                                                             
![Public method]![Static member] | [CreateClassInstance&lt;T>][10]                                                                       | Creates a class instance of the CAEX class and assigns the name to the instance.                                                                                                                                                                                                                                                                                                                                   
![Public method]![Static member] | [IsDerivedFromAttributeType][11]                                                                      | Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias.                                                                                                                                                                                                               
![Public method]![Static member] | [IsDerivedFromInterfaceClass][12]                                                                     | Determines whether the specified interface class has an inheritance relation from the interface class, uniquely identifiable by the given interface class path. The interface class path may contain an alias.                                                                                                                                                                                                     
![Public method]![Static member] | [IsDerivedFromRoleClass][13]                                                                          | Determines whether the specified role reference defines an inheritance relation from the role, uniquely identifiable by the given role class path. The role class path may contain an alias.                                                                                                                                                                                                                       


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: DerivedClasses.md
[4]: ../InheritanceExtensions_DerivedClassDictionary/AddClassDerivations.md
[5]: ChangeNameAndReferences__1.md
[6]: ClassIsDerivedFrom__1_1.md
[7]: ClassIsDerivedFrom__1_2.md
[8]: ClassIsDerivedFrom__1.md
[9]: CopyTreeAndChangeReferences__1.md
[10]: CreateClassInstance__1.md
[11]: IsDerivedFromAttributeType.md
[12]: IsDerivedFromInterfaceClass.md
[13]: IsDerivedFromRoleClass.md
[14]: https://www.automationml.org
[15]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Static member]: ../../icons/static.gif "Static member"
[Public method]: ../../icons/pubmethod.gif "Public method"