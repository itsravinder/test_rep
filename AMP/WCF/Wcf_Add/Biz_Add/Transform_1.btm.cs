namespace Biz_Add {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biz_Add.Input_schema", typeof(global::Biz_Add.Input_schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Biz_Add.wcfaDD_tempuri_org+add", typeof(global::Biz_Add.wcfaDD_tempuri_org.add))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Biz_Add.Input_schema"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:add>
      <ns0:x>
        <xsl:value-of select=""A/text()"" />
      </ns0:x>
      <ns0:y>
        <xsl:value-of select=""B/text()"" />
      </ns0:y>
    </ns0:add>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Biz_Add.Input_schema";
        
        private const global::Biz_Add.Input_schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Biz_Add.wcfaDD_tempuri_org+add";
        
        private const global::Biz_Add.wcfaDD_tempuri_org.add _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Biz_Add.Input_schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Biz_Add.wcfaDD_tempuri_org+add";
                return _TrgSchemas;
            }
        }
    }
}
