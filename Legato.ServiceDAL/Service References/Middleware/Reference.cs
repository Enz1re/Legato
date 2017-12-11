﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Legato.ServiceDAL.Middleware {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Middleware.ILegatoMiddleware")]
    public interface ILegatoMiddleware {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitarResponse")]
        void AddAcousticClassicalGuitar(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task AddAcousticClassicalGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitarResponse")]
        void EditAcousticClassicalGuitar(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task EditAcousticClassicalGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitarResponse")]
        void RemoveAcousticClassicalGuitar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticClassicalGuitarResponse")]
        System.Threading.Tasks.Task RemoveAcousticClassicalGuitarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticClassicalGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        string[] GetAcousticClassicalGuitarVendors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        int GetAcousticClassicalGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticClassicalGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitarResponse")]
        void AddAcousticWesternGuitar(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task AddAcousticWesternGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitarResponse")]
        void EditAcousticWesternGuitar(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task EditAcousticWesternGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitarResponse")]
        void RemoveAcousticWesternGuitar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveAcousticWesternGuitarResponse")]
        System.Threading.Tasks.Task RemoveAcousticWesternGuitarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedAcousticWesternGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        string[] GetAcousticWesternGuitarVendors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        int GetAcousticWesternGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetAcousticWesternGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddElectricGuitarResponse")]
        void AddElectricGuitar(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddElectricGuitarResponse")]
        System.Threading.Tasks.Task AddElectricGuitarAsync(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditElectricGuitarResponse")]
        void EditElectricGuitar(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditElectricGuitarResponse")]
        System.Threading.Tasks.Task EditElectricGuitarAsync(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitarResponse")]
        void RemoveElectricGuitar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveElectricGuitarResponse")]
        System.Threading.Tasks.Task RemoveElectricGuitarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedElectricGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        string[] GetElectricGuitarVendors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        int GetElectricGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetElectricGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddBassGuitarResponse")]
        void AddBassGuitar(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/AddBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/AddBassGuitarResponse")]
        System.Threading.Tasks.Task AddBassGuitarAsync(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditBassGuitarResponse")]
        void EditBassGuitar(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/EditBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/EditBassGuitarResponse")]
        System.Threading.Tasks.Task EditBassGuitarAsync(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitarResponse")]
        void RemoveBassGuitar(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitar", ReplyAction="http://tempuri.org/ILegatoMiddleware/RemoveBassGuitarResponse")]
        System.Threading.Tasks.Task RemoveBassGuitarAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitars", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetSortedBassGuitarsResponse")]
        System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        string[] GetBassGuitarVendors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendors", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarVendorsResponse")]
        System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        int GetBassGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantity", ReplyAction="http://tempuri.org/ILegatoMiddleware/GetBassGuitarQuantityResponse")]
        System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILegatoMiddlewareChannel : Legato.ServiceDAL.Middleware.ILegatoMiddleware, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LegatoMiddlewareClient : System.ServiceModel.ClientBase<Legato.ServiceDAL.Middleware.ILegatoMiddleware>, Legato.ServiceDAL.Middleware.ILegatoMiddleware {
        
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
        
        public void AddAcousticClassicalGuitar(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            base.Channel.AddAcousticClassicalGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task AddAcousticClassicalGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.AddAcousticClassicalGuitarAsync(guitar);
        }
        
        public void EditAcousticClassicalGuitar(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            base.Channel.EditAcousticClassicalGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task EditAcousticClassicalGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel guitar) {
            return base.Channel.EditAcousticClassicalGuitarAsync(guitar);
        }
        
        public void RemoveAcousticClassicalGuitar(int id) {
            base.Channel.RemoveAcousticClassicalGuitar(id);
        }
        
        public System.Threading.Tasks.Task RemoveAcousticClassicalGuitarAsync(int id) {
            return base.Channel.RemoveAcousticClassicalGuitarAsync(id);
        }
        
        public Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetAcousticClassicalGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticClassicalGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetAcousticClassicalGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[] GetSortedAcousticClassicalGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticClassicalGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticClassicalGuitarDataModel[]> GetSortedAcousticClassicalGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticClassicalGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetAcousticClassicalGuitarVendors() {
            return base.Channel.GetAcousticClassicalGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticClassicalGuitarVendorsAsync() {
            return base.Channel.GetAcousticClassicalGuitarVendorsAsync();
        }
        
        public int GetAcousticClassicalGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticClassicalGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticClassicalGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticClassicalGuitarQuantityAsync(filter);
        }
        
        public void AddAcousticWesternGuitar(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            base.Channel.AddAcousticWesternGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task AddAcousticWesternGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.AddAcousticWesternGuitarAsync(guitar);
        }
        
        public void EditAcousticWesternGuitar(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            base.Channel.EditAcousticWesternGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task EditAcousticWesternGuitarAsync(Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel guitar) {
            return base.Channel.EditAcousticWesternGuitarAsync(guitar);
        }
        
        public void RemoveAcousticWesternGuitar(int id) {
            base.Channel.RemoveAcousticWesternGuitar(id);
        }
        
        public System.Threading.Tasks.Task RemoveAcousticWesternGuitarAsync(int id) {
            return base.Channel.RemoveAcousticWesternGuitarAsync(id);
        }
        
        public Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetAcousticWesternGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticWesternGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetAcousticWesternGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetAcousticWesternGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[] GetSortedAcousticWesternGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticWesternGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.AcousticWesternGuitarDataModel[]> GetSortedAcousticWesternGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedAcousticWesternGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetAcousticWesternGuitarVendors() {
            return base.Channel.GetAcousticWesternGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAcousticWesternGuitarVendorsAsync() {
            return base.Channel.GetAcousticWesternGuitarVendorsAsync();
        }
        
        public int GetAcousticWesternGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticWesternGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetAcousticWesternGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetAcousticWesternGuitarQuantityAsync(filter);
        }
        
        public void AddElectricGuitar(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            base.Channel.AddElectricGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task AddElectricGuitarAsync(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.AddElectricGuitarAsync(guitar);
        }
        
        public void EditElectricGuitar(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            base.Channel.EditElectricGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task EditElectricGuitarAsync(Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel guitar) {
            return base.Channel.EditElectricGuitarAsync(guitar);
        }
        
        public void RemoveElectricGuitar(int id) {
            base.Channel.RemoveElectricGuitar(id);
        }
        
        public System.Threading.Tasks.Task RemoveElectricGuitarAsync(int id) {
            return base.Channel.RemoveElectricGuitarAsync(id);
        }
        
        public Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetElectricGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetElectricGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetElectricGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetElectricGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[] GetSortedElectricGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedElectricGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.ElectricGuitarDataModel[]> GetSortedElectricGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedElectricGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetElectricGuitarVendors() {
            return base.Channel.GetElectricGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetElectricGuitarVendorsAsync() {
            return base.Channel.GetElectricGuitarVendorsAsync();
        }
        
        public int GetElectricGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetElectricGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetElectricGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetElectricGuitarQuantityAsync(filter);
        }
        
        public void AddBassGuitar(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            base.Channel.AddBassGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task AddBassGuitarAsync(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.AddBassGuitarAsync(guitar);
        }
        
        public void EditBassGuitar(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            base.Channel.EditBassGuitar(guitar);
        }
        
        public System.Threading.Tasks.Task EditBassGuitarAsync(Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel guitar) {
            return base.Channel.EditBassGuitarAsync(guitar);
        }
        
        public void RemoveBassGuitar(int id) {
            base.Channel.RemoveBassGuitar(id);
        }
        
        public System.Threading.Tasks.Task RemoveBassGuitarAsync(int id) {
            return base.Channel.RemoveBassGuitarAsync(id);
        }
        
        public Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetBassGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetBassGuitars(filter, lowerBound, upperBound);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetBassGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound) {
            return base.Channel.GetBassGuitarsAsync(filter, lowerBound, upperBound);
        }
        
        public Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[] GetSortedBassGuitars(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedBassGuitars(filter, lowerBound, upperBound, sorting);
        }
        
        public System.Threading.Tasks.Task<Legato.MiddlewareContracts.DataContracts.BassGuitarDataModel[]> GetSortedBassGuitarsAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter, int lowerBound, int upperBound, Legato.MiddlewareContracts.DataContracts.SortingDataModel sorting) {
            return base.Channel.GetSortedBassGuitarsAsync(filter, lowerBound, upperBound, sorting);
        }
        
        public string[] GetBassGuitarVendors() {
            return base.Channel.GetBassGuitarVendors();
        }
        
        public System.Threading.Tasks.Task<string[]> GetBassGuitarVendorsAsync() {
            return base.Channel.GetBassGuitarVendorsAsync();
        }
        
        public int GetBassGuitarQuantity(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetBassGuitarQuantity(filter);
        }
        
        public System.Threading.Tasks.Task<int> GetBassGuitarQuantityAsync(Legato.MiddlewareContracts.DataContracts.FilterDataModel filter) {
            return base.Channel.GetBassGuitarQuantityAsync(filter);
        }
    }
}
