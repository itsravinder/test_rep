namespace Parallel {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Parallel.Shopping_Details",@"Shopping_details")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Parallel.PropertySchema.Cust_ID), XPath = @"/*[local-name()='Shopping_details' and namespace-uri()='http://Parallel.Shopping_Details']/*[local-name()='Cust_ID' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Type", XPath = @"/*[local-name()='Shopping_details' and namespace-uri()='http://Parallel.Shopping_Details']/*[local-name()='Type' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Shopping_details"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Parallel.PropertySchema.PropertySchema", typeof(global::Parallel.PropertySchema.PropertySchema))]
    public sealed class Shopping_Details : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Parallel.Shopping_Details"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Parallel.PropertySchema"" targetNamespace=""http://Parallel.Shopping_Details"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Parallel.PropertySchema"" location=""Parallel.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Shopping_details"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Cust_ID"" xpath=""/*[local-name()='Shopping_details' and namespace-uri()='http://Parallel.Shopping_Details']/*[local-name()='Cust_ID' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Shopping_details' and namespace-uri()='http://Parallel.Shopping_Details']/*[local-name()='Type' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Cust_ID"" type=""xs:string"" />
        <xs:element name=""Item_number"" type=""xs:string"" />
        <xs:element name=""Item_name"" type=""xs:string"" />
        <xs:element name=""Qty"" type=""xs:integer"" />
        <xs:element name=""Price"" type=""xs:double"" />
        <xs:element name=""Type"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Shopping_Details() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Shopping_details";
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
