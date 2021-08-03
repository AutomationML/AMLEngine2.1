CAEXLibrary&lt;TLibItem>.InsertAfter Method
===========================================
AutomationML 2.1 APIInserts the provided CAEX object as a new sibling after this CAEX object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public void InsertAfter(
	CAEXLibrary<TLibItem> caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXLibrary][2]&lt;[TLibItem][2]>  
The CAEX object to be inserted.

#### Implements
[IMultipleOccurrences&lt;T>.InsertAfter(T)][3]  


Exceptions
----------

Exception                       | Condition                                                            
------------------------------- | -------------------------------------------------------------------- 
[ArgumentNullException][4]      | caexObject                                                           
[SchemaConformanceException][5] | The provided object is not allowed to be a sibling of this instance. 


See Also
--------

#### Reference
[CAEXLibrary&lt;TLibItem> Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: ../IMultipleOccurrences_1/InsertAfter.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: ../SchemaConformanceException/README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png