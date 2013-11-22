using System.ServiceModel;
using System.Runtime.Serialization;

namespace PSWinCom.Gateway.SoapContracts
{
    [ServiceContractAttribute(Namespace = "http://pswin.com/SOAP/Receive", ConfigurationName = "SMSReceiveSoap")]
    public interface SMSReceiveSoap
    {

        [OperationContractAttribute(Action = "http://pswin.com/SOAP/Receive/ReceiveSMSMessage", ReplyAction = "http://pswin.com/SOAP/Receive/SMSReceiveSoap/ReceiveSMSMessageResponse")]
        ReturnValue ReceiveSMSMessage(IncomingSMSMessage m);

        [OperationContractAttribute(Action = "http://pswin.com/SOAP/Receive/ReceiveDeliveryReport", ReplyAction = "http://pswin.com/SOAP/Receive/SMSReceiveSoap/ReceiveDeliveryReportResponse")]
        ReturnValue ReceiveDeliveryReport(DeliveryReport dr);

        [OperationContractAttribute(Action = "http://pswin.com/SOAP/Receive/ReceiveMMSMessage", ReplyAction = "http://pswin.com/SOAP/Receive/SMSReceiveSoap/ReceiveMMSMessageResponse")]
        ReturnValue ReceiveMMSMessage(IncomingMMSMessage m);
    }

    [DataContract(Name = "IncomingSMSMessage", Namespace = "http://pswin.com/SOAP/Receive")]
    public partial class IncomingSMSMessage : object, IExtensibleDataObject
    {

        private ExtensionDataObject extensionDataField;

        private string ReceiverNumberField;

        private string SenderNumberField;

        private string TextField;

        private string NetworkField;

        private string AddressField;

        private GSMPosition PositionField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string ReceiverNumber
        {
            get
            {
                return this.ReceiverNumberField;
            }
            set
            {
                this.ReceiverNumberField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string SenderNumber
        {
            get
            {
                return this.SenderNumberField;
            }
            set
            {
                this.SenderNumberField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 3)]
        public string Network
        {
            get
            {
                return this.NetworkField;
            }
            set
            {
                this.NetworkField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 4)]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 5)]
        public GSMPosition Position
        {
            get
            {
                return this.PositionField;
            }
            set
            {
                this.PositionField = value;
            }
        }
    }

    [DataContract(Name = "GSMPosition", Namespace = "http://pswin.com/SOAP/Receive")]
    public partial class GSMPosition : object, IExtensibleDataObject
    {

        private ExtensionDataObject extensionDataField;

        private string LongitudeField;

        private string LattitudeField;

        private string RadiusField;

        private string CountyField;

        private string CouncilField;

        private string CouncilNumberField;

        private string PlaceField;

        private string SubPlaceField;

        private string ZipCodeField;

        private string CityField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string Lattitude
        {
            get
            {
                return this.LattitudeField;
            }
            set
            {
                this.LattitudeField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string Radius
        {
            get
            {
                return this.RadiusField;
            }
            set
            {
                this.RadiusField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string County
        {
            get
            {
                return this.CountyField;
            }
            set
            {
                this.CountyField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string Council
        {
            get
            {
                return this.CouncilField;
            }
            set
            {
                this.CouncilField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string CouncilNumber
        {
            get
            {
                return this.CouncilNumberField;
            }
            set
            {
                this.CouncilNumberField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 7)]
        public string SubPlace
        {
            get
            {
                return this.SubPlaceField;
            }
            set
            {
                this.SubPlaceField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 8)]
        public string ZipCode
        {
            get
            {
                return this.ZipCodeField;
            }
            set
            {
                this.ZipCodeField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 9)]
        public string City
        {
            get
            {
                return this.CityField;
            }
            set
            {
                this.CityField = value;
            }
        }
    }

    [DataContract(Name = "ReturnValue", Namespace = "http://pswin.com/SOAP/Receive")]
    public partial class ReturnValue : object, IExtensibleDataObject
    {

        private ExtensionDataObject extensionDataField;

        private int CodeField;

        private string DescriptionField;

        private string ReferenceField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(IsRequired = true)]
        public int Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Reference
        {
            get
            {
                return this.ReferenceField;
            }
            set
            {
                this.ReferenceField = value;
            }
        }
    }

    [DataContract(Name = "DeliveryReport", Namespace = "http://pswin.com/SOAP/Receive")]
    public partial class DeliveryReport : object, IExtensibleDataObject
    {

        private ExtensionDataObject extensionDataField;

        private string StateField;

        private string ReceiverNumberField;

        private string DeliveryTimeField;

        private string ReferenceField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string State
        {
            get
            {
                return this.StateField;
            }
            set
            {
                this.StateField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string ReceiverNumber
        {
            get
            {
                return this.ReceiverNumberField;
            }
            set
            {
                this.ReceiverNumberField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 2)]
        public string DeliveryTime
        {
            get
            {
                return this.DeliveryTimeField;
            }
            set
            {
                this.DeliveryTimeField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string Reference
        {
            get
            {
                return this.ReferenceField;
            }
            set
            {
                this.ReferenceField = value;
            }
        }
    }

    [DataContract(Name = "IncomingMMSMessage", Namespace = "http://pswin.com/SOAP/Receive")]
    public partial class IncomingMMSMessage : object, IExtensibleDataObject
    {

        private ExtensionDataObject extensionDataField;

        private string ReceiverNumberField;

        private string SenderNumberField;

        private string SubjectField;

        private string NetworkField;

        private string AddressField;

        private GSMPosition PositionField;

        private byte[] DataField;

        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string ReceiverNumber
        {
            get
            {
                return this.ReceiverNumberField;
            }
            set
            {
                this.ReceiverNumberField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string SenderNumber
        {
            get
            {
                return this.SenderNumberField;
            }
            set
            {
                this.SenderNumberField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string Subject
        {
            get
            {
                return this.SubjectField;
            }
            set
            {
                this.SubjectField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 3)]
        public string Network
        {
            get
            {
                return this.NetworkField;
            }
            set
            {
                this.NetworkField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 4)]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }

        [DataMember(IsRequired = true, Order = 5)]
        public GSMPosition Position
        {
            get
            {
                return this.PositionField;
            }
            set
            {
                this.PositionField = value;
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        public byte[] Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
    }
}
