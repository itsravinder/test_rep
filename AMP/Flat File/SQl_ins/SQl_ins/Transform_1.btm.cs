namespace SQl_ins {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SQl_ins.Schema_XML", typeof(global::SQl_ins.Schema_XML))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"SQl_ins.TypedProcedure_dbo+Usp_name_insert", typeof(global::SQl_ins.TypedProcedure_dbo.Usp_name_insert))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s0=""http://SQl_ins.Schema_XML"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Record"" />
  </xsl:template>
  <xsl:template match=""/s0:Record"">
    <ns0:Usp_name_insert>
      <xsl:for-each select=""Details/ID"">
        <ns0:ID>
          <xsl:value-of select=""./text()"" />
        </ns0:ID>
      </xsl:for-each>
      <xsl:for-each select=""Details/Name"">
        <ns0:Name>
          <xsl:value-of select=""./text()"" />
        </ns0:Name>
      </xsl:for-each>
      <xsl:for-each select=""Details/City"">
        <ns0:city>
          <xsl:value-of select=""./text()"" />
        </ns0:city>
      </xsl:for-each>
      <xsl:for-each select=""Details/Dob"">
        <ns0:Dob>
          <xsl:value-of select=""./text()"" />
        </ns0:Dob>
      </xsl:for-each>
    </ns0:Usp_name_insert>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"SQl_ins.Schema_XML";
        
        private const global::SQl_ins.Schema_XML _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"SQl_ins.TypedProcedure_dbo+Usp_name_insert";
        
        private const global::SQl_ins.TypedProcedure_dbo.Usp_name_insert _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"SQl_ins.Schema_XML";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"SQl_ins.TypedProcedure_dbo+Usp_name_insert";
                return _TrgSchemas;
            }
        }
    }
}
