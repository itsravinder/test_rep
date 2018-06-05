namespace batching_map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"batching_map.Schema1", typeof(global::batching_map.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"batching_map.Schema2", typeof(global::batching_map.Schema2))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"batching_map.outxsd", typeof(global::batching_map.outxsd))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1"" version=""1.0"" xmlns:s0=""http://batching_map.Schema1"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:ns0=""http://batching_map.outxsd"" xmlns:s1=""http://batching_map.Schema2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:Root />
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"batching_map.Schema1";
        
        private const global::batching_map.Schema1 _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"batching_map.Schema2";
        
        private const global::batching_map.Schema2 _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"batching_map.outxsd";
        
        private const global::batching_map.outxsd _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"batching_map.Schema1";
                _SrcSchemas[1] = @"batching_map.Schema2";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"batching_map.outxsd";
                return _TrgSchemas;
            }
        }
    }
}
