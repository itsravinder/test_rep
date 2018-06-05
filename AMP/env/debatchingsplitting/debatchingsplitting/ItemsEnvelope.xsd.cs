namespace debatchingsplitting {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://debatchingsplitting.ItemsEnvelope",@"Items")]
    [BodyXPath(@"/*[local-name()='Items' and namespace-uri()='http://debatchingsplitting.ItemsEnvelope']/*[local-name()='Orders' and namespace-uri()='']")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Items"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"debatchingsplitting.Document", typeof(global::debatchingsplitting.Document))]
    public sealed class ItemsEnvelope : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://debatchingsplitting.ItemsEnvelope"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://debatchingsplitting.Document"" targetNamespace=""http://debatchingsplitting.ItemsEnvelope"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""debatchingsplitting.Document"" namespace=""http://debatchingsplitting.Document"" />
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo is_envelope=""yes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      <b:references>
        <b:reference targetNamespace=""http://debatchingsplitting.Document"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Items"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo body_xpath=""/*[local-name()='Items' and namespace-uri()='http://debatchingsplitting.ItemsEnvelope']/*[local-name()='Orders' and namespace-uri()='']"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""BatchId"" type=""xs:string"" />
        <xs:element name=""Orders"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""ns0:Product"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ItemsEnvelope() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Items";
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
