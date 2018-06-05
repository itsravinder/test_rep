namespace batching_map {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://batching_map.Schema1",@"Schema_one")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::batching_map.PropertySchema.City), XPath = @"/*[local-name()='Schema_one' and namespace-uri()='http://batching_map.Schema1']/*[local-name()='City' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Schema_one"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"batching_map.PropertySchema.PropertySchema", typeof(global::batching_map.PropertySchema.PropertySchema))]
    public sealed class Schema1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://batching_map.Schema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://batching_map.PropertySchema"" targetNamespace=""http://batching_map.Schema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://batching_map.PropertySchema"" location=""batching_map.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Schema_one"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:City"" xpath=""/*[local-name()='Schema_one' and namespace-uri()='http://batching_map.Schema1']/*[local-name()='City' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Name"" type=""xs:string"" />
        <xs:element name=""Street"" type=""xs:string"" />
        <xs:element name=""City"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Schema1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Schema_one";
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
