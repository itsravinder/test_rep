
#pragma warning disable 162

namespace Email_Notification
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Email_Notification.__messagetype_System_String)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_1(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_1(PortType_1 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_1 p = new PortType_1(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_System_String),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 208 "C:\AMP\Email\Email_Notification\Email_Not.odx"
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(Email_Notification.PortType_1)
        },
        new System.String[] {
            "EmailNotificationDynamicPort"
        },
        new System.Type[] {
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class Email_Not : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        public static readonly bool __execable = true;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy(
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.String EmailHostMsg,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.String EmailTOMsg,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.String EmailBodyMsg,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.String EmailSubjectMsg,
            [ Microsoft.XLANGs.BaseTypes.ServiceParameterAttribute(Microsoft.XLANGs.BaseTypes.EXLangSParameter.eMessage, "") ] System.String EmailFromMsg)
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Email_Not));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return false; } }

        internal bool IsExeced = false;

        static Email_Not()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 1;
            _rootContext = new __Email_Not_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Email_Not(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Email_Not", tracker)
        {
            ConstructorHelper();
        }

        public Email_Not(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Email_Not")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a6a9d91f-cfd4-4664-a1e8-9a9de1d3b787</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>02fef0eb-b0cd-4037-9298-2b1c78ac370b</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EmailHostMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>71cba895-117a-498c-b0d5-818b00828474</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EmailTOMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>b45996f9-e7ce-4815-8fbf-f01a063c4776</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>80403352-4744-4996-856b-61d4ac4e0be6</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EmailSubjectMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>3a1766b7-a2fc-4e76-aad6-206b42b9576c</ShapeID>      <ParentLink>ServiceBody_Declaration</ParentLink>                <shapeText>EmailFromMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>e36e4c1c-1039-42f8-a45f-733fb9f33a84</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>5dd71ce0-78b4-4b3a-99fe-59969a3be58c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>f818d72a-0abb-47ec-a5e2-32844359e4c3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>889d6fb0-d16e-441f-8be3-425ded4e5226</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2e630a17-2b0e-4079-8308-8cd5bd177f7a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1de9eee3-325b-4970-9b58-bc4420170090</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>d030e18b-45ed-4b5f-ac05-6a77e3194d32</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>cb7635b0-d9b6-4d9a-951d-8e2eb117655b</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Smtp_Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Email_Not'</ActionName><IsAtomic>0</IsAtomic><Line>208</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>226</Line><Position>13</Position><ShapeID>'e36e4c1c-1039-42f8-a45f-733fb9f33a84'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>231</Line><Position>33</Position><ShapeID>'5dd71ce0-78b4-4b3a-99fe-59969a3be58c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>240</Line><Position>21</Position><ShapeID>'f818d72a-0abb-47ec-a5e2-32844359e4c3'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>21</Position><ShapeID>'1de9eee3-325b-4970-9b58-bc4420170090'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>262</Line><Position>21</Position><ShapeID>'d030e18b-45ed-4b5f-ac05-6a77e3194d32'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>63</Position><ShapeID>'cb7635b0-d9b6-4d9a-951d-8e2eb117655b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='b2a88f9e-83b9-458f-916a-514a6be86b34' LowerBound='1.1' HigherBound='76.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Email_Notification' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5ea1e5db-3290-4fe2-bc3c-2627219a95b2' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='514384d6-bcc3-4017-a0b6-3f6e171e734b' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='f893e575-720c-43dd-96f3-210d5d7a9691' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='System.String' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='a91ca7d4-0c0e-4db9-b900-ef63efbea37f' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='75.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Email_Not' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='b97804c0-3f7e-4116-b082-12f5002e23e3' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='17.1' HigherBound='18.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EMailServer' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='419d7d8f-dee2-481d-a6ec-7866b59cd1c1' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='18.1' HigherBound='19.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailFrom' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dee25a56-3eb5-4975-aba9-09a9fe323a66' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='19.1' HigherBound='20.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailTO' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='4af95dac-b6a1-4411-baea-79aaf80742db' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='20.1' HigherBound='21.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailBodyMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='361cf9c0-375d-4870-a646-a3176c60af52' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='21.1' HigherBound='22.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailSubject' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4bfaa202-9907-4baf-aca1-a24916ca08bf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='16.1' HigherBound='17.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendEmailMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a6a9d91f-cfd4-4664-a1e8-9a9de1d3b787' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageDeclaration' OID='02fef0eb-b0cd-4037-9298-2b1c78ac370b' ParentLink='ServiceBody_Declaration' LowerBound='22.15' HigherBound='22.49'>
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EmailHostMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='71cba895-117a-498c-b0d5-818b00828474' ParentLink='ServiceBody_Declaration' LowerBound='22.51' HigherBound='22.83'>
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EmailTOMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='b45996f9-e7ce-4815-8fbf-f01a063c4776' ParentLink='ServiceBody_Declaration' LowerBound='22.85' HigherBound='22.119'>
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EmailBodyMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='80403352-4744-4996-856b-61d4ac4e0be6' ParentLink='ServiceBody_Declaration' LowerBound='22.121' HigherBound='22.158'>
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EmailSubjectMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageDeclaration' OID='3a1766b7-a2fc-4e76-aad6-206b42b9576c' ParentLink='ServiceBody_Declaration' LowerBound='22.160' HigherBound='22.194'>
                    <om:Property Name='Type' Value='System.String' />
                    <om:Property Name='ParamDirection' Value='In' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='EmailFromMsg' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='e36e4c1c-1039-42f8-a45f-733fb9f33a84' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='73.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='5dd71ce0-78b4-4b3a-99fe-59969a3be58c' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='43.1'>
                        <om:Property Name='Expression' Value='EMailServer = EmailHostMsg;&#xD;&#xA;EmailFrom = EmailFromMsg;&#xD;&#xA;&#xD;&#xA;EmailTO = EmailTOMsg;&#xD;&#xA;EmailNotificationDynamicPort(Microsoft.XLANGs.BaseTypes.Address) = &quot;mailto:&quot; + EmailTO;&#xD;&#xA;&#xD;&#xA;EmailBodyMessage = EmailBodyMsg;&#xD;&#xA;EmailSubject = EmailSubjectMsg;&#xD;&#xA;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Expression_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='f818d72a-0abb-47ec-a5e2-32844359e4c3' ParentLink='ComplexStatement_Statement' LowerBound='43.1' HigherBound='60.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='889d6fb0-d16e-441f-8be3-425ded4e5226' ParentLink='ComplexStatement_Statement' LowerBound='46.1' HigherBound='59.1'>
                            <om:Property Name='Expression' Value='SendEmailMessage = System.String.Empty;&#xD;&#xA;&#xD;&#xA;SendEmailMessage(SMTP.SMTPHost) = EMailServer;&#xD;&#xA;&#xD;&#xA;SendEmailMessage(SMTP.From) =EmailFrom;&#xD;&#xA;&#xD;&#xA;SendEmailMessage(SMTP.Subject)= EmailSubject;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;SendEmailMessage(SMTP.EmailBodyText) = EmailSubject;&#xD;&#xA;SendEmailMessage(SMTP.EmailBodyTextCharset) = &quot;utf-8&quot;;&#xD;&#xA;SendEmailMessage(SMTP.MessagePartsAttachments) = 0;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='2e630a17-2b0e-4079-8308-8cd5bd177f7a' ParentLink='Construct_MessageRef' LowerBound='44.31' HigherBound='44.47'>
                            <om:Property Name='Ref' Value='SendEmailMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='1de9eee3-325b-4970-9b58-bc4420170090' ParentLink='ComplexStatement_Statement' LowerBound='60.1' HigherBound='62.1'>
                        <om:Property Name='PortName' Value='EmailNotificationDynamicPort' />
                        <om:Property Name='MessageName' Value='SendEmailMessage' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_1' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='d030e18b-45ed-4b5f-ac05-6a77e3194d32' ParentLink='Scope_Catch' LowerBound='65.1' HigherBound='71.1'>
                        <om:Property Name='ExceptionName' Value='EX' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='cb7635b0-d9b6-4d9a-951d-8e2eb117655b' ParentLink='Catch_Statement' LowerBound='68.1' HigherBound='70.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;SmtpException&quot;,EX.Message);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Smtp_Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c80eb1d9-461c-4251-a0ac-03277fe20b5b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Email_Notification.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailNotificationDynamicPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='476e9523-bcb8-4bdd-8479-ae25795b0045' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Email_Not_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Email_Not_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Email_Not")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Email_Not __svc__ = (Email_Not)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __Email_Not_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Email_Not_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Email_Not")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Email_Not __svc__ = (Email_Not)_service;
                __Email_Not_root_0 __ctx0__ = (__Email_Not_root_0)(__svc__._stateMgrs[0]);
                __Email_Not_1 __ctx1__ = (__Email_Not_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__EmailTOMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailTOMsg);
                    __ctx1__.__EmailTOMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__EMailServer = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailFrom = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailTO = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailBodyMessage = null;
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__EmailSubject = null;
                if (__svc__.EmailNotificationDynamicPort != null)
                {
                    __svc__.EmailNotificationDynamicPort.Close(this, null);
                    __svc__.EmailNotificationDynamicPort = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("SendEmailMessage")]
            public __messagetype_System_String __SendEmailMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailHostMsg")]
            public __messagetype_System_String __EmailHostMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailTOMsg")]
            public __messagetype_System_String __EmailTOMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailBodyMsg")]
            public __messagetype_System_String __EmailBodyMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailSubjectMsg")]
            public __messagetype_System_String __EmailSubjectMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailFromMsg")]
            public __messagetype_System_String __EmailFromMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EMailServer")]
            internal System.String __EMailServer;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailFrom")]
            internal System.String __EmailFrom;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailTO")]
            internal System.String __EmailTO;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailBodyMessage")]
            internal System.String __EmailBodyMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailSubject")]
            internal System.String __EmailSubject;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                Email_Not __svc__ = (Email_Not)_service;
                __Email_Not_1 __ctx1__ = (__Email_Not_1)(__svc__._stateMgrs[1]);
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__SendEmailMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SendEmailMessage);
                    __ctx1__.__SendEmailMessage = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__EX_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __EX_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("EmailNotificationDynamicPort")]
        internal PortType_1 EmailNotificationDynamicPort;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(Email_Not).GetField("EmailNotificationDynamicPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Email_Not), "EmailNotificationDynamicPort"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }


        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e36e4c1c-1039-42f8-a45f-733fb9f33a84", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "5dd71ce0-78b4-4b3a-99fe-59969a3be58c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "5dd71ce0-78b4-4b3a-99fe-59969a3be58c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "f818d72a-0abb-47ec-a5e2-32844359e4c3", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "f818d72a-0abb-47ec-a5e2-32844359e4c3", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "1de9eee3-325b-4970-9b58-bc4420170090", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "1de9eee3-325b-4970-9b58-bc4420170090", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "d030e18b-45ed-4b5f-ac05-6a77e3194d32", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "cb7635b0-d9b6-4d9a-951d-8e2eb117655b", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "cb7635b0-d9b6-4d9a-951d-8e2eb117655b", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "d030e18b-45ed-4b5f-ac05-6a77e3194d32", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "e36e4c1c-1039-42f8-a45f-733fb9f33a84", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,1,1,2,2,2,15,1,1,1,1,};
        public static int[] __progressLocation2 = new int[] { 4,4,4,5,5,5,5,5,5,7,7,8,9,9,9,10,10,10,10,};
        public static int[] __progressLocation3 = new int[] { 11,11,12,12,13,14,14,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Email_Not_root_0 __ctx0__ = (__Email_Not_root_0)_stateMgrs[0];
            __Email_Not_1 __ctx1__ = (__Email_Not_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                EmailNotificationDynamicPort = new PortType_1(0, this);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Email_Not_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Email_Not_root_0 __ctx0__ = (__Email_Not_root_0)_stateMgrs[0];
            __Email_Not_1 __ctx1__ = (__Email_Not_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__EmailHostMsg = new __messagetype_System_String("EmailHostMsg", __ctx1__);
                __ctx1__.__EmailHostMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[0]);
                __ctx1__.RefMessage(__ctx1__.__EmailHostMsg);
                __ctx1__.__EmailHostMsg.ConstructionCompleteEvent();
                __ctx1__.__EmailTOMsg = new __messagetype_System_String("EmailTOMsg", __ctx1__);
                __ctx1__.__EmailTOMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[1]);
                __ctx1__.RefMessage(__ctx1__.__EmailTOMsg);
                __ctx1__.__EmailTOMsg.ConstructionCompleteEvent();
                __ctx1__.__EmailBodyMsg = new __messagetype_System_String("EmailBodyMsg", __ctx1__);
                __ctx1__.__EmailBodyMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[2]);
                __ctx1__.RefMessage(__ctx1__.__EmailBodyMsg);
                __ctx1__.__EmailBodyMsg.ConstructionCompleteEvent();
                __ctx1__.__EmailSubjectMsg = new __messagetype_System_String("EmailSubjectMsg", __ctx1__);
                __ctx1__.__EmailSubjectMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[3]);
                __ctx1__.RefMessage(__ctx1__.__EmailSubjectMsg);
                __ctx1__.__EmailSubjectMsg.ConstructionCompleteEvent();
                __ctx1__.__EmailFromMsg = new __messagetype_System_String("EmailFromMsg", __ctx1__);
                __ctx1__.__EmailFromMsg.CopyFrom((Microsoft.XLANGs.Core.XMessage)Args[4]);
                __ctx1__.RefMessage(__ctx1__.__EmailFromMsg);
                __ctx1__.__EmailFromMsg.ConstructionCompleteEvent();
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx1__.__EMailServer = default(System.String);
                __ctx1__.__EmailFrom = default(System.String);
                __ctx1__.__EmailTO = default(System.String);
                __ctx1__.__EmailBodyMessage = default(System.String);
                __ctx1__.__EmailSubject = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __ctx1__.__EMailServer = "";
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.__EmailFrom = "";
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__EmailTO = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__EmailBodyMessage = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__EmailSubject = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[2],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__EmailSubject = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailBodyMessage = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailTO = null;
                if (__ctx1__ != null)
                    __ctx1__.__EmailFrom = null;
                if (__ctx1__ != null)
                    __ctx1__.__EMailServer = null;
                if (EmailNotificationDynamicPort != null)
                {
                    EmailNotificationDynamicPort.Close(__ctx1__, __seg__);
                    EmailNotificationDynamicPort = null;
                }
                Tracker.FireEvent(__eventLocations[15],__eventData[9],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body);
                    __edata.Messages.Add(__ctx1__.__EmailHostMsg);
                    __edata.Messages.Add(__ctx1__.__EmailTOMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailSubjectMsg);
                    __edata.Messages.Add(__ctx1__.__EmailFromMsg);
                    Tracker.FireEvent(__eventLocations[0],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailTOMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailTOMsg);
                    __ctx1__.__EmailTOMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Email_Not_root_0 __ctx0__ = (__Email_Not_root_0)_stateMgrs[0];
            __Email_Not_1 __ctx1__ = (__Email_Not_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__EMailServer = __ctx1__.__EmailHostMsg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__EmailFrom = __ctx1__.__EmailFromMsg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__EmailTO = __ctx1__.__EmailTOMsg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                EmailNotificationDynamicPort.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "mailto:" + __ctx1__.__EmailTO);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__EmailBodyMessage = __ctx1__.__EmailBodyMsg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__EmailSubject = __ctx1__.__EmailSubjectMsg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_System_String __SendEmailMessage = new __messagetype_System_String("SendEmailMessage", __ctx1__);

                    __SendEmailMessage.part.LoadFrom(System.String.Empty);
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.SMTPHost), __ctx1__.__EMailServer);
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.From), __ctx1__.__EmailFrom);
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.Subject), __ctx1__.__EmailSubject);
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.EmailBodyText), __ctx1__.__EmailSubject);
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.EmailBodyTextCharset), "utf-8");
                    __SendEmailMessage.SetPropertyValue(typeof(SMTP.MessagePartsAttachments), (System.UInt32)(0U));

                    if (__ctx1__.__SendEmailMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__SendEmailMessage);
                    __ctx1__.__SendEmailMessage = __SendEmailMessage;
                    __ctx1__.RefMessage(__ctx1__.__SendEmailMessage);
                }
                __ctx1__.__SendEmailMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__SendEmailMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                EmailNotificationDynamicPort.SendMessage(0, __ctx1__.__SendEmailMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__SendEmailMessage);
                    __edata.PortName = @"EmailNotificationDynamicPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__SendEmailMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__SendEmailMessage);
                    __ctx1__.__SendEmailMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 18;
            case 18:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("SmtpException", __ctx2__.__EX_0.Message);
                if (__ctx2__ != null)
                    __ctx2__.__EX_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_4.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.String' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='string' nillable='true' type='xs:string' />
</xs:schema>",
        @"string",
        null,
        typeof(System.String),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_String__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_String__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.String); } }
        public System.String TypedValue { get { return (System.String) this.RetrieveAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        public System.String WriteableTypedValue { get { return (System.String) this.RetrieveForWriteAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.String); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.String",
        new System.Type[]{
            typeof(System.String)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__System_String__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_String : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ part;

        private void __CreatePartWrappers()
        {
            part = new __System_String__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_String(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
