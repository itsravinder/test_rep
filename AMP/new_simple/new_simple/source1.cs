namespace new_simple {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://new_simple.source",@"Root")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "No1", XPath = @"/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='No1' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "No2", XPath = @"/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='No2' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::new_simple.PropertySchema.State), XPath = @"/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='State' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Root"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"new_simple.PropertySchema.PropertySchema", typeof(global::new_simple.PropertySchema.PropertySchema))]
    public sealed class source : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://new_simple.source"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://new_simple.PropertySchema"" targetNamespace=""http://new_simple.source"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://new_simple.PropertySchema"" location=""new_simple.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Root"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='No1' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='No2' and namespace-uri()='']"" />
          <b:property name=""ns0:State"" xpath=""/*[local-name()='Root' and namespace-uri()='http://new_simple.source']/*[local-name()='State' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""name"" type=""xs:string"" />
        <xs:element name=""State"" type=""xs:string"" />
        <xs:element name=""Sku"" type=""xs:string"" />
        <xs:element name=""No1"" type=""xs:int"" />
        <xs:element name=""No2"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public source() {
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
