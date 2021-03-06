// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A custom image.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomImageFragment : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the CustomImageFragment class.
        /// </summary>
        public CustomImageFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomImageFragment class.
        /// </summary>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="vm">The virtual machine from which the image is to be
        /// created.</param>
        /// <param name="vhd">The VHD from which the image is to be
        /// created.</param>
        /// <param name="description">The description of the custom
        /// image.</param>
        /// <param name="author">The author of the custom image.</param>
        /// <param name="managedImageId">The Managed Image Id backing the
        /// custom image.</param>
        /// <param name="managedSnapshotId">The Managed Snapshot Id backing the
        /// custom image.</param>
        /// <param name="dataDiskStorageInfo">Storage information about the
        /// data disks present in the custom image</param>
        /// <param name="customImagePlan">Storage information about the plan
        /// related to this custom image</param>
        /// <param name="isPlanAuthorized">Whether or not the custom images
        /// underlying offer/plan has been enabled for programmatic
        /// deployment</param>
        public CustomImageFragment(IDictionary<string, string> tags = default(IDictionary<string, string>), CustomImagePropertiesFromVmFragment vm = default(CustomImagePropertiesFromVmFragment), CustomImagePropertiesCustomFragment vhd = default(CustomImagePropertiesCustomFragment), string description = default(string), string author = default(string), string managedImageId = default(string), string managedSnapshotId = default(string), IList<DataDiskStorageTypeInfoFragment> dataDiskStorageInfo = default(IList<DataDiskStorageTypeInfoFragment>), CustomImagePropertiesFromPlanFragment customImagePlan = default(CustomImagePropertiesFromPlanFragment), bool? isPlanAuthorized = default(bool?))
            : base(tags)
        {
            Vm = vm;
            Vhd = vhd;
            Description = description;
            Author = author;
            ManagedImageId = managedImageId;
            ManagedSnapshotId = managedSnapshotId;
            DataDiskStorageInfo = dataDiskStorageInfo;
            CustomImagePlan = customImagePlan;
            IsPlanAuthorized = isPlanAuthorized;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine from which the image is to be
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vm")]
        public CustomImagePropertiesFromVmFragment Vm { get; set; }

        /// <summary>
        /// Gets or sets the VHD from which the image is to be created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vhd")]
        public CustomImagePropertiesCustomFragment Vhd { get; set; }

        /// <summary>
        /// Gets or sets the description of the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author of the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.author")]
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Managed Image Id backing the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedImageId")]
        public string ManagedImageId { get; set; }

        /// <summary>
        /// Gets or sets the Managed Snapshot Id backing the custom image.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedSnapshotId")]
        public string ManagedSnapshotId { get; set; }

        /// <summary>
        /// Gets or sets storage information about the data disks present in
        /// the custom image
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataDiskStorageInfo")]
        public IList<DataDiskStorageTypeInfoFragment> DataDiskStorageInfo { get; set; }

        /// <summary>
        /// Gets or sets storage information about the plan related to this
        /// custom image
        /// </summary>
        [JsonProperty(PropertyName = "properties.customImagePlan")]
        public CustomImagePropertiesFromPlanFragment CustomImagePlan { get; set; }

        /// <summary>
        /// Gets or sets whether or not the custom images underlying offer/plan
        /// has been enabled for programmatic deployment
        /// </summary>
        [JsonProperty(PropertyName = "properties.isPlanAuthorized")]
        public bool? IsPlanAuthorized { get; set; }

    }
}
