
#pragma warning disable 162

namespace Temp_Sql
{

    [System.SerializableAttribute]
    sealed public class __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDelete__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete _schema = new Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete();

        public __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDelete__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDelete__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#MasterInsertUpdateDelete"
    )]
    [System.SerializableAttribute]
    sealed internal class TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDelete__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDelete__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDeleteResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDeleteResponse _schema = new Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDeleteResponse();

        public __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDeleteResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eNone,
        "",
        new System.Type[]{
            typeof(Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDeleteResponse)
        },
        new string[]{
            "parameters"
        },
        new System.Type[]{
            typeof(__Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDeleteResponse__)
        },
        0,
        @"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo#MasterInsertUpdateDeleteResponse"
    )]
    [System.SerializableAttribute]
    sealed internal class TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDeleteResponse__ parameters;

        private void __CreatePartWrappers()
        {
            parameters = new __Temp_Sql_sqlBinding_dbo_MasterInsertUpdateDeleteResponse__(this, "parameters", 0);
            this.AddPart("parameters", 0, parameters);
        }

        public TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "MasterInsertUpdateDelete",
        new System.Type[]{
            typeof(Temp_Sql.TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage), 
            typeof(Temp_Sql.TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class TypedProcedures_dbo : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public TypedProcedures_dbo(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public TypedProcedures_dbo(TypedProcedures_dbo p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            TypedProcedures_dbo p = new TypedProcedures_dbo(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo MasterInsertUpdateDelete = new Microsoft.XLANGs.Core.OperationInfo
        (
            "MasterInsertUpdateDelete",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(TypedProcedures_dbo),
            typeof(TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage),
            typeof(TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "MasterInsertUpdateDelete" ] = MasterInsertUpdateDelete;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 101 "C:\AMP\Flat File\Diff_FF\Temp_Sql\BizTalk Orchestration.odx"
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
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eCallable|Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eExecable
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Orchestration_1 : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = true;
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Orchestration_1));
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

        static Orchestration_1()
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
            _rootContext = new __Orchestration_1_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Orchestration_1(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Orchestration_1", tracker)
        {
            ConstructorHelper();
        }

        public Orchestration_1(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Orchestration_1")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>8fb0644e-ebcf-46b9-97f4-347e9ceeb5e2</ShapeID>      
<children>                </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Orchestration_1'</ActionName><IsAtomic>0</IsAtomic><Line>101</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='de0e3fce-a0fe-41d6-be2d-6eaf0df2549b'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Temp_Sql' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='691b40d7-01f2-42b6-8242-080b858a0c63' ParentLink='Module_PortType'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata port type: ' />
            <om:Property Name='Name' Value='TypedProcedures_dbo' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='58d87f0b-0b86-4cfe-b9fb-0f5d5bb015b4' ParentLink='PortType_OperationDeclaration'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata operation: ' />
                <om:Property Name='Name' Value='MasterInsertUpdateDelete' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='5acf3e4a-1cc9-4e4a-8d23-22c096911cdc' ParentLink='OperationDeclaration_RequestMessageRef'>
                    <om:Property Name='Ref' Value='Temp_Sql.TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='adb2ce78-5f6f-44de-92de-7919e05b713c' ParentLink='OperationDeclaration_ResponseMessageRef'>
                    <om:Property Name='Ref' Value='Temp_Sql.TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='AnalystComments' Value='Adapter metadata operation message: ' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='d8276187-5aad-4c70-b1dd-fe11743c1b7a' ParentLink='Module_MessageType'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='TypedProcedures_dbo_MasterInsertUpdateDelete_InputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='982eb649-0ccd-4d92-913a-0c4fa8da262f' ParentLink='MultipartMessageType_PartDeclaration'>
                <om:Property Name='ClassName' Value='Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDelete' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='MultipartMessageType' OID='ce643687-2809-4b91-b99e-14b19c8e2107' ParentLink='Module_MessageType'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='AnalystComments' Value='Adapter metadata message type: ' />
            <om:Property Name='Name' Value='TypedProcedures_dbo_MasterInsertUpdateDelete_OutputMessage' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='PartDeclaration' OID='aaac0e21-a2a8-42ae-a6ca-e6d4edee05fc' ParentLink='MultipartMessageType_PartDeclaration'>
                <om:Property Name='ClassName' Value='Temp_Sql.sqlBinding_dbo.MasterInsertUpdateDeleteResponse' />
                <om:Property Name='IsBodyPart' Value='True' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='AnalystComments' Value='Adapter metadata message part: ' />
                <om:Property Name='Name' Value='parameters' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='243280d1-6452-42c3-805b-e44820c294b2' ParentLink='Module_ServiceDeclaration'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration_1' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='8fb0644e-ebcf-46b9-97f4-347e9ceeb5e2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Orchestration_1_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Orchestration_1_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration_1")
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
                Orchestration_1 __svc__ = (Orchestration_1)_service;
                base.Finally();
            }

        }


        [System.SerializableAttribute]
        public class __Orchestration_1_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Orchestration_1_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration_1")
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
                Orchestration_1 __svc__ = (Orchestration_1)_service;
                base.Finally();
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


        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] { };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return null; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
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
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,1,1,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,1,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Orchestration_1_root_0 __ctx0__ = (__Orchestration_1_root_0)_stateMgrs[0];
            __Orchestration_1_1 __ctx1__ = (__Orchestration_1_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Orchestration_1_1(this);
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
            __Orchestration_1_root_0 __ctx0__ = (__Orchestration_1_root_0)_stateMgrs[0];
            __Orchestration_1_1 __ctx1__ = (__Orchestration_1_1)_stateMgrs[1];

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
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 5;
            case 5:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
