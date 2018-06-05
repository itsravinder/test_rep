namespace seq {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://seq.Purchase_info",@"Purchase_Details")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::seq.PropertySchema.PoNo), XPath = @"/*[local-name()='Purchase_Details' and namespace-uri()='http://seq.Purchase_info']/*[local-name()='PoNo' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Purchase_Details"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"seq.PropertySchema.PropertySchema", typeof(global::seq.PropertySchema.PropertySchema))]
    public sealed class Purchase_info : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://seq.Purchase_info"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://seq.PropertySchema"" targetNamespace=""http://seq.Purchase_info"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://seq.PropertySchema"" location=""seq.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Purchase_Details"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:PoNo"" xpath=""/*[local-name()='Purchase_Details' and namespace-uri()='http://seq.Purchase_info']/*[local-name()='PoNo' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PoNo"" type=""xs:string"" />
        <xs:element name=""DateofPurchase"" type=""xs:string"" />
        <xs:element name=""ItemDetails"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Purchase_info() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Purchase_Details";
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
