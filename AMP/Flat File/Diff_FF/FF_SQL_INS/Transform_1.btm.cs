namespace FF_SQL_INS {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FF_SQL_INS.Schema1", typeof(global::FF_SQL_INS.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"FF_SQL_INS.Procedure_dbo+requesting", typeof(global::FF_SQL_INS.Procedure_dbo.requesting))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://FF_SQL_INS.Schema1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Transactions"" />
  </xsl:template>
  <xsl:template match=""/s0:Transactions"">
    <ns0:requesting>
      <ns0:insertTransactions>
        <xsl:if test=""Transcation/@RecordCount"">
          <ns0:Recordcount>
            <xsl:value-of select=""Transcation/@RecordCount"" />
          </ns0:Recordcount>
        </xsl:if>
        <xsl:if test=""Transcation/@RecordType"">
          <ns0:RecordType>
            <xsl:value-of select=""Transcation/@RecordType"" />
          </ns0:RecordType>
        </xsl:if>
        <ns0:Image>
          <xsl:value-of select=""Transcation/image/text()"" />
        </ns0:Image>
      </ns0:insertTransactions>
    </ns0:requesting>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"FF_SQL_INS.Schema1";
        
        private const global::FF_SQL_INS.Schema1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"FF_SQL_INS.Procedure_dbo+requesting";
        
        private const global::FF_SQL_INS.Procedure_dbo.requesting _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"FF_SQL_INS.Schema1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"FF_SQL_INS.Procedure_dbo+requesting";
                return _TrgSchemas;
            }
        }
    }
}
