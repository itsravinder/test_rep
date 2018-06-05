
#pragma warning disable 162

namespace UntypedMessages
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Receive",
        new System.Type[]{
            typeof(UntypedMessages.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class InputMessagePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public InputMessagePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public InputMessagePortType(InputMessagePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            InputMessagePortType p = new InputMessagePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Receive = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Receive",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(InputMessagePortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Receive" ] = Receive;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Send",
        new System.Type[]{
            typeof(UntypedMessages.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class OutputMessagePortType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public OutputMessagePortType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public OutputMessagePortType(OutputMessagePortType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            OutputMessagePortType p = new OutputMessagePortType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Send = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Send",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(OutputMessagePortType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Send" ] = Send;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 328 "C:\AMP\untyped\untyped\untyped\UntypedOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "InputMessagePort", "Receive", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(UntypedMessages.InputMessagePortType),
            typeof(UntypedMessages.OutputMessagePortType)
        },
        new System.String[] {
            "InputMessagePort",
            "OutputMessagePort"
        },
        new System.Type[] {
            null,
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class UntypedOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(UntypedOrchestration));
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

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static UntypedOrchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __UntypedOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public UntypedOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "UntypedOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public UntypedOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "UntypedOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>daf18817-57c9-4d76-bdd0-f613748f8eaa</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2e540850-e12b-4875-bb10-74684f602b15</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>UntypedMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>3ecd7333-e209-491e-8d6d-023cdcebc924</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Separate Messages</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>8b3e939b-f4fa-42fe-a429-5fb07715b2b5</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Book</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2e402df5-dc51-4625-bd4a-ca4612a887ca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Message_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>62656e77-7384-4e42-99c3-93daeb8f12e3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>BuldMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a4f31d82-52fb-408d-9de5-bf3ded9e04f1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>70573150-1503-4fe4-91a9-a1ba9086a245</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>46775a71-e7fd-4657-ba47-eddf170712a7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Car</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4c5c9b74-fcf5-4920-8f36-05e216a6cb00</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Message_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>ee416620-e379-4eee-8c66-603a26c8bcf0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>BuildMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>480f78d1-bac3-4b06-a592-9250e9e1f4f3</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>1508887a-b5c7-4b7c-9b15-b4751fae3563</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>22c6055a-147f-4fea-9225-3663e2555199</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Music</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>1b699787-3e2f-42da-85a3-a7838dc9aa7c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Message_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>f46c2718-b39e-4dcb-a0de-e2ee359b88d8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>BuildMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>702f55bf-695f-4b37-99ca-1818da9dfa07</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>249630bf-d0c9-4100-aebc-b8cb98714e3a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4af31b96-9e33-4470-921a-f29a8134e9da</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>678dc521-75d8-425d-826c-d309a0e3b9a9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>WriteToLog</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>e3480423-8bb0-4195-8b67-f29e99893b5d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Terminate Process</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b44a5577-c441-47b4-bc16-8aaeed54a000</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>SendMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'UntypedOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>328</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>349</Line><Position>22</Position><ShapeID>'2e540850-e12b-4875-bb10-74684f602b15'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>358</Line><Position>13</Position><ShapeID>'3ecd7333-e209-491e-8d6d-023cdcebc924'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>363</Line><Position>17</Position><ShapeID>'2e402df5-dc51-4625-bd4a-ca4612a887ca'</ShapeID>
<Messages>
	<MsgInfo><name>BookMsg</name><part>part</part><schema>untyped.Book</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>384</Line><Position>17</Position><ShapeID>'4c5c9b74-fcf5-4920-8f36-05e216a6cb00'</ShapeID>
<Messages>
	<MsgInfo><name>CarMsg</name><part>part</part><schema>untyped.Car</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>408</Line><Position>17</Position><ShapeID>'1b699787-3e2f-42da-85a3-a7838dc9aa7c'</ShapeID>
<Messages>
	<MsgInfo><name>MusicMsg</name><part>part</part><schema>untyped.Music</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>430</Line><Position>55</Position><ShapeID>'678dc521-75d8-425d-826c-d309a0e3b9a9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>432</Line><Position>17</Position><ShapeID>'e3480423-8bb0-4195-8b67-f29e99893b5d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>435</Line><Position>13</Position><ShapeID>'b44a5577-c441-47b4-bc16-8aaeed54a000'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='9f251c00-a850-4355-ac8f-4a9eed3cc373' LowerBound='1.1' HigherBound='130.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='UntypedMessages' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5a13792c-745b-4078-9a97-b848f5471b54' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='InputMessagePortType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='38522dc1-5409-441c-9b43-8a2ade9d934d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Receive' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='b0bb841f-fdb0-4377-8762-d396e969ef2b' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='22e35d74-bb1f-472e-a58f-c94c88031fe7' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OutputMessagePortType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c3997776-6ff9-419c-9ce7-2d75dc6799fe' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Send' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f912144f-c351-4853-866d-64809e8dc006' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='29728672-d6cd-4c24-974c-197f21523eb5' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='129.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='UntypedOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='cb88c883-70b5-4ead-9b9d-d564f842a6bd' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmlDocument' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='7472b540-9bf2-4c65-9c48-fd61d40a5376' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='regId' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='fb309771-ed7b-48f6-a3f4-28e314b876c4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='32.1' HigherBound='33.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='category' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='49528ef2-6aa7-4a80-93af-3fc45cd1bfa4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='33.1' HigherBound='34.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='expectedPrice' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b90c10a7-7640-4ed1-b9d9-4be5b1854d9f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dataItem1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='48e50205-5ab5-4bb5-a56f-8518771f64b8' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='dataItem2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='c5c60686-046c-41c5-b3d6-f62b54ad2d5a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='36.1' HigherBound='37.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='operation' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='221c0703-00e7-4b86-9be8-9d5783586d13' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InputMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ff7f1339-5432-4417-809a-a98810f8fb64' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OutputMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='8b101d38-2a32-4a13-901a-23d722f2f843' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='27.1' HigherBound='28.1'>
                <om:Property Name='Type' Value='untyped.Book' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='BookMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4ba5749a-a390-4b63-bf5e-7df482858603' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='28.1' HigherBound='29.1'>
                <om:Property Name='Type' Value='untyped.Music' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MusicMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='45bb542e-c451-4590-af6c-0a04d13929b9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='untyped.Car' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CarMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='daf18817-57c9-4d76-bdd0-f613748f8eaa' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='2e540850-e12b-4875-bb10-74684f602b15' ParentLink='ServiceBody_Statement' LowerBound='39.1' HigherBound='48.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='InputMessagePort' />
                    <om:Property Name='MessageName' Value='InputMessage' />
                    <om:Property Name='OperationName' Value='Receive' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='UntypedMessage' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='3ecd7333-e209-491e-8d6d-023cdcebc924' ParentLink='ServiceBody_Statement' LowerBound='48.1' HigherBound='125.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Separate Messages' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='8b3e939b-f4fa-42fe-a429-5fb07715b2b5' ParentLink='ReallyComplexStatement_Branch' LowerBound='49.13' HigherBound='71.1'>
                        <om:Property Name='Expression' Value='// Message Type consists of TargetNamespace#SchemaRootElementName&#xD;&#xA;InputMessage(BTS.MessageType) == &quot;http://UntypedMessages.Book#BookMessage&quot;&#xD;&#xA;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Book' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='2e402df5-dc51-4625-bd4a-ca4612a887ca' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='70.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Message_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='62656e77-7384-4e42-99c3-93daeb8f12e3' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='69.1'>
                                <om:Property Name='Expression' Value='BookMsg = InputMessage;&#xD;&#xA;regId = BookMsg.RegID;&#xD;&#xA;category = &quot;BOOK&quot;;&#xD;&#xA;operation = BookMsg.Operation;&#xD;&#xA;dataItem1 = BookMsg.Author;&#xD;&#xA;dataItem2 = BookMsg.Pages;&#xD;&#xA;expectedPrice = BookMsg.ExpectedPrice;&#xD;&#xA;&#xD;&#xA;xmlDocument = new System.Xml.XmlDocument();  &#xD;&#xA;xmlDocument.LoadXml(&quot;&lt;ns0:StoreFront xmlns:ns0=&apos;http://UntypedMessages.StoreFront&apos;&gt;&lt;RegID&gt;&quot;+ regId +&quot;&lt;/RegID&gt;&lt;Category&gt;&quot;+ category +&quot;&lt;/Category&gt;&lt;ExpectedPrice&gt;&quot;+ expectedPrice +&quot;&lt;/ExpectedPrice&gt;&lt;DataItem1&gt;&quot;+ dataItem1 +&quot;&lt;/DataItem1&gt;&lt;DataItem2&gt;&quot;+ dataItem2 +&quot;&lt;/DataItem2&gt;&lt;Operation&gt;&quot;+ operation +&quot;&lt;/Operation&gt;&lt;/ns0:StoreFront&gt;&quot;);&#xD;&#xA;&#xD;&#xA;OutputMessage = xmlDocument;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='BuldMessage' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='a4f31d82-52fb-408d-9de5-bf3ded9e04f1' ParentLink='Construct_MessageRef' LowerBound='54.27' HigherBound='54.40'>
                                <om:Property Name='Ref' Value='OutputMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='70573150-1503-4fe4-91a9-a1ba9086a245' ParentLink='Construct_MessageRef' LowerBound='54.42' HigherBound='54.49'>
                                <om:Property Name='Ref' Value='BookMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='46775a71-e7fd-4657-ba47-eddf170712a7' ParentLink='ReallyComplexStatement_Branch' LowerBound='71.18' HigherBound='95.1'>
                        <om:Property Name='Expression' Value='InputMessage(BTS.MessageType) == &quot;http://UntypedMessages.Car#CarMessage&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Car' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='4c5c9b74-fcf5-4920-8f36-05e216a6cb00' ParentLink='ComplexStatement_Statement' LowerBound='74.1' HigherBound='94.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Message_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='ee416620-e379-4eee-8c66-603a26c8bcf0' ParentLink='ComplexStatement_Statement' LowerBound='77.1' HigherBound='93.1'>
                                <om:Property Name='Expression' Value='CarMsg = InputMessage;&#xD;&#xA;&#xD;&#xA;regId = CarMsg.RegID;&#xD;&#xA;category = &quot;CAR&quot;;&#xD;&#xA;operation = CarMsg.Operation;&#xD;&#xA;dataItem1 = CarMsg.Make;&#xD;&#xA;dataItem2 = CarMsg.Model;&#xD;&#xA;expectedPrice = CarMsg.ExpectedPrice;&#xD;&#xA;&#xD;&#xA;xmlDocument = new System.Xml.XmlDocument();&#xD;&#xA;&#xD;&#xA;xmlDocument = new System.Xml.XmlDocument();  &#xD;&#xA;xmlDocument.LoadXml(&quot;&lt;ns0:StoreFront xmlns:ns0=&apos;http://UntypedMessages.StoreFront&apos;&gt;&lt;RegID&gt;&quot;+ regId +&quot;&lt;/RegID&gt;&lt;Category&gt;&quot;+ category +&quot;&lt;/Category&gt;&lt;ExpectedPrice&gt;&quot;+ expectedPrice +&quot;&lt;/ExpectedPrice&gt;&lt;DataItem1&gt;&quot;+ dataItem1 +&quot;&lt;/DataItem1&gt;&lt;DataItem2&gt;&quot;+ dataItem2 +&quot;&lt;/DataItem2&gt;&lt;Operation&gt;&quot;+ operation +&quot;&lt;/Operation&gt;&lt;/ns0:StoreFront&gt;&quot;);&#xD;&#xA;&#xD;&#xA;OutputMessage = xmlDocument;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='BuildMessage' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='480f78d1-bac3-4b06-a592-9250e9e1f4f3' ParentLink='Construct_MessageRef' LowerBound='75.27' HigherBound='75.40'>
                                <om:Property Name='Ref' Value='OutputMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='1508887a-b5c7-4b7c-9b15-b4751fae3563' ParentLink='Construct_MessageRef' LowerBound='75.42' HigherBound='75.48'>
                                <om:Property Name='Ref' Value='CarMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='22c6055a-147f-4fea-9225-3663e2555199' ParentLink='ReallyComplexStatement_Branch' LowerBound='95.18' HigherBound='118.1'>
                        <om:Property Name='Expression' Value='InputMessage(BTS.MessageType) == &quot;http://UntypedMessages.Music#MusicMessage&quot;&#xD;&#xA;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Music' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='1b699787-3e2f-42da-85a3-a7838dc9aa7c' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='117.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Message_3' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='f46c2718-b39e-4dcb-a0de-e2ee359b88d8' ParentLink='ComplexStatement_Statement' LowerBound='101.1' HigherBound='116.1'>
                                <om:Property Name='Expression' Value='MusicMsg = InputMessage;&#xD;&#xA;&#xD;&#xA;regId = MusicMsg.RegID;&#xD;&#xA;category = &quot;MUSIC&quot;;&#xD;&#xA;operation = MusicMsg.Operation;&#xD;&#xA;dataItem1 = MusicMsg.Album;&#xD;&#xA;dataItem2 = MusicMsg.Artist;&#xD;&#xA;expectedPrice = MusicMsg.ExpectedPrice;&#xD;&#xA;&#xD;&#xA;xmlDocument = new System.Xml.XmlDocument();  &#xD;&#xA;xmlDocument.LoadXml(&quot;&lt;ns0:StoreFront xmlns:ns0=&apos;http://UntypedMessages.StoreFront&apos;&gt;&lt;RegID&gt;&quot;+ regId +&quot;&lt;/RegID&gt;&lt;Category&gt;&quot;+ category +&quot;&lt;/Category&gt;&lt;ExpectedPrice&gt;&quot;+ expectedPrice +&quot;&lt;/ExpectedPrice&gt;&lt;DataItem1&gt;&quot;+ dataItem1 +&quot;&lt;/DataItem1&gt;&lt;DataItem2&gt;&quot;+ dataItem2 +&quot;&lt;/DataItem2&gt;&lt;Operation&gt;&quot;+ operation +&quot;&lt;/Operation&gt;&lt;/ns0:StoreFront&gt;&quot;);&#xD;&#xA;&#xD;&#xA;OutputMessage = xmlDocument;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='BuildMessage' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='702f55bf-695f-4b37-99ca-1818da9dfa07' ParentLink='Construct_MessageRef' LowerBound='99.27' HigherBound='99.35'>
                                <om:Property Name='Ref' Value='MusicMsg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='249630bf-d0c9-4100-aebc-b8cb98714e3a' ParentLink='Construct_MessageRef' LowerBound='99.37' HigherBound='99.50'>
                                <om:Property Name='Ref' Value='OutputMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='4af31b96-9e33-4470-921a-f29a8134e9da' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='VariableAssignment' OID='678dc521-75d8-425d-826c-d309a0e3b9a9' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='122.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;Unknown Message Type Received:&quot;, InputMessage(BTS.MessageType));' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='WriteToLog' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Terminate' OID='e3480423-8bb0-4195-8b67-f29e99893b5d' ParentLink='ComplexStatement_Statement' LowerBound='122.1' HigherBound='124.1'>
                            <om:Property Name='ErrorMessage' Value='&quot;Process Terminated due to unknown message type&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Terminate Process' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='b44a5577-c441-47b4-bc16-8aaeed54a000' ParentLink='ServiceBody_Statement' LowerBound='125.1' HigherBound='127.1'>
                    <om:Property Name='PortName' Value='OutputMessagePort' />
                    <om:Property Name='MessageName' Value='OutputMessage' />
                    <om:Property Name='OperationName' Value='Send' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='SendMessage' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1cd80084-5235-4aae-b589-90d12bfb9f95' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='UntypedMessages.InputMessagePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='InputMessagePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='77a73742-eebb-425b-a173-7876fc96caa5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='287e6e09-cdbd-4a94-8ef9-5b2ce7c38542' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='22' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='UntypedMessages.OutputMessagePortType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OutputMessagePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='17df7742-02b7-4ca6-b878-d5a2d6b60c45' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __UntypedOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __UntypedOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "UntypedOrchestration")
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
                UntypedOrchestration __svc__ = (UntypedOrchestration)_service;
                __UntypedOrchestration_root_0 __ctx0__ = (__UntypedOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.OutputMessagePort != null)
                {
                    __svc__.OutputMessagePort.Close(this, null);
                    __svc__.OutputMessagePort = null;
                }
                if (__svc__.InputMessagePort != null)
                {
                    __svc__.InputMessagePort.Close(this, null);
                    __svc__.InputMessagePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __UntypedOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __UntypedOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "UntypedOrchestration")
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
                UntypedOrchestration __svc__ = (UntypedOrchestration)_service;
                __UntypedOrchestration_1 __ctx1__ = (__UntypedOrchestration_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__operation = null;
                if (__ctx1__ != null)
                    __ctx1__.__dataItem2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__dataItem1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__expectedPrice = null;
                if (__ctx1__ != null)
                    __ctx1__.__category = null;
                if (__ctx1__ != null)
                    __ctx1__.__regId = null;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__CarMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CarMsg);
                    __ctx1__.__CarMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__MusicMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MusicMsg);
                    __ctx1__.__MusicMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__BookMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__BookMsg);
                    __ctx1__.__BookMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__OutputMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OutputMessage);
                    __ctx1__.__OutputMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__InputMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__InputMessage);
                    __ctx1__.__InputMessage = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("InputMessage")]
            public __messagetype_System_Xml_XmlDocument __InputMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("OutputMessage")]
            public __messagetype_System_Xml_XmlDocument __OutputMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("BookMsg")]
            public __messagetype_untyped_Book __BookMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MusicMsg")]
            public __messagetype_untyped_Music __MusicMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CarMsg")]
            public __messagetype_untyped_Car __CarMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmlDocument")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xmlDocument;
            [Microsoft.XLANGs.Core.UserVariableAttribute("regId")]
            internal System.String __regId;
            [Microsoft.XLANGs.Core.UserVariableAttribute("category")]
            internal System.String __category;
            [Microsoft.XLANGs.Core.UserVariableAttribute("expectedPrice")]
            internal System.String __expectedPrice;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dataItem1")]
            internal System.String __dataItem1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("dataItem2")]
            internal System.String __dataItem2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("operation")]
            internal System.String __operation;
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

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("InputMessagePort")]
        internal InputMessagePortType InputMessagePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OutputMessagePort")]
        internal OutputMessagePortType OutputMessagePort;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {InputMessagePortType.Receive},
                                               typeof(UntypedOrchestration).GetField("InputMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(UntypedOrchestration), "InputMessagePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {OutputMessagePortType.Send},
                                               typeof(UntypedOrchestration).GetField("OutputMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(UntypedOrchestration), "OutputMessagePort"),
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
                h[_portInfo[1].Name] = _portInfo[1];
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

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "2e540850-e12b-4875-bb10-74684f602b15", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "2e540850-e12b-4875-bb10-74684f602b15", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "3ecd7333-e209-491e-8d6d-023cdcebc924", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "2e402df5-dc51-4625-bd4a-ca4612a887ca", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "2e402df5-dc51-4625-bd4a-ca4612a887ca", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4c5c9b74-fcf5-4920-8f36-05e216a6cb00", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4c5c9b74-fcf5-4920-8f36-05e216a6cb00", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "1b699787-3e2f-42da-85a3-a7838dc9aa7c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "1b699787-3e2f-42da-85a3-a7838dc9aa7c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "678dc521-75d8-425d-826c-d309a0e3b9a9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "678dc521-75d8-425d-826c-d309a0e3b9a9", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "e3480423-8bb0-4195-8b67-f29e99893b5d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "3ecd7333-e209-491e-8d6d-023cdcebc924", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "b44a5577-c441-47b4-bc16-8aaeed54a000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "b44a5577-c441-47b4-bc16-8aaeed54a000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,2,4,4,5,5,6,4,4,4,7,7,8,8,8,8,9,9,10,10,11,11,12,13,13,13,13,14,15,15,15,16,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __UntypedOrchestration_1 __ctx1__ = (__UntypedOrchestration_1)_stateMgrs[1];
            __UntypedOrchestration_root_0 __ctx0__ = (__UntypedOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                InputMessagePort = new InputMessagePortType(0, this);
                OutputMessagePort = new OutputMessagePortType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], InputMessagePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __UntypedOrchestration_1(this);
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
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __UntypedOrchestration_1 __ctx1__ = (__UntypedOrchestration_1)_stateMgrs[1];
            __UntypedOrchestration_root_0 __ctx0__ = (__UntypedOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__xmlDocument = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__regId = default(System.String);
                __ctx1__.__category = default(System.String);
                __ctx1__.__expectedPrice = default(System.String);
                __ctx1__.__dataItem1 = default(System.String);
                __ctx1__.__dataItem2 = default(System.String);
                __ctx1__.__operation = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!InputMessagePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__InputMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__InputMessage);
                __ctx1__.__InputMessage = new __messagetype_System_Xml_XmlDocument("InputMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__InputMessage);
                InputMessagePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__InputMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (InputMessagePort != null)
                {
                    InputMessagePort.Close(__ctx1__, __seg__);
                    InputMessagePort = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__InputMessage);
                    __edata.PortName = @"InputMessagePort";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__regId = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__category = "";
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__expectedPrice = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__dataItem1 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__dataItem2 = "";
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.__operation = "";
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __condition__ = (System.String)__ctx1__.__InputMessage.GetPropertyValueThrows(typeof(BTS.MessageType)) == "http://UntypedMessages.Book#BookMessage";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 18;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    __messagetype_System_Xml_XmlDocument __OutputMessage = new __messagetype_System_Xml_XmlDocument("OutputMessage", __ctx1__);
                    __messagetype_untyped_Book __BookMsg = new __messagetype_untyped_Book("BookMsg", __ctx1__);

                    __BookMsg.CopyFrom(__ctx1__.__InputMessage);
                    __ctx1__.__regId = (System.String)__BookMsg.part.GetDistinguishedField("RegID");
                    __ctx1__.__category = "BOOK";
                    __ctx1__.__operation = (System.String)__BookMsg.part.GetDistinguishedField("Operation");
                    __ctx1__.__dataItem1 = (System.String)__BookMsg.part.GetDistinguishedField("Author");
                    __ctx1__.__dataItem2 = (System.String)__BookMsg.part.GetDistinguishedField("Pages");
                    __ctx1__.__expectedPrice = (System.String)__BookMsg.part.GetDistinguishedField("ExpectedPrice");
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:StoreFront xmlns:ns0='http://UntypedMessages.StoreFront'><RegID>" + __ctx1__.__regId + "</RegID><Category>" + __ctx1__.__category + "</Category><ExpectedPrice>" + __ctx1__.__expectedPrice + "</ExpectedPrice><DataItem1>" + __ctx1__.__dataItem1 + "</DataItem1><DataItem2>" + __ctx1__.__dataItem2 + "</DataItem2><Operation>" + __ctx1__.__operation + "</Operation></ns0:StoreFront>");
                    __OutputMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument);

                    if (__ctx1__.__OutputMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OutputMessage);
                    __ctx1__.__OutputMessage = __OutputMessage;
                    __ctx1__.RefMessage(__ctx1__.__OutputMessage);
                    if (__ctx1__.__BookMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__BookMsg);
                    __ctx1__.__BookMsg = __BookMsg;
                    __ctx1__.RefMessage(__ctx1__.__BookMsg);
                }
                __ctx1__.__OutputMessage.ConstructionCompleteEvent(false);
                __ctx1__.__BookMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OutputMessage);
                    __edata.Messages.Add(__ctx1__.__BookMsg);
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__BookMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__BookMsg);
                    __ctx1__.__BookMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __condition__ = (System.String)__ctx1__.__InputMessage.GetPropertyValueThrows(typeof(BTS.MessageType)) == "http://UntypedMessages.Car#CarMessage";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 24;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    __messagetype_System_Xml_XmlDocument __OutputMessage = new __messagetype_System_Xml_XmlDocument("OutputMessage", __ctx1__);
                    __messagetype_untyped_Car __CarMsg = new __messagetype_untyped_Car("CarMsg", __ctx1__);

                    __CarMsg.CopyFrom(__ctx1__.__InputMessage);
                    __ctx1__.__regId = (System.String)__CarMsg.part.GetDistinguishedField("RegID");
                    __ctx1__.__category = "CAR";
                    __ctx1__.__operation = (System.String)__CarMsg.part.GetDistinguishedField("Operation");
                    __ctx1__.__dataItem1 = (System.String)__CarMsg.part.GetDistinguishedField("Make");
                    __ctx1__.__dataItem2 = (System.String)__CarMsg.part.GetDistinguishedField("Model");
                    __ctx1__.__expectedPrice = (System.String)__CarMsg.part.GetDistinguishedField("ExpectedPrice");
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:StoreFront xmlns:ns0='http://UntypedMessages.StoreFront'><RegID>" + __ctx1__.__regId + "</RegID><Category>" + __ctx1__.__category + "</Category><ExpectedPrice>" + __ctx1__.__expectedPrice + "</ExpectedPrice><DataItem1>" + __ctx1__.__dataItem1 + "</DataItem1><DataItem2>" + __ctx1__.__dataItem2 + "</DataItem2><Operation>" + __ctx1__.__operation + "</Operation></ns0:StoreFront>");
                    __OutputMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument);

                    if (__ctx1__.__OutputMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OutputMessage);
                    __ctx1__.__OutputMessage = __OutputMessage;
                    __ctx1__.RefMessage(__ctx1__.__OutputMessage);
                    if (__ctx1__.__CarMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CarMsg);
                    __ctx1__.__CarMsg = __CarMsg;
                    __ctx1__.RefMessage(__ctx1__.__CarMsg);
                }
                __ctx1__.__OutputMessage.ConstructionCompleteEvent(false);
                __ctx1__.__CarMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__OutputMessage);
                    __edata.Messages.Add(__ctx1__.__CarMsg);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CarMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CarMsg);
                    __ctx1__.__CarMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                __condition__ = (System.String)__ctx1__.__InputMessage.GetPropertyValueThrows(typeof(BTS.MessageType)) == "http://UntypedMessages.Music#MusicMessage";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 30;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                {
                    __messagetype_untyped_Music __MusicMsg = new __messagetype_untyped_Music("MusicMsg", __ctx1__);
                    __messagetype_System_Xml_XmlDocument __OutputMessage = new __messagetype_System_Xml_XmlDocument("OutputMessage", __ctx1__);

                    __MusicMsg.CopyFrom(__ctx1__.__InputMessage);
                    __ctx1__.__regId = (System.String)__MusicMsg.part.GetDistinguishedField("RegID");
                    __ctx1__.__category = "MUSIC";
                    __ctx1__.__operation = (System.String)__MusicMsg.part.GetDistinguishedField("Operation");
                    __ctx1__.__dataItem1 = (System.String)__MusicMsg.part.GetDistinguishedField("Album");
                    __ctx1__.__dataItem2 = (System.String)__MusicMsg.part.GetDistinguishedField("Artist");
                    __ctx1__.__expectedPrice = (System.String)__MusicMsg.part.GetDistinguishedField("ExpectedPrice");
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:StoreFront xmlns:ns0='http://UntypedMessages.StoreFront'><RegID>" + __ctx1__.__regId + "</RegID><Category>" + __ctx1__.__category + "</Category><ExpectedPrice>" + __ctx1__.__expectedPrice + "</ExpectedPrice><DataItem1>" + __ctx1__.__dataItem1 + "</DataItem1><DataItem2>" + __ctx1__.__dataItem2 + "</DataItem2><Operation>" + __ctx1__.__operation + "</Operation></ns0:StoreFront>");
                    __OutputMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument);

                    if (__ctx1__.__MusicMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MusicMsg);
                    __ctx1__.__MusicMsg = __MusicMsg;
                    __ctx1__.RefMessage(__ctx1__.__MusicMsg);
                    if (__ctx1__.__OutputMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__OutputMessage);
                    __ctx1__.__OutputMessage = __OutputMessage;
                    __ctx1__.RefMessage(__ctx1__.__OutputMessage);
                }
                __ctx1__.__MusicMsg.ConstructionCompleteEvent(false);
                __ctx1__.__OutputMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MusicMsg);
                    __edata.Messages.Add(__ctx1__.__OutputMessage);
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MusicMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MusicMsg);
                    __ctx1__.__MusicMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PostProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 35;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                System.Diagnostics.EventLog.WriteEntry("Unknown Message Type Received:", (System.String)__ctx1__.__InputMessage.GetPropertyValueThrows(typeof(BTS.MessageType)));
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                RequestTerminate(__ctx1__,"Process Terminated due to unknown message type");
                __seg__.SegmentDone();
                break;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__operation = null;
                if (__ctx1__ != null)
                    __ctx1__.__dataItem2 = null;
                if (__ctx1__ != null)
                    __ctx1__.__dataItem1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__expectedPrice = null;
                if (__ctx1__ != null)
                    __ctx1__.__category = null;
                if (__ctx1__ != null)
                    __ctx1__.__regId = null;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__InputMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__InputMessage);
                    __ctx1__.__InputMessage = null;
                }
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OutputMessagePort.SendMessage(0, __ctx1__.__OutputMessage, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (OutputMessagePort != null)
                {
                    OutputMessagePort.Close(__ctx1__, __seg__);
                    OutputMessagePort = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__OutputMessage);
                    __edata.PortName = @"OutputMessagePort";
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__OutputMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__OutputMessage);
                    __ctx1__.__OutputMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 45;
            case 45:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __untyped_Book__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static untyped.Book _schema = new untyped.Book();

        public __untyped_Book__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "untyped.Book",
        new System.Type[]{
            typeof(untyped.Book)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__untyped_Book__)
        },
        0,
        @"http://UntypedMessages.Book#BookMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_untyped_Book : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __untyped_Book__ part;

        private void __CreatePartWrappers()
        {
            part = new __untyped_Book__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_untyped_Book(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __untyped_Music__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static untyped.Music _schema = new untyped.Music();

        public __untyped_Music__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "untyped.Music",
        new System.Type[]{
            typeof(untyped.Music)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__untyped_Music__)
        },
        0,
        @"http://UntypedMessages.Music#MusicMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_untyped_Music : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __untyped_Music__ part;

        private void __CreatePartWrappers()
        {
            part = new __untyped_Music__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_untyped_Music(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __untyped_Car__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static untyped.Car _schema = new untyped.Car();

        public __untyped_Car__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "untyped.Car",
        new System.Type[]{
            typeof(untyped.Car)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__untyped_Car__)
        },
        0,
        @"http://UntypedMessages.Car#CarMessage"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_untyped_Car : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __untyped_Car__ part;

        private void __CreatePartWrappers()
        {
            part = new __untyped_Car__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_untyped_Car(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
