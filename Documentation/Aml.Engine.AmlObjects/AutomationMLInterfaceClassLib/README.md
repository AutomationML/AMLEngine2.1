AutomationMLInterfaceClassLib Class
===================================
AutomationML 2.1 APIContains definitions and access methods of standard base InterfaceClass objects.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.AutomationMLInterfaceClassLib**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class AutomationMLInterfaceClassLib
```

The **AutomationMLInterfaceClassLib** type exposes the following members.


Methods
-------

                                 | Name                                      | Description                                                                                                                                                                                            
-------------------------------- | ----------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ 
![Public method]![Static member] | [IsAutomationMLBaseInterface][3]          | Determines whether the specified interface class is derived from the AutomationMLBase interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                  
![Public method]![Static member] | [IsBehaviourLogicInterface][4]            | Determines whether the specified interface class is derived from the BehaviourLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.           
![Public method]![Static member] | [IsCOLLADAInterface][5]                   | Determines whether the specified interface class is derived from the COLLADAInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                  
![Public method]![Static member] | [IsCommunicationInterface][6]             | Determines whether the specified interface class is derived from the Communication interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                     
![Public method]![Static member] | [IsExternalDataConnector][7]              | Determines whether the specified interface class is derived from the ExternalDataConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy.             
![Public method]![Static member] | [IsInterlockingConnector][8]              | Determines whether the specified interface class is derived from the InterlockingConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy.             
![Public method]![Static member] | [IsInterlockingLogicInterface][9]         | Determines whether the specified interface class is derived from the InterlockingLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.        
![Public method]![Static member] | [IsInterlockingVariableInterface][10]     | Determines whether the specified interface class is derived from the InterlockingVariableInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.     
![Public method]![Static member] | [IsLogicElementInterface][11]             | Determines whether the specified interface class is derived from the LogicElementInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.             
![Public method]![Static member] | [IsLogicInterface][12]                    | Determines whether the specified interface class is derived from the LogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                    
![Public method]![Static member] | [IsOrderInterface][13]                    | Determines whether the specified interface class is derived from the Order interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                             
![Public method]![Static member] | [IsPLCopenXMLInterface][14]               | Determines whether the specified interface class is derived from the PLCopenXMLInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.               
![Public method]![Static member] | [IsPortConnector][15]                     | Determines whether the specified interface class is derived from the PortConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                     
![Public method]![Static member] | [IsPPRConnector][16]                      | Determines whether the specified interface class is derived from the PPRConnector interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                      
![Public method]![Static member] | [IsSequencingBehaviourLogicInterface][17] | Determines whether the specified interface class is derived from the SequencingBehaviourLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy. 
![Public method]![Static member] | [IsSequencingLogicInterface][18]          | Determines whether the specified interface class is derived from the SequencingLogicInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.          
![Public method]![Static member] | [IsSignalInterface][19]                   | Determines whether the specified interface class is derived from the SignalInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                   
![Public method]![Static member] | [IsVariableInterface][20]                 | Determines whether the specified interface class is derived from the VariableInterface interface class. The method can resolve alias references anywhere in the inheritance hierarchy.                 
![Public method]![Static member] | [MakeAutomationMLBaseInterface][21]       | Makes the AutomationML base interface.                                                                                                                                                                 
![Public method]![Static member] | [MakeCOLLADAInterface][22]                | Makes the COLLADA interface.                                                                                                                                                                           
![Public method]![Static member] | [MakeCommunicationInterface][23]          | Makes the communication interface.                                                                                                                                                                     
![Public method]![Static member] | [MakeExternalDataConnector][24]           | Makes the external data connector.                                                                                                                                                                     
![Public method]![Static member] | [MakeInterlockingConnector][25]           | Makes the interlocking connector.                                                                                                                                                                      
![Public method]![Static member] | [MakeOrderInterface][26]                  | Makes the order interface.                                                                                                                                                                             
![Public method]![Static member] | [MakePLCopenXMLInterface][27]             | Makes the PLCopen XML interface.                                                                                                                                                                       
![Public method]![Static member] | [MakePortConnector][28]                   | Makes the port connector.                                                                                                                                                                              
![Public method]![Static member] | [MakePPRConnector][29]                    | Makes the PPR connector.                                                                                                                                                                               
![Public method]![Static member] | [MakeSignalInterface][30]                 | Makes the signal interface.                                                                                                                                                                            


Fields
------

                                | Name                                    | Description                                                              
------------------------------- | --------------------------------------- | ------------------------------------------------------------------------ 
![Public field]![Static member] | [AttachmentInterface][31]               | The AttachmentInterface class path (a Part 3 Interface)                  
![Public field]![Static member] | [AutomationMLBaseInterface][32]         | The AutomationML base interface class path (a Part 1 Interface)          
![Public field]![Static member] | [AutomationMLInterfaceClassLibName][33] | The AutomationML base interface class library name                       
![Public field]![Static member] | [BehaviourLogicInterface][34]           | The behaviour logic interface class path (a Part 4 Interface)            
![Public field]![Static member] | [COLLADAInterface][35]                  | The COLLADA interface class path (a Part 1 Interface)                    
![Public field]![Static member] | [Communication][36]                     | The communication interface class path (a Part 1 Interface)              
![Public field]![Static member] | [ExternalDataConnector][37]             | The external data connector (a Part 1 Interface)                         
![Public field]![Static member] | [InterlockingConnector][38]             | The interlocking connector interface class path (a Part 1 Interface)     
![Public field]![Static member] | [InterlockingLogicInterface][39]        | The interlocking logic interface class path (a Part 4 Interface)         
![Public field]![Static member] | [InterlockingVariableInterface][40]     | The interlocking variable interface class path (a Part 4 Interface)      
![Public field]![Static member] | [LogicElementInterface][41]             | The logic element interface class path (a Part 4 Interface)              
![Public field]![Static member] | [LogicInterface][42]                    | The logic interface class path (a Part 4 Interface)                      
![Public field]![Static member] | [Order][43]                             | The order interface class path (a Part 1 Interface)                      
![Public field]![Static member] | [PLCopenXMLInterface][44]               | The PLCopenXML interface class path (a Part 1 Interface)                 
![Public field]![Static member] | [PortConnector][45]                     | The port connector interface class path (a Part 1 Interface)             
![Public field]![Static member] | [PPRConnector][46]                      | The PPR connector interface class path (a Part 1 Interface)              
![Public field]![Static member] | [SequencingBehaviourLogicInterface][47] | The sequencing behaviour logic interface class path (a Part 4 Interface) 
![Public field]![Static member] | [SequencingLogicInterface][48]          | The sequencing logic interface class path (a Part 4 Interface)           
![Public field]![Static member] | [SignalInterface][49]                   | The signal interface class path (a Part 1 Interface)                     
![Public field]![Static member] | [VariableInterface][50]                 | The variable interface class path (a Part 4 Interface)                   


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: IsAutomationMLBaseInterface.md
[4]: IsBehaviourLogicInterface.md
[5]: IsCOLLADAInterface.md
[6]: IsCommunicationInterface.md
[7]: IsExternalDataConnector.md
[8]: IsInterlockingConnector.md
[9]: IsInterlockingLogicInterface.md
[10]: IsInterlockingVariableInterface.md
[11]: IsLogicElementInterface.md
[12]: IsLogicInterface.md
[13]: IsOrderInterface.md
[14]: IsPLCopenXMLInterface.md
[15]: IsPortConnector.md
[16]: IsPPRConnector.md
[17]: IsSequencingBehaviourLogicInterface.md
[18]: IsSequencingLogicInterface.md
[19]: IsSignalInterface.md
[20]: IsVariableInterface.md
[21]: MakeAutomationMLBaseInterface.md
[22]: MakeCOLLADAInterface.md
[23]: MakeCommunicationInterface.md
[24]: MakeExternalDataConnector.md
[25]: MakeInterlockingConnector.md
[26]: MakeOrderInterface.md
[27]: MakePLCopenXMLInterface.md
[28]: MakePortConnector.md
[29]: MakePPRConnector.md
[30]: MakeSignalInterface.md
[31]: AttachmentInterface.md
[32]: AutomationMLBaseInterface.md
[33]: AutomationMLInterfaceClassLibName.md
[34]: BehaviourLogicInterface.md
[35]: COLLADAInterface.md
[36]: Communication.md
[37]: ExternalDataConnector.md
[38]: InterlockingConnector.md
[39]: InterlockingLogicInterface.md
[40]: InterlockingVariableInterface.md
[41]: LogicElementInterface.md
[42]: LogicInterface.md
[43]: Order.md
[44]: PLCopenXMLInterface.md
[45]: PortConnector.md
[46]: PPRConnector.md
[47]: SequencingBehaviourLogicInterface.md
[48]: SequencingLogicInterface.md
[49]: SignalInterface.md
[50]: VariableInterface.md
[51]: https://www.automationml.org
[52]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public field]: ../../icons/pubfield.gif "Public field"