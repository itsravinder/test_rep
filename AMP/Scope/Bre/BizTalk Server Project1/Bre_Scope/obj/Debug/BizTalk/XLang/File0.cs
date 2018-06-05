
#pragma warning disable 162

namespace Bre_Scope
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Bre_Scope.__messagetype_Bre_Scope_LoanApplication)
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
            typeof(__messagetype_Bre_Scope_LoanApplication),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Bre_Scope.__messagetype_Microsoft_XLANGs_BaseTypes_Any)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_2 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2(PortType_2 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2 p = new PortType_2(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2),
            typeof(__messagetype_Microsoft_XLANGs_BaseTypes_Any),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Bre_Scope.__messagetype_Bre_Scope_LoanApproval)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_3 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_3(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_3(PortType_3 p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_3 p = new PortType_3(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_3),
            typeof(__messagetype_Bre_Scope_LoanApproval),
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
    //#line 300 "C:\AMP\Scope\Bre\BizTalk Server Project1\Bre_Scope\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(Bre_Scope.PortType_1),
            typeof(Bre_Scope.PortType_3),
            typeof(Bre_Scope.PortType_2)
        },
        new System.String[] {
            "Port_1",
            "Port_3",
            "Port_2"
        },
        new System.Type[] {
            null,
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
    sealed internal class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalk_Orchestration1));
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

        static BizTalk_Orchestration1()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 2, 4)
            };

            _Locks = 1;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalk_Orchestration1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalk_Orchestration1", tracker)
        {
            ConstructorHelper();
        }

        public BizTalk_Orchestration1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalk_Orchestration1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>a0755119-8ccc-44eb-986c-b5522aa47b49</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>d8800b33-4628-485e-af4b-4c394e3e016f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>d40b1837-8621-46e9-a488-32331e988801</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>6884bd3f-4b3a-4035-9128-fc89ed663df9</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ddceb6c0-0618-4e9f-beae-d880d2ba848f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>9eb4c553-859c-4d48-a85a-61ddd70e0854</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3fcb0b33-2f8e-4ea9-9b7d-d46004e14ce8</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>348588d7-8d44-4f43-978d-c1db589e9a79</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>384f17c5-79f3-4d7c-8709-cde5be11dd85</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CallRulesShape</shapeType>      <ShapeID>a160c3fa-ed11-4a59-af74-1f94e5bfad37</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CallRules_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>RulesParameterRefShape</shapeType>      <ShapeID>4a561355-6ea4-42a3-8b8d-98c5ce0df173</ShapeID>      <ParentLink>CallRules_RulesParameterRef</ParentLink>                <shapeText>RulesParameterRef_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>ebcb47c4-202a-44ee-aca7-62a4f9467250</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>e1e46a94-3a52-4bb2-acc1-0ae63c9bdafe</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_1</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>8094639d-b303-4b69-ab68-9c2c3d5fca4c</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ea72d06b-686d-4d5d-985c-0611a7c0995c</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>61ef93ba-f2cd-43ff-80a4-8008d76415a4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>50660e50-ce68-4835-988e-e731c845cf6e</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>83364430-e2bb-4d20-bf8f-4b1e9e7e3918</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>d863a50a-ee6b-46b7-81fe-326407c93841</ShapeID>      <ParentLink>Scope_MessageDeclaration</ParentLink>                <shapeText>Out_msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageDeclarationShape</shapeType>      <ShapeID>507ec743-1d5b-4b38-8768-4a53e888bdc9</ShapeID>      <ParentLink>Scope_MessageDeclaration</ParentLink>                <shapeText>Any_Msg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>300</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>313</Line><Position>22</Position><ShapeID>'d8800b33-4628-485e-af4b-4c394e3e016f'</ShapeID>
<Messages>
	<MsgInfo><name>In_msg</name><part>part</part><schema>Bre_Scope.LoanApplication</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>316</Line><Position>31</Position><ShapeID>'d40b1837-8621-46e9-a488-32331e988801'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>318</Line><Position>13</Position><ShapeID>'6884bd3f-4b3a-4035-9128-fc89ed663df9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>325</Line><Position>21</Position><ShapeID>'ddceb6c0-0618-4e9f-beae-d880d2ba848f'</ShapeID>
<Messages>
	<MsgInfo><name>Out_msg</name><part>part</part><schema>Bre_Scope.LoanApproval</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>In_msg</name><part>part</part><schema>Bre_Scope.LoanApplication</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope34'</ActionName><IsAtomic>0</IsAtomic><Line>332</Line><Position>21</Position><ShapeID>'a160c3fa-ed11-4a59-af74-1f94e5bfad37'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>355</Line><Position>21</Position><ShapeID>'ebcb47c4-202a-44ee-aca7-62a4f9467250'</ShapeID>
<Messages>
	<MsgInfo><name>Out_msg</name><part>part</part><schema>Bre_Scope.LoanApproval</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>360</Line><Position>21</Position><ShapeID>'e1e46a94-3a52-4bb2-acc1-0ae63c9bdafe'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>363</Line><Position>63</Position><ShapeID>'8094639d-b303-4b69-ab68-9c2c3d5fca4c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>365</Line><Position>25</Position><ShapeID>'ea72d06b-686d-4d5d-985c-0611a7c0995c'</ShapeID>
<Messages>
	<MsgInfo><name>Any_Msg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>384</Line><Position>25</Position><ShapeID>'83364430-e2bb-4d20-bf8f-4b1e9e7e3918'</ShapeID>
<Messages>
	<MsgInfo><name>Any_Msg</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='89260cb0-26c8-4f8b-bc37-63031bc5f80f' LowerBound='1.1' HigherBound='117.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Bre_Scope' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5399c362-5b8a-41d6-bf31-110e4f189923' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='027f23ed-a7f1-44d6-8410-8a5f7977ece3' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='80db2e88-b41e-4aff-82ad-5cfdccea4d77' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.28'>
                    <om:Property Name='Ref' Value='Bre_Scope.LoanApplication' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='4044186b-a308-411d-84f5-fca866671947' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='52db6112-982a-497b-a868-718698c7619c' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='764288b2-ddb6-4577-9db6-9834300f0b39' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.43'>
                    <om:Property Name='Ref' Value='Microsoft.XLANGs.BaseTypes.Any' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='483fbf85-2072-457d-a040-65a04ace46bf' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_3' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c5cbb574-fc94-4866-b2a5-2cefb45ee7f0' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='cc188dca-66b7-4e31-986e-bff03f9a5da1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.25'>
                    <om:Property Name='Ref' Value='Bre_Scope.LoanApproval' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='008a96b1-ff06-4af8-9c21-057d7181b908' ParentLink='Module_ServiceDeclaration' LowerBound='25.1' HigherBound='116.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='60255fb3-2bab-4348-8a45-4056149ddd49' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='35.1' HigherBound='36.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Variable_1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='008dbde4-5663-4585-bbc3-75f101fa32ef' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='34.1' HigherBound='35.1'>
                <om:Property Name='Type' Value='Bre_Scope.LoanApplication' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='In_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='a0755119-8ccc-44eb-986c-b5522aa47b49' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='d8800b33-4628-485e-af4b-4c394e3e016f' ParentLink='ServiceBody_Statement' LowerBound='38.1' HigherBound='41.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='In_msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='d40b1837-8621-46e9-a488-32331e988801' ParentLink='ServiceBody_Statement' LowerBound='41.1' HigherBound='43.1'>
                    <om:Property Name='Expression' Value='Variable_1.LoadXml(&quot;&lt;a&gt;&lt;/a&gt;&quot;);' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Scope' OID='6884bd3f-4b3a-4035-9128-fc89ed663df9' ParentLink='ServiceBody_Statement' LowerBound='43.1' HigherBound='114.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Construct' OID='ddceb6c0-0618-4e9f-beae-d880d2ba848f' ParentLink='ComplexStatement_Statement' LowerBound='50.1' HigherBound='56.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructMessage_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Transform' OID='9eb4c553-859c-4d48-a85a-61ddd70e0854' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='55.1'>
                            <om:Property Name='ClassName' Value='Bre_Scope.LoanApprovalMap' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Transform_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessagePartRef' OID='3fcb0b33-2f8e-4ea9-9b7d-d46004e14ce8' ParentLink='Transform_InputMessagePartRef' LowerBound='54.74' HigherBound='54.80'>
                                <om:Property Name='MessageRef' Value='In_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='348588d7-8d44-4f43-978d-c1db589e9a79' ParentLink='Transform_OutputMessagePartRef' LowerBound='54.36' HigherBound='54.43'>
                                <om:Property Name='MessageRef' Value='Out_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='384f17c5-79f3-4d7c-8709-cde5be11dd85' ParentLink='Construct_MessageRef' LowerBound='51.31' HigherBound='51.38'>
                            <om:Property Name='Ref' Value='Out_msg' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='CallRules' OID='a160c3fa-ed11-4a59-af74-1f94e5bfad37' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='80.1'>
                        <om:Property Name='PolicyName' Value='LoanApproval' />
                        <om:Property Name='PolicyVersion' Value='-1' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CallRules_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='RulesParameterRef' OID='4a561355-6ea4-42a3-8b8d-98c5ce0df173' ParentLink='CallRules_RulesParameterRef'>
                            <om:Property Name='Reference' Value='Out_msg' />
                            <om:Property Name='Alias' Value='Bre_Scope.LoanApproval' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='RulesParameterRef_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='ebcb47c4-202a-44ee-aca7-62a4f9467250' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='82.1'>
                        <om:Property Name='PortName' Value='Port_3' />
                        <om:Property Name='MessageName' Value='Out_msg' />
                        <om:Property Name='OperationName' Value='Operation_1' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Send_2' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='e1e46a94-3a52-4bb2-acc1-0ae63c9bdafe' ParentLink='Scope_Catch' LowerBound='85.1' HigherBound='112.1'>
                        <om:Property Name='ExceptionName' Value='EX' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchException_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='8094639d-b303-4b69-ab68-9c2c3d5fca4c' ParentLink='Catch_Statement' LowerBound='88.1' HigherBound='90.1'>
                            <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;Error&quot;,EX.Message);' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='Construct' OID='ea72d06b-686d-4d5d-985c-0611a7c0995c' ParentLink='Catch_Statement' LowerBound='90.1' HigherBound='109.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='61ef93ba-f2cd-43ff-80a4-8008d76415a4' ParentLink='ComplexStatement_Statement' LowerBound='93.1' HigherBound='108.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;Port_2(Microsoft.XLANGs.BaseTypes.Address)= &quot;mailto:ravinder.kampa@gmail.com&quot;;&#xD;&#xA;Port_2(Microsoft.XLANGs.BaseTypes.TransportType)=&quot;SMTP&quot; ;&#xD;&#xA;&#xD;&#xA;Variable_1.LoadXml(&quot;&lt;a&gt;&lt;/a&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Any_Msg=Variable_1;&#xD;&#xA;&#xD;&#xA;Any_Msg(SMTP.CC) = &quot;ravinder.nani63@gmail.com &quot;;&#xD;&#xA;Any_Msg(SMTP.Subject) = &quot;error:&quot;+EX.Message;&#xD;&#xA;&#xD;&#xA;Any_Msg(SMTP.SMTPHost) = &quot;mail.rrd.com&quot;;&#xD;&#xA;Any_Msg(SMTP.SMTPAuthenticate) = 0;&#xD;&#xA;Any_Msg(SMTP.From) = &quot;ravinder.kampa@rrd.com &quot;;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='50660e50-ce68-4835-988e-e731c845cf6e' ParentLink='Construct_MessageRef' LowerBound='91.35' HigherBound='91.42'>
                                <om:Property Name='Ref' Value='Any_Msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='83364430-e2bb-4d20-bf8f-4b1e9e7e3918' ParentLink='Catch_Statement' LowerBound='109.1' HigherBound='111.1'>
                            <om:Property Name='PortName' Value='Port_2' />
                            <om:Property Name='MessageName' Value='Any_Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageDeclaration' OID='d863a50a-ee6b-46b7-81fe-326407c93841' ParentLink='Scope_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                        <om:Property Name='Type' Value='Bre_Scope.LoanApproval' />
                        <om:Property Name='ParamDirection' Value='In' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Out_msg' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='MessageDeclaration' OID='507ec743-1d5b-4b38-8768-4a53e888bdc9' ParentLink='Scope_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                        <om:Property Name='Type' Value='Microsoft.XLANGs.BaseTypes.Any' />
                        <om:Property Name='ParamDirection' Value='In' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Any_Msg' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='01c4bb07-a943-41cc-9cb3-96f0a4646842' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='28.1' HigherBound='30.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Bre_Scope.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e4e21e2e-1642-4c84-91b3-a632420f8365' ParentLink='PortDeclaration_CLRAttribute' LowerBound='28.1' HigherBound='29.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='eda0de77-51b5-484a-88c3-ce26a0f294a8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='30.1' HigherBound='32.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Bre_Scope.PortType_3' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_3' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c64ad6eb-4fac-4bf7-bed0-31c216542e60' ParentLink='PortDeclaration_CLRAttribute' LowerBound='30.1' HigherBound='31.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='f3ae6bfe-27ad-4f7c-9b94-3510883c7161' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='14' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Bre_Scope.PortType_2' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_2' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='2849e2b4-1bc5-4296-8f3f-88ad21301378' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.PassThruTransmit' />
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
        public class __BizTalk_Orchestration1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalk_Orchestration1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_3 != null)
                {
                    __svc__.Port_3.Close(this, null);
                    __svc__.Port_3 = null;
                }
                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __BizTalk_Orchestration1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalk_Orchestration1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalk_Orchestration1")
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)(__svc__._stateMgrs[0]);
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                if (__ctx1__ != null && __ctx1__.__In_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                    __ctx1__.__In_msg = null;
                }
                if (__svc__.Port_2 != null)
                {
                    __svc__.Port_2.Close(this, null);
                    __svc__.Port_2 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("In_msg")]
            public __messagetype_Bre_Scope_LoanApplication __In_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Variable_1")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __Variable_1;
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
                        __seg__ = _service._segments[4];
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
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);

                if (__ctx2__ != null)
                    __ctx2__.__EX_0 = null;
                if (__ctx2__ != null && __ctx2__.__Out_msg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__Out_msg);
                    __ctx2__.__Out_msg = null;
                }
                if (__ctx2__ != null && __ctx2__.__Any_Msg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__Any_Msg);
                    __ctx2__.__Any_Msg = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Out_msg")]
            public __messagetype_Bre_Scope_LoanApproval __Out_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Any_Msg")]
            public __messagetype_Microsoft_XLANGs_BaseTypes_Any __Any_Msg;
            internal object __exv__;
            internal System.Exception __EX_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope34_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope34_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope34")
            {
            }

            public override int Index { get { return 3; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                BizTalk_Orchestration1 __svc__ = (BizTalk_Orchestration1)_service;
                ____scope34_3 __ctx3__ = (____scope34_3)(__svc__._stateMgrs[3]);

                if (__ctx3__ != null)
                    __ctx3__.__policyParamAsTXD_1_1__ = null;
                if (__ctx3__ != null)
                    __ctx3__.__policyParam_1_1__ = null;
                if (__ctx3__ != null)
                    __ctx3__.__policy_1__ = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("policy_1__")]
            internal Microsoft.RuleEngine.Policy __policy_1__;
            [Microsoft.XLANGs.Core.UserVariableAttribute("policyParam_1_1__")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __policyParam_1_1__;
            [Microsoft.XLANGs.Core.UserVariableAttribute("policyParamAsTXD_1_1__")]
            internal Microsoft.RuleEngine.TypedXmlDocument __policyParamAsTXD_1_1__;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_3")]
        internal PortType_3 Port_3;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.PassThruTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_2")]
        internal PortType_2 Port_2;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_3.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_3", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_3"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_2.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_2", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_2"),
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
                h[_portInfo[2].Name] = _portInfo[2];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "d8800b33-4628-485e-af4b-4c394e3e016f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "d8800b33-4628-485e-af4b-4c394e3e016f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "d40b1837-8621-46e9-a488-32331e988801", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "d40b1837-8621-46e9-a488-32331e988801", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "6884bd3f-4b3a-4035-9128-fc89ed663df9", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "ddceb6c0-0618-4e9f-beae-d880d2ba848f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "ddceb6c0-0618-4e9f-beae-d880d2ba848f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "a160c3fa-ed11-4a59-af74-1f94e5bfad37", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "a160c3fa-ed11-4a59-af74-1f94e5bfad37", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "ebcb47c4-202a-44ee-aca7-62a4f9467250", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "ebcb47c4-202a-44ee-aca7-62a4f9467250", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "e1e46a94-3a52-4bb2-acc1-0ae63c9bdafe", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "8094639d-b303-4b69-ab68-9c2c3d5fca4c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "8094639d-b303-4b69-ab68-9c2c3d5fca4c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "ea72d06b-686d-4d5d-985c-0611a7c0995c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "ea72d06b-686d-4d5d-985c-0611a7c0995c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "83364430-e2bb-4d20-bf8f-4b1e9e7e3918", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "83364430-e2bb-4d20-bf8f-4b1e9e7e3918", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "e1e46a94-3a52-4bb2-acc1-0ae63c9bdafe", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "6884bd3f-4b3a-4035-9128-fc89ed663df9", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,6,6,6,24,3,3,3,3,};
        public static int[] __progressLocation2 = new int[] { 8,8,8,9,10,10,10,13,14,14,14,15,15,15,15,};
        public static int[] __progressLocation3 = new int[] { 0,0,0,0,0,0,0,0,0,0,0,0,};
        public static int[] __progressLocation4 = new int[] { 16,16,17,17,18,19,19,20,21,21,21,22,23,23,};

        public static int[][] __progressLocations = new int[5] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new PortType_1(0, this);
                Port_3 = new PortType_3(1, this);
                Port_2 = new PortType_2(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalk_Orchestration1_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Variable_1 = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
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
                if (!Port_1.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__In_msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                __ctx1__.__In_msg = new __messagetype_Bre_Scope_LoanApplication("In_msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__In_msg);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__In_msg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__In_msg);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__Variable_1.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx1__.__Variable_1.UnderlyingXmlDocument.LoadXml("<a></a>");
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__Variable_1 = null;
                if (__ctx1__ != null && __ctx1__.__In_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__In_msg);
                    __ctx1__.__In_msg = null;
                }
                if (Port_2 != null)
                {
                    Port_2.Close(__ctx1__, __seg__);
                    Port_2 = null;
                }
                if (Port_3 != null)
                {
                    Port_3.Close(__ctx1__, __seg__);
                    Port_3 = null;
                }
                Tracker.FireEvent(__eventLocations[24],__eventData[6],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 16;
            case 16:
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
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope34_3 __ctx3__ = (____scope34_3)_stateMgrs[3];
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
                Tracker.FireEvent(__eventLocations[8],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_Bre_Scope_LoanApproval __Out_msg = new __messagetype_Bre_Scope_LoanApproval("Out_msg", __ctx2__);

                    ApplyTransform(typeof(Bre_Scope.LoanApprovalMap), new object[] {__Out_msg.part}, new object[] {__ctx1__.__In_msg.part});

                    if (__ctx2__.__Out_msg != null)
                        __ctx2__.UnrefMessage(__ctx2__.__Out_msg);
                    __ctx2__.__Out_msg = __Out_msg;
                    __ctx2__.RefMessage(__ctx2__.__Out_msg);
                }
                __ctx2__.__Out_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__Out_msg);
                    __edata.Messages.Add(__ctx1__.__In_msg);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx3__ = new ____scope34_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[6],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_3.SendMessage(0, __ctx2__.__Out_msg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__Out_msg);
                    __edata.PortName = @"Port_3";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx2__ != null && __ctx2__.__Out_msg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__Out_msg);
                    __ctx2__.__Out_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 14;
            case 14:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope34_3 __ctx3__ = (____scope34_3)_stateMgrs[3];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx3__.__policy_1__ = default(Microsoft.RuleEngine.Policy);
                __ctx3__.__policyParam_1_1__ = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx3__.__policyParamAsTXD_1_1__ = default(Microsoft.RuleEngine.TypedXmlDocument);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                __ctx3__.__policyParam_1_1__.UnderlyingXmlDocument = __ctx2__.__Out_msg.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx3__.__policyParamAsTXD_1_1__ = new Microsoft.RuleEngine.TypedXmlDocument("Bre_Scope.LoanApproval", (System.Xml.XmlDocument)__ctx3__.__policyParam_1_1__.UnderlyingXmlDocument);
                if (__ctx3__ != null)
                    __ctx3__.__policyParam_1_1__ = null;
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                __ctx3__.__policy_1__ = new Microsoft.RuleEngine.Policy("LoanApproval");
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx3__.__policy_1__.Execute(__ctx3__.__policyParamAsTXD_1_1__);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Bre_Scope_LoanApproval __Out_msg = new __messagetype_Bre_Scope_LoanApproval("Out_msg", __ctx2__);

                    __Out_msg.part.LoadFrom(__ctx3__.__policyParamAsTXD_1_1__.Document);
                    if (__ctx3__ != null)
                        __ctx3__.__policyParamAsTXD_1_1__ = null;

                    if (__ctx2__.__Out_msg != null)
                        __ctx2__.UnrefMessage(__ctx2__.__Out_msg);
                    __ctx2__.__Out_msg = __Out_msg;
                    __ctx2__.RefMessage(__ctx2__.__Out_msg);
                }
                __ctx2__.__Out_msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__Out_msg);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                __ctx3__.__policy_1__.Dispose();
                if (__ctx3__ != null)
                    __ctx3__.__policy_1__ = null;
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 11;
            case 11:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("Error", __ctx2__.__EX_0.Message);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                {
                    __messagetype_Microsoft_XLANGs_BaseTypes_Any __Any_Msg = new __messagetype_Microsoft_XLANGs_BaseTypes_Any("Any_Msg", __ctx2__);

                    Port_2.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), "mailto:ravinder.kampa@gmail.com");
                    Port_2.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.TransportType), "SMTP");
                    __ctx1__.__Variable_1.UnderlyingXmlDocument.LoadXml("<a></a>");
                    __Any_Msg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__Variable_1.UnderlyingXmlDocument);
                    __Any_Msg.SetPropertyValue(typeof(SMTP.CC), "ravinder.nani63@gmail.com ");
                    __Any_Msg.SetPropertyValue(typeof(SMTP.Subject), "error:" + __ctx2__.__EX_0.Message);
                    if (__ctx2__ != null)
                        __ctx2__.__EX_0 = null;
                    __Any_Msg.SetPropertyValue(typeof(SMTP.SMTPHost), "mail.rrd.com");
                    __Any_Msg.SetPropertyValue(typeof(SMTP.SMTPAuthenticate), (System.UInt32)(0U));
                    __Any_Msg.SetPropertyValue(typeof(SMTP.From), "ravinder.kampa@rrd.com ");

                    if (__ctx2__.__Any_Msg != null)
                        __ctx2__.UnrefMessage(__ctx2__.__Any_Msg);
                    __ctx2__.__Any_Msg = __Any_Msg;
                    __ctx2__.RefMessage(__ctx2__.__Any_Msg);
                }
                __ctx2__.__Any_Msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx2__.__Any_Msg);
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_2.SendMessage(0, __ctx2__.__Any_Msg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx2__.__Any_Msg);
                    __edata.PortName = @"Port_2";
                    Tracker.FireEvent(__eventLocations[22],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx2__ != null && __ctx2__.__Any_Msg != null)
                {
                    __ctx2__.UnrefMessage(__ctx2__.__Any_Msg);
                    __ctx2__.__Any_Msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Bre_Scope_LoanApplication__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Bre_Scope.LoanApplication _schema = new Bre_Scope.LoanApplication();

        public __Bre_Scope_LoanApplication__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Bre_Scope.LoanApplication",
        new System.Type[]{
            typeof(Bre_Scope.LoanApplication)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Bre_Scope_LoanApplication__)
        },
        0,
        @"http://Bre_Scope.LoanApplication#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Bre_Scope_LoanApplication : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Bre_Scope_LoanApplication__ part;

        private void __CreatePartWrappers()
        {
            part = new __Bre_Scope_LoanApplication__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Bre_Scope_LoanApplication(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
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
        "Microsoft.XLANGs.BaseTypes.Any",
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
    sealed public class __messagetype_Microsoft_XLANGs_BaseTypes_Any : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Microsoft_XLANGs_BaseTypes_Any(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Bre_Scope_LoanApproval__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Bre_Scope.LoanApproval _schema = new Bre_Scope.LoanApproval();

        public __Bre_Scope_LoanApproval__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Bre_Scope.LoanApproval",
        new System.Type[]{
            typeof(Bre_Scope.LoanApproval)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Bre_Scope_LoanApproval__)
        },
        0,
        @"http://Bre_Scope.LoanApproval#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Bre_Scope_LoanApproval : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Bre_Scope_LoanApproval__ part;

        private void __CreatePartWrappers()
        {
            part = new __Bre_Scope_LoanApproval__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Bre_Scope_LoanApproval(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
