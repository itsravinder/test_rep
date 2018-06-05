
#pragma warning disable 162

namespace simpleRouting
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(simpleRouting.__messagetype_simpleRouting_Incoming_order)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Incoming_Msg : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Incoming_Msg(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Incoming_Msg(Incoming_Msg p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Incoming_Msg p = new Incoming_Msg(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Incoming_Msg),
            typeof(__messagetype_simpleRouting_Incoming_order),
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
        "TN",
        new System.Type[]{
            typeof(simpleRouting.__messagetype_simpleRouting_Incoming_order)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "HYD",
        new System.Type[]{
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "other",
        new System.Type[]{
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
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
        static public Microsoft.XLANGs.Core.OperationInfo TN = new Microsoft.XLANGs.Core.OperationInfo
        (
            "TN",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_simpleRouting_Incoming_order),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo HYD = new Microsoft.XLANGs.Core.OperationInfo
        (
            "HYD",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_simpleRouting_tem),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo other = new Microsoft.XLANGs.Core.OperationInfo
        (
            "other",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_1),
            typeof(__messagetype_simpleRouting_tem),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "TN" ] = TN;
                h[ "HYD" ] = HYD;
                h[ "other" ] = other;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
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
            typeof(__messagetype_simpleRouting_tem),
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
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class TN_Rcv : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TN_Rcv(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TN_Rcv(TN_Rcv p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TN_Rcv p = new TN_Rcv(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(TN_Rcv),
            typeof(__messagetype_simpleRouting_tem),
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
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class HYD_Send : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public HYD_Send(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public HYD_Send(HYD_Send p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            HYD_Send p = new HYD_Send(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(HYD_Send),
            typeof(__messagetype_simpleRouting_tem),
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
            typeof(simpleRouting.__messagetype_simpleRouting_tem)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Others_Send : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Others_Send(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Others_Send(Others_Send p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Others_Send p = new Others_Send(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Others_Send),
            typeof(__messagetype_simpleRouting_tem),
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
    //#line 506 "C:\AMP\simpleRouting\simpleRouting\State_Routing.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_1", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(simpleRouting.Incoming_Msg),
            typeof(simpleRouting.TN_Rcv),
            typeof(simpleRouting.HYD_Send),
            typeof(simpleRouting.Others_Send)
        },
        new System.String[] {
            "Port_1",
            "TN",
            "HYD",
            "OThers"
        },
        new System.Type[] {
            null,
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
    sealed internal class State_Routing : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(State_Routing));
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

        static State_Routing()
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
            _rootContext = new __State_Routing_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public State_Routing(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "State_Routing", tracker)
        {
            ConstructorHelper();
        }

        public State_Routing(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "State_Routing")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>b91fe8cb-aee5-4996-bcf5-c3a94ba2c37b</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>bd0a80ab-ae5b-4d2e-9db1-107c4b42b0eb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>7330b5dd-64b7-4e3f-99ee-05bd8723638f</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>f727d639-cae3-4c46-abad-c44254dff86a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>74eb485f-3f18-417f-b57c-d958aa541d79</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6f8bb4eb-2179-4403-b0eb-30348a115bc0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>ed7c4481-a967-4ae9-a675-8f1d0e356a36</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7da18f4b-945e-48a9-adcf-1f3d5bd08d92</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e5e8cf06-b6e9-4696-be55-d3e2cec4c480</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>5e3ca629-16c2-4612-9dc2-3bd44541e915</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>2c26e42e-5904-4602-a90f-f271d097adc1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>247e66b1-f0e9-4599-a315-a6ecbd168b53</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>00762a35-b069-4c25-9a57-fd689c5f1fc5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>830b11e5-417e-4669-9974-17cf2368b772</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>e5b2d0f2-9f9a-453d-a1a8-fff0befaf8a4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>811b39bf-8eba-461c-a274-b9d5e18e5aec</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>25acb555-d773-4730-849d-f422839ff1f3</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>acda1a2e-7f74-42f3-ac78-7a3a352cffe3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f63eefe8-3322-4ebb-aa00-6aec3a755cc1</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>2af1217a-e726-4ffb-92c3-b925bd62c73a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>1ed4df07-25fd-4196-8a6b-786c5c72d5a4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_3</shapeText>                  
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
<ActionName>'State_Routing'</ActionName><IsAtomic>0</IsAtomic><Line>506</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>532</Line><Position>22</Position><ShapeID>'bd0a80ab-ae5b-4d2e-9db1-107c4b42b0eb'</ShapeID>
<Messages>
	<MsgInfo><name>IN_Msg</name><part>part</part><schema>simpleRouting.Incoming_order</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>540</Line><Position>19</Position><ShapeID>'7330b5dd-64b7-4e3f-99ee-05bd8723638f'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>546</Line><Position>13</Position><ShapeID>'f727d639-cae3-4c46-abad-c44254dff86a'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>549</Line><Position>17</Position><ShapeID>'6f8bb4eb-2179-4403-b0eb-30348a115bc0'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>572</Line><Position>17</Position><ShapeID>'e5e8cf06-b6e9-4696-be55-d3e2cec4c480'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>577</Line><Position>17</Position><ShapeID>'2c26e42e-5904-4602-a90f-f271d097adc1'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>580</Line><Position>21</Position><ShapeID>'00762a35-b069-4c25-9a57-fd689c5f1fc5'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>603</Line><Position>21</Position><ShapeID>'811b39bf-8eba-461c-a274-b9d5e18e5aec'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>608</Line><Position>21</Position><ShapeID>'acda1a2e-7f74-42f3-ac78-7a3a352cffe3'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>631</Line><Position>21</Position><ShapeID>'1ed4df07-25fd-4196-8a6b-786c5c72d5a4'</ShapeID>
<Messages>
	<MsgInfo><name>Out_Msg</name><part>part</part><schema>simpleRouting.tem</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='020b60f5-e7e0-41c8-bb3d-b909572394ec' LowerBound='1.1' HigherBound='186.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='simpleRouting' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='ee9e8f86-e703-4e6e-aeb2-3bcb229437e6' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Incoming_Msg' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='93592a62-84d4-432e-8c1a-635743304a00' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='93baa19b-28fc-444c-b96b-01b407ec9165' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.27'>
                    <om:Property Name='Ref' Value='simpleRouting.Incoming_order' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='f97b96f1-6031-4e11-890f-451b7a7fe0a1' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6408440f-f6ff-4bd6-bf4b-9a44ab631240' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TN' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='42ca6f16-75ce-4af7-a3cd-5f54ecba6e18' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.27'>
                    <om:Property Name='Ref' Value='simpleRouting.Incoming_order' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='OperationDeclaration' OID='26691a62-1661-4442-94ee-557572c62b0d' ParentLink='PortType_OperationDeclaration' LowerBound='17.1' HigherBound='21.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='HYD' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f2f1540e-6c1f-43be-b7bd-a6aac4c568b2' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='19.13' HigherBound='19.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='OperationDeclaration' OID='4393c303-dc9c-4750-a3d9-50b8d57acc29' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='other' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d809445c-00aa-4538-8690-e89e8f0ec4a7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='790ab0d6-bb08-46e3-99ca-cb1344dbffb8' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8712396c-f29a-43a9-8d5b-0611814e6a7f' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='d08f2930-8634-4395-a44c-05a3b3f7ef67' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='81bd025f-ef13-491a-a37b-bc1ad132f753' ParentLink='Module_PortType' LowerBound='33.1' HigherBound='40.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='TN_Rcv' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f525f78f-ca66-40e4-8522-71022e550d57' ParentLink='PortType_OperationDeclaration' LowerBound='35.1' HigherBound='39.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='71059019-3aed-4765-8b52-fb8b45038fba' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='37.13' HigherBound='37.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='62d17ec3-7959-4c81-97dc-1acd8d290c61' ParentLink='Module_PortType' LowerBound='40.1' HigherBound='47.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='HYD_Send' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dbf254ad-7d4e-4e04-9d6f-a317641ad933' ParentLink='PortType_OperationDeclaration' LowerBound='42.1' HigherBound='46.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='258da52f-9283-4744-b5ba-77346cdcef13' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='44.13' HigherBound='44.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='12be1546-f164-4d7e-a1c7-ffc63b4d925c' ParentLink='Module_PortType' LowerBound='47.1' HigherBound='54.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Others_Send' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='df0d64d5-87fd-4024-ac11-30cb28153dff' ParentLink='PortType_OperationDeclaration' LowerBound='49.1' HigherBound='53.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9081b55a-be87-41f3-b7be-389d7314c455' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='51.13' HigherBound='51.16'>
                    <om:Property Name='Ref' Value='simpleRouting.tem' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='7508e096-1426-44fa-bc28-6040cc40bcdc' ParentLink='Module_ServiceDeclaration' LowerBound='54.1' HigherBound='185.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='State_Routing' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='8a5fbdf0-b865-4cac-bcc4-8a57540bf315' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='69.1' HigherBound='70.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='State' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='8caada95-2b27-46c3-9021-385985305a9f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='70.1' HigherBound='71.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmldocument1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='50d64241-d024-462f-9af2-fd0ce790af2b' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='71.1' HigherBound='72.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmldocument2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='33678145-78de-40a4-b2d9-21eab32ded97' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='72.1' HigherBound='73.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.Int64' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='result' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='09f07fb9-7a98-41d9-a158-a93b8bb8e394' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='73.1' HigherBound='74.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='143ee27c-d3b0-437a-b3d0-6dc6e28f77c0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='74.1' HigherBound='75.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='myxmlDoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='a2584578-a30c-4cdc-a3f6-9a24d2926dec' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='75.1' HigherBound='76.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Invoice_ID' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='325584a2-1830-42ba-8a38-21b995296aaa' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='76.1' HigherBound='77.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Address' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5010362d-5003-4cfa-99a9-82d5e1017e3a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='77.1' HigherBound='78.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='result_str' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f11e7f67-7148-48e6-b854-0f068a637147' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='65.1' HigherBound='66.1'>
                <om:Property Name='Type' Value='simpleRouting.Incoming_order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='IN_Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa4f31a9-29dc-4128-af00-7461822cd0b6' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='66.1' HigherBound='67.1'>
                <om:Property Name='Type' Value='simpleRouting.tem' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Out_Msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='34d2d86f-78ab-4f7f-b192-44b02baaf3f0' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='67.1' HigherBound='68.1'>
                <om:Property Name='Type' Value='simpleRouting.Incoming_order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='State_name_msg1' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f072ff23-abd7-4bbf-8efc-42c97ae4cd4d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='68.1' HigherBound='69.1'>
                <om:Property Name='Type' Value='simpleRouting.Incoming_order' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='State_name_msg2' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='b91fe8cb-aee5-4996-bcf5-c3a94ba2c37b' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='bd0a80ab-ae5b-4d2e-9db1-107c4b42b0eb' ParentLink='ServiceBody_Statement' LowerBound='80.1' HigherBound='88.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_1' />
                    <om:Property Name='MessageName' Value='IN_Msg' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='7330b5dd-64b7-4e3f-99ee-05bd8723638f' ParentLink='ServiceBody_Statement' LowerBound='88.1' HigherBound='94.1'>
                    <om:Property Name='Expression' Value='State = xpath(IN_Msg,&quot;string(/*[local-name()=&apos;AllOrders&apos; and namespace-uri()=&apos;http://simpleRouting.Incoming_order&apos;]/*[local-name()=&apos;Orders&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;State&apos; and namespace-uri()=&apos;&apos;])&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;xmldocument1 = System.Convert.ToInt64(xpath(IN_Msg,&quot;number/*[local-name()=&apos;AllOrders&apos; and namespace-uri()=&apos;http://simpleRouting.Incoming_order&apos;]/*[local-name()=&apos;Orders&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;Number1&apos; and namespace-uri()=&apos;&apos;]&quot;));&#xD;&#xA;xmldocument2 =  System.Convert.ToInt64(xpath(IN_Msg,&quot;number/*[local-name()=&apos;AllOrders&apos; and namespace-uri()=&apos;http://simpleRouting.Incoming_order&apos;]/*[local-name()=&apos;Orders&apos; and namespace-uri()=&apos;&apos;]/*[local-name()=&apos;Number2&apos; and namespace-uri()=&apos;&apos;]&quot;));' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='f727d639-cae3-4c46-abad-c44254dff86a' ParentLink='ServiceBody_Statement' LowerBound='94.1' HigherBound='183.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='74eb485f-3f18-417f-b57c-d958aa541d79' ParentLink='ReallyComplexStatement_Branch' LowerBound='95.13' HigherBound='123.1'>
                        <om:Property Name='Expression' Value='State == &quot;TN&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='6f8bb4eb-2179-4403-b0eb-30348a115bc0' ParentLink='ComplexStatement_Statement' LowerBound='97.1' HigherBound='120.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_1' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='ed7c4481-a967-4ae9-a675-8f1d0e356a36' ParentLink='Construct_MessageRef' LowerBound='98.27' HigherBound='98.34'>
                                <om:Property Name='Ref' Value='Out_Msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='7da18f4b-945e-48a9-adcf-1f3d5bd08d92' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='119.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;myxmlDoc = new System.Xml.XmlDocument();&#xD;&#xA;myxmlDoc=IN_Msg;&#xD;&#xA;&#xD;&#xA;Invoice_ID=IN_Msg.Orders.InvocieId;&#xD;&#xA;&#xD;&#xA;State = IN_Msg.Orders.State;&#xD;&#xA;&#xD;&#xA;Address = IN_Msg.Orders.Address;&#xD;&#xA;&#xD;&#xA;result = xmldocument1+xmldocument2;&#xD;&#xA;&#xD;&#xA;//result_str = System.Convert.ToString(result);&#xD;&#xA;&#xD;&#xA;myxmlDoc.LoadXml(&quot;&lt;ns0:Root xmlns:ns0=&apos;http://simpleRouting.tem&apos;&gt;&lt;InvoiceID&gt;&quot;+Invoice_ID+&quot;&lt;/InvoiceID&gt; &lt;Address&gt;&quot;+Address+&quot;&lt;/Address&gt;  &lt;State&gt;&quot;+State+&quot;&lt;/State&gt;  &lt;Result&gt; result &lt;/Result&gt; &lt;/ns0:Root&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Out_Msg = myxmlDoc;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='e5e8cf06-b6e9-4696-be55-d3e2cec4c480' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='122.1'>
                            <om:Property Name='PortName' Value='TN' />
                            <om:Property Name='MessageName' Value='Out_Msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='5e3ca629-16c2-4612-9dc2-3bd44541e915' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Decision' OID='2c26e42e-5904-4602-a90f-f271d097adc1' ParentLink='ComplexStatement_Statement' LowerBound='125.1' HigherBound='182.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='DecisionBranch' OID='247e66b1-f0e9-4599-a315-a6ecbd168b53' ParentLink='ReallyComplexStatement_Branch' LowerBound='126.17' HigherBound='154.1'>
                                <om:Property Name='Expression' Value='State == &quot;HYD&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='00762a35-b069-4c25-9a57-fd689c5f1fc5' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='151.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='830b11e5-417e-4669-9974-17cf2368b772' ParentLink='Construct_MessageRef' LowerBound='129.31' HigherBound='129.38'>
                                        <om:Property Name='Ref' Value='Out_Msg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='e5b2d0f2-9f9a-453d-a1a8-fff0befaf8a4' ParentLink='ComplexStatement_Statement' LowerBound='131.1' HigherBound='150.1'>
                                        <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;myxmlDoc = new System.Xml.XmlDocument();&#xD;&#xA;myxmlDoc=IN_Msg;&#xD;&#xA;&#xD;&#xA;Invoice_ID=IN_Msg.Orders.InvocieId;&#xD;&#xA;&#xD;&#xA;State = IN_Msg.Orders.State;&#xD;&#xA;&#xD;&#xA;Address = IN_Msg.Orders.Address;&#xD;&#xA;&#xD;&#xA;result = xmldocument1+xmldocument2;&#xD;&#xA;&#xD;&#xA;//result_str = System.Convert.ToString(result);&#xD;&#xA;&#xD;&#xA;myxmlDoc.LoadXml(&quot;&lt;ns0:Root xmlns:ns0=&apos;http://simpleRouting.tem&apos;&gt;&lt;InvoiceID&gt;&quot;+Invoice_ID+&quot;&lt;/InvoiceID&gt; &lt;Address&gt;&quot;+Address+&quot;&lt;/Address&gt;  &lt;State&gt;&quot;+State+&quot;&lt;/State&gt;  &lt;Result&gt;result&lt;/Result&gt; &lt;/ns0:Root&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Out_Msg = myxmlDoc;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='811b39bf-8eba-461c-a274-b9d5e18e5aec' ParentLink='ComplexStatement_Statement' LowerBound='151.1' HigherBound='153.1'>
                                    <om:Property Name='PortName' Value='HYD' />
                                    <om:Property Name='MessageName' Value='Out_Msg' />
                                    <om:Property Name='OperationName' Value='Operation_1' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_2' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='25acb555-d773-4730-849d-f422839ff1f3' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='acda1a2e-7f74-42f3-ac78-7a3a352cffe3' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='179.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_1' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageRef' OID='f63eefe8-3322-4ebb-aa00-6aec3a755cc1' ParentLink='Construct_MessageRef' LowerBound='157.31' HigherBound='157.38'>
                                        <om:Property Name='Ref' Value='Out_Msg' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='2af1217a-e726-4ffb-92c3-b925bd62c73a' ParentLink='ComplexStatement_Statement' LowerBound='159.1' HigherBound='178.1'>
                                        <om:Property Name='Expression' Value='&#xD;&#xA;&#xD;&#xA;myxmlDoc = new System.Xml.XmlDocument();&#xD;&#xA;myxmlDoc=IN_Msg;&#xD;&#xA;&#xD;&#xA;Invoice_ID=IN_Msg.Orders.InvocieId;&#xD;&#xA;&#xD;&#xA;State = IN_Msg.Orders.State;&#xD;&#xA;&#xD;&#xA;Address = IN_Msg.Orders.Address;&#xD;&#xA;&#xD;&#xA;result = xmldocument1+xmldocument2;&#xD;&#xA;&#xD;&#xA;//result_str = System.Convert.ToString(result);&#xD;&#xA;&#xD;&#xA;myxmlDoc.LoadXml(&quot;&lt;ns0:Root xmlns:ns0=&apos;http://simpleRouting.tem&apos;&gt;&lt;InvoiceID&gt;&quot;+Invoice_ID+&quot;&lt;/InvoiceID&gt; &lt;Address&gt;&quot;+Address+&quot;&lt;/Address&gt;  &lt;State&gt;&quot;+State+&quot;&lt;/State&gt;  &lt;Result&gt;result&lt;/Result&gt; &lt;/ns0:Root&gt;&quot;);&#xD;&#xA;&#xD;&#xA;Out_Msg = myxmlDoc;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='1ed4df07-25fd-4196-8a6b-786c5c72d5a4' ParentLink='ComplexStatement_Statement' LowerBound='179.1' HigherBound='181.1'>
                                    <om:Property Name='PortName' Value='OThers' />
                                    <om:Property Name='MessageName' Value='Out_Msg' />
                                    <om:Property Name='OperationName' Value='Operation_1' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_3' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6f759b36-d04a-41b1-b225-a9238281bda2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='57.1' HigherBound='59.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='simpleRouting.Incoming_Msg' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a2bdd71d-97e6-4016-a32f-c39f9f01f3eb' ParentLink='PortDeclaration_CLRAttribute' LowerBound='57.1' HigherBound='58.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='01486761-986a-4018-83df-781bebf40e57' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='59.1' HigherBound='61.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='simpleRouting.TN_Rcv' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='TN' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='777f176e-a5e0-416a-82cf-d08af65d891c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='59.1' HigherBound='60.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='cd5b27d3-dc11-4830-a669-4a5c781cb1a4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='61.1' HigherBound='63.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='simpleRouting.HYD_Send' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='HYD' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='059170f4-619c-48a6-81dd-0858e54a6f89' ParentLink='PortDeclaration_CLRAttribute' LowerBound='61.1' HigherBound='62.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e488e129-38b5-4a87-84c4-7525171c2724' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='63.1' HigherBound='65.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='simpleRouting.Others_Send' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OThers' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c142a8ca-99f8-4a0b-8910-80a11b3bffc9' ParentLink='PortDeclaration_CLRAttribute' LowerBound='63.1' HigherBound='64.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __State_Routing_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __State_Routing_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "State_Routing")
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
                State_Routing __svc__ = (State_Routing)_service;
                __State_Routing_root_0 __ctx0__ = (__State_Routing_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.OThers != null)
                {
                    __svc__.OThers.Close(this, null);
                    __svc__.OThers = null;
                }
                if (__svc__.HYD != null)
                {
                    __svc__.HYD.Close(this, null);
                    __svc__.HYD = null;
                }
                if (__svc__.TN != null)
                {
                    __svc__.TN.Close(this, null);
                    __svc__.TN = null;
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
        public class __State_Routing_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __State_Routing_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "State_Routing")
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
                State_Routing __svc__ = (State_Routing)_service;
                __State_Routing_1 __ctx1__ = (__State_Routing_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__IN_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                    __ctx1__.__IN_Msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Out_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Out_Msg);
                    __ctx1__.__Out_Msg = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__State = null;
                if (__ctx1__ != null)
                    __ctx1__.__Out = null;
                if (__ctx1__ != null)
                    __ctx1__.__myxmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__Invoice_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__Address = null;
                if (__ctx1__ != null)
                    __ctx1__.__result_str = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("IN_Msg")]
            public __messagetype_simpleRouting_Incoming_order __IN_Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Out_Msg")]
            public __messagetype_simpleRouting_tem __Out_Msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("State")]
            internal System.String __State;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmldocument1")]
            internal System.Int64 __xmldocument1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmldocument2")]
            internal System.Int64 __xmldocument2;
            [Microsoft.XLANGs.Core.UserVariableAttribute("result")]
            internal System.Int64 __result;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Out")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __Out;
            [Microsoft.XLANGs.Core.UserVariableAttribute("myxmlDoc")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __myxmlDoc;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Invoice_ID")]
            internal System.String __Invoice_ID;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Address")]
            internal System.String __Address;
            [Microsoft.XLANGs.Core.UserVariableAttribute("result_str")]
            internal System.String __result_str;
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
        internal Incoming_Msg Port_1;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("TN")]
        internal TN_Rcv TN;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("HYD")]
        internal HYD_Send HYD;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OThers")]
        internal Others_Send OThers;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Incoming_Msg.Operation_1},
                                               typeof(State_Routing).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(State_Routing), "Port_1"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {TN_Rcv.Operation_1},
                                               typeof(State_Routing).GetField("TN", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(State_Routing), "TN"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {HYD_Send.Operation_1},
                                               typeof(State_Routing).GetField("HYD", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(State_Routing), "HYD"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Others_Send.Operation_1},
                                               typeof(State_Routing).GetField("OThers", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(State_Routing), "OThers"),
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
                h[_portInfo[3].Name] = _portInfo[3];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "bd0a80ab-ae5b-4d2e-9db1-107c4b42b0eb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "bd0a80ab-ae5b-4d2e-9db1-107c4b42b0eb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "7330b5dd-64b7-4e3f-99ee-05bd8723638f", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "7330b5dd-64b7-4e3f-99ee-05bd8723638f", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f727d639-cae3-4c46-abad-c44254dff86a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "6f8bb4eb-2179-4403-b0eb-30348a115bc0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "6f8bb4eb-2179-4403-b0eb-30348a115bc0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "e5e8cf06-b6e9-4696-be55-d3e2cec4c480", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "e5e8cf06-b6e9-4696-be55-d3e2cec4c480", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "2c26e42e-5904-4602-a90f-f271d097adc1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "00762a35-b069-4c25-9a57-fd689c5f1fc5", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "00762a35-b069-4c25-9a57-fd689c5f1fc5", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "811b39bf-8eba-461c-a274-b9d5e18e5aec", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "811b39bf-8eba-461c-a274-b9d5e18e5aec", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "acda1a2e-7f74-42f3-ac78-7a3a352cffe3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "acda1a2e-7f74-42f3-ac78-7a3a352cffe3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "1ed4df07-25fd-4196-8a6b-786c5c72d5a4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "1ed4df07-25fd-4196-8a6b-786c5c72d5a4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "2c26e42e-5904-4602-a90f-f271d097adc1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "f727d639-cae3-4c46-abad-c44254dff86a", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,2,2,2,2,4,4,5,5,5,6,6,7,7,8,9,9,9,10,6,11,11,12,12,13,14,14,14,15,11,16,16,17,18,18,18,19,20,21,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __State_Routing_root_0 __ctx0__ = (__State_Routing_root_0)_stateMgrs[0];
            __State_Routing_1 __ctx1__ = (__State_Routing_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_1 = new Incoming_Msg(0, this);
                TN = new TN_Rcv(1, this);
                HYD = new HYD_Send(2, this);
                OThers = new Others_Send(3, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_1, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __State_Routing_1(this);
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
            __State_Routing_root_0 __ctx0__ = (__State_Routing_root_0)_stateMgrs[0];
            __State_Routing_1 __ctx1__ = (__State_Routing_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__State = default(System.String);
                __ctx1__.__xmldocument1 = default(System.Int64);
                __ctx1__.__xmldocument2 = default(System.Int64);
                __ctx1__.__result = default(System.Int64);
                __ctx1__.__Out = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__myxmlDoc = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__Invoice_ID = default(System.String);
                __ctx1__.__Address = default(System.String);
                __ctx1__.__result_str = default(System.String);
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
                if (__ctx1__.__IN_Msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                __ctx1__.__IN_Msg = new __messagetype_simpleRouting_Incoming_order("IN_Msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__IN_Msg);
                Port_1.ReceiveMessage(0, __msgEnv__, __ctx1__.__IN_Msg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
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
                    __edata.Messages.Add(__ctx1__.__IN_Msg);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__State = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__Out.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if (__ctx1__ != null)
                    __ctx1__.__Out = null;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                __ctx1__.__myxmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx1__.__Invoice_ID = "";
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                __ctx1__.__Address = "";
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.__result_str = "";
                if (__ctx1__ != null)
                    __ctx1__.__result_str = null;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx1__.__State = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__IN_Msg.part, "string(/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='State' and namespace-uri()=''])", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                __ctx1__.__xmldocument1 = System.Convert.ToInt64(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__IN_Msg.part, "number/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='Number1' and namespace-uri()='']", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                __ctx1__.__xmldocument2 = System.Convert.ToInt64(Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__IN_Msg.part, "number/*[local-name()='AllOrders' and namespace-uri()='http://simpleRouting.Incoming_order']/*[local-name()='Orders' and namespace-uri()='']/*[local-name()='Number2' and namespace-uri()='']", typeof(System.Object)));
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                __condition__ = __ctx1__.__State == "TN";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 26;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                {
                    __messagetype_simpleRouting_tem __Out_Msg = new __messagetype_simpleRouting_tem("Out_Msg", __ctx1__);

                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = __ctx1__.__IN_Msg.part.TypedValue;
                    __ctx1__.__Invoice_ID = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.InvocieId");
                    __ctx1__.__State = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.State");
                    __ctx1__.__Address = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.Address");
                    __ctx1__.__result = __ctx1__.__xmldocument1 + __ctx1__.__xmldocument2;
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument.LoadXml("<ns0:Root xmlns:ns0='http://simpleRouting.tem'><InvoiceID>" + __ctx1__.__Invoice_ID + "</InvoiceID> <Address>" + __ctx1__.__Address + "</Address>  <State>" + __ctx1__.__State + "</State>  <Result> result </Result> </ns0:Root>");
                    __Out_Msg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__myxmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Out_Msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Out_Msg);
                    __ctx1__.__Out_Msg = __Out_Msg;
                    __ctx1__.RefMessage(__ctx1__.__Out_Msg);
                }
                __ctx1__.__Out_Msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                TN.SendMessage(0, __ctx1__.__Out_Msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    __edata.PortName = @"TN";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PostProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 44;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                __condition__ = __ctx1__.__State == "HYD";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 36;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                {
                    __messagetype_simpleRouting_tem __Out_Msg = new __messagetype_simpleRouting_tem("Out_Msg", __ctx1__);

                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = __ctx1__.__IN_Msg.part.TypedValue;
                    __ctx1__.__Invoice_ID = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.InvocieId");
                    __ctx1__.__State = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.State");
                    __ctx1__.__Address = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.Address");
                    __ctx1__.__result = __ctx1__.__xmldocument1 + __ctx1__.__xmldocument2;
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument.LoadXml("<ns0:Root xmlns:ns0='http://simpleRouting.tem'><InvoiceID>" + __ctx1__.__Invoice_ID + "</InvoiceID> <Address>" + __ctx1__.__Address + "</Address>  <State>" + __ctx1__.__State + "</State>  <Result>result</Result> </ns0:Root>");
                    __Out_Msg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__myxmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Out_Msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Out_Msg);
                    __ctx1__.__Out_Msg = __Out_Msg;
                    __ctx1__.RefMessage(__ctx1__.__Out_Msg);
                }
                __ctx1__.__Out_Msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                HYD.SendMessage(0, __ctx1__.__Out_Msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    __edata.PortName = @"HYD";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PostProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 43;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                {
                    __messagetype_simpleRouting_tem __Out_Msg = new __messagetype_simpleRouting_tem("Out_Msg", __ctx1__);

                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument = __ctx1__.__IN_Msg.part.TypedValue;
                    __ctx1__.__Invoice_ID = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.InvocieId");
                    __ctx1__.__State = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.State");
                    __ctx1__.__Address = (System.String)__ctx1__.__IN_Msg.part.GetDistinguishedField("Orders.Address");
                    __ctx1__.__result = __ctx1__.__xmldocument1 + __ctx1__.__xmldocument2;
                    __ctx1__.__myxmlDoc.UnderlyingXmlDocument.LoadXml("<ns0:Root xmlns:ns0='http://simpleRouting.tem'><InvoiceID>" + __ctx1__.__Invoice_ID + "</InvoiceID> <Address>" + __ctx1__.__Address + "</Address>  <State>" + __ctx1__.__State + "</State>  <Result>result</Result> </ns0:Root>");
                    __Out_Msg.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__myxmlDoc.UnderlyingXmlDocument);

                    if (__ctx1__.__Out_Msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Out_Msg);
                    __ctx1__.__Out_Msg = __Out_Msg;
                    __ctx1__.RefMessage(__ctx1__.__Out_Msg);
                }
                __ctx1__.__Out_Msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 41;
            case 41:
                if ( !PreProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OThers.SendMessage(0, __ctx1__.__Out_Msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Out_Msg);
                    __edata.PortName = @"OThers";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__Address = null;
                if (__ctx1__ != null)
                    __ctx1__.__Invoice_ID = null;
                if (__ctx1__ != null)
                    __ctx1__.__myxmlDoc = null;
                if (__ctx1__ != null)
                    __ctx1__.__State = null;
                if (__ctx1__ != null && __ctx1__.__Out_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Out_Msg);
                    __ctx1__.__Out_Msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__IN_Msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__IN_Msg);
                    __ctx1__.__IN_Msg = null;
                }
                if (OThers != null)
                {
                    OThers.Close(__ctx1__, __seg__);
                    OThers = null;
                }
                if (HYD != null)
                {
                    HYD.Close(__ctx1__, __seg__);
                    HYD = null;
                }
                if (TN != null)
                {
                    TN.Close(__ctx1__, __seg__);
                    TN = null;
                }
                Tracker.FireEvent(__eventLocations[21],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if ( !PreProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 46;
            case 46:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 48;
            case 48:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __simpleRouting_Incoming_order__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static simpleRouting.Incoming_order _schema = new simpleRouting.Incoming_order();

        public __simpleRouting_Incoming_order__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "simpleRouting.Incoming_order",
        new System.Type[]{
            typeof(simpleRouting.Incoming_order)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__simpleRouting_Incoming_order__)
        },
        0,
        @"http://simpleRouting.Incoming_order#AllOrders"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_simpleRouting_Incoming_order : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __simpleRouting_Incoming_order__ part;

        private void __CreatePartWrappers()
        {
            part = new __simpleRouting_Incoming_order__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_simpleRouting_Incoming_order(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __simpleRouting_tem__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static simpleRouting.tem _schema = new simpleRouting.tem();

        public __simpleRouting_tem__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "simpleRouting.tem",
        new System.Type[]{
            typeof(simpleRouting.tem)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__simpleRouting_tem__)
        },
        0,
        @"http://simpleRouting.tem#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_simpleRouting_tem : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __simpleRouting_tem__ part;

        private void __CreatePartWrappers()
        {
            part = new __simpleRouting_tem__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_simpleRouting_tem(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
