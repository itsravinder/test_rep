namespace Diff_FF {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Diff_FF.FlatFile_To_Sql", typeof(global::Diff_FF.FlatFile_To_Sql))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Diff_FF.TypedProcedure_dbo+usp_Customer_Details", typeof(global::Diff_FF.TypedProcedure_dbo.usp_Customer_Details))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s0=""http://Diff_FF.FlatFile_To_Sql"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <ns0:usp_Customer_Details>
      <ns0:First_name>
        <xsl:value-of select=""Customer_Details/First_Name/text()"" />
      </ns0:First_name>
      <ns0:Last_Name>
        <xsl:value-of select=""Customer_Details/Last_name/text()"" />
      </ns0:Last_Name>
      <ns0:Year>
        <xsl:value-of select=""Customer_Details/Year/text()"" />
      </ns0:Year>
      <ns0:City>
        <xsl:value-of select=""Customer_Details/City/text()"" />
      </ns0:City>
      <ns0:ZipCode>
        <xsl:value-of select=""Customer_Details/ZipCode/text()"" />
      </ns0:ZipCode>
    </ns0:usp_Customer_Details>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Diff_FF.FlatFile_To_Sql";
        
        private const global::Diff_FF.FlatFile_To_Sql _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Diff_FF.TypedProcedure_dbo+usp_Customer_Details";
        
        private const global::Diff_FF.TypedProcedure_dbo.usp_Customer_Details _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Diff_FF.FlatFile_To_Sql";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Diff_FF.TypedProcedure_dbo+usp_Customer_Details";
                return _TrgSchemas;
            }
        }
    }
}
