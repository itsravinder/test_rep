namespace Envenlope {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Envenlope.Order_Envelope",@"OrderEnvenlope")]
    [BodyXPath(@"/*[local-name()='OrderEnvenlope' and namespace-uri()='http://Envenlope.Order_Envelope']/*[local-name()='orders' and namespace-uri()='']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"OrderEnvenlope"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Envenlope.order", typeof(global::Envenlope.order))]
    public sealed class Order_Envelope : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Envenlope.Order_Envelope"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://Envenlope.order"" targetNamespace=""http://Envenlope.Order_Envelope"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Envenlope.order"" namespace=""http://Envenlope.order"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://Envenlope.order"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""OrderEnvenlope"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='OrderEnvenlope' and namespace-uri()='http://Envenlope.Order_Envelope']/*[local-name()='orders' and namespace-uri()='']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""BatchID"" type=""xs:string"" />
        <xs:element name=""orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""ns0:Order"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Order_Envelope() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "OrderEnvenlope";
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
