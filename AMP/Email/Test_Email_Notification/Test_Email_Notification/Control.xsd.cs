namespace Test_Email_Notification {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Test_Email_Notification.Control",@"Control")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "Count.Count_Value", XPath = @"/*[local-name()='Control' and namespace-uri()='http://Test_Email_Notification.Control']/*[local-name()='Count' and namespace-uri()='']/*[local-name()='Count_Value' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Control"})]
    public sealed class Control : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Test_Email_Notification.Control"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Test_Email_Notification.Control"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Control"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Control' and namespace-uri()='http://Test_Email_Notification.Control']/*[local-name()='Count' and namespace-uri()='']/*[local-name()='Count_Value' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Count"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Count_Value"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Control() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Control";
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
