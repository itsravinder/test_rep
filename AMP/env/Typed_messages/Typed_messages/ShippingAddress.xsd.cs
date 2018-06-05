namespace Typed_messages {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Typed_messages.input",@"Root")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Address1", XPath = @"/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='Address1' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "City", XPath = @"/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='City' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "State", XPath = @"/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='State' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Country", XPath = @"/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='Country' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    public sealed class ShippingAddress : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Typed_messages.input"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Typed_messages.input"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='Address1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='City' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='State' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://Typed_messages.input']/*[local-name()='Country' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Address1"" type=""xs:string"" />
        <xs:element name=""City"" type=""xs:string"" />
        <xs:element name=""State"" type=""xs:string"" />
        <xs:element name=""Country"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ShippingAddress() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Root";
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
