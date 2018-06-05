namespace RRD.BT.Core.GetOrderStatus.InternalSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://rrd.digitalpcs.CoreGetOrderStatusResponse.v1.0",@"GetOrderStatusResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GetOrderStatusResponse"})]
    public sealed class Core_GetOrderStatusResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://rrd.digitalpcs.CoreGetOrderStatusResponse.v1.0"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://rrd.digitalpcs.CoreGetOrderStatusResponse.v1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""GetOrderStatusResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FromIdentity"" type=""xs:string"" />
              <xs:element name=""FromPassCode"" type=""xs:string"" />
              <xs:element name=""EnvelopeDate"" type=""xs:dateTime"" />
              <xs:element name=""EnvelopeNum"" type=""xs:int"" />
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
                          <xs:element name=""OrderNum"" type=""xs:long"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OrderLines"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""OrderLine"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""LineItemNum"" type=""xs:byte"" />
                                <xs:element name=""StatusCode"" type=""xs:byte"" />
                                <xs:element name=""StausDesc"" type=""xs:string"" />
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
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Core_GetOrderStatusResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GetOrderStatusResponse";
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
