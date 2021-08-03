FrameValues Class
=================
A frame holds position information of an object. The object position is defined by values for x, y and z axis as well as rotation values rx,ry and rz in degree, for the x, y and z axis.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.FrameValues**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class FrameValues : INotifyPropertyChanged
```

The **FrameValues** type exposes the following members.


Constructors
------------

                 | Name                                                             | Description                                                            
---------------- | ---------------------------------------------------------------- | ---------------------------------------------------------------------- 
![Public method] | [FrameValues()][3]                                               | Creating a new FrameValues object with initially all values set to 0.0 
![Public method] | [FrameValues(Double, Double, Double, Double, Double, Double)][4] | Creating a new FrameValues object with the given frame values          


Properties
----------

                   | Name    | Description          
------------------ | ------- | -------------------- 
![Public property] | [Rx][5] | Gets or sets the rx. 
![Public property] | [Ry][6] | Gets or sets the ry. 
![Public property] | [Rz][7] | Gets or sets the rz. 
![Public property] | [X][8]  | Gets or sets the x.  
![Public property] | [Y][9]  | Gets or sets the y.  
![Public property] | [Z][10] | Gets or sets the z.  


Events
------

                | Name                  | Description                     
--------------- | --------------------- | ------------------------------- 
![Public event] | [PropertyChanged][11] | occurs, when a property changed 


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: _ctor_1.md
[5]: Rx.md
[6]: Ry.md
[7]: Rz.md
[8]: X.md
[9]: Y.md
[10]: Z.md
[11]: PropertyChanged.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public event]: ../../icons/pubevent.gif "Public event"