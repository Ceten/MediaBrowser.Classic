﻿using System.ComponentModel;
using MediaBrowser.Library;
using MediaBrowser.Model.Configuration;
using MediaBrowser.Model.Entities;
using Microsoft.MediaCenter.UI;
using ProtoBuf;
using System;
using System.Runtime.Serialization;
using PropertyChangedEventHandler = System.ComponentModel.PropertyChangedEventHandler;

namespace MediaBrowser.Model.Dto
{
    /// <summary>
    /// Class UserDto
    /// </summary>
    [ProtoContract]
    public class UserDto : INotifyPropertyChanged, IItemDto
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [ProtoMember(1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [ProtoMember(2)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the primary image tag.
        /// </summary>
        /// <value>The primary image tag.</value>
        [ProtoMember(3)]
        public Guid? PrimaryImageTag { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has password.
        /// </summary>
        /// <value><c>true</c> if this instance has password; otherwise, <c>false</c>.</value>
        [ProtoMember(4)]
        public bool HasPassword { get; set; }

        /// <summary>
        /// Gets or sets the last login date.
        /// </summary>
        /// <value>The last login date.</value>
        [ProtoMember(5)]
        public DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// Gets or sets the last activity date.
        /// </summary>
        /// <value>The last activity date.</value>
        [ProtoMember(6)]
        public DateTime? LastActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        [ProtoMember(7)]
        public UserConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the primary image aspect ratio.
        /// </summary>
        /// <value>The primary image aspect ratio.</value>
        [ProtoMember(8)]
        public double? PrimaryImageAspectRatio { get; set; }
        
        /// <summary>
        /// Gets a value indicating whether this instance has primary image.
        /// </summary>
        /// <value><c>true</c> if this instance has primary image; otherwise, <c>false</c>.</value>
        [IgnoreDataMember]
        public bool HasPrimaryImage
        {
            get { return PrimaryImageTag.HasValue; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
