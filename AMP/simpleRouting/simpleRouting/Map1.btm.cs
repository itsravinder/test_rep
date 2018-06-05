namespace simpleRouting {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"simpleRouting.Incoming_order", typeof(global::simpleRouting.Incoming_order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"simpleRouting.tem", typeof(global::simpleRouting.tem))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://simpleRouting.tem"" xmlns:s0=""http://simpleRouting.Incoming_order"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AllOrders"" />
  </xsl:template>
  <xsl:template match=""/s0:AllOrders"">
    <ns0:Root>
      <InvoiceID>
        <xsl:value-of select=""Orders/InvocieId/text()"" />
      </InvoiceID>
      <Address>
        <xsl:value-of select=""Orders/Address/text()"" />
      </Address>
      <State>
        <xsl:value-of select=""Orders/State/text()"" />
      </State>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"simpleRouting.Incoming_order";
        
        private const global::simpleRouting.Incoming_order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"simpleRouting.tem";
        
        private const global::simpleRouting.tem _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"simpleRouting.Incoming_order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"simpleRouting.tem";
                return _TrgSchemas;
            }
        }
    }
}
