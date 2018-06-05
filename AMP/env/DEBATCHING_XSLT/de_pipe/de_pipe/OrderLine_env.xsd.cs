namespace de_pipe {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://de_pipe.OrderLine_env",@"Order")]
    [BodyXPath(@"/*[local-name()='Order' and namespace-uri()='http://de_pipe.OrderLine_env']/*[local-name()='OrderLine' and namespace-uri()='http://de_pipe.OrderLine']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"de_pipe.OrderLine", typeof(global::de_pipe.OrderLine))]
    public sealed class OrderLine_env : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://de_pipe.OrderLine_env"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://de_pipe.OrderLine"" targetNamespace=""http://de_pipe.OrderLine_env"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""de_pipe.OrderLine"" namespace=""http://de_pipe.OrderLine"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://de_pipe.OrderLine"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='Order' and namespace-uri()='http://de_pipe.OrderLine_env']/*[local-name()='OrderLine' and namespace-uri()='http://de_pipe.OrderLine']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""unbounded"" ref=""ns0:OrderLine"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OrderLine_env() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
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
