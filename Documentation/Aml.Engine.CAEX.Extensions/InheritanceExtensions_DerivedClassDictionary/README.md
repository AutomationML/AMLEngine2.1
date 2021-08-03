InheritanceExtensions.DerivedClassDictionary Class
==================================================
This class can be used to improve the performance of the [ClassIsDerivedFrom&lt;T>(CAEXDocument, String, String)][1] method. If your class library in the AML document is stable, it is possible to add the base classes, which are of interest, into the dictionary. After a class is registered, all derived classes of this class are fast accessible. If not longer needed or if the class library needs an update, the dictionary entries should be updated or removed.


Inheritance Hierarchy
---------------------
[System.Object][2]  
  [System.Collections.Generic.Dictionary][3]&lt;[String][4], [HashSet][5]&lt;[String][4]>>  
    **Aml.Engine.CAEX.Extensions.InheritanceExtensions.DerivedClassDictionary**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][6]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class DerivedClassDictionary : Dictionary<string, HashSet<string>>
```

The **InheritanceExtensions.DerivedClassDictionary** type exposes the following members.


Constructors
------------

                 | Name                                              | Description                                                                              
---------------- | ------------------------------------------------- | ---------------------------------------------------------------------------------------- 
![Public method] | [InheritanceExtensions.DerivedClassDictionary][7] | Initializes a new instance of the **InheritanceExtensions.DerivedClassDictionary** class 


Methods
-------

                 | Name                     | Description                                                                
---------------- | ------------------------ | -------------------------------------------------------------------------- 
![Public method] | [AddClassDerivations][8] | Adds the class derivations for the specified class path to the dictionary. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][6]  

[1]: ../InheritanceExtensions/ClassIsDerivedFrom__1.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.collections.generic.hashset-1
[6]: ../README.md
[7]: _ctor.md
[8]: AddClassDerivations.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"