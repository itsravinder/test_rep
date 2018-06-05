namespace simpleRouting {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://simpleRouting.Incoming_order",@"AllOrders")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Orders.InvocieId", XPath = @"/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='InvocieId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Orders.Address", XPath = @"/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='Address' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Orders.State", XPath = @"/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='State' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AllOrders"})]
    public sealed class Incoming_order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://simpleRouting.Incoming_order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://simpleRouting.Incoming_order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AllOrders"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='InvocieId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='Address' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='State' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""InvocieId"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Address"" type=""xs:string"" />
              <xs:element name=""State"" type=""xs:string"" />
              <xs:element name=""Sku"" type=""xs:string"" />
              <xs:element name=""Number1"" type=""xs:int"" />
              <xs:element name=""Number2"" type=""xs:int"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Incoming_order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AllOrders";
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
