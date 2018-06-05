namespace Temp_Sql {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Sql.Schema1", typeof(global::Temp_Sql.Schema1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Sql.sqlBinding_dbo+MasterInsertUpdateDelete", typeof(global::Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://Temp_Sql.Schema1"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/MasterInsertUpdateDelete"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Ins_record"" />
  </xsl:template>
  <xsl:template match=""/s0:Ins_record"">
    <ns0:MasterInsertUpdateDelete>
      <ns0:id>
        <xsl:value-of select=""ID/text()"" />
      </ns0:id>
      <ns0:first_name>
        <xsl:value-of select=""First_Name/text()"" />
      </ns0:first_name>
      <ns0:last_name>
        <xsl:value-of select=""Last_Name/text()"" />
      </ns0:last_name>
      <ns0:salary>
        <xsl:value-of select=""Salary/text()"" />
      </ns0:salary>
      <ns0:city>
        <xsl:value-of select=""City/text()"" />
      </ns0:city>
      <ns0:StatementType>
        <xsl:value-of select=""Statment/text()"" />
      </ns0:StatementType>
    </ns0:MasterInsertUpdateDelete>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Temp_Sql.Schema1";
        
        private const global::Temp_Sql.Schema1 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Temp_Sql.sqlBinding_dbo+MasterInsertUpdateDelete";
        
        private const global::Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Temp_Sql.Schema1";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Temp_Sql.sqlBinding_dbo+MasterInsertUpdateDelete";
                return _TrgSchemas;
            }
        }
    }
}
