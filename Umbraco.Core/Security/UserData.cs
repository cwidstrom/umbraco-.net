﻿using System;
using System.Runtime.Serialization;

namespace Umbraco.Core.Security
{
    /// <summary>
    /// Data structure used to store information in the authentication cookie
    /// </summary>
    [DataContract(Name = "userData", Namespace = "")]
    [Serializable]
    public class UserData
    {
        public UserData()
        {
            AllowedApplications = new string[] {};
            Roles = new string[] {};
        }

        /// <summary>
        /// Use this constructor to create/assign new UserData to the ticket
        /// </summary>
        /// <param name="sessionId">
        /// A unique id that is assigned to this ticket
        /// </param>
        public UserData(string sessionId)
        {
            SessionId = sessionId;
            AllowedApplications = new string[] { };
            Roles = new string[] { };
        }

        /// <summary>
        /// This is used to Id the current ticket which we can then use to mitigate csrf attacks
        /// and other things that require request validation.
        /// </summary>        
        [DataMember(Name = "sessionId")]
        public string SessionId { get; set; } 

        [DataMember(Name = "id")]
        public object Id { get; set; }
        
        [DataMember(Name = "roles")]
        public string[] Roles { get; set; }

        //public int SessionTimeout { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "name")]
        public string RealName { get; set; }

        [DataMember(Name = "startContent")]
        public int StartContentNode { get; set; }

        [DataMember(Name = "startMedia")]
        public int StartMediaNode { get; set; }

        [DataMember(Name = "allowedApps")]
        public string[] AllowedApplications { get; set; }

        [DataMember(Name = "culture")]
        public string Culture { get; set; }
    }
}