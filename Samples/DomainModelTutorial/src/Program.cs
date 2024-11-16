#nullable disable

using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Resources.Files;
using Aml.Engine.Services;
using Aml.Engine.Services.LibraryService;

namespace Aml.Engine.DomainModel.Tutorial;

internal class Program
{
    // This is the path to identify an AutomationComponent roleClass
    // The path is build from the Component RoleClassLib name and the RoleClass name.
    // Identification of any class instance is only possible, as long as the library name and class name is not changed.
    const string AutomationComponentPath = @"AutomationMLComponentStandardRCL/AutomationComponent";

    static void Main(string[] args)
    {
        // 1. create a new aml document containing an external reference to the AutomationComponent libraries
        string document = null;

        Task.Run(async () =>
        {
            document = await AMLDomainModelTutorial();
        }).GetAwaiter().GetResult();


        if (document == null)
        {
            Console.WriteLine("Failed to create a document");
            return;
        }

        // 2. interpret the instance hierarchy in the document as an importer would do
        ImportAMLDocument(document);
    }

    // This method uses the created AmlDocument fom step 1 and imports the contained instances which are identified
    private static void ImportAMLDocument(string document)
    {
        var importedDocument = CAEXDocument.LoadFromFile(document);

        if (importedDocument == null)
        {
            Console.WriteLine("Failed to load the created document");
            return;
        }

        // importing all instances which are recognized as AutomationComponents. Note, that the external reference resolver is not needed
        // to identify the instances as components. The Aml.Engine is able to find the referenced external AutomationComponent role class.
        foreach (var instance in importedDocument.InstanceHierarchy[0])
        {
            if (IsAutomationComponent(instance))
            {
                Console.WriteLine($"{instance.Name} is recognized as an AutomationComponent and can be imported!");
            }
            else
            {
                Console.WriteLine($"{instance.Name} is not recognized as an AutomationComponent and is skipped!");
            }
        }
    }


    // determines, if an instance is an automation component
    private static bool IsAutomationComponent(InternalElementType instance)
    {
        // Check the instance semantic
        if (!instance.HasRoleClassReference(AutomationComponentPath, true))
        {
            Console.WriteLine($"{instance.Name} not identified as {AutomationComponentPath}");
            return false;
        }
        return true;
    }

    // the domain model tutorial
    private static async Task<string> AMLDomainModelTutorial()
    {   
        
        // 1. A new empty caex 2.15 document is created
        using var mainDocument = CAEXDocument.New_CAEXDocument(CAEXDocument.CAEXSchema.CAEX2_15);

        // 2. External references to the Automation component model documents are inserted, using the AMLFileService
        await AddComponentModelDocumentsAsExternalReferences(mainDocument);

        // 3. When classes from external documents are used, the ExternalReferenceResolver service is needed. This
        // service can load the external document from the external reference and can recognize, if a class is contained
        // in an external document or defined in the main document.
        ExternalReferenceResolver.Register();

        // 4. The external document containing the 'AutomationComponent' RoleClass is loaded. To identify the
        // 'AutomationComponent' RoleClass the CAEXPath of the class is used as an identifier.
        var automationComponent = GetAutomationComponent(mainDocument, AutomationComponentPath);

        if (automationComponent == null)
        {
            Console.WriteLine($"{AutomationComponentPath} not found");
            return null;
        }

        // 5. A new SystemUnitClass Library is created defining an AutomationComponent Class
        CreateAutomationProduct (mainDocument, automationComponent);

        // 6. Creating an instances of the created product
        var myProject = mainDocument.InstanceHierarchy.Append("AutomationProject");

        // 7. Create an instance of the product
        var driveInstance = myProject.InternalElement.Insert(mainDocument.SystemUnitClassLib[0]["Drive"].CreateClassInstance("drive 23") as InternalElementType);

        // 8. Check the instance semantic
        if (!driveInstance.HasRoleClassReference(AutomationComponentPath, true))
        {
            Console.WriteLine($"{driveInstance.Name} not identified as {AutomationComponentPath}");
            return null;
        }

        var tempFile = Path.GetTempFileName();

        mainDocument.SaveToFile(tempFile);

        // 8. The ExternalReferenceResolver is unregistered
        ExternalReferenceResolver.UnRegister();

        return tempFile;
    }

    // creation of some sample components
    private static void CreateAutomationProduct(CAEXDocument mainDocument, RoleFamilyType automationComponent)
    {        
        // create a new library named according to the library naming conventions
        var productLib = mainDocument.SystemUnitClassLib.Append(AMLLibraryModel.LibraryName("MyDrive", "Products", AMLLibraryTypeEnum.SystemUnitClass));

        var drive = productLib.SystemUnitClass.Append($"Drive");

        // Add a supportedRoleClass referencing the provided automationComponent roleClass
        // The RoleReference will be created using the alias to the external document. The alias can be resolved
        // by the Engine using the registered ExternalReferenceResolver service
        drive.AddRoleClassReference(automationComponent);        
    }

    // the caex document providing the desired role class is loaded and the AutomationComponent role class is returned 
    private static RoleFamilyType GetAutomationComponent(CAEXDocument mainDocument, string roleClassPath)
    {
        RoleFamilyType automationComponent = null;
        foreach (var externalReference in mainDocument.CAEXFile.ExternalReference)
        {
            // the registered ExternalReferenceResolver is used to load the external
            var (Document, Message) = ServiceLocator.ExternalReferenceResolverService.LoadOrGetReferencedDocument(externalReference);
            if (Document != null)
            {
                automationComponent = Document.FindByPath(roleClassPath) as RoleFamilyType;
                if (automationComponent != null)
                {                    
                    break;
                }
            }
        }        
        
        return automationComponent;
    }


    // add the automation component model libraries to the main document using the AMLFileService
    private static async Task AddComponentModelDocumentsAsExternalReferences(CAEXDocument mainDocument)
    {
        // the aml file service is used to access published documents
        var amlFileService = new AMLFileService();

        // get the most recent versions of documents for the 'AutomationComponent' domain model
        var componentModelDocuments = await amlFileService.GetDomainDocumentsAsync(AMLDomainEnum.AutomationComponent, CAEXDocument.CAEXSchema.CAEX2_15, Services.Model.AMLEditionEnum.Edition1);

        foreach (var componentModelDocument in componentModelDocuments)
        {
            mainDocument.CAEXFile.New_ExternalReference(componentModelDocument.URL, componentModelDocument.AliasNameFromParts);
        }
    }
}
