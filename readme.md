#SoapSample
This is a sample of how to create a Soap service that receives sms, mms and delivery reports from PSWinCom Gateway. Although the code is written using framework 4.5 it should work with earlier frameworks.

##The files
The following are the important files to consider in this sample project.

###Contracts\SmsReceiveContract
Describes the SOAP interface

###SmsReceive.cs
Actual implementation of the webservice. Hooked up to SmsReceive.svc using the ServiceHost and Assembly directives inside the file. You can rename this as long as you change the files below to reflect the change. Keep in mind that the Assembly directive should contain the full name of the assembly where your implementation is (you can find this in project properties).

###SmsReceive.svc
This makes the service visible for IIS, although not strictly needed it removes some complexity in the Web.config

###Web.config
The important bits is the code inside the <system.serviceModel> section. Keep in mind that service name should match what is stated as name inside SmsReceive.svc.