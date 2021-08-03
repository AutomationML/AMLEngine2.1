# ISchemaTransform.TransformationEnded Event
AutomationML 2.1 API 

Raised from the ShemaTransform service when a transformation has ended.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
event EventHandler<SchemaTransformationEventArgs> TransformationEnded
```

**VB**<br />
``` VB
Event TransformationEnded As EventHandler(Of SchemaTransformationEventArgs)
```

**C++**<br />
``` C++
 event EventHandler<SchemaTransformationEventArgs^>^ TransformationEnded {
	void add (EventHandler<SchemaTransformationEventArgs^>^ value);
	void remove (EventHandler<SchemaTransformationEventArgs^>^ value);
}
```


#### Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.eventhandler-1" target="_parent" rel="noopener noreferrer">System.EventHandler</a>(<a href="T_Aml_Engine_Services_Interfaces_SchemaTransformationEventArgs">SchemaTransformationEventArgs</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_ISchemaTransform">ISchemaTransform Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />