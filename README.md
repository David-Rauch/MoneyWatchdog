# MoneyWatchdog
Application to sort and compare banking account usage to a pre-determined Budget. 

![Money Watchdog Class Diagram](https://github.com/David-Rauch/MoneyWatchdog/blob/master/classDiagram.jpg)

**Money Watchdog Repository Folders**
* Money($)Watchdog -> A application that takes your downloaded .csv files from your bank and provides a way to categorize, display, compare to pre-set Budget spending plan and upload to a database for personal storage.

**Money($)Watchdog Software Requirements**
* The user needs to download a .csv file from their bank and place it in a MONEY folder.  Adjustments will be needed to the files to account for the location this file is stored.
* A username and password for the app is required, and can be hard coded in if desired.  An administrative function will be provided to set levels of permissions for editing/updating data.
* A MENU button will be available on all pages to allow navigation to all pages, and logoff.
* All line items pulled from the .csv file are categorized by the user into Budget groupings.
* Unless the user selects “upload data to Budget” the manipulated data will be lost, and the user will need to begin again by pulling data from the .csv file.  This application does not upload the data until the user is finished manipulating it.
