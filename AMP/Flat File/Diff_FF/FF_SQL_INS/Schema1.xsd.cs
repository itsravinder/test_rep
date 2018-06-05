namespace FF_SQL_INS {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FF_SQL_INS.Schema1",@"Transactions")]
    [BodyXPath(@"/*[local-name()='Transactions' and namespace-uri()='http://FF_SQL_INS.Schema1']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Transactions"})]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FF_SQL_INS.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://FF_SQL_INS.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Transactions"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='Transactions' and namespace-uri()='http://FF_SQL_INS.Schema1']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Transcation"">
          <xs:complexType>
            <xs:sequence minOccurs=""1"" maxOccurs=""unbounded"">
              <xs:element name=""image"" type=""xs:string"" />
            </xs:sequence>
            <xs:attribute name=""RecordType"" type=""xs:string"" />
            <xs:attribute name=""RecordCount"" type=""xs:int"" />
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Transactions";
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
