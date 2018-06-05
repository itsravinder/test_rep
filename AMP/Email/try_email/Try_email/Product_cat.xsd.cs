namespace Try_email {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Try_email.Product_cat",@"Product")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Type", XPath = @"/*[local-name()='Product' and namespace-uri()='http://Try_email.Product_cat']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Product"})]
    public sealed class Product_cat : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Try_email.Product_cat"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Try_email.Product_cat"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Product"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='Product' and namespace-uri()='http://Try_email.Product_cat']/*[local-name()='Type' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Type"" type=""xs:string"" />
        <xs:element name=""Customer_details"">
          <xs:complexType>
            <xs:sequence maxOccurs=""unbounded"">
              <xs:element name=""Details"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""First_name"" type=""xs:string"" />
                    <xs:element name=""Last_name"" type=""xs:string"" />
                    <xs:element name=""Product_name"" type=""xs:string"" />
                    <xs:element name=""Price"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Product_cat() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Product";
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
