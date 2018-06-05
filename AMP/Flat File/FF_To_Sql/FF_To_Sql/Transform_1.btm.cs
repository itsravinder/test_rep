namespace FF_To_Sql {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FF_To_Sql.Xml_2_Sql", typeof(global::FF_To_Sql.Xml_2_Sql))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FF_To_Sql.TypedProcedure_dbo+MasterInsert", typeof(global::FF_To_Sql.TypedProcedure_dbo.MasterInsert))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://FF_To_Sql.Xml_2_Sql"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Record"" />
  </xsl:template>
  <xsl:template match=""/s0:Record"">
    <ns0:MasterInsert>
      <ns0:id>
        <xsl:value-of select=""Details/ID/text()"" />
      </ns0:id>
      <ns0:first_name>
        <xsl:value-of select=""Details/FirstName/text()"" />
      </ns0:first_name>
      <ns0:last_name>
        <xsl:value-of select=""Details/LastName/text()"" />
      </ns0:last_name>
      <ns0:salary>
        <xsl:value-of select=""Details/salary/text()"" />
      </ns0:salary>
      <ns0:city>
        <xsl:value-of select=""Details/City/text()"" />
      </ns0:city>
    </ns0:MasterInsert>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FF_To_Sql.Xml_2_Sql";
        
        private const global::FF_To_Sql.Xml_2_Sql _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FF_To_Sql.TypedProcedure_dbo+MasterInsert";
        
        private const global::FF_To_Sql.TypedProcedure_dbo.MasterInsert _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FF_To_Sql.Xml_2_Sql";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FF_To_Sql.TypedProcedure_dbo+MasterInsert";
                return _TrgSchemas;
            }
        }
    }
}
