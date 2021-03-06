﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanetWrox.Ui.ReviewServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Review", Namespace="http://schemas.datacontract.org/2004/07/PlanetWrox.Service")]
    [System.SerializableAttribute()]
    public partial class Review : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AuthorizedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GenreIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SummaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UpdateDateTimeField;
        
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
        public bool Authorized {
            get {
                return this.AuthorizedField;
            }
            set {
                if ((this.AuthorizedField.Equals(value) != true)) {
                    this.AuthorizedField = value;
                    this.RaisePropertyChanged("Authorized");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreateDateTime {
            get {
                return this.CreateDateTimeField;
            }
            set {
                if ((this.CreateDateTimeField.Equals(value) != true)) {
                    this.CreateDateTimeField = value;
                    this.RaisePropertyChanged("CreateDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int GenreId {
            get {
                return this.GenreIdField;
            }
            set {
                if ((this.GenreIdField.Equals(value) != true)) {
                    this.GenreIdField = value;
                    this.RaisePropertyChanged("GenreId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Summary {
            get {
                return this.SummaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SummaryField, value) != true)) {
                    this.SummaryField = value;
                    this.RaisePropertyChanged("Summary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UpdateDateTime {
            get {
                return this.UpdateDateTimeField;
            }
            set {
                if ((this.UpdateDateTimeField.Equals(value) != true)) {
                    this.UpdateDateTimeField = value;
                    this.RaisePropertyChanged("UpdateDateTime");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReviewServiceReference.IReviewService")]
    public interface IReviewService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewService/GetAll", ReplyAction="http://tempuri.org/IReviewService/GetAllResponse")]
        PlanetWrox.Ui.ReviewServiceReference.Review[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewService/GetById", ReplyAction="http://tempuri.org/IReviewService/GetByIdResponse")]
        PlanetWrox.Ui.ReviewServiceReference.Review GetById(int reviewId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReviewService/GetByGenre", ReplyAction="http://tempuri.org/IReviewService/GetByGenreResponse")]
        PlanetWrox.Ui.ReviewServiceReference.Review[] GetByGenre(int genreId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReviewServiceChannel : PlanetWrox.Ui.ReviewServiceReference.IReviewService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReviewServiceClient : System.ServiceModel.ClientBase<PlanetWrox.Ui.ReviewServiceReference.IReviewService>, PlanetWrox.Ui.ReviewServiceReference.IReviewService {
        
        public ReviewServiceClient() {
        }
        
        public ReviewServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReviewServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReviewServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PlanetWrox.Ui.ReviewServiceReference.Review[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public PlanetWrox.Ui.ReviewServiceReference.Review GetById(int reviewId) {
            return base.Channel.GetById(reviewId);
        }
        
        public PlanetWrox.Ui.ReviewServiceReference.Review[] GetByGenre(int genreId) {
            return base.Channel.GetByGenre(genreId);
        }
    }
}
