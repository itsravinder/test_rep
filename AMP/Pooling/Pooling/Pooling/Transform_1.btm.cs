namespace Pooling {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Pooling.Schema2", typeof(global::Pooling.Schema2))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Pooling.InsertRecordProcedure_dbo+insertFeedProcessfileDetails", typeof(global::Pooling.InsertRecordProcedure_dbo.insertFeedProcessfileDetails))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:s0=""http://Pooling.Schema2"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:IncomingSchema"" />
  </xsl:template>
  <xsl:template match=""/s0:IncomingSchema"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDate()"" />
    <ns0:insertFeedProcessfileDetails>
      <ns0:Filename>
        <xsl:value-of select=""FeedProcessFileInfoID/FileName/text()"" />
      </ns0:Filename>
      <ns0:OrderCount>
        <xsl:value-of select=""FeedProcessFileInfoID/OrderCount/text()"" />
      </ns0:OrderCount>
      <ns0:ProcessName>
        <xsl:value-of select=""FeedProcessFileInfoID/ProcessName/text()"" />
      </ns0:ProcessName>
      <ns0:UserName>
        <xsl:value-of select=""FeedProcessFileInfoID/Username/text()"" />
      </ns0:UserName>
      <ns0:ProcessStartDate>
        <xsl:value-of select=""$var:v1"" />
      </ns0:ProcessStartDate>
      <ns0:ProcessCompletionDate>
        <xsl:value-of select=""$var:v1"" />
      </ns0:ProcessCompletionDate>
      <ns0:ModifiedDate>
        <xsl:value-of select=""$var:v2"" />
      </ns0:ModifiedDate>
      <ns0:CreateDate>
        <xsl:value-of select=""$var:v2"" />
      </ns0:CreateDate>
      <ns0:OrderURL>
        <xsl:value-of select=""FeedProcessFileInfoID/OrderUrl/text()"" />
      </ns0:OrderURL>
    </ns0:insertFeedProcessfileDetails>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Pooling.Schema2";
        
        private const global::Pooling.Schema2 _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Pooling.InsertRecordProcedure_dbo+insertFeedProcessfileDetails";
        
        private const global::Pooling.InsertRecordProcedure_dbo.insertFeedProcessfileDetails _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Pooling.Schema2";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Pooling.InsertRecordProcedure_dbo+insertFeedProcessfileDetails";
                return _TrgSchemas;
            }
        }
    }
}
