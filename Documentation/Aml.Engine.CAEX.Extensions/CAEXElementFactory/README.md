CAEXElementFactory Class
========================
AutomationML 2.1 APIFactory to create CAEX-Elements according to a provided Type.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Extensions.CAEXElementFactory**  

  **Namespace:**  [Aml.Engine.CAEX.Extensions][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class CAEXElementFactory
```


Methods
-------

                                 | Name                              | Description                                                                                                                                                                                                                                
-------------------------------- | --------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [Create(CAEXDocument, String)][3] | Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used. 
![Public method]![Static member] | [Create&lt;T>(CAEXDocument)][4]   | Factory method to create a new CAEX object in the provided CAEX document. The CAEX element is derived from the specified CAEX object Type. To insert the new CAEX object into the document an appropriate insertion method has to be used. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Extensions Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: Create.md
[4]: Create__1.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"