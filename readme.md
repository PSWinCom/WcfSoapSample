#SoapSample
This is a sample of how to create a Soap service that receives messages and delivery reports from PSWinCom Gateway.

1. SMSReceive.cs is generated using svcutil (available in Developer Command Prompt for VS2012 or it's equivalent for other versions of Visual Studio: `x:\your\project\folder> svcutil https://secure.pswin.com/SOAP/Receive.asmx?wsdl`
Include SMSService.cs in your project.
2. Add new WCF Service to your project, call it MyReceiver.svc
3. Remove IMyReceiver from project, we will not be using it
4. Change MyReceiver.svc.cs to implement SMSReceiveSoap interface instead of IMyReceiver, and implement the interface (CTRL+ALT+F10 with cursor over interface name in MyReceiver.svc.cs
5. Write your code for receiving messages