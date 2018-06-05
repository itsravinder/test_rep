namespace Rest_Country {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Rest_Country.Request",@"CountryRequest")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Rest_Country.PropertySchema.CountryName), XPath = @"/*[local-name()='CountryRequest' and namespace-uri()='http://Rest_Country.Request']/*[local-name()='CountryName' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CountryRequest"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Rest_Country.PropertySchema.PropertySchema", typeof(global::Rest_Country.PropertySchema.PropertySchema))]
    public sealed class Request : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Rest_Country.Request"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Rest_Country.PropertySchema"" targetNamespace=""http://Rest_Country.Request"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Rest_Country.PropertySchema"" location=""Rest_Country.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CountryRequest"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:CountryName"" xpath=""/*[local-name()='CountryRequest' and namespace-uri()='http://Rest_Country.Request']/*[local-name()='CountryName' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CountryName"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Request() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CountryRequest";
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
