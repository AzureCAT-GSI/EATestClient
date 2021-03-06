# EATestClient
Contains a test client you can use against the EA tenant APIs to view the pricing and usage. This test client uses the Microsoft Azure EA Portal APIs to gather usage and pricing data from the API. With the API Key, and the enrollment Id, you can view the following:

1) Get a list of reports that are available for the enrollment `https://ea.azure.com/rest/100/usage-reports`
1) Get the summary `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=Summary&fmt=json`.  You can change the `fmt` parameter to **CSV**
1) Get the detailed usage `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=Detail&fmt=json`
1) Get the price list that was in effect for the particular month `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=PriceSheet&fmt=json`
1) (If there is usage) Get the marketplace usage for the month `https://ea.azure.com/rest/100/usage-report?month=2015-07&type=StoreCharge&fmt=json`

## Configuration ##

To set it up, you will need an API key generated from the EA portal. It currently defaults to a test tenant and a test enrollment.
To use the client:
1) Generate an access key from the EA Portal. To use the sandbox account, obtain the key from the following link: <a href="https://automaticbillingspec.blob.core.windows.net/spec/TestEnrollmentUsageApiKey.txt" target="_blank">https://automaticbillingspec.blob.core.windows.net/spec/TestEnrollmentUsageApiKey.txt</a>

1) Download/Clone the test client from: 
    > `git clone https://github.com/AzureCAT-GSI/EATestClient.git` 
   
1) Open the `EATestClient.SLN` file from Visual Studio 2015 or above and compile the EXE
1) Launch the EATestClient project in the debugger or from the command line where you downloaded the Git repo. 
    >Example if you cloned it to `F:\git\` directory: `F:\Git\EATestClient\EATestClient\bin\Debug\EATestClient.exe`
1) Enter the access key and the enrollment number in the form. 

    > **Note:** The form is initialized with a default test key but it may have expired. Obtain a new test key or proper key from the EA portal

1) Click the `Get Reports` button. This will populate the tree view with the available reports. Navigate to the report type and click it. Some requests take very long to complete due to the size of the data. The timeout is set to 5 minutes.

    ![Report button](./media/reportbtn.png)

1) The tree view will be populated with the different report types

    ![Report button](./media/treeview.png)
    
## Reports ##
* Detail = Get the detailed usage. Equivalent to `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=Detail&fmt=json`

    ![](./media/detail.png)

* PriceSheet = Price list that was in effect for the particular month. Equivalent to `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=PriceSheet&fmt=json`

    ![](./media/pricesheet.png)

* StoreCharge = (If there is usage) Get the marketplace usage for the month. Equivalent to `https://ea.azure.com/rest/100/usage-report?month=2015-07&type=StoreCharge&fmt=json`

    ![](./media/storecharge.png)

* Summary = The billing and usage summary for the month. Equivalent to `https://ea.azure.com/rest/100/usage-report?month=2017-04&type=Summary&fmt=json`

    ![](./media/summary.png)

* ReconcileUsageToPriceSheet = A report that combines the current month usage with the current month price sheet. Use this to reconcile.
    

* ReconcileStoreChargeToPriceSheet = A report that combines the current month market place usage with the current month market place price sheet. Use this to reconcile.
    

> Note: the price sheet schema changed fields in November-December 2015.
> 
> From (November 2015):
> ```csharp
> public string ConsumptionPartNumber { get; set; }
> public double? ConsumptionPrice { get; set; }
> ```
> 
> TO (December 2015):
> ```csharp
> public string PartNumber { get; set; }
> public Double? UnitPrice { get; set; }
> ```
> 
> Both of these fields are included in the sample test client for reference and it will be empty when not used.

------
Copyright 2016 Microsoft Corporation. All rights reserved. Except where otherwise noted, these materials are licensed under the terms of the MIT License. You may use them according to the license as is most appropriate for your project. The terms of this license can be found at https://opensource.org/licenses/MIT.
