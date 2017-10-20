namespace Legato.ServiceDAL.LegatoMiddleware {
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContract(ConfigurationName=".LegatoMiddleware.ILegatoMiddleware")]
    public interface ILegatoMiddleware {
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllGuitarsResponse")]
        MiddlewareContracts.DataContracts.GuitarDataModel[] GetAllGuitars();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllGuitarsResponse")]
        System.IAsyncResult BeginGetAllGuitars(System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetAllGuitars(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllVendorsResponse")]
        string[] GetAllVendors();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllVendorsResponse")]
        System.IAsyncResult BeginGetAllVendors(System.AsyncCallback callback, object asyncState);
        
        string[] EndGetAllVendors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPriceResponse")]
        MiddlewareContracts.DataContracts.GuitarDataModel[] GetGuitarsByPrice(short from, short to);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPriceResponse")]
        System.IAsyncResult BeginGetGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetGuitarsByPrice(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendorResponse")]
        MiddlewareContracts.DataContracts.GuitarDataModel[] GetGuitarsByVendor(string vendor);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendorResponse")]
        System.IAsyncResult BeginGetGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetGuitarsByVendor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAllAcousticClassicalGuitars();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitarsResponse")]
        System.IAsyncResult BeginGetAllAcousticClassicalGuitars(System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAllAcousticClassicalGuitars(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        string[] GetAcousticClassicalGuitarVendors();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        System.IAsyncResult BeginGetAcousticClassicalGuitarVendors(System.AsyncCallback callback, object asyncState);
        
        string[] EndGetAcousticClassicalGuitarVendors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPriceResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByPrice(short from, short to);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPriceResponse")]
        System.IAsyncResult BeginGetAcousticClassicalGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAcousticClassicalGuitarsByPrice(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendorResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByVendor(string vendor);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendorResponse")]
        System.IAsyncResult BeginGetAcousticClassicalGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAcousticClassicalGuitarsByVendor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAllAcousticWesternGuitars();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitarsResponse")]
        System.IAsyncResult BeginGetAllAcousticWesternGuitars(System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAllAcousticWesternGuitars(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        string[] GetAcousticWesternGuitarVendors();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        System.IAsyncResult BeginGetAcousticWesternGuitarVendors(System.AsyncCallback callback, object asyncState);
        
        string[] EndGetAcousticWesternGuitarVendors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPriceResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByPrice(short from, short to);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPriceResponse")]
        System.IAsyncResult BeginGetAcousticWesternGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAcousticWesternGuitarsByPrice(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendorResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByVendor(string vendor);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendorResponse")]
        System.IAsyncResult BeginGetAcousticWesternGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAcousticWesternGuitarsByVendor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllElectroGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllElectroGuitarsResponse")]
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetAllElectroGuitars();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllElectroGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllElectroGuitarsResponse")]
        System.IAsyncResult BeginGetAllElectroGuitars(System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetAllElectroGuitars(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        string[] GetElectricGuitarVendors();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        System.IAsyncResult BeginGetElectricGuitarVendors(System.AsyncCallback callback, object asyncState);
        
        string[] EndGetElectricGuitarVendors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByPriceResponse")]
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetElectroGuitarsByPrice(short from, short to);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByPriceResponse")]
        System.IAsyncResult BeginGetElectroGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetElectroGuitarsByPrice(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByVendorResponse")]
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetElectroGuitarsByVendor(string vendor);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectroGuitarsByVendorResponse")]
        System.IAsyncResult BeginGetElectroGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetElectroGuitarsByVendor(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitarsResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetAllBassGuitars();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitarsResponse")]
        System.IAsyncResult BeginGetAllBassGuitars(System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetAllBassGuitars(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        string[] GetBassGuitarVendors();
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        System.IAsyncResult BeginGetBassGuitarVendors(System.AsyncCallback callback, object asyncState);
        
        string[] EndGetBassGuitarVendors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPriceResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitarsByPrice(short from, short to);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPriceResponse")]
        System.IAsyncResult BeginGetBassGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetBassGuitarsByPrice(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendorResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitarsByVendor(string vendor);
        
        [System.ServiceModel.OperationContract(AsyncPattern=true, Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendorResponse")]
        System.IAsyncResult BeginGetBassGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState);
        
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetBassGuitarsByVendor(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ILegatoMiddlewareChannel : Legato.ServiceDAL.LegatoMiddleware.ILegatoMiddleware, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllGuitarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllGuitarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.GuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllVendorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllVendorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetGuitarsByPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetGuitarsByPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.GuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetGuitarsByVendorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetGuitarsByVendorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.GuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllAcousticClassicalGuitarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllAcousticClassicalGuitarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticClassicalGuitarVendorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticClassicalGuitarVendorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticClassicalGuitarsByPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticClassicalGuitarsByPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticClassicalGuitarsByVendorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticClassicalGuitarsByVendorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllAcousticWesternGuitarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllAcousticWesternGuitarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticWesternGuitarVendorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticWesternGuitarVendorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticWesternGuitarsByPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticWesternGuitarsByPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAcousticWesternGuitarsByVendorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAcousticWesternGuitarsByVendorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllElectroGuitarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllElectroGuitarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.ElectroGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetElectricGuitarVendorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetElectricGuitarVendorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetElectroGuitarsByPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetElectroGuitarsByPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.ElectroGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetElectroGuitarsByVendorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetElectroGuitarsByVendorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.ElectroGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllBassGuitarsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllBassGuitarsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.BassGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetBassGuitarVendorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBassGuitarVendorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetBassGuitarsByPriceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBassGuitarsByPriceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.BassGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class GetBassGuitarsByVendorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetBassGuitarsByVendorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((MiddlewareContracts.DataContracts.BassGuitarDataModel[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class LegatoMiddlewareClient : System.ServiceModel.ClientBase<Legato.ServiceDAL.LegatoMiddleware.ILegatoMiddleware>, Legato.ServiceDAL.LegatoMiddleware.ILegatoMiddleware {
        
        private BeginOperationDelegate onBeginGetAllGuitarsDelegate;
        
        private EndOperationDelegate onEndGetAllGuitarsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllGuitarsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllVendorsDelegate;
        
        private EndOperationDelegate onEndGetAllVendorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllVendorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetGuitarsByPriceDelegate;
        
        private EndOperationDelegate onEndGetGuitarsByPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetGuitarsByPriceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetGuitarsByVendorDelegate;
        
        private EndOperationDelegate onEndGetGuitarsByVendorDelegate;
        
        private System.Threading.SendOrPostCallback onGetGuitarsByVendorCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllAcousticClassicalGuitarsDelegate;
        
        private EndOperationDelegate onEndGetAllAcousticClassicalGuitarsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllAcousticClassicalGuitarsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticClassicalGuitarVendorsDelegate;
        
        private EndOperationDelegate onEndGetAcousticClassicalGuitarVendorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticClassicalGuitarVendorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticClassicalGuitarsByPriceDelegate;
        
        private EndOperationDelegate onEndGetAcousticClassicalGuitarsByPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticClassicalGuitarsByPriceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticClassicalGuitarsByVendorDelegate;
        
        private EndOperationDelegate onEndGetAcousticClassicalGuitarsByVendorDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticClassicalGuitarsByVendorCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllAcousticWesternGuitarsDelegate;
        
        private EndOperationDelegate onEndGetAllAcousticWesternGuitarsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllAcousticWesternGuitarsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticWesternGuitarVendorsDelegate;
        
        private EndOperationDelegate onEndGetAcousticWesternGuitarVendorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticWesternGuitarVendorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticWesternGuitarsByPriceDelegate;
        
        private EndOperationDelegate onEndGetAcousticWesternGuitarsByPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticWesternGuitarsByPriceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAcousticWesternGuitarsByVendorDelegate;
        
        private EndOperationDelegate onEndGetAcousticWesternGuitarsByVendorDelegate;
        
        private System.Threading.SendOrPostCallback onGetAcousticWesternGuitarsByVendorCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllElectroGuitarsDelegate;
        
        private EndOperationDelegate onEndGetAllElectroGuitarsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllElectroGuitarsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetElectricGuitarVendorsDelegate;
        
        private EndOperationDelegate onEndGetElectricGuitarVendorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetElectricGuitarVendorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetElectroGuitarsByPriceDelegate;
        
        private EndOperationDelegate onEndGetElectroGuitarsByPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetElectroGuitarsByPriceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetElectroGuitarsByVendorDelegate;
        
        private EndOperationDelegate onEndGetElectroGuitarsByVendorDelegate;
        
        private System.Threading.SendOrPostCallback onGetElectroGuitarsByVendorCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllBassGuitarsDelegate;
        
        private EndOperationDelegate onEndGetAllBassGuitarsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllBassGuitarsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetBassGuitarVendorsDelegate;
        
        private EndOperationDelegate onEndGetBassGuitarVendorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetBassGuitarVendorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetBassGuitarsByPriceDelegate;
        
        private EndOperationDelegate onEndGetBassGuitarsByPriceDelegate;
        
        private System.Threading.SendOrPostCallback onGetBassGuitarsByPriceCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetBassGuitarsByVendorDelegate;
        
        private EndOperationDelegate onEndGetBassGuitarsByVendorDelegate;
        
        private System.Threading.SendOrPostCallback onGetBassGuitarsByVendorCompletedDelegate;
        
        public LegatoMiddlewareClient() {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LegatoMiddlewareClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAllGuitarsCompletedEventArgs> GetAllGuitarsCompleted;
        
        public event System.EventHandler<GetAllVendorsCompletedEventArgs> GetAllVendorsCompleted;
        
        public event System.EventHandler<GetGuitarsByPriceCompletedEventArgs> GetGuitarsByPriceCompleted;
        
        public event System.EventHandler<GetGuitarsByVendorCompletedEventArgs> GetGuitarsByVendorCompleted;
        
        public event System.EventHandler<GetAllAcousticClassicalGuitarsCompletedEventArgs> GetAllAcousticClassicalGuitarsCompleted;
        
        public event System.EventHandler<GetAcousticClassicalGuitarVendorsCompletedEventArgs> GetAcousticClassicalGuitarVendorsCompleted;
        
        public event System.EventHandler<GetAcousticClassicalGuitarsByPriceCompletedEventArgs> GetAcousticClassicalGuitarsByPriceCompleted;
        
        public event System.EventHandler<GetAcousticClassicalGuitarsByVendorCompletedEventArgs> GetAcousticClassicalGuitarsByVendorCompleted;
        
        public event System.EventHandler<GetAllAcousticWesternGuitarsCompletedEventArgs> GetAllAcousticWesternGuitarsCompleted;
        
        public event System.EventHandler<GetAcousticWesternGuitarVendorsCompletedEventArgs> GetAcousticWesternGuitarVendorsCompleted;
        
        public event System.EventHandler<GetAcousticWesternGuitarsByPriceCompletedEventArgs> GetAcousticWesternGuitarsByPriceCompleted;
        
        public event System.EventHandler<GetAcousticWesternGuitarsByVendorCompletedEventArgs> GetAcousticWesternGuitarsByVendorCompleted;
        
        public event System.EventHandler<GetAllElectroGuitarsCompletedEventArgs> GetAllElectroGuitarsCompleted;
        
        public event System.EventHandler<GetElectricGuitarVendorsCompletedEventArgs> GetElectricGuitarVendorsCompleted;
        
        public event System.EventHandler<GetElectroGuitarsByPriceCompletedEventArgs> GetElectroGuitarsByPriceCompleted;
        
        public event System.EventHandler<GetElectroGuitarsByVendorCompletedEventArgs> GetElectroGuitarsByVendorCompleted;
        
        public event System.EventHandler<GetAllBassGuitarsCompletedEventArgs> GetAllBassGuitarsCompleted;
        
        public event System.EventHandler<GetBassGuitarVendorsCompletedEventArgs> GetBassGuitarVendorsCompleted;
        
        public event System.EventHandler<GetBassGuitarsByPriceCompletedEventArgs> GetBassGuitarsByPriceCompleted;
        
        public event System.EventHandler<GetBassGuitarsByVendorCompletedEventArgs> GetBassGuitarsByVendorCompleted;
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] GetAllGuitars() {
            return base.Channel.GetAllGuitars();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllGuitars(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllGuitars(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetAllGuitars(System.IAsyncResult result) {
            return base.Channel.EndGetAllGuitars(result);
        }
        
        private System.IAsyncResult OnBeginGetAllGuitars(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllGuitars(callback, asyncState);
        }
        
        private object[] OnEndGetAllGuitars(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.GuitarDataModel[] retVal = this.EndGetAllGuitars(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllGuitarsCompleted(object state) {
            if ((this.GetAllGuitarsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllGuitarsCompleted(this, new GetAllGuitarsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllGuitarsAsync() {
            this.GetAllGuitarsAsync(null);
        }
        
        public void GetAllGuitarsAsync(object userState) {
            if ((this.onBeginGetAllGuitarsDelegate == null)) {
                this.onBeginGetAllGuitarsDelegate = new BeginOperationDelegate(this.OnBeginGetAllGuitars);
            }
            if ((this.onEndGetAllGuitarsDelegate == null)) {
                this.onEndGetAllGuitarsDelegate = new EndOperationDelegate(this.OnEndGetAllGuitars);
            }
            if ((this.onGetAllGuitarsCompletedDelegate == null)) {
                this.onGetAllGuitarsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllGuitarsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllGuitarsDelegate, null, this.onEndGetAllGuitarsDelegate, this.onGetAllGuitarsCompletedDelegate, userState);
        }
        
        public string[] GetAllVendors() {
            return base.Channel.GetAllVendors();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllVendors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllVendors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndGetAllVendors(System.IAsyncResult result) {
            return base.Channel.EndGetAllVendors(result);
        }
        
        private System.IAsyncResult OnBeginGetAllVendors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllVendors(callback, asyncState);
        }
        
        private object[] OnEndGetAllVendors(System.IAsyncResult result) {
            string[] retVal = this.EndGetAllVendors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllVendorsCompleted(object state) {
            if ((this.GetAllVendorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllVendorsCompleted(this, new GetAllVendorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllVendorsAsync() {
            this.GetAllVendorsAsync(null);
        }
        
        public void GetAllVendorsAsync(object userState) {
            if ((this.onBeginGetAllVendorsDelegate == null)) {
                this.onBeginGetAllVendorsDelegate = new BeginOperationDelegate(this.OnBeginGetAllVendors);
            }
            if ((this.onEndGetAllVendorsDelegate == null)) {
                this.onEndGetAllVendorsDelegate = new EndOperationDelegate(this.OnEndGetAllVendors);
            }
            if ((this.onGetAllVendorsCompletedDelegate == null)) {
                this.onGetAllVendorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllVendorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllVendorsDelegate, null, this.onEndGetAllVendorsDelegate, this.onGetAllVendorsCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] GetGuitarsByPrice(short from, short to) {
            return base.Channel.GetGuitarsByPrice(from, to);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetGuitarsByPrice(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetGuitarsByPrice(System.IAsyncResult result) {
            return base.Channel.EndGetGuitarsByPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetGuitarsByPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            short from = ((short)(inValues[0]));
            short to = ((short)(inValues[1]));
            return this.BeginGetGuitarsByPrice(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetGuitarsByPrice(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.GuitarDataModel[] retVal = this.EndGetGuitarsByPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetGuitarsByPriceCompleted(object state) {
            if ((this.GetGuitarsByPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetGuitarsByPriceCompleted(this, new GetGuitarsByPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetGuitarsByPriceAsync(short from, short to) {
            this.GetGuitarsByPriceAsync(from, to, null);
        }
        
        public void GetGuitarsByPriceAsync(short from, short to, object userState) {
            if ((this.onBeginGetGuitarsByPriceDelegate == null)) {
                this.onBeginGetGuitarsByPriceDelegate = new BeginOperationDelegate(this.OnBeginGetGuitarsByPrice);
            }
            if ((this.onEndGetGuitarsByPriceDelegate == null)) {
                this.onEndGetGuitarsByPriceDelegate = new EndOperationDelegate(this.OnEndGetGuitarsByPrice);
            }
            if ((this.onGetGuitarsByPriceCompletedDelegate == null)) {
                this.onGetGuitarsByPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetGuitarsByPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetGuitarsByPriceDelegate, new object[] {
                        from,
                        to}, this.onEndGetGuitarsByPriceDelegate, this.onGetGuitarsByPriceCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.GuitarDataModel[] GetGuitarsByVendor(string vendor) {
            return base.Channel.GetGuitarsByVendor(vendor);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetGuitarsByVendor(vendor, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.GuitarDataModel[] EndGetGuitarsByVendor(System.IAsyncResult result) {
            return base.Channel.EndGetGuitarsByVendor(result);
        }
        
        private System.IAsyncResult OnBeginGetGuitarsByVendor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string vendor = ((string)(inValues[0]));
            return this.BeginGetGuitarsByVendor(vendor, callback, asyncState);
        }
        
        private object[] OnEndGetGuitarsByVendor(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.GuitarDataModel[] retVal = this.EndGetGuitarsByVendor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetGuitarsByVendorCompleted(object state) {
            if ((this.GetGuitarsByVendorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetGuitarsByVendorCompleted(this, new GetGuitarsByVendorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetGuitarsByVendorAsync(string vendor) {
            this.GetGuitarsByVendorAsync(vendor, null);
        }
        
        public void GetGuitarsByVendorAsync(string vendor, object userState) {
            if ((this.onBeginGetGuitarsByVendorDelegate == null)) {
                this.onBeginGetGuitarsByVendorDelegate = new BeginOperationDelegate(this.OnBeginGetGuitarsByVendor);
            }
            if ((this.onEndGetGuitarsByVendorDelegate == null)) {
                this.onEndGetGuitarsByVendorDelegate = new EndOperationDelegate(this.OnEndGetGuitarsByVendor);
            }
            if ((this.onGetGuitarsByVendorCompletedDelegate == null)) {
                this.onGetGuitarsByVendorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetGuitarsByVendorCompleted);
            }
            base.InvokeAsync(this.onBeginGetGuitarsByVendorDelegate, new object[] {
                        vendor}, this.onEndGetGuitarsByVendorDelegate, this.onGetGuitarsByVendorCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAllAcousticClassicalGuitars() {
            return base.Channel.GetAllAcousticClassicalGuitars();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllAcousticClassicalGuitars(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllAcousticClassicalGuitars(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAllAcousticClassicalGuitars(System.IAsyncResult result) {
            return base.Channel.EndGetAllAcousticClassicalGuitars(result);
        }
        
        private System.IAsyncResult OnBeginGetAllAcousticClassicalGuitars(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllAcousticClassicalGuitars(callback, asyncState);
        }
        
        private object[] OnEndGetAllAcousticClassicalGuitars(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] retVal = this.EndGetAllAcousticClassicalGuitars(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllAcousticClassicalGuitarsCompleted(object state) {
            if ((this.GetAllAcousticClassicalGuitarsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllAcousticClassicalGuitarsCompleted(this, new GetAllAcousticClassicalGuitarsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllAcousticClassicalGuitarsAsync() {
            this.GetAllAcousticClassicalGuitarsAsync(null);
        }
        
        public void GetAllAcousticClassicalGuitarsAsync(object userState) {
            if ((this.onBeginGetAllAcousticClassicalGuitarsDelegate == null)) {
                this.onBeginGetAllAcousticClassicalGuitarsDelegate = new BeginOperationDelegate(this.OnBeginGetAllAcousticClassicalGuitars);
            }
            if ((this.onEndGetAllAcousticClassicalGuitarsDelegate == null)) {
                this.onEndGetAllAcousticClassicalGuitarsDelegate = new EndOperationDelegate(this.OnEndGetAllAcousticClassicalGuitars);
            }
            if ((this.onGetAllAcousticClassicalGuitarsCompletedDelegate == null)) {
                this.onGetAllAcousticClassicalGuitarsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllAcousticClassicalGuitarsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllAcousticClassicalGuitarsDelegate, null, this.onEndGetAllAcousticClassicalGuitarsDelegate, this.onGetAllAcousticClassicalGuitarsCompletedDelegate, userState);
        }
        
        public string[] GetAcousticClassicalGuitarVendors() {
            return base.Channel.GetAcousticClassicalGuitarVendors();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticClassicalGuitarVendors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticClassicalGuitarVendors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndGetAcousticClassicalGuitarVendors(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticClassicalGuitarVendors(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticClassicalGuitarVendors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAcousticClassicalGuitarVendors(callback, asyncState);
        }
        
        private object[] OnEndGetAcousticClassicalGuitarVendors(System.IAsyncResult result) {
            string[] retVal = this.EndGetAcousticClassicalGuitarVendors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticClassicalGuitarVendorsCompleted(object state) {
            if ((this.GetAcousticClassicalGuitarVendorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticClassicalGuitarVendorsCompleted(this, new GetAcousticClassicalGuitarVendorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticClassicalGuitarVendorsAsync() {
            this.GetAcousticClassicalGuitarVendorsAsync(null);
        }
        
        public void GetAcousticClassicalGuitarVendorsAsync(object userState) {
            if ((this.onBeginGetAcousticClassicalGuitarVendorsDelegate == null)) {
                this.onBeginGetAcousticClassicalGuitarVendorsDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticClassicalGuitarVendors);
            }
            if ((this.onEndGetAcousticClassicalGuitarVendorsDelegate == null)) {
                this.onEndGetAcousticClassicalGuitarVendorsDelegate = new EndOperationDelegate(this.OnEndGetAcousticClassicalGuitarVendors);
            }
            if ((this.onGetAcousticClassicalGuitarVendorsCompletedDelegate == null)) {
                this.onGetAcousticClassicalGuitarVendorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticClassicalGuitarVendorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticClassicalGuitarVendorsDelegate, null, this.onEndGetAcousticClassicalGuitarVendorsDelegate, this.onGetAcousticClassicalGuitarVendorsCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByPrice(short from, short to) {
            return base.Channel.GetAcousticClassicalGuitarsByPrice(from, to);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticClassicalGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticClassicalGuitarsByPrice(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAcousticClassicalGuitarsByPrice(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticClassicalGuitarsByPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticClassicalGuitarsByPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            short from = ((short)(inValues[0]));
            short to = ((short)(inValues[1]));
            return this.BeginGetAcousticClassicalGuitarsByPrice(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetAcousticClassicalGuitarsByPrice(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] retVal = this.EndGetAcousticClassicalGuitarsByPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticClassicalGuitarsByPriceCompleted(object state) {
            if ((this.GetAcousticClassicalGuitarsByPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticClassicalGuitarsByPriceCompleted(this, new GetAcousticClassicalGuitarsByPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticClassicalGuitarsByPriceAsync(short from, short to) {
            this.GetAcousticClassicalGuitarsByPriceAsync(from, to, null);
        }
        
        public void GetAcousticClassicalGuitarsByPriceAsync(short from, short to, object userState) {
            if ((this.onBeginGetAcousticClassicalGuitarsByPriceDelegate == null)) {
                this.onBeginGetAcousticClassicalGuitarsByPriceDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticClassicalGuitarsByPrice);
            }
            if ((this.onEndGetAcousticClassicalGuitarsByPriceDelegate == null)) {
                this.onEndGetAcousticClassicalGuitarsByPriceDelegate = new EndOperationDelegate(this.OnEndGetAcousticClassicalGuitarsByPrice);
            }
            if ((this.onGetAcousticClassicalGuitarsByPriceCompletedDelegate == null)) {
                this.onGetAcousticClassicalGuitarsByPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticClassicalGuitarsByPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticClassicalGuitarsByPriceDelegate, new object[] {
                        from,
                        to}, this.onEndGetAcousticClassicalGuitarsByPriceDelegate, this.onGetAcousticClassicalGuitarsByPriceCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByVendor(string vendor) {
            return base.Channel.GetAcousticClassicalGuitarsByVendor(vendor);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticClassicalGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticClassicalGuitarsByVendor(vendor, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] EndGetAcousticClassicalGuitarsByVendor(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticClassicalGuitarsByVendor(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticClassicalGuitarsByVendor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string vendor = ((string)(inValues[0]));
            return this.BeginGetAcousticClassicalGuitarsByVendor(vendor, callback, asyncState);
        }
        
        private object[] OnEndGetAcousticClassicalGuitarsByVendor(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] retVal = this.EndGetAcousticClassicalGuitarsByVendor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticClassicalGuitarsByVendorCompleted(object state) {
            if ((this.GetAcousticClassicalGuitarsByVendorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticClassicalGuitarsByVendorCompleted(this, new GetAcousticClassicalGuitarsByVendorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticClassicalGuitarsByVendorAsync(string vendor) {
            this.GetAcousticClassicalGuitarsByVendorAsync(vendor, null);
        }
        
        public void GetAcousticClassicalGuitarsByVendorAsync(string vendor, object userState) {
            if ((this.onBeginGetAcousticClassicalGuitarsByVendorDelegate == null)) {
                this.onBeginGetAcousticClassicalGuitarsByVendorDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticClassicalGuitarsByVendor);
            }
            if ((this.onEndGetAcousticClassicalGuitarsByVendorDelegate == null)) {
                this.onEndGetAcousticClassicalGuitarsByVendorDelegate = new EndOperationDelegate(this.OnEndGetAcousticClassicalGuitarsByVendor);
            }
            if ((this.onGetAcousticClassicalGuitarsByVendorCompletedDelegate == null)) {
                this.onGetAcousticClassicalGuitarsByVendorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticClassicalGuitarsByVendorCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticClassicalGuitarsByVendorDelegate, new object[] {
                        vendor}, this.onEndGetAcousticClassicalGuitarsByVendorDelegate, this.onGetAcousticClassicalGuitarsByVendorCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAllAcousticWesternGuitars() {
            return base.Channel.GetAllAcousticWesternGuitars();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllAcousticWesternGuitars(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllAcousticWesternGuitars(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAllAcousticWesternGuitars(System.IAsyncResult result) {
            return base.Channel.EndGetAllAcousticWesternGuitars(result);
        }
        
        private System.IAsyncResult OnBeginGetAllAcousticWesternGuitars(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllAcousticWesternGuitars(callback, asyncState);
        }
        
        private object[] OnEndGetAllAcousticWesternGuitars(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] retVal = this.EndGetAllAcousticWesternGuitars(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllAcousticWesternGuitarsCompleted(object state) {
            if ((this.GetAllAcousticWesternGuitarsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllAcousticWesternGuitarsCompleted(this, new GetAllAcousticWesternGuitarsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllAcousticWesternGuitarsAsync() {
            this.GetAllAcousticWesternGuitarsAsync(null);
        }
        
        public void GetAllAcousticWesternGuitarsAsync(object userState) {
            if ((this.onBeginGetAllAcousticWesternGuitarsDelegate == null)) {
                this.onBeginGetAllAcousticWesternGuitarsDelegate = new BeginOperationDelegate(this.OnBeginGetAllAcousticWesternGuitars);
            }
            if ((this.onEndGetAllAcousticWesternGuitarsDelegate == null)) {
                this.onEndGetAllAcousticWesternGuitarsDelegate = new EndOperationDelegate(this.OnEndGetAllAcousticWesternGuitars);
            }
            if ((this.onGetAllAcousticWesternGuitarsCompletedDelegate == null)) {
                this.onGetAllAcousticWesternGuitarsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllAcousticWesternGuitarsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllAcousticWesternGuitarsDelegate, null, this.onEndGetAllAcousticWesternGuitarsDelegate, this.onGetAllAcousticWesternGuitarsCompletedDelegate, userState);
        }
        
        public string[] GetAcousticWesternGuitarVendors() {
            return base.Channel.GetAcousticWesternGuitarVendors();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticWesternGuitarVendors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticWesternGuitarVendors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndGetAcousticWesternGuitarVendors(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticWesternGuitarVendors(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticWesternGuitarVendors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAcousticWesternGuitarVendors(callback, asyncState);
        }
        
        private object[] OnEndGetAcousticWesternGuitarVendors(System.IAsyncResult result) {
            string[] retVal = this.EndGetAcousticWesternGuitarVendors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticWesternGuitarVendorsCompleted(object state) {
            if ((this.GetAcousticWesternGuitarVendorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticWesternGuitarVendorsCompleted(this, new GetAcousticWesternGuitarVendorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticWesternGuitarVendorsAsync() {
            this.GetAcousticWesternGuitarVendorsAsync(null);
        }
        
        public void GetAcousticWesternGuitarVendorsAsync(object userState) {
            if ((this.onBeginGetAcousticWesternGuitarVendorsDelegate == null)) {
                this.onBeginGetAcousticWesternGuitarVendorsDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticWesternGuitarVendors);
            }
            if ((this.onEndGetAcousticWesternGuitarVendorsDelegate == null)) {
                this.onEndGetAcousticWesternGuitarVendorsDelegate = new EndOperationDelegate(this.OnEndGetAcousticWesternGuitarVendors);
            }
            if ((this.onGetAcousticWesternGuitarVendorsCompletedDelegate == null)) {
                this.onGetAcousticWesternGuitarVendorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticWesternGuitarVendorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticWesternGuitarVendorsDelegate, null, this.onEndGetAcousticWesternGuitarVendorsDelegate, this.onGetAcousticWesternGuitarVendorsCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByPrice(short from, short to) {
            return base.Channel.GetAcousticWesternGuitarsByPrice(from, to);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticWesternGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticWesternGuitarsByPrice(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAcousticWesternGuitarsByPrice(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticWesternGuitarsByPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticWesternGuitarsByPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            short from = ((short)(inValues[0]));
            short to = ((short)(inValues[1]));
            return this.BeginGetAcousticWesternGuitarsByPrice(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetAcousticWesternGuitarsByPrice(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] retVal = this.EndGetAcousticWesternGuitarsByPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticWesternGuitarsByPriceCompleted(object state) {
            if ((this.GetAcousticWesternGuitarsByPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticWesternGuitarsByPriceCompleted(this, new GetAcousticWesternGuitarsByPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticWesternGuitarsByPriceAsync(short from, short to) {
            this.GetAcousticWesternGuitarsByPriceAsync(from, to, null);
        }
        
        public void GetAcousticWesternGuitarsByPriceAsync(short from, short to, object userState) {
            if ((this.onBeginGetAcousticWesternGuitarsByPriceDelegate == null)) {
                this.onBeginGetAcousticWesternGuitarsByPriceDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticWesternGuitarsByPrice);
            }
            if ((this.onEndGetAcousticWesternGuitarsByPriceDelegate == null)) {
                this.onEndGetAcousticWesternGuitarsByPriceDelegate = new EndOperationDelegate(this.OnEndGetAcousticWesternGuitarsByPrice);
            }
            if ((this.onGetAcousticWesternGuitarsByPriceCompletedDelegate == null)) {
                this.onGetAcousticWesternGuitarsByPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticWesternGuitarsByPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticWesternGuitarsByPriceDelegate, new object[] {
                        from,
                        to}, this.onEndGetAcousticWesternGuitarsByPriceDelegate, this.onGetAcousticWesternGuitarsByPriceCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByVendor(string vendor) {
            return base.Channel.GetAcousticWesternGuitarsByVendor(vendor);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAcousticWesternGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAcousticWesternGuitarsByVendor(vendor, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] EndGetAcousticWesternGuitarsByVendor(System.IAsyncResult result) {
            return base.Channel.EndGetAcousticWesternGuitarsByVendor(result);
        }
        
        private System.IAsyncResult OnBeginGetAcousticWesternGuitarsByVendor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string vendor = ((string)(inValues[0]));
            return this.BeginGetAcousticWesternGuitarsByVendor(vendor, callback, asyncState);
        }
        
        private object[] OnEndGetAcousticWesternGuitarsByVendor(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] retVal = this.EndGetAcousticWesternGuitarsByVendor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAcousticWesternGuitarsByVendorCompleted(object state) {
            if ((this.GetAcousticWesternGuitarsByVendorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAcousticWesternGuitarsByVendorCompleted(this, new GetAcousticWesternGuitarsByVendorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAcousticWesternGuitarsByVendorAsync(string vendor) {
            this.GetAcousticWesternGuitarsByVendorAsync(vendor, null);
        }
        
        public void GetAcousticWesternGuitarsByVendorAsync(string vendor, object userState) {
            if ((this.onBeginGetAcousticWesternGuitarsByVendorDelegate == null)) {
                this.onBeginGetAcousticWesternGuitarsByVendorDelegate = new BeginOperationDelegate(this.OnBeginGetAcousticWesternGuitarsByVendor);
            }
            if ((this.onEndGetAcousticWesternGuitarsByVendorDelegate == null)) {
                this.onEndGetAcousticWesternGuitarsByVendorDelegate = new EndOperationDelegate(this.OnEndGetAcousticWesternGuitarsByVendor);
            }
            if ((this.onGetAcousticWesternGuitarsByVendorCompletedDelegate == null)) {
                this.onGetAcousticWesternGuitarsByVendorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAcousticWesternGuitarsByVendorCompleted);
            }
            base.InvokeAsync(this.onBeginGetAcousticWesternGuitarsByVendorDelegate, new object[] {
                        vendor}, this.onEndGetAcousticWesternGuitarsByVendorDelegate, this.onGetAcousticWesternGuitarsByVendorCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetAllElectroGuitars() {
            return base.Channel.GetAllElectroGuitars();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllElectroGuitars(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllElectroGuitars(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetAllElectroGuitars(System.IAsyncResult result) {
            return base.Channel.EndGetAllElectroGuitars(result);
        }
        
        private System.IAsyncResult OnBeginGetAllElectroGuitars(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllElectroGuitars(callback, asyncState);
        }
        
        private object[] OnEndGetAllElectroGuitars(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] retVal = this.EndGetAllElectroGuitars(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllElectroGuitarsCompleted(object state) {
            if ((this.GetAllElectroGuitarsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllElectroGuitarsCompleted(this, new GetAllElectroGuitarsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllElectroGuitarsAsync() {
            this.GetAllElectroGuitarsAsync(null);
        }
        
        public void GetAllElectroGuitarsAsync(object userState) {
            if ((this.onBeginGetAllElectroGuitarsDelegate == null)) {
                this.onBeginGetAllElectroGuitarsDelegate = new BeginOperationDelegate(this.OnBeginGetAllElectroGuitars);
            }
            if ((this.onEndGetAllElectroGuitarsDelegate == null)) {
                this.onEndGetAllElectroGuitarsDelegate = new EndOperationDelegate(this.OnEndGetAllElectroGuitars);
            }
            if ((this.onGetAllElectroGuitarsCompletedDelegate == null)) {
                this.onGetAllElectroGuitarsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllElectroGuitarsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllElectroGuitarsDelegate, null, this.onEndGetAllElectroGuitarsDelegate, this.onGetAllElectroGuitarsCompletedDelegate, userState);
        }
        
        public string[] GetElectricGuitarVendors() {
            return base.Channel.GetElectricGuitarVendors();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetElectricGuitarVendors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetElectricGuitarVendors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndGetElectricGuitarVendors(System.IAsyncResult result) {
            return base.Channel.EndGetElectricGuitarVendors(result);
        }
        
        private System.IAsyncResult OnBeginGetElectricGuitarVendors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetElectricGuitarVendors(callback, asyncState);
        }
        
        private object[] OnEndGetElectricGuitarVendors(System.IAsyncResult result) {
            string[] retVal = this.EndGetElectricGuitarVendors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetElectricGuitarVendorsCompleted(object state) {
            if ((this.GetElectricGuitarVendorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetElectricGuitarVendorsCompleted(this, new GetElectricGuitarVendorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetElectricGuitarVendorsAsync() {
            this.GetElectricGuitarVendorsAsync(null);
        }
        
        public void GetElectricGuitarVendorsAsync(object userState) {
            if ((this.onBeginGetElectricGuitarVendorsDelegate == null)) {
                this.onBeginGetElectricGuitarVendorsDelegate = new BeginOperationDelegate(this.OnBeginGetElectricGuitarVendors);
            }
            if ((this.onEndGetElectricGuitarVendorsDelegate == null)) {
                this.onEndGetElectricGuitarVendorsDelegate = new EndOperationDelegate(this.OnEndGetElectricGuitarVendors);
            }
            if ((this.onGetElectricGuitarVendorsCompletedDelegate == null)) {
                this.onGetElectricGuitarVendorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetElectricGuitarVendorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetElectricGuitarVendorsDelegate, null, this.onEndGetElectricGuitarVendorsDelegate, this.onGetElectricGuitarVendorsCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetElectroGuitarsByPrice(short from, short to) {
            return base.Channel.GetElectroGuitarsByPrice(from, to);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetElectroGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetElectroGuitarsByPrice(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetElectroGuitarsByPrice(System.IAsyncResult result) {
            return base.Channel.EndGetElectroGuitarsByPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetElectroGuitarsByPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            short from = ((short)(inValues[0]));
            short to = ((short)(inValues[1]));
            return this.BeginGetElectroGuitarsByPrice(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetElectroGuitarsByPrice(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] retVal = this.EndGetElectroGuitarsByPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetElectroGuitarsByPriceCompleted(object state) {
            if ((this.GetElectroGuitarsByPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetElectroGuitarsByPriceCompleted(this, new GetElectroGuitarsByPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetElectroGuitarsByPriceAsync(short from, short to) {
            this.GetElectroGuitarsByPriceAsync(from, to, null);
        }
        
        public void GetElectroGuitarsByPriceAsync(short from, short to, object userState) {
            if ((this.onBeginGetElectroGuitarsByPriceDelegate == null)) {
                this.onBeginGetElectroGuitarsByPriceDelegate = new BeginOperationDelegate(this.OnBeginGetElectroGuitarsByPrice);
            }
            if ((this.onEndGetElectroGuitarsByPriceDelegate == null)) {
                this.onEndGetElectroGuitarsByPriceDelegate = new EndOperationDelegate(this.OnEndGetElectroGuitarsByPrice);
            }
            if ((this.onGetElectroGuitarsByPriceCompletedDelegate == null)) {
                this.onGetElectroGuitarsByPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetElectroGuitarsByPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetElectroGuitarsByPriceDelegate, new object[] {
                        from,
                        to}, this.onEndGetElectroGuitarsByPriceDelegate, this.onGetElectroGuitarsByPriceCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] GetElectroGuitarsByVendor(string vendor) {
            return base.Channel.GetElectroGuitarsByVendor(vendor);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetElectroGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetElectroGuitarsByVendor(vendor, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] EndGetElectroGuitarsByVendor(System.IAsyncResult result) {
            return base.Channel.EndGetElectroGuitarsByVendor(result);
        }
        
        private System.IAsyncResult OnBeginGetElectroGuitarsByVendor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string vendor = ((string)(inValues[0]));
            return this.BeginGetElectroGuitarsByVendor(vendor, callback, asyncState);
        }
        
        private object[] OnEndGetElectroGuitarsByVendor(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.ElectroGuitarDataModel[] retVal = this.EndGetElectroGuitarsByVendor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetElectroGuitarsByVendorCompleted(object state) {
            if ((this.GetElectroGuitarsByVendorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetElectroGuitarsByVendorCompleted(this, new GetElectroGuitarsByVendorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetElectroGuitarsByVendorAsync(string vendor) {
            this.GetElectroGuitarsByVendorAsync(vendor, null);
        }
        
        public void GetElectroGuitarsByVendorAsync(string vendor, object userState) {
            if ((this.onBeginGetElectroGuitarsByVendorDelegate == null)) {
                this.onBeginGetElectroGuitarsByVendorDelegate = new BeginOperationDelegate(this.OnBeginGetElectroGuitarsByVendor);
            }
            if ((this.onEndGetElectroGuitarsByVendorDelegate == null)) {
                this.onEndGetElectroGuitarsByVendorDelegate = new EndOperationDelegate(this.OnEndGetElectroGuitarsByVendor);
            }
            if ((this.onGetElectroGuitarsByVendorCompletedDelegate == null)) {
                this.onGetElectroGuitarsByVendorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetElectroGuitarsByVendorCompleted);
            }
            base.InvokeAsync(this.onBeginGetElectroGuitarsByVendorDelegate, new object[] {
                        vendor}, this.onEndGetElectroGuitarsByVendorDelegate, this.onGetElectroGuitarsByVendorCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetAllBassGuitars() {
            return base.Channel.GetAllBassGuitars();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllBassGuitars(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllBassGuitars(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetAllBassGuitars(System.IAsyncResult result) {
            return base.Channel.EndGetAllBassGuitars(result);
        }
        
        private System.IAsyncResult OnBeginGetAllBassGuitars(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllBassGuitars(callback, asyncState);
        }
        
        private object[] OnEndGetAllBassGuitars(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.BassGuitarDataModel[] retVal = this.EndGetAllBassGuitars(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllBassGuitarsCompleted(object state) {
            if ((this.GetAllBassGuitarsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllBassGuitarsCompleted(this, new GetAllBassGuitarsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllBassGuitarsAsync() {
            this.GetAllBassGuitarsAsync(null);
        }
        
        public void GetAllBassGuitarsAsync(object userState) {
            if ((this.onBeginGetAllBassGuitarsDelegate == null)) {
                this.onBeginGetAllBassGuitarsDelegate = new BeginOperationDelegate(this.OnBeginGetAllBassGuitars);
            }
            if ((this.onEndGetAllBassGuitarsDelegate == null)) {
                this.onEndGetAllBassGuitarsDelegate = new EndOperationDelegate(this.OnEndGetAllBassGuitars);
            }
            if ((this.onGetAllBassGuitarsCompletedDelegate == null)) {
                this.onGetAllBassGuitarsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllBassGuitarsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllBassGuitarsDelegate, null, this.onEndGetAllBassGuitarsDelegate, this.onGetAllBassGuitarsCompletedDelegate, userState);
        }
        
        public string[] GetBassGuitarVendors() {
            return base.Channel.GetBassGuitarVendors();
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetBassGuitarVendors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBassGuitarVendors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string[] EndGetBassGuitarVendors(System.IAsyncResult result) {
            return base.Channel.EndGetBassGuitarVendors(result);
        }
        
        private System.IAsyncResult OnBeginGetBassGuitarVendors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetBassGuitarVendors(callback, asyncState);
        }
        
        private object[] OnEndGetBassGuitarVendors(System.IAsyncResult result) {
            string[] retVal = this.EndGetBassGuitarVendors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBassGuitarVendorsCompleted(object state) {
            if ((this.GetBassGuitarVendorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBassGuitarVendorsCompleted(this, new GetBassGuitarVendorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBassGuitarVendorsAsync() {
            this.GetBassGuitarVendorsAsync(null);
        }
        
        public void GetBassGuitarVendorsAsync(object userState) {
            if ((this.onBeginGetBassGuitarVendorsDelegate == null)) {
                this.onBeginGetBassGuitarVendorsDelegate = new BeginOperationDelegate(this.OnBeginGetBassGuitarVendors);
            }
            if ((this.onEndGetBassGuitarVendorsDelegate == null)) {
                this.onEndGetBassGuitarVendorsDelegate = new EndOperationDelegate(this.OnEndGetBassGuitarVendors);
            }
            if ((this.onGetBassGuitarVendorsCompletedDelegate == null)) {
                this.onGetBassGuitarVendorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBassGuitarVendorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetBassGuitarVendorsDelegate, null, this.onEndGetBassGuitarVendorsDelegate, this.onGetBassGuitarVendorsCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitarsByPrice(short from, short to) {
            return base.Channel.GetBassGuitarsByPrice(from, to);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetBassGuitarsByPrice(short from, short to, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBassGuitarsByPrice(from, to, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetBassGuitarsByPrice(System.IAsyncResult result) {
            return base.Channel.EndGetBassGuitarsByPrice(result);
        }
        
        private System.IAsyncResult OnBeginGetBassGuitarsByPrice(object[] inValues, System.AsyncCallback callback, object asyncState) {
            short from = ((short)(inValues[0]));
            short to = ((short)(inValues[1]));
            return this.BeginGetBassGuitarsByPrice(from, to, callback, asyncState);
        }
        
        private object[] OnEndGetBassGuitarsByPrice(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.BassGuitarDataModel[] retVal = this.EndGetBassGuitarsByPrice(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBassGuitarsByPriceCompleted(object state) {
            if ((this.GetBassGuitarsByPriceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBassGuitarsByPriceCompleted(this, new GetBassGuitarsByPriceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBassGuitarsByPriceAsync(short from, short to) {
            this.GetBassGuitarsByPriceAsync(from, to, null);
        }
        
        public void GetBassGuitarsByPriceAsync(short from, short to, object userState) {
            if ((this.onBeginGetBassGuitarsByPriceDelegate == null)) {
                this.onBeginGetBassGuitarsByPriceDelegate = new BeginOperationDelegate(this.OnBeginGetBassGuitarsByPrice);
            }
            if ((this.onEndGetBassGuitarsByPriceDelegate == null)) {
                this.onEndGetBassGuitarsByPriceDelegate = new EndOperationDelegate(this.OnEndGetBassGuitarsByPrice);
            }
            if ((this.onGetBassGuitarsByPriceCompletedDelegate == null)) {
                this.onGetBassGuitarsByPriceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBassGuitarsByPriceCompleted);
            }
            base.InvokeAsync(this.onBeginGetBassGuitarsByPriceDelegate, new object[] {
                        from,
                        to}, this.onEndGetBassGuitarsByPriceDelegate, this.onGetBassGuitarsByPriceCompletedDelegate, userState);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitarsByVendor(string vendor) {
            return base.Channel.GetBassGuitarsByVendor(vendor);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetBassGuitarsByVendor(string vendor, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetBassGuitarsByVendor(vendor, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] EndGetBassGuitarsByVendor(System.IAsyncResult result) {
            return base.Channel.EndGetBassGuitarsByVendor(result);
        }
        
        private System.IAsyncResult OnBeginGetBassGuitarsByVendor(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string vendor = ((string)(inValues[0]));
            return this.BeginGetBassGuitarsByVendor(vendor, callback, asyncState);
        }
        
        private object[] OnEndGetBassGuitarsByVendor(System.IAsyncResult result) {
            MiddlewareContracts.DataContracts.BassGuitarDataModel[] retVal = this.EndGetBassGuitarsByVendor(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetBassGuitarsByVendorCompleted(object state) {
            if ((this.GetBassGuitarsByVendorCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetBassGuitarsByVendorCompleted(this, new GetBassGuitarsByVendorCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetBassGuitarsByVendorAsync(string vendor) {
            this.GetBassGuitarsByVendorAsync(vendor, null);
        }
        
        public void GetBassGuitarsByVendorAsync(string vendor, object userState) {
            if ((this.onBeginGetBassGuitarsByVendorDelegate == null)) {
                this.onBeginGetBassGuitarsByVendorDelegate = new BeginOperationDelegate(this.OnBeginGetBassGuitarsByVendor);
            }
            if ((this.onEndGetBassGuitarsByVendorDelegate == null)) {
                this.onEndGetBassGuitarsByVendorDelegate = new EndOperationDelegate(this.OnEndGetBassGuitarsByVendor);
            }
            if ((this.onGetBassGuitarsByVendorCompletedDelegate == null)) {
                this.onGetBassGuitarsByVendorCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetBassGuitarsByVendorCompleted);
            }
            base.InvokeAsync(this.onBeginGetBassGuitarsByVendorDelegate, new object[] {
                        vendor}, this.onEndGetBassGuitarsByVendorDelegate, this.onGetBassGuitarsByVendorCompletedDelegate, userState);
        }
    }
}
