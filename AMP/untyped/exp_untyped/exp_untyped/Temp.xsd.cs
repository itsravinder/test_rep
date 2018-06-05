namespace exp_untyped {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://exp_untyped.Temp",@"Service")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Name", XPath = @"/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='Name' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Type", XPath = @"/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "City", XPath = @"/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='City' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Service"})]
    public sealed class Temp : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://exp_untyped.Temp"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://exp_untyped.Temp"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Service"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='Name' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='Type' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Service' and namespace-uri()='http://exp_untyped.Temp']/*[local-name()='City' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"" type=""xs:string"" />
        <xs:element name=""Type"" type=""xs:string"" />
        <xs:element name=""City"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Temp() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Service";
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
