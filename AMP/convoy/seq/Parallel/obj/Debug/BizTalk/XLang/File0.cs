
#pragma warning disable 162

namespace Parallel
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Customer_details",
        new System.Type[]{
            typeof(Parallel.__messagetype_Parallel_Customer_Details)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Billing_Details",
        new System.Type[]{
            typeof(Parallel.__messagetype_Parallel_Billing_details)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Shopping_details",
        new System.Type[]{
            typeof(Parallel.__messagetype_Parallel_Shopping_Details)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Rcv_order_Type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Rcv_order_Type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Rcv_order_Type(Rcv_order_Type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Rcv_order_Type p = new Rcv_order_Type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Customer_details = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Customer_details",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Rcv_order_Type),
            typeof(__messagetype_Parallel_Customer_Details),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo Billing_Details = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Billing_Details",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Rcv_order_Type),
            typeof(__messagetype_Parallel_Billing_details),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo Shopping_details = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Shopping_details",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Rcv_order_Type),
            typeof(__messagetype_Parallel_Shopping_Details),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Customer_details" ] = Customer_details;
                h[ "Billing_Details" ] = Billing_Details;
                h[ "Shopping_details" ] = Shopping_details;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Parallel.__messagetype_Parallel_Output_schema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Order_placement_Type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Order_placement_Type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Order_placement_Type(Order_placement_Type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Order_placement_Type p = new Order_placement_Type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Order_placement_Type),
            typeof(__messagetype_Parallel_Output_schema),
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
            typeof(Parallel.__messagetype_Parallel_Shopping_Details)
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
            typeof(__messagetype_Parallel_Shopping_Details),
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
            "Parallel.PropertySchema.Cust_ID"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new Parallel.PropertySchema.Cust_ID()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 483 "C:\AMP\convoy\seq\Parallel\Order_placing.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Rcv_order", "Billing_Details", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Rcv_order", "Customer_details", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        2, "Rcv_order", "Shopping_details", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Parallel.Rcv_order_Type),
            typeof(Parallel.Order_placement_Type),
            typeof(Parallel.PortType_1)
        },
        new System.String[] {
            "Rcv_order",
            "Order_placement",
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
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Order_placing : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Order_placing));
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

        static Order_placing()
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 1, 4)
            };

            _Locks = 0;
            _rootContext = new __Order_placing_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Order_placing(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Order_placing", tracker)
        {
            ConstructorHelper();
        }

        public Order_placing(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Order_placing")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>5c415d24-4c3f-44df-afd7-33d200e11c27</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ParallelShape</shapeType>      <ShapeID>fdc8d23f-0997-42a2-99f4-eb85d9a7202e</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ParallelActions_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>2f7581e2-e7cf-481a-859b-4a4b1bd1ffbb</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>9ffa59c6-8083-49af-8a9c-c72c83d8df92</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Billing_Details</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>51425f7d-e28d-44ca-b420-2e8654dda323</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>118e7fa8-6901-4afc-876e-7cd593ee7e29</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Customer_details</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ParallelBranchShape</shapeType>      <ShapeID>535f6b47-a550-4b57-a985-93d12f2fdeb6</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ParallelBranch_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1dd051a7-b7e3-4d15-a59a-f21d75593601</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Shopping_details</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>dc34ee31-5a3d-4a55-bf87-e3d3c67aa953</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>133fd695-fede-4f96-99a8-08cbd2507dbd</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Expression_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>b6b20c17-9cca-47a3-a9a7-fe3798057068</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>96515884-5a19-4a4b-9e5d-d4e80a4ea813</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>da9a2ace-015c-44b4-a7c9-4358368f7f8d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>b17c99ca-f257-43a5-a3a1-70ca23166f35</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1822c49b-9e69-4b90-84e1-423637bdbf0d</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>bf447fdb-1b4f-46f8-bf38-b388c520da85</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>d162eb64-3cbe-4056-8407-8feffde0222e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>591a497b-28e6-4630-b50b-ec1fd13c0bb9</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>2af7018a-e335-4d7e-8f3f-639b97fe08c0</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>dfb5b4ca-7600-495c-8990-77d9e955ab1e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>71e7cc92-4e15-449b-ac52-9e85389db3b0</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>c832f78b-e730-4c0c-8538-78c564bb2e8e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e532e328-05a2-4140-9e94-36b468595cbf</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>c9326d65-f966-4c00-9278-4cd132039f79</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>6808d0e7-3d95-4543-97a1-557d254ded8d</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a8c016db-7725-496a-8719-8bd457f344aa</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>8bc820ec-5764-4d86-ae0a-cb80f65fce31</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>68ee6e2b-3dcc-4c50-b154-c9afcb314496</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>08351e06-a4cb-41b6-b036-deff742b74ec</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>687304ce-2c16-493d-9ad6-2bc86680c124</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Order_placing</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Order_placing'</ActionName><IsAtomic>0</IsAtomic><Line>483</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>504</Line><Position>13</Position><ShapeID>'fdc8d23f-0997-42a2-99f4-eb85d9a7202e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>509</Line><Position>30</Position><ShapeID>'9ffa59c6-8083-49af-8a9c-c72c83d8df92'</ShapeID>
<Messages>
	<MsgInfo><name>Bill_details</name><part>part</part><schema>Parallel.Billing_details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>514</Line><Position>30</Position><ShapeID>'118e7fa8-6901-4afc-876e-7cd593ee7e29'</ShapeID>
<Messages>
	<MsgInfo><name>Cust_details</name><part>part</part><schema>Parallel.Customer_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>519</Line><Position>30</Position><ShapeID>'1dd051a7-b7e3-4d15-a59a-f21d75593601'</ShapeID>
<Messages>
	<MsgInfo><name>Shop_details</name><part>part</part><schema>Parallel.Shopping_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>523</Line><Position>22</Position><ShapeID>'dc34ee31-5a3d-4a55-bf87-e3d3c67aa953'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>528</Line><Position>18</Position><ShapeID>'133fd695-fede-4f96-99a8-08cbd2507dbd'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>531</Line><Position>13</Position><ShapeID>'b6b20c17-9cca-47a3-a9a7-fe3798057068'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>534</Line><Position>17</Position><ShapeID>'da9a2ace-015c-44b4-a7c9-4358368f7f8d'</ShapeID>
<Messages>
	<MsgInfo><name>Final_order</name><part>part</part><schema>Parallel.Output_schema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Bill_details</name><part>part</part><schema>Parallel.Billing_details</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Cust_details</name><part>part</part><schema>Parallel.Customer_Details</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Shop_details</name><part>part</part><schema>Parallel.Shopping_Details</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>540</Line><Position>17</Position><ShapeID>'dfb5b4ca-7600-495c-8990-77d9e955ab1e'</ShapeID>
<Messages>
	<MsgInfo><name>Final_order</name><part>part</part><schema>Parallel.Output_schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>545</Line><Position>17</Position><ShapeID>'c832f78b-e730-4c0c-8538-78c564bb2e8e'</ShapeID>
<Messages>
	<MsgInfo><name>Final_order</name><part>part</part><schema>Parallel.Output_schema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Bill_details</name><part>part</part><schema>Parallel.Billing_details</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Cust_details</name><part>part</part><schema>Parallel.Customer_Details</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>Shop_details</name><part>part</part><schema>Parallel.Shopping_Details</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>551</Line><Position>17</Position><ShapeID>'08351e06-a4cb-41b6-b036-deff742b74ec'</ShapeID>
<Messages>
	<MsgInfo><name>Shop_details</name><part>part</part><schema>Parallel.Shopping_Details</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>554</Line><Position>28</Position><ShapeID>'687304ce-2c16-493d-9ad6-2bc86680c124'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='8cd377c2-98ea-4d3c-80f7-f65195c72436' LowerBound='1.1' HigherBound='115.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Parallel' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='9593da06-396d-453f-90a7-dccffc4dca97' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='19.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Rcv_order_Type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c51baf96-c417-4a34-a9d6-48ccce485b90' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Customer_details' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e68b0d2d-a352-4464-98a2-ebc0bc73d477' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.29'>
                    <om:Property Name='Ref' Value='Parallel.Customer_Details' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='OperationDeclaration' OID='cb65ee61-ccec-4514-b0b5-a446d5251899' ParentLink='PortType_OperationDeclaration' LowerBound='10.1' HigherBound='14.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Billing_Details' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='3c6aacc8-19b6-40a7-bd6c-ac8d02580fb6' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='12.13' HigherBound='12.28'>
                    <om:Property Name='Ref' Value='Parallel.Billing_details' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='OperationDeclaration' OID='739c7b37-fd65-4269-8b28-b79b308360a3' ParentLink='PortType_OperationDeclaration' LowerBound='14.1' HigherBound='18.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Shopping_details' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='d6cd81d7-027b-4fc3-94e0-5fe53f8257be' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='16.13' HigherBound='16.29'>
                    <om:Property Name='Ref' Value='Parallel.Shopping_Details' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='901ddb16-71a9-4de5-bd77-b485c7f43fca' ParentLink='Module_PortType' LowerBound='19.1' HigherBound='26.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Order_placement_Type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d04b5496-5f4d-4548-b7d7-ca036f3d37e2' ParentLink='PortType_OperationDeclaration' LowerBound='21.1' HigherBound='25.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='06dd0f29-36bf-4bad-bb21-923c67561f53' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='23.13' HigherBound='23.26'>
                    <om:Property Name='Ref' Value='Parallel.Output_schema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='3cb4f2a6-bbb8-4799-b50c-d01e1552ffb1' ParentLink='Module_PortType' LowerBound='26.1' HigherBound='33.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d82d1eb0-45c4-42e4-908b-31d182587965' ParentLink='PortType_OperationDeclaration' LowerBound='28.1' HigherBound='32.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='eef5a209-78ba-43c5-8558-3c4c033af823' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='30.13' HigherBound='30.29'>
                    <om:Property Name='Ref' Value='Parallel.Shopping_Details' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='147675b5-eff9-45c3-b756-e609f2042bee' ParentLink='Module_CorrelationType' LowerBound='33.1' HigherBound='37.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='d806bf49-23c9-43e4-9206-774e8ee27021' ParentLink='CorrelationType_PropertyRef' LowerBound='35.9' HigherBound='35.31'>
                <om:Property Name='Ref' Value='Parallel.PropertySchema.Cust_ID' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ab23d2bc-6ebb-4a1c-b3eb-8f901a42e2c6' ParentLink='Module_ServiceDeclaration' LowerBound='37.1' HigherBound='114.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Order_placing' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='813f89f9-fbdd-46f6-a32d-4da9f3b3db02' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.DateTime' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='rcv_time' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1e94900a-e824-4703-8c50-0517f967208a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.DateTime' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='order_cmp_time' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='5feae7c2-0b7b-4e3d-88de-46fe4b9da843' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Type' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='b4d77d6a-f675-4542-b8cc-7c26df0c0250' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmldoc' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='e85157b5-8845-4649-bbca-76c5b287e31d' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='Type' Value='Parallel.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='7fe8918e-5d82-41cd-a543-b0055d1b4341' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='64.80' HigherBound='64.104'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='9ffa59c6-8083-49af-8a9c-c72c83d8df92' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='e5f25eb4-bb5e-4a16-871a-aa46711b7030' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='69.81' HigherBound='69.105'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='118e7fa8-6901-4afc-876e-7cd593ee7e29' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='f4fa025b-d9f3-4c79-b302-eaf1a8c787c4' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='74.81' HigherBound='74.105'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='1dd051a7-b7e3-4d15-a59a-f21d75593601' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_3' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b9186fea-5bd8-47f4-977a-f3b1b7874577' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='Type' Value='Parallel.Billing_details' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Bill_details' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c299d3ee-9938-4f27-bc1b-bab0617f945e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='48.1' HigherBound='49.1'>
                <om:Property Name='Type' Value='Parallel.Shopping_Details' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Shop_details' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d536f12d-49aa-4802-989d-e2b82f7d87b8' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='49.1' HigherBound='50.1'>
                <om:Property Name='Type' Value='Parallel.Customer_Details' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Cust_details' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='5d611b0c-2080-40b7-ad5a-de85d2992b18' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='50.1' HigherBound='51.1'>
                <om:Property Name='Type' Value='Parallel.Output_schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Final_order' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='332c4f03-9c4c-458d-a33d-004e67ed1867' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='Type' Value='Parallel.Shopping_Details' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Type_of_Item' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='5c415d24-4c3f-44df-afd7-33d200e11c27' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Parallel' OID='fdc8d23f-0997-42a2-99f4-eb85d9a7202e' ParentLink='ServiceBody_Statement' LowerBound='58.1' HigherBound='77.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ParallelActions_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ParallelBranch' OID='2f7581e2-e7cf-481a-859b-4a4b1bd1ffbb' ParentLink='ReallyComplexStatement_Branch' LowerBound='63.1' HigherBound='65.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='9ffa59c6-8083-49af-8a9c-c72c83d8df92' ParentLink='ComplexStatement_Statement' LowerBound='63.1' HigherBound='65.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Rcv_order' />
                            <om:Property Name='MessageName' Value='Bill_details' />
                            <om:Property Name='OperationName' Value='Billing_Details' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Billing_Details' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='51425f7d-e28d-44ca-b420-2e8654dda323' ParentLink='ReallyComplexStatement_Branch' LowerBound='68.1' HigherBound='70.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_2' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='118e7fa8-6901-4afc-876e-7cd593ee7e29' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='70.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Rcv_order' />
                            <om:Property Name='MessageName' Value='Cust_details' />
                            <om:Property Name='OperationName' Value='Customer_details' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Customer_details' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ParallelBranch' OID='535f6b47-a550-4b57-a985-93d12f2fdeb6' ParentLink='ReallyComplexStatement_Branch' LowerBound='73.1' HigherBound='75.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ParallelBranch_3' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Receive' OID='1dd051a7-b7e3-4d15-a59a-f21d75593601' ParentLink='ComplexStatement_Statement' LowerBound='73.1' HigherBound='75.1'>
                            <om:Property Name='Activate' Value='True' />
                            <om:Property Name='PortName' Value='Rcv_order' />
                            <om:Property Name='MessageName' Value='Shop_details' />
                            <om:Property Name='OperationName' Value='Shopping_details' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Shopping_details' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='dc34ee31-5a3d-4a55-bf87-e3d3c67aa953' ParentLink='ServiceBody_Statement' LowerBound='77.1' HigherBound='81.1'>
                    <om:Property Name='Expression' Value='rcv_time = System.DateTime.Now;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;message started&quot;,rcv_time.ToString());' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_4' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='VariableAssignment' OID='133fd695-fede-4f96-99a8-08cbd2507dbd' ParentLink='ServiceBody_Statement' LowerBound='81.1' HigherBound='85.1'>
                    <om:Property Name='Expression' Value='&#xD;&#xA;Type = Shop_details.Type;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Type of item is&quot;,Type.ToString());' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Expression_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='Decision' OID='b6b20c17-9cca-47a3-a9a7-fe3798057068' ParentLink='ServiceBody_Statement' LowerBound='85.1' HigherBound='108.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='DecisionBranch' OID='96515884-5a19-4a4b-9e5d-d4e80a4ea813' ParentLink='ReallyComplexStatement_Branch' LowerBound='86.13' HigherBound='97.1'>
                        <om:Property Name='Expression' Value='Shop_details.Type == &quot;Banking&quot;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='da9a2ace-015c-44b4-a7c9-4358368f7f8d' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='94.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='b17c99ca-f257-43a5-a3a1-70ca23166f35' ParentLink='ComplexStatement_Statement' LowerBound='91.1' HigherBound='93.1'>
                                <om:Property Name='ClassName' Value='Parallel.Transform_1' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='1822c49b-9e69-4b90-84e1-423637bdbf0d' ParentLink='Transform_InputMessagePartRef' LowerBound='92.69' HigherBound='92.81'>
                                    <om:Property Name='MessageRef' Value='Bill_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='bf447fdb-1b4f-46f8-bf38-b388c520da85' ParentLink='Transform_InputMessagePartRef' LowerBound='92.83' HigherBound='92.95'>
                                    <om:Property Name='MessageRef' Value='Cust_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='d162eb64-3cbe-4056-8407-8feffde0222e' ParentLink='Transform_InputMessagePartRef' LowerBound='92.97' HigherBound='92.109'>
                                    <om:Property Name='MessageRef' Value='Shop_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='591a497b-28e6-4630-b50b-ec1fd13c0bb9' ParentLink='Transform_OutputMessagePartRef' LowerBound='92.32' HigherBound='92.43'>
                                    <om:Property Name='MessageRef' Value='Final_order' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='2af7018a-e335-4d7e-8f3f-639b97fe08c0' ParentLink='Construct_MessageRef' LowerBound='89.27' HigherBound='89.38'>
                                <om:Property Name='Ref' Value='Final_order' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='dfb5b4ca-7600-495c-8990-77d9e955ab1e' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='96.1'>
                            <om:Property Name='PortName' Value='Order_placement' />
                            <om:Property Name='MessageName' Value='Final_order' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='71e7cc92-4e15-449b-ac52-9e85389db3b0' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='c832f78b-e730-4c0c-8538-78c564bb2e8e' ParentLink='ComplexStatement_Statement' LowerBound='99.1' HigherBound='105.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='MessageRef' OID='e532e328-05a2-4140-9e94-36b468595cbf' ParentLink='Construct_MessageRef' LowerBound='100.27' HigherBound='100.38'>
                                <om:Property Name='Ref' Value='Final_order' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Transform' OID='c9326d65-f966-4c00-9278-4cd132039f79' ParentLink='ComplexStatement_Statement' LowerBound='102.1' HigherBound='104.1'>
                                <om:Property Name='ClassName' Value='Parallel.Transform_1' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='6808d0e7-3d95-4543-97a1-557d254ded8d' ParentLink='Transform_OutputMessagePartRef' LowerBound='103.32' HigherBound='103.43'>
                                    <om:Property Name='MessageRef' Value='Final_order' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='a8c016db-7725-496a-8719-8bd457f344aa' ParentLink='Transform_InputMessagePartRef' LowerBound='103.69' HigherBound='103.81'>
                                    <om:Property Name='MessageRef' Value='Bill_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='8bc820ec-5764-4d86-ae0a-cb80f65fce31' ParentLink='Transform_InputMessagePartRef' LowerBound='103.83' HigherBound='103.95'>
                                    <om:Property Name='MessageRef' Value='Cust_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='68ee6e2b-3dcc-4c50-b154-c9afcb314496' ParentLink='Transform_InputMessagePartRef' LowerBound='103.97' HigherBound='103.109'>
                                    <om:Property Name='MessageRef' Value='Shop_details' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='08351e06-a4cb-41b6-b036-deff742b74ec' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='107.1'>
                            <om:Property Name='PortName' Value='Port_1' />
                            <om:Property Name='MessageName' Value='Shop_details' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='VariableAssignment' OID='687304ce-2c16-493d-9ad6-2bc86680c124' ParentLink='ServiceBody_Statement' LowerBound='108.1' HigherBound='112.1'>
                    <om:Property Name='Expression' Value='order_cmp_time = System.DateTime.Now;&#xD;&#xA;&#xD;&#xA;System.Diagnostics.EventLog.WriteEntry(&quot;Order_creation completed @&quot;,order_cmp_time.ToString());' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Order_placing' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='9e926e18-1c38-4aa3-bef2-faa94aeff1f9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='40.1' HigherBound='42.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Parallel.Rcv_order_Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Rcv_order' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='765ec27d-2a58-4a88-a3a2-9d1603bcfcde' ParentLink='PortDeclaration_CLRAttribute' LowerBound='40.1' HigherBound='41.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='74f77768-cf83-410b-b8d8-21b20d525955' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='42.1' HigherBound='44.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Parallel.Order_placement_Type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Order_placement' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ddc058d2-3d5c-45c5-8f69-56a5eff8f580' ParentLink='PortDeclaration_CLRAttribute' LowerBound='42.1' HigherBound='43.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='350910c5-9aa6-4229-a069-465030139173' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='44.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='27' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Parallel.PortType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c26dd15a-32da-4810-8908-97b602ab8dd1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='44.1' HigherBound='45.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Order_placing_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Order_placing_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Order_placing")
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
                Order_placing __svc__ = (Order_placing)_service;
                __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_1 != null)
                {
                    __svc__.Port_1.Close(this, null);
                    __svc__.Port_1 = null;
                }
                if (__svc__.Order_placement != null)
                {
                    __svc__.Order_placement.Close(this, null);
                    __svc__.Order_placement = null;
                }
                if (__svc__.Rcv_order != null)
                {
                    __svc__.Rcv_order.Close(this, null);
                    __svc__.Rcv_order = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
        }


        [System.SerializableAttribute]
        public class __Order_placing_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Order_placing_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Order_placing")
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
                Order_placing __svc__ = (Order_placing)_service;
                __Order_placing_1 __ctx1__ = (__Order_placing_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (__ctx1__ != null)
                    __ctx1__.__Type = null;
                if (__ctx1__ != null && __ctx1__.__Cust_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Cust_details);
                    __ctx1__.__Cust_details = null;
                }
                if (__ctx1__ != null && __ctx1__.__Shop_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Shop_details);
                    __ctx1__.__Shop_details = null;
                }
                if (__ctx1__ != null && __ctx1__.__Final_order != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Final_order);
                    __ctx1__.__Final_order = null;
                }
                if (__ctx1__ != null && __ctx1__.__Bill_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Bill_details);
                    __ctx1__.__Bill_details = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Bill_details")]
            public __messagetype_Parallel_Billing_details __Bill_details;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Shop_details")]
            public __messagetype_Parallel_Shopping_Details __Shop_details;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Cust_details")]
            public __messagetype_Parallel_Customer_Details __Cust_details;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Final_order")]
            public __messagetype_Parallel_Output_schema __Final_order;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
            [Microsoft.XLANGs.Core.UserVariableAttribute("rcv_time")]
            internal System.DateTime __rcv_time;
            [Microsoft.XLANGs.Core.UserVariableAttribute("order_cmp_time")]
            internal System.DateTime __order_cmp_time;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Type")]
            internal System.String __Type;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("Rcv_order")]
        internal Rcv_order_Type Rcv_order;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Order_placement")]
        internal Order_placement_Type Order_placement;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_1")]
        internal PortType_1 Port_1;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Rcv_order_Type.Customer_details, Rcv_order_Type.Billing_Details, Rcv_order_Type.Shopping_details},
                                               typeof(Order_placing).GetField("Rcv_order", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Order_placing), "Rcv_order"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Order_placement_Type.Operation_1},
                                               typeof(Order_placing).GetField("Order_placement", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Order_placing), "Order_placement"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_1.Operation_1},
                                               typeof(Order_placing).GetField("Port_1", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Order_placing), "Port_1"),
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
                return new object[3]{
                     new object[5] { _portInfo[0], 1, null , 0, true }
                    , new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[0], 2, null , 0, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "fdc8d23f-0997-42a2-99f4-eb85d9a7202e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "fdc8d23f-0997-42a2-99f4-eb85d9a7202e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "9ffa59c6-8083-49af-8a9c-c72c83d8df92", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "9ffa59c6-8083-49af-8a9c-c72c83d8df92", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "118e7fa8-6901-4afc-876e-7cd593ee7e29", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "118e7fa8-6901-4afc-876e-7cd593ee7e29", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "1dd051a7-b7e3-4d15-a59a-f21d75593601", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "1dd051a7-b7e3-4d15-a59a-f21d75593601", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "dc34ee31-5a3d-4a55-bf87-e3d3c67aa953", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "dc34ee31-5a3d-4a55-bf87-e3d3c67aa953", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "133fd695-fede-4f96-99a8-08cbd2507dbd", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "133fd695-fede-4f96-99a8-08cbd2507dbd", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "b6b20c17-9cca-47a3-a9a7-fe3798057068", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "da9a2ace-015c-44b4-a7c9-4358368f7f8d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "da9a2ace-015c-44b4-a7c9-4358368f7f8d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "dfb5b4ca-7600-495c-8990-77d9e955ab1e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "dfb5b4ca-7600-495c-8990-77d9e955ab1e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "c832f78b-e730-4c0c-8538-78c564bb2e8e", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "c832f78b-e730-4c0c-8538-78c564bb2e8e", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "08351e06-a4cb-41b6-b036-deff742b74ec", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "08351e06-a4cb-41b6-b036-deff742b74ec", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "b6b20c17-9cca-47a3-a9a7-fe3798057068", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "687304ce-2c16-493d-9ad6-2bc86680c124", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "687304ce-2c16-493d-9ad6-2bc86680c124", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Parallel),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,11,11,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,3,2,2,9,9,10,10,12,12,13,13,14,14,15,15,16,17,17,17,18,14,19,19,20,21,21,21,22,23,24,24,25,25,11,11,11,11,};
        public static int[] __progressLocation2 = new int[] { 3,3,4,2,};
        public static int[] __progressLocation3 = new int[] { 5,5,6,2,};
        public static int[] __progressLocation4 = new int[] { 7,7,8,2,};

        public static int[][] __progressLocations = new int[5] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)_stateMgrs[0];
            __Order_placing_1 __ctx1__ = (__Order_placing_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Rcv_order = new Rcv_order_Type(0, this);
                Order_placement = new Order_placement_Type(1, this);
                Port_1 = new PortType_1(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Rcv_order, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Rcv_order, this);
                __ctx0__.__subWrapper2 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[2], Rcv_order, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Order_placing_1(this);
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
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)_stateMgrs[0];
            __Order_placing_1 __ctx1__ = (__Order_placing_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__rcv_time = default(System.DateTime);
                __ctx1__.__order_cmp_time = default(System.DateTime);
                __ctx1__.__Type = default(System.String);
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
                __seg__.RunSegments(new Microsoft.XLANGs.Core.Segment[] {_segments[2], _segments[3], _segments[4]}, this);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if (Rcv_order != null)
                {
                    Rcv_order.Close(__ctx1__, __seg__);
                    Rcv_order = null;
                }
                Tracker.FireEvent(__eventLocations[2],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx1__.__rcv_time = System.DateTime.Now;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                System.Diagnostics.EventLog.WriteEntry("message started", __ctx1__.__rcv_time.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __ctx1__.__Type = (System.String)__ctx1__.__Shop_details.part.GetDistinguishedField("Type");
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                System.Diagnostics.EventLog.WriteEntry("Type of item is", __ctx1__.__Type.ToString());
                if (__ctx1__ != null)
                    __ctx1__.__Type = null;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                __condition__ = (System.String)__ctx1__.__Shop_details.part.GetDistinguishedField("Type") == "Banking";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 24;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_Parallel_Output_schema __Final_order = new __messagetype_Parallel_Output_schema("Final_order", __ctx1__);

                    ApplyTransform(typeof(Parallel.Transform_1), new object[] {__Final_order.part}, new object[] {__ctx1__.__Bill_details.part, __ctx1__.__Cust_details.part, __ctx1__.__Shop_details.part});

                    if (__ctx1__.__Final_order != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Final_order);
                    __ctx1__.__Final_order = __Final_order;
                    __ctx1__.RefMessage(__ctx1__.__Final_order);
                }
                __ctx1__.__Final_order.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Final_order);
                    __edata.Messages.Add(__ctx1__.__Bill_details);
                    __edata.Messages.Add(__ctx1__.__Cust_details);
                    __edata.Messages.Add(__ctx1__.__Shop_details);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Order_placement.SendMessage(0, __ctx1__.__Final_order, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Final_order);
                    __edata.PortName = @"Order_placement";
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 31;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                {
                    __messagetype_Parallel_Output_schema __Final_order = new __messagetype_Parallel_Output_schema("Final_order", __ctx1__);

                    ApplyTransform(typeof(Parallel.Transform_1), new object[] {__Final_order.part}, new object[] {__ctx1__.__Bill_details.part, __ctx1__.__Cust_details.part, __ctx1__.__Shop_details.part});

                    if (__ctx1__.__Final_order != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Final_order);
                    __ctx1__.__Final_order = __Final_order;
                    __ctx1__.RefMessage(__ctx1__.__Final_order);
                }
                __ctx1__.__Final_order.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Final_order);
                    __edata.Messages.Add(__ctx1__.__Bill_details);
                    __edata.Messages.Add(__ctx1__.__Cust_details);
                    __edata.Messages.Add(__ctx1__.__Shop_details);
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_1.SendMessage(0, __ctx1__.__Shop_details, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Shop_details);
                    __edata.PortName = @"Port_1";
                    Tracker.FireEvent(__eventLocations[22],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Final_order != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Final_order);
                    __ctx1__.__Final_order = null;
                }
                if (__ctx1__ != null && __ctx1__.__Cust_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Cust_details);
                    __ctx1__.__Cust_details = null;
                }
                if (__ctx1__ != null && __ctx1__.__Shop_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Shop_details);
                    __ctx1__.__Shop_details = null;
                }
                if (__ctx1__ != null && __ctx1__.__Bill_details != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Bill_details);
                    __ctx1__.__Bill_details = null;
                }
                if (Port_1 != null)
                {
                    Port_1.Close(__ctx1__, __seg__);
                    Port_1 = null;
                }
                if (Order_placement != null)
                {
                    Order_placement.Close(__ctx1__, __seg__);
                    Order_placement = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[9],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                __ctx1__.__order_cmp_time = System.DateTime.Now;
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                System.Diagnostics.EventLog.WriteEntry("Order_creation completed @", __ctx1__.__order_cmp_time.ToString());
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[10],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 39;
            case 39:
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
            __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)_stateMgrs[0];
            __Order_placing_1 __ctx1__ = (__Order_placing_1)_stateMgrs[1];

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
                if (!Rcv_order.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Bill_details != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Bill_details);
                __ctx1__.__Bill_details = new __messagetype_Parallel_Billing_details("Bill_details", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Bill_details);
                Rcv_order.ReceiveMessage(1, __msgEnv__, __ctx1__.__Bill_details, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Bill_details);
                    __edata.PortName = @"Rcv_order";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
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

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)_stateMgrs[0];
            __Order_placing_1 __ctx1__ = (__Order_placing_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                if ( !PreProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 1;
            case 1:
                if (!Rcv_order.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Cust_details != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Cust_details);
                __ctx1__.__Cust_details = new __messagetype_Parallel_Customer_Details("Cust_details", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Cust_details);
                Rcv_order.ReceiveMessage(0, __msgEnv__, __ctx1__.__Cust_details, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Cust_details);
                    __edata.PortName = @"Rcv_order";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
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
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Order_placing_root_0 __ctx0__ = (__Order_placing_root_0)_stateMgrs[0];
            __Order_placing_1 __ctx1__ = (__Order_placing_1)_stateMgrs[1];

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
                if (!Rcv_order.GetMessageId(__ctx0__.__subWrapper2.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Shop_details != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Shop_details);
                __ctx1__.__Shop_details = new __messagetype_Parallel_Shopping_Details("Shop_details", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Shop_details);
                Rcv_order.ReceiveMessage(2, __msgEnv__, __ctx1__.__Shop_details, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Shop_details);
                    __edata.PortName = @"Rcv_order";
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
    }

    [System.SerializableAttribute]
    sealed public class __Parallel_Customer_Details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Parallel.Customer_Details _schema = new Parallel.Customer_Details();

        public __Parallel_Customer_Details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Parallel.Customer_Details",
        new System.Type[]{
            typeof(Parallel.Customer_Details)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Parallel_Customer_Details__)
        },
        0,
        @"http://Parallel.Customer_Details#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Parallel_Customer_Details : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Parallel_Customer_Details__ part;

        private void __CreatePartWrappers()
        {
            part = new __Parallel_Customer_Details__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Parallel_Customer_Details(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Parallel_Billing_details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Parallel.Billing_details _schema = new Parallel.Billing_details();

        public __Parallel_Billing_details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Parallel.Billing_details",
        new System.Type[]{
            typeof(Parallel.Billing_details)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Parallel_Billing_details__)
        },
        0,
        @"http://Parallel.Billing_details#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Parallel_Billing_details : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Parallel_Billing_details__ part;

        private void __CreatePartWrappers()
        {
            part = new __Parallel_Billing_details__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Parallel_Billing_details(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Parallel_Shopping_Details__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Parallel.Shopping_Details _schema = new Parallel.Shopping_Details();

        public __Parallel_Shopping_Details__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Parallel.Shopping_Details",
        new System.Type[]{
            typeof(Parallel.Shopping_Details)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Parallel_Shopping_Details__)
        },
        0,
        @"http://Parallel.Shopping_Details#Shopping_details"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Parallel_Shopping_Details : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Parallel_Shopping_Details__ part;

        private void __CreatePartWrappers()
        {
            part = new __Parallel_Shopping_Details__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Parallel_Shopping_Details(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Parallel_Output_schema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Parallel.Output_schema _schema = new Parallel.Output_schema();

        public __Parallel_Output_schema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Parallel.Output_schema",
        new System.Type[]{
            typeof(Parallel.Output_schema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Parallel_Output_schema__)
        },
        0,
        @"http://Parallel.Output_schema#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Parallel_Output_schema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Parallel_Output_schema__ part;

        private void __CreatePartWrappers()
        {
            part = new __Parallel_Output_schema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Parallel_Output_schema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
