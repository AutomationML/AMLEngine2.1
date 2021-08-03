CAEXElementChangeMode Enumeration
=================================
AutomationML 2.1 APIThis enum defines possible changes of a CAEX object. The changes are notified in a **ChangedEvent** or a **ChangingEvent**.

  **Namespace:**  [Aml.Engine.CAEX.Commands][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
[FlagsAttribute]
public enum CAEXElementChangeMode
```


Members
-------

Member name         | Value  | Description                                                                                                                           
------------------- | ------ | ------------------------------------------------------------------------------------------------------------------------------------- 
**None**            | 0      | empty mode                                                                                                                            
**Added**           | 1      | A CAEX object has been added.                                                                                                         
**Deleting**        | 4      | A CAEX object will be deleted.                                                                                                        
**IDChanged**       | 8      | A CAEX object has got a changed ID attribute.                                                                                         
**IDChanging**      | 16     | A CAEX object will get a changed ID.                                                                                                  
**IDRefChanged**    | 32     | A CAEX object has got a changed ID reference.                                                                                         
**IDRefChanging**   | 64     | A CAEX object will get a changed ID reference.                                                                                        
**NameChanged**     | 128    | A CAEX object has been renamed.                                                                                                       
**NameChanging**    | 256    | A CAEX object will be renamed.                                                                                                        
**NameRefChanged**  | 512    | A CAEX object has got a changed name reference.                                                                                       
**NameRefChanging** | 1024   | A CAEX object will get a changed name reference.                                                                                      
**PathRefChanged**  | 2048   | A CAEX object has got a changed path reference.                                                                                       
**PathRefChanging** | 4096   | A CAEX object will get a changed path reference.                                                                                      
**Deleted**         | 8192   | A CAEX object has been deleted, the element in the change notification is the former parent of the deleted element. [CAEXElement][2]. 
**ValueChanged**    | 16384  | A CAEX object's value has been changed.                                                                                               
**ValueChanging**   | 32768  | A CAEX object's value will change.                                                                                                    
**Moving**          | 65536  | A CAEX object is moving to a new position in its collection.                                                                          
**Moved**           | 131072 | A CAEX object has been moved to a new position in its collection.                                                                     
**ChangedEvent**    | 158377 | Combination of all defined changed mode events                                                                                        
**ChangingEvent**   | 103764 | Combination of all defined modes for changing events                                                                                  


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands Namespace][1]  

[1]: ../README.md
[2]: ../CAEXElementChangeEventArgs/CAEXElement.md
[3]: https://www.automationml.org
[4]: ../../icons/logoShade.png