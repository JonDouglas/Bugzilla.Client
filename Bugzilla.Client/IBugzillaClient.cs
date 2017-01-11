using System;
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
    [Headers("Content-Type: application/json")]
    public interface IBugzillaClient
    {
        //Overall need to finish create/update/delete methods and add token to requests for secondary use-case
        #region BugAttachment

        [Get("/bug/{id}/attachment?api_key={apiKey}")]
        Task<RootBugAttachment> GetBugAttachments(int id, string apiKey);

        #endregion

        #region Bug

        [Get("/bug/{id}?api_key={apiKey}")]
        Task<RootBug> GetBug(int id, string apiKey);

        [Get("/bug?id={ids}&api_key={apiKey}")]
        Task<RootBug> GetBugs(string ids, string apiKey);

        [Post("/bug?api_key={apiKey}")]
        Task CreateBug([Body] Bug bug, string apiKey);

        [Put("/bug/{id}?api_key={apiKey}")]
        Task UpdateBug([Body] Bug bug, int id, string apiKey);

        #endregion

        #region BugHistory
        [Get("/bug/{id}/history?api_key={apiKey}")]
        Task<RootBugHistory> GetBugHistory(int id, string apiKey);

        [Get("/bug/{id}/history?new_since={dateTime}&api_key={apiKey}")]
        Task<RootBugHistory> GetBugHistoryByNewSince(int id, DateTime dateTime, string apiKey);

        #endregion

        #region BugzillaInformation

        [Get("/version?api_key={apiKey}")]
        Task<RootVersion> GetVersion(string apiKey);

        [Get("/extensions?api_key={apiKey}")]
        Task<RootExtensions> GetExtensions(string apiKey);

        [Get("/timezone?api_key={apiKey}")]
        Task<RootTimeZone> GetTimeZone(string apiKey);

        [Get("/time?api_key={apiKey}")]
        Task<RootTime> GetTime(string apiKey);

        [Get("/parameters?api_key={apiKey}")]
        Task<RootParameters> GetParameters(string apiKey);

        [Get("/last_audit_time?api_key={apiKey}")]
        Task<RootLastAuditTime> GetLastAuditTime(string apiKey);

        #endregion

        #region Classificaitons

        [Get("/classification/{name}?api_key={apiKey}")]
        Task<RootClassification> GetClassificationByName(string name, string apiKey);

        [Get("/classification/{id}?api_key={apiKey}")]
        Task<RootClassification> GetClassificationById(int id, string apiKey);

        #endregion

        #region Comments

        [Get("/bug/{id}/comment?api_key={apiKey}")]
        Task<RootComments> GetComments(int id, string apiKey);

        [Post("/bug/{id}/comment?api_key={apiKey}")]
        Task CreateComment([Body] Comment comment, int id, string apiKey);

        #endregion

        #region Fields

        [Get("/field/bug?api_key={apiKey}")]
        Task<RootFields> GetFields(string apiKey);

        [Get("/field/bug/{id}?api_key={apiKey}")]
        Task<RootFields> GetFieldsById(int id, string apiKey);

        [Get("/field/bug/{name}?api_key={apiKey}")]
        Task<RootFields> GetFieldsByName(string name, string apiKey);

        #endregion

        #region Login

        [Get("/login?login={email}&password={password}")]
        Task<RootLogin> Login(string email, string password);

        [Get("/logout?token={token}")]
        Task Logout(string token);


        #endregion

        #region Products
        [Get("/product_selectable?api_key={apiKey}")]
        Task<RootProducts> GetProductsSelectable(string apiKey);

        [Get("/product_enterable?api_key={apiKey}")]
        Task<RootProducts> GetProductsEnterable(string apiKey);

        [Get("/product_accessible?api_key={apiKey}")]
        Task<RootProducts> GetProductsAccessible(string apiKey);

        [Get("/product?type={productType}&api_key={apiKey}")]
        Task<RootProduct> GetProductByType(string productType, string apiKey);

        [Get("/product/{id}?api_key={apiKey}")]
        Task<RootProduct> GetProductById(int id, string apiKey);

        [Get("/product/{name}?api_key={apiKey}")]
        Task<RootProduct> GetProductByName(string name, string apiKey);

        //TODO Return product by ids or names: http://bugzilla.readthedocs.io/en/latest/api/core/v1/product.html#get-product
        #endregion

        #region Users

        [Get("/user/{id}?api_key={apiKey}")]
        Task<RootUsers> GetUserById(int id, string apiKey);

        [Get("/user/{name}?api_key={apiKey}")]
        Task<RootUsers> GetUserByName(string name, string apiKey);

        //TODO Return users by ids or names: http://bugzilla.readthedocs.io/en/latest/api/core/v1/user.html#get-user

        #endregion
    }
}