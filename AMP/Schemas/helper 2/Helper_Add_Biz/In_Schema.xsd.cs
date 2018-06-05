namespace Helper_Add_Biz {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Helper_Add_Biz.In_Schema",@"Add")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "A", XPath = @"/*[local-name()='Add' and namespace-uri()='http://Helper_Add_Biz.In_Schema']/*[local-name()='A' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "B", XPath = @"/*[local-name()='Add' and namespace-uri()='http://Helper_Add_Biz.In_Schema']/*[local-name()='B' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Add"})]
    public sealed class In_Schema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Helper_Add_Biz.In_Schema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Helper_Add_Biz.In_Schema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Add"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Add' and namespace-uri()='http://Helper_Add_Biz.In_Schema']/*[local-name()='A' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Add' and namespace-uri()='http://Helper_Add_Biz.In_Schema']/*[local-name()='B' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""A"" type=""xs:int"" />
        <xs:element name=""B"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public In_Schema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Add";
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
