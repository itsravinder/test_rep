namespace Diff_FF {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Diff_FF.TypedProcedure_dbo+usp_Customer_DetailsResponse", typeof(global::Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Diff_FF.Status", typeof(global::Diff_FF.Status))]
    public sealed class Transform_2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://Diff_FF.Status"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:usp_Customer_DetailsResponse"" />
  </xsl:template>
  <xsl:template match=""/s0:usp_Customer_DetailsResponse"">
    <ns0:Root>
      <Status>
        <xsl:value-of select=""s0:ReturnValue/text()"" />
      </Status>
    </ns0:Root>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Diff_FF.TypedProcedure_dbo+usp_Customer_DetailsResponse";
        
        private const global::Diff_FF.TypedProcedure_dbo.usp_Customer_DetailsResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Diff_FF.Status";
        
        private const global::Diff_FF.Status _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Diff_FF.TypedProcedure_dbo+usp_Customer_DetailsResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Diff_FF.Status";
                return _TrgSchemas;
            }
        }
    }
}
