# CAEXElementChangeMode Enumeration
AutomationML 2.1 API 

This enum defines possible changes of a CAEX object. The changes are notified in a ChangedEvent or a ChangingEvent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[FlagsAttribute]
public enum CAEXElementChangeMode
```

**VB**<br />
``` VB
<FlagsAttribute>
Public Enumeration CAEXElementChangeMode
```

**C++**<br />
``` C++
[FlagsAttribute]
public enum class CAEXElementChangeMode
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.None">**None**</td><td>0</td><td>empty mode</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.Added">**Added**</td><td>1</td><td>A CAEX object has been added.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.Deleting">**Deleting**</td><td>4</td><td>A CAEX object will be deleted.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.IDChanged">**IDChanged**</td><td>8</td><td>A CAEX object has got a changed ID attribute.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.IDChanging">**IDChanging**</td><td>16</td><td>A CAEX object will get a changed ID.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.IDRefChanged">**IDRefChanged**</td><td>32</td><td>A CAEX object has got a changed ID reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.IDRefChanging">**IDRefChanging**</td><td>64</td><td>A CAEX object will get a changed ID reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.NameChanged">**NameChanged**</td><td>128</td><td>A CAEX object has been renamed.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.NameChanging">**NameChanging**</td><td>256</td><td>A CAEX object will be renamed.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.NameRefChanged">**NameRefChanged**</td><td>512</td><td>A CAEX object has got a changed name reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.NameRefChanging">**NameRefChanging**</td><td>1024</td><td>A CAEX object will get a changed name reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.PathRefChanged">**PathRefChanged**</td><td>2048</td><td>A CAEX object has got a changed path reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.PathRefChanging">**PathRefChanging**</td><td>4096</td><td>A CAEX object will get a changed path reference.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.Deleted">**Deleted**</td><td>8192</td><td>A CAEX object has been deleted, the element in the change notification is the former parent of the deleted element. <a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXElement">CAEXElement</a>.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.ValueChanged">**ValueChanged**</td><td>16384</td><td>A CAEX object's value has been changed.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.ValueChanging">**ValueChanging**</td><td>32768</td><td>A CAEX object's value will change.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.Moving">**Moving**</td><td>65536</td><td>A CAEX object is moving to a new position in its collection.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.Moved">**Moved**</td><td>131072</td><td>A CAEX object has been moved to a new position in its collection.</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.ChangedEvent">**ChangedEvent**</td><td>158377</td><td>Combination of all defined changed mode events</td></tr><tr><td /><td target="F:Aml.Engine.CAEX.Commands.CAEXElementChangeMode.ChangingEvent">**ChangingEvent**</td><td>103764</td><td>Combination of all defined modes for changing events</td></tr></table>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />