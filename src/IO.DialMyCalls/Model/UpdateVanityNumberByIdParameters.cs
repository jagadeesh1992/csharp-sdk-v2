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
    /// UpdateVanityNumberByIdParameters
    /// </summary>
    [DataContract]
    public partial class UpdateVanityNumberByIdParameters :  IEquatable<UpdateVanityNumberByIdParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVanityNumberByIdParameters" /> class.
        /// </summary>
        /// <param name="CallOptions">The options to include when the number is called.  If an option is not included it will be turned off.  Option values should be boolean.  Possible values are: &#39;voicemail&#39; (Leave A Message), &#39;ptt&#39; (Push To Talk), &#39;optin&#39; (Opt-In), &#39;repeat&#39; (Repeat Your Message) - - Note: Optout cannot be removed without prior authorization.  Please contact customer support for this..</param>
        /// <param name="RecordingSource">Where the recording will be generated from.  (specific, lastsent, lastuploaded).</param>
        /// <param name="SpecificRecordingId">Unique identifier for the recording if recording_source is set to specific..</param>
        /// <param name="PlayCta">Setting this to true our system will play the prompts for keys to be pushed..</param>
        /// <param name="PttNumberId">This is a verified caller id that is on your account.  This will be used if PTT option is used..</param>
        public UpdateVanityNumberByIdParameters(List<string> CallOptions = null, string RecordingSource = null, Guid? SpecificRecordingId = null, bool? PlayCta = null, Guid? PttNumberId = null)
        {
            this.CallOptions = CallOptions;
            this.RecordingSource = RecordingSource;
            this.SpecificRecordingId = SpecificRecordingId;
            this.PlayCta = PlayCta;
            this.PttNumberId = PttNumberId;
        }
        
        /// <summary>
        /// The options to include when the number is called.  If an option is not included it will be turned off.  Option values should be boolean.  Possible values are: &#39;voicemail&#39; (Leave A Message), &#39;ptt&#39; (Push To Talk), &#39;optin&#39; (Opt-In), &#39;repeat&#39; (Repeat Your Message) - - Note: Optout cannot be removed without prior authorization.  Please contact customer support for this.
        /// </summary>
        /// <value>The options to include when the number is called.  If an option is not included it will be turned off.  Option values should be boolean.  Possible values are: &#39;voicemail&#39; (Leave A Message), &#39;ptt&#39; (Push To Talk), &#39;optin&#39; (Opt-In), &#39;repeat&#39; (Repeat Your Message) - - Note: Optout cannot be removed without prior authorization.  Please contact customer support for this.</value>
        [DataMember(Name="call_options", EmitDefaultValue=false)]
        public List<string> CallOptions { get; set; }
        /// <summary>
        /// Where the recording will be generated from.  (specific, lastsent, lastuploaded)
        /// </summary>
        /// <value>Where the recording will be generated from.  (specific, lastsent, lastuploaded)</value>
        [DataMember(Name="recording_source", EmitDefaultValue=false)]
        public string RecordingSource { get; set; }
        /// <summary>
        /// Unique identifier for the recording if recording_source is set to specific.
        /// </summary>
        /// <value>Unique identifier for the recording if recording_source is set to specific.</value>
        [DataMember(Name="specific_recording_id", EmitDefaultValue=false)]
        public Guid? SpecificRecordingId { get; set; }
        /// <summary>
        /// Setting this to true our system will play the prompts for keys to be pushed.
        /// </summary>
        /// <value>Setting this to true our system will play the prompts for keys to be pushed.</value>
        [DataMember(Name="play_cta", EmitDefaultValue=false)]
        public bool? PlayCta { get; set; }
        /// <summary>
        /// This is a verified caller id that is on your account.  This will be used if PTT option is used.
        /// </summary>
        /// <value>This is a verified caller id that is on your account.  This will be used if PTT option is used.</value>
        [DataMember(Name="ptt_number_id", EmitDefaultValue=false)]
        public Guid? PttNumberId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVanityNumberByIdParameters {\n");
            sb.Append("  CallOptions: ").Append(CallOptions).Append("\n");
            sb.Append("  RecordingSource: ").Append(RecordingSource).Append("\n");
            sb.Append("  SpecificRecordingId: ").Append(SpecificRecordingId).Append("\n");
            sb.Append("  PlayCta: ").Append(PlayCta).Append("\n");
            sb.Append("  PttNumberId: ").Append(PttNumberId).Append("\n");
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
            return this.Equals(obj as UpdateVanityNumberByIdParameters);
        }

        /// <summary>
        /// Returns true if UpdateVanityNumberByIdParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateVanityNumberByIdParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVanityNumberByIdParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CallOptions == other.CallOptions ||
                    this.CallOptions != null &&
                    this.CallOptions.SequenceEqual(other.CallOptions)
                ) && 
                (
                    this.RecordingSource == other.RecordingSource ||
                    this.RecordingSource != null &&
                    this.RecordingSource.Equals(other.RecordingSource)
                ) && 
                (
                    this.SpecificRecordingId == other.SpecificRecordingId ||
                    this.SpecificRecordingId != null &&
                    this.SpecificRecordingId.Equals(other.SpecificRecordingId)
                ) && 
                (
                    this.PlayCta == other.PlayCta ||
                    this.PlayCta != null &&
                    this.PlayCta.Equals(other.PlayCta)
                ) && 
                (
                    this.PttNumberId == other.PttNumberId ||
                    this.PttNumberId != null &&
                    this.PttNumberId.Equals(other.PttNumberId)
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
                if (this.CallOptions != null)
                    hash = hash * 59 + this.CallOptions.GetHashCode();
                if (this.RecordingSource != null)
                    hash = hash * 59 + this.RecordingSource.GetHashCode();
                if (this.SpecificRecordingId != null)
                    hash = hash * 59 + this.SpecificRecordingId.GetHashCode();
                if (this.PlayCta != null)
                    hash = hash * 59 + this.PlayCta.GetHashCode();
                if (this.PttNumberId != null)
                    hash = hash * 59 + this.PttNumberId.GetHashCode();
                return hash;
            }
        }
    }

}