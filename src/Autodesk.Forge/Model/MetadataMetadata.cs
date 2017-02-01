/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model
{
    /// <summary>
    /// metadata definition
    /// </summary>
    [DataContract]
    public partial class MetadataMetadata :  IEquatable<MetadataMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MetadataMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataMetadata" /> class.
        /// </summary>
        /// <param name="Name">Name of the model view (required).</param>
        /// <param name="Guid">Unique identifier for the model view (required).</param>
        public MetadataMetadata(string Name = null, string Guid = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for MetadataMetadata and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Guid" is required (not null)
            if (Guid == null)
            {
                throw new InvalidDataException("Guid is a required property for MetadataMetadata and cannot be null");
            }
            else
            {
                this.Guid = Guid;
            }
        }
        
        /// <summary>
        /// Name of the model view
        /// </summary>
        /// <value>Name of the model view</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Unique identifier for the model view
        /// </summary>
        /// <value>Unique identifier for the model view</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetadataMetadata {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MetadataMetadata);
        }

        /// <summary>
        /// Returns true if MetadataMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of MetadataMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetadataMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                return hash;
            }
        }
    }

}

