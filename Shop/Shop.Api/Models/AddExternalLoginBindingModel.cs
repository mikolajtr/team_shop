﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Shop.Models
{
    public partial class AddExternalLoginBindingModel
    {
        private string _externalAccessToken;
        
        /// <summary>
        /// Required.
        /// </summary>
        public string ExternalAccessToken
        {
            get { return this._externalAccessToken; }
            set { this._externalAccessToken = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AddExternalLoginBindingModel
        /// class.
        /// </summary>
        public AddExternalLoginBindingModel()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AddExternalLoginBindingModel
        /// class with required arguments.
        /// </summary>
        public AddExternalLoginBindingModel(string externalAccessToken)
            : this()
        {
            if (externalAccessToken == null)
            {
                throw new ArgumentNullException("externalAccessToken");
            }
            this.ExternalAccessToken = externalAccessToken;
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type AddExternalLoginBindingModel
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.ExternalAccessToken == null)
            {
                throw new ArgumentNullException("ExternalAccessToken");
            }
            if (this.ExternalAccessToken != null)
            {
                outputObject["ExternalAccessToken"] = this.ExternalAccessToken;
            }
            return outputObject;
        }
    }
}
