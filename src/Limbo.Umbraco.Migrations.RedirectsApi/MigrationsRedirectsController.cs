using System;
using System.Collections.Generic;
using System.Web.Http;
using Limbo.Umbraco.MigrationsApi.Controllers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using NPoco;
using Skybrud.Umbraco.Redirects.Models.Database;
using Umbraco.Core.Composing;
using Umbraco.Core.Persistence;
using Umbraco.Core.Scoping;

namespace Limbo.Umbraco.Migrations.RedirectsApi {

    public class MigrationsRedirectsController : MigrationsControllerBase {

        [HttpGet]
        [Route("api/limbo/migrations/redirects")]
        public object GetRedirects() {

            if (!HasAccess(out string reason)) return Unauthorized(reason);

            using (IScope scope = Current.ScopeProvider.CreateScope(autoComplete: true)) {

                // Fetch non-regex redirects from the database
                Sql<ISqlContext> sql = scope.SqlContext
                    .Sql()
                    .Select<RedirectItemDto>()
                    .From<RedirectItemDto>();

                // Make the call to the database
                List<RedirectItemDto> dtos = scope.Database
                    .Fetch<RedirectItemDto>(sql);

                // Return the redirects as JSON
                return JArray.FromObject(dtos, new JsonSerializer {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            }

        }

        [HttpGet]
        [Route("api/limbo/migrations/redirects/{id:int}")]
        public object GetRedirectById(int id) {

            if (!HasAccess(out string reason)) return Unauthorized(reason);

            using (IScope scope = Current.ScopeProvider.CreateScope(autoComplete: true)) {

                // Fetch non-regex redirects from the database
                Sql<ISqlContext> sql = scope.SqlContext
                    .Sql()
                    .Select<RedirectItemDto>()
                    .From<RedirectItemDto>()
                    .Where<RedirectItemDto>(x => x.Id == id);

                // Make the call to the database
                RedirectItemDto dto = scope.Database.FirstOrDefault<RedirectItemDto>(sql);

                return dto is null ? NotFound() : (object) Serialize(dto);

            }

        }

        [HttpGet]
        [Route("api/limbo/migrations/redirects/{key:guid}")]
        public object GetRedirectByKey(Guid key) {

            if (!HasAccess(out string reason)) return Unauthorized(reason);

            using (IScope scope = Current.ScopeProvider.CreateScope(autoComplete: true)) {

                // Fetch non-regex redirects from the database
                Sql<ISqlContext> sql = scope.SqlContext
                    .Sql()
                    .Select<RedirectItemDto>()
                    .From<RedirectItemDto>()
                    .Where<RedirectItemDto>(x => x.Key == key);

                // Make the call to the database
                RedirectItemDto dto = scope.Database
                    .FirstOrDefault<RedirectItemDto>(sql);

                return dto is null ? NotFound() : (object) Serialize(dto);

            }

        }

        private static JToken Serialize(object value) {
            return JToken.FromObject(value, new JsonSerializer {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

    }

}