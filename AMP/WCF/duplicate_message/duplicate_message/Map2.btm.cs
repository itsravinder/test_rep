namespace duplicate_message {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"duplicate_message.output", typeof(global::duplicate_message.output))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"duplicate_message.output", typeof(global::duplicate_message.output))]
    public sealed class Map2 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://duplicate_message.output"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Root"" />
  </xsl:template>
  <xsl:template match=""/ns0:Root"">
    <ns0:Root>
      <xsl:for-each select=""record_count"">
        <xsl:variable name=""var:v1"" select=""userCSharp:MathAdd(string(./text()) , &quot;2&quot;)"" />
        <record_count>
          <xsl:value-of select=""$var:v1"" />
        </record_count>
      </xsl:for-each>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathAdd(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 0;
	foreach (string obj in listValues)
	{
	double d = 0;
		if (IsNumeric(obj, ref d))
		{
			ret += d;
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"duplicate_message.output";
        
        private const global::duplicate_message.output _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"duplicate_message.output";
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
