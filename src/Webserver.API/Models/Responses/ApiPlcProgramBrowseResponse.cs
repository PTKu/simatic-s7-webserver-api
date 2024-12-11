﻿// Copyright (c) 2024, Siemens AG
//
// SPDX-License-Identifier: MIT
using System.Collections.Generic;

namespace Siemens.Simatic.S7.Webserver.API.Models.Responses
{
    /// <summary>
    /// ApiResponse (Jsonrpc,id) with a List of ApiPlcProgramData
    /// </summary>
    public class ApiPlcProgramBrowseResponse : ApiResultResponse<List<ApiPlcProgramData>>
    {
    }
}
