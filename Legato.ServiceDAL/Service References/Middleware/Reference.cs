namespace Legato.ServiceDAL.Middleware {
    
    
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContract(ConfigurationName="Middleware.ILegatoMiddleware")]
    public interface ILegatoMiddleware
    {
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitarResponse")]
        bool AddAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task<bool> AddAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitarResponse")]
        bool EditAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task<bool> EditAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitarResponse")]
        bool RemoveAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task<bool> RemoveAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        string[] GetAcousticClassicalGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        int GetAcousticClassicalGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitarResponse")]
        bool AddAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task<bool> AddAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitarResponse")]
        bool EditAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task<bool> EditAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitarResponse")]
        bool RemoveAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task<bool> RemoveAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        string[] GetAcousticWesternGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        int GetAcousticWesternGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddElectricGuitarResponse")]
        bool AddElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddElectricGuitarResponse")]
        System.Threading.Tasks.Task<bool> AddElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditElectricGuitarResponse")]
        bool EditElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditElectricGuitarResponse")]
        System.Threading.Tasks.Task<bool> EditElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitarResponse")]
        bool RemoveElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitarResponse")]
        System.Threading.Tasks.Task<bool> RemoveElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        string[] GetElectricGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        int GetElectricGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddBassGuitarResponse")]
        bool AddBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/AddBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddBassGuitarResponse")]
        System.Threading.Tasks.Task<bool> AddBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditBassGuitarResponse")]
        bool EditBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/EditBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditBassGuitarResponse")]
        System.Threading.Tasks.Task<bool> EditBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitarResponse")]
        bool RemoveBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitarResponse")]
        System.Threading.Tasks.Task<bool> RemoveBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        string[] GetBassGuitarVendors();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        int GetBassGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ILegatoMiddlewareChannel : ServiceDAL.Middleware.ILegatoMiddleware, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [System.CodeDom.Compiler.GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class LegatoMiddlewareClient : System.ServiceModel.ClientBase<ServiceDAL.Middleware.ILegatoMiddleware>, ServiceDAL.Middleware.ILegatoMiddleware {
        
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
        
        public bool AddAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.AddAcousticClassicalGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> AddAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.AddAcousticClassicalGuitarAsync(guitar);
        }
        
        public bool EditAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.EditAcousticClassicalGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> EditAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.EditAcousticClassicalGuitarAsync(guitar);
        }
        
        public bool RemoveAcousticClassicalGuitar(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.RemoveAcousticClassicalGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveAcousticClassicalGuitarAsync(MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.RemoveAcousticClassicalGuitarAsync(guitar);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticClassicalGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetAcousticClassicalGuitarVendors() {
            return base.Channel.GetAcousticClassicalGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync() {
            return base.Channel.GetAcousticClassicalGuitarVendorsAsync();
        }
        
        public int GetAcousticClassicalGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticClassicalGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticClassicalGuitarQuantityAsync(filter);
        }
        
        public bool AddAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.AddAcousticWesternGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> AddAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.AddAcousticWesternGuitarAsync(guitar);
        }
        
        public bool EditAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.EditAcousticWesternGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> EditAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.EditAcousticWesternGuitarAsync(guitar);
        }
        
        public bool RemoveAcousticWesternGuitar(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.RemoveAcousticWesternGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveAcousticWesternGuitarAsync(MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.RemoveAcousticWesternGuitarAsync(guitar);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticWesternGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticWesternGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticWesternGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetAcousticWesternGuitarVendors() {
            return base.Channel.GetAcousticWesternGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync() {
            return base.Channel.GetAcousticWesternGuitarVendorsAsync();
        }
        
        public int GetAcousticWesternGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticWesternGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticWesternGuitarQuantityAsync(filter);
        }
        
        public bool AddElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.AddElectricGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> AddElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.AddElectricGuitarAsync(guitar);
        }
        
        public bool EditElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.EditElectricGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> EditElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.EditElectricGuitarAsync(guitar);
        }
        
        public bool RemoveElectricGuitar(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.RemoveElectricGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveElectricGuitarAsync(MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.RemoveElectricGuitarAsync(guitar);
        }
        
        public MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetElectricGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetElectricGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedElectricGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedElectricGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetElectricGuitarVendors() {
            return base.Channel.GetElectricGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync() {
            return base.Channel.GetElectricGuitarVendorsAsync();
        }
        
        public int GetElectricGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetElectricGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetElectricGuitarQuantityAsync(filter);
        }
        
        public bool AddBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.AddBassGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> AddBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.AddBassGuitarAsync(guitar);
        }
        
        public bool EditBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.EditBassGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> EditBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.EditBassGuitarAsync(guitar);
        }
        
        public bool RemoveBassGuitar(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.RemoveBassGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveBassGuitarAsync(MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.RemoveBassGuitarAsync(guitar);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetBassGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetBassGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedBassGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedBassGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetBassGuitarVendors() {
            return base.Channel.GetBassGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync() {
            return base.Channel.GetBassGuitarVendorsAsync();
        }
        
        public int GetBassGuitarQuantity(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetBassGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetBassGuitarQuantityAsync(filter);
        }
    }
}
