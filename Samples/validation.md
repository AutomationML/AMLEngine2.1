# Document Validation

This topic contains the following sections:
<ul>
<li><a href="#validating-a-document">Validating a document</a></li>
<li><a href="#repair-a-validated-document">Repair a validated document</a></li>    
<li><a href="#validation-of-names-and-ids">Validation of Names and IDs</a></li>
<li><a href="#see-also">See Also</a></li>
</ul>

To validate a document, a service, which implements the
[IValidator](../Documentation/Aml.Engine.Services.Interfaces/IValidator_1/README.md)
interface has to be used. The Aml.Engine currently contains one implementation of this interface, 
the [ValidatorService](../Documentation/Aml.Engine.Services/ValidatorService/README.md). 
If validation issues are detected, also possible repair options are included in the validation result. See 
the [ValidationElement](../Documentation/Aml.Engine.Services/ValidationElement/README.md) 
class, which information is included in the validation result.

## Validating a document

This example show, how a document can be validated and how the obtained result can be read using extension methods, defined in
[ValidationResults](../Documentation/Aml.Engine.Services/ValidationResults/README.md)

**Validate document**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

void ValidateDocument (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    // document validation
    var validationResult = service.ValidateAll();

    // filter results, get all ID references which are not OK.
    var idReferenceValidationResult = validationResult.IDReferenceValidationResults();

    // filter results, get all Path references which are not OK.
    var pathReferenceValidationResult = validationResult.PathReferenceValidationResults();

    ValidatorService.UnRegister();
}
```

[Back to the Top](#Document-Validation)

## Repair a validated document

This example is about repair IDs in a validated document.


**Repair IDs**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;

void ValidateDocument (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    // document validation
    var validationResult = service.ValidateAll();

    // filter results, get all IDs which are repairable.
    var idValidationResult = validationResult.IDValidationResults().Where(v => v.AvailableRepairOptions != RepairTypeEnum.None).ToList();

    idValidationResult.ForEach((e) => service.Repair(e));

    ValidatorService.UnRegister();
}
```

[Back to the Top](#Document-Validation)

## Validation of Names and IDs

These examples explain, how to validate a single ID or Name which should be assigned to an element.

**Validate a name**<br />
``` C#
using Aml.Engine.Services;
using Aml.Engine.CAEX;

void ValidateName (CAEXDocument document)
{
    // registration of the validation service
    var service = ValidatorService.Register();

    var insHierarchy1 = document.CAEXFile.InstanceHierarchy.Append();

    insHierarchy1.Name = "InsHierarchy";
    result = _service.NameValidation(insHierarchy1, "InsHierarchy");
    Assert.IsTrue(result.IsValid);

    var insHierarchy2 = document.CAEXFile.InstanceHierarchy.Append("");

    // it is not allowed, to assign the same name to another InstanceHierarchy
    result = _service.NameValidation(insHierarchy2, "InsHierarchy");
    Assert.IsFalse(result.IsValid);


    // it is possible to register a UniqueNameService. The Aml.Engine recognizes, if such a service is present and
    // will automatically assign unique names to all generated or inserted objects.

    Console.WriteLine (result.Message);
}
```

[Back to the Top](#Document-Validation)


## See Also

#### Reference
- [NameValidation](../Documentation/Aml.Engine.Services/ValidatorService/NameValidation.md)
- [UniqueNameService](../Documentation/Aml.Engine.Services/UniqueNameService/README.md)
