# Advanced document processing using services

These code examples explain the application of services from the Aml.Engine.



### Advanced AML document processing using services.
<ol>
<li id="Loading">
        
Registration of a [LookupService](../Documentation/Aml.Engine.Services/LookupService/README.md) to locate CAEX objects using  an identifier.
        

**C#**<br />
``` C#
using Aml.Engine.CAEX;
using Aml.Engine.Services;
using Aml.Engine.AmlObjects;

// Create a new document.
var document = CAEXDocument.New_Document ();

// Add the standard AutomationML InterfaceClass library to this document.
AutomationMLInterfaceClassLibType.InterfaceClassLib(document);

// Locate a specific interface class from that library using the default query service.
var interfaceClass = document.FindByPath (AutomationMLInterfaceClassLib.InterlockingVariableInterface);

// Use the Lookup service for the same query
LookupService.Register();

// After registration of the Lookup service, all queries are automatically transferred to the Lookup service.
// There is no need to change any method calls. The Lookup service performs faster but needs additional
// memory space to maintain the lookup tables.
var interfaceClass = document.FindByPath (AutomationMLInterfaceClassLib.InterlockingVariableInterface);
```

</li>
<li id="Transformation">
        
Transformation of an AML document to a higher version using the [CAEXSchemaTransformer](../Documentation/Aml.Engine.Services/CAEXSchemaTransformer/README.md).

        

**C#**<br />
``` C#
using Aml.Engine.CAEX;
using Aml.Engine.Services;

// load your AML file based on AutomationML 2.0 and CAEX 2.15
var document = CAEXDocument.LoadFromFile ("myAutomationML20.aml", true);

// register the transformation service. After registration of the service, the AMLEngine
// communicates with the transformation service via event notification.
var transformer = CAEXSchemaTransformer.Register();

// transform the document to AutomationML 2.10 and CAEX 3.0
var newDocV3 = transformer.TransformTo(document, CAEXDocument.CAEXSchema.CAEX3_0);

// unregister the transformation service. The communication channel between the AMLEngine and
// the transformation service is closed.
CAEXSchemaTransformer.UnRegister();

// validate the document according to the assigned CAEX version
if (newDocV3.Validate (out var message))
        Console.Writeline ("Transformation success!");
else
        Console.Writeline ("Transformation failed! See the returned message for details.");
```
</li>
</ol>

## See Also


#### Other Resources
[Basic examples](basic.md)

[Document validation](validation.md)
