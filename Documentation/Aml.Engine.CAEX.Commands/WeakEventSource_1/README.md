WeakEventSource&lt;TEventArgs> Class
====================================
AutomationML 2.1 APIThis Class defines a WeakEventSource, used to define Events, raised in the AML Engine.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.CAEX.Commands.WeakEventSource&lt;TEventArgs>**  

  **Namespace:**  [Aml.Engine.CAEX.Commands][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class WeakEventSource<TEventArgs>
where TEventArgs : EventArgs

```

#### Type Parameters

##### *TEventArgs*
The type of the event arguments.

The **WeakEventSource&lt;TEventArgs>** type exposes the following members.


Constructors
------------

                 | Name                                | Description                                                                 
---------------- | ----------------------------------- | --------------------------------------------------------------------------- 
![Public method] | [WeakEventSource&lt;TEventArgs>][3] | Initializes a new instance of the **WeakEventSource&lt;TEventArgs>** class. 


Methods
-------

                 | Name             | Description                                                
---------------- | ---------------- | ---------------------------------------------------------- 
![Public method] | [Raise][4]       | Raises an event, defined with this instance                
![Public method] | [Subscribe][5]   | Subscribes the specified handler with this event source.   
![Public method] | [Unsubscribe][6] | Unsubscribes the specified handler with this event source. 


See Also
--------

#### Reference
[Aml.Engine.CAEX.Commands Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: _ctor.md
[4]: Raise.md
[5]: Subscribe.md
[6]: Unsubscribe.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"