
#pragma warning disable 162

namespace Test_Email_Notification
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Test_Email_Notification.__messagetype_Test_Email_Notification_Data_File)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Temp_Data_Type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Temp_Data_Type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Temp_Data_Type(Temp_Data_Type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Temp_Data_Type p = new Temp_Data_Type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Temp_Data_Type),
            typeof(__messagetype_Test_Email_Notification_Data_File),
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
            typeof(Test_Email_Notification.__messagetype_Test_Email_Notification_Control)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Temp_Control_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Temp_Control_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Temp_Control_type(Temp_Control_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Temp_Control_type p = new Temp_Control_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Temp_Control_type),
            typeof(__messagetype_Test_Email_Notification_Control),
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
            typeof(Test_Email_Notification.__messagetype_Test_Email_Notification_Dummy_data)
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
            typeof(__messagetype_Test_Email_Notification_Dummy_data),
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
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "BTS.ReceivePortName"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BTS.ReceivePortName()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 535 "C:\AMP\Email\Test_Email_Notification\Test_Email_Notification\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Temp_Data_Rcv", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Temp_Control_Rcv", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Test_Email_Notification.Temp_Data_Type),
            typeof(Test_Email_Notification.Temp_Control_type),
            typeof(Test_Email_Notification.PortType_1)
        },
        new System.String[] {
            "Temp_Data_Rcv",
            "Temp_Control_Rcv",
            "Port_1"
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class BizTalk_Orchestration1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 1, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 1, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 2, 4)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>b25db86c-f30c-4f49-ad75-6db23a072e93</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>35843f9c-24db-4bec-9f93-546430eb88a4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>f7bc84d9-ee81-463f-8948-45c19151182b</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1501cc54-646d-49ef-85e2-a4e3452bffa4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>132b173a-8b9c-4d96-8f9d-7eda7907be85</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Data_Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>479a7df5-f1d6-4e17-b4d0-f7acca17f48c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>adda01cd-b2fc-4827-a73c-c0dab3e093b9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>d5f19a75-9e03-4933-982e-f185db644300</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a5f56408-76ae-4754-80f3-e260a249ad27</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Contol_Count</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>765aeb53-f2e0-4309-b777-c640e9ec3ba7</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>732375e5-85ca-488b-bdc4-4779206060e0</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c3ab94ee-7d2d-4032-933f-0eec5d88677c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c5f44f46-3e9c-4fa8-9471-cf61fa1c4bea</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>b0ddf662-f418-4d1c-be32-d2259e4d5d47</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>3bfeaa67-f3b4-43e9-a722-904862407aca</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>319ef6ab-7736-45c1-a342-3e27dbfb4e1d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>44ee9916-0610-4da1-bb91-f3aa5e00f07f</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8607cd07-85bc-4525-b1ee-b58c08679eae</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f71474a8-1822-4f2f-b8bb-31b28508a37c</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>ecb23c96-ea04-4a78-a505-1afef71005d8</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>453954cf-368c-417f-95b3-ff0722832613</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2e756c1a-93af-4c1c-b82a-4d8f4523b2a4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>ca6397c7-c18b-4062-853e-8f6ac809439c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>60eb98ea-17b6-49b4-b4cd-0574a2d79c4b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>1f2869b6-6575-49ca-9b69-19c682e80990</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssigControl_Countnment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>fbb509f3-557c-4053-afa1-06fe7731c513</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>3985b32d-e647-4874-ad91-ff7254576d78</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0d0856b4-eb1d-4afa-9c23-3ea8440d7f11</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>d6ae82bb-ac94-496f-848a-f1ad2440cd25</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>9dd670ef-012b-4678-a44c-e784ff5863cc</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ExecShape</shapeType>      <ShapeID>27b67b64-1c83-4bf9-ab7e-15ca47803990</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>StartOrchestration_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>1f452e9c-932f-4bbc-bbab-28759a6b5d2c</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>b7322218-3875-46c1-8746-cbad0fb313b2</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4e109ec7-1bbe-491d-93ff-9a8e897e7fbe</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>4b384aa3-2a4b-41ad-80ba-15ebaa93285a</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParameterShape</shapeType>      <ShapeID>2138221b-7d15-448f-b319-f5812a507601</ShapeID>      <ParentLink>InvokeStatement_Parameter</ParentLink>                <shapeText>EmailBodyMsg</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>535</Line><Position>12</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>565</Line><Position>13</Position><ShapeID>'35843f9c-24db-4bec-9f93-546430eb88a4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>570</Line><Position>30</Position><ShapeID>'1501cc54-646d-49ef-85e2-a4e3452bffa4'</ShapeID>
<Messages>
	<MsgInfo><name>Data_Msg</name><part>part</part><schema>Test_Email_Notification.Data_File</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>572</Line><Position>32</Position><ShapeID>'132b173a-8b9c-4d96-8f9d-7eda7907be85'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>577</Line><Position>30</Position><ShapeID>'adda01cd-b2fc-4827-a73c-c0dab3e093b9'</ShapeID>
<Messages>
	<MsgInfo><name>Control_Msg</name><part>part</part><schema>Test_Email_Notification.Control</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>581</Line><Position>13</Position><ShapeID>'d5f19a75-9e03-4933-982e-f185db644300'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>586</Line><Position>35</Position><ShapeID>'a5f56408-76ae-4754-80f3-e260a249ad27'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>588</Line><Position>21</Position><ShapeID>'765aeb53-f2e0-4309-b777-c640e9ec3ba7'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>591</Line><Position>25</Position><ShapeID>'c3ab94ee-7d2d-4032-933f-0eec5d88677c'</ShapeID>
<Messages>
	<MsgInfo><name>Data_dummy</name><part>part</part><schema>Test_Email_Notification.Data_File</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>597</Line><Position>25</Position><ShapeID>'3bfeaa67-f3b4-43e9-a722-904862407aca'</ShapeID>
<Messages>
	<MsgInfo><name>Dummy_msg</name><part>part</part><schema>Test_Email_Notification.Dummy_data</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Data_dummy</name><part>part</part><schema>Test_Email_Notification.Data_File</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>603</Line><Position>33</Position><ShapeID>'ecb23c96-ea04-4a78-a505-1afef71005d8'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>605</Line><Position>63</Position><ShapeID>'453954cf-368c-417f-95b3-ff0722832613'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>607</Line><Position>25</Position><ShapeID>'2e756c1a-93af-4c1c-b82a-4d8f4523b2a4'</ShapeID>
<Messages>
	<MsgInfo><name>Dummy_msg</name><part>part</part><schema>Test_Email_Notification.Dummy_data</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>612</Line><Position>25</Position><ShapeID>'60eb98ea-17b6-49b4-b4cd-0574a2d79c4b'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>642</Line><Position>59</Position><ShapeID>'27b67b64-1c83-4bf9-ab7e-15ca47803990'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='fc453371-70b0-4c7a-a24a-9f0ed7e23684' LowerBound='1.1' HigherBound='144.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Test_Email_Notification' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='fef3980f-65ca-45d8-ba99-87bf9d754c2e' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Temp_Data_Type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='208f1650-bbd8-4e9c-959a-34ff4b4f0dd5' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='6770f4c4-b4cc-4091-9a78-102201d24794' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.22'>
                    <om:Property Name='Ref' Value='Test_Email_Notification.Data_File' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='c2a0e6dc-a939-44f8-9cba-769c02dd2786' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Temp_Control_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='4130f2e5-d961-44b2-b99d-fc798a00b8a7' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='988803cb-2f70-4e3a-9fbf-c5170afdac87' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.20'>
                    <om:Property Name='Ref' Value='Test_Email_Notification.Control' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2c8df715-4755-41e4-b548-e38652dd3c73' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='feaba713-6b49-45fb-9f0b-672e5e833164' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9343249d-255a-4332-9fdf-f5f1c4cfd591' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.23'>
                    <om:Property Name='Ref' Value='Test_Email_Notification.Dummy_data' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='e4f783c4-32b8-4226-bdba-f9245df33025' ParentLink='Module_CorrelationType' LowerBound='25.1' HigherBound='29.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='3e05da93-83b4-418c-9ad4-0aaccbc69dcb' ParentLink='CorrelationType_PropertyRef' LowerBound='27.9' HigherBound='27.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='30c32c8f-a0f4-4830-a9fd-a92797b3b354' ParentLink='Module_ServiceDeclaration' LowerBound='29.1' HigherBound='143.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='fc0a9b28-3263-42a2-b6e8-f31217c6cccf' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Data_Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='ff9532a7-df9a-4fdc-b902-da05e8db359f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int32' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Control_Count' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e2a14dba-5844-4d97-868d-06430e3d9c4b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='XmlDocument' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='29bb45ca-987c-4b6a-bacb-54cc8cacaf54' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strEmail' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='dc62d520-bed9-404e-bda4-ef11e1e9c020' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strSubject' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='bfb54502-fc4e-4f30-910e-42c825ef6461' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strHost' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8fbcb903-c9f4-408d-922c-38e4edb60ee7' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strFrom' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='3cf486f2-a711-4a65-be04-110c4fff6d2f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='strEmailTo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='3f52a619-ad47-4267-baef-11467200a1a4' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='38.1' HigherBound='39.1'>
                <om:Property Name='Type' Value='Test_Email_Notification.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='f43c1215-1a61-4337-899a-6588c5c8503c' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='65.76' HigherBound='65.100'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='1501cc54-646d-49ef-85e2-a4e3452bffa4' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='b66f16cc-2b8c-4823-a571-59aa7453c69f' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='72.82' HigherBound='72.106'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='adda01cd-b2fc-4827-a73c-c0dab3e093b9' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aee98196-9244-46ca-b839-c1600487d897' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='39.1' HigherBound='40.1'>
                <om:Property Name='Type' Value='Test_Email_Notification.Data_File' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Data_Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6da94f4e-a27a-448c-b027-ace15a07e4d6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='40.1' HigherBound='41.1'>
                <om:Property Name='Type' Value='Test_Email_Notification.Control' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Control_Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1213ea43-7b6b-4dfb-b942-192203507cd8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='Test_Email_Notification.Dummy_data' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Dummy_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='46caf707-77a3-4883-abc0-0eaa7d22ba18' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xml_Doc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='51b61dd6-e81b-4728-a727-24833b429013' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='Test_Email_Notification.Data_File' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Data_dummy' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5930a6b1-41d1-4b1c-b02f-07595bde55c2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailBodyMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7f5aa899-991a-43f3-9a6a-5668ab6395f9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailFromMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='0e1d52c8-9fa2-428b-80a1-8c56035cae28' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailHostMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='35cd796b-e1e2-4cbc-b767-d84ee405ceed' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailSubjectMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aad72067-80ef-41c4-884a-f78b4281e7d4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='EmailToMsg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='b25db86c-f30c-4f49-ad75-6db23a072e93' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Parallel' OID='35843f9c-24db-4bec-9f93-546430eb88a4' ParentLink='ServiceBody_Statement' LowerBound='59.1' HigherBound='75.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='f7bc84d9-ee81-463f-8948-45c19151182b' ParentLink='ReallyComplexStatement_Branch' LowerBound='64.1' HigherBound='68.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='1501cc54-646d-49ef-85e2-a4e3452bffa4' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='66.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Temp_Data_Rcv' />
                            <om:Property Name='MessageName' Value='Data_Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='VariableAssignment' OID='132b173a-8b9c-4d96-8f9d-7eda7907be85' ParentLink='ComplexStatement_Statement' LowerBound='66.1' HigherBound='68.1'>
                            <om:Property Name='Expression' Value='Data_Count = System.Convert.ToInt32(xpath(Data_Msg,&quot;count(/*[local-name()=&apos;Customer&apos; and namespace-uri()=&apos;http://Test_Email_Notification.Data_File&apos;]/*[local-name()=&apos;Data_Record&apos; and namespace-uri()=&apos;&apos;])&quot;));' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Data_Count' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='479a7df5-f1d6-4e17-b4d0-f7acca17f48c' ParentLink='ReallyComplexStatement_Branch' LowerBound='71.1' HigherBound='73.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='adda01cd-b2fc-4827-a73c-c0dab3e093b9' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='73.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Temp_Control_Rcv' />
                            <om:Property Name='MessageName' Value='Control_Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Scope' OID='d5f19a75-9e03-4933-982e-f185db644300' ParentLink='ServiceBody_Statement' LowerBound='75.1' HigherBound='141.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='VariableAssignment' OID='a5f56408-76ae-4754-80f3-e260a249ad27' ParentLink='ComplexStatement_Statement' LowerBound='80.1' HigherBound='82.1'>
                        <om:Property Name='Expression' Value='Control_Count = Control_Msg.Count.Count_Value;' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Contol_Count' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                    <om:Element Type='Decision' OID='765aeb53-f2e0-4309-b777-c640e9ec3ba7' ParentLink='ComplexStatement_Statement' LowerBound='82.1' HigherBound='139.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Decide_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='DecisionBranch' OID='732375e5-85ca-488b-bdc4-4779206060e0' ParentLink='ReallyComplexStatement_Branch' LowerBound='83.21' HigherBound='104.1'>
                            <om:Property Name='Expression' Value='Data_Count == Control_Count' />
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Rule_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='c3ab94ee-7d2d-4032-933f-0eec5d88677c' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='91.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_3' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='c5f44f46-3e9c-4fa8-9471-cf61fa1c4bea' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='90.1'>
                                    <om:Property Name='Expression' Value='Data_dummy=Data_Msg;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='b0ddf662-f418-4d1c-be32-d2259e4d5d47' ParentLink='Construct_MessageRef' LowerBound='86.35' HigherBound='86.45'>
                                    <om:Property Name='Ref' Value='Data_dummy' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Construct' OID='3bfeaa67-f3b4-43e9-a722-904862407aca' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='97.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Transform' OID='319ef6ab-7736-45c1-a342-3e27dbfb4e1d' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='96.1'>
                                    <om:Property Name='ClassName' Value='Test_Email_Notification.Transform_2' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Transform_2' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessagePartRef' OID='44ee9916-0610-4da1-bb91-f3aa5e00f07f' ParentLink='Transform_InputMessagePartRef' LowerBound='95.90' HigherBound='95.100'>
                                        <om:Property Name='MessageRef' Value='Data_dummy' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessagePartRef' OID='8607cd07-85bc-4525-b1ee-b58c08679eae' ParentLink='Transform_OutputMessagePartRef' LowerBound='95.40' HigherBound='95.49'>
                                        <om:Property Name='MessageRef' Value='Dummy_msg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='MessagePartReference_2' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='MessageRef' OID='f71474a8-1822-4f2f-b8bb-31b28508a37c' ParentLink='Construct_MessageRef' LowerBound='92.35' HigherBound='92.44'>
                                    <om:Property Name='Ref' Value='Dummy_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='ecb23c96-ea04-4a78-a505-1afef71005d8' ParentLink='ComplexStatement_Statement' LowerBound='97.1' HigherBound='99.1'>
                                <om:Property Name='Expression' Value='xml_Doc = Dummy_msg;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='VariableAssignment' OID='453954cf-368c-417f-95b3-ff0722832613' ParentLink='ComplexStatement_Statement' LowerBound='99.1' HigherBound='101.1'>
                                <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;data and countrol&quot;,&quot;count matched&quot;) ;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_2' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Send' OID='2e756c1a-93af-4c1c-b82a-4d8f4523b2a4' ParentLink='ComplexStatement_Statement' LowerBound='101.1' HigherBound='103.1'>
                                <om:Property Name='PortName' Value='Port_1' />
                                <om:Property Name='MessageName' Value='Dummy_msg' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Send_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='DecisionBranch' OID='ca6397c7-c18b-4062-853e-8f6ac809439c' ParentLink='ReallyComplexStatement_Branch'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Else' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Construct' OID='60eb98ea-17b6-49b4-b4cd-0574a2d79c4b' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='136.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ConstructMessage_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='1f2869b6-6575-49ca-9b69-19c682e80990' ParentLink='ComplexStatement_Statement' LowerBound='109.1' HigherBound='135.1'>
                                    <om:Property Name='Expression' Value='EmailBodyMsg= System.String.Empty;&#xD;&#xA;EmailFromMsg = System.String.Empty;&#xD;&#xA;EmailHostMsg = System.String.Empty;&#xD;&#xA;EmailSubjectMsg = System.String.Empty;&#xD;&#xA;EmailToMsg = System.String.Empty;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Getting data form SSO&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;strEmail = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailBody&quot;);&#xD;&#xA;strSubject = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_subject&quot;);&#xD;&#xA;strHost = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailHost&quot;);&#xD;&#xA;strFrom = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailFrom&quot;);&#xD;&#xA;strEmailTo = TSSG.SSO.Utility.Helper_Class.Read(&quot;Sending_Notification&quot;,&quot;Notification_EmailTo&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;//Assign_data&#xD;&#xA;                           &#xD;&#xA;//Assign Parameters to Messages                                &#xD;&#xA;EmailBodyMsg=strEmail;&#xD;&#xA;EmailSubjectMsg = strSubject;&#xD;&#xA;EmailHostMsg = strHost;&#xD;&#xA;EmailFromMsg = strFrom;&#xD;&#xA;EmailToMsg = strEmailTo;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssigControl_Countnment_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='fbb509f3-557c-4053-afa1-06fe7731c513' ParentLink='Construct_MessageRef' LowerBound='107.35' HigherBound='107.47'>
                                    <om:Property Name='Ref' Value='EmailBodyMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='3985b32d-e647-4874-ad91-ff7254576d78' ParentLink='Construct_MessageRef' LowerBound='107.49' HigherBound='107.61'>
                                    <om:Property Name='Ref' Value='EmailFromMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='0d0856b4-eb1d-4afa-9c23-3ea8440d7f11' ParentLink='Construct_MessageRef' LowerBound='107.63' HigherBound='107.75'>
                                    <om:Property Name='Ref' Value='EmailHostMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='d6ae82bb-ac94-496f-848a-f1ad2440cd25' ParentLink='Construct_MessageRef' LowerBound='107.77' HigherBound='107.92'>
                                    <om:Property Name='Ref' Value='EmailSubjectMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='9dd670ef-012b-4678-a44c-e784ff5863cc' ParentLink='Construct_MessageRef' LowerBound='107.94' HigherBound='107.104'>
                                    <om:Property Name='Ref' Value='EmailToMsg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Exec' OID='27b67b64-1c83-4bf9-ab7e-15ca47803990' ParentLink='ComplexStatement_Statement' LowerBound='136.1' HigherBound='138.1'>
                                <om:Property Name='Invokee' Value='Email_Notification.Email_Not' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='StartOrchestration_1' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Parameter' OID='1f452e9c-932f-4bbc-bbab-28759a6b5d2c' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='b7322218-3875-46c1-8746-cbad0fb313b2' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='4e109ec7-1bbe-491d-93ff-9a8e897e7fbe' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='4b384aa3-2a4b-41ad-80ba-15ebaa93285a' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='Parameter' OID='2138221b-7d15-448f-b319-f5812a507601' ParentLink='InvokeStatement_Parameter'>
                                    <om:Property Name='Direction' Value='In' />
                                    <om:Property Name='Name' Value='EmailBodyMsg' />
                                    <om:Property Name='Type' Value='System.String' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4bbaba20-42d9-4046-84b6-772cda7acceb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='32.1' HigherBound='34.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Test_Email_Notification.Temp_Data_Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Temp_Data_Rcv' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='406239a4-acd6-4e8a-b0ea-b902e266d7b2' ParentLink='PortDeclaration_CLRAttribute' LowerBound='32.1' HigherBound='33.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d3f439e5-5597-49d3-80ba-c3df03df3d46' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='34.1' HigherBound='36.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Test_Email_Notification.Temp_Control_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Temp_Control_Rcv' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='b6840df0-f65b-4305-ab12-6c5e80a0de0b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='34.1' HigherBound='35.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cdb9a34c-7e90-4d1b-94f4-41d5903a8f9f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='36.1' HigherBound='38.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Unbound' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Test_Email_Notification.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='876da0b0-eff1-4d66-9ddf-0b079054fc77' ParentLink='PortDeclaration_CLRAttribute' LowerBound='36.1' HigherBound='37.1'>
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

                if (__svc__.Temp_Data_Rcv != null)
                {
                    __svc__.Temp_Data_Rcv.Close(this, null);
                    __svc__.Temp_Data_Rcv = null;
                }
                if (__svc__.Temp_Control_Rcv != null)
                {
                    __svc__.Temp_Control_Rcv.Close(this, null);
                    __svc__.Temp_Control_Rcv = null;
                }
                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
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
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Data_Msg")]
            public __messagetype_Test_Email_Notification_Data_File __Data_Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Control_Msg")]
            public __messagetype_Test_Email_Notification_Control __Control_Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Dummy_msg")]
            public __messagetype_Test_Email_Notification_Dummy_data __Dummy_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xml_Doc")]
            public __messagetype_System_Xml_XmlDocument __xml_Doc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Data_dummy")]
            public __messagetype_Test_Email_Notification_Data_File __Data_dummy;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailBodyMsg")]
            public __messagetype_System_String __EmailBodyMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailFromMsg")]
            public __messagetype_System_String __EmailFromMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailHostMsg")]
            public __messagetype_System_String __EmailHostMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailSubjectMsg")]
            public __messagetype_System_String __EmailSubjectMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("EmailToMsg")]
            public __messagetype_System_String __EmailToMsg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Data_Count")]
            internal System.Int32 __Data_Count;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Control_Count")]
            internal System.Int32 __Control_Count;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strEmail")]
            internal System.String __strEmail;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strSubject")]
            internal System.String __strSubject;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strHost")]
            internal System.String __strHost;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strFrom")]
            internal System.String __strFrom;
            [Microsoft.XLANGs.Core.UserVariableAttribute("strEmailTo")]
            internal System.String __strEmailTo;
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
                get { return _service._segments[4]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[4]; }
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
                __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Data_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Data_Msg);
                    __ctx1__.__Data_Msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Control_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Control_Msg);
                    __ctx1__.__Control_Msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Dummy_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Dummy_msg);
                    __ctx1__.__Dummy_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__xml_Doc != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml_Doc);
                    __ctx1__.__xml_Doc = null;
                }
                if (__ctx1__ != null && __ctx1__.__Data_dummy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Data_dummy);
                    __ctx1__.__Data_dummy = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailToMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__strEmail = null;
                if (__ctx1__ != null)
                    __ctx1__.__strSubject = null;
                if (__ctx1__ != null)
                    __ctx1__.__strHost = null;
                if (__ctx1__ != null)
                    __ctx1__.__strFrom = null;
                if (__ctx1__ != null)
                    __ctx1__.__strEmailTo = null;
                base.Finally();
            }

        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_1() };
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
                return new object[] {
                    new Microsoft.XLANGs.Core.CorrelationType[] { _correlationTypes[0] }
                };
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Temp_Data_Rcv")]
        internal Temp_Data_Type Temp_Data_Rcv;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Temp_Control_Rcv")]
        internal Temp_Control_type Temp_Control_Rcv;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Temp_Data_Type.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Temp_Data_Rcv", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Temp_Data_Rcv"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Temp_Control_type.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Temp_Control_Rcv", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Temp_Control_Rcv"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Port_1"),
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
                    typeof(Email_Notification.Email_Not)                    
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[2]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[1], 0, null , 0, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "35843f9c-24db-4bec-9f93-546430eb88a4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "35843f9c-24db-4bec-9f93-546430eb88a4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "1501cc54-646d-49ef-85e2-a4e3452bffa4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "1501cc54-646d-49ef-85e2-a4e3452bffa4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "132b173a-8b9c-4d96-8f9d-7eda7907be85", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "132b173a-8b9c-4d96-8f9d-7eda7907be85", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "adda01cd-b2fc-4827-a73c-c0dab3e093b9", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "adda01cd-b2fc-4827-a73c-c0dab3e093b9", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "d5f19a75-9e03-4933-982e-f185db644300", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "00000000-0000-0000-0000-000000000000", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a5f56408-76ae-4754-80f3-e260a249ad27", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "a5f56408-76ae-4754-80f3-e260a249ad27", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "765aeb53-f2e0-4309-b777-c640e9ec3ba7", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "c3ab94ee-7d2d-4032-933f-0eec5d88677c", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "c3ab94ee-7d2d-4032-933f-0eec5d88677c", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "3bfeaa67-f3b4-43e9-a722-904862407aca", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "3bfeaa67-f3b4-43e9-a722-904862407aca", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "ecb23c96-ea04-4a78-a505-1afef71005d8", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "ecb23c96-ea04-4a78-a505-1afef71005d8", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "453954cf-368c-417f-95b3-ff0722832613", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "453954cf-368c-417f-95b3-ff0722832613", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "2e756c1a-93af-4c1c-b82a-4d8f4523b2a4", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "2e756c1a-93af-4c1c-b82a-4d8f4523b2a4", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "60eb98ea-17b6-49b4-b4cd-0574a2d79c4b", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "60eb98ea-17b6-49b4-b4cd-0574a2d79c4b", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "27b67b64-1c83-4bf9-ab7e-15ca47803990", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "27b67b64-1c83-4bf9-ab7e-15ca47803990", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "765aeb53-f2e0-4309-b777-c640e9ec3ba7", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "d5f19a75-9e03-4933-982e-f185db644300", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Exec),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,30,30,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,3,2,2,9,9,9,29,30,30,30,30,};
        public static int[] __progressLocation2 = new int[] { 3,3,4,5,5,6,2,};
        public static int[] __progressLocation3 = new int[] { 7,7,8,2,};
        public static int[] __progressLocation4 = new int[] { 11,11,11,12,13,13,14,14,15,16,16,17,18,18,19,20,20,21,22,22,22,23,13,24,24,25,26,26,27,27,28,28,28,28,};

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
                Temp_Data_Rcv = new Temp_Data_Type(0, this);
                Temp_Control_Rcv = new Temp_Control_type(1, this);
                Port_1 = new PortType_1(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Temp_Data_Rcv, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Temp_Control_Rcv, this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__Data_Count = default(System.Int32);
                __ctx1__.__Control_Count = default(System.Int32);
                __ctx1__.__strEmail = default(System.String);
                __ctx1__.__strSubject = default(System.String);
                __ctx1__.__strHost = default(System.String);
                __ctx1__.__strFrom = default(System.String);
                __ctx1__.__strEmailTo = default(System.String);
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
                __ctx1__.__Correlation_1 = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (Temp_Control_Rcv != null)
                {
                    Temp_Control_Rcv.Close(__ctx1__, __seg__);
                    Temp_Control_Rcv = null;
                }
                if (Temp_Data_Rcv != null)
                {
                    Temp_Data_Rcv.Close(__ctx1__, __seg__);
                    Temp_Data_Rcv = null;
                }
                Tracker.FireEvent(__eventLocations[2],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[13],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[14],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 13;
            case 13:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Temp_Data_Rcv.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Data_Msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Data_Msg);
                __ctx1__.__Data_Msg = new __messagetype_Test_Email_Notification_Data_File("Data_Msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Data_Msg);
                Temp_Data_Rcv.ReceiveMessage(0, __msgEnv__, __ctx1__.__Data_Msg, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Data_Msg);
                    __edata.PortName = @"Temp_Data_Rcv";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__Data_Count = System.Convert.ToInt32(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__Data_Msg.part, "count(/*[local-name()='Customer' and namespace-uri()='http://Test_Email_Notification.Data_File']/*[local-name()='Data_Record' and namespace-uri()=''])", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Temp_Control_Rcv.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Control_Msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Control_Msg);
                __ctx1__.__Control_Msg = new __messagetype_Test_Email_Notification_Control("Control_Msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Control_Msg);
                Temp_Control_Rcv.ReceiveMessage(0, __msgEnv__, __ctx1__.__Control_Msg, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Control_Msg);
                    __edata.PortName = @"Temp_Control_Rcv";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
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
                Tracker.FireEvent(__eventLocations[11],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __ctx1__.__Control_Count = (System.Int32)__ctx1__.__Control_Msg.part.GetDistinguishedField("Count.Count_Value");
                if (__ctx1__ != null && __ctx1__.__Control_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Control_Msg);
                    __ctx1__.__Control_Msg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __condition__ = __ctx1__.__Data_Count == __ctx1__.__Control_Count;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 23;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_Test_Email_Notification_Data_File __Data_dummy = new __messagetype_Test_Email_Notification_Data_File("Data_dummy", __ctx1__);

                    __Data_dummy.CopyFrom(__ctx1__.__Data_Msg);

                    if (__ctx1__.__Data_dummy != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Data_dummy);
                    __ctx1__.__Data_dummy = __Data_dummy;
                    __ctx1__.RefMessage(__ctx1__.__Data_dummy);
                }
                __ctx1__.__Data_dummy.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Data_dummy);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                {
                    __messagetype_Test_Email_Notification_Dummy_data __Dummy_msg = new __messagetype_Test_Email_Notification_Dummy_data("Dummy_msg", __ctx1__);

                    ApplyTransform(typeof(Test_Email_Notification.Transform_2), new object[] {__Dummy_msg.part}, new object[] {__ctx1__.__Data_dummy.part});

                    if (__ctx1__.__Dummy_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Dummy_msg);
                    __ctx1__.__Dummy_msg = __Dummy_msg;
                    __ctx1__.RefMessage(__ctx1__.__Dummy_msg);
                }
                __ctx1__.__Dummy_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Dummy_msg);
                    __edata.Messages.Add(__ctx1__.__Data_dummy);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Data_dummy != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Data_dummy);
                    __ctx1__.__Data_dummy = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (__ctx1__.__xml_Doc != null)
                    __ctx1__.UnrefMessage(__ctx1__.__xml_Doc);
                __ctx1__.__xml_Doc = new __messagetype_System_Xml_XmlDocument("xml_Doc", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__xml_Doc);
                __ctx1__.__xml_Doc.CopyFrom(__ctx1__.__Dummy_msg);
                __ctx1__.__xml_Doc.ConstructionCompleteEvent(false);
                if (__ctx1__ != null && __ctx1__.__xml_Doc != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__xml_Doc);
                    __ctx1__.__xml_Doc = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                System.Diagnostics.EventLog.WriteEntry("data and countrol", "count matched");
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_1.SendMessage(0, __ctx1__.__Dummy_msg, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Dummy_msg);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[23],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Dummy_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Dummy_msg);
                    __ctx1__.__Dummy_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                {
                    __messagetype_System_String __EmailBodyMsg = new __messagetype_System_String("EmailBodyMsg", __ctx1__);
                    __messagetype_System_String __EmailFromMsg = new __messagetype_System_String("EmailFromMsg", __ctx1__);
                    __messagetype_System_String __EmailHostMsg = new __messagetype_System_String("EmailHostMsg", __ctx1__);
                    __messagetype_System_String __EmailSubjectMsg = new __messagetype_System_String("EmailSubjectMsg", __ctx1__);
                    __messagetype_System_String __EmailToMsg = new __messagetype_System_String("EmailToMsg", __ctx1__);

                    __EmailBodyMsg.part.LoadFrom(System.String.Empty);
                    __EmailFromMsg.part.LoadFrom(System.String.Empty);
                    __EmailHostMsg.part.LoadFrom(System.String.Empty);
                    __EmailSubjectMsg.part.LoadFrom(System.String.Empty);
                    __EmailToMsg.part.LoadFrom(System.String.Empty);
                    __ctx1__.__strEmail = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailBody");
                    __ctx1__.__strSubject = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_subject");
                    __ctx1__.__strHost = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailHost");
                    __ctx1__.__strFrom = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailFrom");
                    __ctx1__.__strEmailTo = TSSG.SSO.Utility.Helper_Class.Read("Sending_Notification", "Notification_EmailTo");
                    __EmailBodyMsg.part.LoadFrom(__ctx1__.__strEmail);
                    if (__ctx1__ != null)
                        __ctx1__.__strEmail = null;
                    __EmailSubjectMsg.part.LoadFrom(__ctx1__.__strSubject);
                    if (__ctx1__ != null)
                        __ctx1__.__strSubject = null;
                    __EmailHostMsg.part.LoadFrom(__ctx1__.__strHost);
                    if (__ctx1__ != null)
                        __ctx1__.__strHost = null;
                    __EmailFromMsg.part.LoadFrom(__ctx1__.__strFrom);
                    if (__ctx1__ != null)
                        __ctx1__.__strFrom = null;
                    __EmailToMsg.part.LoadFrom(__ctx1__.__strEmailTo);
                    if (__ctx1__ != null)
                        __ctx1__.__strEmailTo = null;

                    if (__ctx1__.__EmailBodyMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = __EmailBodyMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailBodyMsg);
                    if (__ctx1__.__EmailFromMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = __EmailFromMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailFromMsg);
                    if (__ctx1__.__EmailHostMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = __EmailHostMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailHostMsg);
                    if (__ctx1__.__EmailSubjectMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = __EmailSubjectMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailSubjectMsg);
                    if (__ctx1__.__EmailToMsg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = __EmailToMsg;
                    __ctx1__.RefMessage(__ctx1__.__EmailToMsg);
                }
                __ctx1__.__EmailBodyMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailFromMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailHostMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailSubjectMsg.ConstructionCompleteEvent(false);
                __ctx1__.__EmailToMsg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailFromMsg);
                    __edata.Messages.Add(__ctx1__.__EmailHostMsg);
                    __edata.Messages.Add(__ctx1__.__EmailSubjectMsg);
                    __edata.Messages.Add(__ctx1__.__EmailToMsg);
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__EmailToMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailToMsg);
                    __ctx1__.__EmailToMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailSubjectMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailSubjectMsg);
                    __ctx1__.__EmailSubjectMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailHostMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailHostMsg);
                    __ctx1__.__EmailHostMsg = null;
                }
                if (__ctx1__ != null && __ctx1__.__EmailFromMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailFromMsg);
                    __ctx1__.__EmailFromMsg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                ExecService(__ctx2__, typeof(Email_Notification.Email_Not), new object[] {__ctx1__.__EmailBodyMsg, __ctx1__.__EmailBodyMsg, __ctx1__.__EmailBodyMsg, __ctx1__.__EmailBodyMsg, __ctx1__.__EmailBodyMsg});
                goto case 29;
            case 29:
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Exec);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    __edata.Messages.Add(__ctx1__.__EmailBodyMsg);
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__EmailBodyMsg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__EmailBodyMsg);
                    __ctx1__.__EmailBodyMsg = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Data_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Data_Msg);
                    __ctx1__.__Data_Msg = null;
                }
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx2__, __seg__);
                    Port_1 = null;
                }
                Tracker.FireEvent(__eventLocations[28],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 33;
            case 33:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __Test_Email_Notification_Data_File__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Test_Email_Notification.Data_File _schema = new Test_Email_Notification.Data_File();

        public __Test_Email_Notification_Data_File__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Test_Email_Notification.Data_File",
        new System.Type[]{
            typeof(Test_Email_Notification.Data_File)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Test_Email_Notification_Data_File__)
        },
        0,
        @"http://Test_Email_Notification.Data_File#Customer"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Test_Email_Notification_Data_File : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Test_Email_Notification_Data_File__ part;

        private void __CreatePartWrappers()
        {
            part = new __Test_Email_Notification_Data_File__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Test_Email_Notification_Data_File(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Test_Email_Notification_Control__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Test_Email_Notification.Control _schema = new Test_Email_Notification.Control();

        public __Test_Email_Notification_Control__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Test_Email_Notification.Control",
        new System.Type[]{
            typeof(Test_Email_Notification.Control)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Test_Email_Notification_Control__)
        },
        0,
        @"http://Test_Email_Notification.Control#Control"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Test_Email_Notification_Control : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Test_Email_Notification_Control__ part;

        private void __CreatePartWrappers()
        {
            part = new __Test_Email_Notification_Control__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Test_Email_Notification_Control(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Test_Email_Notification_Dummy_data__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Test_Email_Notification.Dummy_data _schema = new Test_Email_Notification.Dummy_data();

        public __Test_Email_Notification_Dummy_data__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Test_Email_Notification.Dummy_data",
        new System.Type[]{
            typeof(Test_Email_Notification.Dummy_data)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Test_Email_Notification_Dummy_data__)
        },
        0,
        @"http://Test_Email_Notification.Dummy_data#Dummy_Cus"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Test_Email_Notification_Dummy_data : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Test_Email_Notification_Dummy_data__ part;

        private void __CreatePartWrappers()
        {
            part = new __Test_Email_Notification_Dummy_data__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Test_Email_Notification_Dummy_data(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
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
