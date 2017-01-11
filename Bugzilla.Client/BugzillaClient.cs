using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bugzilla.Client.Models.Bug;
using Bugzilla.Client.Models.BugAttachment;
using Bugzilla.Client.Models.BugHistory;
using Bugzilla.Client.Models.BugzillaInformation;
using Bugzilla.Client.Models.Classification;
using Bugzilla.Client.Models.Comment;
using Bugzilla.Client.Models.Fields;
using Bugzilla.Client.Models.Login;
using Bugzilla.Client.Models.Products;
using Bugzilla.Client.Models.Users;
using Bugzilla.Client.Models.Version;
using Refit;

namespace Bugzilla.Client
{
    public class BugzillaClient
    {
        private readonly string _apiKey;
        private readonly IBugzillaClient _bugzillaClient;

        public BugzillaClient(string endpoint, string apiKey)
        {
            _apiKey = apiKey;
            _bugzillaClient = RestService.For<IBugzillaClient>(endpoint);
        }

        #region BugAttachment

        public async Task<RootBugAttachment> GetBugAttachmentsAsync(int id)
        {
            return await _bugzillaClient.GetBugAttachments(id, _apiKey);
        }

        #endregion

        #region Bug

        public async Task<RootBug> GetBugAsync(int id)
        {
            return await _bugzillaClient.GetBug(id, _apiKey);
        }

        public async Task<RootBug> GetBugsAsync(List<int> ids)
        {
            var delimitedIds = string.Join(",", ids);
            return await _bugzillaClient.GetBugs(delimitedIds, _apiKey);
        }

        public async Task CreateBugAsync(Bug bug)
        {
            await _bugzillaClient.CreateBug(bug, _apiKey);
        }

        public async Task UpdateBugAsync(Bug bug)
        {
            await _bugzillaClient.UpdateBug(bug, bug.Id, _apiKey);
        }

        #endregion

        #region BugHistory
        public async Task<RootBugHistory> GetBugHistoryAsync(int id)
        {
            return await _bugzillaClient.GetBugHistory(id, _apiKey);
        }

        public async Task<RootBugHistory> GetBugHistoryByNewSinceAsync(int id, DateTime dateTime)
        {
            return await _bugzillaClient.GetBugHistoryByNewSince(id, dateTime, _apiKey);
        }
        #endregion

        #region BugzillaInformation

        public async Task<RootVersion> GetVersionAsync()
        {
            return await _bugzillaClient.GetVersion(_apiKey);
        }

        public async Task<RootExtensions> GetExtensionsAsync()
        {
            return await _bugzillaClient.GetExtensions(_apiKey);
        }

        public async Task<RootTimeZone> GetTimeZoneAsync()
        {
            return await _bugzillaClient.GetTimeZone(_apiKey);
        }

        public async Task<RootTime> GetTimeAsync()
        {
            return await _bugzillaClient.GetTime(_apiKey);
        }

        public async Task<RootParameters> GetParametersAsync()
        {
            return await _bugzillaClient.GetParameters(_apiKey);
        }

        public async Task<RootLastAuditTime> GetLastAuditTimeAsync()
        {
            return await _bugzillaClient.GetLastAuditTime(_apiKey);
        }

        #endregion

        #region Classifications

        public async Task<RootClassification> GetClassificationAsync(string name)
        {
            return await _bugzillaClient.GetClassificationByName(name, _apiKey);
        }

        public async Task<RootClassification> GetClassificationAsync(int id)
        {
            return await _bugzillaClient.GetClassificationById(id, _apiKey);
        }

        #endregion

        #region Comments

        public async Task<RootComments> GetCommentsAsync(int id)
        {
            return await _bugzillaClient.GetComments(id, _apiKey);
        }

        #endregion

        #region Fields

        public async Task<RootFields> GetFieldsAsync()
        {
            return await _bugzillaClient.GetFields(_apiKey);
        }

        public async Task<RootFields> GetFieldsAsync(int id)
        {
            return await _bugzillaClient.GetFieldsById(id, _apiKey);
        }

        public async Task<RootFields> GetFieldsAsync(string name)
        {
            return await _bugzillaClient.GetFieldsByName(name, _apiKey);
        }
        #endregion

        #region Login
        public async Task<RootLogin> LoginAsync(string email, string password)
        {
            return await _bugzillaClient.Login(email, password);
        }

        public async Task LogoutAsync(string token)
        {
            await _bugzillaClient.Logout(token);
        }
        #endregion

        #region Products

        public async Task<RootProducts> GetProductsSelectableAsync()
        {
            return await _bugzillaClient.GetProductsSelectable(_apiKey);
        }

        public async Task<RootProducts> GetProductsEnterableAsync()
        {
            return await _bugzillaClient.GetProductsEnterable(_apiKey);
        }

        public async Task<RootProducts> GetProductsAccessibleAsync()
        {
            return await _bugzillaClient.GetProductsAccessible(_apiKey);
        }

        public async Task<RootProduct> GetProductByTypeAsync(string productType)
        {
            return await _bugzillaClient.GetProductByType(productType, _apiKey);
        }

        public async Task<RootProduct> GetProductByIdAsync(int id)
        {
            return await _bugzillaClient.GetProductById(id, _apiKey);
        }

        public async Task<RootProduct> GetProductByNameAsync(string name)
        {
            return await _bugzillaClient.GetProductByType(name, _apiKey);
        }
        #endregion

        #region Users

        public async Task<RootUsers> GetUser(int id)
        {
            return await _bugzillaClient.GetUserById(id, _apiKey);
        }

        public async Task<RootUsers> GetUser(string name)
        {
            return await _bugzillaClient.GetUserByName(name, _apiKey);
        }
        #endregion
    }
}