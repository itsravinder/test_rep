namespace Temp_Map {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Temp_Map.GenericSchema",@"GenericMessage")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::Temp_Map.PropertySchema.SubscriberInfo), XPath = @"/*[local-name()='GenericMessage' and namespace-uri()='http://Temp_Map.GenericSchema']/*[local-name()='SubscriberInfo' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"GenericMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Map.PropertySchema.PropertySchema", typeof(global::Temp_Map.PropertySchema.PropertySchema))]
    public sealed class GenericSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Temp_Map.GenericSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://Temp_Map.PropertySchema"" targetNamespace=""http://Temp_Map.GenericSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Temp_Map.PropertySchema"" location=""Temp_Map.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""GenericMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:SubscriberInfo"" xpath=""/*[local-name()='GenericMessage' and namespace-uri()='http://Temp_Map.GenericSchema']/*[local-name()='SubscriberInfo' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Data"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Age"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""SubscriberInfo"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public GenericSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "GenericMessage";
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
