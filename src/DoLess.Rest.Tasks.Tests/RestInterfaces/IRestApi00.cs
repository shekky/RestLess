﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoLess.Rest.RestInterfaces
{
    using System;

    [BaseUrl("/api")]
    [Header("X-Scope", "Interface")]
    public interface IRestApi00
    {
        [Get("v1/app/books/{id}")]
        Task<string> UrlIdNotFound01(string name);

        [Get("v1/app/books/{id}")]
        Task UrlIdNotFound02([UrlId("name")] string id);

        [Get("v1/app/books/{id}/{name}")]
        System.Threading.Tasks.Task<string> UrlIdNotFound03(string name);

        [Get("v1/app/books/{id}/{name}/{foo}")]
        System.Threading.Tasks.Task UrlIdNotFound04(string name);

        [Get("v1/app/books/{id}/{name}/{foo}/test{end}")]
        Task<string> UrlIdNotFound05(string name);

        [Get("v1/app/books/{name}")]
        Task<string> UrlIdAlreadyExists01(string name, [UrlId("name")] string name01);

        [Get("v1/app/books/{id}/{name}")]
        Task<string> UrlIdAlreadyExists02(string id, string name, [UrlId("name")] string name01);

        [Get("v1/app/books/{id}/{name}")]
        Task<string> UrlIdAlreadyExists03(string id, [UrlId("name")] string name01, string name);

        [Get("v1/app/books/{id}/{name}")]
        Task<string> UrlIdAlreadyExists04(string id, [UrlId("name")] string name01, string name, [UrlId("id")] string id01);

        [Get("v1/app/books/{id}")]
        Task<string> MultipleRestAttributes01([UrlId("id")][Header("X-Test")]string name, string sortOrder);

        Task<string> MissingHttpAttribute01([UrlId("id")]string name);

        Task<string> MissingHttpAttribute02();

        [Header("X-test", "value")]
        Task<string> MissingHttpAttribute03();

        [Get("v1/app/books/{id}")]
        [Post("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute01();

        [Get("v1/app/books/{id}")]
        [Put("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute02();

        [Get("v1/app/books/{id}")]
        [Head("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute03();

        [Get("v1/app/books/{id}")]
        [Delete("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute04();

        [Get("v1/app/books/{id}")]
        [Options("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute05();

        [Get("v1/app/books/{id}")]
        [Patch("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute06();

        [Get("v1/app/books/{id}")]
        [Trace("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute07();

        [Post("v1/app/books/{id}/2")]
        [Put("v1/app/books/{id}/2")]
        Task<string> MultipleHttpAttribute08();

        [Get("/v1/app/}")]
        Task<string> MalformedUrlTemplate01();

        [Get("{/v1/app/")]
        Task<string> MalformedUrlTemplate02();

        [Get("/v1/{name{/id")]
        Task<string> MalformedUrlTemplate03();

        [Get("/v1/app{id")]
        Task<string> MalformedUrlTemplate04();

        [Get("}/v1/app/")]
        Task<string> MalformedUrlTemplate05();

        [Get("/v1/app/{me?thod}")]
        Task<string> MalformedUrlTemplate06();

        [Get("/v1/app/{me/thod}")]
        Task<string> MalformedUrlTemplate07();

        [Get("/v1/app/{me&thod}")]
        Task<string> MalformedUrlTemplate08();

        [Get("/v1/app/{me=thod}")]
        Task<string> MalformedUrlTemplate09();

        [Get("/v1/app")]
        string ReturnType01();

        [Get("/v1/app")]
        List<string> ReturnType02();

        [Get("/v1/app/{id}")]
        Task<string> GetSomeStuffWithHeader01(string id);

        [Get("/v1/app/{id}")]
        [Header("X-Scope", "Method")]
        Task<string> GetSomeStuffWithHeader02(string id);

        [Get("/v1/app/{id}")]
        [Header("X-Scope", "Method")]
        Task<string> GetSomeStuffWithHeader03(string id, [Header("X-Scope")] string scope);

        [Post("/v1/app/{id}")]
        Task<string> PostSomeStuffWithoutBody(string id);

        [Post("/v1/app/{id}")]
        Task<string> PostSomeStuffWithBody(string id, [Body] string body);

        [Delete("/v1/app/{id}")]
        Task<string> DeleteSomeStuff(string id);

        [Get("/v1/app/{id}")]
        Task<string> GetSomeStuff(string id);

        [Head("/v1/app/{id}")]
        Task<string> HeadSomeStuff(string id);

        [Options("/v1/app/{id}")]
        Task<string> OptionsSomeStuff(string id);

        [Patch("/v1/app/{id}")]
        Task<string> PatchSomeStuff(string id);

        [Post("/v1/app/{id}")]
        Task<string> PostSomeStuff(string id);

        [Put("/v1/app/{id}")]
        Task<string> PutSomeStuff(string id);

        [Trace("/v1/app/{id}")]
        Task<string> TraceSomeStuff(string id);
    }
}