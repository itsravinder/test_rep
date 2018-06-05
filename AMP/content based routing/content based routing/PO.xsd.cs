namespace content_based_routing {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://content_based_routing.PO",@"PurchaseOrder")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::content_based_routing.PropertySchema.TotalAmount), XPath = @"/*[local-name()='PurchaseOrder' and namespace-uri()='http://content_based_routing.PO']/*[local-name()='TotalAmount' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PurchaseOrder"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"content_based_routing.PropertySchema.PropertySchema", typeof(global::content_based_routing.PropertySchema.PropertySchema))]
    public sealed class PO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://content_based_routing.PO"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://content_based_routing.PropertySchema"" targetNamespace=""http://content_based_routing.PO"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://content_based_routing.PropertySchema"" location=""content_based_routing.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""PurchaseOrder"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:TotalAmount"" xpath=""/*[local-name()='PurchaseOrder' and namespace-uri()='http://content_based_routing.PO']/*[local-name()='TotalAmount' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PoRefNo"" type=""xs:string"" />
        <xs:element name=""PurchaseDate"" type=""xs:date"" />
        <xs:element name=""TotalAmount"" type=""xs:int"" />
        <xs:element name=""No_of_items"" type=""xs:int"" />
        <xs:element name=""Avg_amount"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PurchaseOrder";
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
