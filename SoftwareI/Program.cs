namespace SoftwareI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // FORMS within the GUI
            // TODO 1: Create a main form
            // TODO 2: Create an add part form
            // TODO 3: Create a modify part form
            // TODO 4: Create an add product form
            // TODO 5: Create an add product form where you can edit a property. 

            // APPLICATION

            // TODO 1: Using the UML Class Diagram create appropriate classes and instance variables. Variables must be accessible/modifiable through properties
            // TODO 2: DATAGRID VIEW - redirect the user to the correct form, delete a selected part or product from the grid view. search for a part or product and display matches. Exit the main form.
            // TODO 3: Add functionality to part form - 
            //1. Add Part form: select "In-House" or "Outsourced", enter name, inventory level, price, max and min values, and company name or machine ID, save data and redirect to main form, and cancel or exit out of this form back to main menu. 
            //2. Modify Part Form: select "In-House" or "Outsourced", modify or change data values, save modifications to the data and then redirect to main form, cancel or exit out of this form to main.
            //TODO 4: Add functionality to product form
            //1. "Add Product" form - enter name, inventory level, price, max and min values, save the data and redirect to main, associate one or more parts with a product, remove or disassociate a part from a product, cancel or exit and return to main form.
            //2. "Modify Product" form - modify or change data values, save modifications and redirect, associate one or more parts with a product, cancel or exit out of the form to main
            //3. Write code to address the following conditions with exception handling.
            //Detect non-numeric values in textboxes that expect numeric values, Min should be less than Max; and Inv should be between those 2 values, prevent the user from deleting a product that has a Part associated with it, Confirm "delete" actions

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            


            ApplicationConfiguration.Initialize();
           
            Application.Run(new MainForm());
        }
    }
}