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
    /// VersionCreated
    /// </summary>
    [DataContract]
    public partial class VersionCreated :  IEquatable<VersionCreated>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionCreated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VersionCreated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionCreated" /> class.
        /// </summary>
        /// <param name="Jsonapi">Jsonapi.</param>
        /// <param name="Data">Data (required).</param>
        /// <param name="Included">Included.</param>
        /// <param name="Links">Links (required).</param>
        public VersionCreated(JsonApiVersionJsonapi Jsonapi = null, Version Data = null, List<JsonApiResource> Included = null, JsonApiLinksSelf Links = null)
        {
            // to ensure "Data" is required (not null)
            if (Data == null)
            {
                throw new InvalidDataException("Data is a required property for VersionCreated and cannot be null");
            }
            else
            {
                this.Data = Data;
            }
            // to ensure "Links" is required (not null)
            if (Links == null)
            {
                throw new InvalidDataException("Links is a required property for VersionCreated and cannot be null");
            }
            else
            {
                this.Links = Links;
            }
            this.Jsonapi = Jsonapi;
            this.Included = Included;
        }
        
        /// <summary>
        /// Gets or Sets Jsonapi
        /// </summary>
        [DataMember(Name="jsonapi", EmitDefaultValue=false)]
        public JsonApiVersionJsonapi Jsonapi { get; set; }
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Version Data { get; set; }
        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public List<JsonApiResource> Included { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public JsonApiLinksSelf Links { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionCreated {\n");
            sb.Append("  Jsonapi: ").Append(Jsonapi).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(obj as VersionCreated);
        }

        /// <summary>
        /// Returns true if VersionCreated instances are equal
        /// </summary>
        /// <param name="other">Instance of VersionCreated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionCreated other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Jsonapi == other.Jsonapi ||
                    this.Jsonapi != null &&
                    this.Jsonapi.Equals(other.Jsonapi)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Included == other.Included ||
                    this.Included != null &&
                    this.Included.SequenceEqual(other.Included)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
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
                if (this.Jsonapi != null)
                    hash = hash * 59 + this.Jsonapi.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Included != null)
                    hash = hash * 59 + this.Included.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
            }
        }
    }

}

