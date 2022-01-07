# AZDOTestResultExport
Quick non-production-quality tool for Azure DevOps, will dump Test Outcomes to a flat-file based upon provided RunId

In order to use for test/demo purposes only, replace the ALL_CAPS_SETTINGS within the Program.cs with valid settings from your own project.  You will need to provide the Organzation Name, the Project Name, the Test Run ID and a PAT (generated from within Azure DevOps).

For anything beyond test/demo purposes, at a minimum you will want to extract all these settings into a secure configuration/secret provider (Azure App Configuration, Azure KeyVault, etc).

If you are using this in a test/demo use case and have updated the afore-mentioned settings, build the console application and then you can do:

AZDOTestResultExport > output.csv  

This will generate a .csv file containing the test results for that test run.  Currently only provides the test run id, the test result id, the outcome and a url link to the test result.  There is much more data available wtihin the result object and it's all deserialized by the code for use.

