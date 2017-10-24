namespace Legato.ServiceDAL.Middleware
{
    using System.ServiceModel;
    using System.Threading.Tasks;
    using System.CodeDom.Compiler;
    using System.ServiceModel.Channels;
    using MiddlewareContracts.DataContracts;

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName="Middleware.ILegatoMiddleware")]
    public interface ILegatoMiddleware
    {
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllGuitarsResponse")]
        GuitarDataModel[] GetAllGuitars();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllGuitarsResponse")]
        Task<GuitarDataModel[]> GetAllGuitarsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllVendorsResponse")]
        string[] GetAllVendors();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllVendorsResponse")]
        Task<string[]> GetAllVendorsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPriceResponse")]
        GuitarDataModel[] GetGuitarsByPrice(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByPriceResponse")]
        Task<GuitarDataModel[]> GetGuitarsByPriceAsync(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendorResponse")]
        GuitarDataModel[] GetGuitarsByVendor(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetGuitarsByVendorResponse")]
        Task<GuitarDataModel[]> GetGuitarsByVendorAsync(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitarsResponse")]
        AcousticClassicalGuitarDataModel[] GetAllAcousticClassicalGuitars();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticClassicalGuitarsResponse")]
        Task<AcousticClassicalGuitarDataModel[]> GetAllAcousticClassicalGuitarsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        string[] GetAcousticClassicalGuitarVendors();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        Task<string[]> GetAcousticClassicalGuitarVendorsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPriceResponse")]
        AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByPrice(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByPriceResponse")]
        Task<AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsByPriceAsync(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendorResponse")]
        AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByVendor(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsByVendorResponse")]
        Task<AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsByVendorAsync(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitarsResponse")]
        AcousticWesternGuitarDataModel[] GetAllAcousticWesternGuitars();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllAcousticWesternGuitarsResponse")]
        Task<AcousticWesternGuitarDataModel[]> GetAllAcousticWesternGuitarsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        string[] GetAcousticWesternGuitarVendors();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        Task<string[]> GetAcousticWesternGuitarVendorsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPriceResponse")]
        AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByPrice(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByPriceResponse")]
        Task<AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsByPriceAsync(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendorResponse")]
        AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByVendor(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsByVendorResponse")]
        Task<AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsByVendorAsync(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllElectricGuitarsResponse")]
        ElectricGuitarDataModel[] GetAllElectricGuitars();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllElectricGuitarsResponse")]
        Task<ElectricGuitarDataModel[]> GetAllElectricGuitarsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        string[] GetElectricGuitarVendors();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        Task<string[]> GetElectricGuitarVendorsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByPriceResponse")]
        ElectricGuitarDataModel[] GetElectricGuitarsByPrice(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByPriceResponse")]
        Task<ElectricGuitarDataModel[]> GetElectricGuitarsByPriceAsync(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByVendorResponse")]
        ElectricGuitarDataModel[] GetElectricGuitarsByVendor(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsByVendorResponse")]
        Task<ElectricGuitarDataModel[]> GetElectricGuitarsByVendorAsync(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitarsResponse")]
        BassGuitarDataModel[] GetAllBassGuitars();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAllBassGuitarsResponse")]
        Task<BassGuitarDataModel[]> GetAllBassGuitarsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        string[] GetBassGuitarVendors();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        Task<string[]> GetBassGuitarVendorsAsync();
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPriceResponse")]
        BassGuitarDataModel[] GetBassGuitarsByPrice(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPrice", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByPriceResponse")]
        Task<BassGuitarDataModel[]> GetBassGuitarsByPriceAsync(short from, short to);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendorResponse")]
        BassGuitarDataModel[] GetBassGuitarsByVendor(string vendor);
        
        [OperationContract(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendor", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsByVendorResponse")]
        Task<BassGuitarDataModel[]> GetBassGuitarsByVendorAsync(string vendor);
    }
    
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ILegatoMiddlewareChannel : ILegatoMiddleware, IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThrough()]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class LegatoMiddlewareClient : ClientBase<ILegatoMiddleware>, ILegatoMiddleware
    {
        public LegatoMiddlewareClient()
        {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public LegatoMiddlewareClient(string endpointConfigurationName, EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public LegatoMiddlewareClient(Binding binding, EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public GuitarDataModel[] GetAllGuitars()
        {
            return Channel.GetAllGuitars();
        }
        
        public Task<GuitarDataModel[]> GetAllGuitarsAsync()
        {
            return Channel.GetAllGuitarsAsync();
        }
        
        public string[] GetAllVendors()
        {
            return Channel.GetAllVendors();
        }
        
        public Task<string[]> GetAllVendorsAsync()
        {
            return Channel.GetAllVendorsAsync();
        }
        
        public GuitarDataModel[] GetGuitarsByPrice(short from, short to)
        {
            return Channel.GetGuitarsByPrice(from, to);
        }
        
        public Task<GuitarDataModel[]> GetGuitarsByPriceAsync(short from, short to)
        {
            return Channel.GetGuitarsByPriceAsync(from, to);
        }
        
        public GuitarDataModel[] GetGuitarsByVendor(string vendor)
        {
            return Channel.GetGuitarsByVendor(vendor);
        }
        
        public Task<GuitarDataModel[]> GetGuitarsByVendorAsync(string vendor)
        {
            return Channel.GetGuitarsByVendorAsync(vendor);
        }
        
        public AcousticClassicalGuitarDataModel[] GetAllAcousticClassicalGuitars()
        {
            return Channel.GetAllAcousticClassicalGuitars();
        }
        
        public Task<AcousticClassicalGuitarDataModel[]> GetAllAcousticClassicalGuitarsAsync()
        {
            return Channel.GetAllAcousticClassicalGuitarsAsync();
        }
        
        public string[] GetAcousticClassicalGuitarVendors()
        {
            return Channel.GetAcousticClassicalGuitarVendors();
        }
        
        public Task<string[]> GetAcousticClassicalGuitarVendorsAsync()
        {
            return Channel.GetAcousticClassicalGuitarVendorsAsync();
        }
        
        public AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByPrice(short from, short to)
        {
            return Channel.GetAcousticClassicalGuitarsByPrice(from, to);
        }
        
        public Task<AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsByPriceAsync(short from, short to)
        {
            return Channel.GetAcousticClassicalGuitarsByPriceAsync(from, to);
        }
        
        public AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitarsByVendor(string vendor)
        {
            return Channel.GetAcousticClassicalGuitarsByVendor(vendor);
        }
        
        public Task<AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsByVendorAsync(string vendor)
        {
            return Channel.GetAcousticClassicalGuitarsByVendorAsync(vendor);
        }
        
        public AcousticWesternGuitarDataModel[] GetAllAcousticWesternGuitars()
        {
            return Channel.GetAllAcousticWesternGuitars();
        }
        
        public Task<AcousticWesternGuitarDataModel[]> GetAllAcousticWesternGuitarsAsync()
        {
            return Channel.GetAllAcousticWesternGuitarsAsync();
        }
        
        public string[] GetAcousticWesternGuitarVendors()
        {
            return Channel.GetAcousticWesternGuitarVendors();
        }
        
        public Task<string[]> GetAcousticWesternGuitarVendorsAsync()
        {
            return Channel.GetAcousticWesternGuitarVendorsAsync();
        }
        
        public AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByPrice(short from, short to)
        {
            return Channel.GetAcousticWesternGuitarsByPrice(from, to);
        }
        
        public Task<AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsByPriceAsync(short from, short to)
        {
            return Channel.GetAcousticWesternGuitarsByPriceAsync(from, to);
        }
        
        public AcousticWesternGuitarDataModel[] GetAcousticWesternGuitarsByVendor(string vendor)
        {
            return Channel.GetAcousticWesternGuitarsByVendor(vendor);
        }
        
        public Task<AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsByVendorAsync(string vendor)
        {
            return Channel.GetAcousticWesternGuitarsByVendorAsync(vendor);
        }
        
        public ElectricGuitarDataModel[] GetAllElectricGuitars()
        {
            return Channel.GetAllElectricGuitars();
        }
        
        public Task<ElectricGuitarDataModel[]> GetAllElectricGuitarsAsync()
        {
            return Channel.GetAllElectricGuitarsAsync();
        }
        
        public string[] GetElectricGuitarVendors()
        {
            return Channel.GetElectricGuitarVendors();
        }
        
        public Task<string[]> GetElectricGuitarVendorsAsync()
        {
            return Channel.GetElectricGuitarVendorsAsync();
        }
        
        public ElectricGuitarDataModel[] GetElectricGuitarsByPrice(short from, short to)
        {
            return Channel.GetElectricGuitarsByPrice(from, to);
        }
        
        public Task<ElectricGuitarDataModel[]> GetElectricGuitarsByPriceAsync(short from, short to)
        {
            return Channel.GetElectricGuitarsByPriceAsync(from, to);
        }
        
        public ElectricGuitarDataModel[] GetElectricGuitarsByVendor(string vendor)
        {
            return Channel.GetElectricGuitarsByVendor(vendor);
        }
        
        public Task<ElectricGuitarDataModel[]> GetElectricGuitarsByVendorAsync(string vendor)
        {
            return Channel.GetElectricGuitarsByVendorAsync(vendor);
        }
        
        public BassGuitarDataModel[] GetAllBassGuitars()
        {
            return Channel.GetAllBassGuitars();
        }
        
        public Task<BassGuitarDataModel[]> GetAllBassGuitarsAsync()
        {
            return Channel.GetAllBassGuitarsAsync();
        }
        
        public string[] GetBassGuitarVendors()
        {
            return Channel.GetBassGuitarVendors();
        }
        
        public Task<string[]> GetBassGuitarVendorsAsync()
        {
            return Channel.GetBassGuitarVendorsAsync();
        }
        
        public BassGuitarDataModel[] GetBassGuitarsByPrice(short from, short to)
        {
            return Channel.GetBassGuitarsByPrice(from, to);
        }
        
        public Task<BassGuitarDataModel[]> GetBassGuitarsByPriceAsync(short from, short to)
        {
            return Channel.GetBassGuitarsByPriceAsync(from, to);
        }
        
        public BassGuitarDataModel[] GetBassGuitarsByVendor(string vendor)
        {
            return Channel.GetBassGuitarsByVendor(vendor);
        }
        
        public Task<BassGuitarDataModel[]> GetBassGuitarsByVendorAsync(string vendor)
        {
            return Channel.GetBassGuitarsByVendorAsync(vendor);
        }
    }
}
