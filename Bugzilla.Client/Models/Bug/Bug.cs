using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Bug
{
    public class Bug
    {
        [JsonProperty("actual_time")]
        public int ActualTime { get; set; }

        [JsonProperty("alias")]
        public IList<object> Alias { get; set; }

        [JsonProperty("assigned_to")]
        public string AssignedTo { get; set; }

        [JsonProperty("assigned_to_detail")]
        public AssignedToDetail AssignedToDetail { get; set; }

        [JsonProperty("blocks")]
        public IList<object> Blocks { get; set; }

        [JsonProperty("cc")]
        public IList<string> Cc { get; set; }

        [JsonProperty("cc_detail")]
        public IList<CcDetail> CcDetail { get; set; }

        [JsonProperty("cf_bug_regression")]
        public string CfBugRegression { get; set; }

        [JsonProperty("cf_bug_regression_build")]
        public string CfBugRegressionBuild { get; set; }

        [JsonProperty("cf_tags")]
        public string CfTags { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_detail")]
        public CreatorDetail CreatorDetail { get; set; }

        [JsonProperty("deadline")]
        public object Deadline { get; set; }

        [JsonProperty("depends_on")]
        public IList<object> DependsOn { get; set; }

        [JsonProperty("dupe_of")]
        public object DupeOf { get; set; }

        [JsonProperty("estimated_time")]
        public int EstimatedTime { get; set; }

        [JsonProperty("flags")]
        public IList<object> Flags { get; set; }

        [JsonProperty("groups")]
        public IList<string> Groups { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_cc_accessible")]
        public bool IsCcAccessible { get; set; }

        [JsonProperty("is_confirmed")]
        public bool IsConfirmed { get; set; }

        [JsonProperty("is_creator_accessible")]
        public bool IsCreatorAccessible { get; set; }

        [JsonProperty("is_open")]
        public bool IsOpen { get; set; }

        [JsonProperty("keywords")]
        public IList<object> Keywords { get; set; }

        [JsonProperty("last_change_time")]
        public DateTime LastChangeTime { get; set; }

        [JsonProperty("op_sys")]
        public string OpSys { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("qa_contact")]
        public string QaContact { get; set; }

        [JsonProperty("qa_contact_detail")]
        public object QaContactDetail { get; set; }

        [JsonProperty("remaining_time")]
        public int RemainingTime { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("see_also")]
        public IList<object> SeeAlso { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("target_milestone")]
        public string TargetMilestone { get; set; }

        [JsonProperty("update_token")]
        public string UpdateToken { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("whiteboard")]
        public string Whiteboard { get; set; }
    }
}