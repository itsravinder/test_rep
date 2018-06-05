namespace untyped {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://UntypedMessages.Music",@"MusicMessage")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "RegID", XPath = @"/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='RegID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Album", XPath = @"/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Album' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Artist", XPath = @"/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Artist' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Operation", XPath = @"/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Operation' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ExpectedPrice", XPath = @"/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='ExpectedPrice' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"MusicMessage"})]
    public sealed class Music : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://UntypedMessages.Music"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://UntypedMessages.Music"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""MusicMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='RegID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Album' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Artist' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='Operation' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='MusicMessage' and namespace-uri()='http://UntypedMessages.Music']/*[local-name()='ExpectedPrice' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""RegID"" type=""xs:string"" />
        <xs:element name=""Album"" type=""xs:string"" />
        <xs:element name=""Artist"" type=""xs:string"" />
        <xs:element name=""Operation"" type=""xs:string"" />
        <xs:element name=""ExpectedPrice"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Music() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "MusicMessage";
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
