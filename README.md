# Allisons Shop Inventory

### Code Source for Allison's Convenience Store Inventory Application

Notes:
 * Made with .NET Core 3.0 and C#
 * Application is designed to allow testing a list of any combination of Item, Sell In and Quality
 * Specified Test Input is available by selecting option **4: Load Demo Inventory**
 * Nightly Maturing of all inventories in the list can be achieved by
 * The following Libraries were used:
   * EasyConsole (For Quick Console Menu)
   * XUnit (For Testing)
   * Shouldly (For Easy Readable Test Assertions)

# How to Build, Run and Test the Application

**Important:** You need to have .NET Core SDK 3.0 or later by clicking [here](https://dotnet.microsoft.com/download/dotnet-core, ".Net Core SDKs"):

### Visual Studio:

 * After Downloading the files, open *AllisonsShopInventory.Application.sln* in Visual Studio
 * When the Project has loaded tap **Ctrl + Shift + B** to Build the Application
 * Tap **F5** to Run the Application
 * To Test the application open the Test Explorer in Visual Studio with **Ctrl + E + T** and **Ctrl + A + R** to run the tests.

### CMD / Powershell

 * After Downloading the files, navigate to the folder *AllisonsShopInventory.Application* using command "cd"
 * Type `dotnet build` to build the Application
 * Type `dotnet run` to run the Application
 * Type `dotnet test` to run the Unit Tests
