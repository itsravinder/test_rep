
#pragma warning disable 162

namespace seq
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CI_msg",
        new System.Type[]{
            typeof(seq.__messagetype_seq_Customer_info)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "PI_msg",
        new System.Type[]{
            typeof(seq.__messagetype_seq_Purchase_info)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class rcv_message_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public rcv_message_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public rcv_message_type(rcv_message_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            rcv_message_type p = new rcv_message_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo CI_msg = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CI_msg",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(rcv_message_type),
            typeof(__messagetype_seq_Customer_info),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public Microsoft.XLANGs.Core.OperationInfo PI_msg = new Microsoft.XLANGs.Core.OperationInfo
        (
            "PI_msg",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(rcv_message_type),
            typeof(__messagetype_seq_Purchase_info),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "CI_msg" ] = CI_msg;
                h[ "PI_msg" ] = PI_msg;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(seq.__messagetype_seq_Output_schema)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Output_msg_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Output_msg_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Output_msg_type(Output_msg_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Output_msg_type p = new Output_msg_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Output_msg_type),
            typeof(__messagetype_seq_Output_schema),
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
            typeof(seq.__messagetype_System_String)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Error_msg_type : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Error_msg_type(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Error_msg_type(Error_msg_type p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Error_msg_type p = new Error_msg_type(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Error_msg_type),
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(seq.__messagetype_seq_Purchase_info)
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
            typeof(__messagetype_seq_Purchase_info),
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
            "seq.PropertySchema.PoNo"
        }
    )]
    sealed internal class CorrelationType_1 : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new seq.PropertySchema.PoNo()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 371 "C:\AMP\convoy\seq\seq\BizTalk Orchestration1.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationType_1) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Rcv_messages", "CI_msg", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "Rcv_messages", "PI_msg", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(seq.rcv_message_type),
            typeof(seq.Output_msg_type),
            typeof(seq.Error_msg_type)
        },
        new System.String[] {
            "Rcv_messages",
            "OutPut",
            "Error_output"
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __BizTalk_Orchestration1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>02ac0e0c-c5f6-402f-8d72-0fcbbea57da5</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenShape</shapeType>      <ShapeID>9f1b0604-4f82-4f66-9f9f-88e93a86506c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Listen_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>49e5c5d4-1c23-4f98-b9e6-b8c99e936a99</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3f8ff365-7d52-48f5-bb98-ff347b0bd199</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ed1d9706-1571-4665-aaa4-a7c134b85d6d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>5e4ec1e8-57fd-4fed-8adc-f6a946e75445</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>50a5e4d9-7a23-4af7-9442-8e28a8a9d94e</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7866acdc-e059-4b55-a7d4-d05100df5142</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3de576cc-8d40-4ddd-b52e-991bc1b8bb2a</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>8241d7c2-55e5-448d-bb74-26fc70e3ed2b</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b8d585da-b677-47d4-90c1-01d7f35772b3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>4d7a35e1-6cdf-4dad-a0e7-7b0e04eaa7b7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>6eef6492-2483-46ba-ab02-b9f6fcb7b093</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>ffb0536e-b8a0-49b9-bc9c-b79054524b12</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>44a5418f-d7a7-4b20-b586-8ba9e7556b51</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>5347e674-f9ad-45b3-b615-281690d90e18</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DelayShape</shapeType>      <ShapeID>0c1ea116-a79e-419f-b8b3-3afd22d6c9c0</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Delay_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalk_Orchestration1'</ActionName><IsAtomic>0</IsAtomic><Line>371</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>389</Line><Position>22</Position><ShapeID>'60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453'</ShapeID>
<Messages>
	<MsgInfo><name>CI_msg</name><part>part</part><schema>seq.Customer_info</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>392</Line><Position>13</Position><ShapeID>'9f1b0604-4f82-4f66-9f9f-88e93a86506c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>394</Line><Position>23</Position><ShapeID>'3f8ff365-7d52-48f5-bb98-ff347b0bd199'</ShapeID>
<Messages>
	<MsgInfo><name>PI_msg</name><part>part</part><schema>seq.Purchase_info</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>397</Line><Position>21</Position><ShapeID>'ed1d9706-1571-4665-aaa4-a7c134b85d6d'</ShapeID>
<Messages>
	<MsgInfo><name>Output_msg</name><part>part</part><schema>seq.Output_schema</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CI_msg</name><part>part</part><schema>seq.Customer_info</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>PI_msg</name><part>part</part><schema>seq.Purchase_info</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>403</Line><Position>21</Position><ShapeID>'b8d585da-b677-47d4-90c1-01d7f35772b3'</ShapeID>
<Messages>
	<MsgInfo><name>Output_msg</name><part>part</part><schema>seq.Output_schema</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>409</Line><Position>21</Position><ShapeID>'6eef6492-2483-46ba-ab02-b9f6fcb7b093'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>415</Line><Position>21</Position><ShapeID>'5347e674-f9ad-45b3-b615-281690d90e18'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='5c39b046-0467-48c7-bd48-35bfed953609' LowerBound='1.1' HigherBound='91.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='seq' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='77fcd42a-6721-482a-9d7f-c17e2e1a7624' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='15.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='rcv_message_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='aac2d548-98c0-4d29-9a3a-67eab5ae9d41' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CI_msg' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='bdd4ccc8-62c9-42ec-bd53-39c0a39bb1a7' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='seq.Customer_info' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='OperationDeclaration' OID='a3b244a9-9110-493d-a5ff-6c460be3bb33' ParentLink='PortType_OperationDeclaration' LowerBound='10.1' HigherBound='14.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PI_msg' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='14d86119-85dd-4798-8656-d5fcb4da2155' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='12.13' HigherBound='12.26'>
                    <om:Property Name='Ref' Value='seq.Purchase_info' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='71388a26-4c90-41ee-a7ed-d8063994a8f6' ParentLink='Module_PortType' LowerBound='15.1' HigherBound='22.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Output_msg_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e8a2224b-1467-4fcf-98c5-8c710889681a' ParentLink='PortType_OperationDeclaration' LowerBound='17.1' HigherBound='21.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0564f1a8-185d-4457-bb46-216db9dcde52' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='19.13' HigherBound='19.26'>
                    <om:Property Name='Ref' Value='seq.Output_schema' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8c42d441-4dd6-4768-9b27-79bff114db90' ParentLink='Module_PortType' LowerBound='22.1' HigherBound='29.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Error_msg_type' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7f960419-e2bf-4643-898c-ca8d776104e8' ParentLink='PortType_OperationDeclaration' LowerBound='24.1' HigherBound='28.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='b7fc608f-9f9f-4cc5-a523-64eec374077c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='26.13' HigherBound='26.26'>
                    <om:Property Name='Ref' Value='System.String' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='b82951e6-ee0b-44a3-9a34-85eff8208527' ParentLink='Module_PortType' LowerBound='29.1' HigherBound='36.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='7aa4289b-ef99-4502-b975-96d0303f5231' ParentLink='PortType_OperationDeclaration' LowerBound='31.1' HigherBound='35.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='76be6894-19bb-45f4-8380-5fbb6ed9ca2d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='33.13' HigherBound='33.26'>
                    <om:Property Name='Ref' Value='seq.Purchase_info' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='5cff1382-b121-4148-80fd-8ae0ab7e4870' ParentLink='Module_CorrelationType' LowerBound='36.1' HigherBound='40.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PropertyRef' OID='6d946b95-abcc-4a6b-bdd2-315292c4a5b3' ParentLink='CorrelationType_PropertyRef' LowerBound='38.9' HigherBound='38.28'>
                <om:Property Name='Ref' Value='seq.PropertySchema.PoNo' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='c75a948e-8475-452a-a64a-289764c3db8c' ParentLink='Module_ServiceDeclaration' LowerBound='40.1' HigherBound='90.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalk_Orchestration1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='CorrelationDeclaration' OID='3cd20df6-37d1-41bb-80f6-57a6b35c6c5e' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='Type' Value='seq.CorrelationType_1' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_1' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='9574b993-bdee-4c5f-bce1-b9cf3cd91405' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='59.60' HigherBound='59.84'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='f166f44f-a0af-4300-a771-a05c78415ba8' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='64.61' HigherBound='64.74'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='3f8ff365-7d52-48f5-bb98-ff347b0bd199' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='aa49fa25-b301-4f10-9a13-4cb484a6af0d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='Type' Value='seq.Customer_info' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CI_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='183d8247-1cb0-4104-81b9-4e22ab985095' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='Type' Value='seq.Purchase_info' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PI_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ab062f45-892a-41bd-bd9d-29a2bb7e4601' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Error_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ed006013-47ec-49ec-8a1f-1f2c21a0d3c2' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='seq.Output_schema' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Output_msg' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='02ac0e0c-c5f6-402f-8d72-0fcbbea57da5' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453' ParentLink='ServiceBody_Statement' LowerBound='58.1' HigherBound='60.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Rcv_messages' />
                    <om:Property Name='MessageName' Value='CI_msg' />
                    <om:Property Name='OperationName' Value='CI_msg' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Listen' OID='9f1b0604-4f82-4f66-9f9f-88e93a86506c' ParentLink='ServiceBody_Statement' LowerBound='60.1' HigherBound='88.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Listen_1' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='ListenBranch' OID='49e5c5d4-1c23-4f98-b9e6-b8c99e936a99' ParentLink='ReallyComplexStatement_Branch' LowerBound='60.1' HigherBound='60.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ListenBranch_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Receive' OID='3f8ff365-7d52-48f5-bb98-ff347b0bd199' ParentLink='ListenBranch_Statement' LowerBound='63.1' HigherBound='64.75'>
                            <om:Property Name='Activate' Value='False' />
                            <om:Property Name='PortName' Value='Rcv_messages' />
                            <om:Property Name='MessageName' Value='PI_msg' />
                            <om:Property Name='OperationName' Value='PI_msg' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Receive_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='ed1d9706-1571-4665-aaa4-a7c134b85d6d' ParentLink='ComplexStatement_Statement' LowerBound='66.1' HigherBound='72.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Transform' OID='5e4ec1e8-57fd-4fed-8adc-f6a946e75445' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='71.1'>
                                <om:Property Name='ClassName' Value='seq.Transform_1' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_1' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='50a5e4d9-7a23-4af7-9442-8e28a8a9d94e' ParentLink='Transform_InputMessagePartRef' LowerBound='70.67' HigherBound='70.73'>
                                    <om:Property Name='MessageRef' Value='CI_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='7866acdc-e059-4b55-a7d4-d05100df5142' ParentLink='Transform_InputMessagePartRef' LowerBound='70.75' HigherBound='70.81'>
                                    <om:Property Name='MessageRef' Value='PI_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_2' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='3de576cc-8d40-4ddd-b52e-991bc1b8bb2a' ParentLink='Transform_OutputMessagePartRef' LowerBound='70.36' HigherBound='70.46'>
                                    <om:Property Name='MessageRef' Value='Output_msg' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='8241d7c2-55e5-448d-bb74-26fc70e3ed2b' ParentLink='Construct_MessageRef' LowerBound='67.31' HigherBound='67.41'>
                                <om:Property Name='Ref' Value='Output_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='b8d585da-b677-47d4-90c1-01d7f35772b3' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='74.1'>
                            <om:Property Name='PortName' Value='OutPut' />
                            <om:Property Name='MessageName' Value='Output_msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='ListenBranch' OID='4d7a35e1-6cdf-4dad-a0e7-7b0e04eaa7b7' ParentLink='ReallyComplexStatement_Branch' LowerBound='60.1' HigherBound='60.1'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ListenBranch_2' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='6eef6492-2483-46ba-ab02-b9f6fcb7b093' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='84.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='ffb0536e-b8a0-49b9-bc9c-b79054524b12' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='83.1'>
                                <om:Property Name='Expression' Value='Error_msg = &quot;Purchase_info didn&apos;t receive in time&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='44a5418f-d7a7-4b20-b586-8ba9e7556b51' ParentLink='Construct_MessageRef' LowerBound='79.31' HigherBound='79.40'>
                                <om:Property Name='Ref' Value='Error_msg' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='5347e674-f9ad-45b3-b615-281690d90e18' ParentLink='ComplexStatement_Statement' LowerBound='84.1' HigherBound='86.1'>
                            <om:Property Name='PortName' Value='Error_output' />
                            <om:Property Name='MessageName' Value='Error_msg' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Delay' OID='0c1ea116-a79e-419f-b8b3-3afd22d6c9c0' ParentLink='ListenBranch_Statement' LowerBound='75.1' HigherBound='76.52'>
                            <om:Property Name='Timeout' Value='new System.TimeSpan(0,0,30)' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Delay_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5d34f463-c412-4476-b5a9-9a60a6560c56' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='43.1' HigherBound='46.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='True' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='seq.rcv_message_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Rcv_messages' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='c3213f1b-b149-4a32-b01a-445197b15fb1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='43.1' HigherBound='44.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='66ac2b37-d8ad-40cb-8c0c-709b2f62c0b2' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='46.1' HigherBound='49.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='Transmitted' />
                <om:Property Name='Type' Value='seq.Output_msg_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='OutPut' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='885ea686-da7e-44ef-87f9-f3579ced8110' ParentLink='PortDeclaration_CLRAttribute' LowerBound='46.1' HigherBound='47.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='0e676f4e-5428-46c2-a277-ea71e245c2c6' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='seq.Error_msg_type' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Error_output' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='963a63d7-d34b-4231-9247-8e24997b25ca' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
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

                if (__svc__.Error_output != null)
                {
                    __svc__.Error_output.Close(this, null);
                    __svc__.Error_output = null;
                }
                if (__svc__.OutPut != null)
                {
                    __svc__.OutPut.Close(this, null);
                    __svc__.OutPut = null;
                }
                if (__svc__.Rcv_messages != null)
                {
                    __svc__.Rcv_messages.Close(this, null);
                    __svc__.Rcv_messages = null;
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

                if (__ctx1__ != null && __ctx1__.__Output_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Output_msg);
                    __ctx1__.__Output_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Error_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Error_msg);
                    __ctx1__.__Error_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__PI_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PI_msg);
                    __ctx1__.__PI_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__CI_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CI_msg);
                    __ctx1__.__CI_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("CI_msg")]
            public __messagetype_seq_Customer_info __CI_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("PI_msg")]
            public __messagetype_seq_Purchase_info __PI_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Error_msg")]
            public __messagetype_System_String __Error_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Output_msg")]
            public __messagetype_seq_Output_schema __Output_msg;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_1")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_1;
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
        [Microsoft.XLANGs.BaseTypes.OrderedDeliveryAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Rcv_messages")]
        internal rcv_message_type Rcv_messages;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute(Microsoft.XLANGs.BaseTypes.DeliveryNotificationAttribute.NotificationLevel.Transmitted)]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("OutPut")]
        internal Output_msg_type OutPut;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Error_output")]
        internal Error_msg_type Error_output;
        System.Guid __timeout0__;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {rcv_message_type.CI_msg, rcv_message_type.PI_msg},
                                               typeof(BizTalk_Orchestration1).GetField("Rcv_messages", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Rcv_messages"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Output_msg_type.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("OutPut", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "OutPut"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Error_msg_type.Operation_1},
                                               typeof(BizTalk_Orchestration1).GetField("Error_output", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalk_Orchestration1), "Error_output"),
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
                return new object[2]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[0], 1, null , 0, false }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "60ab9bcc-2351-4f3e-b6c4-4f3b7cca4453", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "9f1b0604-4f82-4f66-9f9f-88e93a86506c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "3f8ff365-7d52-48f5-bb98-ff347b0bd199", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "3f8ff365-7d52-48f5-bb98-ff347b0bd199", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "ed1d9706-1571-4665-aaa4-a7c134b85d6d", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "ed1d9706-1571-4665-aaa4-a7c134b85d6d", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "b8d585da-b677-47d4-90c1-01d7f35772b3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "b8d585da-b677-47d4-90c1-01d7f35772b3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "0c1ea116-a79e-419f-b8b3-3afd22d6c9c0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "0c1ea116-a79e-419f-b8b3-3afd22d6c9c0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "6eef6492-2483-46ba-ab02-b9f6fcb7b093", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "6eef6492-2483-46ba-ab02-b9f6fcb7b093", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "5347e674-f9ad-45b3-b615-281690d90e18", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "5347e674-f9ad-45b3-b615-281690d90e18", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "9f1b0604-4f82-4f66-9f9f-88e93a86506c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,17,17,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,6,6,7,8,8,8,9,3,10,11,12,12,13,14,14,14,15,3,3,16,17,17,17,17,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Rcv_messages = new rcv_message_type(0, this);
                OutPut = new Output_msg_type(1, this);
                Error_output = new Error_msg_type(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Rcv_messages, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], Rcv_messages, this);
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
            __BizTalk_Orchestration1_1 __ctx1__ = (__BizTalk_Orchestration1_1)_stateMgrs[1];
            __BizTalk_Orchestration1_root_0 __ctx0__ = (__BizTalk_Orchestration1_root_0)_stateMgrs[0];

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
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.__Correlation_1 = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Rcv_messages.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__CI_msg != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CI_msg);
                __ctx1__.__CI_msg = new __messagetype_seq_Customer_info("CI_msg", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CI_msg);
                Rcv_messages.ReceiveMessage(0, __msgEnv__, __ctx1__.__CI_msg, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_1 }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CI_msg);
                    __edata.PortName = @"Rcv_messages";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __timeout0__ = __ctx1__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, 0, 30)));
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout0__ ), __ctx0__.__subWrapper1.getSubscription(this) }, __seg__, __ctx1__, out __msgEnv__ , _locations[0]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 18;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__PI_msg != null)
                            __ctx1__.UnrefMessage(__ctx1__.__PI_msg);
                        __ctx1__.__PI_msg = new __messagetype_seq_Purchase_info("PI_msg", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__PI_msg);
                        Rcv_messages.ReceiveMessage(1, __msgEnv__, __ctx1__.__PI_msg, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 8;
                    }
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_1 != null)
                    __ctx1__.__Correlation_1 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__PI_msg);
                    __edata.PortName = @"Rcv_messages";
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                {
                    __messagetype_seq_Output_schema __Output_msg = new __messagetype_seq_Output_schema("Output_msg", __ctx1__);

                    ApplyTransform(typeof(seq.Transform_1), new object[] {__Output_msg.part}, new object[] {__ctx1__.__CI_msg.part, __ctx1__.__PI_msg.part});

                    if (__ctx1__.__Output_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Output_msg);
                    __ctx1__.__Output_msg = __Output_msg;
                    __ctx1__.RefMessage(__ctx1__.__Output_msg);
                }
                __ctx1__.__Output_msg.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Output_msg);
                    __edata.Messages.Add(__ctx1__.__CI_msg);
                    __edata.Messages.Add(__ctx1__.__PI_msg);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                OutPut.SendMessage(0, __ctx1__.__Output_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Output_msg);
                    __edata.PortName = @"OutPut";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Output_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Output_msg);
                    __ctx1__.__Output_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    __messagetype_System_String __Error_msg = new __messagetype_System_String("Error_msg", __ctx1__);

                    __Error_msg.part.LoadFrom("Purchase_info didn't receive in time");

                    if (__ctx1__.__Error_msg != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Error_msg);
                    __ctx1__.__Error_msg = __Error_msg;
                    __ctx1__.RefMessage(__ctx1__.__Error_msg);
                }
                __ctx1__.__Error_msg.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Error_msg);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Error_output.SendMessage(0, __ctx1__.__Error_msg, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Error_msg);
                    __edata.PortName = @"Error_output";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Error_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Error_msg);
                    __ctx1__.__Error_msg = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if (__ctx1__ != null && __ctx1__.__PI_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__PI_msg);
                    __ctx1__.__PI_msg = null;
                }
                if (__ctx1__ != null && __ctx1__.__CI_msg != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CI_msg);
                    __ctx1__.__CI_msg = null;
                }
                if (Error_output != null)
                {
                    Error_output.Close(__ctx1__, __seg__);
                    Error_output = null;
                }
                if (OutPut != null)
                {
                    OutPut.Close(__ctx1__, __seg__);
                    OutPut = null;
                }
                if (Rcv_messages != null)
                {
                    Rcv_messages.Close(__ctx1__, __seg__);
                    Rcv_messages = null;
                }
                DeleteTimeout(LookupSubscription(__timeout0__));
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[7],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[8],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 33;
            case 33:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{2EFA8A99-61DC-436B-B7A0-9BDFBA6284F5}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __seq_Customer_info__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static seq.Customer_info _schema = new seq.Customer_info();

        public __seq_Customer_info__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "seq.Customer_info",
        new System.Type[]{
            typeof(seq.Customer_info)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__seq_Customer_info__)
        },
        0,
        @"http://seq.Customer_info#Customer_Details"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_seq_Customer_info : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __seq_Customer_info__ part;

        private void __CreatePartWrappers()
        {
            part = new __seq_Customer_info__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_seq_Customer_info(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __seq_Purchase_info__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static seq.Purchase_info _schema = new seq.Purchase_info();

        public __seq_Purchase_info__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "seq.Purchase_info",
        new System.Type[]{
            typeof(seq.Purchase_info)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__seq_Purchase_info__)
        },
        0,
        @"http://seq.Purchase_info#Purchase_Details"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_seq_Purchase_info : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __seq_Purchase_info__ part;

        private void __CreatePartWrappers()
        {
            part = new __seq_Purchase_info__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_seq_Purchase_info(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __seq_Output_schema__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static seq.Output_schema _schema = new seq.Output_schema();

        public __seq_Output_schema__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "seq.Output_schema",
        new System.Type[]{
            typeof(seq.Output_schema)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__seq_Output_schema__)
        },
        0,
        @"http://seq.Output_schema#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_seq_Output_schema : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __seq_Output_schema__ part;

        private void __CreatePartWrappers()
        {
            part = new __seq_Output_schema__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_seq_Output_schema(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
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
