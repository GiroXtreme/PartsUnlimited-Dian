﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PartsUnlimited.Areas.Admin.Controllers
{
    //comentario remoto
    //Comentario local
    //Cambio 1
    //Cambio 3
    [Area(AdminConstants.Area)]
    [Authorize(AdminConstants.Role)]
    public abstract class AdminController : Controller
    {
    }
}
