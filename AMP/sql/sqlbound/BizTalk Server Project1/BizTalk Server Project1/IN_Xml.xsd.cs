namespace BizTalk_Server_Project1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk_Server_Project1.IN_Xml",@"Order")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    public sealed class IN_Xml : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk_Server_Project1.IN_Xml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk_Server_Project1.IN_Xml"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""Order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Details"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""OrderID"" type=""xs:string"" />
              <xs:element name=""OrderDate"" type=""xs:date"" />
              <xs:element name=""BillToID"" type=""xs:string"" />
              <xs:element name=""ShipToID"" type=""xs:string"" />
              <xs:element name=""BillToName"" type=""xs:string"" />
              <xs:element name=""BillToCity"" type=""xs:string"" />
              <xs:element name=""ShipToName"" type=""xs:string"" />
              <xs:element name=""ShipToCity"" type=""xs:string"" />
              <xs:element name=""Comments"" type=""xs:string"" />
              <xs:element name=""Amount"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public IN_Xml() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
