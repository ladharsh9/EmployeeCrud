﻿using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCrud.Controllers
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private HttpStatusCode badRequest;

        public HttpStatusCodeResult(HttpStatusCode badRequest)
        {
            this.badRequest = badRequest;
        }
    }
}