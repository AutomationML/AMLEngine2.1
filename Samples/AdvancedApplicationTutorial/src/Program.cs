using Aml.Engine.Tutorial.LibraryServiceTutorial;

namespace Aml.Engine.Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AML Engine Tutorial!");

            // start the library service tutorial
            Task t1 = CallLibraryService();
            t1.Wait();

            // start the AMLFile service tutorial, which computes the same tasks as the previous tutorial
            // but uses a specific librar service for AutomationML hosted files.
            Task t2 = CallAMLFileService();
            t2.Wait();
        }

        // the library service tutorial
        static async Task CallLibraryService()
        {
            // prepare the library service using a server profile
            if ( await LibraryServiceProfileTutorial.InitializeAsnyc())
            {
                Console.WriteLine("\nList hosted libraries using the generic Library service\n");
                // list all hosted document, containing published libraries
                await LibraryServiceProfileTutorial.ListHostedDataAsync();

                Console.WriteLine("\nReference hosted base libraries\n");
                // create a new document with references to the base libraries
                await LibraryServiceProfileTutorial.UseHostedBaseLibrariesAsync();

                // provide some tests using the registered library catalog
                await LibraryServiceProfileTutorial.UseHostedLibraryCatalogAsync();
            }
        }

        // the AMLFileService tutorial
        static async Task CallAMLFileService()
        {
            Console.WriteLine("\nList hosted libraries using the AMLFileService\n");

            if (AMLFileServiceTutorial.Initialize())
            {
                // list all hosted document, containing published libraries
                await AMLFileServiceTutorial.ListHostedDataAsync();

                Console.WriteLine("\nReference hosted base libraries\n");

                // create a new document with references to the base libraries
                await AMLFileServiceTutorial.UseHostedBaseLibrariesAsync();
            }
                     
        }


    }
}
