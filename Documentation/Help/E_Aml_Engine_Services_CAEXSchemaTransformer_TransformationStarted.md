# CAEXSchemaTransformer.TransformationStarted Event
AutomationML 2.1 API 

Raised from the ShemaTransform service when a transformation has started.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public event EventHandler<SchemaTransformationEventArgs> TransformationStarted
```

**VB**<br />
``` VB
Public Event TransformationStarted As EventHandler(Of SchemaTransformationEventArgs)
```

**C++**<br />
``` C++
public:
virtual  event EventHandler<SchemaTransformationEventArgs^>^ TransformationStarted {
	void add (EventHandler<SchemaTransformationEventArgs^>^ value);
	void remove (EventHandler<SchemaTransformationEventArgs^>^ value);
}
```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_Services_Interfaces_SchemaTransformationEventArgs">SchemaTransformationEventArgs</a>)

#### Implements
<a href="E_Aml_Engine_Services_Interfaces_ISchemaTransform_TransformationStarted">ISchemaTransform.TransformationStarted</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_CAEXSchemaTransformer">CAEXSchemaTransformer Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />