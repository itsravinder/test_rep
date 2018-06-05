namespace RRD.BT.Core.GetOrderStatus.InternalSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://rrd.digitalpcs.Statuscore.v1.0",@"GetOrderStatus")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetOrderStatus"})]
    public sealed class GetOrderStatus_core : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://rrd.digitalpcs.Statuscore.v1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://rrd.digitalpcs.Statuscore.v1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GetOrderStatus"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FromIdentity"" type=""xs:string"" />
              <xs:element name=""FromPassCode"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Order"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""OrderHeader"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""OrderHeader"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
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
        
        public GetOrderStatus_core() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GetOrderStatus";
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
