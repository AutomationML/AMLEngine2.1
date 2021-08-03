# CAEXDocument.LoadFromBinary Method 
AutomationML 2.1 API 

Loading a CAEX file from the specified Byte-Array.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static CAEXDocument LoadFromBinary(
	byte[] binary
)
```

**VB**<br />
``` VB
Public Shared Function LoadFromBinary ( 
	binary As Byte()
) As CAEXDocument
```

**C++**<br />
``` C++
public:
static CAEXDocument^ LoadFromBinary(
	array<unsigned char>^ binary
)
```


#### Parameters
&nbsp;<dl><dt>binary</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.byte" target="_parent" rel="noopener noreferrer">System.Byte</a>[]<br />The CAEX file to load</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a><br />A CAEXDocument containing the CAEX-Nodes

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />