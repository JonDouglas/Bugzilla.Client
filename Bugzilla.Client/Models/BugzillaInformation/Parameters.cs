using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class Parameters
    {
        [JsonProperty("allowemailchange")]
        public string Allowemailchange { get; set; }

        [JsonProperty("attachment_base")]
        public string AttachmentBase { get; set; }

        [JsonProperty("commentonchange_resolution")]
        public string CommentonchangeResolution { get; set; }

        [JsonProperty("commentonduplicate")]
        public string Commentonduplicate { get; set; }

        [JsonProperty("cookiepath")]
        public string Cookiepath { get; set; }

        [JsonProperty("defaultopsys")]
        public string Defaultopsys { get; set; }

        [JsonProperty("defaultplatform")]
        public string Defaultplatform { get; set; }

        [JsonProperty("defaultpriority")]
        public string Defaultpriority { get; set; }

        [JsonProperty("defaultseverity")]
        public string Defaultseverity { get; set; }

        [JsonProperty("duplicate_or_move_bug_status")]
        public string DuplicateOrMoveBugStatus { get; set; }

        [JsonProperty("emailregexpdesc")]
        public string Emailregexpdesc { get; set; }

        [JsonProperty("emailsuffix")]
        public string Emailsuffix { get; set; }

        [JsonProperty("letsubmitterchoosemilestone")]
        public string Letsubmitterchoosemilestone { get; set; }

        [JsonProperty("letsubmitterchoosepriority")]
        public string Letsubmitterchoosepriority { get; set; }

        [JsonProperty("mailfrom")]
        public string Mailfrom { get; set; }

        [JsonProperty("maintainer")]
        public string Maintainer { get; set; }

        [JsonProperty("maxattachmentsize")]
        public string Maxattachmentsize { get; set; }

        [JsonProperty("maxlocalattachment")]
        public string Maxlocalattachment { get; set; }

        [JsonProperty("musthavemilestoneonaccept")]
        public string Musthavemilestoneonaccept { get; set; }

        [JsonProperty("noresolveonopenblockers")]
        public string Noresolveonopenblockers { get; set; }

        [JsonProperty("password_complexity")]
        public string PasswordComplexity { get; set; }

        [JsonProperty("rememberlogin")]
        public string Rememberlogin { get; set; }

        [JsonProperty("requirelogin")]
        public string Requirelogin { get; set; }

        [JsonProperty("search_allow_no_criteria")]
        public string SearchAllowNoCriteria { get; set; }

        [JsonProperty("urlbase")]
        public string Urlbase { get; set; }

        [JsonProperty("useclassification")]
        public string Useclassification { get; set; }

        [JsonProperty("usemenuforusers")]
        public string Usemenuforusers { get; set; }

        [JsonProperty("useqacontact")]
        public string Useqacontact { get; set; }

        [JsonProperty("use_see_also")]
        public string UseSeeAlso { get; set; }

        [JsonProperty("usestatuswhiteboard")]
        public string Usestatuswhiteboard { get; set; }

        [JsonProperty("usetargetmilestone")]
        public string Usetargetmilestone { get; set; }
    }
}