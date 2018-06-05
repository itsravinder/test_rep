namespace debacthing_Example {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://debacthing_Example.CustomersEnvelope",@"Customers")]
    [BodyXPath(@"/*[local-name()='Customers' and namespace-uri()='http://debacthing_Example.CustomersEnvelope']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customers"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"debacthing_Example.Customer_Document", typeof(global::debacthing_Example.Customer_Document))]
    public sealed class CustomersEnvelope : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://debacthing_Example.CustomersEnvelope"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://debacthing_Example.Customer_Document"" targetNamespace=""http://debacthing_Example.CustomersEnvelope"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""debacthing_Example.Customer_Document"" namespace=""http://debacthing_Example.Customer_Document"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://debacthing_Example.Customer_Document"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Customers"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='Customers' and namespace-uri()='http://debacthing_Example.CustomersEnvelope']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element ref=""ns0:Customer"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CustomersEnvelope() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customers";
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
