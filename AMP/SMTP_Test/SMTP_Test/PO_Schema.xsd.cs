namespace SMTP_Test {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://SMTP_Test.PO_Schema",@"Purchase_x0020_Order")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PO_No", XPath = @"/*[local-name()='Purchase_x0020_Order' and namespace-uri()='http://SMTP_Test.PO_Schema']/*[local-name()='PO_No' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Purchase_x0020_Order"})]
    public sealed class PO_Schema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://SMTP_Test.PO_Schema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://SMTP_Test.PO_Schema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Purchase_x0020_Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Purchase_x0020_Order' and namespace-uri()='http://SMTP_Test.PO_Schema']/*[local-name()='PO_No' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PO_No"" type=""xs:string"" />
        <xs:element name=""Customer"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Addres"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Description"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PO_desc"" type=""xs:string"" />
              <xs:element name=""Owner_Desc"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PO_Schema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Purchase_x0020_Order";
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
