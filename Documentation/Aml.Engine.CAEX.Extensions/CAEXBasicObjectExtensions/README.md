CAEXBasicObjectExtensions Class
===============================
This class provides extension methods for all types of CAEX objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.CAEXBasicObjectExtensions**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class CAEXBasicObjectExtensions
```

The **CAEXBasicObjectExtensions** type exposes the following members.


Methods
-------

                                 | Name                                                          | Description                                                                                                                                                      
-------------------------------- | ------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AMLSchemaManager][3]                                         | Gets the associated CAEX schema manager of the CAEX object.                                                                                                      
![Public method]![Static member] | [Ancestors&lt;T>][4]                                          | Finds the ancestors of the provided CAEX object which have the given type.                                                                                       
![Public method]![Static member] | [CAEXDocument][5]                                             | Gets the CAEX document which contains this CAEX object.                                                                                                          
![Public method]![Static member] | [CAEXFile][6]                                                 | Gets the CAEX file which contains this CAEX object.                                                                                                              
![Public method]![Static member] | [CAEXSchema][7]                                               | Gets the associated CAEX schema of the CAEX object.                                                                                                              
![Public method]![Static member] | [CreateCaexWrapper&lt;T>][8]                                  | Creates a CAEX object of the given type from the specified XML element.                                                                                          
![Public method]![Static member] | [Descendants(CAEXWrapper, Type)][9]                           | Finds the descendants of the provided CAEX object which are of the given type.                                                                                   
![Public method]![Static member] | [Descendants&lt;T>(CAEXWrapper)][10]                          | Finds the descendants of the provided CAEX object which are of the given type.                                                                                   
![Public method]![Static member] | [Descendants&lt;T>(ICAEXWrapper, Boolean)][11]                | Finds the descendants of the provided CAEX object which are of the given type.                                                                                   
![Public method]![Static member] | [FindCaexObjectFromId&lt;T>][12]                              | Finds the CAEX object with the specified id and the specified Type.                                                                                              
![Public method]![Static member] | [FindReferencedClass&lt;T>][13]                               | Finds the CAEX object with the specified CAEX path and the specified Type.                                                                                       
![Public method]![Static member] | [FirstAncestor(ICAEXWrapper, Predicate&lt;ICAEXWrapper>)][14] | Finds the first ancestor of the specified CAEX object which fulfils the specified predicate                                                                      
![Public method]![Static member] | [FirstAncestor(ICAEXWrapper, String)][15]                     | Finds the first ancestor of the specified CAEX object with the given Tag name                                                                                    
![Public method]![Static member] | [FirstAncestor&lt;T>(ICAEXWrapper)][16]                       | Finds the first ancestor of the specified CAEX object in the given Type.                                                                                         
![Public method]![Static member] | [GetParent&lt;T>][17]                                         | Tries to get a CAEX parent with the specified Type of the provided caexObject. If the parent is not assignable to the provided type, the result is `null`.       
![Public method]![Static member] | [Library][18]                                                 | Gets the Library which contains this CAEX object.                                                                                                                
![Public method]![Static member] | [Name][19]                                                    | Gets a names for the specified CAEX wrapper object. If the specified object is a [CAEXObject][20], the Name is returned; otherwise the TagName of the CAEX item. 
![Public method]![Static member] | [New_Copyright][21]                                           | Adds an new Copyright node to this object if it doesn't exists.                                                                                                  
![Public method]![Static member] | [New_Description][22]                                         | Adds an new Description node to this object if it doesn't exists.                                                                                                
![Public method]![Static member] | [New_Version][23]                                             | Adds an new Version node to this object if it doesn't exists.                                                                                                    


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AMLSchemaManager.md
[4]: Ancestors__1.md
[5]: CAEXDocument.md
[6]: CAEXFile.md
[7]: CAEXSchema.md
[8]: CreateCaexWrapper__1.md
[9]: Descendants.md
[10]: Descendants__1.md
[11]: Descendants__1_1.md
[12]: FindCaexObjectFromId__1.md
[13]: FindReferencedClass__1.md
[14]: FirstAncestor.md
[15]: FirstAncestor_1.md
[16]: FirstAncestor__1.md
[17]: GetParent__1.md
[18]: Library.md
[19]: Name.md
[20]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[21]: New_Copyright.md
[22]: New_Description.md
[23]: New_Version.md
[24]: https://www.automationml.org
[25]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"