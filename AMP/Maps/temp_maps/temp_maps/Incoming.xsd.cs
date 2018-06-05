namespace temp_maps {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://temp_maps.outgoining",@"Customer")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Address.Country", XPath = @"/*[local-name()='Customer' and namespace-uri()='http://temp_maps.outgoining']/*[local-name()='Address' and namespace-uri()='']/*[local-name()='Country' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Customer"})]
    public sealed class Incoming : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://temp_maps.outgoining"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://temp_maps.outgoining"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Customer"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Customer' and namespace-uri()='http://temp_maps.outgoining']/*[local-name()='Address' and namespace-uri()='']/*[local-name()='Country' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""MiddleInt"" type=""xs:string"" />
        <xs:element name=""Age"" type=""xs:string"" />
        <xs:element name=""Address"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Address1"" type=""xs:string"" />
              <xs:element name=""Address2"" type=""xs:string"" />
              <xs:element name=""Zip"" type=""xs:string"" />
              <xs:element name=""State"" type=""xs:string"" />
              <xs:element name=""Country"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Incoming() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Customer";
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
