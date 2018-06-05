namespace untyped {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://UntypedMessages.StoreFront",@"StoreFront")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RegID", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='RegID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Category", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='Category' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ExpectedPrice", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='ExpectedPrice' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DataItem1", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='DataItem1' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "DataItem2", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='DataItem2' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Operation", XPath = @"/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='Operation' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StoreFront"})]
    public sealed class StoreFront : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://UntypedMessages.StoreFront"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://UntypedMessages.StoreFront"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""StoreFront"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='RegID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='Category' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='ExpectedPrice' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='DataItem1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='DataItem2' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='StoreFront' and namespace-uri()='http://UntypedMessages.StoreFront']/*[local-name()='Operation' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RegID"" type=""xs:string"" />
        <xs:element name=""Category"" type=""xs:string"" />
        <xs:element name=""ExpectedPrice"" type=""xs:string"" />
        <xs:element name=""DataItem1"" type=""xs:string"" />
        <xs:element name=""DataItem2"" type=""xs:string"" />
        <xs:element name=""Operation"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public StoreFront() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "StoreFront";
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
