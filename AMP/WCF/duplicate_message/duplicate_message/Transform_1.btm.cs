namespace duplicate_message {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"duplicate_message.input", typeof(global::duplicate_message.input))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"duplicate_message.output", typeof(global::duplicate_message.output))]
    public sealed class Transform_1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://duplicate_message.output"" xmlns:s0=""http://duplicate_message.input"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:Root>
      <xsl:variable name=""var:v2"" select=""userCSharp:myDateTime(string($var:v1))"" />
      <record_count>
        <xsl:value-of select=""$var:v2"" />
      </record_count>
    </ns0:Root>
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


public String myDateTime(String s )
{

DateTime dt = DateTime.Now;

return dt.ToString("" yyyyMMddHHmmss"");

}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"duplicate_message.input";
        
        private const global::duplicate_message.input _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"duplicate_message.output";
        
        private const global::duplicate_message.output _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"duplicate_message.input";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"duplicate_message.output";
                return _TrgSchemas;
            }
        }
    }
}
