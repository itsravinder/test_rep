namespace record_count {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"record_count.Incoming_schema", typeof(global::record_count.Incoming_schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"record_count.outgoning_schema", typeof(global::record_count.outgoning_schema))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://record_count.outgoning_schema"" xmlns:s0=""http://record_count.Incoming_schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Purchase_order"" />
  </xsl:template>
  <xsl:template match=""/s0:Purchase_order"">
    <xsl:variable name=""var:v1"" select=""count(/s0:Purchase_order/Orders)"" />
    <ns0:PurchaseOrder>
      <OrderCount>
        <count>
          <xsl:value-of select=""$var:v1"" />
        </count>
      </OrderCount>
      <orders>
        <OrderNo>
          <xsl:value-of select=""Orders/OrderNo/text()"" />
        </OrderNo>
        <FirstName>
          <xsl:value-of select=""Orders/FirstName/text()"" />
        </FirstName>
        <LastName>
          <xsl:value-of select=""Orders/LastName/text()"" />
        </LastName>
        <OrderType>
          <xsl:value-of select=""Orders/OrderType/text()"" />
        </OrderType>
        <Amount>
          <xsl:value-of select=""Orders/Amount/text()"" />
        </Amount>
      </orders>
    </ns0:PurchaseOrder>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"record_count.Incoming_schema";
        
        private const global::record_count.Incoming_schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"record_count.outgoning_schema";
        
        private const global::record_count.outgoning_schema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"record_count.Incoming_schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"record_count.outgoning_schema";
                return _TrgSchemas;
            }
        }
    }
}
