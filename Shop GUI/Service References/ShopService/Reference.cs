﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_GUI.ShopService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Shop_Server")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int quantField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Shop_GUI.ShopService.OrderState stateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Shop_GUI.ShopService.Title titleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                if ((this.dateField.Equals(value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quant {
            get {
                return this.quantField;
            }
            set {
                if ((this.quantField.Equals(value) != true)) {
                    this.quantField = value;
                    this.RaisePropertyChanged("quant");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Shop_GUI.ShopService.OrderState state {
            get {
                return this.stateField;
            }
            set {
                if ((this.stateField.Equals(value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Shop_GUI.ShopService.Title title {
            get {
                return this.titleField;
            }
            set {
                if ((this.titleField.Equals(value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderState", Namespace="http://schemas.datacontract.org/2004/07/Shop_Server")]
    public enum OrderState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WaitingExpediton = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dispatched = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DispatchWillOccur = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Title", Namespace="http://schemas.datacontract.org/2004/07/Shop_Server")]
    public enum Title : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        LotR = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GoT = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CProgramming = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AIBasicApproach = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RemotingForDummies = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShopService.IShopService", CallbackContract=typeof(Shop_GUI.ShopService.IShopServiceCallback))]
    public interface IShopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/getOrders", ReplyAction="http://tempuri.org/IShopService/getOrdersResponse")]
        System.Collections.Generic.List<Shop_GUI.ShopService.Order> getOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/getOrders", ReplyAction="http://tempuri.org/IShopService/getOrdersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Shop_GUI.ShopService.Order>> getOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/getStocks", ReplyAction="http://tempuri.org/IShopService/getStocksResponse")]
        System.Collections.Generic.Dictionary<Shop_GUI.ShopService.Title, int> getStocks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/getStocks", ReplyAction="http://tempuri.org/IShopService/getStocksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<Shop_GUI.ShopService.Title, int>> getStocksAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/addOrder")]
        void addOrder(string name, string addr, string email, int quant, Shop_GUI.ShopService.Title t);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/addOrder")]
        System.Threading.Tasks.Task addOrderAsync(string name, string addr, string email, int quant, Shop_GUI.ShopService.Title t);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/warehouseDispatch")]
        void warehouseDispatch(Shop_GUI.ShopService.Title t, int quant);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/warehouseDispatch")]
        System.Threading.Tasks.Task warehouseDispatchAsync(Shop_GUI.ShopService.Title t, int quant);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/orderArrived")]
        void orderArrived(Shop_GUI.ShopService.Title t, int quant);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/orderArrived")]
        System.Threading.Tasks.Task orderArrivedAsync(Shop_GUI.ShopService.Title t, int quant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Subscribe", ReplyAction="http://tempuri.org/IShopService/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Subscribe", ReplyAction="http://tempuri.org/IShopService/SubscribeResponse")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Unsubscribe", ReplyAction="http://tempuri.org/IShopService/UnsubscribeResponse")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShopService/Unsubscribe", ReplyAction="http://tempuri.org/IShopService/UnsubscribeResponse")]
        System.Threading.Tasks.Task UnsubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShopServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/OrderUpdated")]
        void OrderUpdated(System.Collections.Generic.List<Shop_GUI.ShopService.Order> orders, System.Collections.Generic.Dictionary<Shop_GUI.ShopService.Title, int> stocks);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShopService/OrderCompleted")]
        void OrderCompleted(Shop_GUI.ShopService.Order o);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShopServiceChannel : Shop_GUI.ShopService.IShopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShopServiceClient : System.ServiceModel.DuplexClientBase<Shop_GUI.ShopService.IShopService>, Shop_GUI.ShopService.IShopService {
        
        public ShopServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Shop_GUI.ShopService.Order> getOrders() {
            return base.Channel.getOrders();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Shop_GUI.ShopService.Order>> getOrdersAsync() {
            return base.Channel.getOrdersAsync();
        }
        
        public System.Collections.Generic.Dictionary<Shop_GUI.ShopService.Title, int> getStocks() {
            return base.Channel.getStocks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<Shop_GUI.ShopService.Title, int>> getStocksAsync() {
            return base.Channel.getStocksAsync();
        }
        
        public void addOrder(string name, string addr, string email, int quant, Shop_GUI.ShopService.Title t) {
            base.Channel.addOrder(name, addr, email, quant, t);
        }
        
        public System.Threading.Tasks.Task addOrderAsync(string name, string addr, string email, int quant, Shop_GUI.ShopService.Title t) {
            return base.Channel.addOrderAsync(name, addr, email, quant, t);
        }
        
        public void warehouseDispatch(Shop_GUI.ShopService.Title t, int quant) {
            base.Channel.warehouseDispatch(t, quant);
        }
        
        public System.Threading.Tasks.Task warehouseDispatchAsync(Shop_GUI.ShopService.Title t, int quant) {
            return base.Channel.warehouseDispatchAsync(t, quant);
        }
        
        public void orderArrived(Shop_GUI.ShopService.Title t, int quant) {
            base.Channel.orderArrived(t, quant);
        }
        
        public System.Threading.Tasks.Task orderArrivedAsync(Shop_GUI.ShopService.Title t, int quant) {
            return base.Channel.orderArrivedAsync(t, quant);
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void Unsubscribe() {
            base.Channel.Unsubscribe();
        }
        
        public System.Threading.Tasks.Task UnsubscribeAsync() {
            return base.Channel.UnsubscribeAsync();
        }
    }
}
