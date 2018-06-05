namespace Envenlope
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ReceivePipeline1 : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Micro"+
"soft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35<"+
"/Name>          <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML "+
"disassembler</Description>          <Version>1.0</Version>          <Properties>            <Propert"+
"y Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\">Envenlope.Order_Envelope</Valu"+
"e>            </Property>            <Property Name=\"EnvelopeSpecTargetNamespaces\">              <Va"+
"lue xsi:type=\"xsd:string\">http://Envenlope.Order_Envelope</Value>            </Property>            "+
"<Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\">Envenlope.order</Value"+
">            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">              <Val"+
"ue xsi:type=\"xsd:string\">http://Envenlope.order</Value>            </Property>            <Property "+
"Name=\"AllowUnrecognizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>           "+
" </Property>            <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean"+
"\">false</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessing\">"+
"              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Propert"+
"y Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Do"+
"cumentSpecTargetNamespaces</Value>            </Property>          </Properties>          <CachedDis"+
"playName>XML disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>      "+
"  </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _"+
"locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-"+
"83fa-4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData="+
"\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410"+
"e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "ce515a2c-9fd6-4259-89fa-9b3503c8efa6";
        
        public ReceivePipeline1()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\">Envenlope.Order_Envelope</Value>    </Property>    <Property "+
"Name=\"EnvelopeSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://Envenlope.Order_Envelo"+
"pe</Value>    </Property>    <Property Name=\"DocumentSpecNames\">      <Value xsi:type=\"xsd:string\">E"+
"nvenlope.order</Value>    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\">      <Value "+
"xsi:type=\"xsd:string\">http://Envenlope.order</Value>    </Property>    <Property Name=\"AllowUnrecogn"+
"izedMessage\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Val"+
"idateDocument\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"R"+
"ecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>   "+
" <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,D"+
"ocumentSpecTargetNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
