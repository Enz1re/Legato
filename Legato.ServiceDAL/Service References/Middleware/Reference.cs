namespace Legato.ServiceDAL.Middleware {
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContract(ConfigurationName="Middleware.ILegatoMiddleware")]
    public interface ILegatoMiddleware {
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        string[] GetAcousticClassicalGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        int GetAcousticClassicalGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        string[] GetAcousticWesternGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        int GetAcousticWesternGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        string[] GetElectricGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        int GetElectricGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        string[] GetBassGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        int GetBassGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ILegatoMiddlewareChannel : ILegatoMiddleware, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class LegatoMiddlewareClient : System.ServiceModel.ClientBase<ILegatoMiddleware>, ILegatoMiddleware {
        
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
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public string[] GetAcousticClassicalGuitarVendors() {
            return Channel.GetAcousticClassicalGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync() {
            return Channel.GetAcousticClassicalGuitarVendorsAsync();
        }
        
        public int GetAcousticClassicalGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetAcousticClassicalGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetAcousticClassicalGuitarQuantityAsync(filter);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedAcousticClassicalGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetAcousticWesternGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public string[] GetAcousticWesternGuitarVendors() {
            return Channel.GetAcousticWesternGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync() {
            return Channel.GetAcousticWesternGuitarVendorsAsync();
        }
        
        public int GetAcousticWesternGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetAcousticWesternGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetAcousticWesternGuitarQuantityAsync(filter);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedAcousticWesternGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedAcousticWesternGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetElectricGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetElectricGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public string[] GetElectricGuitarVendors() {
            return Channel.GetElectricGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync() {
            return Channel.GetElectricGuitarVendorsAsync();
        }
        
        public int GetElectricGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetElectricGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetElectricGuitarQuantityAsync(filter);
        }
        
        public MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedElectricGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedElectricGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetBassGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return Channel.GetBassGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public string[] GetBassGuitarVendors() {
            return Channel.GetBassGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync() {
            return Channel.GetBassGuitarVendorsAsync();
        }
        
        public int GetBassGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetBassGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return Channel.GetBassGuitarQuantityAsync(filter);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedBassGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return Channel.GetSortedBassGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
    }
}
