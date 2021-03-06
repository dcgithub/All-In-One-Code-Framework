/***************************************** Module Header *****************************\
* Module Name:  Connect.cs
* Project:      CSVSAddInCommandEvents
* Copyright (c) Microsoft Corporation.
* 
* This sample demonstrates how to subscribe to the shell command executing and
* how to change the menu item's caption dynamically.
* 
* The EnvDTE Automation has provided CommandEvents interface to represent the
* specific command events in the shell.
* The DTE.Events.get_CommandEvents() method gives the way to get the specific
* command events, then you could add your personal actions before/after the
* command executing.
* 
* To change the text of menu item in AddIn, you need to get the CommandBar
* which contains the menu item controls firstly, then use
* CommandBarControl.Caption property to specify the caption of menu item.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* History:
* * 12/10/2009 06:35 PM Wesley Yao Created
\*************************************************************************************/

using System;
using Extensibility;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.CommandBars;
using System.Resources;
using System.Reflection;
using System.Globalization;

namespace CSVSAddInCommandEvents
{
    /// <summary>The object for implementing an Add-in.</summary>
    /// <seealso class='IDTExtensibility2' />
    public class Connect : IDTExtensibility2, IDTCommandTarget
    {
        /// <summary>
        /// Implements the constructor for the Add-in object.
        /// Place your initialization code within this method.
        /// </summary>
        public Connect()
        {
            // Step 3:
            // Initialize the isSubscribe  to true.
            isSubscribe = true;
        }

        /// <summary>
        /// Implements the OnConnection method of the IDTExtensibility2 interface.
        /// Receives notification that the Add-in is being loaded.
        /// </summary>
        /// <param term='application'>Root object of the host application.</param>
        /// <param term='connectMode'>Describes how the Add-in is being loaded.</param>
        /// <param term='addInInst'>Object representing this Add-in.</param>
        /// <seealso class='IDTExtensibility2' />
        public void OnConnection(object application,
            ext_ConnectMode connectMode,
            object addInInst,
            ref Array custom)
        {
            _applicationObject = (DTE2)application;
            _addInInstance = (AddIn)addInInst;
            if (connectMode == ext_ConnectMode.ext_cm_UISetup)
            {
                object[] contextGUIDS = new object[] { };
                Commands2 commands = (Commands2)_applicationObject.Commands;
                string toolsMenuName;

                try
                {
                    // If you would like to move the command to a different menu,
                    // change the word "Tools" to the English version of the menu.
                    // This code will take the culture, append on the name of the menu
                    // then add the command to that menu. You can find a list of all
                    // the top-level menus in the file CommandBar.resx.
                    string resourceName;
                    ResourceManager resourceManager
                        = new ResourceManager("CSVSAddInCommandEvents.CommandBar",
                            Assembly.GetExecutingAssembly());
                    CultureInfo cultureInfo
                        = new CultureInfo(_applicationObject.LocaleID);

                    if (cultureInfo.TwoLetterISOLanguageName == "zh")
                    {
                        System.Globalization.CultureInfo parentCultureInfo
                            = cultureInfo.Parent;
                        resourceName = String.Concat(parentCultureInfo.Name, "Tools");
                    }
                    else
                    {
                        resourceName
                            = String.Concat(cultureInfo.TwoLetterISOLanguageName,
                            "Tools");
                    }
                    toolsMenuName = resourceManager.GetString(resourceName);
                }
                catch
                {
                    // We tried to find a localized version of the word Tools, but one
                    // was not found.
                    // Default to the en-US word, which may work for the current
                    // culture.
                    toolsMenuName = "Tools";
                }

                // Place the command on the tools menu.
                // Find the MenuBar command bar, which is the top-level command bar
                // holding all the main menu items:
                Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar
                    = ((Microsoft.VisualStudio.CommandBars.CommandBars)
                    _applicationObject.CommandBars)["MenuBar"];

                //Find the Tools command bar on the MenuBar command bar:
                CommandBarControl toolsControl
                    = menuBarCommandBar.Controls[toolsMenuName];
                CommandBarPopup toolsPopup = (CommandBarPopup)toolsControl;

                // This try/catch block can be duplicated if you wish to add multiple
                // commands to be handled by your Add-in, just make sure you also
                // update the QueryStatus/Exec method to include the new command names.
                try
                {
                    //Add a command to the Commands collection:

                    // Step 1:
                    // Modify the command with name CSVSAddInCommandEvents and button
                    // text Add CommandEvent Subscription.
                    Command command
                        = commands.AddNamedCommand2(_addInInstance,
                        "CSVSAddInCommandEvents",
                        "Add CommandEvent Subscription",
                        "Executes the command for CSVSAddInCommandEvents",
                        true, 59, ref contextGUIDS,
                        (int)vsCommandStatus.vsCommandStatusSupported
                        + (int)vsCommandStatus.vsCommandStatusEnabled,
                        (int)vsCommandStyle.vsCommandStylePictAndText,
                        vsCommandControlType.vsCommandControlTypeButton);

                    // Add a control for the command to the tools menu:
                    if ((command != null) && (toolsPopup != null))
                    {
                        command.AddControl(toolsPopup.CommandBar, 1);
                    }
                }
                catch (System.ArgumentException)
                {
                    // If we are here, then the exception is probably because a command
                    // with that name already exists. If so there is no need to
                    // recreate the command and we can safely ignore the exception.
                }
            }
        }

        /// <summary>
        /// Implements the OnDisconnection method of the IDTExtensibility2 interface.
        /// Receives notification that the Add-in is being unloaded.
        /// </summary>
        /// <param term='disconnectMode'>
        /// Describes how the Add-in is being unloaded.
        /// </param>
        /// <param term='custom'>
        /// Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnDisconnection(ext_DisconnectMode disconnectMode,
            ref Array custom)
        {
        }

        /// <summary>
        /// Implements the OnAddInsUpdate method of the IDTExtensibility2 interface.
        /// Receives notification when the collection of Add-ins has changed.
        /// </summary>
        /// <param term='custom'>
        /// Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnAddInsUpdate(ref Array custom)
        {
        }

        /// <summary>
        /// Implements the OnStartupComplete method of the IDTExtensibility2 interface.
        /// Receives notification that the host application has completed loading.
        /// </summary>
        /// <param term='custom'>
        /// Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnStartupComplete(ref Array custom)
        {
        }

        /// <summary>
        /// Implements the OnBeginShutdown method of the IDTExtensibility2 interface.
        /// Receives notification that the host application is being unloaded.
        /// </summary>
        /// <param term='custom'>
        /// Array of parameters that are host application specific.
        /// </param>
        /// <seealso class='IDTExtensibility2' />
        public void OnBeginShutdown(ref Array custom)
        {
        }

        /// <summary>
        /// Implements the QueryStatus method of the IDTCommandTarget interface.
        /// This is called when the command's availability is updated
        /// </summary>
        /// <param term='commandName'>
        /// The name of the command to determine state for.</param>
        /// <param term='neededText'>Text that is needed for the command.
        /// </param>
        /// <param term='status'>
        /// The state of the command in the user interface.
        /// </param>
        /// <param term='commandText'>
        /// Text requested by the neededText parameter.
        /// </param>
        /// <seealso class='Exec' />
        public void QueryStatus(string commandName,
            vsCommandStatusTextWanted neededText,
            ref vsCommandStatus status,
            ref object commandText)
        {
            if (neededText == vsCommandStatusTextWanted.vsCommandStatusTextWantedNone)
            {
                if (commandName
                    == "CSVSAddInCommandEvents.Connect.CSVSAddInCommandEvents")
                {
                    status = (vsCommandStatus)vsCommandStatus.vsCommandStatusSupported
                        | vsCommandStatus.vsCommandStatusEnabled;
                    return;
                }
            }
        }

        // Step 7:
        // Modify the Exec() procedure.
        // Call the AddSubscription() or RemoveSubscription() method, change the caption
        // of menu item depends on the flag isSubscribe:

        /// <summary>
        /// Implements the Exec method of the IDTCommandTarget interface.
        /// This is called when the command is invoked.
        /// </summary>
        /// <param term='commandName'>
        /// The name of the command to execute.
        /// </param>
        /// <param term='executeOption'>
        /// Describes how the command should be run.
        /// </param>
        /// <param term='varIn'>
        /// Parameters passed from the caller to the command handler.
        /// </param>
        /// <param term='varOut'>
        /// Parameters passed from the command handler to the caller.
        /// </param>
        /// <param term='handled'>
        /// Informs the caller if the command was handled or not.
        /// </param>
        /// <seealso class='Exec' />
        public void Exec(string commandName,
            vsCommandExecOption executeOption,
            ref object varIn,
            ref object varOut,
            ref bool handled)
        {
            handled = false;
            if (executeOption == vsCommandExecOption.vsCommandExecOptionDoDefault)
            {
                if (commandName
                    == "CSVSAddInCommandEvents.Connect.CSVSAddInCommandEvents")
                {
                    // Get the Tools command bar.
                    Microsoft.VisualStudio.CommandBars.CommandBar menuBarCommandBar
                        = ((Microsoft.VisualStudio.CommandBars.CommandBars)
                        _applicationObject.CommandBars)["MenuBar"];
                    CommandBarControl toolsControl
                        = menuBarCommandBar.Controls["Tools"];
                    CommandBarPopup toolsPopup = (CommandBarPopup)toolsControl;
                    CommandBar toolsCommandBar = toolsPopup.CommandBar;
                    if (isSubscribe)
                    {
                        // Subscribe to the command events.
                        AddSubscription();
                        // Next clicking will remove the subscription.
                        isSubscribe = false;
                        // Get the menu item control.
                        CommandBarControl menuItemControl
                            = toolsCommandBar.Controls["Add CommandEvent Subscription"];
                        // Change its caption to Remove CommandEvent Subscription.
                        menuItemControl.Caption = "Remove CommandEvent Subscription";
                    }
                    else
                    {
                        // Remove the subscription.
                        RemoveSubscription();
                        // Next clicking will add the subscription.
                        isSubscribe = true;
                        // Get the menu item control.
                        CommandBarControl menuItemControl
                            = toolsCommandBar.Controls["Remove CommandEvent Subscription"];
                        // Change its caption to Add Subscription.
                        menuItemControl.Caption = "Add CommandEvent Subscription";
                    }

                    handled = true;
                    return;
                }
            }
        }

        // Step 4:
        // Define a method to add subscription of the Project.AddReference command.

        ///////////////////////////////////////////////////////////////////////////////
        // Subscribe to the BeforeExecute and AfterExecute events, add our process into
        // the command handler.
        // 
        public void AddSubscription()
        {
            // "{1496A755-94DE-11D0-8C3F-00C04FC2AAE2}, 1113" Guid-ID pair refer to
            // Project.AddReference command.
            // About how to get the Guid and ID of the specific command, please take a
            // look at this link on Dr.eX's blog:
            // http://blogs.msdn.com/dr._ex/archive/2007/04/17/using-enablevsiplogging-
            // to-identify-menus-and-commands-with-vs-2005-sp1.aspx
            try
            {
                addReferenceEvents
                    = _applicationObject.Events.get_CommandEvents(
                    "{1496A755-94DE-11D0-8C3F-00C04FC2AAE2}",
                    1113);
                addReferenceEvents.BeforeExecute
                    += new _dispCommandEvents_BeforeExecuteEventHandler
                        (addReferenceEvents_BeforeExecute);
                addReferenceEvents.AfterExecute
                    += new _dispCommandEvents_AfterExecuteEventHandler
                        (addReferenceEvents_AfterExecute);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        // Step 5:
        // Define a method to remove subscription of the Project.AddReference command.

        ///////////////////////////////////////////////////////////////////////////////
        // Remove the subscription on Project.AddReference command events.
        // 
        public void RemoveSubscription()
        {
            try
            {
                addReferenceEvents.BeforeExecute
                    -= new _dispCommandEvents_BeforeExecuteEventHandler
                        (addReferenceEvents_BeforeExecute);
                addReferenceEvents.AfterExecute
                    -= new _dispCommandEvents_AfterExecuteEventHandler
                        (addReferenceEvents_AfterExecute);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        // Step 6:
        // Implement the BeforeExecute/AfterExecute event handlers.

        ///////////////////////////////////////////////////////////////////////////////
        // BeforeExecute event handler.
        // 
        public void addReferenceEvents_BeforeExecute(string Guid,
            int ID,
            object CustomIn,
            object CustomOut,
            ref bool CancelDefault)
        {
            System.Windows.Forms.MessageBox.Show("Before adding reference.");

            // If you want to cancel the default handler for this command, specify
            // the CancelDefault to true.

            //CancelDefault = true;
        }

        ///////////////////////////////////////////////////////////////////////////////
        // AfterExecute event handler.
        // 
        public void addReferenceEvents_AfterExecute(string Guid,
            int ID,
            object CustomIn,
            object CustomOut)
        {
            System.Windows.Forms.MessageBox.Show("After adding reference.");
        }

        private DTE2 _applicationObject;
        private AddIn _addInInstance;

        // Step 2:
        // Add variables for the CommandEvents and menu item's state.
        private CommandEvents addReferenceEvents; // Command events.
        private bool isSubscribe; // Flag to indicate the menu item's current work.
    }
}