﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Rest;
using Shop;

namespace Shop
{
    public partial class ShopApi : ServiceClient<ShopApi>, IShopApi
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IAccount _account;
        
        public virtual IAccount Account
        {
            get { return this._account; }
        }
        
        private ICategories _categories;
        
        public virtual ICategories Categories
        {
            get { return this._categories; }
        }
        
        private IImages _images;
        
        public virtual IImages Images
        {
            get { return this._images; }
        }
        
        private IOrders _orders;
        
        public virtual IOrders Orders
        {
            get { return this._orders; }
        }
        
        private IProducts _products;
        
        public virtual IProducts Products
        {
            get { return this._products; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        public ShopApi()
            : base()
        {
            this._account = new Account(this);
            this._categories = new Categories(this);
            this._images = new Images(this);
            this._orders = new Orders(this);
            this._products = new Products(this);
            this._baseUri = new Uri("http://localhost:55300");
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ShopApi(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._account = new Account(this);
            this._categories = new Categories(this);
            this._images = new Images(this);
            this._orders = new Orders(this);
            this._products = new Products(this);
            this._baseUri = new Uri("http://localhost:55300");
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ShopApi(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._account = new Account(this);
            this._categories = new Categories(this);
            this._images = new Images(this);
            this._orders = new Orders(this);
            this._products = new Products(this);
            this._baseUri = new Uri("http://localhost:55300");
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ShopApi(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ShopApi(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the ShopApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public ShopApi(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}