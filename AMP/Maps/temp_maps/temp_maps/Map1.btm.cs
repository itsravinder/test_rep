namespace temp_maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"temp_maps.Incoming", typeof(global::temp_maps.Incoming))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"temp_maps.outgoing", typeof(global::temp_maps.outgoing))]
    public sealed class Map1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://temp_maps.outgoing"" xmlns:s0=""http://temp_maps.outgoining"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Customer"" />
  </xsl:template>
  <xsl:template match=""/s0:Customer"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , string(LastName/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringUpperCase(string($var:v1))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringSubstring(string(MiddleInt/text()) , &quot;2&quot; , &quot;4&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(string(Address/Address1/text()) , string(Address/Address2/text()))"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringLeft(string(Address/Zip/text()) , &quot;4&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;USA&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:CustomerRecord>
      <Name>
        <xsl:value-of select=""$var:v2"" />
      </Name>
      <MiddleInt>
        <xsl:value-of select=""$var:v3"" />
      </MiddleInt>
      <Address>
        <xsl:value-of select=""$var:v4"" />
      </Address>
      <Zip>
        <xsl:value-of select=""$var:v5"" />
      </Zip>
      <State>
        <xsl:value-of select=""Address/State/text()"" />
      </State>
      <Country>
        <xsl:value-of select=""$var:v6"" />
      </Country>
      <DateandTime>
        <xsl:value-of select=""$var:v7"" />
      </DateandTime>
    </ns0:CustomerRecord>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringLeft(string str, string count)
{
	string retval = """";
	double d = 0;
	if (str != null && IsNumeric(count, ref d))
	{
		int i = (int) d;
		if (i > 0)
		{ 
			if (i <= str.Length)
			{
				retval = str.Substring(0, i);
			}
			else
			{
				retval = str;
			}
		}
	}
	return retval;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public string StringSubstring(string str, string left, string right)
{
	string retval = """";
	double dleft = 0;
	double dright = 0;
	if (str != null && IsNumeric(left, ref dleft) && IsNumeric(right, ref dright))
	{
		int lt = (int)dleft;
		int rt = (int)dright;
		lt--; rt--;
		if (lt >= 0 && rt >= lt && lt < str.Length)
		{
			if (rt < str.Length)
			{
				retval = str.Substring(lt, rt-lt+1);
			}
			else
			{
				retval = str.Substring(lt, str.Length-lt);
			}
		}
	}
	return retval;
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
        
        private const string _strSrcSchemasList0 = @"temp_maps.Incoming";
        
        private const global::temp_maps.Incoming _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"temp_maps.outgoing";
        
        private const global::temp_maps.outgoing _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"temp_maps.Incoming";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"temp_maps.outgoing";
                return _TrgSchemas;
            }
        }
    }
}
