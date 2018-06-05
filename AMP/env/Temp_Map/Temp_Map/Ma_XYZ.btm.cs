namespace Temp_Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Map.GenericSchema", typeof(global::Temp_Map.GenericSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Temp_Map.subscriber_Xyz", typeof(global::Temp_Map.subscriber_Xyz))]
    public sealed class Ma_XYZ : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Temp_Map.subscriber_Xyz"" xmlns:s0=""http://Temp_Map.GenericSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:GenericMessage"" />
  </xsl:template>
  <xsl:template match=""/s0:GenericMessage"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(&quot;Ravinder&quot;)"" />
    <ns0:Payload>
      <Data>
        <Age>
          <xsl:value-of select=""Data/Age/text()"" />
        </Age>
        <Name>
          <xsl:value-of select=""Data/Name/text()"" />
        </Name>
        <SubmissionTimer>
          <xsl:value-of select=""$var:v1"" />
        </SubmissionTimer>
        <Submitter>
          <xsl:value-of select=""$var:v2"" />
        </Submitter>
      </Data>
    </ns0:Payload>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Temp_Map.GenericSchema";
        
        private const global::Temp_Map.GenericSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Temp_Map.subscriber_Xyz";
        
        private const global::Temp_Map.subscriber_Xyz _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Temp_Map.GenericSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Temp_Map.subscriber_Xyz";
                return _TrgSchemas;
            }
        }
    }
}
