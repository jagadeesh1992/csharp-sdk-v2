/* 
 * DialMyCalls API
 *
 * The DialMyCalls API
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@dialmycalls.com
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

namespace IO.DialMyCalls.Model
{
    /// <summary>
    /// UpdateContactByIdParameters
    /// </summary>
    [DataContract]
    public partial class UpdateContactByIdParameters :  IEquatable<UpdateContactByIdParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactByIdParameters" /> class.
        /// </summary>
        /// <param name="Firstname">The contact&#39;s first name..</param>
        /// <param name="Lastname">The contact&#39;s last name..</param>
        /// <param name="Phone">(Required)  The contact&#39;s phone number..</param>
        /// <param name="Extension">The contact&#39;s phone extension..</param>
        /// <param name="Email">The contact&#39;s email address..</param>
        /// <param name="Extra1">Miscellaneous data about this contact..</param>
        /// <param name="Groups">List of group IDs that this contact should belong to..</param>
        public UpdateContactByIdParameters(string Firstname = null, string Lastname = null, string Phone = null, string Extension = null, string Email = null, string Extra1 = null, List<string> Groups = null)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Phone = Phone;
            this.Extension = Extension;
            this.Email = Email;
            this.Extra1 = Extra1;
            this.Groups = Groups;
        }
        
        /// <summary>
        /// The contact&#39;s first name.
        /// </summary>
        /// <value>The contact&#39;s first name.</value>
        [DataMember(Name="firstname", EmitDefaultValue=false)]
        public string Firstname { get; set; }
        /// <summary>
        /// The contact&#39;s last name.
        /// </summary>
        /// <value>The contact&#39;s last name.</value>
        [DataMember(Name="lastname", EmitDefaultValue=false)]
        public string Lastname { get; set; }
        /// <summary>
        /// (Required)  The contact&#39;s phone number.
        /// </summary>
        /// <value>(Required)  The contact&#39;s phone number.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// The contact&#39;s phone extension.
        /// </summary>
        /// <value>The contact&#39;s phone extension.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        /// <summary>
        /// The contact&#39;s email address.
        /// </summary>
        /// <value>The contact&#39;s email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Miscellaneous data about this contact.
        /// </summary>
        /// <value>Miscellaneous data about this contact.</value>
        [DataMember(Name="extra1", EmitDefaultValue=false)]
        public string Extra1 { get; set; }
        /// <summary>
        /// List of group IDs that this contact should belong to.
        /// </summary>
        /// <value>List of group IDs that this contact should belong to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateContactByIdParameters {\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Extra1: ").Append(Extra1).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(obj as UpdateContactByIdParameters);
        }

        /// <summary>
        /// Returns true if UpdateContactByIdParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateContactByIdParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateContactByIdParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Firstname == other.Firstname ||
                    this.Firstname != null &&
                    this.Firstname.Equals(other.Firstname)
                ) && 
                (
                    this.Lastname == other.Lastname ||
                    this.Lastname != null &&
                    this.Lastname.Equals(other.Lastname)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Extra1 == other.Extra1 ||
                    this.Extra1 != null &&
                    this.Extra1.Equals(other.Extra1)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
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
                if (this.Firstname != null)
                    hash = hash * 59 + this.Firstname.GetHashCode();
                if (this.Lastname != null)
                    hash = hash * 59 + this.Lastname.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Extra1 != null)
                    hash = hash * 59 + this.Extra1.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                return hash;
            }
        }
    }

}
