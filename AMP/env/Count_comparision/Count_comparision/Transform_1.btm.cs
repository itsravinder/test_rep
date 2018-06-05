namespace Count_comparision {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Count_comparision.Incoming_orders", typeof(global::Count_comparision.Incoming_orders))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Count_comparision.outgoning_schema", typeof(global::Count_comparision.outgoning_schema))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Count_comparision.Incoming_orders"" xmlns:ns0=""http://record_count.outgoning_schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Po"" />
  </xsl:template>
  <xsl:template match=""/s0:Po"">
    <ns0:PurchaseOrder>
      <OrderCount>
        <count>
          <xsl:text>0</xsl:text>
        </count>
      </OrderCount>
      <orders>
        <OrderNo>
          <xsl:value-of select=""Orders/OrderNo/text()"" />
        </OrderNo>
        <FirstName>
          <xsl:value-of select=""Orders/FristName/text()"" />
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
        
        private const string _strSrcSchemasList0 = @"Count_comparision.Incoming_orders";
        
        private const global::Count_comparision.Incoming_orders _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Count_comparision.outgoning_schema";
        
        private const global::Count_comparision.outgoning_schema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Count_comparision.Incoming_orders";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Count_comparision.outgoning_schema";
                return _TrgSchemas;
            }
        }
    }
}
