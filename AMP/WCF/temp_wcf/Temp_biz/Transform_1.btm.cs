namespace Temp_biz {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_biz.input", typeof(global::Temp_biz.input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_biz.Service1_tempuri_org+Display", typeof(global::Temp_biz.Service1_tempuri_org.Display))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Temp_biz.input"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:Display>
      <ns0:text>
        <xsl:value-of select=""yourname/text()"" />
      </ns0:text>
    </ns0:Display>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Temp_biz.input";
        
        private const global::Temp_biz.input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Temp_biz.Service1_tempuri_org+Display";
        
        private const global::Temp_biz.Service1_tempuri_org.Display _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Temp_biz.input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Temp_biz.Service1_tempuri_org+Display";
                return _TrgSchemas;
            }
        }
    }
}
